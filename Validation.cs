using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZOO
{
    class Validation
    {
        public bool IsNameValid(string name)
        {
            bool point=true;
            for(int i=0; i<name.Length; i++)
            {
                if (!((name[i] >= 'a' && name[i] <= 'z') || (name[i] >= 'A' && name[i] <= 'Z') || (name[i] >= 'А' && name[i] <= 'Я') || (name[i] >= 'а' && name[i] <= 'я')))
                    point = false;
            }

            return point;
        }

        public bool IsSurnameValid(string surname)
        {
            bool point = true;

            for (int i = 0; i < surname.Length; i++)
            {
                if ((surname[i] >= 'a' && surname[i] <= 'z') || (surname[i] >= 'A' && surname[i] <= 'Z') || (surname[i] >= 'А' && surname[i] <= 'Я') || (surname[i] >= 'а' && surname[i] <= 'я'))
                    point = false;

            }
            return point;
        }

        public bool IsLoginValid(string login)
        {
            if (login.Length < 5)
                return false;
            else 
                return true;
        }

        public bool IsPasswordValid(string password)
        {
            if (password.Length < 5)
                return false;
            else
                return true;
        }

        public bool IsPhoneValid(string phone)
        {
            if (phone.Length < 11)
                return false;
            else if (phone[0] != '8' || phone[0] != '7')
                return false;
            else
                return true;
        }

        public Boolean IsUserExist(string login)
        {
            DB db = new DB();

            DataTable dataTable = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `users` WHERE `login`=@uL", db.getConnection());
            command.Parameters.Add("@uL", MySqlDbType.VarChar).Value = login;

            adapter.SelectCommand = command;
            adapter.Fill(dataTable);

            if (dataTable.Rows.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
