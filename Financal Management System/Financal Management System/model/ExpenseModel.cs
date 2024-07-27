using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Financal_Management_System.model
{
    public class ExpenseModel
    {
        public int Expense_ID { get; set; }
        public int Invoices { get; set; }
        public int Rent { get; set; }
        public int Tax { get; set;}
        public int Other_Expense { get; set; }
        public int Monthly_Product_Cost { get; set; }
        public int Total_Monthly_Salary { get; set; }
        public DateTime Dates {  get; set; }


    }
}
