namespace GUI_Project
{
    partial class UpdateAirplane
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdateAirplane));
            this.label5 = new System.Windows.Forms.Label();
            this.btn_clear = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.numeric_totalseat = new System.Windows.Forms.NumericUpDown();
            this.cbox_typeairplane = new System.Windows.Forms.ComboBox();
            this.tbox_nameairplane = new System.Windows.Forms.TextBox();
            this.tbox_idairplane = new System.Windows.Forms.TextBox();
            this.error_addairplane = new System.Windows.Forms.ErrorProvider(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_search = new System.Windows.Forms.Button();
            this.tbox_search = new System.Windows.Forms.TextBox();
            this.cbox_status = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_totalseat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.error_addairplane)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(128, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(124, 20);
            this.label5.TabIndex = 32;
            this.label5.Text = "Update Airplane";
            // 
            // btn_clear
            // 
            this.btn_clear.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_clear.BackgroundImage")));
            this.btn_clear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_clear.Location = new System.Drawing.Point(210, 322);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(106, 50);
            this.btn_clear.TabIndex = 31;
            this.btn_clear.UseVisualStyleBackColor = true;
            // 
            // btn_update
            // 
            this.btn_update.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_update.BackgroundImage")));
            this.btn_update.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_update.Location = new System.Drawing.Point(78, 322);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(106, 50);
            this.btn_update.TabIndex = 30;
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // numeric_totalseat
            // 
            this.numeric_totalseat.Location = new System.Drawing.Point(174, 229);
            this.numeric_totalseat.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.numeric_totalseat.Name = "numeric_totalseat";
            this.numeric_totalseat.Size = new System.Drawing.Size(51, 20);
            this.numeric_totalseat.TabIndex = 29;
            // 
            // cbox_typeairplane
            // 
            this.cbox_typeairplane.FormattingEnabled = true;
            this.cbox_typeairplane.Items.AddRange(new object[] {
            "Economy",
            "Executive",
            "Private"});
            this.cbox_typeairplane.Location = new System.Drawing.Point(174, 186);
            this.cbox_typeairplane.Name = "cbox_typeairplane";
            this.cbox_typeairplane.Size = new System.Drawing.Size(100, 21);
            this.cbox_typeairplane.TabIndex = 28;
            // 
            // tbox_nameairplane
            // 
            this.tbox_nameairplane.Location = new System.Drawing.Point(174, 148);
            this.tbox_nameairplane.Name = "tbox_nameairplane";
            this.tbox_nameairplane.Size = new System.Drawing.Size(100, 20);
            this.tbox_nameairplane.TabIndex = 27;
            // 
            // tbox_idairplane
            // 
            this.tbox_idairplane.Location = new System.Drawing.Point(174, 114);
            this.tbox_idairplane.Name = "tbox_idairplane";
            this.tbox_idairplane.ReadOnly = true;
            this.tbox_idairplane.Size = new System.Drawing.Size(100, 20);
            this.tbox_idairplane.TabIndex = 26;
            // 
            // error_addairplane
            // 
            this.error_addairplane.ContainerControl = this;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(72, 227);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 18);
            this.label4.TabIndex = 25;
            this.label4.Text = "Total Seat";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(72, 185);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 18);
            this.label3.TabIndex = 24;
            this.label3.Text = "Type";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(72, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 18);
            this.label2.TabIndex = 23;
            this.label2.Text = "Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(72, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 18);
            this.label1.TabIndex = 22;
            this.label1.Text = "ID Airplane";
            // 
            // btn_search
            // 
            this.btn_search.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_search.BackgroundImage")));
            this.btn_search.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_search.Location = new System.Drawing.Point(296, 59);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(41, 35);
            this.btn_search.TabIndex = 34;
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // tbox_search
            // 
            this.tbox_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbox_search.Location = new System.Drawing.Point(174, 60);
            this.tbox_search.Multiline = true;
            this.tbox_search.Name = "tbox_search";
            this.tbox_search.Size = new System.Drawing.Size(100, 35);
            this.tbox_search.TabIndex = 33;
            // 
            // cbox_status
            // 
            this.cbox_status.FormattingEnabled = true;
            this.cbox_status.Items.AddRange(new object[] {
            "Active",
            "Not Active"});
            this.cbox_status.Location = new System.Drawing.Point(174, 267);
            this.cbox_status.Name = "cbox_status";
            this.cbox_status.Size = new System.Drawing.Size(100, 21);
            this.cbox_status.TabIndex = 36;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(72, 266);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 18);
            this.label6.TabIndex = 35;
            this.label6.Text = "Status";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(75, 66);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 17);
            this.label7.TabIndex = 37;
            this.label7.Text = "ID Airplane";
            // 
            // UpdateAirplane
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(448, 407);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cbox_status);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.tbox_search);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.numeric_totalseat);
            this.Controls.Add(this.cbox_typeairplane);
            this.Controls.Add(this.tbox_nameairplane);
            this.Controls.Add(this.tbox_idairplane);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "UpdateAirplane";
            this.Text = "UpdateAirplane";
            ((System.ComponentModel.ISupportInitialize)(this.numeric_totalseat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.error_addairplane)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.NumericUpDown numeric_totalseat;
        private System.Windows.Forms.ComboBox cbox_typeairplane;
        private System.Windows.Forms.TextBox tbox_nameairplane;
        private System.Windows.Forms.TextBox tbox_idairplane;
        private System.Windows.Forms.ErrorProvider error_addairplane;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.TextBox tbox_search;
        private System.Windows.Forms.ComboBox cbox_status;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}