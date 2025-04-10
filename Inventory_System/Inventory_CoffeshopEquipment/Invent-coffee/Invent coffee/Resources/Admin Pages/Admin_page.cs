using Invent_coffee.Resources;
using MySql.Data.MySqlClient;

namespace Invent_coffee;

public partial class Admin_page : UserControl
{
    private MainForm _mainform;
    private connSql conn = new connSql();
    public Admin_page(MainForm mainform)
    {
        InitializeComponent();
        _mainform = mainform;
        UserRoleLabel.Text = "           "+AppSession.role.ToUpper();
        MenuPanel.Hide();
    }

    public void salesData(){
        using MySqlConnection connection = conn.connectSql();
        connection.Open();
        Console.WriteLine("Connecting to database...");

        string query = "";
    }

    /*
        OPEN Navigation bar
     */
    private void InventoryBtn_Click(object sender, EventArgs e)
    {
        _mainform.ShowInventoryPage();
    }

    private void OrderBtn_Click(object sender, EventArgs e)
    {
        _mainform.ShowOrderPage();
    }

    private void RecordBtn_Click(object sender, EventArgs e)
    {
        _mainform.ShowRecordPage();
    }

    private void AccountBtn_Click(object sender, EventArgs e)
    {
        _mainform.ShowAccountsPage();
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

    private void MiniNavBarInventoryBtn_Click(object sender, EventArgs e)
    {
        _mainform.ShowInventoryPage();
    }

    private void MiniNavBarOrderBtn_Click(object sender, EventArgs e)
    {
        _mainform.ShowOrderPage();
    }

    private void MiniNavBarRecordBtn_Click(object sender, EventArgs e)
    {
        _mainform.ShowRecordPage();
    }

    private void MiniNavBarAccountBtn_Click(object sender, EventArgs e)
    {
        _mainform.ShowAccountsPage();
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
