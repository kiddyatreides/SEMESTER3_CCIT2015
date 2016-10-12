namespace GUI_Project
{
    partial class ReservationForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReservationForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ticketReservationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buyTicketToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.displayTicketSellerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportTicketSellerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registerCustomerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addCustomerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.displayCustomerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateCustomerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportCustomerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ticketReservationToolStripMenuItem,
            this.registerCustomerToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(821, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ticketReservationToolStripMenuItem
            // 
            this.ticketReservationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.buyTicketToolStripMenuItem,
            this.displayTicketSellerToolStripMenuItem,
            this.reportTicketSellerToolStripMenuItem});
            this.ticketReservationToolStripMenuItem.Name = "ticketReservationToolStripMenuItem";
            this.ticketReservationToolStripMenuItem.Size = new System.Drawing.Size(115, 20);
            this.ticketReservationToolStripMenuItem.Text = "Ticket Reservation";
            // 
            // buyTicketToolStripMenuItem
            // 
            this.buyTicketToolStripMenuItem.Name = "buyTicketToolStripMenuItem";
            this.buyTicketToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.buyTicketToolStripMenuItem.Text = "Buy Ticket";
            this.buyTicketToolStripMenuItem.Click += new System.EventHandler(this.buyTicketToolStripMenuItem_Click);
            // 
            // displayTicketSellerToolStripMenuItem
            // 
            this.displayTicketSellerToolStripMenuItem.Name = "displayTicketSellerToolStripMenuItem";
            this.displayTicketSellerToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.displayTicketSellerToolStripMenuItem.Text = "Display Ticket Seller";
            this.displayTicketSellerToolStripMenuItem.Click += new System.EventHandler(this.displayTicketSellerToolStripMenuItem_Click);
            // 
            // reportTicketSellerToolStripMenuItem
            // 
            this.reportTicketSellerToolStripMenuItem.Name = "reportTicketSellerToolStripMenuItem";
            this.reportTicketSellerToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.reportTicketSellerToolStripMenuItem.Text = "Report Ticket Seller";
            // 
            // registerCustomerToolStripMenuItem
            // 
            this.registerCustomerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addCustomerToolStripMenuItem,
            this.displayCustomerToolStripMenuItem,
            this.updateCustomerToolStripMenuItem,
            this.reportCustomerToolStripMenuItem});
            this.registerCustomerToolStripMenuItem.Name = "registerCustomerToolStripMenuItem";
            this.registerCustomerToolStripMenuItem.Size = new System.Drawing.Size(116, 20);
            this.registerCustomerToolStripMenuItem.Text = "Register Customer";
            // 
            // addCustomerToolStripMenuItem
            // 
            this.addCustomerToolStripMenuItem.Name = "addCustomerToolStripMenuItem";
            this.addCustomerToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.addCustomerToolStripMenuItem.Text = "Add Customer";
            this.addCustomerToolStripMenuItem.Click += new System.EventHandler(this.addCustomerToolStripMenuItem_Click);
            // 
            // displayCustomerToolStripMenuItem
            // 
            this.displayCustomerToolStripMenuItem.Name = "displayCustomerToolStripMenuItem";
            this.displayCustomerToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.displayCustomerToolStripMenuItem.Text = "Display Customer";
            this.displayCustomerToolStripMenuItem.Click += new System.EventHandler(this.displayCustomerToolStripMenuItem_Click);
            // 
            // updateCustomerToolStripMenuItem
            // 
            this.updateCustomerToolStripMenuItem.Name = "updateCustomerToolStripMenuItem";
            this.updateCustomerToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.updateCustomerToolStripMenuItem.Text = "Update Customer";
            this.updateCustomerToolStripMenuItem.Click += new System.EventHandler(this.updateCustomerToolStripMenuItem_Click);
            // 
            // reportCustomerToolStripMenuItem
            // 
            this.reportCustomerToolStripMenuItem.Name = "reportCustomerToolStripMenuItem";
            this.reportCustomerToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.reportCustomerToolStripMenuItem.Text = "Report Data Customer";
            // 
            // ReservationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(821, 401);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "ReservationForm";
            this.Text = "ReservationForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ReservationForm_FormClosed);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ticketReservationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buyTicketToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem displayTicketSellerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registerCustomerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addCustomerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem displayCustomerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateCustomerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportTicketSellerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportCustomerToolStripMenuItem;
    }
}