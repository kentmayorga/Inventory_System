using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Invent_coffee
{
    public partial class Shop_Page : UserControl
    {
        private MainForm _mainForm;
        public Shop_Page(MainForm mainform)
        {
            InitializeComponent();
            _mainForm = mainform;
        }

        private void HomeButton_Click(object sender, EventArgs e)
        {
            _mainForm.ShowHomePage();
        }
    }
}
