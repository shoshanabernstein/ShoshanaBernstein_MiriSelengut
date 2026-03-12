namespace UI
{
    partial class CRUDsMenu
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
            this.CreateBtn = new System.Windows.Forms.Button();
            this.ReadAllBtn = new System.Windows.Forms.Button();
            this.ReadBtn = new System.Windows.Forms.Button();
            this.UpdateBtn = new System.Windows.Forms.Button();
            this.DeleteBtn = new System.Windows.Forms.Button();
            this.CreateGrpBx = new System.Windows.Forms.GroupBox();
            this.EnterBtn = new System.Windows.Forms.Button();
            this.AmountInStockLbl = new System.Windows.Forms.Label();
            this.AmountInStockTxtBx = new System.Windows.Forms.TextBox();
            this.CostPerUnitLbl = new System.Windows.Forms.Label();
            this.CostPerUnitTxtBx = new System.Windows.Forms.TextBox();
            this.ProductIDLbl = new System.Windows.Forms.Label();
            this.ProductIDTxtBx = new System.Windows.Forms.TextBox();
            this.ProductNameLbl = new System.Windows.Forms.Label();
            this.ProductNameTxtBx = new System.Windows.Forms.TextBox();
            this.CloseCreateGrpBxBtn = new System.Windows.Forms.Button();
            this.CreateGrpBx.SuspendLayout();
            this.SuspendLayout();
            // 
            // CreateBtn
            // 
            this.CreateBtn.Location = new System.Drawing.Point(78, 49);
            this.CreateBtn.Name = "CreateBtn";
            this.CreateBtn.Size = new System.Drawing.Size(155, 40);
            this.CreateBtn.TabIndex = 0;
            this.CreateBtn.Text = "Add a new product";
            this.CreateBtn.UseVisualStyleBackColor = true;
            this.CreateBtn.Click += new System.EventHandler(this.CreateBtn_Click);
            // 
            // ReadAllBtn
            // 
            this.ReadAllBtn.Location = new System.Drawing.Point(78, 95);
            this.ReadAllBtn.Name = "ReadAllBtn";
            this.ReadAllBtn.Size = new System.Drawing.Size(155, 42);
            this.ReadAllBtn.TabIndex = 1;
            this.ReadAllBtn.Text = "Show all products";
            this.ReadAllBtn.UseVisualStyleBackColor = true;
            this.ReadAllBtn.Click += new System.EventHandler(this.ReadAllBtn_Click);
            // 
            // ReadBtn
            // 
            this.ReadBtn.Location = new System.Drawing.Point(78, 143);
            this.ReadBtn.Name = "ReadBtn";
            this.ReadBtn.Size = new System.Drawing.Size(155, 38);
            this.ReadBtn.TabIndex = 2;
            this.ReadBtn.Text = "Search product";
            this.ReadBtn.UseVisualStyleBackColor = true;
            this.ReadBtn.Click += new System.EventHandler(this.ReadBtn_Click);
            // 
            // UpdateBtn
            // 
            this.UpdateBtn.Location = new System.Drawing.Point(78, 187);
            this.UpdateBtn.Name = "UpdateBtn";
            this.UpdateBtn.Size = new System.Drawing.Size(154, 36);
            this.UpdateBtn.TabIndex = 3;
            this.UpdateBtn.Text = "Update a product";
            this.UpdateBtn.UseVisualStyleBackColor = true;
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.Location = new System.Drawing.Point(78, 229);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(155, 42);
            this.DeleteBtn.TabIndex = 4;
            this.DeleteBtn.Text = "Delete a product";
            this.DeleteBtn.UseVisualStyleBackColor = true;
            // 
            // CreateGrpBx
            // 
            this.CreateGrpBx.Controls.Add(this.CloseCreateGrpBxBtn);
            this.CreateGrpBx.Controls.Add(this.EnterBtn);
            this.CreateGrpBx.Controls.Add(this.AmountInStockLbl);
            this.CreateGrpBx.Controls.Add(this.AmountInStockTxtBx);
            this.CreateGrpBx.Controls.Add(this.CostPerUnitLbl);
            this.CreateGrpBx.Controls.Add(this.CostPerUnitTxtBx);
            this.CreateGrpBx.Controls.Add(this.ProductIDLbl);
            this.CreateGrpBx.Controls.Add(this.ProductIDTxtBx);
            this.CreateGrpBx.Controls.Add(this.ProductNameLbl);
            this.CreateGrpBx.Controls.Add(this.ProductNameTxtBx);
            this.CreateGrpBx.Location = new System.Drawing.Point(318, 49);
            this.CreateGrpBx.Name = "CreateGrpBx";
            this.CreateGrpBx.Size = new System.Drawing.Size(283, 222);
            this.CreateGrpBx.TabIndex = 5;
            this.CreateGrpBx.TabStop = false;
            this.CreateGrpBx.Text = "Add a new product";
            this.CreateGrpBx.Enter += new System.EventHandler(this.CreateGrpBx_Enter);
            // 
            // EnterBtn
            // 
            this.EnterBtn.Location = new System.Drawing.Point(183, 180);
            this.EnterBtn.Name = "EnterBtn";
            this.EnterBtn.Size = new System.Drawing.Size(75, 25);
            this.EnterBtn.TabIndex = 8;
            this.EnterBtn.Text = "Enter ";
            this.EnterBtn.UseVisualStyleBackColor = true;
            this.EnterBtn.Click += new System.EventHandler(this.EnterBtn_Click);
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
            this.ProductIDLbl.Click += new System.EventHandler(this.ProductIDLbl_Click);
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
            // CloseCreateGrpBxBtn
            // 
            this.CloseCreateGrpBxBtn.Location = new System.Drawing.Point(11, 180);
            this.CloseCreateGrpBxBtn.Name = "CloseCreateGrpBxBtn";
            this.CloseCreateGrpBxBtn.Size = new System.Drawing.Size(75, 25);
            this.CloseCreateGrpBxBtn.TabIndex = 9;
            this.CloseCreateGrpBxBtn.Text = "Close";
            this.CloseCreateGrpBxBtn.UseVisualStyleBackColor = true;
            this.CloseCreateGrpBxBtn.Click += new System.EventHandler(this.CloseCreateGrpBxBtn_Click);
            // 
            // CRUDsMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CreateGrpBx);
            this.Controls.Add(this.DeleteBtn);
            this.Controls.Add(this.UpdateBtn);
            this.Controls.Add(this.ReadBtn);
            this.Controls.Add(this.ReadAllBtn);
            this.Controls.Add(this.CreateBtn);
            this.Name = "CRUDsMenu";
            this.Text = "CRUDsMenu";
            this.CreateGrpBx.ResumeLayout(false);
            this.CreateGrpBx.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button CreateBtn;
        private System.Windows.Forms.Button ReadAllBtn;
        private System.Windows.Forms.Button ReadBtn;
        private System.Windows.Forms.Button UpdateBtn;
        private System.Windows.Forms.Button DeleteBtn;
        private System.Windows.Forms.GroupBox CreateGrpBx;
        private System.Windows.Forms.TextBox ProductNameTxtBx;
        private System.Windows.Forms.Label AmountInStockLbl;
        private System.Windows.Forms.TextBox AmountInStockTxtBx;
        private System.Windows.Forms.Label CostPerUnitLbl;
        private System.Windows.Forms.TextBox CostPerUnitTxtBx;
        private System.Windows.Forms.Label ProductIDLbl;
        private System.Windows.Forms.TextBox ProductIDTxtBx;
        private System.Windows.Forms.Label ProductNameLbl;
        private System.Windows.Forms.Button EnterBtn;
        private System.Windows.Forms.Button CloseCreateGrpBxBtn;
    }
}