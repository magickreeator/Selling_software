namespace Продажа_программного_обеспечения
{
    partial class updateCategoryForm
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
            this.goBackButton = new System.Windows.Forms.Button();
            this.OKButton = new System.Windows.Forms.Button();
            this.nameLabel = new System.Windows.Forms.Label();
            this.idcLabel = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.idcTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // goBackButton
            // 
            this.goBackButton.Location = new System.Drawing.Point(194, 76);
            this.goBackButton.Name = "goBackButton";
            this.goBackButton.Size = new System.Drawing.Size(75, 23);
            this.goBackButton.TabIndex = 11;
            this.goBackButton.Text = "Назад";
            this.goBackButton.UseVisualStyleBackColor = true;
            this.goBackButton.Click += new System.EventHandler(this.goBackButton_Click);
            // 
            // OKButton
            // 
            this.OKButton.Location = new System.Drawing.Point(12, 76);
            this.OKButton.Name = "OKButton";
            this.OKButton.Size = new System.Drawing.Size(75, 23);
            this.OKButton.TabIndex = 10;
            this.OKButton.Text = "OK";
            this.OKButton.UseVisualStyleBackColor = true;
            this.OKButton.Click += new System.EventHandler(this.OKButton_Click);
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(9, 41);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(112, 13);
            this.nameLabel.TabIndex = 9;
            this.nameLabel.Text = "Название категории";
            // 
            // idcLabel
            // 
            this.idcLabel.AutoSize = true;
            this.idcLabel.Location = new System.Drawing.Point(9, 15);
            this.idcLabel.Name = "idcLabel";
            this.idcLabel.Size = new System.Drawing.Size(81, 13);
            this.idcLabel.TabIndex = 8;
            this.idcLabel.Text = "Код категории";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(126, 38);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(143, 20);
            this.nameTextBox.TabIndex = 7;
            // 
            // idcTextBox
            // 
            this.idcTextBox.Location = new System.Drawing.Point(126, 12);
            this.idcTextBox.Name = "idcTextBox";
            this.idcTextBox.Size = new System.Drawing.Size(143, 20);
            this.idcTextBox.TabIndex = 6;
            // 
            // updateCategoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(277, 109);
            this.Controls.Add(this.goBackButton);
            this.Controls.Add(this.OKButton);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.idcLabel);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.idcTextBox);
            this.Name = "updateCategoryForm";
            this.Text = "Редактирование даных о категории";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button goBackButton;
        private System.Windows.Forms.Button OKButton;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label idcLabel;
        public System.Windows.Forms.TextBox nameTextBox;
        public System.Windows.Forms.TextBox idcTextBox;
    }
}