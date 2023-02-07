using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;


namespace CompanyPrinters
{
    public partial class Users : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=localhost; Initial Catalog=Company_Printers2;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("select FirstName, LastName, DesignationID, Email, UserName, Password, Address, DOB from Users1", con);
            SqlDataReader reader = cmd.ExecuteReader();
            Grid_Users.DataSource = reader;
            Grid_Users.DataBind();
        }
    }
}