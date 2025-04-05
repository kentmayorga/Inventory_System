using Invent_coffee.Resources;
using Invent_coffee.Resources.Admin_Pages;
using Invent_coffee.Resources.Admin_Pages.CRUD;
using MySql.Data.MySqlClient;

namespace Invent_coffee;

public partial class MainForm : Form
{
    private connSql conn = new connSql();
    public MainForm()
    {
        InitializeComponent();
        TestDatabaseConnection();
        ShowLoginPage();
    }

    //Check for the database connection
    private void TestDatabaseConnection()
    {
        try
        {
            using (MySqlConnection connection = conn.connectSql())
            {
                connection.Open();
                MessageBox.Show("Connected!");
                connection.Close();
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show("Connection failed: " + ex.Message);
        }
    }

    /*==========================
     Login & Registration
     =========================*/
    public void ShowLoginPage(){
        Main_Panel.Controls.Clear();
        Main_Panel.Controls.Add(new Login_page(this));
    }
    public void ShowRegistrationPage()
    {
        Main_Panel.Controls.Clear();
        Main_Panel.Controls.Add(new Registration_page(this));
    }
    /*==========================
     Admin
     =========================*/
    public void ShowAdminPage(){
        Main_Panel.Controls.Clear();
        Main_Panel.Controls.Add(new Admin_page(this));
    }
    
    public void ShowInventoryPage()
    {
        Main_Panel.Controls.Clear();
        Main_Panel.Controls.Add(new Inventory_page(this));
    }
    //inventory panels
    public void ShowAddProductPage(){
        Main_Panel.Controls.Clear();
        Main_Panel.Controls.Add(new AddProduct_page(this));
    }

    public void ShowEditProductPage(int id){
        Main_Panel.Controls.Clear();
        Main_Panel.Controls.Add(new EditProduct_page(this, id));
    }

    /*==========================
     User
     =========================*/
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
} 


