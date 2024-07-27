namespace Financal_Management_System
{
    partial class HomePage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomePage));
            this.btn_employee = new System.Windows.Forms.Button();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btn_Revenue = new System.Windows.Forms.Button();
            this.btn_Product = new System.Windows.Forms.Button();
            this.btn_Expense = new System.Windows.Forms.Button();
            this.btn_Order = new System.Windows.Forms.Button();
            this.btn_financial = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_logout = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_employee
            // 
            this.btn_employee.ImageKey = "employee2.png";
            this.btn_employee.ImageList = this.ımageList1;
            this.btn_employee.Location = new System.Drawing.Point(50, 55);
            this.btn_employee.Name = "btn_employee";
            this.btn_employee.Size = new System.Drawing.Size(132, 118);
            this.btn_employee.TabIndex = 0;
            this.btn_employee.UseVisualStyleBackColor = true;
            this.btn_employee.Click += new System.EventHandler(this.btn_employee_Click);
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "employee.png");
            this.ımageList1.Images.SetKeyName(1, "expense.png");
            this.ımageList1.Images.SetKeyName(2, "financial.png");
            this.ımageList1.Images.SetKeyName(3, "order.png");
            this.ımageList1.Images.SetKeyName(4, "product.png");
            this.ımageList1.Images.SetKeyName(5, "revenue.png");
            this.ımageList1.Images.SetKeyName(6, "employee2.png");
            // 
            // btn_Revenue
            // 
            this.btn_Revenue.ImageKey = "revenue.png";
            this.btn_Revenue.ImageList = this.ımageList1;
            this.btn_Revenue.Location = new System.Drawing.Point(223, 227);
            this.btn_Revenue.Name = "btn_Revenue";
            this.btn_Revenue.Size = new System.Drawing.Size(132, 118);
            this.btn_Revenue.TabIndex = 0;
            this.btn_Revenue.UseVisualStyleBackColor = true;
            this.btn_Revenue.Click += new System.EventHandler(this.btn_Revenue_Click);
            // 
            // btn_Product
            // 
            this.btn_Product.ImageKey = "product.png";
            this.btn_Product.ImageList = this.ımageList1;
            this.btn_Product.Location = new System.Drawing.Point(223, 55);
            this.btn_Product.Name = "btn_Product";
            this.btn_Product.Size = new System.Drawing.Size(132, 118);
            this.btn_Product.TabIndex = 0;
            this.btn_Product.UseVisualStyleBackColor = true;
            this.btn_Product.Click += new System.EventHandler(this.btn_Product_Click);
            // 
            // btn_Expense
            // 
            this.btn_Expense.ImageKey = "expense.png";
            this.btn_Expense.ImageList = this.ımageList1;
            this.btn_Expense.Location = new System.Drawing.Point(50, 227);
            this.btn_Expense.Name = "btn_Expense";
            this.btn_Expense.Size = new System.Drawing.Size(132, 118);
            this.btn_Expense.TabIndex = 0;
            this.btn_Expense.UseVisualStyleBackColor = true;
            this.btn_Expense.Click += new System.EventHandler(this.btn_Expense_Click);
            // 
            // btn_Order
            // 
            this.btn_Order.ImageKey = "order.png";
            this.btn_Order.ImageList = this.ımageList1;
            this.btn_Order.Location = new System.Drawing.Point(397, 55);
            this.btn_Order.Name = "btn_Order";
            this.btn_Order.Size = new System.Drawing.Size(132, 118);
            this.btn_Order.TabIndex = 0;
            this.btn_Order.UseVisualStyleBackColor = true;
            this.btn_Order.Click += new System.EventHandler(this.btn_Order_Click);
            // 
            // btn_financial
            // 
            this.btn_financial.ImageKey = "financial.png";
            this.btn_financial.ImageList = this.ımageList1;
            this.btn_financial.Location = new System.Drawing.Point(397, 225);
            this.btn_financial.Name = "btn_financial";
            this.btn_financial.Size = new System.Drawing.Size(132, 118);
            this.btn_financial.TabIndex = 0;
            this.btn_financial.UseVisualStyleBackColor = true;
            this.btn_financial.Click += new System.EventHandler(this.btn_financial_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(49, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Employee";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(222, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Product";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(397, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Order";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(222, 202);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Revenue";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(49, 202);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "Expense";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(397, 202);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(165, 20);
            this.label6.TabIndex = 6;
            this.label6.Text = "Financial Situation";
            // 
            // btn_logout
            // 
            this.btn_logout.Location = new System.Drawing.Point(441, 361);
            this.btn_logout.Name = "btn_logout";
            this.btn_logout.Size = new System.Drawing.Size(88, 31);
            this.btn_logout.TabIndex = 7;
            this.btn_logout.Text = "Logout";
            this.btn_logout.UseVisualStyleBackColor = true;
            this.btn_logout.Click += new System.EventHandler(this.btn_logout_Click);
            // 
            // HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(583, 404);
            this.Controls.Add(this.btn_logout);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_financial);
            this.Controls.Add(this.btn_Expense);
            this.Controls.Add(this.btn_Revenue);
            this.Controls.Add(this.btn_Order);
            this.Controls.Add(this.btn_Product);
            this.Controls.Add(this.btn_employee);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "HomePage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home Page";
            this.Load += new System.EventHandler(this.HomePage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_employee;
        private System.Windows.Forms.Button btn_Revenue;
        private System.Windows.Forms.Button btn_Product;
        private System.Windows.Forms.Button btn_Expense;
        private System.Windows.Forms.Button btn_Order;
        private System.Windows.Forms.Button btn_financial;
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_logout;
    }
}