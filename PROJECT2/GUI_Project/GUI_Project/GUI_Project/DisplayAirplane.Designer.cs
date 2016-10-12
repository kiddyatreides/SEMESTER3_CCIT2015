namespace GUI_Project
{
    partial class DisplayAirplane
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DisplayAirplane));
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tbox_search = new System.Windows.Forms.TextBox();
            this.btn_search = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbox_idairplane = new System.Windows.Forms.TextBox();
            this.tbox_name = new System.Windows.Forms.TextBox();
            this.tbox_type = new System.Windows.Forms.TextBox();
            this.tbox_totalseat = new System.Windows.Forms.TextBox();
            this.tbox_status = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_refresh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(204, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Display Airplane";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(45, 221);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(430, 115);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // tbox_search
            // 
            this.tbox_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbox_search.Location = new System.Drawing.Point(45, 46);
            this.tbox_search.Multiline = true;
            this.tbox_search.Name = "tbox_search";
            this.tbox_search.Size = new System.Drawing.Size(360, 37);
            this.tbox_search.TabIndex = 2;
            // 
            // btn_search
            // 
            this.btn_search.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_search.BackgroundImage")));
            this.btn_search.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_search.Location = new System.Drawing.Point(431, 46);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(44, 37);
            this.btn_search.TabIndex = 3;
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "ID Airplane";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(50, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(259, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Type";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(259, 137);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Total Seat";
            // 
            // tbox_idairplane
            // 
            this.tbox_idairplane.Location = new System.Drawing.Point(115, 95);
            this.tbox_idairplane.Name = "tbox_idairplane";
            this.tbox_idairplane.ReadOnly = true;
            this.tbox_idairplane.Size = new System.Drawing.Size(123, 20);
            this.tbox_idairplane.TabIndex = 8;
            // 
            // tbox_name
            // 
            this.tbox_name.Location = new System.Drawing.Point(115, 134);
            this.tbox_name.Name = "tbox_name";
            this.tbox_name.ReadOnly = true;
            this.tbox_name.Size = new System.Drawing.Size(123, 20);
            this.tbox_name.TabIndex = 9;
            // 
            // tbox_type
            // 
            this.tbox_type.Location = new System.Drawing.Point(321, 95);
            this.tbox_type.Name = "tbox_type";
            this.tbox_type.ReadOnly = true;
            this.tbox_type.Size = new System.Drawing.Size(123, 20);
            this.tbox_type.TabIndex = 10;
            // 
            // tbox_totalseat
            // 
            this.tbox_totalseat.Location = new System.Drawing.Point(321, 134);
            this.tbox_totalseat.Name = "tbox_totalseat";
            this.tbox_totalseat.ReadOnly = true;
            this.tbox_totalseat.Size = new System.Drawing.Size(123, 20);
            this.tbox_totalseat.TabIndex = 11;
            // 
            // tbox_status
            // 
            this.tbox_status.Location = new System.Drawing.Point(321, 169);
            this.tbox_status.Name = "tbox_status";
            this.tbox_status.ReadOnly = true;
            this.tbox_status.Size = new System.Drawing.Size(123, 20);
            this.tbox_status.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(259, 172);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Status";
            // 
            // btn_refresh
            // 
            this.btn_refresh.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_refresh.BackgroundImage")));
            this.btn_refresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_refresh.Location = new System.Drawing.Point(49, 172);
            this.btn_refresh.Name = "btn_refresh";
            this.btn_refresh.Size = new System.Drawing.Size(101, 43);
            this.btn_refresh.TabIndex = 14;
            this.btn_refresh.UseVisualStyleBackColor = true;
            this.btn_refresh.Click += new System.EventHandler(this.btn_refresh_Click);
            // 
            // DisplayAirplane
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(520, 415);
            this.Controls.Add(this.btn_refresh);
            this.Controls.Add(this.tbox_status);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbox_totalseat);
            this.Controls.Add(this.tbox_type);
            this.Controls.Add(this.tbox_name);
            this.Controls.Add(this.tbox_idairplane);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.tbox_search);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Name = "DisplayAirplane";
            this.Text = "Display Airplane";
            this.Load += new System.EventHandler(this.DisplayAirplane_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox tbox_search;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbox_idairplane;
        private System.Windows.Forms.TextBox tbox_name;
        private System.Windows.Forms.TextBox tbox_type;
        private System.Windows.Forms.TextBox tbox_totalseat;
        private System.Windows.Forms.TextBox tbox_status;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_refresh;
    }
}