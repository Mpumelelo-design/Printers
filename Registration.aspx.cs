using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.Sql;
using System.Data.SqlTypes;
using System.Data.SqlClient;

namespace CompanyPrinters
{
    public partial class Registation : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Register_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=localhost; Initial Catalog=Company_Printers2;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into Users1(FirstName, LastName, DesignationID, Email, UserName, Password, Address, DOB) values( @FirstName, @LastName, @DesignationID, @Email, @UserName, @Password, @Address, @DOB)", con);
            cmd.Parameters.AddWithValue("@FirstName", U_fname.Text);
            cmd.Parameters.AddWithValue("@LastName", U_lname.Text);
            cmd.Parameters.AddWithValue("@DesignationID", U_designstion.Text);
            cmd.Parameters.AddWithValue("@Email", U_EMAIL.Text);
            cmd.Parameters.AddWithValue("@UserName", U_fname.Text + U_lname.Text);
            cmd.Parameters.AddWithValue("@Password", U_password.Text);
            cmd.Parameters.AddWithValue("@Address", U_address.Text);
            cmd.Parameters.AddWithValue("@DOB", U_birthday.Text);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                ClientScript.RegisterStartupScript(Page.GetType(), "validation", " < script language = 'javascript' > alert('Wlecome New User') </ script > ");
                Response.Redirect("LogIn.aspx");
            }
            else
            {
                ClientScript.RegisterStartupScript(Page.GetType(), "validation", "<script language='javascript'>alert('User Successfully Registered')</script>");
                Response.Redirect("Users.aspx");

            }
        }
    }
}