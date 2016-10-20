namespace RentHouse
{
    partial class RMonthlyPaid
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
            this.CrystalReport31 = new RentHouse.CrystalReport3();
            this.rent_houseDataSet = new RentHouse.rent_houseDataSet();
            this.tbmonthlypaidBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tb_monthly_paidTableAdapter = new RentHouse.rent_houseDataSetTableAdapters.tb_monthly_paidTableAdapter();
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.rent_houseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbmonthlypaidBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // rent_houseDataSet
            // 
            this.rent_houseDataSet.DataSetName = "rent_houseDataSet";
            this.rent_houseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbmonthlypaidBindingSource
            // 
            this.tbmonthlypaidBindingSource.DataMember = "tb_monthly_paid";
            this.tbmonthlypaidBindingSource.DataSource = this.rent_houseDataSet;
            // 
            // tb_monthly_paidTableAdapter
            // 
            this.tb_monthly_paidTableAdapter.ClearBeforeFill = true;
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = 0;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalReportViewer1.Location = new System.Drawing.Point(0, 0);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.ReportSource = this.CrystalReport31;
            this.crystalReportViewer1.Size = new System.Drawing.Size(868, 535);
            this.crystalReportViewer1.TabIndex = 0;
            // 
            // RMonthlyPaid
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(868, 535);
            this.Controls.Add(this.crystalReportViewer1);
            this.Name = "RMonthlyPaid";
            this.Text = "RMonthlyPaid";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.RMonthlyPaid_Load);
            ((System.ComponentModel.ISupportInitialize)(this.rent_houseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbmonthlypaidBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        //private CRMonthlyPaid CRMonthlyPaid1;
        private CrystalReport3 CrystalReport31;
        private rent_houseDataSet rent_houseDataSet;
        private System.Windows.Forms.BindingSource tbmonthlypaidBindingSource;
        private rent_houseDataSetTableAdapters.tb_monthly_paidTableAdapter tb_monthly_paidTableAdapter;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        //private CrystalReport4 CrystalReport41;
    }
}