namespace GUI_Project
{
    partial class DisplayFlight
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DisplayFlight));
            this.tbox_search = new System.Windows.Forms.TextBox();
            this.btn_search = new System.Windows.Forms.Button();
            this.tbox_idairplane = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbox_departure = new System.Windows.Forms.TextBox();
            this.tbox_idflight = new System.Windows.Forms.TextBox();
            this.tbox_departuredate = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.tbox_departuretime = new System.Windows.Forms.TextBox();
            this.tbox_ticketstock = new System.Windows.Forms.TextBox();
            this.tbox_price = new System.Windows.Forms.TextBox();
            this.tbox_arrivaldate = new System.Windows.Forms.TextBox();
            this.tbox_arrival = new System.Windows.Forms.TextBox();
            this.tbox_arrivaltime = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tbox_search
            // 
            this.tbox_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbox_search.Location = new System.Drawing.Point(12, 41);
            this.tbox_search.Multiline = true;
            this.tbox_search.Name = "tbox_search";
            this.tbox_search.Size = new System.Drawing.Size(309, 32);
            this.tbox_search.TabIndex = 0;
            // 
            // btn_search
            // 
            this.btn_search.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_search.BackgroundImage")));
            this.btn_search.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_search.Location = new System.Drawing.Point(327, 41);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(44, 32);
            this.btn_search.TabIndex = 1;
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // tbox_idairplane
            // 
            this.tbox_idairplane.Location = new System.Drawing.Point(95, 128);
            this.tbox_idairplane.Name = "tbox_idairplane";
            this.tbox_idairplane.ReadOnly = true;
            this.tbox_idairplane.Size = new System.Drawing.Size(90, 20);
            this.tbox_idairplane.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "ID Flight";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "ID Airplane";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Departure";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(204, 162);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Arrival";
            // 
            // tbox_departure
            // 
            this.tbox_departure.Location = new System.Drawing.Point(95, 159);
            this.tbox_departure.Name = "tbox_departure";
            this.tbox_departure.ReadOnly = true;
            this.tbox_departure.Size = new System.Drawing.Size(90, 20);
            this.tbox_departure.TabIndex = 7;
            // 
            // tbox_idflight
            // 
            this.tbox_idflight.Location = new System.Drawing.Point(95, 95);
            this.tbox_idflight.Name = "tbox_idflight";
            this.tbox_idflight.ReadOnly = true;
            this.tbox_idflight.Size = new System.Drawing.Size(90, 20);
            this.tbox_idflight.TabIndex = 8;
            // 
            // tbox_departuredate
            // 
            this.tbox_departuredate.Location = new System.Drawing.Point(95, 192);
            this.tbox_departuredate.Name = "tbox_departuredate";
            this.tbox_departuredate.ReadOnly = true;
            this.tbox_departuredate.Size = new System.Drawing.Size(90, 20);
            this.tbox_departuredate.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(204, 95);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Ticket Stock";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(204, 131);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Price";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 195);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Departure Date";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(9, 227);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "Departure Time";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(204, 195);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(62, 13);
            this.label9.TabIndex = 14;
            this.label9.Text = "Arrival Date";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(204, 227);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(62, 13);
            this.label10.TabIndex = 15;
            this.label10.Text = "Arrival Time";
            // 
            // tbox_departuretime
            // 
            this.tbox_departuretime.Location = new System.Drawing.Point(95, 224);
            this.tbox_departuretime.Name = "tbox_departuretime";
            this.tbox_departuretime.ReadOnly = true;
            this.tbox_departuretime.Size = new System.Drawing.Size(90, 20);
            this.tbox_departuretime.TabIndex = 16;
            // 
            // tbox_ticketstock
            // 
            this.tbox_ticketstock.Location = new System.Drawing.Point(289, 92);
            this.tbox_ticketstock.Name = "tbox_ticketstock";
            this.tbox_ticketstock.ReadOnly = true;
            this.tbox_ticketstock.Size = new System.Drawing.Size(90, 20);
            this.tbox_ticketstock.TabIndex = 17;
            // 
            // tbox_price
            // 
            this.tbox_price.Location = new System.Drawing.Point(289, 128);
            this.tbox_price.Name = "tbox_price";
            this.tbox_price.ReadOnly = true;
            this.tbox_price.Size = new System.Drawing.Size(90, 20);
            this.tbox_price.TabIndex = 18;
            // 
            // tbox_arrivaldate
            // 
            this.tbox_arrivaldate.Location = new System.Drawing.Point(289, 192);
            this.tbox_arrivaldate.Name = "tbox_arrivaldate";
            this.tbox_arrivaldate.ReadOnly = true;
            this.tbox_arrivaldate.Size = new System.Drawing.Size(90, 20);
            this.tbox_arrivaldate.TabIndex = 19;
            // 
            // tbox_arrival
            // 
            this.tbox_arrival.Location = new System.Drawing.Point(289, 159);
            this.tbox_arrival.Name = "tbox_arrival";
            this.tbox_arrival.ReadOnly = true;
            this.tbox_arrival.Size = new System.Drawing.Size(90, 20);
            this.tbox_arrival.TabIndex = 20;
            // 
            // tbox_arrivaltime
            // 
            this.tbox_arrivaltime.Location = new System.Drawing.Point(289, 224);
            this.tbox_arrivaltime.Name = "tbox_arrivaltime";
            this.tbox_arrivaltime.ReadOnly = true;
            this.tbox_arrivaltime.Size = new System.Drawing.Size(90, 20);
            this.tbox_arrivaltime.TabIndex = 21;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 279);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(380, 109);
            this.dataGridView1.TabIndex = 22;
            // 
            // DisplayFlight
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 398);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.tbox_arrivaltime);
            this.Controls.Add(this.tbox_arrival);
            this.Controls.Add(this.tbox_arrivaldate);
            this.Controls.Add(this.tbox_price);
            this.Controls.Add(this.tbox_ticketstock);
            this.Controls.Add(this.tbox_departuretime);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbox_departuredate);
            this.Controls.Add(this.tbox_idflight);
            this.Controls.Add(this.tbox_departure);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbox_idairplane);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.tbox_search);
            this.Name = "DisplayFlight";
            this.Text = "DisplayFlight";
            this.Load += new System.EventHandler(this.DisplayFlight_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbox_search;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.TextBox tbox_idairplane;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbox_departure;
        private System.Windows.Forms.TextBox tbox_idflight;
        private System.Windows.Forms.TextBox tbox_departuredate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tbox_departuretime;
        private System.Windows.Forms.TextBox tbox_ticketstock;
        private System.Windows.Forms.TextBox tbox_price;
        private System.Windows.Forms.TextBox tbox_arrivaldate;
        private System.Windows.Forms.TextBox tbox_arrival;
        private System.Windows.Forms.TextBox tbox_arrivaltime;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}