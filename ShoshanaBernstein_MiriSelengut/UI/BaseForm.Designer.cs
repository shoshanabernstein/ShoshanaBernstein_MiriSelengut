namespace UI
{
    partial class BaseForm
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
            this.DeleteBtn = new System.Windows.Forms.Button();
            this.UpdateBtn = new System.Windows.Forms.Button();
            this.ReadBtn = new System.Windows.Forms.Button();
            this.ReadAllBtn = new System.Windows.Forms.Button();
            this.CreateBtn = new System.Windows.Forms.Button();
            this.EnterBtn = new System.Windows.Forms.Button();
            this.CloseBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.BackColor = System.Drawing.Color.AntiqueWhite;
            this.DeleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.DeleteBtn.Font = new System.Drawing.Font("Narkisim", 9F);
            this.DeleteBtn.ForeColor = System.Drawing.Color.SaddleBrown;
            this.DeleteBtn.Location = new System.Drawing.Point(26, 294);
            this.DeleteBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(109, 40);
            this.DeleteBtn.TabIndex = 4;
            this.DeleteBtn.Text = "Delete";
            this.DeleteBtn.UseVisualStyleBackColor = false;
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // UpdateBtn
            // 
            this.UpdateBtn.BackColor = System.Drawing.Color.AntiqueWhite;
            this.UpdateBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.UpdateBtn.Font = new System.Drawing.Font("Narkisim", 9F);
            this.UpdateBtn.ForeColor = System.Drawing.Color.SaddleBrown;
            this.UpdateBtn.Location = new System.Drawing.Point(26, 238);
            this.UpdateBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.UpdateBtn.Name = "UpdateBtn";
            this.UpdateBtn.Size = new System.Drawing.Size(109, 40);
            this.UpdateBtn.TabIndex = 5;
            this.UpdateBtn.Text = "Update";
            this.UpdateBtn.UseVisualStyleBackColor = false;
            this.UpdateBtn.Click += new System.EventHandler(this.UpdateBtn_Click);
            // 
            // ReadBtn
            // 
            this.ReadBtn.BackColor = System.Drawing.Color.AntiqueWhite;
            this.ReadBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ReadBtn.Font = new System.Drawing.Font("Narkisim", 9F);
            this.ReadBtn.ForeColor = System.Drawing.Color.SaddleBrown;
            this.ReadBtn.Location = new System.Drawing.Point(26, 181);
            this.ReadBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ReadBtn.Name = "ReadBtn";
            this.ReadBtn.Size = new System.Drawing.Size(109, 40);
            this.ReadBtn.TabIndex = 3;
            this.ReadBtn.Text = "Search";
            this.ReadBtn.UseVisualStyleBackColor = false;
            this.ReadBtn.Click += new System.EventHandler(this.ReadBtn_Click);
            // 
            // ReadAllBtn
            // 
            this.ReadAllBtn.BackColor = System.Drawing.Color.AntiqueWhite;
            this.ReadAllBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ReadAllBtn.Font = new System.Drawing.Font("Narkisim", 9F);
            this.ReadAllBtn.ForeColor = System.Drawing.Color.SaddleBrown;
            this.ReadAllBtn.Location = new System.Drawing.Point(26, 125);
            this.ReadAllBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ReadAllBtn.Name = "ReadAllBtn";
            this.ReadAllBtn.Size = new System.Drawing.Size(109, 40);
            this.ReadAllBtn.TabIndex = 2;
            this.ReadAllBtn.Text = "Show";
            this.ReadAllBtn.UseVisualStyleBackColor = false;
            this.ReadAllBtn.Click += new System.EventHandler(this.ReadAllBtn_Click);
            // 
            // CreateBtn
            // 
            this.CreateBtn.BackColor = System.Drawing.Color.AntiqueWhite;
            this.CreateBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CreateBtn.Font = new System.Drawing.Font("Narkisim", 9F);
            this.CreateBtn.ForeColor = System.Drawing.Color.SaddleBrown;
            this.CreateBtn.Location = new System.Drawing.Point(26, 68);
            this.CreateBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CreateBtn.Name = "CreateBtn";
            this.CreateBtn.Size = new System.Drawing.Size(109, 40);
            this.CreateBtn.TabIndex = 1;
            this.CreateBtn.Text = "Add";
            this.CreateBtn.UseVisualStyleBackColor = false;
            this.CreateBtn.Click += new System.EventHandler(this.CreateBtn_Click);
            // 
            // EnterBtn
            // 
            this.EnterBtn.BackColor = System.Drawing.Color.AntiqueWhite;
            this.EnterBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.EnterBtn.Font = new System.Drawing.Font("Narkisim", 9F);
            this.EnterBtn.ForeColor = System.Drawing.Color.SaddleBrown;
            this.EnterBtn.Location = new System.Drawing.Point(475, 303);
            this.EnterBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.EnterBtn.Name = "EnterBtn";
            this.EnterBtn.Size = new System.Drawing.Size(75, 23);
            this.EnterBtn.TabIndex = 13;
            this.EnterBtn.Text = "Enter";
            this.EnterBtn.UseVisualStyleBackColor = false;
            this.EnterBtn.Click += new System.EventHandler(this.EnterBtn_Click);
            // 
            // CloseBtn
            // 
            this.CloseBtn.BackColor = System.Drawing.Color.AntiqueWhite;
            this.CloseBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CloseBtn.Font = new System.Drawing.Font("Narkisim", 9F);
            this.CloseBtn.ForeColor = System.Drawing.Color.SaddleBrown;
            this.CloseBtn.Location = new System.Drawing.Point(475, 356);
            this.CloseBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CloseBtn.Name = "CloseBtn";
            this.CloseBtn.Size = new System.Drawing.Size(149, 30);
            this.CloseBtn.TabIndex = 14;
            this.CloseBtn.Text = "Back to Main Menu";
            this.CloseBtn.UseVisualStyleBackColor = false;
            this.CloseBtn.Click += new System.EventHandler(this.CloseBtn_Click);
            // 
            // BaseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OldLace;
            this.ClientSize = new System.Drawing.Size(661, 413);
            this.Controls.Add(this.CloseBtn);
            this.Controls.Add(this.DeleteBtn);
            this.Controls.Add(this.UpdateBtn);
            this.Controls.Add(this.ReadBtn);
            this.Controls.Add(this.ReadAllBtn);
            this.Controls.Add(this.CreateBtn);
            this.Controls.Add(this.EnterBtn);
            this.Font = new System.Drawing.Font("Narkisim", 9F);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "BaseForm";
            this.Text = "BaseForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button DeleteBtn;
        private System.Windows.Forms.Button UpdateBtn;
        private System.Windows.Forms.Button ReadBtn;
        private System.Windows.Forms.Button ReadAllBtn;
        private System.Windows.Forms.Button CreateBtn;
        private System.Windows.Forms.Button EnterBtn;
        private System.Windows.Forms.Button CloseBtn;
    }
}