using Financal_Management_System.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Financal_Management_System
{
    public partial class Financial_Situation : Form
    {
        SqlConnection con = new SqlConnection("Data Source=localhost; Initial Catalog=Financial_Management_System;User ID=sa;password=12345");

        public Financial_Situation()
        {
            InitializeComponent();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            HomePage homePage = new HomePage();
            homePage.Show();
            this.Hide();
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
            this.Hide();
        }

        private void Financial_Situation_Load(object sender, EventArgs e)
        {
           
            dataGridView1.DataSource = bringRecord();
        
            
        }

        public List<FinancialModel> bringRecord()
        {
            List<FinancialModel> financialList = new List<FinancialModel>();
            con.Open();

            // SQL sorgusu ile Financial_Situation, Expense ve Revenue tablolarını birleştirerek verileri al
            SqlCommand cmd = new SqlCommand(@"SELECT fs.FS_ID, 
                                              (r.Montly_Revenue - COALESCE((e.Invoices + e.Rent + e.Tax + e.Other_Expense + e.Monthly_Product_Cost + e.Total_Monthly_Salary), 0)) AS Gross_Profit,
                                              fs.Dates AS FS_Date, 
                                              e.Invoices, e.Rent, e.Tax, e.Other_Expense, e.Monthly_Product_Cost, e.Total_Monthly_Salary, 
                                              r.Montly_Revenue
                                      FROM Financial_Situation fs
                                      LEFT JOIN Expense e ON fs.Dates = e.Dates
                                      LEFT JOIN Revenue r ON fs.Dates = r.Dates", con);
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                FinancialModel financialModel = new FinancialModel();

                financialModel.FS_ID = int.Parse(reader["FS_ID"].ToString());
                financialModel.Gross_Profit = int.Parse(reader["Gross_Profit"].ToString());
                financialModel.Dates = Convert.ToDateTime(reader["FS_Date"]);

                ExpenseModel expense = new ExpenseModel();
                expense.Invoices = int.Parse(reader["Invoices"].ToString());
                expense.Rent = int.Parse(reader["Rent"].ToString());
                expense.Tax = int.Parse(reader["Tax"].ToString());
                expense.Other_Expense = int.Parse(reader["Other_Expense"].ToString());
                expense.Monthly_Product_Cost = int.Parse(reader["Monthly_Product_Cost"].ToString());
                expense.Total_Monthly_Salary = int.Parse(reader["Total_Monthly_Salary"].ToString());

                financialModel.Expense = expense.Invoices + expense.Rent + expense.Tax + expense.Other_Expense + expense.Monthly_Product_Cost + expense.Total_Monthly_Salary;

                financialModel.Revenue = reader["Montly_Revenue"] != DBNull.Value ? int.Parse(reader["Montly_Revenue"].ToString()) : 0;

                financialList.Add(financialModel);
            }

            reader.Close(); // Okuyucuyu kapat
            con.Close(); // Bağlantıyı kapat

            return financialList;
        }

        public List<FinancialModel> CalculateRevenue()
        {
            List<FinancialModel> financialList = new List<FinancialModel>();

            con.Open();
            SqlCommand command = new SqlCommand("select * from Revenue", con);
            SqlDataReader dr = command.ExecuteReader();
            while (dr.Read())
            {
                FinancialModel financial = new FinancialModel();

                financial.Revenue = int.Parse(dr["Montly_Revenue"].ToString());
                financialList.Add(financial);
            }
            con.Close();
            return financialList;

        }

        public List<FinancialModel> calculateExpense()
        {
            List<FinancialModel> financialList = new List<FinancialModel>();

            con.Open();
            SqlCommand com = new SqlCommand("select * from Expense", con);
            SqlDataReader reader = com.ExecuteReader();
            int total = 0;
            while (reader.Read())
            {
                FinancialModel financial = new FinancialModel();

                
                ExpenseModel expense = new ExpenseModel();
                expense.Invoices = int.Parse(reader["Invoices"].ToString());
                expense.Rent = int.Parse(reader["Rent"].ToString());
                expense.Tax = int.Parse(reader["Tax"].ToString());
                expense.Other_Expense = int.Parse(reader["Other_Expense"].ToString());
                expense.Monthly_Product_Cost = int.Parse(reader["Monthly_Product_Cost"].ToString());
                expense.Total_Monthly_Salary = int.Parse(reader["Total_Monthly_Salary"].ToString());
                total = expense.Invoices + expense.Rent + expense.Tax + expense.Other_Expense + expense.Total_Monthly_Salary;
                financial.Expense = total;
                financialList.Add(financial);
            }
            con.Close();
            return financialList;

        }
        public int calculateSalary()
        {
            int totalSalary = 0;
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from Employee", con);
            SqlDataReader reader = cmd.ExecuteReader();


            while (reader.Read())
            {
                EmployeeModel employee = new EmployeeModel();
                employee.Salary = int.Parse(reader["Salary"].ToString());
                totalSalary += employee.Salary;
            }
            con.Close();
            return totalSalary;
        }
    }
}
