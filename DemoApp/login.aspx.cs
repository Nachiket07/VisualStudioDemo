using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySql.Data.MySqlClient;
using System.Data;
namespace DemoApp
{
    MySqlConnection conn = new MySqlConnection(@"Data Source=localhost;port=3306;Initial Catlog=demo ;User Id=root;password='' ");
    public partial class login : System.Web.UI.Page
    {
        
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void Login(object sender, EventArgs e)
        {

        }
    }
}