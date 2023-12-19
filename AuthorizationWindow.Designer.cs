
namespace ZOO
{
    partial class AuthorizationWindow
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AuthorizationWindow));
            this.LoginBox = new System.Windows.Forms.TextBox();
            this.PasswordBox = new System.Windows.Forms.TextBox();
            this.AuthorizationButton = new System.Windows.Forms.Button();
            this.RegistrationButton = new System.Windows.Forms.Button();
            this.mainLogo = new System.Windows.Forms.Label();
            this.AuthorPanel = new System.Windows.Forms.Panel();
            this.CloseButton = new System.Windows.Forms.Label();
            this.AuthorPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // LoginBox
            // 
            this.LoginBox.BackColor = System.Drawing.Color.LightCyan;
            this.LoginBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.LoginBox, "LoginBox");
            this.LoginBox.ForeColor = System.Drawing.Color.Teal;
            this.LoginBox.Name = "LoginBox";
            this.LoginBox.Enter += new System.EventHandler(this.LoginBox_Enter);
            this.LoginBox.Leave += new System.EventHandler(this.LoginBox_Leave);
            // 
            // PasswordBox
            // 
            this.PasswordBox.BackColor = System.Drawing.Color.LightCyan;
            this.PasswordBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.PasswordBox, "PasswordBox");
            this.PasswordBox.ForeColor = System.Drawing.Color.Teal;
            this.PasswordBox.Name = "PasswordBox";
            this.PasswordBox.Enter += new System.EventHandler(this.PasswordBox_Enter);
            this.PasswordBox.Leave += new System.EventHandler(this.PasswordBox_Leave);
            // 
            // AuthorizationButton
            // 
            this.AuthorizationButton.BackColor = System.Drawing.Color.MediumTurquoise;
            this.AuthorizationButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AuthorizationButton.FlatAppearance.BorderSize = 0;
            this.AuthorizationButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightCyan;
            this.AuthorizationButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightCyan;
            resources.ApplyResources(this.AuthorizationButton, "AuthorizationButton");
            this.AuthorizationButton.Name = "AuthorizationButton";
            this.AuthorizationButton.UseVisualStyleBackColor = false;
            this.AuthorizationButton.Click += new System.EventHandler(this.AuthorizationButton_Click);
            // 
            // RegistrationButton
            // 
            this.RegistrationButton.BackColor = System.Drawing.Color.MediumTurquoise;
            this.RegistrationButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RegistrationButton.FlatAppearance.BorderSize = 0;
            this.RegistrationButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightCyan;
            this.RegistrationButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightCyan;
            resources.ApplyResources(this.RegistrationButton, "RegistrationButton");
            this.RegistrationButton.Name = "RegistrationButton";
            this.RegistrationButton.UseVisualStyleBackColor = false;
            this.RegistrationButton.Click += new System.EventHandler(this.RegistrationButton_Click);
            // 
            // mainLogo
            // 
            resources.ApplyResources(this.mainLogo, "mainLogo");
            this.mainLogo.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.mainLogo.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.mainLogo.Name = "mainLogo";
            // 
            // AuthorPanel
            // 
            this.AuthorPanel.BackColor = System.Drawing.Color.PaleTurquoise;
            this.AuthorPanel.Controls.Add(this.CloseButton);
            this.AuthorPanel.Controls.Add(this.mainLogo);
            this.AuthorPanel.Controls.Add(this.RegistrationButton);
            this.AuthorPanel.Controls.Add(this.LoginBox);
            this.AuthorPanel.Controls.Add(this.AuthorizationButton);
            this.AuthorPanel.Controls.Add(this.PasswordBox);
            resources.ApplyResources(this.AuthorPanel, "AuthorPanel");
            this.AuthorPanel.Name = "AuthorPanel";
            // 
            // CloseButton
            // 
            resources.ApplyResources(this.CloseButton, "CloseButton");
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // AuthorizationWindow
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.Controls.Add(this.AuthorPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AuthorizationWindow";
            this.ShowIcon = false;
            this.Load += new System.EventHandler(this.AuthorizationWindow_Load);
            this.AuthorPanel.ResumeLayout(false);
            this.AuthorPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox LoginBox;
        private System.Windows.Forms.TextBox PasswordBox;
        private System.Windows.Forms.Button AuthorizationButton;
        private System.Windows.Forms.Button RegistrationButton;
        private System.Windows.Forms.Label mainLogo;
        private System.Windows.Forms.Panel AuthorPanel;
        private System.Windows.Forms.Label CloseButton;
    }
}

