namespace RentHouse
{
    partial class Rent
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
            this.label1 = new System.Windows.Forms.Label();
            this.tbrentBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.rent_houseDataSet1 = new RentHouse.rent_houseDataSet();
            this.btn_update = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.tbrentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rent_houseDataSet = new RentHouse.rent_houseDataSet();
            this.tb_rentTableAdapter = new RentHouse.rent_houseDataSetTableAdapters.tb_rentTableAdapter();
            this.tb_roomTableAdapter = new RentHouse.rent_houseDataSetTableAdapters.tb_roomTableAdapter();
            this.tableAdapterManager = new RentHouse.rent_houseDataSetTableAdapters.TableAdapterManager();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.cb_idtrans = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.tbrentBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rent_houseDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbrentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rent_houseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Khaki;
            this.label1.Location = new System.Drawing.Point(189, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Rent";
            // 
            // tbrentBindingSource1
            // 
            this.tbrentBindingSource1.DataMember = "tb_rent";
            this.tbrentBindingSource1.DataSource = this.rent_houseDataSet1;
            // 
            // rent_houseDataSet1
            // 
            this.rent_houseDataSet1.DataSetName = "rent_houseDataSet";
            this.rent_houseDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btn_update
            // 
            this.btn_update.Location = new System.Drawing.Point(205, 305);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(75, 23);
            this.btn_update.TabIndex = 39;
            this.btn_update.Text = "Out";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Khaki;
            this.label7.Location = new System.Drawing.Point(100, 170);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 13);
            this.label7.TabIndex = 42;
            this.label7.Text = "ID Transaction";
            this.label7.Click += new System.EventHandler(this.label7_Click);
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
            // tb_rentTableAdapter
            // 
            this.tb_rentTableAdapter.ClearBeforeFill = true;
            // 
            // tb_roomTableAdapter
            // 
            this.tb_roomTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.tb_customerTableAdapter = null;
            this.tableAdapterManager.tb_monthly_paidTableAdapter = null;
            this.tableAdapterManager.tb_rentTableAdapter = null;
            this.tableAdapterManager.tb_roomTableAdapter = this.tb_roomTableAdapter;
            this.tableAdapterManager.tb_type_roomTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = RentHouse.rent_houseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // cb_idtrans
            // 
            this.cb_idtrans.DataSource = this.tbrentBindingSource1;
            this.cb_idtrans.DisplayMember = "id_room";
            this.cb_idtrans.FormattingEnabled = true;
            this.cb_idtrans.Location = new System.Drawing.Point(205, 167);
            this.cb_idtrans.Name = "cb_idtrans";
            this.cb_idtrans.Size = new System.Drawing.Size(97, 21);
            this.cb_idtrans.TabIndex = 46;
            this.cb_idtrans.ValueMember = "id_room";
            this.cb_idtrans.SelectedIndexChanged += new System.EventHandler(this.cb_idtrans_SelectedIndexChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(340, 114);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(335, 150);
            this.dataGridView1.TabIndex = 48;
            // 
            // Rent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(702, 461);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.cb_idtrans);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.label1);
            this.Name = "Rent";
            this.Text = "Rent";
            this.Load += new System.EventHandler(this.Rent_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tbrentBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rent_houseDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbrentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rent_houseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Label label7;
        private rent_houseDataSet rent_houseDataSet;
        private System.Windows.Forms.BindingSource tbrentBindingSource;
        private rent_houseDataSetTableAdapters.tb_rentTableAdapter tb_rentTableAdapter;
        private rent_houseDataSet rent_houseDataSet1;
        private System.Windows.Forms.BindingSource tbrentBindingSource1;
        private rent_houseDataSetTableAdapters.tb_roomTableAdapter tb_roomTableAdapter;
        private rent_houseDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ComboBox cb_idtrans;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}