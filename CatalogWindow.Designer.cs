
namespace ZOO
{
    partial class CatalogWindow
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
            this.CatalogLabel = new System.Windows.Forms.Label();
            this.CatalogPanel = new System.Windows.Forms.Panel();
            this.CloseButton = new System.Windows.Forms.Label();
            this.OrdersButtomCat = new System.Windows.Forms.Button();
            this.AccountButtonCat = new System.Windows.Forms.Button();
            this.BasketButtonCat = new System.Windows.Forms.Button();
            this.SearchButton = new System.Windows.Forms.Button();
            this.SearchBoxKat = new System.Windows.Forms.TextBox();
            this.ProductsPanel = new System.Windows.Forms.Panel();
            this.CatalogPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // CatalogLabel
            // 
            this.CatalogLabel.BackColor = System.Drawing.Color.PaleTurquoise;
            this.CatalogLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.CatalogLabel.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CatalogLabel.Location = new System.Drawing.Point(0, 0);
            this.CatalogLabel.Name = "CatalogLabel";
            this.CatalogLabel.Size = new System.Drawing.Size(978, 45);
            this.CatalogLabel.TabIndex = 0;
            this.CatalogLabel.Text = "Yasheritsa";
            this.CatalogLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CatalogPanel
            // 
            this.CatalogPanel.Controls.Add(this.ProductsPanel);
            this.CatalogPanel.Controls.Add(this.CloseButton);
            this.CatalogPanel.Controls.Add(this.OrdersButtomCat);
            this.CatalogPanel.Controls.Add(this.AccountButtonCat);
            this.CatalogPanel.Controls.Add(this.BasketButtonCat);
            this.CatalogPanel.Controls.Add(this.SearchButton);
            this.CatalogPanel.Controls.Add(this.SearchBoxKat);
            this.CatalogPanel.Controls.Add(this.CatalogLabel);
            this.CatalogPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CatalogPanel.Location = new System.Drawing.Point(0, 0);
            this.CatalogPanel.Name = "CatalogPanel";
            this.CatalogPanel.Size = new System.Drawing.Size(978, 644);
            this.CatalogPanel.TabIndex = 1;
            // 
            // CloseButton
            // 
            this.CloseButton.AutoSize = true;
            this.CloseButton.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold);
            this.CloseButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.CloseButton.Location = new System.Drawing.Point(940, 9);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(26, 29);
            this.CloseButton.TabIndex = 10;
            this.CloseButton.Text = "X";
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // OrdersButtomCat
            // 
            this.OrdersButtomCat.BackColor = System.Drawing.Color.MediumTurquoise;
            this.OrdersButtomCat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.OrdersButtomCat.FlatAppearance.BorderSize = 0;
            this.OrdersButtomCat.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightCyan;
            this.OrdersButtomCat.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightCyan;
            this.OrdersButtomCat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OrdersButtomCat.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.OrdersButtomCat.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.OrdersButtomCat.Location = new System.Drawing.Point(356, 580);
            this.OrdersButtomCat.Name = "OrdersButtomCat";
            this.OrdersButtomCat.Size = new System.Drawing.Size(272, 50);
            this.OrdersButtomCat.TabIndex = 9;
            this.OrdersButtomCat.Text = "Заказы";
            this.OrdersButtomCat.UseVisualStyleBackColor = false;
            this.OrdersButtomCat.Click += new System.EventHandler(this.OrdersButtomCat_Click);
            // 
            // AccountButtonCat
            // 
            this.AccountButtonCat.BackColor = System.Drawing.Color.MediumTurquoise;
            this.AccountButtonCat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AccountButtonCat.FlatAppearance.BorderSize = 0;
            this.AccountButtonCat.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightCyan;
            this.AccountButtonCat.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightCyan;
            this.AccountButtonCat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AccountButtonCat.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.AccountButtonCat.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.AccountButtonCat.Location = new System.Drawing.Point(688, 580);
            this.AccountButtonCat.Name = "AccountButtonCat";
            this.AccountButtonCat.Size = new System.Drawing.Size(272, 50);
            this.AccountButtonCat.TabIndex = 8;
            this.AccountButtonCat.Text = "Личный кабинет";
            this.AccountButtonCat.UseVisualStyleBackColor = false;
            this.AccountButtonCat.Click += new System.EventHandler(this.AccountButtonCat_Click);
            // 
            // BasketButtonCat
            // 
            this.BasketButtonCat.BackColor = System.Drawing.Color.MediumTurquoise;
            this.BasketButtonCat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BasketButtonCat.FlatAppearance.BorderSize = 0;
            this.BasketButtonCat.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightCyan;
            this.BasketButtonCat.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightCyan;
            this.BasketButtonCat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BasketButtonCat.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.BasketButtonCat.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.BasketButtonCat.Location = new System.Drawing.Point(12, 580);
            this.BasketButtonCat.Name = "BasketButtonCat";
            this.BasketButtonCat.Size = new System.Drawing.Size(272, 50);
            this.BasketButtonCat.TabIndex = 7;
            this.BasketButtonCat.Text = "Корзина";
            this.BasketButtonCat.UseVisualStyleBackColor = false;
            this.BasketButtonCat.Click += new System.EventHandler(this.BasketButtonCat_Click);
            // 
            // SearchButton
            // 
            this.SearchButton.BackColor = System.Drawing.Color.MediumTurquoise;
            this.SearchButton.FlatAppearance.BorderSize = 0;
            this.SearchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SearchButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SearchButton.Location = new System.Drawing.Point(833, 48);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(127, 37);
            this.SearchButton.TabIndex = 2;
            this.SearchButton.Text = "Найти";
            this.SearchButton.UseVisualStyleBackColor = false;
            // 
            // SearchBoxKat
            // 
            this.SearchBoxKat.BackColor = System.Drawing.Color.LightCyan;
            this.SearchBoxKat.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SearchBoxKat.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SearchBoxKat.Location = new System.Drawing.Point(12, 46);
            this.SearchBoxKat.Name = "SearchBoxKat";
            this.SearchBoxKat.Size = new System.Drawing.Size(815, 37);
            this.SearchBoxKat.TabIndex = 1;
            // 
            // ProductsPanel
            // 
            this.ProductsPanel.AutoScroll = true;
            this.ProductsPanel.BackColor = System.Drawing.Color.LightCyan;
            this.ProductsPanel.Location = new System.Drawing.Point(0, 89);
            this.ProductsPanel.Name = "ProductsPanel";
            this.ProductsPanel.Size = new System.Drawing.Size(978, 482);
            this.ProductsPanel.TabIndex = 11;
            // 
            // CatalogWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(978, 644);
            this.Controls.Add(this.CatalogPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CatalogWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Yascheritsa";
            this.Load += new System.EventHandler(this.CatalogWindow_Load);
            this.CatalogPanel.ResumeLayout(false);
            this.CatalogPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label CatalogLabel;
        private System.Windows.Forms.Panel CatalogPanel;
        private System.Windows.Forms.TextBox SearchBoxKat;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.Button OrdersButtomCat;
        private System.Windows.Forms.Button AccountButtonCat;
        private System.Windows.Forms.Button BasketButtonCat;
        private System.Windows.Forms.Label CloseButton;
        private System.Windows.Forms.Panel ProductsPanel;
    }
}