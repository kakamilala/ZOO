
namespace ZOO
{
    partial class AdminWindow
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
            this.OrdersPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.OrdersAdminPanel = new System.Windows.Forms.Panel();
            this.CloseButton = new System.Windows.Forms.Label();
            this.OrdersAdminLabel = new System.Windows.Forms.Label();
            this.OrdersAdminPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // OrdersPanel
            // 
            this.OrdersPanel.AutoScroll = true;
            this.OrdersPanel.BackColor = System.Drawing.Color.LightCyan;
            this.OrdersPanel.Location = new System.Drawing.Point(12, 81);
            this.OrdersPanel.Name = "OrdersPanel";
            this.OrdersPanel.Size = new System.Drawing.Size(954, 483);
            this.OrdersPanel.TabIndex = 16;
            // 
            // OrdersAdminPanel
            // 
            this.OrdersAdminPanel.BackColor = System.Drawing.Color.PaleTurquoise;
            this.OrdersAdminPanel.Controls.Add(this.OrdersPanel);
            this.OrdersAdminPanel.Controls.Add(this.CloseButton);
            this.OrdersAdminPanel.Controls.Add(this.OrdersAdminLabel);
            this.OrdersAdminPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OrdersAdminPanel.Location = new System.Drawing.Point(0, 0);
            this.OrdersAdminPanel.Name = "OrdersAdminPanel";
            this.OrdersAdminPanel.Size = new System.Drawing.Size(978, 644);
            this.OrdersAdminPanel.TabIndex = 2;
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
            // OrdersAdminLabel
            // 
            this.OrdersAdminLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.OrdersAdminLabel.Font = new System.Drawing.Font("Times New Roman", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OrdersAdminLabel.Location = new System.Drawing.Point(0, 0);
            this.OrdersAdminLabel.Name = "OrdersAdminLabel";
            this.OrdersAdminLabel.Size = new System.Drawing.Size(978, 71);
            this.OrdersAdminLabel.TabIndex = 1;
            this.OrdersAdminLabel.Text = "Заказы";
            this.OrdersAdminLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AdminWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(978, 644);
            this.Controls.Add(this.OrdersAdminPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdminWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminWindow";
            this.OrdersAdminPanel.ResumeLayout(false);
            this.OrdersAdminPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel OrdersPanel;
        private System.Windows.Forms.Panel OrdersAdminPanel;
        private System.Windows.Forms.Label CloseButton;
        private System.Windows.Forms.Label OrdersAdminLabel;
    }
}