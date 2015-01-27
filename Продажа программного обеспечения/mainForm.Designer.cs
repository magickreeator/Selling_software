namespace Продажа_программного_обеспечения
{
    partial class mainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainForm));
            this.developerButton = new System.Windows.Forms.Button();
            this.categoryButton = new System.Windows.Forms.Button();
            this.appButton = new System.Windows.Forms.Button();
            this.sellerButton = new System.Windows.Forms.Button();
            this.sellingButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // developerButton
            // 
            this.developerButton.Location = new System.Drawing.Point(164, 39);
            this.developerButton.Name = "developerButton";
            this.developerButton.Size = new System.Drawing.Size(129, 42);
            this.developerButton.TabIndex = 0;
            this.developerButton.Text = "Разработчики";
            this.developerButton.UseVisualStyleBackColor = true;
            this.developerButton.Click += new System.EventHandler(this.developerButton_Click);
            // 
            // categoryButton
            // 
            this.categoryButton.Location = new System.Drawing.Point(164, 86);
            this.categoryButton.Name = "categoryButton";
            this.categoryButton.Size = new System.Drawing.Size(129, 42);
            this.categoryButton.TabIndex = 1;
            this.categoryButton.Text = "Категории";
            this.categoryButton.UseVisualStyleBackColor = true;
            this.categoryButton.Click += new System.EventHandler(this.categoryButton_Click);
            // 
            // appButton
            // 
            this.appButton.Location = new System.Drawing.Point(164, 133);
            this.appButton.Name = "appButton";
            this.appButton.Size = new System.Drawing.Size(129, 42);
            this.appButton.TabIndex = 2;
            this.appButton.Text = "Программы";
            this.appButton.UseVisualStyleBackColor = true;
            this.appButton.Click += new System.EventHandler(this.appButton_Click);
            // 
            // sellerButton
            // 
            this.sellerButton.Location = new System.Drawing.Point(164, 180);
            this.sellerButton.Name = "sellerButton";
            this.sellerButton.Size = new System.Drawing.Size(129, 42);
            this.sellerButton.TabIndex = 3;
            this.sellerButton.Text = "Продавцы";
            this.sellerButton.UseVisualStyleBackColor = true;
            this.sellerButton.Click += new System.EventHandler(this.sellerButton_Click);
            // 
            // sellingButton
            // 
            this.sellingButton.Location = new System.Drawing.Point(164, 227);
            this.sellingButton.Name = "sellingButton";
            this.sellingButton.Size = new System.Drawing.Size(129, 42);
            this.sellingButton.TabIndex = 4;
            this.sellingButton.Text = "Продажы";
            this.sellingButton.UseVisualStyleBackColor = true;
            this.sellingButton.Click += new System.EventHandler(this.sellingButton_Click);
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Продажа_программного_обеспечения.Properties.Resources.footer_lodyas;
            this.ClientSize = new System.Drawing.Size(461, 333);
            this.Controls.Add(this.sellingButton);
            this.Controls.Add(this.sellerButton);
            this.Controls.Add(this.appButton);
            this.Controls.Add(this.categoryButton);
            this.Controls.Add(this.developerButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "mainForm";
            this.Text = "Выберите таблицу";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button developerButton;
        private System.Windows.Forms.Button categoryButton;
        private System.Windows.Forms.Button appButton;
        private System.Windows.Forms.Button sellerButton;
        private System.Windows.Forms.Button sellingButton;
    }
}

