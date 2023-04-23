
namespace WindowsFormsApp6
{
    partial class dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(dashboard));
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cart = new System.Windows.Forms.Button();
            this.drink = new System.Windows.Forms.Button();
            this.food = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.front1 = new WindowsFormsApp6.front();
            this.food11 = new WindowsFormsApp6.food1();
            this.drink11 = new WindowsFormsApp6.drink1();
            this.cartt1 = new WindowsFormsApp6.cartt();
            this.feedback1 = new WindowsFormsApp6.feedback();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Beige;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.cart);
            this.panel1.Controls.Add(this.drink);
            this.panel1.Controls.Add(this.food);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(1, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(347, 1026);
            this.panel1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Crimson;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(-2, 781);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(347, 61);
            this.button1.TabIndex = 6;
            this.button1.Text = "Feedback";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(347, -1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1551, 1026);
            this.panel2.TabIndex = 1;
            // 
            // cart
            // 
            this.cart.BackColor = System.Drawing.Color.Crimson;
            this.cart.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cart.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cart.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cart.Location = new System.Drawing.Point(-2, 639);
            this.cart.Name = "cart";
            this.cart.Size = new System.Drawing.Size(347, 61);
            this.cart.TabIndex = 4;
            this.cart.Text = "Cart";
            this.cart.UseVisualStyleBackColor = false;
            this.cart.Click += new System.EventHandler(this.cart_Click);
            // 
            // drink
            // 
            this.drink.BackColor = System.Drawing.Color.Crimson;
            this.drink.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.drink.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drink.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.drink.Location = new System.Drawing.Point(-1, 504);
            this.drink.Name = "drink";
            this.drink.Size = new System.Drawing.Size(347, 61);
            this.drink.TabIndex = 2;
            this.drink.Text = "Drinks";
            this.drink.UseVisualStyleBackColor = false;
            this.drink.Click += new System.EventHandler(this.drink_Click);
            // 
            // food
            // 
            this.food.BackColor = System.Drawing.Color.Crimson;
            this.food.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.food.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.food.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.food.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.food.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.food.Location = new System.Drawing.Point(0, 370);
            this.food.Name = "food";
            this.food.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.food.Size = new System.Drawing.Size(347, 61);
            this.food.TabIndex = 1;
            this.food.Text = "Food";
            this.food.UseVisualStyleBackColor = false;
            this.food.Click += new System.EventHandler(this.food_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(347, 302);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Beige;
            this.panel3.Controls.Add(this.panel8);
            this.panel3.Controls.Add(this.panel7);
            this.panel3.Location = new System.Drawing.Point(349, 1);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1548, 1023);
            this.panel3.TabIndex = 1;
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.front1);
            this.panel8.Controls.Add(this.food11);
            this.panel8.Controls.Add(this.drink11);
            this.panel8.Controls.Add(this.cartt1);
            this.panel8.Controls.Add(this.feedback1);
            this.panel8.Location = new System.Drawing.Point(1, 88);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(1547, 935);
            this.panel8.TabIndex = 3;
            // 
            // front1
            // 
            this.front1.BackColor = System.Drawing.Color.Beige;
            this.front1.Location = new System.Drawing.Point(-1, 2);
            this.front1.Name = "front1";
            this.front1.Size = new System.Drawing.Size(1545, 933);
            this.front1.TabIndex = 0;
            // 
            // food11
            // 
            this.food11.BackColor = System.Drawing.Color.Beige;
            this.food11.Location = new System.Drawing.Point(0, 2);
            this.food11.Name = "food11";
            this.food11.Size = new System.Drawing.Size(1548, 1023);
            this.food11.TabIndex = 1;
            // 
            // drink11
            // 
            this.drink11.BackColor = System.Drawing.Color.Beige;
            this.drink11.Location = new System.Drawing.Point(-1, 1);
            this.drink11.Name = "drink11";
            this.drink11.Size = new System.Drawing.Size(1545, 933);
            this.drink11.TabIndex = 2;
            // 
            // cartt1
            // 
            this.cartt1.BackColor = System.Drawing.Color.Beige;
            this.cartt1.Location = new System.Drawing.Point(0, -1);
            this.cartt1.Name = "cartt1";
            this.cartt1.Size = new System.Drawing.Size(1545, 933);
            this.cartt1.TabIndex = 5;
            // 
            // feedback1
            // 
            this.feedback1.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.feedback1.BackColor = System.Drawing.Color.Beige;
            this.feedback1.Location = new System.Drawing.Point(-2, -1);
            this.feedback1.Name = "feedback1";
            this.feedback1.Size = new System.Drawing.Size(1547, 935);
            this.feedback1.TabIndex = 6;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.Crimson;
            this.panel7.Controls.Add(this.label3);
            this.panel7.Location = new System.Drawing.Point(0, 0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(1551, 57);
            this.panel7.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(445, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(527, 38);
            this.label3.TabIndex = 1;
            this.label3.Text = "JAPANESE CUISINEC RESTAURANT";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(445, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(527, 38);
            this.label1.TabIndex = 1;
            this.label1.Text = "JAPANESE CUISINEC RESTAURANT";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panel4.Controls.Add(this.panel6);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.label2);
            this.panel4.ForeColor = System.Drawing.Color.Transparent;
            this.panel4.Location = new System.Drawing.Point(349, 55);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1548, 33);
            this.panel4.TabIndex = 3;
            // 
            // panel6
            // 
            this.panel6.Location = new System.Drawing.Point(4, 36);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(1547, 933);
            this.panel6.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label4.Location = new System.Drawing.Point(431, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(571, 34);
            this.label4.TabIndex = 3;
            this.label4.Text = "MOST DELICIOUS FOOD YOU\'LL EVER FIND";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(680, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 20);
            this.label2.TabIndex = 0;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel5.Controls.Add(this.label1);
            this.panel5.Location = new System.Drawing.Point(349, 1);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1548, 57);
            this.panel5.TabIndex = 2;
            // 
            // dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1898, 1024);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "dashboard";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button cart;
        private System.Windows.Forms.Button drink;
        private System.Windows.Forms.Button food;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel8;
        private front front1;
        private System.Windows.Forms.Button button1;
        private food1 food11;
        private drink1 drink11;

        private cartt cartt1;
        private feedback feedback1;
    }
}