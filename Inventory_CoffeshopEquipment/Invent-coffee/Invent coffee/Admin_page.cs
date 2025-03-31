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

namespace Invent_coffee;

public partial class Admin_page : UserControl
{
    private MainForm _mainform;
    public Admin_page(MainForm mainform)
    {
        InitializeComponent();
        _mainform = mainform;
    }

    private void InventoryBtn_Click(object sender, EventArgs e)
    {
        _mainform.ShowInventoryPage();
    }

    private void LogOutBtn_Click(object sender, EventArgs e)
    {
        _mainform.ShowLoginPage();
    }

    private void OrderBtn_Click(object sender, EventArgs e)
    {

    }

    private void Admin_page_Load(object sender, EventArgs e)
    {

    }

    private void RecordBtn_Click(object sender, EventArgs e)
    {

    }
}
