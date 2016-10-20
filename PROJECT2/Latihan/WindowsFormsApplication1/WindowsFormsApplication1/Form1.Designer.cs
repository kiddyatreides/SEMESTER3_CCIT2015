namespace WindowsFormsApplication1
{
    partial class Form1
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.latihanDataSet = new WindowsFormsApplication1.latihanDataSet();
            this.tbadminBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tb_adminTableAdapter = new WindowsFormsApplication1.latihanDataSetTableAdapters.tb_adminTableAdapter();
            this.idadminDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jkDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.latihanDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbadminBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idadminDataGridViewTextBoxColumn,
            this.namaDataGridViewTextBoxColumn,
            this.jkDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tbadminBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(55, 62);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(370, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // latihanDataSet
            // 
            this.latihanDataSet.DataSetName = "latihanDataSet";
            this.latihanDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbadminBindingSource
            // 
            this.tbadminBindingSource.DataMember = "tb_admin";
            this.tbadminBindingSource.DataSource = this.latihanDataSet;
            // 
            // tb_adminTableAdapter
            // 
            this.tb_adminTableAdapter.ClearBeforeFill = true;
            // 
            // idadminDataGridViewTextBoxColumn
            // 
            this.idadminDataGridViewTextBoxColumn.DataPropertyName = "id_admin";
            this.idadminDataGridViewTextBoxColumn.HeaderText = "id_admin";
            this.idadminDataGridViewTextBoxColumn.Name = "idadminDataGridViewTextBoxColumn";
            // 
            // namaDataGridViewTextBoxColumn
            // 
            this.namaDataGridViewTextBoxColumn.DataPropertyName = "nama";
            this.namaDataGridViewTextBoxColumn.HeaderText = "nama";
            this.namaDataGridViewTextBoxColumn.Name = "namaDataGridViewTextBoxColumn";
            // 
            // jkDataGridViewTextBoxColumn
            // 
            this.jkDataGridViewTextBoxColumn.DataPropertyName = "jk";
            this.jkDataGridViewTextBoxColumn.HeaderText = "jk";
            this.jkDataGridViewTextBoxColumn.Name = "jkDataGridViewTextBoxColumn";
            // 
            // comboBox1
            // 
            this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.tbadminBindingSource, "id_admin", true));
            this.comboBox1.DataSource = this.tbadminBindingSource;
            this.comboBox1.DisplayMember = "nama";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(85, 261);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.ValueMember = "id_admin";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 312);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.latihanDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbadminBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private latihanDataSet latihanDataSet;
        private System.Windows.Forms.BindingSource tbadminBindingSource;
        private latihanDataSetTableAdapters.tb_adminTableAdapter tb_adminTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idadminDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn namaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jkDataGridViewTextBoxColumn;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}

