namespace RentHouse
{
    partial class Laundry
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Laundry));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cb_idcust = new System.Windows.Forms.ComboBox();
            this.cb_idroom = new System.Windows.Forms.ComboBox();
            this.dt_datetake = new System.Windows.Forms.DateTimePicker();
            this.dt_rdatetake = new System.Windows.Forms.DateTimePicker();
            this.cb_type = new System.Windows.Forms.ComboBox();
            this.lbl_total = new System.Windows.Forms.Label();
            this.bn_laundry = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.dt_datetime = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.bn_laundry)).BeginInit();
            this.bn_laundry.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Khaki;
            this.label1.Location = new System.Drawing.Point(180, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Laundry";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Khaki;
            this.label2.Location = new System.Drawing.Point(99, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "ID Customer";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Khaki;
            this.label3.Location = new System.Drawing.Point(99, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "ID Room";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Khaki;
            this.label4.Location = new System.Drawing.Point(99, 198);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Date Time";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Khaki;
            this.label5.Location = new System.Drawing.Point(99, 229);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Date Take";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Khaki;
            this.label6.Location = new System.Drawing.Point(99, 259);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Real Date Take";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Khaki;
            this.label7.Location = new System.Drawing.Point(99, 293);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Type";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.Khaki;
            this.label9.Location = new System.Drawing.Point(99, 326);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(31, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "Total";
            // 
            // cb_idcust
            // 
            this.cb_idcust.FormattingEnabled = true;
            this.cb_idcust.Location = new System.Drawing.Point(200, 135);
            this.cb_idcust.Name = "cb_idcust";
            this.cb_idcust.Size = new System.Drawing.Size(200, 21);
            this.cb_idcust.TabIndex = 9;
            // 
            // cb_idroom
            // 
            this.cb_idroom.FormattingEnabled = true;
            this.cb_idroom.Location = new System.Drawing.Point(200, 165);
            this.cb_idroom.Name = "cb_idroom";
            this.cb_idroom.Size = new System.Drawing.Size(200, 21);
            this.cb_idroom.TabIndex = 10;
            // 
            // dt_datetake
            // 
            this.dt_datetake.Location = new System.Drawing.Point(200, 222);
            this.dt_datetake.Name = "dt_datetake";
            this.dt_datetake.Size = new System.Drawing.Size(200, 20);
            this.dt_datetake.TabIndex = 11;
            // 
            // dt_rdatetake
            // 
            this.dt_rdatetake.Location = new System.Drawing.Point(200, 254);
            this.dt_rdatetake.Name = "dt_rdatetake";
            this.dt_rdatetake.Size = new System.Drawing.Size(200, 20);
            this.dt_rdatetake.TabIndex = 13;
            // 
            // cb_type
            // 
            this.cb_type.FormattingEnabled = true;
            this.cb_type.Location = new System.Drawing.Point(200, 289);
            this.cb_type.Name = "cb_type";
            this.cb_type.Size = new System.Drawing.Size(200, 21);
            this.cb_type.TabIndex = 14;
            // 
            // lbl_total
            // 
            this.lbl_total.AutoSize = true;
            this.lbl_total.ForeColor = System.Drawing.Color.Khaki;
            this.lbl_total.Location = new System.Drawing.Point(200, 325);
            this.lbl_total.MaximumSize = new System.Drawing.Size(50, 50);
            this.lbl_total.Name = "lbl_total";
            this.lbl_total.Size = new System.Drawing.Size(19, 13);
            this.lbl_total.TabIndex = 15;
            this.lbl_total.Text = "  0";
            // 
            // bn_laundry
            // 
            this.bn_laundry.AddNewItem = this.bn_add;
            this.bn_laundry.CountItem = this.bn_count;
            this.bn_laundry.DeleteItem = this.bn_delete;
            this.bn_laundry.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.bn_laundry.Location = new System.Drawing.Point(0, 0);
            this.bn_laundry.MoveFirstItem = this.bn_first;
            this.bn_laundry.MoveLastItem = this.bn_last;
            this.bn_laundry.MoveNextItem = this.bn_next;
            this.bn_laundry.MovePreviousItem = this.bn_previous;
            this.bn_laundry.Name = "bn_laundry";
            this.bn_laundry.PositionItem = this.bn_position;
            this.bn_laundry.Size = new System.Drawing.Size(484, 25);
            this.bn_laundry.TabIndex = 19;
            this.bn_laundry.Text = "bindingNavigator1";
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
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(200, 370);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(75, 23);
            this.btn_add.TabIndex = 20;
            this.btn_add.Text = "Add";
            this.btn_add.UseVisualStyleBackColor = true;
            // 
            // btn_update
            // 
            this.btn_update.Location = new System.Drawing.Point(294, 370);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(75, 23);
            this.btn_update.TabIndex = 21;
            this.btn_update.Text = "Update";
            this.btn_update.UseVisualStyleBackColor = true;
            // 
            // dt_datetime
            // 
            this.dt_datetime.Location = new System.Drawing.Point(200, 195);
            this.dt_datetime.Name = "dt_datetime";
            this.dt_datetime.Size = new System.Drawing.Size(200, 20);
            this.dt_datetime.TabIndex = 22;
            // 
            // Laundry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(484, 461);
            this.Controls.Add(this.dt_datetime);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.bn_laundry);
            this.Controls.Add(this.lbl_total);
            this.Controls.Add(this.cb_type);
            this.Controls.Add(this.dt_rdatetake);
            this.Controls.Add(this.dt_datetake);
            this.Controls.Add(this.cb_idroom);
            this.Controls.Add(this.cb_idcust);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Laundry";
            this.Text = "Laundry";
            ((System.ComponentModel.ISupportInitialize)(this.bn_laundry)).EndInit();
            this.bn_laundry.ResumeLayout(false);
            this.bn_laundry.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cb_idcust;
        private System.Windows.Forms.ComboBox cb_idroom;
        private System.Windows.Forms.DateTimePicker dt_datetake;
        private System.Windows.Forms.DateTimePicker dt_rdatetake;
        private System.Windows.Forms.ComboBox cb_type;
        private System.Windows.Forms.Label lbl_total;
        private System.Windows.Forms.BindingNavigator bn_laundry;
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
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.DateTimePicker dt_datetime;
    }
}