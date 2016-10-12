namespace GUI_Project
{
    partial class Add_flight
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Add_flight));
            this.label1 = new System.Windows.Forms.Label();
            this.cbox_idairplane = new System.Windows.Forms.ComboBox();
            this.tbox_idflight = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_back = new System.Windows.Forms.Button();
            this.btn_clear = new System.Windows.Forms.Button();
            this.btn_submit = new System.Windows.Forms.Button();
            this.tbox_price = new System.Windows.Forms.TextBox();
            this.numeric_ticketstock = new System.Windows.Forms.NumericUpDown();
            this.tbox_timearrival = new System.Windows.Forms.TextBox();
            this.datetime_datearrival = new System.Windows.Forms.DateTimePicker();
            this.tbox_timedeparture = new System.Windows.Forms.TextBox();
            this.tbox_arrival = new System.Windows.Forms.TextBox();
            this.tbox_departure = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.datetime_datedeparture = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.error_addflight = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.numeric_ticketstock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.error_addflight)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID Flight";
            // 
            // cbox_idairplane
            // 
            this.cbox_idairplane.FormattingEnabled = true;
            this.cbox_idairplane.Location = new System.Drawing.Point(135, 77);
            this.cbox_idairplane.Name = "cbox_idairplane";
            this.cbox_idairplane.Size = new System.Drawing.Size(100, 21);
            this.cbox_idairplane.TabIndex = 1;
            // 
            // tbox_idflight
            // 
            this.tbox_idflight.Location = new System.Drawing.Point(135, 41);
            this.tbox_idflight.Name = "tbox_idflight";
            this.tbox_idflight.ReadOnly = true;
            this.tbox_idflight.Size = new System.Drawing.Size(100, 20);
            this.tbox_idflight.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(27, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "ID Airplane";
            // 
            // btn_back
            // 
            this.btn_back.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_back.Location = new System.Drawing.Point(12, 429);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(39, 26);
            this.btn_back.TabIndex = 41;
            this.btn_back.Text = "←";
            this.btn_back.UseVisualStyleBackColor = true;
            // 
            // btn_clear
            // 
            this.btn_clear.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_clear.BackgroundImage")));
            this.btn_clear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_clear.Location = new System.Drawing.Point(204, 365);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(113, 45);
            this.btn_clear.TabIndex = 40;
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // btn_submit
            // 
            this.btn_submit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_submit.BackgroundImage")));
            this.btn_submit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_submit.Location = new System.Drawing.Point(82, 365);
            this.btn_submit.Name = "btn_submit";
            this.btn_submit.Size = new System.Drawing.Size(106, 45);
            this.btn_submit.TabIndex = 39;
            this.btn_submit.UseVisualStyleBackColor = true;
            this.btn_submit.Click += new System.EventHandler(this.btn_submit_Click);
            // 
            // tbox_price
            // 
            this.tbox_price.Location = new System.Drawing.Point(135, 330);
            this.tbox_price.Name = "tbox_price";
            this.tbox_price.Size = new System.Drawing.Size(100, 20);
            this.tbox_price.TabIndex = 38;
            // 
            // numeric_ticketstock
            // 
            this.numeric_ticketstock.Location = new System.Drawing.Point(135, 299);
            this.numeric_ticketstock.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.numeric_ticketstock.Name = "numeric_ticketstock";
            this.numeric_ticketstock.Size = new System.Drawing.Size(100, 20);
            this.numeric_ticketstock.TabIndex = 37;
            // 
            // tbox_timearrival
            // 
            this.tbox_timearrival.Location = new System.Drawing.Point(135, 267);
            this.tbox_timearrival.Name = "tbox_timearrival";
            this.tbox_timearrival.Size = new System.Drawing.Size(100, 20);
            this.tbox_timearrival.TabIndex = 36;
            // 
            // datetime_datearrival
            // 
            this.datetime_datearrival.Location = new System.Drawing.Point(135, 233);
            this.datetime_datearrival.Name = "datetime_datearrival";
            this.datetime_datearrival.Size = new System.Drawing.Size(120, 20);
            this.datetime_datearrival.TabIndex = 35;
            // 
            // tbox_timedeparture
            // 
            this.tbox_timedeparture.Location = new System.Drawing.Point(135, 203);
            this.tbox_timedeparture.Name = "tbox_timedeparture";
            this.tbox_timedeparture.Size = new System.Drawing.Size(100, 20);
            this.tbox_timedeparture.TabIndex = 34;
            // 
            // tbox_arrival
            // 
            this.tbox_arrival.Location = new System.Drawing.Point(135, 146);
            this.tbox_arrival.Name = "tbox_arrival";
            this.tbox_arrival.Size = new System.Drawing.Size(100, 20);
            this.tbox_arrival.TabIndex = 33;
            // 
            // tbox_departure
            // 
            this.tbox_departure.Location = new System.Drawing.Point(135, 113);
            this.tbox_departure.Name = "tbox_departure";
            this.tbox_departure.ReadOnly = true;
            this.tbox_departure.Size = new System.Drawing.Size(100, 20);
            this.tbox_departure.TabIndex = 32;
            this.tbox_departure.Text = "Jakarta";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(28, 331);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(39, 16);
            this.label10.TabIndex = 31;
            this.label10.Text = "Price";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(28, 299);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(82, 16);
            this.label9.TabIndex = 30;
            this.label9.Text = "Ticket Stock";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(28, 268);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 16);
            this.label8.TabIndex = 29;
            this.label8.Text = "Time Arrival";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(28, 237);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 16);
            this.label7.TabIndex = 28;
            this.label7.Text = "Date Arrival";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(26, 207);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 16);
            this.label6.TabIndex = 27;
            this.label6.Text = "Time Departure";
            // 
            // datetime_datedeparture
            // 
            this.datetime_datedeparture.Location = new System.Drawing.Point(135, 172);
            this.datetime_datedeparture.Name = "datetime_datedeparture";
            this.datetime_datedeparture.Size = new System.Drawing.Size(120, 20);
            this.datetime_datedeparture.TabIndex = 26;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(28, 176);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 16);
            this.label5.TabIndex = 25;
            this.label5.Text = "Date Departure";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(28, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 16);
            this.label4.TabIndex = 24;
            this.label4.Text = "Arrival";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(28, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 16);
            this.label3.TabIndex = 23;
            this.label3.Text = "Departure";
            // 
            // error_addflight
            // 
            this.error_addflight.ContainerControl = this;
            // 
            // Add_flight
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(489, 467);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.btn_submit);
            this.Controls.Add(this.tbox_price);
            this.Controls.Add(this.numeric_ticketstock);
            this.Controls.Add(this.tbox_timearrival);
            this.Controls.Add(this.datetime_datearrival);
            this.Controls.Add(this.tbox_timedeparture);
            this.Controls.Add(this.tbox_arrival);
            this.Controls.Add(this.tbox_departure);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.datetime_datedeparture);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbox_idflight);
            this.Controls.Add(this.cbox_idairplane);
            this.Controls.Add(this.label1);
            this.Name = "Add_flight";
            this.Text = "Add_flight";
            this.Load += new System.EventHandler(this.Add_flight_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numeric_ticketstock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.error_addflight)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbox_idairplane;
        private System.Windows.Forms.TextBox tbox_idflight;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Button btn_submit;
        private System.Windows.Forms.TextBox tbox_price;
        private System.Windows.Forms.NumericUpDown numeric_ticketstock;
        private System.Windows.Forms.TextBox tbox_timearrival;
        private System.Windows.Forms.DateTimePicker datetime_datearrival;
        private System.Windows.Forms.TextBox tbox_timedeparture;
        private System.Windows.Forms.TextBox tbox_arrival;
        private System.Windows.Forms.TextBox tbox_departure;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker datetime_datedeparture;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ErrorProvider error_addflight;
    }
}