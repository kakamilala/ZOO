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
    public partial class AuthorizationWindow : Form
    {
        private String loginUser;
        private String passUser;
        private int id_user;

        public string getLogin()
        {
            return loginUser;
        }
        public string getPass()
        {
            return passUser;
        }
        public int getIDuser()
        {
            return id_user;
        }


        public AuthorizationWindow()
        {
            InitializeComponent();
            
            LoginBox.Text = "Введите логин";
            PasswordBox.Text = "Введите пароль";
        }

        private void AuthorizationButton_Click(object sender, EventArgs e)
        {
            loginUser = LoginBox.Text;
            passUser = PasswordBox.Text;

            if(loginUser=="admin"&&passUser=="admin")
            {
                AdminWindow adminWindow = new AdminWindow();
                adminWindow.Show();
                return;
            }

            DB db = new DB();

            DataTable dataTable = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            

            MySqlCommand command = new MySqlCommand("SELECT * FROM `users` WHERE `login` = @uL AND `password` = @uP", db.getConnection());
            command.Parameters.Add("@uL", MySqlDbType.VarChar).Value = loginUser;
            command.Parameters.Add("@uP", MySqlDbType.VarChar).Value = passUser;

            


            adapter.SelectCommand = command;
            adapter.Fill(dataTable);
            

            if (dataTable.Rows.Count > 0)
            {
                db.openConnection();
                MySqlDataReader dataReader = command.ExecuteReader();
                dataReader.Read();
                id_user = dataReader.GetInt32(dataReader.GetOrdinal("id_user"));
                db.closeConnection();

                CatalogWindow catalog = new CatalogWindow(this);
                catalog.Show();
                this.Visible = false;
            }
            else
                MessageBox.Show("Пользователь не найден!");

        }

        private void RegistrationButton_Click(object sender, EventArgs e)
        {
            RegistrtionWindow RegistrationWindow= new RegistrtionWindow(this);
            RegistrationWindow.Show();
            this.Visible = false;
        }

        private void AuthorizationWindow_Load(object sender, EventArgs e)
        {

        }

        private void LoginBox_Enter(object sender, EventArgs e)
        {
            if (LoginBox.Text == "Введите логин")
            {
                LoginBox.Text = "";
                LoginBox.ForeColor = Color.Black;
            }
        }

        private void LoginBox_Leave(object sender, EventArgs e)
        {
            if (LoginBox.Text == "")
            {
                LoginBox.Text = "Введите логин";
                LoginBox.ForeColor = Color.Teal;
            }
        }

        private void PasswordBox_Enter(object sender, EventArgs e)
        {
            if (PasswordBox.Text == "Введите пароль")
            {
                PasswordBox.Text = "";
                PasswordBox.ForeColor = Color.Black;
                PasswordBox.PasswordChar = '*';
            }
        }

        private void PasswordBox_Leave(object sender, EventArgs e)
        {
            if (PasswordBox.Text == "")
            {
                PasswordBox.Text = "Введите пароль";
                PasswordBox.ForeColor = Color.Teal;
                PasswordBox.PasswordChar = '\0';

            }
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
