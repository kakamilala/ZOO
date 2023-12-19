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
    public partial class CatalogWindow : Form
    {
        private AuthorizationWindow AuthorizationWindow;
        private DB db = new DB();
        private Panel[] panels = new Panel[200];
        private Product[] products = new Product[200];
        public CatalogWindow(AuthorizationWindow authorizationWindow)
        {
            InitializeComponent();
            this.AuthorizationWindow = authorizationWindow;


        }

        private void CatalogWindow_Load(object sender, EventArgs e)
        {
            db.openConnection();
            MySqlCommand command = new MySqlCommand("SELECT * FROM `products` WHERE `quantity`>0", db.getConnection());
            MySqlDataReader dataReader = command.ExecuteReader();

            



            int i = 0,j = 0, x = 15, y = 0;
            while (dataReader.Read())
            {
                if (i == 3)
                {
                    i = 0;
                    x = 15;
                    y += 160;
                }
                products[j] = new Product();
                products[j].setIDproduct(dataReader.GetInt32(dataReader.GetOrdinal("id_product")));                
                products[j].setName(dataReader.GetString(dataReader.GetOrdinal("name_product")));
                products[j].setDescription(dataReader.GetString(dataReader.GetOrdinal("description")));
                products[j].setQuantity(dataReader.GetInt32(dataReader.GetOrdinal("quantity")));
                products[j].setPrice(dataReader.GetInt32(dataReader.GetOrdinal("price")));
                products[j].setCode(dataReader.GetInt32(dataReader.GetOrdinal("code_product")));





                panels[j] = new Panel();
                Label label = new Label();
                Label price_label = new Label();
                panels[j].BorderStyle = BorderStyle.FixedSingle;
                panels[j].Size = new Size(200,150);
                panels[j].Location = new Point(x, y);
                panels[j].Cursor = Cursors.Hand;
                label.Size = new Size(200, 50);
                label.Text = dataReader.GetString(dataReader.GetOrdinal("name_product"));
                price_label.Text = dataReader.GetInt16(dataReader.GetOrdinal("price"))+ " руб.";
                
                price_label.Dock = DockStyle.Bottom;
                panels[j].Controls.Add(label);
                panels[j].Controls.Add(price_label);
                panels[j].Click += new EventHandler(Product_Click);
                ProductsPanel.Controls.Add(panels[j]);
                i++;
                j++;
                x += 210;
            }
            
            db.closeConnection();



        }
        private void Product_Click(object sender, EventArgs e)
        {
            int j = 0;
            while(panels[j]!=null)
            {
                if(panels[j]==sender)
                {
                    ProductDescriptionWindow productDescriptionWindow = new ProductDescriptionWindow(AuthorizationWindow ,this, products[j]);
                    this.Visible = false;
                    productDescriptionWindow.Show();

                }
                j++;
            }
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void AccountButtonCat_Click(object sender, EventArgs e)
        {
            AccountWindow accountWindow = new AccountWindow(AuthorizationWindow, this);
            accountWindow.Show();
            this.Visible = false;
        }

        private void BasketButtonCat_Click(object sender, EventArgs e)
        {
            BasketWindow basketWindow = new BasketWindow(AuthorizationWindow,this);
            basketWindow.Show();
            this.Hide();
        }

        private void OrdersButtomCat_Click(object sender, EventArgs e)
        {
            OrdersUserWindow ordersUserWindow = new OrdersUserWindow(this);
            ordersUserWindow.Show();
            this.Visible = false;
        }
    }
}
