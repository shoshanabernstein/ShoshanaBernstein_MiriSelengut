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
            this.CreateGrpBx.Location = new System.Drawing.Point(162, 94);
            this.CreateGrpBx.Name = "CreateGrpBx";
            this.CreateGrpBx.Size = new System.Drawing.Size(428, 222);
            this.CreateGrpBx.TabIndex = 12;
            this.CreateGrpBx.TabStop = false;
            this.CreateGrpBx.Text = "Add a new customer";
            // 
            // CustomerIDLbl
            // 
            this.CustomerIDLbl.AutoSize = true;
            this.CustomerIDLbl.Location = new System.Drawing.Point(255, 34);
            this.CustomerIDLbl.Name = "CustomerIDLbl";
            this.CustomerIDLbl.Size = new System.Drawing.Size(83, 16);
            this.CustomerIDLbl.TabIndex = 3;
            this.CustomerIDLbl.Text = "Customer ID:";
            // 
            // CustomerIDTxtBx
            // 
            this.CustomerIDTxtBx.Location = new System.Drawing.Point(336, 30);
            this.CustomerIDTxtBx.Name = "CustomerIDTxtBx";
            this.CustomerIDTxtBx.Size = new System.Drawing.Size(79, 22);
            this.CustomerIDTxtBx.TabIndex = 2;
            // 
            // CustomerNameLbl
            // 
            this.CustomerNameLbl.AutoSize = true;
            this.CustomerNameLbl.Location = new System.Drawing.Point(8, 34);
            this.CustomerNameLbl.Name = "CustomerNameLbl";
            this.CustomerNameLbl.Size = new System.Drawing.Size(107, 16);
            this.CustomerNameLbl.TabIndex = 1;
            this.CustomerNameLbl.Text = "Customer Name:";
            // 
            // CustomerNameTxtBx
            // 
            this.CustomerNameTxtBx.Location = new System.Drawing.Point(121, 30);
            this.CustomerNameTxtBx.Name = "CustomerNameTxtBx";
            this.CustomerNameTxtBx.Size = new System.Drawing.Size(126, 22);
            this.CustomerNameTxtBx.TabIndex = 0;
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
            this.CreditCardGrpBx.Location = new System.Drawing.Point(9, 71);
            this.CreditCardGrpBx.Name = "CreditCardGrpBx";
            this.CreditCardGrpBx.Size = new System.Drawing.Size(413, 135);
            this.CreditCardGrpBx.TabIndex = 13;
            this.CreditCardGrpBx.TabStop = false;
            this.CreditCardGrpBx.Text = "Credit Card";
            // 
            // CardNumberLbl
            // 
            this.CardNumberLbl.AutoSize = true;
            this.CardNumberLbl.Location = new System.Drawing.Point(-2, 22);
            this.CardNumberLbl.Name = "CardNumberLbl";
            this.CardNumberLbl.Size = new System.Drawing.Size(87, 16);
            this.CardNumberLbl.TabIndex = 21;
            this.CardNumberLbl.Text = "Card Number";
            // 
            // CvvLbl
            // 
            this.CvvLbl.AutoSize = true;
            this.CvvLbl.Location = new System.Drawing.Point(295, 88);
            this.CvvLbl.Name = "CvvLbl";
            this.CvvLbl.Size = new System.Drawing.Size(37, 16);
            this.CvvLbl.TabIndex = 20;
            this.CvvLbl.Text = "CVV:";
            // 
            // CVVTxtBx
            // 
            this.CVVTxtBx.Location = new System.Drawing.Point(338, 82);
            this.CVVTxtBx.Name = "CVVTxtBx";
            this.CVVTxtBx.Size = new System.Drawing.Size(63, 22);
            this.CVVTxtBx.TabIndex = 19;
            // 
            // ExpYearTxtBx
            // 
            this.ExpYearTxtBx.Location = new System.Drawing.Point(365, 44);
            this.ExpYearTxtBx.Name = "ExpYearTxtBx";
            this.ExpYearTxtBx.Size = new System.Drawing.Size(34, 22);
            this.ExpYearTxtBx.TabIndex = 18;
            // 
            // CardHolderNameLbl
            // 
            this.CardHolderNameLbl.AutoSize = true;
            this.CardHolderNameLbl.Location = new System.Drawing.Point(-2, 69);
            this.CardHolderNameLbl.Name = "CardHolderNameLbl";
            this.CardHolderNameLbl.Size = new System.Drawing.Size(123, 16);
            this.CardHolderNameLbl.TabIndex = 17;
            this.CardHolderNameLbl.Text = "Card Holder Name:";
            // 
            // CardHolderNameTxtBx
            // 
            this.CardHolderNameTxtBx.Location = new System.Drawing.Point(-6, 88);
            this.CardHolderNameTxtBx.Name = "CardHolderNameTxtBx";
            this.CardHolderNameTxtBx.Size = new System.Drawing.Size(291, 22);
            this.CardHolderNameTxtBx.TabIndex = 16;
            // 
            // ExpLbl
            // 
            this.ExpLbl.AutoSize = true;
            this.ExpLbl.Location = new System.Drawing.Point(295, 47);
            this.ExpLbl.Name = "ExpLbl";
            this.ExpLbl.Size = new System.Drawing.Size(33, 16);
            this.ExpLbl.TabIndex = 15;
            this.ExpLbl.Text = "Exp:";
            // 
            // ExpMonthTxtBx
            // 
            this.ExpMonthTxtBx.Location = new System.Drawing.Point(327, 44);
            this.ExpMonthTxtBx.Name = "ExpMonthTxtBx";
            this.ExpMonthTxtBx.Size = new System.Drawing.Size(34, 22);
            this.ExpMonthTxtBx.TabIndex = 14;
            // 
            // CardNumberTxtBx
            // 
            this.CardNumberTxtBx.Location = new System.Drawing.Point(-1, 41);
            this.CardNumberTxtBx.Name = "CardNumberTxtBx";
            this.CardNumberTxtBx.Size = new System.Drawing.Size(286, 22);
            this.CardNumberTxtBx.TabIndex = 13;
            // 
            // CustomerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CreateGrpBx);
            this.Name = "CustomerForm";
            this.Text = "CustomerForm";
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