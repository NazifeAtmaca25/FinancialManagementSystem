namespace Financal_Management_System
{
    partial class Expense
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Expense));
            this.btn_back = new System.Windows.Forms.Button();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btn_logout = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this._txt_tax = new System.Windows.Forms.TextBox();
            this.txt_productCost = new System.Windows.Forms.TextBox();
            this.txt_otherExpense = new System.Windows.Forms.TextBox();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.txt_rent = new System.Windows.Forms.TextBox();
            this.lbl_tax = new System.Windows.Forms.Label();
            this.lbl_date = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_other = new System.Windows.Forms.Label();
            this.lbl_invoices = new System.Windows.Forms.Label();
            this.lbl_rent = new System.Windows.Forms.Label();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_invoices = new System.Windows.Forms.TextBox();
            this.txt_date = new System.Windows.Forms.MaskedTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label_tax = new System.Windows.Forms.Label();
            this.label_expense = new System.Windows.Forms.Label();
            this.label_cost = new System.Windows.Forms.Label();
            this.label_salary = new System.Windows.Forms.Label();
            this.btn_total = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.mskText_second = new System.Windows.Forms.MaskedTextBox();
            this.mskText_first = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label_invoices = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label_rent = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_back
            // 
            this.btn_back.ImageKey = "back button.png";
            this.btn_back.ImageList = this.ımageList1;
            this.btn_back.Location = new System.Drawing.Point(12, 12);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(69, 34);
            this.btn_back.TabIndex = 1;
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "back button.png");
            // 
            // btn_logout
            // 
            this.btn_logout.Location = new System.Drawing.Point(700, 316);
            this.btn_logout.Name = "btn_logout";
            this.btn_logout.Size = new System.Drawing.Size(88, 31);
            this.btn_logout.TabIndex = 8;
            this.btn_logout.Text = "Logout";
            this.btn_logout.UseVisualStyleBackColor = true;
            this.btn_logout.Click += new System.EventHandler(this.btn_logout_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(88, 13);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(700, 221);
            this.dataGridView1.TabIndex = 9;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // _txt_tax
            // 
            this._txt_tax.Location = new System.Drawing.Point(158, 77);
            this._txt_tax.Name = "_txt_tax";
            this._txt_tax.Size = new System.Drawing.Size(100, 22);
            this._txt_tax.TabIndex = 19;
            // 
            // txt_productCost
            // 
            this.txt_productCost.Location = new System.Drawing.Point(158, 133);
            this.txt_productCost.Name = "txt_productCost";
            this.txt_productCost.Size = new System.Drawing.Size(100, 22);
            this.txt_productCost.TabIndex = 20;
            // 
            // txt_otherExpense
            // 
            this.txt_otherExpense.Location = new System.Drawing.Point(158, 105);
            this.txt_otherExpense.Name = "txt_otherExpense";
            this.txt_otherExpense.Size = new System.Drawing.Size(100, 22);
            this.txt_otherExpense.TabIndex = 21;
            // 
            // txt_id
            // 
            this.txt_id.Location = new System.Drawing.Point(741, 261);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(47, 22);
            this.txt_id.TabIndex = 22;
            this.txt_id.TextChanged += new System.EventHandler(this.txt_id_TextChanged);
            // 
            // txt_rent
            // 
            this.txt_rent.Location = new System.Drawing.Point(158, 49);
            this.txt_rent.Name = "txt_rent";
            this.txt_rent.Size = new System.Drawing.Size(100, 22);
            this.txt_rent.TabIndex = 23;
            // 
            // lbl_tax
            // 
            this.lbl_tax.AutoSize = true;
            this.lbl_tax.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_tax.Location = new System.Drawing.Point(6, 76);
            this.lbl_tax.Name = "lbl_tax";
            this.lbl_tax.Size = new System.Drawing.Size(41, 20);
            this.lbl_tax.TabIndex = 13;
            this.lbl_tax.Text = "Tax:";
            // 
            // lbl_date
            // 
            this.lbl_date.AutoSize = true;
            this.lbl_date.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_date.Location = new System.Drawing.Point(6, 160);
            this.lbl_date.Name = "lbl_date";
            this.lbl_date.Size = new System.Drawing.Size(50, 20);
            this.lbl_date.TabIndex = 14;
            this.lbl_date.Text = "Date:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(6, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 20);
            this.label4.TabIndex = 15;
            this.label4.Text = "Product Cost:";
            // 
            // txt_other
            // 
            this.txt_other.AutoSize = true;
            this.txt_other.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_other.Location = new System.Drawing.Point(6, 102);
            this.txt_other.Name = "txt_other";
            this.txt_other.Size = new System.Drawing.Size(125, 20);
            this.txt_other.TabIndex = 16;
            this.txt_other.Text = "Other Expence:";
            // 
            // lbl_invoices
            // 
            this.lbl_invoices.AutoSize = true;
            this.lbl_invoices.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_invoices.Location = new System.Drawing.Point(635, 263);
            this.lbl_invoices.Name = "lbl_invoices";
            this.lbl_invoices.Size = new System.Drawing.Size(100, 20);
            this.lbl_invoices.TabIndex = 17;
            this.lbl_invoices.Text = "Expense ID:";
            // 
            // lbl_rent
            // 
            this.lbl_rent.AutoSize = true;
            this.lbl_rent.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_rent.Location = new System.Drawing.Point(6, 46);
            this.lbl_rent.Name = "lbl_rent";
            this.lbl_rent.Size = new System.Drawing.Size(49, 20);
            this.lbl_rent.TabIndex = 18;
            this.lbl_rent.Text = "Rent:";
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(302, 47);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(118, 32);
            this.btn_add.TabIndex = 25;
            this.btn_add.Text = "Add";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_update
            // 
            this.btn_update.Location = new System.Drawing.Point(302, 85);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(118, 32);
            this.btn_update.TabIndex = 26;
            this.btn_update.Text = "Update";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(302, 125);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(118, 32);
            this.btn_delete.TabIndex = 27;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(6, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 20);
            this.label1.TabIndex = 17;
            this.label1.Text = "Invoices:";
            // 
            // txt_invoices
            // 
            this.txt_invoices.Location = new System.Drawing.Point(158, 21);
            this.txt_invoices.Name = "txt_invoices";
            this.txt_invoices.Size = new System.Drawing.Size(100, 22);
            this.txt_invoices.TabIndex = 22;
            // 
            // txt_date
            // 
            this.txt_date.Location = new System.Drawing.Point(158, 161);
            this.txt_date.Mask = "00/00/0000";
            this.txt_date.Name = "txt_date";
            this.txt_date.Size = new System.Drawing.Size(100, 22);
            this.txt_date.TabIndex = 24;
            this.txt_date.ValidatingType = typeof(System.DateTime);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btn_delete);
            this.groupBox1.Controls.Add(this.lbl_rent);
            this.groupBox1.Controls.Add(this.btn_update);
            this.groupBox1.Controls.Add(this.btn_add);
            this.groupBox1.Controls.Add(this.txt_other);
            this.groupBox1.Controls.Add(this.txt_date);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this._txt_tax);
            this.groupBox1.Controls.Add(this.lbl_date);
            this.groupBox1.Controls.Add(this.txt_productCost);
            this.groupBox1.Controls.Add(this.lbl_tax);
            this.groupBox1.Controls.Add(this.txt_otherExpense);
            this.groupBox1.Controls.Add(this.txt_rent);
            this.groupBox1.Controls.Add(this.txt_invoices);
            this.groupBox1.Location = new System.Drawing.Point(86, 251);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(439, 194);
            this.groupBox1.TabIndex = 28;
            this.groupBox1.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(6, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 20);
            this.label6.TabIndex = 34;
            this.label6.Text = "Tax";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(6, 23);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(120, 20);
            this.label8.TabIndex = 34;
            this.label8.Text = "Other Expense";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(6, 23);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(107, 20);
            this.label9.TabIndex = 34;
            this.label9.Text = "Product Cost";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(6, 23);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(98, 20);
            this.label10.TabIndex = 34;
            this.label10.Text = "Total Salary";
            // 
            // label_tax
            // 
            this.label_tax.AutoSize = true;
            this.label_tax.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_tax.Location = new System.Drawing.Point(6, 60);
            this.label_tax.Name = "label_tax";
            this.label_tax.Size = new System.Drawing.Size(18, 20);
            this.label_tax.TabIndex = 34;
            this.label_tax.Text = "0";
            // 
            // label_expense
            // 
            this.label_expense.AutoSize = true;
            this.label_expense.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_expense.Location = new System.Drawing.Point(6, 60);
            this.label_expense.Name = "label_expense";
            this.label_expense.Size = new System.Drawing.Size(18, 20);
            this.label_expense.TabIndex = 34;
            this.label_expense.Text = "0";
            // 
            // label_cost
            // 
            this.label_cost.AutoSize = true;
            this.label_cost.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_cost.Location = new System.Drawing.Point(6, 60);
            this.label_cost.Name = "label_cost";
            this.label_cost.Size = new System.Drawing.Size(18, 20);
            this.label_cost.TabIndex = 34;
            this.label_cost.Text = "0";
            // 
            // label_salary
            // 
            this.label_salary.AutoSize = true;
            this.label_salary.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_salary.Location = new System.Drawing.Point(6, 60);
            this.label_salary.Name = "label_salary";
            this.label_salary.Size = new System.Drawing.Size(18, 20);
            this.label_salary.TabIndex = 34;
            this.label_salary.Text = "0";
            // 
            // btn_total
            // 
            this.btn_total.Location = new System.Drawing.Point(517, 13);
            this.btn_total.Name = "btn_total";
            this.btn_total.Size = new System.Drawing.Size(92, 33);
            this.btn_total.TabIndex = 33;
            this.btn_total.Text = "Total";
            this.btn_total.UseVisualStyleBackColor = true;
            this.btn_total.Click += new System.EventHandler(this.btn_total_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(254, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 20);
            this.label3.TabIndex = 32;
            this.label3.Text = "End Date:";
            // 
            // mskText_second
            // 
            this.mskText_second.Location = new System.Drawing.Point(351, 18);
            this.mskText_second.Mask = "00/00/0000";
            this.mskText_second.Name = "mskText_second";
            this.mskText_second.Size = new System.Drawing.Size(100, 22);
            this.mskText_second.TabIndex = 31;
            this.mskText_second.ValidatingType = typeof(System.DateTime);
            // 
            // mskText_first
            // 
            this.mskText_first.Location = new System.Drawing.Point(129, 18);
            this.mskText_first.Mask = "00/00/0000";
            this.mskText_first.Name = "mskText_first";
            this.mskText_first.Size = new System.Drawing.Size(100, 22);
            this.mskText_first.TabIndex = 29;
            this.mskText_first.ValidatingType = typeof(System.DateTime);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(27, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 20);
            this.label2.TabIndex = 30;
            this.label2.Text = "Start Date:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label_invoices);
            this.groupBox3.Location = new System.Drawing.Point(6, 47);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(103, 100);
            this.groupBox3.TabIndex = 36;
            this.groupBox3.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(17, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 20);
            this.label5.TabIndex = 34;
            this.label5.Text = "Invoices";
            // 
            // label_invoices
            // 
            this.label_invoices.AutoSize = true;
            this.label_invoices.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_invoices.Location = new System.Drawing.Point(17, 61);
            this.label_invoices.Name = "label_invoices";
            this.label_invoices.Size = new System.Drawing.Size(18, 20);
            this.label_invoices.TabIndex = 34;
            this.label_invoices.Text = "0";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.label_rent);
            this.groupBox4.Location = new System.Drawing.Point(115, 47);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(79, 100);
            this.groupBox4.TabIndex = 37;
            this.groupBox4.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(6, 24);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 20);
            this.label7.TabIndex = 34;
            this.label7.Text = "Rent";
            // 
            // label_rent
            // 
            this.label_rent.AutoSize = true;
            this.label_rent.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_rent.Location = new System.Drawing.Point(6, 61);
            this.label_rent.Name = "label_rent";
            this.label_rent.Size = new System.Drawing.Size(18, 20);
            this.label_rent.TabIndex = 34;
            this.label_rent.Text = "0";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupBox8);
            this.groupBox2.Controls.Add(this.groupBox7);
            this.groupBox2.Controls.Add(this.groupBox6);
            this.groupBox2.Controls.Add(this.groupBox4);
            this.groupBox2.Controls.Add(this.groupBox5);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.mskText_first);
            this.groupBox2.Controls.Add(this.mskText_second);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.btn_total);
            this.groupBox2.Location = new System.Drawing.Point(86, 470);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(702, 153);
            this.groupBox2.TabIndex = 35;
            this.groupBox2.TabStop = false;
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.label10);
            this.groupBox8.Controls.Add(this.label_salary);
            this.groupBox8.Location = new System.Drawing.Point(576, 48);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(120, 100);
            this.groupBox8.TabIndex = 41;
            this.groupBox8.TabStop = false;
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.label9);
            this.groupBox7.Controls.Add(this.label_cost);
            this.groupBox7.Location = new System.Drawing.Point(449, 48);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(121, 100);
            this.groupBox7.TabIndex = 40;
            this.groupBox7.TabStop = false;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.label8);
            this.groupBox6.Controls.Add(this.label_expense);
            this.groupBox6.Location = new System.Drawing.Point(295, 48);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(148, 100);
            this.groupBox6.TabIndex = 39;
            this.groupBox6.TabStop = false;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label6);
            this.groupBox5.Controls.Add(this.label_tax);
            this.groupBox5.Location = new System.Drawing.Point(200, 48);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(89, 100);
            this.groupBox5.TabIndex = 38;
            this.groupBox5.TabStop = false;
            // 
            // Expense
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(809, 632);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txt_id);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_logout);
            this.Controls.Add(this.lbl_invoices);
            this.Controls.Add(this.btn_back);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Expense";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Expense";
            this.Load += new System.EventHandler(this.Expense_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.Button btn_logout;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox _txt_tax;
        private System.Windows.Forms.TextBox txt_productCost;
        private System.Windows.Forms.TextBox txt_otherExpense;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.TextBox txt_rent;
        private System.Windows.Forms.Label lbl_tax;
        private System.Windows.Forms.Label lbl_date;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label txt_other;
        private System.Windows.Forms.Label lbl_invoices;
        private System.Windows.Forms.Label lbl_rent;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_invoices;
        private System.Windows.Forms.MaskedTextBox txt_date;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label_tax;
        private System.Windows.Forms.Label label_expense;
        private System.Windows.Forms.Label label_cost;
        private System.Windows.Forms.Label label_salary;
        private System.Windows.Forms.Button btn_total;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox mskText_second;
        private System.Windows.Forms.MaskedTextBox mskText_first;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label_invoices;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label_rent;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.GroupBox groupBox5;
    }
}