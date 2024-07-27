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
    public partial class Revenue : Form
    {
        SqlConnection con = new SqlConnection("Data Source=localhost;Initial Catalog=Financial_Management_System;User ID=sa;password=12345");

        public Revenue()
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

        public List<RevenueModel> bringRecord()
        {
            UpdateRevenueFromOrders(); // Siparişler eklenmeden önce Revenue tablosunu güncelle

            List<RevenueModel> revenueList = new List<RevenueModel>();
            con.Open();
            SqlCommand cmd = new SqlCommand(@"SELECT Revenue_ID, Montly_Revenue, Dates FROM Revenue", con);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                RevenueModel revenue = new RevenueModel();
                revenue.Revenue_ID = int.Parse(reader["Revenue_ID"].ToString());
                revenue.Montly_Revenue = int.Parse(reader["Montly_Revenue"].ToString());
                revenue.Dates = Convert.ToDateTime(reader["Dates"]);

                revenueList.Add(revenue);
            }
            con.Close();
            return revenueList;
        }

        public void UpdateRevenueFromOrders()
        {
            con.Open();

            // SQL sorgusu ile Orders tablosundan her ayın toplamını alarak Revenue tablosuna ekleyelim
            SqlCommand cmd = new SqlCommand(@"MERGE INTO Revenue AS target
                                       USING (SELECT SUM(Daily_Amount) AS Montly_Revenue,
                                                     DATEADD(MONTH, DATEDIFF(MONTH, 0, Dates), 0) AS Dates
                                              FROM Orders
                                              GROUP BY DATEADD(MONTH, DATEDIFF(MONTH, 0, Dates), 0)) AS source
                                       ON target.Dates = source.Dates
                                       WHEN MATCHED THEN
                                           UPDATE SET target.Montly_Revenue = source.Montly_Revenue
                                       WHEN NOT MATCHED THEN
                                           INSERT (Montly_Revenue, Dates)
                                           VALUES (source.Montly_Revenue, source.Dates);", con);

            cmd.ExecuteNonQuery(); // Sorguyu çalıştır

            con.Close(); // Bağlantıyı kapat
        }
        public int addRecord()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into Revenue (Montly_Revenue,Dates) values (@Montly_Revenue,@Dates)", con);
            cmd.Parameters.AddWithValue("@Montly_Revenue", txt_monthyRevenue.Text);
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
            SqlCommand cmd = new SqlCommand("update Revenue set Montly_Revenue=@Montly_Revenue,Dates=@Dates where Revenue_ID=@Revenue_ID ", con);

            cmd.Parameters.AddWithValue("@Montly_Revenue", txt_monthyRevenue.Text);
            cmd.Parameters.AddWithValue("@Dates", maskedTextBox1.Text);
            cmd.Parameters.AddWithValue("@Revenue_ID", int.Parse(txt_revenueid.Text));
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
            SqlCommand cmd = new SqlCommand("delete from Revenue where Revenue_ID=@Revenue_ID", con);
            cmd.Parameters.AddWithValue("@Revenue_ID", int.Parse(txt_revenueid.Text));
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

        private void button2_Click(object sender, EventArgs e)
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

        private void Revenue_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource=bringRecord();
        }

        private void btn_ekle_Click(object sender, EventArgs e)
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
            string revenue = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            DateTime dates = Convert.ToDateTime(dataGridView1.CurrentRow.Cells[2].Value);

            txt_revenueid.Text = id;
            txt_monthyRevenue.Text = revenue;
            maskedTextBox1.Text = dates.ToString("dd/MM/yyyy");

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string startDateStr = mskText_first.Text;
                string endDateStr = mskText_Second.Text;

                DateTime startDate = DateTime.ParseExact(startDateStr, "dd/MM/yyyy", null);
                DateTime endDate = DateTime.ParseExact(endDateStr, "dd/MM/yyyy", null);

                con.Open();

                string query = @"SELECT SUM(Montly_Revenue) AS TotalMontly_Revenue
                         FROM Revenue
                         WHERE Dates BETWEEN @StartDate AND @EndDate";

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@StartDate", startDate);
                cmd.Parameters.AddWithValue("@EndDate", endDate);

                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    label_revenue.Text = reader["TotalMontly_Revenue"] != DBNull.Value ? reader["TotalMontly_Revenue"].ToString() : "0";
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
