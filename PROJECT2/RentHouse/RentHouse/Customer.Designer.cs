namespace RentHouse
{
    partial class Customer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Customer));
            this.label1 = new System.Windows.Forms.Label();
            this.tb_idcust = new System.Windows.Forms.TextBox();
            this.tbcustomerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rent_houseDataSet = new RentHouse.rent_houseDataSet();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tb_name = new System.Windows.Forms.TextBox();
            this.cb_type = new System.Windows.Forms.ComboBox();
            this.tb_idno = new System.Windows.Forms.TextBox();
            this.tb_phone = new System.Windows.Forms.TextBox();
            this.dt_birth = new System.Windows.Forms.DateTimePicker();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.bn_customer = new System.Windows.Forms.BindingNavigator(this.components);
            this.bn_add = new System.Windows.Forms.ToolStripButton();
            this.bn_count = new System.Windows.Forms.ToolStripLabel();
            this.bn_delete = new System.Windows.Forms.ToolStripButton();
            this.bn_first = new System.Windows.Forms.ToolStripButton();
            this.bn_previous = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bn_position = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bn_next = new System.Windows.Forms.ToolStripButton();
            this.bn_last = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.tb_customerTableAdapter = new RentHouse.rent_houseDataSetTableAdapters.tb_customerTableAdapter();
            this.tb_address = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cb_gender = new System.Windows.Forms.ComboBox();
            this.btn_submit = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.tbcustomerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rent_houseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bn_customer)).BeginInit();
            this.bn_customer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Khaki;
            this.label1.Location = new System.Drawing.Point(179, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Customer";
            // 
            // tb_idcust
            // 
            this.tb_idcust.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbcustomerBindingSource, "id_customer", true));
            this.tb_idcust.Location = new System.Drawing.Point(197, 117);
            this.tb_idcust.Name = "tb_idcust";
            this.tb_idcust.Size = new System.Drawing.Size(180, 20);
            this.tb_idcust.TabIndex = 1;
            this.tb_idcust.TextChanged += new System.EventHandler(this.tb_idcust_TextChanged);
            // 
            // tbcustomerBindingSource
            // 
            this.tbcustomerBindingSource.DataMember = "tb_customer";
            this.tbcustomerBindingSource.DataSource = this.rent_houseDataSet;
            // 
            // rent_houseDataSet
            // 
            this.rent_houseDataSet.DataSetName = "rent_houseDataSet";
            this.rent_houseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Khaki;
            this.label2.Location = new System.Drawing.Point(93, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "ID Customer";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Khaki;
            this.label3.Location = new System.Drawing.Point(93, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Khaki;
            this.label4.Location = new System.Drawing.Point(93, 188);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Card Type";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Khaki;
            this.label5.Location = new System.Drawing.Point(93, 222);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "ID No";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Khaki;
            this.label6.Location = new System.Drawing.Point(93, 251);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Gender";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Khaki;
            this.label7.Location = new System.Drawing.Point(93, 282);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Birthdate";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.Khaki;
            this.label8.Location = new System.Drawing.Point(93, 317);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "Phone";
            // 
            // tb_name
            // 
            this.tb_name.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbcustomerBindingSource, "name", true));
            this.tb_name.Location = new System.Drawing.Point(197, 147);
            this.tb_name.Name = "tb_name";
            this.tb_name.Size = new System.Drawing.Size(180, 20);
            this.tb_name.TabIndex = 9;
            this.tb_name.TextChanged += new System.EventHandler(this.tb_name_TextChanged);
            // 
            // cb_type
            // 
            this.cb_type.DataBindings.Add(new System.Windows.Forms.Binding("SelectedItem", this.tbcustomerBindingSource, "card_type", true));
            this.cb_type.FormattingEnabled = true;
            this.cb_type.Items.AddRange(new object[] {
            "KTP",
            "KTM",
            "SIM"});
            this.cb_type.Location = new System.Drawing.Point(197, 180);
            this.cb_type.Name = "cb_type";
            this.cb_type.Size = new System.Drawing.Size(180, 21);
            this.cb_type.TabIndex = 10;
            // 
            // tb_idno
            // 
            this.tb_idno.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbcustomerBindingSource, "id_no", true));
            this.tb_idno.Location = new System.Drawing.Point(197, 214);
            this.tb_idno.Name = "tb_idno";
            this.tb_idno.Size = new System.Drawing.Size(180, 20);
            this.tb_idno.TabIndex = 11;
            // 
            // tb_phone
            // 
            this.tb_phone.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbcustomerBindingSource, "phone", true));
            this.tb_phone.Location = new System.Drawing.Point(197, 314);
            this.tb_phone.Name = "tb_phone";
            this.tb_phone.Size = new System.Drawing.Size(180, 20);
            this.tb_phone.TabIndex = 12;
            // 
            // dt_birth
            // 
            this.dt_birth.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.tbcustomerBindingSource, "birthdate", true));
            this.dt_birth.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dt_birth.Location = new System.Drawing.Point(197, 282);
            this.dt_birth.Name = "dt_birth";
            this.dt_birth.Size = new System.Drawing.Size(180, 20);
            this.dt_birth.TabIndex = 15;
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(44, 64);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(75, 23);
            this.btn_add.TabIndex = 16;
            this.btn_add.Text = "Add";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_update
            // 
            this.btn_update.Location = new System.Drawing.Point(302, 397);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(75, 23);
            this.btn_update.TabIndex = 17;
            this.btn_update.Text = "Update";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // bn_customer
            // 
            this.bn_customer.AddNewItem = this.bn_add;
            this.bn_customer.BindingSource = this.tbcustomerBindingSource;
            this.bn_customer.CountItem = this.bn_count;
            this.bn_customer.DeleteItem = this.bn_delete;
            this.bn_customer.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bn_first,
            this.bn_previous,
            this.bindingNavigatorSeparator,
            this.bn_position,
            this.bn_count,
            this.bindingNavigatorSeparator1,
            this.bn_next,
            this.bn_last,
            this.bindingNavigatorSeparator2,
            this.bn_add,
            this.bn_delete,
            this.toolStripButton1});
            this.bn_customer.Location = new System.Drawing.Point(0, 0);
            this.bn_customer.MoveFirstItem = this.bn_first;
            this.bn_customer.MoveLastItem = this.bn_last;
            this.bn_customer.MoveNextItem = this.bn_next;
            this.bn_customer.MovePreviousItem = this.bn_previous;
            this.bn_customer.Name = "bn_customer";
            this.bn_customer.PositionItem = this.bn_position;
            this.bn_customer.Size = new System.Drawing.Size(484, 25);
            this.bn_customer.TabIndex = 18;
            this.bn_customer.Text = "bindingNavigator1";
            // 
            // bn_add
            // 
            this.bn_add.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bn_add.Image = ((System.Drawing.Image)(resources.GetObject("bn_add.Image")));
            this.bn_add.Name = "bn_add";
            this.bn_add.RightToLeftAutoMirrorImage = true;
            this.bn_add.Size = new System.Drawing.Size(23, 22);
            this.bn_add.Text = "Add new";
            // 
            // bn_count
            // 
            this.bn_count.Name = "bn_count";
            this.bn_count.Size = new System.Drawing.Size(35, 22);
            this.bn_count.Text = "of {0}";
            this.bn_count.ToolTipText = "Total number of items";
            // 
            // bn_delete
            // 
            this.bn_delete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bn_delete.Image = ((System.Drawing.Image)(resources.GetObject("bn_delete.Image")));
            this.bn_delete.Name = "bn_delete";
            this.bn_delete.RightToLeftAutoMirrorImage = true;
            this.bn_delete.Size = new System.Drawing.Size(23, 22);
            this.bn_delete.Text = "Delete";
            // 
            // bn_first
            // 
            this.bn_first.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bn_first.Image = ((System.Drawing.Image)(resources.GetObject("bn_first.Image")));
            this.bn_first.Name = "bn_first";
            this.bn_first.RightToLeftAutoMirrorImage = true;
            this.bn_first.Size = new System.Drawing.Size(23, 22);
            this.bn_first.Text = "Move first";
            // 
            // bn_previous
            // 
            this.bn_previous.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bn_previous.Image = ((System.Drawing.Image)(resources.GetObject("bn_previous.Image")));
            this.bn_previous.Name = "bn_previous";
            this.bn_previous.RightToLeftAutoMirrorImage = true;
            this.bn_previous.Size = new System.Drawing.Size(23, 22);
            this.bn_previous.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bn_position
            // 
            this.bn_position.AccessibleName = "Position";
            this.bn_position.AutoSize = false;
            this.bn_position.Name = "bn_position";
            this.bn_position.Size = new System.Drawing.Size(50, 23);
            this.bn_position.Text = "0";
            this.bn_position.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bn_next
            // 
            this.bn_next.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bn_next.Image = ((System.Drawing.Image)(resources.GetObject("bn_next.Image")));
            this.bn_next.Name = "bn_next";
            this.bn_next.RightToLeftAutoMirrorImage = true;
            this.bn_next.Size = new System.Drawing.Size(23, 22);
            this.bn_next.Text = "Move next";
            // 
            // bn_last
            // 
            this.bn_last.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bn_last.Image = ((System.Drawing.Image)(resources.GetObject("bn_last.Image")));
            this.bn_last.Name = "bn_last";
            this.bn_last.RightToLeftAutoMirrorImage = true;
            this.bn_last.Size = new System.Drawing.Size(23, 22);
            this.bn_last.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "toolStripButton1";
            // 
            // tb_customerTableAdapter
            // 
            this.tb_customerTableAdapter.ClearBeforeFill = true;
            // 
            // tb_address
            // 
            this.tb_address.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbcustomerBindingSource, "address", true));
            this.tb_address.Location = new System.Drawing.Point(197, 350);
            this.tb_address.Name = "tb_address";
            this.tb_address.Size = new System.Drawing.Size(180, 20);
            this.tb_address.TabIndex = 20;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.Khaki;
            this.label9.Location = new System.Drawing.Point(93, 353);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(45, 13);
            this.label9.TabIndex = 19;
            this.label9.Text = "Address";
            // 
            // cb_gender
            // 
            this.cb_gender.DataBindings.Add(new System.Windows.Forms.Binding("SelectedItem", this.tbcustomerBindingSource, "gender", true));
            this.cb_gender.FormattingEnabled = true;
            this.cb_gender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.cb_gender.Location = new System.Drawing.Point(197, 248);
            this.cb_gender.Name = "cb_gender";
            this.cb_gender.Size = new System.Drawing.Size(180, 21);
            this.cb_gender.TabIndex = 21;
            // 
            // btn_submit
            // 
            this.btn_submit.Location = new System.Drawing.Point(197, 397);
            this.btn_submit.Name = "btn_submit";
            this.btn_submit.Size = new System.Drawing.Size(75, 23);
            this.btn_submit.TabIndex = 22;
            this.btn_submit.Text = "Submit";
            this.btn_submit.UseVisualStyleBackColor = true;
            this.btn_submit.Click += new System.EventHandler(this.btn_submit_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Customer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(484, 461);
            this.Controls.Add(this.btn_submit);
            this.Controls.Add(this.cb_gender);
            this.Controls.Add(this.tb_address);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.bn_customer);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.dt_birth);
            this.Controls.Add(this.tb_phone);
            this.Controls.Add(this.tb_idno);
            this.Controls.Add(this.cb_type);
            this.Controls.Add(this.tb_name);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_idcust);
            this.Controls.Add(this.label1);
            this.Name = "Customer";
            this.Text = "Customer";
            this.Load += new System.EventHandler(this.Customer_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.tbcustomerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rent_houseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bn_customer)).EndInit();
            this.bn_customer.ResumeLayout(false);
            this.bn_customer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_idcust;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tb_name;
        private System.Windows.Forms.ComboBox cb_type;
        private System.Windows.Forms.TextBox tb_idno;
        private System.Windows.Forms.TextBox tb_phone;
        private System.Windows.Forms.DateTimePicker dt_birth;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.BindingNavigator bn_customer;
        private System.Windows.Forms.ToolStripButton bn_add;
        private System.Windows.Forms.ToolStripLabel bn_count;
        private System.Windows.Forms.ToolStripButton bn_delete;
        private System.Windows.Forms.ToolStripButton bn_first;
        private System.Windows.Forms.ToolStripButton bn_previous;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bn_position;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bn_next;
        private System.Windows.Forms.ToolStripButton bn_last;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private rent_houseDataSet rent_houseDataSet;
        private System.Windows.Forms.BindingSource tbcustomerBindingSource;
        private rent_houseDataSetTableAdapters.tb_customerTableAdapter tb_customerTableAdapter;
        private System.Windows.Forms.TextBox tb_address;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cb_gender;
        private System.Windows.Forms.Button btn_submit;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}

