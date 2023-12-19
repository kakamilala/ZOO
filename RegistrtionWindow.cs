using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZOO
{
    public partial class RegistrtionWindow : Form
    {
        private Form AuthorizationWindow;
        public RegistrtionWindow(Form form)
        {
            InitializeComponent();
            NameBoxReg.Text = "Введите имя";
            LoginBoxReg.Text = "Введите логин";
            PasswordBoxReg.Text = "Введите пароль";
            this.AuthorizationWindow = form;
        }

        private void NameBoxReg_TextChanged(object sender, EventArgs e)
        {

        }

        private void PasswordBoxReg_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void RegistrtionWindow_Load(object sender, EventArgs e)
        {

        }

        private void NameBoxReg_Enter(object sender, EventArgs e)
        {
            if(NameBoxReg.Text == "Введите имя")
            {
                NameBoxReg.Text = "";
                NameBoxReg.ForeColor = Color.Black;
            }
        }

        private void NameBoxReg_Leave(object sender, EventArgs e)
        {
            if (NameBoxReg.Text == "")
            {
                NameBoxReg.Text = "Введите имя";
                NameBoxReg.ForeColor = Color.Teal;
            }
        }

        private void LoginBoxReg_Enter(object sender, EventArgs e)
        {
            if (LoginBoxReg.Text == "Введите логин")
            {
                LoginBoxReg.Text = "";
                LoginBoxReg.ForeColor = Color.Black;
            }
        }

        private void LoginBoxReg_Leave(object sender, EventArgs e)
        {
            if (LoginBoxReg.Text == "")
            {
                LoginBoxReg.Text = "Введите логин";
                LoginBoxReg.ForeColor = Color.Teal;
            }
        }

        private void PasswordBoxReg_Enter(object sender, EventArgs e)
        {
            if (PasswordBoxReg.Text == "Введите пароль")
            {
                PasswordBoxReg.Text = "";
                PasswordBoxReg.ForeColor = Color.Black;
                PasswordBoxReg.PasswordChar = '*';
            }
        }

        private void PasswordBoxReg_Leave(object sender, EventArgs e)
        {
            if (PasswordBoxReg.Text == "")
            {
                PasswordBoxReg.Text = "Введите пароль";
                PasswordBoxReg.ForeColor = Color.Teal;
                PasswordBoxReg.PasswordChar = '\0';

            }
        }

        private void RegistrationButtonRegWin_Click(object sender, EventArgs e)
        {

            Validation validation=new Validation();

            
            if (NameBoxReg.Text == "Введите имя")
            {
                MessageBox.Show("Не введено имя!");
                return;
            }

            if (LoginBoxReg.Text == "Введите логин")
            {
                MessageBox.Show("Не введен логин!");
                return;
            }

            if (PasswordBoxReg.Text == "Введите пароль")
            {
                MessageBox.Show("Не введен пароль!");
                return;
            }

            if (!validation.IsNameValid(NameBoxReg.Text))
            {
                MessageBox.Show("Некорректное имя!");
                return;
            }
            else if (!validation.IsLoginValid(LoginBoxReg.Text))
            {
                MessageBox.Show("Некорректный логин!");
                return;
            }
            else if (!validation.IsPasswordValid(PasswordBoxReg.Text))
            {
                MessageBox.Show("Некорректный пароль!");
                return;
            }

            if (validation.IsUserExist(LoginBoxReg.Text))
            {
                MessageBox.Show("Такой логин существует!");
                return;
            }

            
            if(!validation.IsNameValid(NameBoxReg.Text))
            {
                MessageBox.Show("Некорректное имя!");
                return;
            }
            else if(!validation.IsLoginValid(LoginBoxReg.Text))
            {
                MessageBox.Show("Некорректный логин!");
                return;
            }
            else if (!validation.IsPasswordValid(PasswordBoxReg.Text))
            {
                MessageBox.Show("Некорректный пароль!");
                return;
            }




            DB db = new DB();
            MySqlCommand command = new MySqlCommand("INSERT INTO `users` ( `login`, `password`, `name`, `surname`, `phone`) VALUES (@uL, @uP, @uN, '', '')", db.getConnection());
            command.Parameters.Add("@uN", MySqlDbType.VarChar).Value = NameBoxReg.Text;
            command.Parameters.Add("@uL", MySqlDbType.VarChar).Value = LoginBoxReg.Text;
            command.Parameters.Add("@uP", MySqlDbType.VarChar).Value = PasswordBoxReg.Text;

            db.openConnection();

            if (command.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Аккаунт создан!");
                this.Close();
                AuthorizationWindow.Visible = true;
            }
            else
                MessageBox.Show("Аккаунт не создан!(((");



            db.closeConnection();


        }

        

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void AuthorButtonReg_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            AuthorizationWindow.Visible = true;
        }

        private void generator_Click(object sender, EventArgs e)
        {
            string parametrs = "ABCDEFGHIJKLMNOPQRSTUVWXYZабвгдеёжзийклмнопрстуфхцчшщъыьэюя";
            int quantity = 6;
            string result = "";
            Random rnd = new Random();
            int lng = parametrs.Length;

            for (int i = 0; i < quantity; i++)
            {
                result += parametrs[rnd.Next(lng)];
            }

            PasswordBoxReg.Text = result;
        }
    }
}
