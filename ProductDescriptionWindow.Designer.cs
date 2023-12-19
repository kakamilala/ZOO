
namespace ZOO
{
    partial class ProductDescriptionWindow
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
            this.OrderDescPanel = new System.Windows.Forms.Panel();
            this.CloseButton = new System.Windows.Forms.Label();
            this.DecreaseButton = new System.Windows.Forms.Button();
            this.IncreaseButton = new System.Windows.Forms.Button();
            this.InBasketButton = new System.Windows.Forms.Button();
            this.BackProductButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.DescriptionValueLabel = new System.Windows.Forms.Label();
            this.DescriptionLabel = new System.Windows.Forms.Label();
            this.QuantityValueLabel = new System.Windows.Forms.Label();
            this.QuantityLabel = new System.Windows.Forms.Label();
            this.PriceValueLabel = new System.Windows.Forms.Label();
            this.PriceLabel = new System.Windows.Forms.Label();
            this.ProductCodeLabel = new System.Windows.Forms.Label();
            this.ProductNameLabel = new System.Windows.Forms.Label();
            this.OrderDescPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // OrderDescPanel
            // 
            this.OrderDescPanel.Controls.Add(this.CloseButton);
            this.OrderDescPanel.Controls.Add(this.DecreaseButton);
            this.OrderDescPanel.Controls.Add(this.IncreaseButton);
            this.OrderDescPanel.Controls.Add(this.InBasketButton);
            this.OrderDescPanel.Controls.Add(this.BackProductButton);
            this.OrderDescPanel.Controls.Add(this.pictureBox1);
            this.OrderDescPanel.Controls.Add(this.DescriptionValueLabel);
            this.OrderDescPanel.Controls.Add(this.DescriptionLabel);
            this.OrderDescPanel.Controls.Add(this.QuantityValueLabel);
            this.OrderDescPanel.Controls.Add(this.QuantityLabel);
            this.OrderDescPanel.Controls.Add(this.PriceValueLabel);
            this.OrderDescPanel.Controls.Add(this.PriceLabel);
            this.OrderDescPanel.Controls.Add(this.ProductCodeLabel);
            this.OrderDescPanel.Controls.Add(this.ProductNameLabel);
            this.OrderDescPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OrderDescPanel.Location = new System.Drawing.Point(0, 0);
            this.OrderDescPanel.Name = "OrderDescPanel";
            this.OrderDescPanel.Size = new System.Drawing.Size(978, 644);
            this.OrderDescPanel.TabIndex = 0;
            // 
            // CloseButton
            // 
            this.CloseButton.AutoSize = true;
            this.CloseButton.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold);
            this.CloseButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.CloseButton.Location = new System.Drawing.Point(940, 9);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(26, 29);
            this.CloseButton.TabIndex = 15;
            this.CloseButton.Text = "X";
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // DecreaseButton
            // 
            this.DecreaseButton.BackColor = System.Drawing.Color.MediumTurquoise;
            this.DecreaseButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DecreaseButton.FlatAppearance.BorderSize = 0;
            this.DecreaseButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightCyan;
            this.DecreaseButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightCyan;
            this.DecreaseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DecreaseButton.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.DecreaseButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.DecreaseButton.Location = new System.Drawing.Point(642, 159);
            this.DecreaseButton.Name = "DecreaseButton";
            this.DecreaseButton.Size = new System.Drawing.Size(40, 40);
            this.DecreaseButton.TabIndex = 19;
            this.DecreaseButton.Text = "-";
            this.DecreaseButton.UseVisualStyleBackColor = false;
            this.DecreaseButton.Click += new System.EventHandler(this.DecreaseButton_Click);
            // 
            // IncreaseButton
            // 
            this.IncreaseButton.BackColor = System.Drawing.Color.MediumTurquoise;
            this.IncreaseButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.IncreaseButton.FlatAppearance.BorderSize = 0;
            this.IncreaseButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightCyan;
            this.IncreaseButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightCyan;
            this.IncreaseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.IncreaseButton.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.IncreaseButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.IncreaseButton.Location = new System.Drawing.Point(766, 159);
            this.IncreaseButton.Name = "IncreaseButton";
            this.IncreaseButton.Size = new System.Drawing.Size(40, 40);
            this.IncreaseButton.TabIndex = 18;
            this.IncreaseButton.Text = "+";
            this.IncreaseButton.UseVisualStyleBackColor = false;
            this.IncreaseButton.Click += new System.EventHandler(this.IncreaseButton_Click);
            // 
            // InBasketButton
            // 
            this.InBasketButton.BackColor = System.Drawing.Color.MediumTurquoise;
            this.InBasketButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.InBasketButton.FlatAppearance.BorderSize = 0;
            this.InBasketButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightCyan;
            this.InBasketButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightCyan;
            this.InBasketButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.InBasketButton.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.InBasketButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.InBasketButton.Location = new System.Drawing.Point(766, 582);
            this.InBasketButton.Name = "InBasketButton";
            this.InBasketButton.Size = new System.Drawing.Size(200, 50);
            this.InBasketButton.TabIndex = 17;
            this.InBasketButton.Text = "В корзину";
            this.InBasketButton.UseVisualStyleBackColor = false;
            this.InBasketButton.Click += new System.EventHandler(this.InBasketButton_Click);
            // 
            // BackProductButton
            // 
            this.BackProductButton.BackColor = System.Drawing.Color.MediumTurquoise;
            this.BackProductButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BackProductButton.FlatAppearance.BorderSize = 0;
            this.BackProductButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightCyan;
            this.BackProductButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightCyan;
            this.BackProductButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BackProductButton.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.BackProductButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.BackProductButton.Location = new System.Drawing.Point(22, 582);
            this.BackProductButton.Name = "BackProductButton";
            this.BackProductButton.Size = new System.Drawing.Size(200, 50);
            this.BackProductButton.TabIndex = 16;
            this.BackProductButton.Text = "Назад";
            this.BackProductButton.UseVisualStyleBackColor = false;
            this.BackProductButton.Click += new System.EventHandler(this.BackProductButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Honeydew;
            this.pictureBox1.Location = new System.Drawing.Point(22, 100);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(450, 450);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // DescriptionValueLabel
            // 
            this.DescriptionValueLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DescriptionValueLabel.Location = new System.Drawing.Point(484, 287);
            this.DescriptionValueLabel.Name = "DescriptionValueLabel";
            this.DescriptionValueLabel.Size = new System.Drawing.Size(432, 263);
            this.DescriptionValueLabel.TabIndex = 8;
            this.DescriptionValueLabel.Text = "qqqqqqqqqqqqqqqqqqqqqqq\r\nqqqqqqqqqqqqqqqqqqqqqqq\r\nqqqqqqqqqqqqqqqqqqqqqqq\r\n";
            // 
            // DescriptionLabel
            // 
            this.DescriptionLabel.AutoSize = true;
            this.DescriptionLabel.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DescriptionLabel.Location = new System.Drawing.Point(483, 220);
            this.DescriptionLabel.Name = "DescriptionLabel";
            this.DescriptionLabel.Size = new System.Drawing.Size(212, 45);
            this.DescriptionLabel.TabIndex = 7;
            this.DescriptionLabel.Text = "Описание:";
            // 
            // QuantityValueLabel
            // 
            this.QuantityValueLabel.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.QuantityValueLabel.Location = new System.Drawing.Point(688, 154);
            this.QuantityValueLabel.Name = "QuantityValueLabel";
            this.QuantityValueLabel.Size = new System.Drawing.Size(72, 45);
            this.QuantityValueLabel.TabIndex = 6;
            this.QuantityValueLabel.Text = "1";
            this.QuantityValueLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // QuantityLabel
            // 
            this.QuantityLabel.AutoSize = true;
            this.QuantityLabel.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.QuantityLabel.Location = new System.Drawing.Point(482, 154);
            this.QuantityLabel.Name = "QuantityLabel";
            this.QuantityLabel.Size = new System.Drawing.Size(154, 45);
            this.QuantityLabel.TabIndex = 5;
            this.QuantityLabel.Text = "Кол-во:";
            // 
            // PriceValueLabel
            // 
            this.PriceValueLabel.AutoSize = true;
            this.PriceValueLabel.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PriceValueLabel.Location = new System.Drawing.Point(613, 100);
            this.PriceValueLabel.Name = "PriceValueLabel";
            this.PriceValueLabel.Size = new System.Drawing.Size(40, 45);
            this.PriceValueLabel.TabIndex = 3;
            this.PriceValueLabel.Text = "0";
            this.PriceValueLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // PriceLabel
            // 
            this.PriceLabel.AutoSize = true;
            this.PriceLabel.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PriceLabel.Location = new System.Drawing.Point(482, 100);
            this.PriceLabel.Name = "PriceLabel";
            this.PriceLabel.Size = new System.Drawing.Size(125, 45);
            this.PriceLabel.TabIndex = 2;
            this.PriceLabel.Text = "Цена:";
            // 
            // ProductCodeLabel
            // 
            this.ProductCodeLabel.AutoSize = true;
            this.ProductCodeLabel.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ProductCodeLabel.ForeColor = System.Drawing.Color.Teal;
            this.ProductCodeLabel.Location = new System.Drawing.Point(760, 9);
            this.ProductCodeLabel.Name = "ProductCodeLabel";
            this.ProductCodeLabel.Size = new System.Drawing.Size(172, 36);
            this.ProductCodeLabel.TabIndex = 1;
            this.ProductCodeLabel.Text = "Код товара";
            this.ProductCodeLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // ProductNameLabel
            // 
            this.ProductNameLabel.AutoSize = true;
            this.ProductNameLabel.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ProductNameLabel.Location = new System.Drawing.Point(16, 10);
            this.ProductNameLabel.MaximumSize = new System.Drawing.Size(500, 100);
            this.ProductNameLabel.Name = "ProductNameLabel";
            this.ProductNameLabel.Size = new System.Drawing.Size(257, 36);
            this.ProductNameLabel.TabIndex = 0;
            this.ProductNameLabel.Text = "Название товара";
            // 
            // OrderDescriptionWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(978, 644);
            this.Controls.Add(this.OrderDescPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "OrderDescriptionWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OrderDescription";
            this.Load += new System.EventHandler(this.OrderDescriptionWindow_Load);
            this.OrderDescPanel.ResumeLayout(false);
            this.OrderDescPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel OrderDescPanel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label DescriptionValueLabel;
        private System.Windows.Forms.Label DescriptionLabel;
        private System.Windows.Forms.Label QuantityValueLabel;
        private System.Windows.Forms.Label QuantityLabel;
        private System.Windows.Forms.Label PriceValueLabel;
        private System.Windows.Forms.Label PriceLabel;
        private System.Windows.Forms.Label ProductCodeLabel;
        private System.Windows.Forms.Label ProductNameLabel;
        private System.Windows.Forms.Button InBasketButton;
        private System.Windows.Forms.Button BackProductButton;
        private System.Windows.Forms.Button DecreaseButton;
        private System.Windows.Forms.Button IncreaseButton;
        private System.Windows.Forms.Label CloseButton;
    }
}