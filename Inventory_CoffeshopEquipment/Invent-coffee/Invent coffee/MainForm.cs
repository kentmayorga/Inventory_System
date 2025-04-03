using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace Invent_coffee;

public partial class MainForm : Form
{
    private string connectiondb = "server=localhost;database=mydb;user=root;password=1922tqbfjotldsql;";
    public MainForm()
    {
        InitializeComponent();
        ShowLoginPage();
    }
    public void ShowLoginPage(){
        Main_Panel.Controls.Clear();
        Main_Panel.Controls.Add(new Login_page(this));
    }
    public void ShowRegistrationPage()
    {
        Main_Panel.Controls.Clear();
        Main_Panel.Controls.Add(new Registration_page(this));
    }
    public void ShowHomePage()
    { 
        Main_Panel.Controls.Clear();
        Main_Panel.Controls.Add(new Home_Page(this));
    }
    public void ShowShopPage()
    {
        Main_Panel.Controls.Clear();
        Main_Panel.Controls.Add(new Shop_Page(this));
    }
    public void ShowCartPage() 
    {
        Main_Panel.Controls.Clear();
        Main_Panel.Controls.Add(new Cart_Page(this));
    }
    public void ShowLocationPage()
    {
        Main_Panel.Controls.Clear();
        Main_Panel.Controls.Add(new Location_Page(this));
    }
} 


