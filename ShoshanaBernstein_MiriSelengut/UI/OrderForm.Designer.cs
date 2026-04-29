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
            this.OrderQuantityTxtBx.Location = new System.Drawing.Point(157, 185);
            this.OrderQuantityTxtBx.Name = "OrderQuantityTxtBx";
            this.OrderQuantityTxtBx.Size = new System.Drawing.Size(126, 22);
            this.OrderQuantityTxtBx.TabIndex = 17;
            // 
            // OrderGrpBx
            // 
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
            this.OrderGrpBx.Location = new System.Drawing.Point(236, 95);
            this.OrderGrpBx.Name = "OrderGrpBx";
            this.OrderGrpBx.Size = new System.Drawing.Size(315, 222);
            this.OrderGrpBx.TabIndex = 13;
            this.OrderGrpBx.TabStop = false;
            this.OrderGrpBx.Text = "Add a new order";
            // 
            // SearchCustomerBtn
            // 
            this.SearchCustomerBtn.Location = new System.Drawing.Point(153, 27);
            this.SearchCustomerBtn.Name = "SearchCustomerBtn";
            this.SearchCustomerBtn.Size = new System.Drawing.Size(156, 29);
            this.SearchCustomerBtn.TabIndex = 22;
            this.SearchCustomerBtn.Text = "Search by Customer ID";
            this.SearchCustomerBtn.UseVisualStyleBackColor = true;
            this.SearchCustomerBtn.Click += new System.EventHandler(this.SearchCustomerBtn_Click_1);
            // 
            // SearchProductBtn
            // 
            this.SearchProductBtn.Location = new System.Drawing.Point(6, 27);
            this.SearchProductBtn.Name = "SearchProductBtn";
            this.SearchProductBtn.Size = new System.Drawing.Size(144, 29);
            this.SearchProductBtn.TabIndex = 21;
            this.SearchProductBtn.Text = "Search by Product ID";
            this.SearchProductBtn.UseVisualStyleBackColor = true;
            this.SearchProductBtn.Click += new System.EventHandler(this.SearchProductBtn_Click);
            // 
            // OrderIDTxtBx
            // 
            this.OrderIDTxtBx.Location = new System.Drawing.Point(157, 75);
            this.OrderIDTxtBx.Name = "OrderIDTxtBx";
            this.OrderIDTxtBx.Size = new System.Drawing.Size(126, 22);
            this.OrderIDTxtBx.TabIndex = 20;
            // 
            // OrderIDLbl
            // 
            this.OrderIDLbl.AutoSize = true;
            this.OrderIDLbl.Location = new System.Drawing.Point(33, 81);
            this.OrderIDLbl.Name = "OrderIDLbl";
            this.OrderIDLbl.Size = new System.Drawing.Size(60, 16);
            this.OrderIDLbl.TabIndex = 19;
            this.OrderIDLbl.Text = "Order ID:";
            // 
            // OrderQuantityLbl
            // 
            this.OrderQuantityLbl.AutoSize = true;
            this.OrderQuantityLbl.Location = new System.Drawing.Point(33, 186);
            this.OrderQuantityLbl.Name = "OrderQuantityLbl";
            this.OrderQuantityLbl.Size = new System.Drawing.Size(95, 16);
            this.OrderQuantityLbl.TabIndex = 18;
            this.OrderQuantityLbl.Text = "Order Quantity:";
            // 
            // CustomerIDLbl
            // 
            this.CustomerIDLbl.AutoSize = true;
            this.CustomerIDLbl.Location = new System.Drawing.Point(33, 116);
            this.CustomerIDLbl.Name = "CustomerIDLbl";
            this.CustomerIDLbl.Size = new System.Drawing.Size(83, 16);
            this.CustomerIDLbl.TabIndex = 14;
            this.CustomerIDLbl.Text = "Customer ID:";
            // 
            // CustomerIDTxtBx
            // 
            this.CustomerIDTxtBx.Location = new System.Drawing.Point(157, 115);
            this.CustomerIDTxtBx.Name = "CustomerIDTxtBx";
            this.CustomerIDTxtBx.Size = new System.Drawing.Size(126, 22);
            this.CustomerIDTxtBx.TabIndex = 13;
            // 
            // ProductIDLbl
            // 
            this.ProductIDLbl.AutoSize = true;
            this.ProductIDLbl.Location = new System.Drawing.Point(33, 151);
            this.ProductIDLbl.Name = "ProductIDLbl";
            this.ProductIDLbl.Size = new System.Drawing.Size(72, 16);
            this.ProductIDLbl.TabIndex = 16;
            this.ProductIDLbl.Text = "Product ID:";
            // 
            // ProductIDTxtBx
            // 
            this.ProductIDTxtBx.Location = new System.Drawing.Point(157, 150);
            this.ProductIDTxtBx.Name = "ProductIDTxtBx";
            this.ProductIDTxtBx.Size = new System.Drawing.Size(126, 22);
            this.ProductIDTxtBx.TabIndex = 15;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
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
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.OrderGrpBx);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "OrderForm";
            this.Text = "OrderForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.OrderForm_FormClosing);
            this.Controls.SetChildIndex(this.menuStrip1, 0);
            this.Controls.SetChildIndex(this.OrderGrpBx, 0);
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