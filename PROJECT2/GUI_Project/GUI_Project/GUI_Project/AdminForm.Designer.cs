namespace GUI_Project
{
    partial class AdminForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.flightToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addFlightToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.displayFlightToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateFlightToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportFlightToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.airplaneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addAirplaneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.displayAirplaneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateAirplaneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportAirplaneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.flightToolStripMenuItem,
            this.airplaneToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(439, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // flightToolStripMenuItem
            // 
            this.flightToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addFlightToolStripMenuItem,
            this.displayFlightToolStripMenuItem,
            this.updateFlightToolStripMenuItem,
            this.reportFlightToolStripMenuItem});
            this.flightToolStripMenuItem.Name = "flightToolStripMenuItem";
            this.flightToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.flightToolStripMenuItem.Text = "Flight";
            // 
            // addFlightToolStripMenuItem
            // 
            this.addFlightToolStripMenuItem.Name = "addFlightToolStripMenuItem";
            this.addFlightToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.addFlightToolStripMenuItem.Text = "Add Flight";
            this.addFlightToolStripMenuItem.Click += new System.EventHandler(this.addFlightToolStripMenuItem_Click);
            // 
            // displayFlightToolStripMenuItem
            // 
            this.displayFlightToolStripMenuItem.Name = "displayFlightToolStripMenuItem";
            this.displayFlightToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.displayFlightToolStripMenuItem.Text = "Display Flight";
            this.displayFlightToolStripMenuItem.Click += new System.EventHandler(this.displayFlightToolStripMenuItem_Click);
            // 
            // updateFlightToolStripMenuItem
            // 
            this.updateFlightToolStripMenuItem.Name = "updateFlightToolStripMenuItem";
            this.updateFlightToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.updateFlightToolStripMenuItem.Text = "Update Flight";
            this.updateFlightToolStripMenuItem.Click += new System.EventHandler(this.updateFlightToolStripMenuItem_Click);
            // 
            // reportFlightToolStripMenuItem
            // 
            this.reportFlightToolStripMenuItem.Name = "reportFlightToolStripMenuItem";
            this.reportFlightToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.reportFlightToolStripMenuItem.Text = "Flight Data Report";
            // 
            // airplaneToolStripMenuItem
            // 
            this.airplaneToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addAirplaneToolStripMenuItem,
            this.displayAirplaneToolStripMenuItem,
            this.updateAirplaneToolStripMenuItem,
            this.reportAirplaneToolStripMenuItem});
            this.airplaneToolStripMenuItem.Name = "airplaneToolStripMenuItem";
            this.airplaneToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.airplaneToolStripMenuItem.Text = "Airplane";
            // 
            // addAirplaneToolStripMenuItem
            // 
            this.addAirplaneToolStripMenuItem.Name = "addAirplaneToolStripMenuItem";
            this.addAirplaneToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.addAirplaneToolStripMenuItem.Text = "Add Airplane";
            this.addAirplaneToolStripMenuItem.Click += new System.EventHandler(this.addAirplaneToolStripMenuItem_Click);
            // 
            // displayAirplaneToolStripMenuItem
            // 
            this.displayAirplaneToolStripMenuItem.Name = "displayAirplaneToolStripMenuItem";
            this.displayAirplaneToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.displayAirplaneToolStripMenuItem.Text = "Display Airplane";
            this.displayAirplaneToolStripMenuItem.Click += new System.EventHandler(this.displayAirplaneToolStripMenuItem_Click);
            // 
            // updateAirplaneToolStripMenuItem
            // 
            this.updateAirplaneToolStripMenuItem.Name = "updateAirplaneToolStripMenuItem";
            this.updateAirplaneToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.updateAirplaneToolStripMenuItem.Text = "Update Airplane";
            this.updateAirplaneToolStripMenuItem.Click += new System.EventHandler(this.updateAirplaneToolStripMenuItem_Click);
            // 
            // reportAirplaneToolStripMenuItem
            // 
            this.reportAirplaneToolStripMenuItem.Name = "reportAirplaneToolStripMenuItem";
            this.reportAirplaneToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.reportAirplaneToolStripMenuItem.Text = "Airplane Data Report";
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(439, 262);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "AdminForm";
            this.Text = "AdminForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AdminForm_FormClosed);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem flightToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addFlightToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem displayFlightToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateFlightToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportFlightToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem airplaneToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addAirplaneToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem displayAirplaneToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateAirplaneToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportAirplaneToolStripMenuItem;
    }
}