using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Invent_coffee.Resources.Admin_Pages
{
    public partial class Accounts_page: UserControl
    {
        private MainForm _mainform;
        public Accounts_page(MainForm mainform)
        {
            InitializeComponent();
            _mainform = mainform;
        }
    }
}
