using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data.SqlTypes;

namespace CompanyPrinters
{
    public partial class Designations : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=localhost; Initial Catalog=Company_Printers2;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from Designations", con);
            SqlDataReader reader = cmd.ExecuteReader();
            Grid_Designations.DataSource = reader;
            Grid_Designations.DataBind();
        }
    }
}