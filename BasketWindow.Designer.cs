
namespace ZOO
{
    partial class BasketWindow
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
            this.BasketPanel = new System.Windows.Forms.Panel();
            this.ProductsPanel = new System.Windows.Forms.Panel();
            this.BasketBuyButton = new System.Windows.Forms.Button();
            this.BackBaskButton = new System.Windows.Forms.Button();
            this.CloseButton = new System.Windows.Forms.Label();
            this.BasketLabel = new System.Windows.Forms.Label();
            this.BasketPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // BasketPanel
            // 
            this.BasketPanel.Controls.Add(this.ProductsPanel);
            this.BasketPanel.Controls.Add(this.BasketBuyButton);
            this.BasketPanel.Controls.Add(this.BackBaskButton);
            this.BasketPanel.Controls.Add(this.CloseButton);
            this.BasketPanel.Controls.Add(this.BasketLabel);
            this.BasketPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BasketPanel.Location = new System.Drawing.Point(0, 0);
            this.BasketPanel.Name = "BasketPanel";
            this.BasketPanel.Size = new System.Drawing.Size(978, 644);
            this.BasketPanel.TabIndex = 0;
            // 
            // ProductsPanel
            // 
            this.ProductsPanel.AutoScroll = true;
            this.ProductsPanel.BackColor = System.Drawing.Color.LightCyan;
            this.ProductsPanel.Location = new System.Drawing.Point(0, 81);
            this.ProductsPanel.Name = "ProductsPanel";
            this.ProductsPanel.Size = new System.Drawing.Size(978, 482);
            this.ProductsPanel.TabIndex = 17;
            // 
            // BasketBuyButton
            // 
            this.BasketBuyButton.BackColor = System.Drawing.Color.MediumTurquoise;
            this.BasketBuyButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BasketBuyButton.FlatAppearance.BorderSize = 0;
            this.BasketBuyButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightCyan;
            this.BasketBuyButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightCyan;
            this.BasketBuyButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BasketBuyButton.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.BasketBuyButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.BasketBuyButton.Location = new System.Drawing.Point(766, 582);
            this.BasketBuyButton.Name = "BasketBuyButton";
            this.BasketBuyButton.Size = new System.Drawing.Size(200, 50);
            this.BasketBuyButton.TabIndex = 16;
            this.BasketBuyButton.Text = "Купить";
            this.BasketBuyButton.UseVisualStyleBackColor = false;
            // 
            // BackBaskButton
            // 
            this.BackBaskButton.BackColor = System.Drawing.Color.MediumTurquoise;
            this.BackBaskButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BackBaskButton.FlatAppearance.BorderSize = 0;
            this.BackBaskButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightCyan;
            this.BackBaskButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightCyan;
            this.BackBaskButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BackBaskButton.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.BackBaskButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.BackBaskButton.Location = new System.Drawing.Point(12, 582);
            this.BackBaskButton.Name = "BackBaskButton";
            this.BackBaskButton.Size = new System.Drawing.Size(200, 50);
            this.BackBaskButton.TabIndex = 15;
            this.BackBaskButton.Text = "Назад";
            this.BackBaskButton.UseVisualStyleBackColor = false;
            this.BackBaskButton.Click += new System.EventHandler(this.BackBaskButton_Click);
            // 
            // CloseButton
            // 
            this.CloseButton.AutoSize = true;
            this.CloseButton.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold);
            this.CloseButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.CloseButton.Location = new System.Drawing.Point(940, 9);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(26, 29);
            this.CloseButton.TabIndex = 14;
            this.CloseButton.Text = "X";
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // BasketLabel
            // 
            this.BasketLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.BasketLabel.Font = new System.Drawing.Font("Times New Roman", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BasketLabel.Location = new System.Drawing.Point(0, 0);
            this.BasketLabel.Name = "BasketLabel";
            this.BasketLabel.Size = new System.Drawing.Size(978, 71);
            this.BasketLabel.TabIndex = 1;
            this.BasketLabel.Text = "Корзина";
            this.BasketLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BasketWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(978, 644);
            this.Controls.Add(this.BasketPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BasketWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BasketWindow";
            this.Load += new System.EventHandler(this.BasketWindow_Load);
            this.BasketPanel.ResumeLayout(false);
            this.BasketPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel BasketPanel;
        private System.Windows.Forms.Label BasketLabel;
        private System.Windows.Forms.Label CloseButton;
        private System.Windows.Forms.Button BackBaskButton;
        private System.Windows.Forms.Button BasketBuyButton;
        private System.Windows.Forms.Panel ProductsPanel;
    }
}