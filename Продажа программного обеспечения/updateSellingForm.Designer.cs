namespace Продажа_программного_обеспечения
{
    partial class updateSellingForm
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
            this.idsLabel = new System.Windows.Forms.Label();
            this.appIDLabel = new System.Windows.Forms.Label();
            this.amountLabel = new System.Windows.Forms.Label();
            this.sellingDateLabel = new System.Windows.Forms.Label();
            this.idssLabel = new System.Windows.Forms.Label();
            this.idsTextBox = new System.Windows.Forms.TextBox();
            this.appIDTextBox = new System.Windows.Forms.TextBox();
            this.amountTextBox = new System.Windows.Forms.TextBox();
            this.sellingDateTextBox = new System.Windows.Forms.TextBox();
            this.idssTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // goBackButton
            // 
            this.goBackButton.Location = new System.Drawing.Point(194, 155);
            this.goBackButton.Name = "goBackButton";
            this.goBackButton.Size = new System.Drawing.Size(75, 23);
            this.goBackButton.TabIndex = 23;
            this.goBackButton.Text = "Назад";
            this.goBackButton.UseVisualStyleBackColor = true;
            this.goBackButton.Click += new System.EventHandler(this.goBackButton_Click);
            // 
            // OKButton
            // 
            this.OKButton.Location = new System.Drawing.Point(12, 155);
            this.OKButton.Name = "OKButton";
            this.OKButton.Size = new System.Drawing.Size(75, 23);
            this.OKButton.TabIndex = 22;
            this.OKButton.Text = "OK";
            this.OKButton.UseVisualStyleBackColor = true;
            this.OKButton.Click += new System.EventHandler(this.OKButton_Click);
            // 
            // idsLabel
            // 
            this.idsLabel.AutoSize = true;
            this.idsLabel.Location = new System.Drawing.Point(9, 119);
            this.idsLabel.Name = "idsLabel";
            this.idsLabel.Size = new System.Drawing.Size(77, 13);
            this.idsLabel.TabIndex = 21;
            this.idsLabel.Text = "Код продавца";
            // 
            // appIDLabel
            // 
            this.appIDLabel.AutoSize = true;
            this.appIDLabel.Location = new System.Drawing.Point(9, 93);
            this.appIDLabel.Name = "appIDLabel";
            this.appIDLabel.Size = new System.Drawing.Size(88, 13);
            this.appIDLabel.TabIndex = 20;
            this.appIDLabel.Text = "Код программы";
            // 
            // amountLabel
            // 
            this.amountLabel.AutoSize = true;
            this.amountLabel.Location = new System.Drawing.Point(9, 67);
            this.amountLabel.Name = "amountLabel";
            this.amountLabel.Size = new System.Drawing.Size(66, 13);
            this.amountLabel.TabIndex = 19;
            this.amountLabel.Text = "Количество";
            // 
            // sellingDateLabel
            // 
            this.sellingDateLabel.AutoSize = true;
            this.sellingDateLabel.Location = new System.Drawing.Point(9, 41);
            this.sellingDateLabel.Name = "sellingDateLabel";
            this.sellingDateLabel.Size = new System.Drawing.Size(80, 13);
            this.sellingDateLabel.TabIndex = 18;
            this.sellingDateLabel.Text = "Дата продажи";
            // 
            // idssLabel
            // 
            this.idssLabel.AutoSize = true;
            this.idssLabel.Location = new System.Drawing.Point(9, 15);
            this.idssLabel.Name = "idssLabel";
            this.idssLabel.Size = new System.Drawing.Size(73, 13);
            this.idssLabel.TabIndex = 17;
            this.idssLabel.Text = "Код продажи";
            // 
            // idsTextBox
            // 
            this.idsTextBox.Location = new System.Drawing.Point(103, 116);
            this.idsTextBox.Name = "idsTextBox";
            this.idsTextBox.Size = new System.Drawing.Size(166, 20);
            this.idsTextBox.TabIndex = 16;
            // 
            // appIDTextBox
            // 
            this.appIDTextBox.Location = new System.Drawing.Point(103, 90);
            this.appIDTextBox.Name = "appIDTextBox";
            this.appIDTextBox.Size = new System.Drawing.Size(166, 20);
            this.appIDTextBox.TabIndex = 15;
            // 
            // amountTextBox
            // 
            this.amountTextBox.Location = new System.Drawing.Point(103, 64);
            this.amountTextBox.Name = "amountTextBox";
            this.amountTextBox.Size = new System.Drawing.Size(166, 20);
            this.amountTextBox.TabIndex = 14;
            // 
            // sellingDateTextBox
            // 
            this.sellingDateTextBox.Location = new System.Drawing.Point(103, 38);
            this.sellingDateTextBox.Name = "sellingDateTextBox";
            this.sellingDateTextBox.Size = new System.Drawing.Size(166, 20);
            this.sellingDateTextBox.TabIndex = 13;
            // 
            // idssTextBox
            // 
            this.idssTextBox.Location = new System.Drawing.Point(103, 12);
            this.idssTextBox.Name = "idssTextBox";
            this.idssTextBox.Size = new System.Drawing.Size(166, 20);
            this.idssTextBox.TabIndex = 12;
            // 
            // updateSellingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(279, 187);
            this.Controls.Add(this.goBackButton);
            this.Controls.Add(this.OKButton);
            this.Controls.Add(this.idsLabel);
            this.Controls.Add(this.appIDLabel);
            this.Controls.Add(this.amountLabel);
            this.Controls.Add(this.sellingDateLabel);
            this.Controls.Add(this.idssLabel);
            this.Controls.Add(this.idsTextBox);
            this.Controls.Add(this.appIDTextBox);
            this.Controls.Add(this.amountTextBox);
            this.Controls.Add(this.sellingDateTextBox);
            this.Controls.Add(this.idssTextBox);
            this.Name = "updateSellingForm";
            this.Text = "Редактирование даных о продаже";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button goBackButton;
        private System.Windows.Forms.Button OKButton;
        private System.Windows.Forms.Label idsLabel;
        private System.Windows.Forms.Label appIDLabel;
        private System.Windows.Forms.Label amountLabel;
        private System.Windows.Forms.Label sellingDateLabel;
        private System.Windows.Forms.Label idssLabel;
        public System.Windows.Forms.TextBox idsTextBox;
        public System.Windows.Forms.TextBox appIDTextBox;
        public System.Windows.Forms.TextBox amountTextBox;
        public System.Windows.Forms.TextBox sellingDateTextBox;
        public System.Windows.Forms.TextBox idssTextBox;
    }
}