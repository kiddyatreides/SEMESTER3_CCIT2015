namespace RentHouse
{
    partial class RentIn
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
            this.cb_idroom = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_idtrans = new System.Windows.Forms.TextBox();
            this.tbrentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rent_houseDataSet = new RentHouse.rent_houseDataSet();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tb_rentTableAdapter = new RentHouse.rent_houseDataSetTableAdapters.tb_rentTableAdapter();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_search = new System.Windows.Forms.TextBox();
            this.btn_search = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tbrentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rent_houseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // cb_idroom
            // 
            this.cb_idroom.DisplayMember = "id_room";
            this.cb_idroom.FormattingEnabled = true;
            this.cb_idroom.Location = new System.Drawing.Point(216, 189);
            this.cb_idroom.Name = "cb_idroom";
            this.cb_idroom.Size = new System.Drawing.Size(97, 21);
            this.cb_idroom.TabIndex = 49;
            this.cb_idroom.ValueMember = "id_room";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Khaki;
            this.label7.Location = new System.Drawing.Point(106, 142);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 13);
            this.label7.TabIndex = 48;
            this.label7.Text = "ID Transaction";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Khaki;
            this.label1.Location = new System.Drawing.Point(162, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 36);
            this.label1.TabIndex = 47;
            this.label1.Text = "Rent";
            // 
            // tb_idtrans
            // 
            this.tb_idtrans.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbrentBindingSource, "id_rent", true));
            this.tb_idtrans.Location = new System.Drawing.Point(213, 139);
            this.tb_idtrans.Name = "tb_idtrans";
            this.tb_idtrans.Size = new System.Drawing.Size(100, 20);
            this.tb_idtrans.TabIndex = 50;
            // 
            // tbrentBindingSource
            // 
            this.tbrentBindingSource.DataMember = "tb_rent";
            this.tbrentBindingSource.DataSource = this.rent_houseDataSet;
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
            this.label2.Location = new System.Drawing.Point(106, 192);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 51;
            this.label2.Text = "ID Room";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(346, 139);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(423, 150);
            this.dataGridView1.TabIndex = 52;
            // 
            // tb_rentTableAdapter
            // 
            this.tb_rentTableAdapter.ClearBeforeFill = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Khaki;
            this.label3.Location = new System.Drawing.Point(106, 235);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 54;
            this.label3.Text = "Customer ID";
            // 
            // comboBox1
            // 
            this.comboBox1.DisplayMember = "id_room";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(216, 232);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(97, 21);
            this.comboBox1.TabIndex = 53;
            this.comboBox1.ValueMember = "id_room";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(229, 314);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 55;
            this.button1.Text = "Submit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(213, 273);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 57;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Khaki;
            this.label4.Location = new System.Drawing.Point(106, 276);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 13);
            this.label4.TabIndex = 56;
            this.label4.Text = "Customer Name";
            // 
            // tb_search
            // 
            this.tb_search.Location = new System.Drawing.Point(419, 92);
            this.tb_search.Name = "tb_search";
            this.tb_search.Size = new System.Drawing.Size(100, 20);
            this.tb_search.TabIndex = 58;
            // 
            // btn_search
            // 
            this.btn_search.Location = new System.Drawing.Point(546, 90);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(75, 23);
            this.btn_search.TabIndex = 59;
            this.btn_search.Text = "Search";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // RentIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(790, 384);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.tb_search);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_idtrans);
            this.Controls.Add(this.cb_idroom);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label1);
            this.Name = "RentIn";
            this.Text = "RentIn";
            this.Load += new System.EventHandler(this.RentIn_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tbrentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rent_houseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cb_idroom;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_idtrans;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private rent_houseDataSet rent_houseDataSet;
        private System.Windows.Forms.BindingSource tbrentBindingSource;
        private rent_houseDataSetTableAdapters.tb_rentTableAdapter tb_rentTableAdapter;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.TextBox tb_search;
    }
}