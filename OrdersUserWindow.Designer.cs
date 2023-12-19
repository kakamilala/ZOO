
namespace ZOO
{
    partial class OrdersUserWindow
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
            this.OrdersUserPanel = new System.Windows.Forms.Panel();
            this.OrdersPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.BackOrdersButton = new System.Windows.Forms.Button();
            this.CloseButton = new System.Windows.Forms.Label();
            this.OrdersUserLabel = new System.Windows.Forms.Label();
            this.OrdersUserPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // OrdersUserPanel
            // 
            this.OrdersUserPanel.Controls.Add(this.OrdersPanel);
            this.OrdersUserPanel.Controls.Add(this.BackOrdersButton);
            this.OrdersUserPanel.Controls.Add(this.CloseButton);
            this.OrdersUserPanel.Controls.Add(this.OrdersUserLabel);
            this.OrdersUserPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OrdersUserPanel.Location = new System.Drawing.Point(0, 0);
            this.OrdersUserPanel.Name = "OrdersUserPanel";
            this.OrdersUserPanel.Size = new System.Drawing.Size(978, 644);
            this.OrdersUserPanel.TabIndex = 1;
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
            // BackOrdersButton
            // 
            this.BackOrdersButton.BackColor = System.Drawing.Color.MediumTurquoise;
            this.BackOrdersButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BackOrdersButton.FlatAppearance.BorderSize = 0;
            this.BackOrdersButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightCyan;
            this.BackOrdersButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightCyan;
            this.BackOrdersButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BackOrdersButton.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.BackOrdersButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.BackOrdersButton.Location = new System.Drawing.Point(12, 582);
            this.BackOrdersButton.Name = "BackOrdersButton";
            this.BackOrdersButton.Size = new System.Drawing.Size(200, 50);
            this.BackOrdersButton.TabIndex = 15;
            this.BackOrdersButton.Text = "Назад";
            this.BackOrdersButton.UseVisualStyleBackColor = false;
            this.BackOrdersButton.Click += new System.EventHandler(this.BackOrdersButton_Click);
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
            // OrdersUserLabel
            // 
            this.OrdersUserLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.OrdersUserLabel.Font = new System.Drawing.Font("Times New Roman", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OrdersUserLabel.Location = new System.Drawing.Point(0, 0);
            this.OrdersUserLabel.Name = "OrdersUserLabel";
            this.OrdersUserLabel.Size = new System.Drawing.Size(978, 71);
            this.OrdersUserLabel.TabIndex = 1;
            this.OrdersUserLabel.Text = "Заказы";
            this.OrdersUserLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // OrdersUserWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(978, 644);
            this.Controls.Add(this.OrdersUserPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "OrdersUserWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Yascheritsa";
            this.OrdersUserPanel.ResumeLayout(false);
            this.OrdersUserPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel OrdersUserPanel;
        private System.Windows.Forms.Button BackOrdersButton;
        private System.Windows.Forms.Label CloseButton;
        private System.Windows.Forms.Label OrdersUserLabel;
        private System.Windows.Forms.FlowLayoutPanel OrdersPanel;
    }
}