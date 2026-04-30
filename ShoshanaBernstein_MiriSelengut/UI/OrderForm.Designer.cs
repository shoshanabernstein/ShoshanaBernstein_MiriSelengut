namespace UI
{
    partial class OrderForm
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
            this.OrderQuantityTxtBx = new System.Windows.Forms.TextBox();
            this.OrderGrpBx = new System.Windows.Forms.GroupBox();
            this.SearchCustomerBtn = new System.Windows.Forms.Button();
            this.SearchProductBtn = new System.Windows.Forms.Button();
            this.OrderIDTxtBx = new System.Windows.Forms.TextBox();
            this.OrderIDLbl = new System.Windows.Forms.Label();
            this.OrderQuantityLbl = new System.Windows.Forms.Label();
            this.CustomerIDLbl = new System.Windows.Forms.Label();
            this.CustomerIDTxtBx = new System.Windows.Forms.TextBox();
            this.ProductIDLbl = new System.Windows.Forms.Label();
            this.ProductIDTxtBx = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.OrderGrpBx.SuspendLayout();
            this.SuspendLayout();
            // 
            // OrderQuantityTxtBx
            // 
            this.OrderQuantityTxtBx.BackColor = System.Drawing.Color.Linen;
            this.OrderQuantityTxtBx.ForeColor = System.Drawing.Color.SaddleBrown;
            this.OrderQuantityTxtBx.Location = new System.Drawing.Point(171, 146);
            this.OrderQuantityTxtBx.Name = "OrderQuantityTxtBx";
            this.OrderQuantityTxtBx.Size = new System.Drawing.Size(126, 22);
            this.OrderQuantityTxtBx.TabIndex = 9;
            // 
            // OrderGrpBx
            // 
            this.OrderGrpBx.BackColor = System.Drawing.Color.OldLace;
            this.OrderGrpBx.Controls.Add(this.SearchCustomerBtn);
            this.OrderGrpBx.Controls.Add(this.SearchProductBtn);
            this.OrderGrpBx.Controls.Add(this.OrderIDTxtBx);
            this.OrderGrpBx.Controls.Add(this.OrderIDLbl);
            this.OrderGrpBx.Controls.Add(this.OrderQuantityLbl);
            this.OrderGrpBx.Controls.Add(this.CustomerIDLbl);
            this.OrderGrpBx.Controls.Add(this.OrderQuantityTxtBx);
            this.OrderGrpBx.Controls.Add(this.CustomerIDTxtBx);
            this.OrderGrpBx.Controls.Add(this.ProductIDLbl);
            this.OrderGrpBx.Controls.Add(this.ProductIDTxtBx);
            this.OrderGrpBx.ForeColor = System.Drawing.Color.SaddleBrown;
            this.OrderGrpBx.Location = new System.Drawing.Point(207, 68);
            this.OrderGrpBx.Name = "OrderGrpBx";
            this.OrderGrpBx.Size = new System.Drawing.Size(348, 262);
            this.OrderGrpBx.TabIndex = 13;
            this.OrderGrpBx.TabStop = false;
            this.OrderGrpBx.Text = "Add a new order";
            // 
            // SearchCustomerBtn
            // 
            this.SearchCustomerBtn.BackColor = System.Drawing.Color.AntiqueWhite;
            this.SearchCustomerBtn.Location = new System.Drawing.Point(171, 190);
            this.SearchCustomerBtn.Name = "SearchCustomerBtn";
            this.SearchCustomerBtn.Size = new System.Drawing.Size(156, 27);
            this.SearchCustomerBtn.TabIndex = 11;
            this.SearchCustomerBtn.Text = "Search by Customer ID";
            this.SearchCustomerBtn.UseVisualStyleBackColor = false;
            this.SearchCustomerBtn.Click += new System.EventHandler(this.SearchCustomerBtn_Click_1);
            // 
            // SearchProductBtn
            // 
            this.SearchProductBtn.BackColor = System.Drawing.Color.AntiqueWhite;
            this.SearchProductBtn.Location = new System.Drawing.Point(17, 190);
            this.SearchProductBtn.Name = "SearchProductBtn";
            this.SearchProductBtn.Size = new System.Drawing.Size(144, 27);
            this.SearchProductBtn.TabIndex = 10;
            this.SearchProductBtn.Text = "Search by Product ID";
            this.SearchProductBtn.UseVisualStyleBackColor = false;
            this.SearchProductBtn.Click += new System.EventHandler(this.SearchProductBtn_Click);
            // 
            // OrderIDTxtBx
            // 
            this.OrderIDTxtBx.BackColor = System.Drawing.Color.Linen;
            this.OrderIDTxtBx.ForeColor = System.Drawing.Color.SaddleBrown;
            this.OrderIDTxtBx.Location = new System.Drawing.Point(171, 43);
            this.OrderIDTxtBx.Name = "OrderIDTxtBx";
            this.OrderIDTxtBx.Size = new System.Drawing.Size(126, 22);
            this.OrderIDTxtBx.TabIndex = 6;
            // 
            // OrderIDLbl
            // 
            this.OrderIDLbl.AutoSize = true;
            this.OrderIDLbl.ForeColor = System.Drawing.Color.SaddleBrown;
            this.OrderIDLbl.Location = new System.Drawing.Point(47, 49);
            this.OrderIDLbl.Name = "OrderIDLbl";
            this.OrderIDLbl.Size = new System.Drawing.Size(64, 15);
            this.OrderIDLbl.TabIndex = 19;
            this.OrderIDLbl.Text = "Order ID:";
            // 
            // OrderQuantityLbl
            // 
            this.OrderQuantityLbl.AutoSize = true;
            this.OrderQuantityLbl.ForeColor = System.Drawing.Color.SaddleBrown;
            this.OrderQuantityLbl.Location = new System.Drawing.Point(47, 147);
            this.OrderQuantityLbl.Name = "OrderQuantityLbl";
            this.OrderQuantityLbl.Size = new System.Drawing.Size(103, 15);
            this.OrderQuantityLbl.TabIndex = 18;
            this.OrderQuantityLbl.Text = "Order Quantity:";
            // 
            // CustomerIDLbl
            // 
            this.CustomerIDLbl.AutoSize = true;
            this.CustomerIDLbl.ForeColor = System.Drawing.Color.SaddleBrown;
            this.CustomerIDLbl.Location = new System.Drawing.Point(47, 81);
            this.CustomerIDLbl.Name = "CustomerIDLbl";
            this.CustomerIDLbl.Size = new System.Drawing.Size(84, 15);
            this.CustomerIDLbl.TabIndex = 14;
            this.CustomerIDLbl.Text = "Customer ID:";
            // 
            // CustomerIDTxtBx
            // 
            this.CustomerIDTxtBx.BackColor = System.Drawing.Color.Linen;
            this.CustomerIDTxtBx.ForeColor = System.Drawing.Color.SaddleBrown;
            this.CustomerIDTxtBx.Location = new System.Drawing.Point(171, 80);
            this.CustomerIDTxtBx.Name = "CustomerIDTxtBx";
            this.CustomerIDTxtBx.Size = new System.Drawing.Size(126, 22);
            this.CustomerIDTxtBx.TabIndex = 7;
            // 
            // ProductIDLbl
            // 
            this.ProductIDLbl.AutoSize = true;
            this.ProductIDLbl.ForeColor = System.Drawing.Color.SaddleBrown;
            this.ProductIDLbl.Location = new System.Drawing.Point(47, 114);
            this.ProductIDLbl.Name = "ProductIDLbl";
            this.ProductIDLbl.Size = new System.Drawing.Size(74, 15);
            this.ProductIDLbl.TabIndex = 16;
            this.ProductIDLbl.Text = "Product ID:";
            // 
            // ProductIDTxtBx
            // 
            this.ProductIDTxtBx.BackColor = System.Drawing.Color.Linen;
            this.ProductIDTxtBx.ForeColor = System.Drawing.Color.SaddleBrown;
            this.ProductIDTxtBx.Location = new System.Drawing.Point(171, 113);
            this.ProductIDTxtBx.Name = "ProductIDTxtBx";
            this.ProductIDTxtBx.Size = new System.Drawing.Size(126, 22);
            this.ProductIDTxtBx.TabIndex = 8;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(660, 24);
            this.menuStrip1.TabIndex = 14;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // OrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(660, 420);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.OrderGrpBx);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "OrderForm";
            this.Text = "OrderForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.OrderForm_FormClosing);
            this.Controls.SetChildIndex(this.OrderGrpBx, 0);
            this.Controls.SetChildIndex(this.menuStrip1, 0);
            this.OrderGrpBx.ResumeLayout(false);
            this.OrderGrpBx.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox OrderQuantityTxtBx;
        private System.Windows.Forms.GroupBox OrderGrpBx;
        private System.Windows.Forms.TextBox OrderIDTxtBx;
        private System.Windows.Forms.Label OrderIDLbl;
        private System.Windows.Forms.Label OrderQuantityLbl;
        private System.Windows.Forms.Label CustomerIDLbl;
        private System.Windows.Forms.TextBox CustomerIDTxtBx;
        private System.Windows.Forms.Label ProductIDLbl;
        private System.Windows.Forms.TextBox ProductIDTxtBx;
        private System.Windows.Forms.Button SearchCustomerBtn;
        private System.Windows.Forms.Button SearchProductBtn;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    }
}