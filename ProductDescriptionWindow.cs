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
    public partial class ProductDescriptionWindow : Form
    {
        private DB db = new DB();
        private AuthorizationWindow AuthorizationWindow;
        private Form backform;
        private Product product;
        public ProductDescriptionWindow(AuthorizationWindow authorizationWindow,Form backform, Product product)
        {
            InitializeComponent();
            this.backform = backform;
            this.product = product;
            this.AuthorizationWindow = authorizationWindow;

            ToolTip tool = new ToolTip();
            tool.SetToolTip(ProductNameLabel, product.getName());
        }

        

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BackProductButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            backform.Show();
        }

        private void OrderDescriptionWindow_Load(object sender, EventArgs e)
        {
            ProductNameLabel.Text = product.getName();
            ProductCodeLabel.Text = product.getCode().ToString();
            PriceValueLabel.Text = product.getPrice().ToString()+" руб.";
            DescriptionValueLabel.Text = product.getDescription();
        }

        private void IncreaseButton_Click(object sender, EventArgs e)
        {
            int q = Convert.ToInt32(QuantityValueLabel.Text);
            if(q<product.getQuantity())
            q++;
            QuantityValueLabel.Text = Convert.ToString(q);
        }

        private void DecreaseButton_Click(object sender, EventArgs e)
        {
            int q = Convert.ToInt32(QuantityValueLabel.Text);
            if(q>1)
            q--;
            QuantityValueLabel.Text = Convert.ToString(q);
        }

        private void InBasketButton_Click(object sender, EventArgs e)
        {
            MySqlCommand command = new MySqlCommand("INSERT INTO `basket` VALUES (NULL, @idP, @idU, true)", db.getConnection());
            command.Parameters.Add("@idP", MySqlDbType.Int32).Value = product.getIDproduct();
            command.Parameters.Add("@idU", MySqlDbType.Int32).Value = AuthorizationWindow.getIDuser();

            db.openConnection();
            if (command.ExecuteNonQuery() > 0)
                MessageBox.Show("Товар добавлен в корзину!");
            else
                MessageBox.Show("Ошибка!");
            db.closeConnection();

        }
    }
}
