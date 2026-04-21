namespace UI
{
    partial class ProductForm
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
            this.CreateGrpBx = new System.Windows.Forms.GroupBox();
            this.AmountInStockLbl = new System.Windows.Forms.Label();
            this.AmountInStockTxtBx = new System.Windows.Forms.TextBox();
            this.CostPerUnitLbl = new System.Windows.Forms.Label();
            this.CostPerUnitTxtBx = new System.Windows.Forms.TextBox();
            this.ProductIDLbl = new System.Windows.Forms.Label();
            this.ProductIDTxtBx = new System.Windows.Forms.TextBox();
            this.ProductNameLbl = new System.Windows.Forms.Label();
            this.ProductNameTxtBx = new System.Windows.Forms.TextBox();
            this.CreateGrpBx.SuspendLayout();
            this.SuspendLayout();
            // 
            // CreateGrpBx
            // 
            this.CreateGrpBx.Controls.Add(this.AmountInStockLbl);
            this.CreateGrpBx.Controls.Add(this.AmountInStockTxtBx);
            this.CreateGrpBx.Controls.Add(this.CostPerUnitLbl);
            this.CreateGrpBx.Controls.Add(this.CostPerUnitTxtBx);
            this.CreateGrpBx.Controls.Add(this.ProductIDLbl);
            this.CreateGrpBx.Controls.Add(this.ProductIDTxtBx);
            this.CreateGrpBx.Controls.Add(this.ProductNameLbl);
            this.CreateGrpBx.Controls.Add(this.ProductNameTxtBx);
            this.CreateGrpBx.Location = new System.Drawing.Point(280, 95);
            this.CreateGrpBx.Name = "CreateGrpBx";
            this.CreateGrpBx.Size = new System.Drawing.Size(283, 222);
            this.CreateGrpBx.TabIndex = 11;
            this.CreateGrpBx.TabStop = false;
            this.CreateGrpBx.Text = "Add a new product";
            // 
            // AmountInStockLbl
            // 
            this.AmountInStockLbl.AutoSize = true;
            this.AmountInStockLbl.Location = new System.Drawing.Point(8, 151);
            this.AmountInStockLbl.Name = "AmountInStockLbl";
            this.AmountInStockLbl.Size = new System.Drawing.Size(105, 16);
            this.AmountInStockLbl.TabIndex = 7;
            this.AmountInStockLbl.Text = "Amount in Stock:";
            // 
            // AmountInStockTxtBx
            // 
            this.AmountInStockTxtBx.Location = new System.Drawing.Point(132, 150);
            this.AmountInStockTxtBx.Name = "AmountInStockTxtBx";
            this.AmountInStockTxtBx.Size = new System.Drawing.Size(126, 22);
            this.AmountInStockTxtBx.TabIndex = 6;
            // 
            // CostPerUnitLbl
            // 
            this.CostPerUnitLbl.AutoSize = true;
            this.CostPerUnitLbl.Location = new System.Drawing.Point(8, 116);
            this.CostPerUnitLbl.Name = "CostPerUnitLbl";
            this.CostPerUnitLbl.Size = new System.Drawing.Size(87, 16);
            this.CostPerUnitLbl.TabIndex = 5;
            this.CostPerUnitLbl.Text = "Cost Per Unit:";
            // 
            // CostPerUnitTxtBx
            // 
            this.CostPerUnitTxtBx.Location = new System.Drawing.Point(132, 115);
            this.CostPerUnitTxtBx.Name = "CostPerUnitTxtBx";
            this.CostPerUnitTxtBx.Size = new System.Drawing.Size(126, 22);
            this.CostPerUnitTxtBx.TabIndex = 4;
            // 
            // ProductIDLbl
            // 
            this.ProductIDLbl.AutoSize = true;
            this.ProductIDLbl.Location = new System.Drawing.Point(8, 81);
            this.ProductIDLbl.Name = "ProductIDLbl";
            this.ProductIDLbl.Size = new System.Drawing.Size(72, 16);
            this.ProductIDLbl.TabIndex = 3;
            this.ProductIDLbl.Text = "Product ID:";
            // 
            // ProductIDTxtBx
            // 
            this.ProductIDTxtBx.Location = new System.Drawing.Point(132, 80);
            this.ProductIDTxtBx.Name = "ProductIDTxtBx";
            this.ProductIDTxtBx.Size = new System.Drawing.Size(126, 22);
            this.ProductIDTxtBx.TabIndex = 2;
            // 
            // ProductNameLbl
            // 
            this.ProductNameLbl.AutoSize = true;
            this.ProductNameLbl.Location = new System.Drawing.Point(8, 46);
            this.ProductNameLbl.Name = "ProductNameLbl";
            this.ProductNameLbl.Size = new System.Drawing.Size(96, 16);
            this.ProductNameLbl.TabIndex = 1;
            this.ProductNameLbl.Text = "Product Name:";
            // 
            // ProductNameTxtBx
            // 
            this.ProductNameTxtBx.Location = new System.Drawing.Point(132, 45);
            this.ProductNameTxtBx.Name = "ProductNameTxtBx";
            this.ProductNameTxtBx.Size = new System.Drawing.Size(126, 22);
            this.ProductNameTxtBx.TabIndex = 0;
            // 
            // ProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CreateGrpBx);
            this.Name = "ProductForm";
            this.Text = "ProductForm";
            this.Controls.SetChildIndex(this.CreateGrpBx, 0);
            this.CreateGrpBx.ResumeLayout(false);
            this.CreateGrpBx.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox CreateGrpBx;
        private System.Windows.Forms.Label AmountInStockLbl;
        private System.Windows.Forms.TextBox AmountInStockTxtBx;
        private System.Windows.Forms.Label CostPerUnitLbl;
        private System.Windows.Forms.TextBox CostPerUnitTxtBx;
        private System.Windows.Forms.Label ProductIDLbl;
        private System.Windows.Forms.TextBox ProductIDTxtBx;
        private System.Windows.Forms.Label ProductNameLbl;
        private System.Windows.Forms.TextBox ProductNameTxtBx;
    }
}