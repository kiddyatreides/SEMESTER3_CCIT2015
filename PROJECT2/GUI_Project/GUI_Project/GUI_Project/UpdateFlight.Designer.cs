namespace GUI_Project
{
    partial class UpdateFlight
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdateFlight));
            this.tbox_arrivaltime = new System.Windows.Forms.TextBox();
            this.tbox_arrival = new System.Windows.Forms.TextBox();
            this.tbox_price = new System.Windows.Forms.TextBox();
            this.tbox_departuretime = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbox_idflight = new System.Windows.Forms.TextBox();
            this.tbox_departure = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_search = new System.Windows.Forms.Button();
            this.tbox_search = new System.Windows.Forms.TextBox();
            this.datetime_departuredate = new System.Windows.Forms.DateTimePicker();
            this.datetime_arrivaldate = new System.Windows.Forms.DateTimePicker();
            this.numeric_ticketstock = new System.Windows.Forms.NumericUpDown();
            this.cbox_idairplane = new System.Windows.Forms.ComboBox();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_clear = new System.Windows.Forms.Button();
            this.error_updateflight = new System.Windows.Forms.ErrorProvider(this.components);
            this.label11 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_ticketstock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.error_updateflight)).BeginInit();
            this.SuspendLayout();
            // 
            // tbox_arrivaltime
            // 
            this.tbox_arrivaltime.Location = new System.Drawing.Point(326, 232);
            this.tbox_arrivaltime.Name = "tbox_arrivaltime";
            this.tbox_arrivaltime.Size = new System.Drawing.Size(90, 20);
            this.tbox_arrivaltime.TabIndex = 43;
            // 
            // tbox_arrival
            // 
            this.tbox_arrival.Location = new System.Drawing.Point(326, 171);
            this.tbox_arrival.Name = "tbox_arrival";
            this.tbox_arrival.Size = new System.Drawing.Size(90, 20);
            this.tbox_arrival.TabIndex = 42;
            // 
            // tbox_price
            // 
            this.tbox_price.Location = new System.Drawing.Point(326, 140);
            this.tbox_price.Name = "tbox_price";
            this.tbox_price.Size = new System.Drawing.Size(90, 20);
            this.tbox_price.TabIndex = 40;
            // 
            // tbox_departuretime
            // 
            this.tbox_departuretime.Location = new System.Drawing.Point(95, 232);
            this.tbox_departuretime.Name = "tbox_departuretime";
            this.tbox_departuretime.Size = new System.Drawing.Size(90, 20);
            this.tbox_departuretime.TabIndex = 38;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(241, 232);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(62, 13);
            this.label10.TabIndex = 37;
            this.label10.Text = "Arrival Time";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(241, 206);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(62, 13);
            this.label9.TabIndex = 36;
            this.label9.Text = "Arrival Date";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 232);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 13);
            this.label8.TabIndex = 35;
            this.label8.Text = "Departure Time";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 206);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 13);
            this.label7.TabIndex = 34;
            this.label7.Text = "Departure Date";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(241, 143);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 13);
            this.label6.TabIndex = 33;
            this.label6.Text = "Price";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(241, 107);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 13);
            this.label5.TabIndex = 32;
            this.label5.Text = "Ticket Stock";
            // 
            // tbox_idflight
            // 
            this.tbox_idflight.Location = new System.Drawing.Point(95, 107);
            this.tbox_idflight.Name = "tbox_idflight";
            this.tbox_idflight.ReadOnly = true;
            this.tbox_idflight.Size = new System.Drawing.Size(90, 20);
            this.tbox_idflight.TabIndex = 30;
            // 
            // tbox_departure
            // 
            this.tbox_departure.Location = new System.Drawing.Point(95, 171);
            this.tbox_departure.Name = "tbox_departure";
            this.tbox_departure.ReadOnly = true;
            this.tbox_departure.Size = new System.Drawing.Size(90, 20);
            this.tbox_departure.TabIndex = 29;
            this.tbox_departure.Text = "Jakarta";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(241, 174);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 28;
            this.label4.Text = "Arrival";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 174);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 27;
            this.label3.Text = "Departure";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 26;
            this.label2.Text = "ID Airplane";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 25;
            this.label1.Text = "ID Flight";
            // 
            // btn_search
            // 
            this.btn_search.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_search.BackgroundImage")));
            this.btn_search.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_search.Location = new System.Drawing.Point(337, 41);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(46, 34);
            this.btn_search.TabIndex = 23;
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // tbox_search
            // 
            this.tbox_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 19F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbox_search.Location = new System.Drawing.Point(95, 41);
            this.tbox_search.Multiline = true;
            this.tbox_search.Name = "tbox_search";
            this.tbox_search.Size = new System.Drawing.Size(222, 34);
            this.tbox_search.TabIndex = 22;
            // 
            // datetime_departuredate
            // 
            this.datetime_departuredate.Location = new System.Drawing.Point(95, 203);
            this.datetime_departuredate.Name = "datetime_departuredate";
            this.datetime_departuredate.Size = new System.Drawing.Size(90, 20);
            this.datetime_departuredate.TabIndex = 44;
            // 
            // datetime_arrivaldate
            // 
            this.datetime_arrivaldate.Location = new System.Drawing.Point(326, 203);
            this.datetime_arrivaldate.Name = "datetime_arrivaldate";
            this.datetime_arrivaldate.Size = new System.Drawing.Size(90, 20);
            this.datetime_arrivaldate.TabIndex = 45;
            // 
            // numeric_ticketstock
            // 
            this.numeric_ticketstock.Location = new System.Drawing.Point(326, 105);
            this.numeric_ticketstock.Name = "numeric_ticketstock";
            this.numeric_ticketstock.Size = new System.Drawing.Size(90, 20);
            this.numeric_ticketstock.TabIndex = 46;
            // 
            // cbox_idairplane
            // 
            this.cbox_idairplane.FormattingEnabled = true;
            this.cbox_idairplane.Location = new System.Drawing.Point(95, 140);
            this.cbox_idairplane.Name = "cbox_idairplane";
            this.cbox_idairplane.Size = new System.Drawing.Size(90, 21);
            this.cbox_idairplane.TabIndex = 47;
            // 
            // btn_update
            // 
            this.btn_update.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_update.BackgroundImage")));
            this.btn_update.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_update.Location = new System.Drawing.Point(95, 274);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(161, 62);
            this.btn_update.TabIndex = 48;
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_clear
            // 
            this.btn_clear.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_clear.BackgroundImage")));
            this.btn_clear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_clear.Location = new System.Drawing.Point(326, 274);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(142, 62);
            this.btn_clear.TabIndex = 49;
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // error_updateflight
            // 
            this.error_updateflight.ContainerControl = this;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(12, 50);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(59, 17);
            this.label11.TabIndex = 50;
            this.label11.Text = "ID Flight";
            // 
            // UpdateFlight
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(575, 365);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.cbox_idairplane);
            this.Controls.Add(this.numeric_ticketstock);
            this.Controls.Add(this.datetime_arrivaldate);
            this.Controls.Add(this.datetime_departuredate);
            this.Controls.Add(this.tbox_arrivaltime);
            this.Controls.Add(this.tbox_arrival);
            this.Controls.Add(this.tbox_price);
            this.Controls.Add(this.tbox_departuretime);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbox_idflight);
            this.Controls.Add(this.tbox_departure);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.tbox_search);
            this.Name = "UpdateFlight";
            this.Text = "UpdateFlight";
            this.Load += new System.EventHandler(this.UpdateFlight_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numeric_ticketstock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.error_updateflight)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbox_arrivaltime;
        private System.Windows.Forms.TextBox tbox_arrival;
        private System.Windows.Forms.TextBox tbox_price;
        private System.Windows.Forms.TextBox tbox_departuretime;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbox_idflight;
        private System.Windows.Forms.TextBox tbox_departure;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.TextBox tbox_search;
        private System.Windows.Forms.DateTimePicker datetime_departuredate;
        private System.Windows.Forms.DateTimePicker datetime_arrivaldate;
        private System.Windows.Forms.NumericUpDown numeric_ticketstock;
        private System.Windows.Forms.ComboBox cbox_idairplane;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.ErrorProvider error_updateflight;
        private System.Windows.Forms.Label label11;

    }
}