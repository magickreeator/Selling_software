namespace Продажа_программного_обеспечения
{
    partial class insertCategoryForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(insertCategoryForm));
            this.idcTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.idcLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.OKButton = new System.Windows.Forms.Button();
            this.goBackButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // idcTextBox
            // 
            this.idcTextBox.Location = new System.Drawing.Point(129, 12);
            this.idcTextBox.Name = "idcTextBox";
            this.idcTextBox.Size = new System.Drawing.Size(143, 20);
            this.idcTextBox.TabIndex = 0;
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(129, 38);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(143, 20);
            this.nameTextBox.TabIndex = 1;
            // 
            // idcLabel
            // 
            this.idcLabel.AutoSize = true;
            this.idcLabel.Location = new System.Drawing.Point(12, 15);
            this.idcLabel.Name = "idcLabel";
            this.idcLabel.Size = new System.Drawing.Size(81, 13);
            this.idcLabel.TabIndex = 2;
            this.idcLabel.Text = "Код категории";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(12, 41);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(112, 13);
            this.nameLabel.TabIndex = 3;
            this.nameLabel.Text = "Название категории";
            // 
            // OKButton
            // 
            this.OKButton.Location = new System.Drawing.Point(15, 76);
            this.OKButton.Name = "OKButton";
            this.OKButton.Size = new System.Drawing.Size(75, 23);
            this.OKButton.TabIndex = 4;
            this.OKButton.Text = "OK";
            this.OKButton.UseVisualStyleBackColor = true;
            this.OKButton.Click += new System.EventHandler(this.OKButton_Click);
            // 
            // goBackButton
            // 
            this.goBackButton.Location = new System.Drawing.Point(197, 76);
            this.goBackButton.Name = "goBackButton";
            this.goBackButton.Size = new System.Drawing.Size(75, 23);
            this.goBackButton.TabIndex = 5;
            this.goBackButton.Text = "Назад";
            this.goBackButton.UseVisualStyleBackColor = true;
            this.goBackButton.Click += new System.EventHandler(this.goBackButton_Click);
            // 
            // insertCategoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 110);
            this.Controls.Add(this.goBackButton);
            this.Controls.Add(this.OKButton);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.idcLabel);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.idcTextBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "insertCategoryForm";
            this.Text = "Добавление данных о категориях";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.insertCategoryForm_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox idcTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label idcLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Button OKButton;
        private System.Windows.Forms.Button goBackButton;
    }
}