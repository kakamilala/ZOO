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
    public partial class OrdersUserWindow : Form
    {
        private Form CatalogWindow;
        public OrdersUserWindow(Form catalogWindow)
        {
            InitializeComponent();
            this.CatalogWindow = catalogWindow;
        }

        private void BackOrdersButton_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            CatalogWindow.Visible = true;
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
