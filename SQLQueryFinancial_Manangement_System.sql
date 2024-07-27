-- Expense tablosunu oluþturma
CREATE TABLE Expense( 
    Expense_ID int IDENTITY(1,1) PRIMARY KEY, 
    Invoices int, 
    Rent int, 
    Tax int, 
    Other_Expense int, 
    Monthly_Product_Cost int, 
    Total_Monthly_Salary int, 
    Dates date 
); 

-- Employee tablosunu oluþturma
CREATE TABLE Employee( 
    Employee_ID int IDENTITY(1,1) PRIMARY KEY, 
    Names nvarchar(50), 
    Salary int, 
    Position nvarchar(50) 
); 

-- Revenue tablosunu oluþturma
CREATE TABLE Revenue( 
    Revenue_ID int IDENTITY(1,1) PRIMARY KEY, 
    Montly_Revenue int, 
    Dates date 
); 

-- Orders tablosunu oluþturma
CREATE TABLE Orders( 
    Order_ID int IDENTITY(1,1) PRIMARY KEY, 
    Daily_Amount int, 
    Dates date, 
    Revenue_ID int FOREIGN KEY REFERENCES Revenue (Revenue_ID) 
); 

-- Product tablosunu oluþturma
CREATE TABLE Product( 
    Product_ID int IDENTITY(1,1) PRIMARY KEY, 
    Product_Name nvarchar(50)
); 

-- Product_Of tablosunu oluþturma
CREATE TABLE Product_Of( 
    Product_ID int FOREIGN KEY REFERENCES Product (Product_ID), 
    Order_ID int FOREIGN KEY REFERENCES Orders (Order_ID) 
); 

-- Prepare tablosunu oluþturma
CREATE TABLE Prepare( 
    Employee_ID int FOREIGN KEY REFERENCES Employee(Employee_ID), 
    Order_ID int FOREIGN KEY REFERENCES Orders (Order_ID) 
); 

-- Financial_Situation tablosunu oluþturma
CREATE TABLE Financial_Situation(
    FS_ID int IDENTITY(1,1) PRIMARY KEY,
    Dates Date,
    Gross_Profit int,
    Revenue_ID int FOREIGN KEY REFERENCES Revenue (Revenue_ID),
    Expense_ID int FOREIGN KEY REFERENCES Expense (Expense_ID)
);


-- Çalýþan verilerini ekleme
INSERT INTO Employee (Names, Salary, Position) 
VALUES 
('Ahmet Yýlmaz', 5000, 'Worker'), 
('Mehmet Kaya', 5000, 'Worker'), 
('Ayþe Demir', 5000, 'Worker'), 
('Fatma Çelik', 5000, 'Worker'), 
('Mustafa Öztürk', 5000, 'Worker'), 
('Emine Arslan', 5000, 'Worker'), 
('Ali Ak', 5000, 'Worker'), 
('Zeynep Yýldýz', 4000, 'Cleaner'), 
('Merve Özdemir', 4000, 'Cleaner'), 
('Kemal Can', 10000, 'Boss'); 

-- Rastgele sayýlar üretmek için geçici tablo oluþturma
CREATE TABLE #RandomNumbers ( 
    RandomNumber INT 
);

-- 4 haneli rastgele sayýlarý üreten döngü
DECLARE @i INT = 1; 
WHILE @i <= 42  -- Toplam 42 kayýt eklemek için
BEGIN 
    INSERT INTO #RandomNumbers (RandomNumber) 
    VALUES (1000 + CONVERT(INT, RAND() * 9000));  -- 1000 ile 9999 arasýnda rastgele sayý üretir
    SET @i = @i + 1; 
END;

-- Tüm çalýþan maaþlarýný toplama
DECLARE @TotalMonthlySalary INT; 
SELECT @TotalMonthlySalary = SUM(Salary) FROM Employee;

