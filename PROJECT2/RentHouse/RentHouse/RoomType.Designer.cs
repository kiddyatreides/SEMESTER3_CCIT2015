namespace RentHouse
{
    partial class RoomType
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RoomType));
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.btn_submit = new System.Windows.Forms.Button();
            this.bn_position = new System.Windows.Forms.ToolStripTextBox();
            this.bn_count = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bn_customer = new System.Windows.Forms.BindingNavigator(this.components);
            this.tbtyperoomBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rent_houseDataSet = new RentHouse.rent_houseDataSet();
            this.bn_first = new System.Windows.Forms.ToolStripButton();
            this.bn_previous = new System.Windows.Forms.ToolStripButton();
            this.bn_next = new System.Windows.Forms.ToolStripButton();
            this.bn_last = new System.Windows.Forms.ToolStripButton();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.tb_name = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_idcust = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tb_type_roomTableAdapter = new RentHouse.rent_houseDataSetTableAdapters.tb_type_roomTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.bn_customer)).BeginInit();
            this.bn_customer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbtyperoomBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rent_houseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // btn_submit
            // 
            this.btn_submit.Location = new System.Drawing.Point(217, 245);
            this.btn_submit.Name = "btn_submit";
            this.btn_submit.Size = new System.Drawing.Size(75, 23);
            this.btn_submit.TabIndex = 43;
            this.btn_submit.Text = "Submit";
            this.btn_submit.UseVisualStyleBackColor = true;
            this.btn_submit.Click += new System.EventHandler(this.btn_submit_Click);
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
            // bn_count
            // 
            this.bn_count.Name = "bn_count";
            this.bn_count.Size = new System.Drawing.Size(35, 22);
            this.bn_count.Text = "of {0}";
            this.bn_count.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // bn_customer
            // 
            this.bn_customer.AddNewItem = null;
            this.bn_customer.BindingSource = this.tbtyperoomBindingSource;
            this.bn_customer.CountItem = this.bn_count;
            this.bn_customer.DeleteItem = null;
            this.bn_customer.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bn_first,
            this.bn_previous,
            this.bindingNavigatorSeparator,
            this.bn_position,
            this.bn_count,
            this.bindingNavigatorSeparator1,
            this.bn_next,
            this.bn_last,
            this.bindingNavigatorSeparator2});
            this.bn_customer.Location = new System.Drawing.Point(0, 0);
            this.bn_customer.MoveFirstItem = this.bn_first;
            this.bn_customer.MoveLastItem = this.bn_last;
            this.bn_customer.MoveNextItem = this.bn_next;
            this.bn_customer.MovePreviousItem = this.bn_previous;
            this.bn_customer.Name = "bn_customer";
            this.bn_customer.PositionItem = this.bn_position;
            this.bn_customer.Size = new System.Drawing.Size(897, 25);
            this.bn_customer.TabIndex = 39;
            this.bn_customer.Text = "bindingNavigator1";
            // 
            // tbtyperoomBindingSource
            // 
            this.tbtyperoomBindingSource.DataMember = "tb_type_room";
            this.tbtyperoomBindingSource.DataSource = this.rent_houseDataSet;
            // 
            // rent_houseDataSet
            // 
            this.rent_houseDataSet.DataSetName = "rent_houseDataSet";
            this.rent_houseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // btn_update
            // 
            this.btn_update.Location = new System.Drawing.Point(322, 245);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(75, 23);
            this.btn_update.TabIndex = 38;
            this.btn_update.Text = "Update";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(64, 67);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(75, 23);
            this.btn_add.TabIndex = 37;
            this.btn_add.Text = "Add";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // tb_name
            // 
            this.tb_name.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbtyperoomBindingSource, "name", true));
            this.tb_name.Location = new System.Drawing.Point(217, 156);
            this.tb_name.Name = "tb_name";
            this.tb_name.Size = new System.Drawing.Size(180, 20);
            this.tb_name.TabIndex = 32;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Khaki;
            this.label4.Location = new System.Drawing.Point(113, 193);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 27;
            this.label4.Text = "Description";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Khaki;
            this.label3.Location = new System.Drawing.Point(113, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 26;
            this.label3.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Khaki;
            this.label2.Location = new System.Drawing.Point(113, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 25;
            this.label2.Text = "ID Type Room";
            // 
            // tb_idcust
            // 
            this.tb_idcust.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbtyperoomBindingSource, "id_type_room", true));
            this.tb_idcust.Location = new System.Drawing.Point(217, 120);
            this.tb_idcust.Name = "tb_idcust";
            this.tb_idcust.Size = new System.Drawing.Size(180, 20);
            this.tb_idcust.TabIndex = 24;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Khaki;
            this.label1.Location = new System.Drawing.Point(199, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 36);
            this.label1.TabIndex = 23;
            this.label1.Text = "Customer";
            // 
            // textBox1
            // 
            this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbtyperoomBindingSource, "description", true));
            this.textBox1.Location = new System.Drawing.Point(217, 190);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(180, 20);
            this.textBox1.TabIndex = 44;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(433, 120);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(429, 163);
            this.dataGridView1.TabIndex = 45;
            // 
            // tb_type_roomTableAdapter
            // 
            this.tb_type_roomTableAdapter.ClearBeforeFill = true;
            // 
            // RoomType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(897, 436);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btn_submit);
            this.Controls.Add(this.bn_customer);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.tb_name);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_idcust);
            this.Controls.Add(this.label1);
            this.Name = "RoomType";
            this.Text = "RoomType";
            this.Load += new System.EventHandler(this.RoomType_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bn_customer)).EndInit();
            this.bn_customer.ResumeLayout(false);
            this.bn_customer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbtyperoomBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rent_houseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.Button btn_submit;
        private System.Windows.Forms.ToolStripButton bn_previous;
        private System.Windows.Forms.ToolStripTextBox bn_position;
        private System.Windows.Forms.ToolStripLabel bn_count;
        private System.Windows.Forms.ToolStripButton bn_first;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bn_next;
        private System.Windows.Forms.ToolStripButton bn_last;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.BindingNavigator bn_customer;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.TextBox tb_name;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_idcust;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBox1;
        private rent_houseDataSet rent_houseDataSet;
        private System.Windows.Forms.BindingSource tbtyperoomBindingSource;
        private rent_houseDataSetTableAdapters.tb_type_roomTableAdapter tb_type_roomTableAdapter;
    }
}