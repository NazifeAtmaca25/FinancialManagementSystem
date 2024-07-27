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
    public partial class Product : Form
    {
        SqlConnection con = new SqlConnection("Data Source=localhost;Initial Catalog=Financial_Management_System;User ID=sa;password=12345");

        public Product()
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

        private void Product_Load(object sender, EventArgs e)
        {
            dtGridProduct.DataSource =bringRecord();
        }

        public List<ProductModel> bringRecord()
        {
            List<ProductModel> productList = new List<ProductModel>();
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from Product", con);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
               ProductModel product = new ProductModel();
                product.Product_ID = int.Parse(reader["Product_ID"].ToString());
                product.Product_Name = reader["Product_Name"].ToString();
                productList.Add(product);
            }
            con.Close();
            return productList;
        }

        public int addRecord()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into Product (Product_Name) values (@Product_Name)", con);
            cmd.Parameters.AddWithValue("@Product_Name", txt_ProductName.Text);
            
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
            SqlCommand cmd = new SqlCommand("update Product set Product_Name=@Product_Name where Product_ID=@Product_ID ", con);

            cmd.Parameters.AddWithValue("@Product_Name", txt_ProductName.Text);
            cmd.Parameters.AddWithValue("@Product_ID", int.Parse(txt_productID.Text));
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
            SqlCommand cmd = new SqlCommand("delete from Product where Product_ID=@Product_ID", con);
            cmd.Parameters.AddWithValue("@Product_ID", int.Parse(txt_productID.Text));
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
                dtGridProduct.DataSource = bringRecord();
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
                dtGridProduct.DataSource = bringRecord();
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
                dtGridProduct.DataSource = bringRecord();
            }
            else
            {
                MessageBox.Show("Record is not deleted.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dtGridProduct_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string names = dtGridProduct.CurrentRow.Cells[1].Value.ToString();
            string id = dtGridProduct.CurrentRow.Cells[0].Value.ToString();

            txt_ProductName.Text = names;
            txt_productID.Text = id;
        }
    }
}
