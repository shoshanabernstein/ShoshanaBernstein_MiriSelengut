namespace UI
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
            this.CustomerFormBtn = new System.Windows.Forms.Button();
            this.ProductFormBtn = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CustomerFormBtn
            // 
            this.CustomerFormBtn.Location = new System.Drawing.Point(200, 244);
            this.CustomerFormBtn.Name = "CustomerFormBtn";
            this.CustomerFormBtn.Size = new System.Drawing.Size(168, 58);
            this.CustomerFormBtn.TabIndex = 2;
            this.CustomerFormBtn.Text = "Customers";
            this.CustomerFormBtn.UseVisualStyleBackColor = true;
            this.CustomerFormBtn.Click += new System.EventHandler(this.CustomerFormBtn_Click);
            // 
            // ProductFormBtn
            // 
            this.ProductFormBtn.Location = new System.Drawing.Point(390, 244);
            this.ProductFormBtn.Name = "ProductFormBtn";
            this.ProductFormBtn.Size = new System.Drawing.Size(168, 58);
            this.ProductFormBtn.TabIndex = 3;
            this.ProductFormBtn.Text = "Products";
            this.ProductFormBtn.UseVisualStyleBackColor = true;
            this.ProductFormBtn.Click += new System.EventHandler(this.ProductFormBtn_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(430, 126);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(0, 0);
            this.button3.TabIndex = 4;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(283, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(198, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Welcome to The Furniture Store!";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(283, 425);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(188, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "A Project of Thomas + Dorothy";
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.ProductFormBtn);
            this.Controls.Add(this.CustomerFormBtn);
            this.Name = "MainMenu";
            this.Text = "MainMenu";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainMenu_FormClosing);
            this.Load += new System.EventHandler(this.MainMenu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button CustomerFormBtn;
        private System.Windows.Forms.Button ProductFormBtn;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}