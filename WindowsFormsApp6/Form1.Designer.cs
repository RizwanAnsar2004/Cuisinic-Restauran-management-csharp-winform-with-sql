
namespace WindowsFormsApp6
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.logo = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.customer = new System.Windows.Forms.PictureBox();
            this.staff = new System.Windows.Forms.PictureBox();
            this.admin = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.staff)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.admin)).BeginInit();
            this.SuspendLayout();
            // 
            // logo
            // 
            this.logo.Image = ((System.Drawing.Image)(resources.GetObject("logo.Image")));
            this.logo.Location = new System.Drawing.Point(361, 0);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(427, 368);
            this.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logo.TabIndex = 0;
            this.logo.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Algerian", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(274, 371);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(535, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "WHICH CATEGORY DO YOU BELONG TO:";
            // 
            // customer
            // 
            this.customer.Image = ((System.Drawing.Image)(resources.GetObject("customer.Image")));
            this.customer.Location = new System.Drawing.Point(84, 414);
            this.customer.Name = "customer";
            this.customer.Size = new System.Drawing.Size(310, 278);
            this.customer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.customer.TabIndex = 2;
            this.customer.TabStop = false;
            this.customer.Click += new System.EventHandler(this.customer_Click);
            // 
            // staff
            // 
            this.staff.Image = ((System.Drawing.Image)(resources.GetObject("staff.Image")));
            this.staff.Location = new System.Drawing.Point(432, 414);
            this.staff.Name = "staff";
            this.staff.Size = new System.Drawing.Size(310, 278);
            this.staff.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.staff.TabIndex = 3;
            this.staff.TabStop = false;
            this.staff.Click += new System.EventHandler(this.staff_Click);
            // 
            // admin
            // 
            this.admin.Image = ((System.Drawing.Image)(resources.GetObject("admin.Image")));
            this.admin.Location = new System.Drawing.Point(765, 414);
            this.admin.Name = "admin";
            this.admin.Size = new System.Drawing.Size(310, 278);
            this.admin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.admin.TabIndex = 4;
            this.admin.TabStop = false;
            this.admin.Click += new System.EventHandler(this.admin_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Beige;
            this.ClientSize = new System.Drawing.Size(1135, 714);
            this.Controls.Add(this.admin);
            this.Controls.Add(this.staff);
            this.Controls.Add(this.customer);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.logo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cuisinec Restaurant Management";
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.staff)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.admin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox customer;
        private System.Windows.Forms.PictureBox staff;
        private System.Windows.Forms.PictureBox admin;
    }
}

