namespace RentHouse
{
    partial class MainMenu
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.customerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customerPanelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.displayCustomerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.roomToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.roomPanelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.roomDisplayToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.typeRoomToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rentPanelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.displayRentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rentInToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.monthlyPaidToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.displayMonthlyPaidToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportMonthlyPaidToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.White;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.customerToolStripMenuItem,
            this.roomToolStripMenuItem,
            this.rentToolStripMenuItem,
            this.monthlyPaidToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1350, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // customerToolStripMenuItem
            // 
            this.customerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.customerPanelToolStripMenuItem,
            this.displayCustomerToolStripMenuItem});
            this.customerToolStripMenuItem.Name = "customerToolStripMenuItem";
            this.customerToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.customerToolStripMenuItem.Text = "Customer";
            // 
            // customerPanelToolStripMenuItem
            // 
            this.customerPanelToolStripMenuItem.Name = "customerPanelToolStripMenuItem";
            this.customerPanelToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.customerPanelToolStripMenuItem.Text = "Customer Panel";
            this.customerPanelToolStripMenuItem.Click += new System.EventHandler(this.customerPanelToolStripMenuItem_Click);
            // 
            // displayCustomerToolStripMenuItem
            // 
            this.displayCustomerToolStripMenuItem.Name = "displayCustomerToolStripMenuItem";
            this.displayCustomerToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.displayCustomerToolStripMenuItem.Text = "Display Customer";
            this.displayCustomerToolStripMenuItem.Click += new System.EventHandler(this.displayCustomerToolStripMenuItem_Click);
            // 
            // roomToolStripMenuItem
            // 
            this.roomToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.roomPanelToolStripMenuItem,
            this.roomDisplayToolStripMenuItem,
            this.typeRoomToolStripMenuItem});
            this.roomToolStripMenuItem.Name = "roomToolStripMenuItem";
            this.roomToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.roomToolStripMenuItem.Text = "Room";
            // 
            // roomPanelToolStripMenuItem
            // 
            this.roomPanelToolStripMenuItem.Name = "roomPanelToolStripMenuItem";
            this.roomPanelToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.roomPanelToolStripMenuItem.Text = "Room Panel";
            this.roomPanelToolStripMenuItem.Click += new System.EventHandler(this.roomPanelToolStripMenuItem_Click);
            // 
            // roomDisplayToolStripMenuItem
            // 
            this.roomDisplayToolStripMenuItem.Name = "roomDisplayToolStripMenuItem";
            this.roomDisplayToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.roomDisplayToolStripMenuItem.Text = "Room Display";
            this.roomDisplayToolStripMenuItem.Click += new System.EventHandler(this.roomDisplayToolStripMenuItem_Click);
            // 
            // typeRoomToolStripMenuItem
            // 
            this.typeRoomToolStripMenuItem.Name = "typeRoomToolStripMenuItem";
            this.typeRoomToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.typeRoomToolStripMenuItem.Text = "Type Room";
            this.typeRoomToolStripMenuItem.Click += new System.EventHandler(this.typeRoomToolStripMenuItem_Click);
            // 
            // rentToolStripMenuItem
            // 
            this.rentToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rentInToolStripMenuItem,
            this.rentPanelToolStripMenuItem,
            this.displayRentToolStripMenuItem});
            this.rentToolStripMenuItem.Name = "rentToolStripMenuItem";
            this.rentToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.rentToolStripMenuItem.Text = "Rent";
            // 
            // rentPanelToolStripMenuItem
            // 
            this.rentPanelToolStripMenuItem.Name = "rentPanelToolStripMenuItem";
            this.rentPanelToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.rentPanelToolStripMenuItem.Text = "Rent Out";
            this.rentPanelToolStripMenuItem.Click += new System.EventHandler(this.rentPanelToolStripMenuItem_Click);
            // 
            // displayRentToolStripMenuItem
            // 
            this.displayRentToolStripMenuItem.Name = "displayRentToolStripMenuItem";
            this.displayRentToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.displayRentToolStripMenuItem.Text = "Display Rent";
            this.displayRentToolStripMenuItem.Click += new System.EventHandler(this.displayRentToolStripMenuItem_Click);
            // 
            // rentInToolStripMenuItem
            // 
            this.rentInToolStripMenuItem.Name = "rentInToolStripMenuItem";
            this.rentInToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.rentInToolStripMenuItem.Text = "Rent In";
            this.rentInToolStripMenuItem.Click += new System.EventHandler(this.rentInToolStripMenuItem_Click);
            // 
            // monthlyPaidToolStripMenuItem
            // 
            this.monthlyPaidToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.displayMonthlyPaidToolStripMenuItem,
            this.reportMonthlyPaidToolStripMenuItem});
            this.monthlyPaidToolStripMenuItem.Name = "monthlyPaidToolStripMenuItem";
            this.monthlyPaidToolStripMenuItem.Size = new System.Drawing.Size(90, 20);
            this.monthlyPaidToolStripMenuItem.Text = "Monthly Paid";
            // 
            // displayMonthlyPaidToolStripMenuItem
            // 
            this.displayMonthlyPaidToolStripMenuItem.Name = "displayMonthlyPaidToolStripMenuItem";
            this.displayMonthlyPaidToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.displayMonthlyPaidToolStripMenuItem.Text = "Display Monthly Paid";
            this.displayMonthlyPaidToolStripMenuItem.Click += new System.EventHandler(this.displayMonthlyPaidToolStripMenuItem_Click);
            // 
            // reportMonthlyPaidToolStripMenuItem
            // 
            this.reportMonthlyPaidToolStripMenuItem.Name = "reportMonthlyPaidToolStripMenuItem";
            this.reportMonthlyPaidToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.reportMonthlyPaidToolStripMenuItem.Text = "Report Monthly Paid";
            this.reportMonthlyPaidToolStripMenuItem.Click += new System.EventHandler(this.reportMonthlyPaidToolStripMenuItem_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::RentHouse.Properties.Resources.Login;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1350, 729);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainMenu";
            this.Text = "MainMenu";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainMenu_FormClosed);
            this.Load += new System.EventHandler(this.MainMenu_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem customerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem customerPanelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem displayCustomerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem roomToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem roomPanelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem roomDisplayToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rentPanelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem displayRentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem monthlyPaidToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem displayMonthlyPaidToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rentInToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem typeRoomToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportMonthlyPaidToolStripMenuItem;
    }
}