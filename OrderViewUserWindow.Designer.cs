
namespace ZOO
{
    partial class OrderViewUserWindow
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
            this.OrderPanel = new System.Windows.Forms.Panel();
            this.OrderSubPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.OrderCancelButton = new System.Windows.Forms.Button();
            this.BackOrderButton = new System.Windows.Forms.Button();
            this.CloseButton = new System.Windows.Forms.Label();
            this.OrderLabel = new System.Windows.Forms.Label();
            this.OrderPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // OrderPanel
            // 
            this.OrderPanel.Controls.Add(this.OrderSubPanel);
            this.OrderPanel.Controls.Add(this.OrderCancelButton);
            this.OrderPanel.Controls.Add(this.BackOrderButton);
            this.OrderPanel.Controls.Add(this.CloseButton);
            this.OrderPanel.Controls.Add(this.OrderLabel);
            this.OrderPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OrderPanel.Location = new System.Drawing.Point(0, 0);
            this.OrderPanel.Name = "OrderPanel";
            this.OrderPanel.Size = new System.Drawing.Size(978, 644);
            this.OrderPanel.TabIndex = 1;
            // 
            // OrderSubPanel
            // 
            this.OrderSubPanel.AutoScroll = true;
            this.OrderSubPanel.BackColor = System.Drawing.Color.LightCyan;
            this.OrderSubPanel.Location = new System.Drawing.Point(12, 81);
            this.OrderSubPanel.Name = "OrderSubPanel";
            this.OrderSubPanel.Size = new System.Drawing.Size(954, 483);
            this.OrderSubPanel.TabIndex = 17;
            // 
            // OrderCancelButton
            // 
            this.OrderCancelButton.BackColor = System.Drawing.Color.MediumTurquoise;
            this.OrderCancelButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.OrderCancelButton.FlatAppearance.BorderSize = 0;
            this.OrderCancelButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightCyan;
            this.OrderCancelButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightCyan;
            this.OrderCancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OrderCancelButton.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.OrderCancelButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.OrderCancelButton.Location = new System.Drawing.Point(702, 570);
            this.OrderCancelButton.Name = "OrderCancelButton";
            this.OrderCancelButton.Size = new System.Drawing.Size(200, 50);
            this.OrderCancelButton.TabIndex = 16;
            this.OrderCancelButton.Text = "Отменить";
            this.OrderCancelButton.UseVisualStyleBackColor = false;
            // 
            // BackOrderButton
            // 
            this.BackOrderButton.BackColor = System.Drawing.Color.MediumTurquoise;
            this.BackOrderButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BackOrderButton.FlatAppearance.BorderSize = 0;
            this.BackOrderButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightCyan;
            this.BackOrderButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightCyan;
            this.BackOrderButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BackOrderButton.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.BackOrderButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.BackOrderButton.Location = new System.Drawing.Point(100, 570);
            this.BackOrderButton.Name = "BackOrderButton";
            this.BackOrderButton.Size = new System.Drawing.Size(200, 50);
            this.BackOrderButton.TabIndex = 15;
            this.BackOrderButton.Text = "Назад";
            this.BackOrderButton.UseVisualStyleBackColor = false;
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
            // OrderLabel
            // 
            this.OrderLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.OrderLabel.Font = new System.Drawing.Font("Times New Roman", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OrderLabel.Location = new System.Drawing.Point(0, 0);
            this.OrderLabel.Name = "OrderLabel";
            this.OrderLabel.Size = new System.Drawing.Size(978, 71);
            this.OrderLabel.TabIndex = 1;
            this.OrderLabel.Text = "№ заказа";
            this.OrderLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // OrderViewUserWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(978, 644);
            this.Controls.Add(this.OrderPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "OrderViewUserWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OrderViewUserWindow";
            this.OrderPanel.ResumeLayout(false);
            this.OrderPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel OrderPanel;
        private System.Windows.Forms.Button OrderCancelButton;
        private System.Windows.Forms.Button BackOrderButton;
        private System.Windows.Forms.Label CloseButton;
        private System.Windows.Forms.Label OrderLabel;
        private System.Windows.Forms.FlowLayoutPanel OrderSubPanel;
    }
}