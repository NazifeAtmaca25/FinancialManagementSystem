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
    public partial class Order : Form
    {
        SqlConnection con = new SqlConnection("Data Source=localhost;Initial Catalog=Financial_Management_System;User ID=sa;password=12345");

        public Order()
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

        private void Order_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = bringRecord();
        }

        public List<OrderModel> bringRecord()
        {
            List<OrderModel> orderList = new List<OrderModel>();
            con.Open();

            SqlCommand cmd = new SqlCommand("select * from Orders", con);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                OrderModel order = new OrderModel();
                order.Order_ID = int.Parse(reader["Order_ID"].ToString());
                order.Daily_Amount = int.Parse(reader["Daily_Amount"].ToString());
                order.Dates = Convert.ToDateTime(reader["Dates"]);

                orderList.Add(order);
            }
            con.Close();
            return orderList;
        }
        public int GetRevenueIdByOrderDate(DateTime orderDate)
        {
            int revenueId = 0;

            con.Open();
            string query = "SELECT Revenue_ID FROM Revenue WHERE DATEPART(MONTH, Dates) = @Month AND DATEPART(YEAR, Dates) = @Year\r\n";
            SqlCommand command = new SqlCommand(query, con);

            command.Parameters.AddWithValue("@Month", orderDate.Month);
            command.Parameters.AddWithValue("@Year", orderDate.Year);

            object result = command.ExecuteScalar();
            con.Close();
            if (result != null)
            {
                revenueId = Convert.ToInt32(result);
            }



            return revenueId;
        }


        public int addRecord()
        {
           
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into Orders (Daily_Amount,Dates) values (@Daily_Amount,@Dates)", con);
            cmd.Parameters.AddWithValue("@Daily_Amount", txt_dailyAmount.Text);
            string dateStr = maskedTextBox1.Text;
            string[] dateParts = dateStr.Split('.'); // Veya başka bir ayırıcıya göre split yapabilirsiniz
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

        public int updateRecord()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("update Orders set Daily_Amount=@Daily_Amount,Dates=@Dates where Order_ID=@Order_ID ", con);

            cmd.Parameters.AddWithValue("@Daily_Amount", txt_dailyAmount.Text);
            cmd.Parameters.AddWithValue("@Dates", maskedTextBox1.Text);
            cmd.Parameters.AddWithValue("@Order_ID", int.Parse(txt_orderID.Text));

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
            SqlCommand cmd = new SqlCommand("delete from Orders where Order_ID=@Order_ID", con);
            cmd.Parameters.AddWithValue("@Order_ID", int.Parse(txt_orderID.Text));
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

        private void label3_Click(object sender, EventArgs e)
        {

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

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string id = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            string dailyAmount = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            DateTime dates = Convert.ToDateTime(dataGridView1.CurrentRow.Cells[2].Value);


            txt_orderID.Text = id;
            txt_dailyAmount.Text = dailyAmount;
            maskedTextBox1.Text = dates.ToString("dd/MM/yyyy");
        }

        

        
    }
    }

