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
            this.OrderQuantityTxtBx = new System.Windows.Forms.TextBox();
            this.OrderGrpBx = new System.Windows.Forms.GroupBox();
            this.OrderIDTxtBx = new System.Windows.Forms.TextBox();
            this.OrderIDLbl = new System.Windows.Forms.Label();
            this.OrderQuantityLbl = new System.Windows.Forms.Label();
            this.CustomerIDLbl = new System.Windows.Forms.Label();
            this.CustomerIDTxtBx = new System.Windows.Forms.TextBox();
            this.ProductIDLbl = new System.Windows.Forms.Label();
            this.ProductIDTxtBx = new System.Windows.Forms.TextBox();
            this.OrderGrpBx.SuspendLayout();
            this.SuspendLayout();
            // 
            // OrderQuantityTxtBx
            // 
            this.OrderQuantityTxtBx.Location = new System.Drawing.Point(162, 158);
            this.OrderQuantityTxtBx.Name = "OrderQuantityTxtBx";
            this.OrderQuantityTxtBx.Size = new System.Drawing.Size(126, 22);
            this.OrderQuantityTxtBx.TabIndex = 17;
            // 
            // OrderGrpBx
            // 
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
            // OrderIDTxtBx
            // 
            this.OrderIDTxtBx.Location = new System.Drawing.Point(162, 48);
            this.OrderIDTxtBx.Name = "OrderIDTxtBx";
            this.OrderIDTxtBx.Size = new System.Drawing.Size(126, 22);
            this.OrderIDTxtBx.TabIndex = 20;
            // 
            // OrderIDLbl
            // 
            this.OrderIDLbl.AutoSize = true;
            this.OrderIDLbl.Location = new System.Drawing.Point(38, 54);
            this.OrderIDLbl.Name = "OrderIDLbl";
            this.OrderIDLbl.Size = new System.Drawing.Size(60, 16);
            this.OrderIDLbl.TabIndex = 19;
            this.OrderIDLbl.Text = "Order ID:";
            // 
            // OrderQuantityLbl
            // 
            this.OrderQuantityLbl.AutoSize = true;
            this.OrderQuantityLbl.Location = new System.Drawing.Point(38, 159);
            this.OrderQuantityLbl.Name = "OrderQuantityLbl";
            this.OrderQuantityLbl.Size = new System.Drawing.Size(95, 16);
            this.OrderQuantityLbl.TabIndex = 18;
            this.OrderQuantityLbl.Text = "Order Quantity:";
            // 
            // CustomerIDLbl
            // 
            this.CustomerIDLbl.AutoSize = true;
            this.CustomerIDLbl.Location = new System.Drawing.Point(38, 89);
            this.CustomerIDLbl.Name = "CustomerIDLbl";
            this.CustomerIDLbl.Size = new System.Drawing.Size(83, 16);
            this.CustomerIDLbl.TabIndex = 14;
            this.CustomerIDLbl.Text = "Customer ID:";
            // 
            // CustomerIDTxtBx
            // 
            this.CustomerIDTxtBx.Location = new System.Drawing.Point(162, 88);
            this.CustomerIDTxtBx.Name = "CustomerIDTxtBx";
            this.CustomerIDTxtBx.Size = new System.Drawing.Size(126, 22);
            this.CustomerIDTxtBx.TabIndex = 13;
            // 
            // ProductIDLbl
            // 
            this.ProductIDLbl.AutoSize = true;
            this.ProductIDLbl.Location = new System.Drawing.Point(38, 124);
            this.ProductIDLbl.Name = "ProductIDLbl";
            this.ProductIDLbl.Size = new System.Drawing.Size(72, 16);
            this.ProductIDLbl.TabIndex = 16;
            this.ProductIDLbl.Text = "Product ID:";
            // 
            // ProductIDTxtBx
            // 
            this.ProductIDTxtBx.Location = new System.Drawing.Point(162, 123);
            this.ProductIDTxtBx.Name = "ProductIDTxtBx";
            this.ProductIDTxtBx.Size = new System.Drawing.Size(126, 22);
            this.ProductIDTxtBx.TabIndex = 15;
            // 
            // OrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.OrderGrpBx);
            this.Name = "OrderForm";
            this.Text = "OrderForm";
            this.Controls.SetChildIndex(this.OrderGrpBx, 0);
            this.OrderGrpBx.ResumeLayout(false);
            this.OrderGrpBx.PerformLayout();
            this.ResumeLayout(false);

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
    }
}