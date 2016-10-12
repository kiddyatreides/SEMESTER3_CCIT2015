namespace GUI_Project
{
    partial class UpdateCustomer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdateCustomer));
            this.btn_clear = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.tbox_address = new System.Windows.Forms.RichTextBox();
            this.datetime_birthdate = new System.Windows.Forms.DateTimePicker();
            this.cbox_idtype = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbox_idnumber = new System.Windows.Forms.TextBox();
            this.tbox_name = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbox_idcustomer = new System.Windows.Forms.TextBox();
            this.error_addcustomer = new System.Windows.Forms.ErrorProvider(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.tbox_search = new System.Windows.Forms.TextBox();
            this.cbox_gender = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.error_addcustomer)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_clear
            // 
            this.btn_clear.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_clear.BackgroundImage")));
            this.btn_clear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_clear.Location = new System.Drawing.Point(247, 485);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(105, 52);
            this.btn_clear.TabIndex = 34;
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // btn_update
            // 
            this.btn_update.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_update.BackgroundImage")));
            this.btn_update.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_update.Location = new System.Drawing.Point(80, 485);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(105, 52);
            this.btn_update.TabIndex = 33;
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(55, 202);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 16);
            this.label7.TabIndex = 32;
            this.label7.Text = "Gender";
            // 
            // tbox_address
            // 
            this.tbox_address.Location = new System.Drawing.Point(142, 359);
            this.tbox_address.Name = "tbox_address";
            this.tbox_address.Size = new System.Drawing.Size(180, 96);
            this.tbox_address.TabIndex = 31;
            this.tbox_address.Text = "";
            // 
            // datetime_birthdate
            // 
            this.datetime_birthdate.Location = new System.Drawing.Point(142, 318);
            this.datetime_birthdate.Name = "datetime_birthdate";
            this.datetime_birthdate.Size = new System.Drawing.Size(180, 20);
            this.datetime_birthdate.TabIndex = 30;
            // 
            // cbox_idtype
            // 
            this.cbox_idtype.FormattingEnabled = true;
            this.cbox_idtype.Items.AddRange(new object[] {
            "KTP",
            "Passport",
            "SIM"});
            this.cbox_idtype.Location = new System.Drawing.Point(142, 246);
            this.cbox_idtype.Name = "cbox_idtype";
            this.cbox_idtype.Size = new System.Drawing.Size(181, 21);
            this.cbox_idtype.TabIndex = 29;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(55, 360);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 16);
            this.label6.TabIndex = 28;
            this.label6.Text = "Address";
            // 
            // tbox_idnumber
            // 
            this.tbox_idnumber.Location = new System.Drawing.Point(142, 284);
            this.tbox_idnumber.Name = "tbox_idnumber";
            this.tbox_idnumber.Size = new System.Drawing.Size(180, 20);
            this.tbox_idnumber.TabIndex = 27;
            // 
            // tbox_name
            // 
            this.tbox_name.Location = new System.Drawing.Point(142, 160);
            this.tbox_name.Name = "tbox_name";
            this.tbox_name.Size = new System.Drawing.Size(180, 20);
            this.tbox_name.TabIndex = 26;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(55, 322);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 16);
            this.label5.TabIndex = 24;
            this.label5.Text = "Birthdate";
            // 
            // tbox_idcustomer
            // 
            this.tbox_idcustomer.Location = new System.Drawing.Point(142, 120);
            this.tbox_idcustomer.Name = "tbox_idcustomer";
            this.tbox_idcustomer.ReadOnly = true;
            this.tbox_idcustomer.Size = new System.Drawing.Size(180, 20);
            this.tbox_idcustomer.TabIndex = 25;
            // 
            // error_addcustomer
            // 
            this.error_addcustomer.ContainerControl = this;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(55, 284);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 16);
            this.label4.TabIndex = 23;
            this.label4.Text = "ID Number";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(55, 247);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 16);
            this.label3.TabIndex = 22;
            this.label3.Text = "ID Type";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(55, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 16);
            this.label2.TabIndex = 21;
            this.label2.Text = "Full Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(55, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 16);
            this.label1.TabIndex = 20;
            this.label1.Text = "ID Customer";
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Location = new System.Drawing.Point(272, 68);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(51, 34);
            this.button1.TabIndex = 40;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tbox_search
            // 
            this.tbox_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbox_search.Location = new System.Drawing.Point(142, 68);
            this.tbox_search.Multiline = true;
            this.tbox_search.Name = "tbox_search";
            this.tbox_search.Size = new System.Drawing.Size(124, 34);
            this.tbox_search.TabIndex = 39;
            // 
            // cbox_gender
            // 
            this.cbox_gender.FormattingEnabled = true;
            this.cbox_gender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.cbox_gender.Location = new System.Drawing.Point(142, 201);
            this.cbox_gender.Name = "cbox_gender";
            this.cbox_gender.Size = new System.Drawing.Size(180, 21);
            this.cbox_gender.TabIndex = 41;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(51, 76);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(85, 17);
            this.label8.TabIndex = 42;
            this.label8.Text = "ID Customer";
            // 
            // UpdateCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(391, 561);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cbox_gender);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tbox_search);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tbox_address);
            this.Controls.Add(this.datetime_birthdate);
            this.Controls.Add(this.cbox_idtype);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbox_idnumber);
            this.Controls.Add(this.tbox_name);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbox_idcustomer);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "UpdateCustomer";
            this.Text = "UpdateCustomer";
            ((System.ComponentModel.ISupportInitialize)(this.error_addcustomer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RichTextBox tbox_address;
        private System.Windows.Forms.DateTimePicker datetime_birthdate;
        private System.Windows.Forms.ComboBox cbox_idtype;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbox_idnumber;
        private System.Windows.Forms.TextBox tbox_name;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbox_idcustomer;
        private System.Windows.Forms.ErrorProvider error_addcustomer;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbox_gender;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tbox_search;
        private System.Windows.Forms.Label label8;

    }
}