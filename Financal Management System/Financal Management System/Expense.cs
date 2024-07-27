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
    public partial class Expense : Form
    {
        SqlConnection con=new SqlConnection("Data Source=localhost;Initial Catalog=Financial_Management_System;User ID=sa;password=12345");
        public Expense()
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Expense_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = bringRecord();
        }

        public List<ExpenseModel> bringRecord()
        {
            List<ExpenseModel> expenseList = new List<ExpenseModel>();
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from Expense", con);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                ExpenseModel expense = new ExpenseModel();
                expense.Expense_ID = int.Parse(reader["Expense_ID"].ToString());
                expense.Invoices = int.Parse(reader["Invoices"].ToString());
                expense.Rent = int.Parse(reader["Rent"].ToString());
                expense.Tax = int.Parse(reader["Tax"].ToString());
                expense.Other_Expense = int.Parse(reader["Other_Expense"].ToString());
                expense.Monthly_Product_Cost = int.Parse(reader["Monthly_Product_Cost"].ToString());
                expense.Total_Monthly_Salary= int.Parse(reader["Total_Monthly_Salary"].ToString());
                expense.Dates = Convert.ToDateTime(reader["Dates"]);

                expenseList.Add(expense);
            }
            con.Close();
            return expenseList;
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
                employee.Salary = int.Parse(reader["Salary"].ToString()) ;
                totalSalary += employee.Salary;
            }
            con.Close();
            return totalSalary;
        }

        public int addRecord()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into Expense (Invoices,Rent,Tax,Other_Expense,Monthly_Product_Cost,Total_Monthly_Salary,Dates) values (@Invoices,@Rent,@Tax,@Other_Expense,@Monthly_Product_Cost,@Total_Monthly_Salary,@Dates)", con);
            cmd.Parameters.AddWithValue("@Invoices", txt_invoices.Text);
            cmd.Parameters.AddWithValue("@Rent", txt_rent.Text);
            cmd.Parameters.AddWithValue("@Tax", _txt_tax.Text);
            cmd.Parameters.AddWithValue("@Other_Expense", txt_otherExpense.Text);
            cmd.Parameters.AddWithValue("@Monthly_Product_Cost", txt_productCost.Text);
            cmd.Parameters.AddWithValue("@Total_Monthly_Salary", calculateSalary());
            string dateStr = txt_date.Text;
            string[] dateParts = dateStr.Split('.');
            int day = int.Parse(dateParts[0]);
            int month = int.Parse(dateParts[1]);
            int year = int.Parse(dateParts[2]);
            DateTime date = new DateTime(year, month, day);
            cmd.Parameters.AddWithValue("@Dates", date);
            int returnValue = cmd.ExecuteNonQuery();
            con.Close();
            if (returnValue == 1)
            {
                return 1;
            }
            else
            {
                return 0;
            }

        }


        public int deleteRecord()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("delete from Expense where Expense_ID=@Expense_ID", con);
            cmd.Parameters.AddWithValue("@Expense_ID", int.Parse(txt_id.Text));
            int returnValue = cmd.ExecuteNonQuery();
            con.Close();
            if (returnValue == 1)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }

        public int updateRecord()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("update Expense set Invoices=@Invoices,Rent=@Rent,Tax=@Tax,Other_Expense=@Other_Expense,Monthly_Product_Cost=@Monthly_Product_Cost,Dates=@Dates where Expense_ID=@Expense_ID ", con);

            cmd.Parameters.AddWithValue("@Invoices", txt_invoices.Text);
            cmd.Parameters.AddWithValue("@Rent", txt_rent.Text);
            cmd.Parameters.AddWithValue("@Tax", _txt_tax.Text);
            cmd.Parameters.AddWithValue("@Other_Expense", txt_otherExpense.Text);
            cmd.Parameters.AddWithValue("@Monthly_Product_Cost", txt_productCost.Text);
            cmd.Parameters.AddWithValue("@Dates", txt_date.Text);
            cmd.Parameters.AddWithValue("@Expense_ID", int.Parse(txt_id.Text));
            int returnValue = cmd.ExecuteNonQuery();
            con.Close();
            if (returnValue == 1)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            int result = addRecord();
            if (result == 1)
            {
                MessageBox.Show("Record has been added.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dataGridView1.DataSource = bringRecord();
            }
            else
            {
                MessageBox.Show("Record could not been added.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_update_Click(object sender, EventArgs e)
        {

            int result = updateRecord();
            if (result == 1)
            {
                MessageBox.Show("Record is updated", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dataGridView1.DataSource = bringRecord();
            }
            else
            {
                MessageBox.Show("Record is not updated.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string invoices = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            string rent = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            string tax = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            string otherExpense = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            string productCost = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            DateTime dates = Convert.ToDateTime(dataGridView1.CurrentRow.Cells[7].Value);
            string id = dataGridView1.CurrentRow.Cells[0].Value.ToString();



            txt_id.Text = id;
            txt_invoices.Text = invoices;
            txt_rent.Text = rent;
            _txt_tax.Text = tax;
            txt_otherExpense.Text = otherExpense;
            txt_productCost.Text = productCost;
            txt_date.Text = dates.ToString("dd/MM/yyyy");

        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            int result = deleteRecord();
            if (result == 1)
            {
                MessageBox.Show("Record is deleted", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dataGridView1.DataSource = bringRecord();
            }
            else
            {
                MessageBox.Show("Record is not deleted.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txt_id_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_total_Click(object sender, EventArgs e)
        {
            try
            {
                string startDateStr = mskText_first.Text;
                string endDateStr = mskText_second.Text;

                DateTime startDate = DateTime.ParseExact(startDateStr, "dd/MM/yyyy", null);
                DateTime endDate = DateTime.ParseExact(endDateStr, "dd/MM/yyyy", null);

                con.Open();

                string query = @"SELECT SUM(Rent) AS TotalRent, SUM(Invoices) AS TotalInvoices,
                         SUM(Tax) AS TotalTax, SUM(Other_Expense) AS TotalOtherExpense,
                         SUM(Monthly_Product_Cost) AS TotalProductCost,
                         SUM(Total_Monthly_Salary) AS TotalSalary
                         FROM Expense
                         WHERE Dates BETWEEN @StartDate AND @EndDate";

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@StartDate", startDate);
                cmd.Parameters.AddWithValue("@EndDate", endDate);

                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
               
                    label_rent.Text = reader["TotalRent"] != DBNull.Value ? reader["TotalRent"].ToString() : "0";
                    label_invoices.Text = reader["TotalInvoices"] != DBNull.Value ? reader["TotalInvoices"].ToString() : "0";
                    label_tax.Text = reader["TotalTax"] != DBNull.Value ? reader["TotalTax"].ToString() : "0";
                    label_expense.Text = reader["TotalOtherExpense"] != DBNull.Value ? reader["TotalOtherExpense"].ToString() : "0";
                    label_cost.Text = reader["TotalProductCost"] != DBNull.Value ? reader["TotalProductCost"].ToString() : "0";
                    label_salary.Text = reader["TotalSalary"] != DBNull.Value ? reader["TotalSalary"].ToString() : "0";
                }

                reader.Close();
                con.Close();
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Invalid date format. Please enter date in dd/MM/yyyy format\r\n", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }
    }
}
