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
        MenuPanel.Hide();
    }

    private void Admin_page_Load(object sender, EventArgs e)
    {

    }

    /*
        OPEN Navigation bar
     */
    private void ProfileBtn_Click(object sender, EventArgs e)
    {

    }

    private void InventoryBtn_Click(object sender, EventArgs e)
    {
        _mainform.ShowInventoryPage();
    }

    private void OrderBtn_Click(object sender, EventArgs e)
    {

    }

    private void RecordBtn_Click(object sender, EventArgs e)
    {

    }

    private void AccountBtn_Click(object sender, EventArgs e)
    {

    }

    private void LogOutBtn_Click(object sender, EventArgs e)
    {
        _mainform.ShowLoginPage();
    }
    private void NavBarBtn_Click(object sender, EventArgs e)
    {
        MenuPanel.Hide();
        MiniMenuPanel.Show();
    }

    /*
        CLOSE Navigation Bar
     */
    private void MiniNavBarProfileBtn_Click(object sender, EventArgs e)
    {

    }

    private void MiniNavBarInventoryBtn_Click(object sender, EventArgs e)
    {
        _mainform.ShowInventoryPage();
    }

    private void MiniNavBarOrderBtn_Click(object sender, EventArgs e)
    {

    }

    private void MiniNavBarRecordBtn_Click(object sender, EventArgs e)
    {

    }

    private void MiniNavBarAccountBtn_Click(object sender, EventArgs e)
    {

    }

    private void MiniNavLogOutBtn_Click(object sender, EventArgs e)
    {
        _mainform.ShowLoginPage();
    }

    private void MenuBarBtn_Click(object sender, EventArgs e)
    {
        MenuPanel.Show();
        MiniMenuPanel.Hide();
    }
}
