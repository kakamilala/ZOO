
namespace ZOO
{
    partial class RegistrtionWindow
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
            this.NameBoxReg = new System.Windows.Forms.TextBox();
            this.LoginBoxReg = new System.Windows.Forms.TextBox();
            this.PasswordBoxReg = new System.Windows.Forms.TextBox();
            this.RegistrationButtonRegWin = new System.Windows.Forms.Button();
            this.RegistrationLabel = new System.Windows.Forms.Label();
            this.RegistrPanel = new System.Windows.Forms.Panel();
            this.AuthorButtonReg = new System.Windows.Forms.Button();
            this.CloseButton = new System.Windows.Forms.Label();
            this.generator = new System.Windows.Forms.Button();
            this.RegistrPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // NameBoxReg
            // 
            this.NameBoxReg.BackColor = System.Drawing.Color.LightCyan;
            this.NameBoxReg.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.NameBoxReg.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NameBoxReg.ForeColor = System.Drawing.Color.Teal;
            this.NameBoxReg.Location = new System.Drawing.Point(300, 173);
            this.NameBoxReg.Name = "NameBoxReg";
            this.NameBoxReg.Size = new System.Drawing.Size(400, 56);
            this.NameBoxReg.TabIndex = 1;
            this.NameBoxReg.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.NameBoxReg.TextChanged += new System.EventHandler(this.NameBoxReg_TextChanged);
            this.NameBoxReg.Enter += new System.EventHandler(this.NameBoxReg_Enter);
            this.NameBoxReg.Leave += new System.EventHandler(this.NameBoxReg_Leave);
            // 
            // LoginBoxReg
            // 
            this.LoginBoxReg.BackColor = System.Drawing.Color.LightCyan;
            this.LoginBoxReg.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LoginBoxReg.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LoginBoxReg.ForeColor = System.Drawing.Color.Teal;
            this.LoginBoxReg.Location = new System.Drawing.Point(300, 252);
            this.LoginBoxReg.Name = "LoginBoxReg";
            this.LoginBoxReg.Size = new System.Drawing.Size(400, 56);
            this.LoginBoxReg.TabIndex = 2;
            this.LoginBoxReg.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.LoginBoxReg.Enter += new System.EventHandler(this.LoginBoxReg_Enter);
            this.LoginBoxReg.Leave += new System.EventHandler(this.LoginBoxReg_Leave);
            // 
            // PasswordBoxReg
            // 
            this.PasswordBoxReg.BackColor = System.Drawing.Color.LightCyan;
            this.PasswordBoxReg.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PasswordBoxReg.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PasswordBoxReg.ForeColor = System.Drawing.Color.Teal;
            this.PasswordBoxReg.Location = new System.Drawing.Point(300, 331);
            this.PasswordBoxReg.Name = "PasswordBoxReg";
            this.PasswordBoxReg.Size = new System.Drawing.Size(400, 56);
            this.PasswordBoxReg.TabIndex = 3;
            this.PasswordBoxReg.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.PasswordBoxReg.TextChanged += new System.EventHandler(this.PasswordBoxReg_TextChanged);
            this.PasswordBoxReg.Enter += new System.EventHandler(this.PasswordBoxReg_Enter);
            this.PasswordBoxReg.Leave += new System.EventHandler(this.PasswordBoxReg_Leave);
            // 
            // RegistrationButtonRegWin
            // 
            this.RegistrationButtonRegWin.BackColor = System.Drawing.Color.MediumTurquoise;
            this.RegistrationButtonRegWin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RegistrationButtonRegWin.FlatAppearance.BorderSize = 0;
            this.RegistrationButtonRegWin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightCyan;
            this.RegistrationButtonRegWin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RegistrationButtonRegWin.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RegistrationButtonRegWin.Location = new System.Drawing.Point(300, 429);
            this.RegistrationButtonRegWin.Name = "RegistrationButtonRegWin";
            this.RegistrationButtonRegWin.Size = new System.Drawing.Size(400, 50);
            this.RegistrationButtonRegWin.TabIndex = 4;
            this.RegistrationButtonRegWin.Text = "Зарегистрироваться";
            this.RegistrationButtonRegWin.UseVisualStyleBackColor = false;
            this.RegistrationButtonRegWin.Click += new System.EventHandler(this.RegistrationButtonRegWin_Click);
            // 
            // RegistrationLabel
            // 
            this.RegistrationLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.RegistrationLabel.Font = new System.Drawing.Font("Times New Roman", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RegistrationLabel.Location = new System.Drawing.Point(0, 0);
            this.RegistrationLabel.Name = "RegistrationLabel";
            this.RegistrationLabel.Size = new System.Drawing.Size(978, 96);
            this.RegistrationLabel.TabIndex = 5;
            this.RegistrationLabel.Text = "Регистрация";
            this.RegistrationLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // RegistrPanel
            // 
            this.RegistrPanel.Controls.Add(this.generator);
            this.RegistrPanel.Controls.Add(this.AuthorButtonReg);
            this.RegistrPanel.Controls.Add(this.CloseButton);
            this.RegistrPanel.Controls.Add(this.RegistrationLabel);
            this.RegistrPanel.Controls.Add(this.RegistrationButtonRegWin);
            this.RegistrPanel.Controls.Add(this.NameBoxReg);
            this.RegistrPanel.Controls.Add(this.PasswordBoxReg);
            this.RegistrPanel.Controls.Add(this.LoginBoxReg);
            this.RegistrPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RegistrPanel.Location = new System.Drawing.Point(0, 0);
            this.RegistrPanel.Name = "RegistrPanel";
            this.RegistrPanel.Size = new System.Drawing.Size(978, 644);
            this.RegistrPanel.TabIndex = 6;
            this.RegistrPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // AuthorButtonReg
            // 
            this.AuthorButtonReg.BackColor = System.Drawing.Color.MediumTurquoise;
            this.AuthorButtonReg.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AuthorButtonReg.FlatAppearance.BorderSize = 0;
            this.AuthorButtonReg.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightCyan;
            this.AuthorButtonReg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AuthorButtonReg.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AuthorButtonReg.Location = new System.Drawing.Point(300, 568);
            this.AuthorButtonReg.Name = "AuthorButtonReg";
            this.AuthorButtonReg.Size = new System.Drawing.Size(400, 50);
            this.AuthorButtonReg.TabIndex = 7;
            this.AuthorButtonReg.Text = "Авторизация";
            this.AuthorButtonReg.UseVisualStyleBackColor = false;
            this.AuthorButtonReg.Click += new System.EventHandler(this.AuthorButtonReg_Click);
            // 
            // CloseButton
            // 
            this.CloseButton.AutoSize = true;
            this.CloseButton.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold);
            this.CloseButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.CloseButton.Location = new System.Drawing.Point(940, 9);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(26, 29);
            this.CloseButton.TabIndex = 6;
            this.CloseButton.Text = "X";
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // generator
            // 
            this.generator.Location = new System.Drawing.Point(706, 331);
            this.generator.Name = "generator";
            this.generator.Size = new System.Drawing.Size(123, 56);
            this.generator.TabIndex = 8;
            this.generator.Text = "генерировать";
            this.generator.UseVisualStyleBackColor = true;
            this.generator.Click += new System.EventHandler(this.generator_Click);
            // 
            // RegistrtionWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(978, 644);
            this.Controls.Add(this.RegistrPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RegistrtionWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RegistrtionWindow";
            this.Load += new System.EventHandler(this.RegistrtionWindow_Load);
            this.RegistrPanel.ResumeLayout(false);
            this.RegistrPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox NameBoxReg;
        private System.Windows.Forms.TextBox LoginBoxReg;
        private System.Windows.Forms.TextBox PasswordBoxReg;
        private System.Windows.Forms.Button RegistrationButtonRegWin;
        private System.Windows.Forms.Label RegistrationLabel;
        private System.Windows.Forms.Panel RegistrPanel;
        private System.Windows.Forms.Label CloseButton;
        private System.Windows.Forms.Button AuthorButtonReg;
        private System.Windows.Forms.Button generator;
    }
}