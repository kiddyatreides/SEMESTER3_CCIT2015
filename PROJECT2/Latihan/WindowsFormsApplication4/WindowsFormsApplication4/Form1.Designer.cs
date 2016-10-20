namespace WindowsFormsApplication4
{
    partial class Form1
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
            this.cmdSave = new System.Windows.Forms.Button();
            this.cmdTotal = new System.Windows.Forms.Button();
            this.cmdAdd = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmdSave
            // 
            this.cmdSave.Location = new System.Drawing.Point(33, 125);
            this.cmdSave.Name = "cmdSave";
            this.cmdSave.Size = new System.Drawing.Size(111, 61);
            this.cmdSave.TabIndex = 0;
            this.cmdSave.Text = "Save as XML";
            this.cmdSave.UseVisualStyleBackColor = true;
            this.cmdSave.Click += new System.EventHandler(this.cmdSave_Click);
            // 
            // cmdTotal
            // 
            this.cmdTotal.Location = new System.Drawing.Point(201, 125);
            this.cmdTotal.Name = "cmdTotal";
            this.cmdTotal.Size = new System.Drawing.Size(111, 61);
            this.cmdTotal.TabIndex = 1;
            this.cmdTotal.Text = "Total Job Fairs Held";
            this.cmdTotal.UseVisualStyleBackColor = true;
            this.cmdTotal.Click += new System.EventHandler(this.cmdTotal_Click);
            // 
            // cmdAdd
            // 
            this.cmdAdd.Location = new System.Drawing.Point(359, 125);
            this.cmdAdd.Name = "cmdAdd";
            this.cmdAdd.Size = new System.Drawing.Size(111, 61);
            this.cmdAdd.TabIndex = 2;
            this.cmdAdd.Text = "Add";
            this.cmdAdd.UseVisualStyleBackColor = true;
            this.cmdAdd.Click += new System.EventHandler(this.cmdAdd_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.label1.Location = new System.Drawing.Point(176, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Job Fair Details";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(521, 287);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmdAdd);
            this.Controls.Add(this.cmdTotal);
            this.Controls.Add(this.cmdSave);
            this.Name = "Form1";
            this.Text = "Tebisco : Job Fair";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmdSave;
        private System.Windows.Forms.Button cmdTotal;
        private System.Windows.Forms.Button cmdAdd;
        private System.Windows.Forms.Label label1;
    }
}

