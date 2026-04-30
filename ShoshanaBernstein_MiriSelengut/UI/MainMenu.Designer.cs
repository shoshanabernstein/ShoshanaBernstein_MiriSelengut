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
            this.components = new System.ComponentModel.Container();
            this.CustomerFormBtn = new System.Windows.Forms.Button();
            this.ProductFormBtn = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.WelcomeLbl = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.OrderFormBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.SuspendLayout();
            // 
            // CustomerFormBtn
            // 
            this.CustomerFormBtn.BackColor = System.Drawing.Color.AntiqueWhite;
            this.CustomerFormBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CustomerFormBtn.Font = new System.Drawing.Font("Narkisim", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerFormBtn.ForeColor = System.Drawing.Color.SaddleBrown;
            this.CustomerFormBtn.Location = new System.Drawing.Point(121, 251);
            this.CustomerFormBtn.Name = "CustomerFormBtn";
            this.CustomerFormBtn.Size = new System.Drawing.Size(168, 58);
            this.CustomerFormBtn.TabIndex = 2;
            this.CustomerFormBtn.Text = "Customers";
            this.CustomerFormBtn.UseVisualStyleBackColor = false;
            this.CustomerFormBtn.Click += new System.EventHandler(this.CustomerFormBtn_Click);
            // 
            // ProductFormBtn
            // 
            this.ProductFormBtn.BackColor = System.Drawing.Color.AntiqueWhite;
            this.ProductFormBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ProductFormBtn.Font = new System.Drawing.Font("Narkisim", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductFormBtn.ForeColor = System.Drawing.Color.SaddleBrown;
            this.ProductFormBtn.Location = new System.Drawing.Point(310, 251);
            this.ProductFormBtn.Name = "ProductFormBtn";
            this.ProductFormBtn.Size = new System.Drawing.Size(168, 58);
            this.ProductFormBtn.TabIndex = 3;
            this.ProductFormBtn.Text = "Products";
            this.ProductFormBtn.UseVisualStyleBackColor = false;
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
            // WelcomeLbl
            // 
            this.WelcomeLbl.AutoSize = true;
            this.WelcomeLbl.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.WelcomeLbl.Font = new System.Drawing.Font("Imprint MT Shadow", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WelcomeLbl.Location = new System.Drawing.Point(135, 83);
            this.WelcomeLbl.Name = "WelcomeLbl";
            this.WelcomeLbl.Size = new System.Drawing.Size(533, 40);
            this.WelcomeLbl.TabIndex = 5;
            this.WelcomeLbl.Text = "Welcome to The Furniture Store!";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Narkisim", 8.5F);
            this.label2.Location = new System.Drawing.Point(261, 428);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(303, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "Proudly bought to you by DOROTHY x THOMAS";
            // 
            // OrderFormBtn
            // 
            this.OrderFormBtn.BackColor = System.Drawing.Color.AntiqueWhite;
            this.OrderFormBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.OrderFormBtn.Font = new System.Drawing.Font("Narkisim", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OrderFormBtn.ForeColor = System.Drawing.Color.SaddleBrown;
            this.OrderFormBtn.Location = new System.Drawing.Point(500, 251);
            this.OrderFormBtn.Name = "OrderFormBtn";
            this.OrderFormBtn.Size = new System.Drawing.Size(168, 58);
            this.OrderFormBtn.TabIndex = 7;
            this.OrderFormBtn.Text = "Orders";
            this.OrderFormBtn.UseVisualStyleBackColor = false;
            this.OrderFormBtn.Click += new System.EventHandler(this.OrderFormBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Narkisim", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label1.Location = new System.Drawing.Point(315, 193);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 18);
            this.label1.TabIndex = 8;
            this.label1.Text = "Click button to access:";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OldLace;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.OrderFormBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.WelcomeLbl);
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
        private System.Windows.Forms.Label WelcomeLbl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button OrderFormBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    }
}