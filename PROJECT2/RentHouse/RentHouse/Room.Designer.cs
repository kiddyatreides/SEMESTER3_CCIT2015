namespace RentHouse
{
    partial class Room
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Room));
            this.label3 = new System.Windows.Forms.Label();
            this.bn_room = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.label1 = new System.Windows.Forms.Label();
            this.tb_idroom = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_name = new System.Windows.Forms.TextBox();
            this.tb_price = new System.Windows.Forms.TextBox();
            this.cb_type = new System.Windows.Forms.ComboBox();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.rent_houseDataSet = new RentHouse.rent_houseDataSet();
            this.tbroomBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tb_roomTableAdapter = new RentHouse.rent_houseDataSetTableAdapters.tb_roomTableAdapter();
            this.renthouseDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbtyperoomBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tb_type_roomTableAdapter = new RentHouse.rent_houseDataSetTableAdapters.tb_type_roomTableAdapter();
            this.idtyperoomDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bn_room)).BeginInit();
            this.bn_room.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rent_houseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbroomBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.renthouseDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbtyperoomBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Khaki;
            this.label3.Location = new System.Drawing.Point(107, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 34;
            this.label3.Text = "ID Room";
            // 
            // bn_room
            // 
            this.bn_room.AddNewItem = this.bn_add;
            this.bn_room.BindingSource = this.tbroomBindingSource;
            this.bn_room.CountItem = this.bn_count;
            this.bn_room.DeleteItem = this.bn_delete;
            this.bn_room.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.bn_delete});
            this.bn_room.Location = new System.Drawing.Point(0, 0);
            this.bn_room.MoveFirstItem = this.bn_first;
            this.bn_room.MoveLastItem = this.bn_last;
            this.bn_room.MoveNextItem = this.bn_next;
            this.bn_room.MovePreviousItem = this.bn_previous;
            this.bn_room.Name = "bn_room";
            this.bn_room.PositionItem = this.bn_position;
            this.bn_room.Size = new System.Drawing.Size(875, 25);
            this.bn_room.TabIndex = 33;
            this.bn_room.Text = "bindingNavigator1";
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Khaki;
            this.label1.Location = new System.Drawing.Point(204, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 36);
            this.label1.TabIndex = 32;
            this.label1.Text = "Room";
            // 
            // tb_idroom
            // 
            this.tb_idroom.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbroomBindingSource, "id_room", true));
            this.tb_idroom.Location = new System.Drawing.Point(209, 126);
            this.tb_idroom.Name = "tb_idroom";
            this.tb_idroom.Size = new System.Drawing.Size(156, 20);
            this.tb_idroom.TabIndex = 35;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Khaki;
            this.label2.Location = new System.Drawing.Point(110, 179);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 36;
            this.label2.Text = "Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Khaki;
            this.label4.Location = new System.Drawing.Point(110, 226);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 37;
            this.label4.Text = "Type";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Khaki;
            this.label5.Location = new System.Drawing.Point(113, 277);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 38;
            this.label5.Text = "Price";
            // 
            // tb_name
            // 
            this.tb_name.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbroomBindingSource, "name", true));
            this.tb_name.Location = new System.Drawing.Point(209, 172);
            this.tb_name.Name = "tb_name";
            this.tb_name.Size = new System.Drawing.Size(156, 20);
            this.tb_name.TabIndex = 39;
            // 
            // tb_price
            // 
            this.tb_price.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbroomBindingSource, "price", true));
            this.tb_price.Location = new System.Drawing.Point(209, 274);
            this.tb_price.Name = "tb_price";
            this.tb_price.Size = new System.Drawing.Size(156, 20);
            this.tb_price.TabIndex = 40;
            // 
            // cb_type
            // 
            this.cb_type.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbroomBindingSource, "id_type_room", true));
            this.cb_type.DataSource = this.tbtyperoomBindingSource;
            this.cb_type.DisplayMember = "id_type_room";
            this.cb_type.FormattingEnabled = true;
            this.cb_type.Location = new System.Drawing.Point(209, 217);
            this.cb_type.Name = "cb_type";
            this.cb_type.Size = new System.Drawing.Size(156, 21);
            this.cb_type.TabIndex = 41;
            this.cb_type.ValueMember = "id_type_room";
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(325, 83);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(75, 23);
            this.btn_add.TabIndex = 44;
            this.btn_add.Text = "Add";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_update
            // 
            this.btn_update.Location = new System.Drawing.Point(291, 337);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(75, 23);
            this.btn_update.TabIndex = 45;
            this.btn_update.Text = "Update";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idtyperoomDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tbtyperoomBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(406, 126);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(414, 150);
            this.dataGridView1.TabIndex = 46;
            // 
            // rent_houseDataSet
            // 
            this.rent_houseDataSet.DataSetName = "rent_houseDataSet";
            this.rent_houseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbroomBindingSource
            // 
            this.tbroomBindingSource.DataMember = "tb_room";
            this.tbroomBindingSource.DataSource = this.rent_houseDataSet;
            // 
            // tb_roomTableAdapter
            // 
            this.tb_roomTableAdapter.ClearBeforeFill = true;
            // 
            // renthouseDataSetBindingSource
            // 
            this.renthouseDataSetBindingSource.DataSource = this.rent_houseDataSet;
            this.renthouseDataSetBindingSource.Position = 0;
            // 
            // tbtyperoomBindingSource
            // 
            this.tbtyperoomBindingSource.DataMember = "tb_type_room";
            this.tbtyperoomBindingSource.DataSource = this.renthouseDataSetBindingSource;
            // 
            // tb_type_roomTableAdapter
            // 
            this.tb_type_roomTableAdapter.ClearBeforeFill = true;
            // 
            // idtyperoomDataGridViewTextBoxColumn
            // 
            this.idtyperoomDataGridViewTextBoxColumn.DataPropertyName = "id_type_room";
            this.idtyperoomDataGridViewTextBoxColumn.HeaderText = "id_type_room";
            this.idtyperoomDataGridViewTextBoxColumn.Name = "idtyperoomDataGridViewTextBoxColumn";
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "description";
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(207, 337);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 47;
            this.button1.Text = "Submit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Room
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(875, 461);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.cb_type);
            this.Controls.Add(this.tb_price);
            this.Controls.Add(this.tb_name);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_idroom);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.bn_room);
            this.Controls.Add(this.label1);
            this.Name = "Room";
            this.Text = "Room";
            this.Load += new System.EventHandler(this.Room_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bn_room)).EndInit();
            this.bn_room.ResumeLayout(false);
            this.bn_room.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rent_houseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbroomBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.renthouseDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbtyperoomBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.BindingNavigator bn_room;
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_idroom;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_name;
        private System.Windows.Forms.TextBox tb_price;
        private System.Windows.Forms.ComboBox cb_type;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.DataGridView dataGridView1;
        private rent_houseDataSet rent_houseDataSet;
        private System.Windows.Forms.BindingSource tbroomBindingSource;
        private rent_houseDataSetTableAdapters.tb_roomTableAdapter tb_roomTableAdapter;
        private System.Windows.Forms.BindingSource renthouseDataSetBindingSource;
        private System.Windows.Forms.BindingSource tbtyperoomBindingSource;
        private rent_houseDataSetTableAdapters.tb_type_roomTableAdapter tb_type_roomTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idtyperoomDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button button1;
    }
}