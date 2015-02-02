namespace Продажа_программного_обеспечения
{
    partial class insertDeveloperForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(insertDeveloperForm));
            this.iddTextBox = new System.Windows.Forms.TextBox();
            this.websiteTextBox = new System.Windows.Forms.TextBox();
            this.physical_addressTextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.iddLabel = new System.Windows.Forms.Label();
            this.websiteLabel = new System.Windows.Forms.Label();
            this.physical_addressLabel = new System.Windows.Forms.Label();
            this.emailLabel = new System.Windows.Forms.Label();
            this.OKButton = new System.Windows.Forms.Button();
            this.goBackButton = new System.Windows.Forms.Button();
            this.nameLabel = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // iddTextBox
            // 
            this.iddTextBox.Location = new System.Drawing.Point(129, 12);
            this.iddTextBox.Name = "iddTextBox";
            this.iddTextBox.Size = new System.Drawing.Size(150, 20);
            this.iddTextBox.TabIndex = 0;
            // 
            // websiteTextBox
            // 
            this.websiteTextBox.Location = new System.Drawing.Point(129, 116);
            this.websiteTextBox.Name = "websiteTextBox";
            this.websiteTextBox.Size = new System.Drawing.Size(150, 20);
            this.websiteTextBox.TabIndex = 1;
            // 
            // physical_addressTextBox
            // 
            this.physical_addressTextBox.Location = new System.Drawing.Point(129, 64);
            this.physical_addressTextBox.Name = "physical_addressTextBox";
            this.physical_addressTextBox.Size = new System.Drawing.Size(150, 20);
            this.physical_addressTextBox.TabIndex = 2;
            // 
            // emailTextBox
            // 
            this.emailTextBox.Location = new System.Drawing.Point(129, 90);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(150, 20);
            this.emailTextBox.TabIndex = 3;
            // 
            // iddLabel
            // 
            this.iddLabel.AutoSize = true;
            this.iddLabel.Location = new System.Drawing.Point(3, 15);
            this.iddLabel.Name = "iddLabel";
            this.iddLabel.Size = new System.Drawing.Size(99, 13);
            this.iddLabel.TabIndex = 4;
            this.iddLabel.Text = "Код разработчика";
            // 
            // websiteLabel
            // 
            this.websiteLabel.AutoSize = true;
            this.websiteLabel.Location = new System.Drawing.Point(3, 119);
            this.websiteLabel.Name = "websiteLabel";
            this.websiteLabel.Size = new System.Drawing.Size(52, 13);
            this.websiteLabel.TabIndex = 5;
            this.websiteLabel.Text = "Веб-сайт";
            // 
            // physical_addressLabel
            // 
            this.physical_addressLabel.AutoSize = true;
            this.physical_addressLabel.Location = new System.Drawing.Point(3, 67);
            this.physical_addressLabel.Name = "physical_addressLabel";
            this.physical_addressLabel.Size = new System.Drawing.Size(104, 13);
            this.physical_addressLabel.TabIndex = 6;
            this.physical_addressLabel.Text = "Физический адрес";
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Location = new System.Drawing.Point(3, 93);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(89, 13);
            this.emailLabel.TabIndex = 7;
            this.emailLabel.Text = "Адрес эл. почты";
            // 
            // OKButton
            // 
            this.OKButton.Location = new System.Drawing.Point(15, 158);
            this.OKButton.Name = "OKButton";
            this.OKButton.Size = new System.Drawing.Size(75, 23);
            this.OKButton.TabIndex = 8;
            this.OKButton.Text = "OK";
            this.OKButton.UseVisualStyleBackColor = true;
            this.OKButton.Click += new System.EventHandler(this.OKButton_Click);
            // 
            // goBackButton
            // 
            this.goBackButton.Location = new System.Drawing.Point(197, 158);
            this.goBackButton.Name = "goBackButton";
            this.goBackButton.Size = new System.Drawing.Size(75, 23);
            this.goBackButton.TabIndex = 9;
            this.goBackButton.Text = "Назад";
            this.goBackButton.UseVisualStyleBackColor = true;
            this.goBackButton.Click += new System.EventHandler(this.goBackButton_Click);
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(3, 41);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(125, 13);
            this.nameLabel.TabIndex = 10;
            this.nameLabel.Text = "Название организации";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(129, 38);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(150, 20);
            this.nameTextBox.TabIndex = 11;
            // 
            // insertDeveloperForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 193);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.goBackButton);
            this.Controls.Add(this.OKButton);
            this.Controls.Add(this.emailLabel);
            this.Controls.Add(this.physical_addressLabel);
            this.Controls.Add(this.websiteLabel);
            this.Controls.Add(this.iddLabel);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(this.physical_addressTextBox);
            this.Controls.Add(this.websiteTextBox);
            this.Controls.Add(this.iddTextBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "insertDeveloperForm";
            this.Text = "Добавление данных о разработчиках";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.insertDeveloperForm_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox iddTextBox;
        private System.Windows.Forms.TextBox websiteTextBox;
        private System.Windows.Forms.TextBox physical_addressTextBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.Label iddLabel;
        private System.Windows.Forms.Label websiteLabel;
        private System.Windows.Forms.Label physical_addressLabel;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.Button OKButton;
        private System.Windows.Forms.Button goBackButton;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.TextBox nameTextBox;
    }
}