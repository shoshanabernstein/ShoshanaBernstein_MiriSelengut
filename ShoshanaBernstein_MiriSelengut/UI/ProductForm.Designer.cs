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
            this.label1 = new System.Windows.Forms.Label();
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
            this.CreateGrpBx.Controls.Add(this.label1);
            this.CreateGrpBx.Controls.Add(this.AmountInStockLbl);
            this.CreateGrpBx.Controls.Add(this.AmountInStockTxtBx);
            this.CreateGrpBx.Controls.Add(this.CostPerUnitLbl);
            this.CreateGrpBx.Controls.Add(this.CostPerUnitTxtBx);
            this.CreateGrpBx.Controls.Add(this.ProductIDLbl);
            this.CreateGrpBx.Controls.Add(this.ProductIDTxtBx);
            this.CreateGrpBx.Controls.Add(this.ProductNameLbl);
            this.CreateGrpBx.Controls.Add(this.ProductNameTxtBx);
            this.CreateGrpBx.ForeColor = System.Drawing.Color.SaddleBrown;
            this.CreateGrpBx.Location = new System.Drawing.Point(214, 67);
            this.CreateGrpBx.Name = "CreateGrpBx";
            this.CreateGrpBx.Size = new System.Drawing.Size(378, 262);
            this.CreateGrpBx.TabIndex = 11;
            this.CreateGrpBx.TabStop = false;
            this.CreateGrpBx.Text = "Add a new product";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(171, 134);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 15);
            this.label1.TabIndex = 10;
            this.label1.Text = "$";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // AmountInStockLbl
            // 
            this.AmountInStockLbl.AutoSize = true;
            this.AmountInStockLbl.ForeColor = System.Drawing.Color.SaddleBrown;
            this.AmountInStockLbl.Location = new System.Drawing.Point(61, 165);
            this.AmountInStockLbl.Name = "AmountInStockLbl";
            this.AmountInStockLbl.Size = new System.Drawing.Size(110, 15);
            this.AmountInStockLbl.TabIndex = 7;
            this.AmountInStockLbl.Text = "Amount in Stock:";
            // 
            // AmountInStockTxtBx
            // 
            this.AmountInStockTxtBx.BackColor = System.Drawing.Color.Linen;
            this.AmountInStockTxtBx.ForeColor = System.Drawing.Color.SaddleBrown;
            this.AmountInStockTxtBx.Location = new System.Drawing.Point(185, 164);
            this.AmountInStockTxtBx.Name = "AmountInStockTxtBx";
            this.AmountInStockTxtBx.Size = new System.Drawing.Size(126, 22);
            this.AmountInStockTxtBx.TabIndex = 9;
            // 
            // CostPerUnitLbl
            // 
            this.CostPerUnitLbl.AutoSize = true;
            this.CostPerUnitLbl.ForeColor = System.Drawing.Color.SaddleBrown;
            this.CostPerUnitLbl.Location = new System.Drawing.Point(61, 132);
            this.CostPerUnitLbl.Name = "CostPerUnitLbl";
            this.CostPerUnitLbl.Size = new System.Drawing.Size(90, 15);
            this.CostPerUnitLbl.TabIndex = 5;
            this.CostPerUnitLbl.Text = "Cost Per Unit:";
            // 
            // CostPerUnitTxtBx
            // 
            this.CostPerUnitTxtBx.BackColor = System.Drawing.Color.Linen;
            this.CostPerUnitTxtBx.ForeColor = System.Drawing.Color.SaddleBrown;
            this.CostPerUnitTxtBx.Location = new System.Drawing.Point(185, 131);
            this.CostPerUnitTxtBx.Name = "CostPerUnitTxtBx";
            this.CostPerUnitTxtBx.Size = new System.Drawing.Size(126, 22);
            this.CostPerUnitTxtBx.TabIndex = 8;
            // 
            // ProductIDLbl
            // 
            this.ProductIDLbl.AutoSize = true;
            this.ProductIDLbl.ForeColor = System.Drawing.Color.SaddleBrown;
            this.ProductIDLbl.Location = new System.Drawing.Point(61, 99);
            this.ProductIDLbl.Name = "ProductIDLbl";
            this.ProductIDLbl.Size = new System.Drawing.Size(74, 15);
            this.ProductIDLbl.TabIndex = 3;
            this.ProductIDLbl.Text = "Product ID:";
            // 
            // ProductIDTxtBx
            // 
            this.ProductIDTxtBx.BackColor = System.Drawing.Color.Linen;
            this.ProductIDTxtBx.ForeColor = System.Drawing.Color.SaddleBrown;
            this.ProductIDTxtBx.Location = new System.Drawing.Point(185, 98);
            this.ProductIDTxtBx.Name = "ProductIDTxtBx";
            this.ProductIDTxtBx.Size = new System.Drawing.Size(126, 22);
            this.ProductIDTxtBx.TabIndex = 7;
            // 
            // ProductNameLbl
            // 
            this.ProductNameLbl.AutoSize = true;
            this.ProductNameLbl.ForeColor = System.Drawing.Color.SaddleBrown;
            this.ProductNameLbl.Location = new System.Drawing.Point(61, 66);
            this.ProductNameLbl.Name = "ProductNameLbl";
            this.ProductNameLbl.Size = new System.Drawing.Size(95, 15);
            this.ProductNameLbl.TabIndex = 1;
            this.ProductNameLbl.Text = "Product Name:";
            // 
            // ProductNameTxtBx
            // 
            this.ProductNameTxtBx.BackColor = System.Drawing.Color.Linen;
            this.ProductNameTxtBx.ForeColor = System.Drawing.Color.SaddleBrown;
            this.ProductNameTxtBx.Location = new System.Drawing.Point(185, 65);
            this.ProductNameTxtBx.Name = "ProductNameTxtBx";
            this.ProductNameTxtBx.Size = new System.Drawing.Size(126, 22);
            this.ProductNameTxtBx.TabIndex = 6;
            // 
            // ProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(671, 419);
            this.Controls.Add(this.CreateGrpBx);
            this.Name = "ProductForm";
            this.Text = "ProductForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ProductForm_FormClosing);
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
        private System.Windows.Forms.Label label1;
    }
}