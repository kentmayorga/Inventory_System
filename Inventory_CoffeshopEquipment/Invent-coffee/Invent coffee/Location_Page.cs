using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Invent_coffee
{
    public partial class Location_Page : UserControl
    {
        private MainForm _mainForm;
        public Location_Page(MainForm mainForm)
        {
            InitializeComponent();
            _mainForm = mainForm;
        }

        private void HomeButton_Click(object sender, EventArgs e)
        {
            _mainForm.ShowHomePage();
        }

        private void HomeButton_Click_1(object sender, EventArgs e)
        {

        }
    }
}
