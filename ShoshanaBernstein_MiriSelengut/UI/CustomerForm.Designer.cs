namespace UI
{
    partial class CustomerForm
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
            this.CustomerIDLbl = new System.Windows.Forms.Label();
            this.CustomerIDTxtBx = new System.Windows.Forms.TextBox();
            this.CustomerNameLbl = new System.Windows.Forms.Label();
            this.CustomerNameTxtBx = new System.Windows.Forms.TextBox();
            this.CreditCardGrpBx = new System.Windows.Forms.GroupBox();
            this.CardNumberLbl = new System.Windows.Forms.Label();
            this.CvvLbl = new System.Windows.Forms.Label();
            this.CVVTxtBx = new System.Windows.Forms.TextBox();
            this.ExpYearTxtBx = new System.Windows.Forms.TextBox();
            this.CardHolderNameLbl = new System.Windows.Forms.Label();
            this.CardHolderNameTxtBx = new System.Windows.Forms.TextBox();
            this.ExpLbl = new System.Windows.Forms.Label();
            this.ExpMonthTxtBx = new System.Windows.Forms.TextBox();
            this.CardNumberTxtBx = new System.Windows.Forms.TextBox();
            this.CreateGrpBx.SuspendLayout();
            this.CreditCardGrpBx.SuspendLayout();
            this.SuspendLayout();
            // 
            // CreateGrpBx
            // 
            this.CreateGrpBx.Controls.Add(this.CustomerIDLbl);
            this.CreateGrpBx.Controls.Add(this.CustomerIDTxtBx);
            this.CreateGrpBx.Controls.Add(this.CustomerNameLbl);
            this.CreateGrpBx.Controls.Add(this.CustomerNameTxtBx);
            this.CreateGrpBx.Controls.Add(this.CreditCardGrpBx);
            this.CreateGrpBx.ForeColor = System.Drawing.Color.SaddleBrown;
            this.CreateGrpBx.Location = new System.Drawing.Point(165, 68);
            this.CreateGrpBx.Name = "CreateGrpBx";
            this.CreateGrpBx.Size = new System.Drawing.Size(428, 262);
            this.CreateGrpBx.TabIndex = 12;
            this.CreateGrpBx.TabStop = false;
            this.CreateGrpBx.Text = "Add a new customer";
            // 
            // CustomerIDLbl
            // 
            this.CustomerIDLbl.AutoSize = true;
            this.CustomerIDLbl.ForeColor = System.Drawing.Color.SaddleBrown;
            this.CustomerIDLbl.Location = new System.Drawing.Point(252, 48);
            this.CustomerIDLbl.Name = "CustomerIDLbl";
            this.CustomerIDLbl.Size = new System.Drawing.Size(84, 15);
            this.CustomerIDLbl.TabIndex = 3;
            this.CustomerIDLbl.Text = "Customer ID:";
            // 
            // CustomerIDTxtBx
            // 
            this.CustomerIDTxtBx.BackColor = System.Drawing.Color.Linen;
            this.CustomerIDTxtBx.ForeColor = System.Drawing.Color.SaddleBrown;
            this.CustomerIDTxtBx.Location = new System.Drawing.Point(341, 44);
            this.CustomerIDTxtBx.Name = "CustomerIDTxtBx";
            this.CustomerIDTxtBx.Size = new System.Drawing.Size(79, 22);
            this.CustomerIDTxtBx.TabIndex = 7;
            // 
            // CustomerNameLbl
            // 
            this.CustomerNameLbl.AutoSize = true;
            this.CustomerNameLbl.ForeColor = System.Drawing.Color.SaddleBrown;
            this.CustomerNameLbl.Location = new System.Drawing.Point(7, 48);
            this.CustomerNameLbl.Name = "CustomerNameLbl";
            this.CustomerNameLbl.Size = new System.Drawing.Size(105, 15);
            this.CustomerNameLbl.TabIndex = 1;
            this.CustomerNameLbl.Text = "Customer Name:";
            // 
            // CustomerNameTxtBx
            // 
            this.CustomerNameTxtBx.BackColor = System.Drawing.Color.Linen;
            this.CustomerNameTxtBx.ForeColor = System.Drawing.Color.SaddleBrown;
            this.CustomerNameTxtBx.Location = new System.Drawing.Point(120, 44);
            this.CustomerNameTxtBx.Name = "CustomerNameTxtBx";
            this.CustomerNameTxtBx.Size = new System.Drawing.Size(126, 22);
            this.CustomerNameTxtBx.TabIndex = 6;
            // 
            // CreditCardGrpBx
            // 
            this.CreditCardGrpBx.Controls.Add(this.CardNumberLbl);
            this.CreditCardGrpBx.Controls.Add(this.CvvLbl);
            this.CreditCardGrpBx.Controls.Add(this.CVVTxtBx);
            this.CreditCardGrpBx.Controls.Add(this.ExpYearTxtBx);
            this.CreditCardGrpBx.Controls.Add(this.CardHolderNameLbl);
            this.CreditCardGrpBx.Controls.Add(this.CardHolderNameTxtBx);
            this.CreditCardGrpBx.Controls.Add(this.ExpLbl);
            this.CreditCardGrpBx.Controls.Add(this.ExpMonthTxtBx);
            this.CreditCardGrpBx.Controls.Add(this.CardNumberTxtBx);
            this.CreditCardGrpBx.ForeColor = System.Drawing.Color.SaddleBrown;
            this.CreditCardGrpBx.Location = new System.Drawing.Point(8, 97);
            this.CreditCardGrpBx.Name = "CreditCardGrpBx";
            this.CreditCardGrpBx.Size = new System.Drawing.Size(413, 129);
            this.CreditCardGrpBx.TabIndex = 13;
            this.CreditCardGrpBx.TabStop = false;
            this.CreditCardGrpBx.Text = "Credit Card";
            this.CreditCardGrpBx.Enter += new System.EventHandler(this.CreditCardGrpBx_Enter);
            // 
            // CardNumberLbl
            // 
            this.CardNumberLbl.AutoSize = true;
            this.CardNumberLbl.ForeColor = System.Drawing.Color.SaddleBrown;
            this.CardNumberLbl.Location = new System.Drawing.Point(6, 21);
            this.CardNumberLbl.Name = "CardNumberLbl";
            this.CardNumberLbl.Size = new System.Drawing.Size(86, 15);
            this.CardNumberLbl.TabIndex = 21;
            this.CardNumberLbl.Text = "Card Number";
            // 
            // CvvLbl
            // 
            this.CvvLbl.AutoSize = true;
            this.CvvLbl.ForeColor = System.Drawing.Color.SaddleBrown;
            this.CvvLbl.Location = new System.Drawing.Point(295, 82);
            this.CvvLbl.Name = "CvvLbl";
            this.CvvLbl.Size = new System.Drawing.Size(42, 15);
            this.CvvLbl.TabIndex = 20;
            this.CvvLbl.Text = "CVV:";
            // 
            // CVVTxtBx
            // 
            this.CVVTxtBx.BackColor = System.Drawing.Color.Linen;
            this.CVVTxtBx.ForeColor = System.Drawing.Color.SaddleBrown;
            this.CVVTxtBx.Location = new System.Drawing.Point(338, 77);
            this.CVVTxtBx.Name = "CVVTxtBx";
            this.CVVTxtBx.Size = new System.Drawing.Size(63, 22);
            this.CVVTxtBx.TabIndex = 12;
            // 
            // ExpYearTxtBx
            // 
            this.ExpYearTxtBx.BackColor = System.Drawing.Color.Linen;
            this.ExpYearTxtBx.ForeColor = System.Drawing.Color.SaddleBrown;
            this.ExpYearTxtBx.Location = new System.Drawing.Point(373, 41);
            this.ExpYearTxtBx.Name = "ExpYearTxtBx";
            this.ExpYearTxtBx.Size = new System.Drawing.Size(34, 22);
            this.ExpYearTxtBx.TabIndex = 10;
            // 
            // CardHolderNameLbl
            // 
            this.CardHolderNameLbl.AutoSize = true;
            this.CardHolderNameLbl.ForeColor = System.Drawing.Color.SaddleBrown;
            this.CardHolderNameLbl.Location = new System.Drawing.Point(6, 65);
            this.CardHolderNameLbl.Name = "CardHolderNameLbl";
            this.CardHolderNameLbl.Size = new System.Drawing.Size(121, 15);
            this.CardHolderNameLbl.TabIndex = 17;
            this.CardHolderNameLbl.Text = "Card Holder Name:";
            // 
            // CardHolderNameTxtBx
            // 
            this.CardHolderNameTxtBx.BackColor = System.Drawing.Color.Linen;
            this.CardHolderNameTxtBx.ForeColor = System.Drawing.Color.SaddleBrown;
            this.CardHolderNameTxtBx.Location = new System.Drawing.Point(6, 82);
            this.CardHolderNameTxtBx.Name = "CardHolderNameTxtBx";
            this.CardHolderNameTxtBx.Size = new System.Drawing.Size(286, 22);
            this.CardHolderNameTxtBx.TabIndex = 11;
            // 
            // ExpLbl
            // 
            this.ExpLbl.AutoSize = true;
            this.ExpLbl.ForeColor = System.Drawing.Color.SaddleBrown;
            this.ExpLbl.Location = new System.Drawing.Point(295, 46);
            this.ExpLbl.Name = "ExpLbl";
            this.ExpLbl.Size = new System.Drawing.Size(33, 15);
            this.ExpLbl.TabIndex = 15;
            this.ExpLbl.Text = "Exp:";
            // 
            // ExpMonthTxtBx
            // 
            this.ExpMonthTxtBx.BackColor = System.Drawing.Color.Linen;
            this.ExpMonthTxtBx.ForeColor = System.Drawing.Color.SaddleBrown;
            this.ExpMonthTxtBx.Location = new System.Drawing.Point(333, 41);
            this.ExpMonthTxtBx.Name = "ExpMonthTxtBx";
            this.ExpMonthTxtBx.Size = new System.Drawing.Size(34, 22);
            this.ExpMonthTxtBx.TabIndex = 9;
            // 
            // CardNumberTxtBx
            // 
            this.CardNumberTxtBx.BackColor = System.Drawing.Color.Linen;
            this.CardNumberTxtBx.ForeColor = System.Drawing.Color.SaddleBrown;
            this.CardNumberTxtBx.Location = new System.Drawing.Point(6, 38);
            this.CardNumberTxtBx.Name = "CardNumberTxtBx";
            this.CardNumberTxtBx.Size = new System.Drawing.Size(286, 22);
            this.CardNumberTxtBx.TabIndex = 8;
            this.CardNumberTxtBx.TextChanged += new System.EventHandler(this.CardNumberTxtBx_TextChanged);
            // 
            // CustomerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 422);
            this.Controls.Add(this.CreateGrpBx);
            this.Name = "CustomerForm";
            this.Text = "CustomerForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CustomerForm_FormClosing);
            this.Controls.SetChildIndex(this.CreateGrpBx, 0);
            this.CreateGrpBx.ResumeLayout(false);
            this.CreateGrpBx.PerformLayout();
            this.CreditCardGrpBx.ResumeLayout(false);
            this.CreditCardGrpBx.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox CreateGrpBx;
        private System.Windows.Forms.Label CustomerIDLbl;
        private System.Windows.Forms.TextBox CustomerIDTxtBx;
        private System.Windows.Forms.Label CustomerNameLbl;
        private System.Windows.Forms.TextBox CustomerNameTxtBx;
        private System.Windows.Forms.GroupBox CreditCardGrpBx;
        private System.Windows.Forms.Label CardNumberLbl;
        private System.Windows.Forms.Label CvvLbl;
        private System.Windows.Forms.TextBox CVVTxtBx;
        private System.Windows.Forms.TextBox ExpYearTxtBx;
        private System.Windows.Forms.Label CardHolderNameLbl;
        private System.Windows.Forms.TextBox CardHolderNameTxtBx;
        private System.Windows.Forms.Label ExpLbl;
        private System.Windows.Forms.TextBox ExpMonthTxtBx;
        private System.Windows.Forms.TextBox CardNumberTxtBx;
    }
}