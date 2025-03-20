using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Invent_coffee
{
    public partial class Cart_Page: UserControl
    {
        private string connectiondb = "server=localhost;database=mydb;user=root;password=1922tqbfjotldsql;";
        private MainForm _mainform;

        public Cart_Page(MainForm mainform)
        {
            InitializeComponent();
            _mainform = mainform;

        }

    }
}
