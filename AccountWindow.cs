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
    public partial class AccountWindow : Form
    {
        private DB db = new DB();

        private Form CatalogWindow;
        private AuthorizationWindow AuthorisationWindow;
        string name = "", surname = "", login = "", password = "", phone = "";


        public AccountWindow(AuthorizationWindow AuthorisationWindow, Form CatalogWindow)
        {
            InitializeComponent();
            this.CatalogWindow = CatalogWindow;
            this.AuthorisationWindow = AuthorisationWindow;

        }

        private void UserPasswordLabel_Click(object sender, EventArgs e)
        {

        }

        private void AuthorizationButton_Click(object sender, EventArgs e)
        {

        }

        private void NameBoxAcc_TextChanged(object sender, EventArgs e)
        {

        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BackAccButton_Click(object sender, EventArgs e)
        {
            CatalogWindow.Visible = true;
            this.Visible = false;
        }

        private void AccountSaveButton_Click(object sender, EventArgs e)
        {
            Validation validation = new Validation();
            db.openConnection();
            

            if (NameBoxAcc.Text!=name || SurnameBoxAcc.Text!=surname||LoginBoxAcc.Text!=login||PasswordBoxAcc.Text!=password||PhoneBoxAcc.Text!=phone)
            {
                /*if (!validation.IsNameValid(NameBoxAcc.Text))
                {
                    MessageBox.Show("Некорректное имя!");
                    db.closeConnection();
                    return;
                }
                else if (!validation.IsSurnameValid(SurnameBoxAcc.Text))
                {
                    MessageBox.Show("Некорректная фамилия!");
                    db.closeConnection();
                    return;
                }
                else if (!validation.IsLoginValid(LoginBoxAcc.Text))
                {
                    MessageBox.Show("Некорректный логин!");
                    db.closeConnection();
                    return;
                }
                else if (!validation.IsPasswordValid(PasswordBoxAcc.Text))
                {
                    MessageBox.Show("Некорректный пароль!");
                    db.closeConnection();
                    return;
                }
                else if (!validation.IsPhoneValid(PhoneBoxAcc.Text))
                {
                    MessageBox.Show("Некорректный номер телефона!");
                    db.closeConnection();
                    return;
                }*/

                if(login!=LoginBoxAcc.Text && validation.IsUserExist(LoginBoxAcc.Text))
                {
                    MessageBox.Show("Такой логин существует!");
                    db.closeConnection();
                    return;
                }

                MySqlCommand command = new MySqlCommand("UPDATE `users` SET `login`=@uL, `password`=@uP, `name`=@uN, `surname`=@uS, `phone`=@uPh WHERE `login`=@lastuL AND `password`=@lastuP", db.getConnection());
                command.Parameters.Add("@lastuL", MySqlDbType.VarChar).Value = login;
                command.Parameters.Add("@lastuP", MySqlDbType.VarChar).Value = password;

                command.Parameters.Add("@uN", MySqlDbType.VarChar).Value = NameBoxAcc.Text;
                command.Parameters.Add("@uL", MySqlDbType.VarChar).Value = LoginBoxAcc.Text;
                command.Parameters.Add("@uP", MySqlDbType.VarChar).Value = PasswordBoxAcc.Text;
                command.Parameters.Add("@uS", MySqlDbType.VarChar).Value = SurnameBoxAcc.Text;
                command.Parameters.Add("@uPh", MySqlDbType.VarChar).Value = PhoneBoxAcc.Text;

                name = NameBoxAcc.Text;
                surname = SurnameBoxAcc.Text;
                login = LoginBoxAcc.Text;
                password = PasswordBoxAcc.Text;
                phone = PhoneBoxAcc.Text;

                if (command.ExecuteNonQuery()!= 0)
                {
                    MessageBox.Show("Изменения сохранены!");
                }
                else
                    MessageBox.Show("Ошибка((");

                db.closeConnection();
            }
        }

        private void AccountWindow_Load(object sender, EventArgs e)
        {

            db.openConnection();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `users` WHERE `login`=@uL AND `password`=@uP", db.getConnection());
            command.Parameters.Add("@uL", MySqlDbType.VarChar).Value = AuthorisationWindow.getLogin();
            command.Parameters.Add("@uP", MySqlDbType.VarChar).Value = AuthorisationWindow.getPass();
            MySqlDataReader dataReader = command.ExecuteReader();

            while(dataReader.Read())
            {
                name = dataReader.GetString(dataReader.GetOrdinal("name"));
                surname = dataReader.GetString(dataReader.GetOrdinal("surname"));
                login = dataReader.GetString(dataReader.GetOrdinal("login"));
                password = dataReader.GetString(dataReader.GetOrdinal("password"));
                phone = dataReader.GetString(dataReader.GetOrdinal("phone"));
            }

            NameBoxAcc.Text = name;
            SurnameBoxAcc.Text = surname;
            LoginBoxAcc.Text = login;
            PasswordBoxAcc.Text = password;
            PhoneBoxAcc.Text = phone;



            db.closeConnection();
        }
    }
}
