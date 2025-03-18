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
    public partial class Home_Page: UserControl
    {
        private MainForm _mainform;
        public Home_Page(MainForm mainform)
        {
            InitializeComponent();
            _mainform = mainform;
        }
    }
}
