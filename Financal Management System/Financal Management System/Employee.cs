using System;
using Financal_Management_System.model;
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
    public partial class Employee : Form
    {
        SqlConnection con =new SqlConnection("Data Source=localhost;Initial Catalog=Financial_Management_System;User ID=sa;password=12345");
        public Employee()
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

        private void Employee_Load(object sender, EventArgs e)
        {
            dtGrid_employee.DataSource = bringRecord();
        }
        public List<EmployeeModel> bringRecord()
        {
            List<EmployeeModel> employeeList = new List<EmployeeModel>();
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from Employee", con);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                EmployeeModel employee = new EmployeeModel();
                employee.Employee_ID = int.Parse(reader["Employee_ID"].ToString());
                employee.Names = reader["Names"].ToString();
                employee.Position = reader["Position"].ToString();
                employee.Salary = int.Parse(reader["Salary"].ToString());
                employeeList.Add(employee);
            }
            con.Close();
            return employeeList;
        }

        public int addRecord()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into Employee (Names,Salary,Position) values (@Names,@Salary,@Position)", con);
            cmd.Parameters.AddWithValue("@Names",txt_name.Text);
            cmd.Parameters.AddWithValue("@Salary",txt_salary.Text);
            cmd.Parameters.AddWithValue("@Position",txt_position.Text);
            int returnValue=cmd.ExecuteNonQuery();
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
            SqlCommand cmd = new SqlCommand("update Employee set Names=@Names, Salary=@Salary, Position=@Position where Employee_ID=@Employee_ID ", con);

            cmd.Parameters.AddWithValue("@Names", txt_name.Text);
            cmd.Parameters.AddWithValue("@Salary", txt_salary.Text);
            cmd.Parameters.AddWithValue("@Position", txt_position.Text);
            cmd.Parameters.AddWithValue("@Employee_ID", int.Parse(txt_id.Text));
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
            SqlCommand cmd = new SqlCommand("delete from Employee where Employee_ID=@Employee_ID", con);
            cmd.Parameters.AddWithValue("@Employee_ID", int.Parse(txt_id.Text));
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

        private void btn_update_Click(object sender, EventArgs e)
        {
            int result = updateRecord();
            if (result == 1)
            {
                MessageBox.Show("Record is updated", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dtGrid_employee.DataSource = bringRecord();
            }
            else
            {
                MessageBox.Show("Record is not updated.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            int result=addRecord();
            if (result == 1)
            {
                MessageBox.Show("Record has been added.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dtGrid_employee.DataSource = bringRecord();
            }
            else
            {
                MessageBox.Show("Record could not been added.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dtGrid_employee_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string names=dtGrid_employee.CurrentRow.Cells[1].Value.ToString();
            string salary=dtGrid_employee.CurrentRow.Cells[2].Value.ToString();
            string position=dtGrid_employee.CurrentRow.Cells[3].Value.ToString();
            string id=dtGrid_employee.CurrentRow.Cells[0].Value.ToString();

            txt_name.Text = names;
            txt_salary.Text = salary;
            txt_position.Text = position;
            txt_id.Text = id;
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            int result=deleteRecord();
            if (result == 1)
            {
                MessageBox.Show("Record is deleted", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dtGrid_employee.DataSource = bringRecord();
            }
            else
            {
                MessageBox.Show("Record is not deleted.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