-- Verileri eklemek için tarih döngüsü
DECLARE @StartDate DATE = '2022-01-01'; -- Baþlangýç tarihi
DECLARE @EndDate DATE = DATEADD(MONTH, 41, @StartDate); -- 42 ay sonra bitiþ tarihi
DECLARE @CurrentDate DATE = @StartDate;

WHILE @CurrentDate <= @EndDate
BEGIN
    -- Rastgele deðerler üret
    DECLARE @Invoices INT = (SELECT TOP 1 RandomNumber FROM #RandomNumbers ORDER BY NEWID());
    DECLARE @Tax INT = (SELECT TOP 1 RandomNumber FROM #RandomNumbers ORDER BY NEWID());
    DECLARE @Other_Expense INT = (SELECT TOP 1 RandomNumber FROM #RandomNumbers ORDER BY NEWID());
    DECLARE @Monthly_Product_Cost INT = (SELECT TOP 1 RandomNumber FROM #RandomNumbers ORDER BY NEWID());
    DECLARE @Montly_Revenue INT = (SELECT TOP 1 RandomNumber FROM #RandomNumbers ORDER BY NEWID()) + 10000; -- Daha yüksek gelirler için

    -- Expense tablosuna veri ekle
    INSERT INTO Expense (Dates, Invoices, Rent, Tax, Other_Expense, Monthly_Product_Cost, Total_Monthly_Salary)
    VALUES (@CurrentDate, @Invoices, 4500, @Tax, @Other_Expense, @Monthly_Product_Cost, @TotalMonthlySalary);

    -- Revenue tablosuna veri ekle
    INSERT INTO Revenue (Dates, Montly_Revenue)
    VALUES (@CurrentDate, @Montly_Revenue);

    -- Bir sonraki aya geç
    SET @CurrentDate = DATEADD(MONTH, 1, @CurrentDate);
END;

-- Geçici tabloyu sil
DROP TABLE #RandomNumbers;

-- Orders tablosunu doldur
DECLARE @OrderDate DATE = '2022-01-01';
DECLARE @MaxRevenueID INT;
WHILE @OrderDate <= '2025-06-01'
BEGIN
    DECLARE @DailyAmount INT = FLOOR(RAND() * 9000) + 1000;
    SET @MaxRevenueID = (SELECT TOP 1 Revenue_ID FROM Revenue ORDER BY NEWID());

    INSERT INTO Orders (Daily_Amount, Dates, Revenue_ID)
    VALUES (@DailyAmount, @OrderDate, @MaxRevenueID);

    SET @OrderDate = DATEADD(DAY, 1, @OrderDate);
END;

-- Revenue tablosunu güncelle
INSERT INTO Revenue (Montly_Revenue, Dates)
SELECT SUM(Daily_Amount) AS Monthly_Revenue,
       MAX(DATEADD(DAY, -1, DATEADD(MONTH, DATEDIFF(MONTH, 0, Dates) + 1, 0))) AS Dates
FROM Orders
WHERE Dates > (SELECT MAX(Dates) FROM Revenue) -- Sadece mevcut en son tarihten sonraki verileri al
GROUP BY DATEADD(MONTH, DATEDIFF(MONTH, 0, Dates), 0);

-- Orders tablosunu güncelle
UPDATE Orders
SET Revenue_ID = R.Revenue_ID
FROM Orders O
INNER JOIN Revenue R ON MONTH(O.Dates) = MONTH(R.Dates) AND YEAR(O.Dates) = YEAR(R.Dates);

-- Revenue tablosunu güncelle
UPDATE Revenue
SET Montly_Revenue = MonthlyOrderAmounts.TotalOrderAmount
FROM Revenue
INNER JOIN (
    SELECT DATEADD(MONTH, DATEDIFF(MONTH, 0, O.Dates), 0) AS MonthStart,
           SUM(O.Daily_Amount) AS TotalOrderAmount
    FROM Orders O
    GROUP BY DATEADD(MONTH, DATEDIFF(MONTH, 0, O.Dates), 0)
) AS MonthlyOrderAmounts ON MonthlyOrderAmounts.MonthStart = DATEADD(MONTH, DATEDIFF(MONTH, 0, Revenue.Dates), 0);


-- Product tablosunu doldur
INSERT INTO Product(Product_Name) 
VALUES  
('Hamburger'), 
('Pizza'), 
('French Fries'), 
('Kebab'), 
('Sushi'), 
('Pasta'), 
('Doner'), 
('Fried Chicken'), 
('Fruit Juice'), 
('Soda'), 
('Cola'), 
('Fanta'), 
('Water'), 
('Cake'), 
('Magnolia'), 
('Suffle'), 
('Pudding'), 
('Croissant'), 
('Baklava'), 
('Ice Cream');

-- Product_Of tablosunu doldur
DECLARE @MaxOrderID INT = (SELECT MAX(Order_ID) FROM Orders);
DECLARE @MaxProductID INT = (SELECT MAX(Product_ID) FROM Product);
DECLARE @Counter INT = 1;

WHILE @Counter <= @MaxOrderID
BEGIN
    DECLARE @NumberOfProducts INT = (SELECT RAND() * 5 + 1);
    WHILE @NumberOfProducts > 0
    BEGIN
        DECLARE @ProductID INT = (SELECT RAND() * @MaxProductID);
        INSERT INTO Product_Of (Product_ID, Order_ID)
        VALUES (@ProductID, @Counter);
        SET @NumberOfProducts = @NumberOfProducts - 1;
    END;
    SET @Counter = @Counter + 1;
END;

-- Prepare tablosunu doldur
CREATE TABLE #OrderedOrders ( 
    RowNumber INT IDENTITY(1,1), 
    Order_ID INT 
);

INSERT INTO #OrderedOrders (Order_ID)
SELECT Order_ID
FROM Orders
ORDER BY Order_ID;

INSERT INTO Prepare (Employee_ID, Order_ID)
SELECT  
    (ABS(CHECKSUM(NEWID())) % 7) + 1 AS Employee_ID, -- 1 ile 7 arasýnda rastgele bir tam sayý seçme
    OO.Order_ID
FROM  
    #OrderedOrders OO;

DROP TABLE #OrderedOrders;

-- Financial_Situation tablosunu doldur
DECLARE @RevenueID INT;
DECLARE @ExpenseID INT;
DECLARE @GrossProfit INT;
DECLARE @Date DATE;
DECLARE @CounterFS INT = 1;

DECLARE Financial_Cursor CURSOR FOR
SELECT R.Revenue_ID, E.Expense_ID, R.Montly_Revenue - (E.Invoices + E.Rent + E.Tax + E.Other_Expense + E.Monthly_Product_Cost + E.Total_Monthly_Salary) AS Gross_Profit, R.Dates
FROM Revenue R
JOIN Expense E ON R.Dates = E.Dates;

OPEN Financial_Cursor;
FETCH NEXT FROM Financial_Cursor INTO @RevenueID, @ExpenseID, @GrossProfit, @Date;

WHILE @@FETCH_STATUS = 0
BEGIN
    INSERT INTO Financial_Situation (Dates, Gross_Profit, Revenue_ID, Expense_ID)
    VALUES (@Date, @GrossProfit, @RevenueID, @ExpenseID);

    FETCH NEXT FROM Financial_Cursor INTO @RevenueID, @ExpenseID, @GrossProfit, @Date;
END;

CLOSE Financial_Cursor;
DEALLOCATE Financial_Cursor;

CREATE TABLE loginTable( 
    id int IDENTITY(1,1) PRIMARY KEY, 
    UserId varchar(50), 
    Pasword varchar(50), 
    Position varchar(50)
)

INSERT INTO loginTable (UserId, Pasword, Position) 
VALUES 
('nazife', '12345', 'Boss'), 
('tuna', '12345', 'Manager'); 

