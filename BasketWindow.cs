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
    public partial class BasketWindow : Form
    {
        private DB db = new DB();
        private Form CatalogWindow;
        private AuthorizationWindow authorizationWindow;

        Panel[] panels = new Panel[200];
        Product[] products = new Product[200];

        public BasketWindow(AuthorizationWindow authorizationWindow,Form form)
        {
            InitializeComponent();
            CatalogWindow = form;
            this.authorizationWindow = authorizationWindow;
            
        }

        private void BackBaskButton_Click(object sender, EventArgs e)
        {
            this.Close();
            CatalogWindow.Visible = true;
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BasketWindow_Load(object sender, EventArgs e)
        {
            int[] id_product = new int[100];
            db.openConnection();
            MySqlCommand command = new MySqlCommand("SELECT * FROM `basket` WHERE `id_user`=@idU", db.getConnection());
            command.Parameters.Add("@idU", MySqlDbType.Int32).Value = authorizationWindow.getIDuser();
            MySqlDataReader dataReader = command.ExecuteReader();

            int i = 0;
            while(dataReader.Read())
            {
                id_product[i] = dataReader.GetInt32(dataReader.GetOrdinal("id_product"));
                i++;
            }

            dataReader.Close();
            db.closeConnection();

            int y = 0;
            for (int j=0; id_product[j]!=0; j++)
            {

                MySqlCommand _command = new MySqlCommand("SELECT * FROM `products` WHERE `id_product`=@idP", db.getConnection());
                _command.Parameters.Add("@idP", MySqlDbType.Int32).Value = id_product[j];
                db.openConnection();
                MySqlDataReader _dataReader = _command.ExecuteReader();
                _dataReader.Read();
                panels[j] = new Panel();
                Label label = new Label();
                Label price_label = new Label();
                panels[j].BorderStyle = BorderStyle.FixedSingle;
                panels[j].Size = new Size(300, 150);
                panels[j].Location = new Point(15, y);
                panels[j].Cursor = Cursors.Hand;
                label.Size = new Size(200, 50);
                label.Text = _dataReader.GetString(_dataReader.GetOrdinal("name_product"));
                price_label.Text = _dataReader.GetInt16(_dataReader.GetOrdinal("price")) + " руб.";

                db.closeConnection();
                price_label.Dock = DockStyle.Bottom;
                panels[j].Controls.Add(label);
                panels[j].Controls.Add(price_label);
                panels[j].Click += new EventHandler(Product_Click);
                ProductsPanel.Controls.Add(panels[j]);
                j++;
                y += 160;
            }
            
        }

        private void Product_Click(object sender, EventArgs e)
        {
            int j = 0;
            while (panels[j] != null)
            {
                if (panels[j] == sender)
                {
                    ProductDescriptionWindow orderDescriptionWindow = new ProductDescriptionWindow(authorizationWindow, this, products[j]);
                    this.Visible = false;
                    orderDescriptionWindow.Show();

                }
                j++;
            }
        }

    }
}
