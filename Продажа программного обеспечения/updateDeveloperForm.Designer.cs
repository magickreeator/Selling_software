namespace Продажа_программного_обеспечения
{
    partial class updateDeveloperForm
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
            this.emailLabel = new System.Windows.Forms.Label();
            this.physical_addressLabel = new System.Windows.Forms.Label();
            this.websiteLabel = new System.Windows.Forms.Label();
            this.iddLabel = new System.Windows.Forms.Label();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.physical_addressTextBox = new System.Windows.Forms.TextBox();
            this.websiteTextBox = new System.Windows.Forms.TextBox();
            this.iddTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // goBackButton
            // 
            this.goBackButton.Location = new System.Drawing.Point(195, 125);
            this.goBackButton.Name = "goBackButton";
            this.goBackButton.Size = new System.Drawing.Size(75, 23);
            this.goBackButton.TabIndex = 19;
            this.goBackButton.Text = "Назад";
            this.goBackButton.UseVisualStyleBackColor = true;
            this.goBackButton.Click += new System.EventHandler(this.goBackButton_Click);
            // 
            // OKButton
            // 
            this.OKButton.Location = new System.Drawing.Point(13, 125);
            this.OKButton.Name = "OKButton";
            this.OKButton.Size = new System.Drawing.Size(75, 23);
            this.OKButton.TabIndex = 18;
            this.OKButton.Text = "OK";
            this.OKButton.UseVisualStyleBackColor = true;
            this.OKButton.Click += new System.EventHandler(this.OKButton_Click);
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Location = new System.Drawing.Point(10, 93);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(89, 13);
            this.emailLabel.TabIndex = 17;
            this.emailLabel.Text = "Адрес эл. почты";
            // 
            // physical_addressLabel
            // 
            this.physical_addressLabel.AutoSize = true;
            this.physical_addressLabel.Location = new System.Drawing.Point(10, 67);
            this.physical_addressLabel.Name = "physical_addressLabel";
            this.physical_addressLabel.Size = new System.Drawing.Size(104, 13);
            this.physical_addressLabel.TabIndex = 16;
            this.physical_addressLabel.Text = "Физический адрес";
            // 
            // websiteLabel
            // 
            this.websiteLabel.AutoSize = true;
            this.websiteLabel.Location = new System.Drawing.Point(10, 41);
            this.websiteLabel.Name = "websiteLabel";
            this.websiteLabel.Size = new System.Drawing.Size(52, 13);
            this.websiteLabel.TabIndex = 15;
            this.websiteLabel.Text = "Веб-сайт";
            // 
            // iddLabel
            // 
            this.iddLabel.AutoSize = true;
            this.iddLabel.Location = new System.Drawing.Point(10, 15);
            this.iddLabel.Name = "iddLabel";
            this.iddLabel.Size = new System.Drawing.Size(99, 13);
            this.iddLabel.TabIndex = 14;
            this.iddLabel.Text = "Код разработчика";
            // 
            // emailTextBox
            // 
            this.emailTextBox.Location = new System.Drawing.Point(120, 90);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(150, 20);
            this.emailTextBox.TabIndex = 13;
            // 
            // physical_addressTextBox
            // 
            this.physical_addressTextBox.Location = new System.Drawing.Point(120, 64);
            this.physical_addressTextBox.Name = "physical_addressTextBox";
            this.physical_addressTextBox.Size = new System.Drawing.Size(150, 20);
            this.physical_addressTextBox.TabIndex = 12;
            // 
            // websiteTextBox
            // 
            this.websiteTextBox.Location = new System.Drawing.Point(120, 38);
            this.websiteTextBox.Name = "websiteTextBox";
            this.websiteTextBox.Size = new System.Drawing.Size(150, 20);
            this.websiteTextBox.TabIndex = 11;
            // 
            // iddTextBox
            // 
            this.iddTextBox.Location = new System.Drawing.Point(120, 12);
            this.iddTextBox.Name = "iddTextBox";
            this.iddTextBox.Size = new System.Drawing.Size(150, 20);
            this.iddTextBox.TabIndex = 10;
            // 
            // updateDeveloperForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(278, 157);
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
            this.Name = "updateDeveloperForm";
            this.Text = "Редактирование даных о разработчике";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button goBackButton;
        private System.Windows.Forms.Button OKButton;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.Label physical_addressLabel;
        private System.Windows.Forms.Label websiteLabel;
        private System.Windows.Forms.Label iddLabel;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.TextBox physical_addressTextBox;
        private System.Windows.Forms.TextBox websiteTextBox;
        private System.Windows.Forms.TextBox iddTextBox;
    }
}