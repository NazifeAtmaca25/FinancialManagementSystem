using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Financal_Management_System
{
    public partial class HomePage : Form
    {
        public HomePage()
        {
            InitializeComponent();
        }

        private void btn_employee_Click(object sender, EventArgs e)
        {
            Employee employee = new Employee();
            employee.Show();
            this.Hide();
        }

        private void btn_Product_Click(object sender, EventArgs e)
        {
            Product product = new Product();
            product.Show();
            this.Hide();
        }

        private void btn_Order_Click(object sender, EventArgs e)
        {
            Order order = new Order();
            order.Show(); 
            this.Hide();
        }

        private void btn_Revenue_Click(object sender, EventArgs e)
        {
            Revenue revenue = new Revenue();
            revenue.Show();
            this.Hide();
        }

        private void btn_Expense_Click(object sender, EventArgs e)
        {
            Expense expense = new Expense();
            expense.Show();
            this.Hide();
        }

        private void btn_financial_Click(object sender, EventArgs e)
        {
            Financial_Situation financial=new Financial_Situation();
            financial.Show();  
            this.Hide();
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
            this.Hide();
        }

        private void HomePage_Load(object sender, EventArgs e)
        {

        }
    }
}
