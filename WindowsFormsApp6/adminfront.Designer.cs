
namespace WindowsFormsApp6
{
    partial class adminfront
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(adminfront));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelbanner2 = new System.Windows.Forms.Label();
            this.labelbanner = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(462, 38);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(599, 533);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // labelbanner2
            // 
            this.labelbanner2.AutoSize = true;
            this.labelbanner2.Font = new System.Drawing.Font("Stencil", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelbanner2.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.labelbanner2.Location = new System.Drawing.Point(457, 798);
            this.labelbanner2.Name = "labelbanner2";
            this.labelbanner2.Size = new System.Drawing.Size(604, 47);
            this.labelbanner2.TabIndex = 7;
            this.labelbanner2.Text = "BEST JAPANESE RESTAURANT";
            // 
            // labelbanner
            // 
            this.labelbanner.AutoSize = true;
            this.labelbanner.Font = new System.Drawing.Font("Stencil", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelbanner.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.labelbanner.Location = new System.Drawing.Point(397, 653);
            this.labelbanner.Name = "labelbanner";
            this.labelbanner.Size = new System.Drawing.Size(722, 171);
            this.labelbanner.TabIndex = 6;
            this.labelbanner.Text = "CUISINEC";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Stencil", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.label1.Location = new System.Drawing.Point(536, 574);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(479, 85);
            this.label1.TabIndex = 5;
            this.label1.Text = "WELCOME TO";
            // 
            // adminfront
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Beige;
            this.Controls.Add(this.labelbanner2);
            this.Controls.Add(this.labelbanner);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "adminfront";
            this.Size = new System.Drawing.Size(1547, 935);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelbanner2;
        private System.Windows.Forms.Label labelbanner;
        private System.Windows.Forms.Label label1;
    }
}
