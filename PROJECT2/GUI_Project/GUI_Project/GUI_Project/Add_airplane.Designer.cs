namespace GUI_Project
{
    partial class Add_airplane
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Add_airplane));
            this.label5 = new System.Windows.Forms.Label();
            this.btn_clear = new System.Windows.Forms.Button();
            this.btn_submit = new System.Windows.Forms.Button();
            this.numeric_totalseat = new System.Windows.Forms.NumericUpDown();
            this.cbox_typeairplane = new System.Windows.Forms.ComboBox();
            this.tbox_nameairplane = new System.Windows.Forms.TextBox();
            this.tbox_idairplane = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.error_addairplane = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.numeric_totalseat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.error_addairplane)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(142, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 20);
            this.label5.TabIndex = 21;
            this.label5.Text = "Add Airplane";
            // 
            // btn_clear
            // 
            this.btn_clear.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_clear.BackgroundImage")));
            this.btn_clear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_clear.Location = new System.Drawing.Point(212, 254);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(94, 45);
            this.btn_clear.TabIndex = 20;
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // btn_submit
            // 
            this.btn_submit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_submit.BackgroundImage")));
            this.btn_submit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_submit.Location = new System.Drawing.Point(93, 254);
            this.btn_submit.Name = "btn_submit";
            this.btn_submit.Size = new System.Drawing.Size(100, 45);
            this.btn_submit.TabIndex = 19;
            this.btn_submit.UseVisualStyleBackColor = true;
            this.btn_submit.Click += new System.EventHandler(this.btn_submit_Click);
            // 
            // numeric_totalseat
            // 
            this.numeric_totalseat.Location = new System.Drawing.Point(164, 199);
            this.numeric_totalseat.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.numeric_totalseat.Name = "numeric_totalseat";
            this.numeric_totalseat.Size = new System.Drawing.Size(51, 20);
            this.numeric_totalseat.TabIndex = 18;
            // 
            // cbox_typeairplane
            // 
            this.cbox_typeairplane.FormattingEnabled = true;
            this.cbox_typeairplane.Items.AddRange(new object[] {
            "Economy",
            "Executive",
            "Private"});
            this.cbox_typeairplane.Location = new System.Drawing.Point(164, 156);
            this.cbox_typeairplane.Name = "cbox_typeairplane";
            this.cbox_typeairplane.Size = new System.Drawing.Size(100, 21);
            this.cbox_typeairplane.TabIndex = 17;
            // 
            // tbox_nameairplane
            // 
            this.tbox_nameairplane.Location = new System.Drawing.Point(164, 118);
            this.tbox_nameairplane.Name = "tbox_nameairplane";
            this.tbox_nameairplane.Size = new System.Drawing.Size(100, 20);
            this.tbox_nameairplane.TabIndex = 16;
            // 
            // tbox_idairplane
            // 
            this.tbox_idairplane.Location = new System.Drawing.Point(164, 84);
            this.tbox_idairplane.Name = "tbox_idairplane";
            this.tbox_idairplane.ReadOnly = true;
            this.tbox_idairplane.Size = new System.Drawing.Size(100, 20);
            this.tbox_idairplane.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(62, 197);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 18);
            this.label4.TabIndex = 14;
            this.label4.Text = "Total Seat";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(62, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 18);
            this.label3.TabIndex = 13;
            this.label3.Text = "Type";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(62, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 18);
            this.label2.TabIndex = 12;
            this.label2.Text = "Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(62, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 18);
            this.label1.TabIndex = 11;
            this.label1.Text = "ID Airplane";
            // 
            // error_addairplane
            // 
            this.error_addairplane.ContainerControl = this;
            // 
            // Add_airplane
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(408, 384);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.btn_submit);
            this.Controls.Add(this.numeric_totalseat);
            this.Controls.Add(this.cbox_typeairplane);
            this.Controls.Add(this.tbox_nameairplane);
            this.Controls.Add(this.tbox_idairplane);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Add_airplane";
            this.Text = "Add_airplane";
            this.Load += new System.EventHandler(this.Add_airplane_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numeric_totalseat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.error_addairplane)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Button btn_submit;
        private System.Windows.Forms.NumericUpDown numeric_totalseat;
        private System.Windows.Forms.ComboBox cbox_typeairplane;
        private System.Windows.Forms.TextBox tbox_nameairplane;
        private System.Windows.Forms.TextBox tbox_idairplane;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ErrorProvider error_addairplane;
    }
}