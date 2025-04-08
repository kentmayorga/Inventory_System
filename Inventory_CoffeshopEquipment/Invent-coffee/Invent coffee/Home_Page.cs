using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Invent_coffee.Resources;

namespace Invent_coffee
{
    public partial class Home_Page : UserControl
    {
        private MainForm _mainform;
        public Home_Page(MainForm mainform)
        {
            InitializeComponent();
            _mainform = mainform;
            Username.Text = AppSession.username;
        }

        private void LogOutButton_Click(object sender, EventArgs e)
        {
            AppSession.id = 0;
            AppSession.username = "";
            AppSession.role = "";
            _mainform.ShowLoginPage();
        }

        private void ShopButton_Click(object sender, EventArgs e)
        {
            _mainform.ShowShopPage();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
