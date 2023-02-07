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
using System.Configuration;
using System.IO;
using System.Text;
using System.Collections;

namespace CompanyPrinters
{
    public partial class AdminPage : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                DataTable tt = this.BindMenuData(0);
                DynamicMenuControlPopulation(tt, 0, null);
            }

            BindGrid();

            //SqlConnection con = new SqlConnection(@"Data Source=localhost; Initial Catalog=Company_Printers2;Integrated Security=True");
            //con.Open();
            //SqlCommand cmd = new SqlCommand("select FirstName, LastName, DesignationID, Email, UserName, Password, Address, DOB from Users1", con);
            //SqlDataReader reader = cmd.ExecuteReader();
            //Grid_Users.DataSource = reader;
            //Grid_Users.DataBind();

        }

        protected void btnCreate_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=localhost; Initial Catalog=Company_Printers2;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into Users1(FirstName, LastName, DesignationID, Email, UserName, Password, Address, DOB) values(@FirstName, @LastName, @DesignationID, @Email, @UserName, @Password, @Address, @DOB)", con);
            cmd.Parameters.AddWithValue("@FirstName", FirstName.Text);
            cmd.Parameters.AddWithValue("@LastName", LastName.Text);
            cmd.Parameters.AddWithValue("@DesignationID", txtDesignation.Text);
            cmd.Parameters.AddWithValue("@Email", Email.Text);
            cmd.Parameters.AddWithValue("@UserName", FirstName.Text + LastName.Text);
            cmd.Parameters.AddWithValue("@Password", Password.Text);
            cmd.Parameters.AddWithValue("@Address", txtAddress.Text);
            cmd.Parameters.AddWithValue("@DOB", DOB.Text);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                ClientScript.RegisterStartupScript(Page.GetType(), "validation", " < script language = 'javascript' > alert('User Not Registered') </ script > ");
                Response.Redirect("Registration.aspx");
            }
            else
            {
                ClientScript.RegisterStartupScript(Page.GetType(), "validation", "<script language='javascript'>alert('User Successfully Registered')</script>");
                

            }

        }

        private void BindGrid()
        {
            SqlConnection con = new SqlConnection(@"Data Source=localhost; Initial Catalog=Company_Printers2;Integrated Security=True");
            con.Open();
            string query = "select FirstName, LastName, DesignationID, Email, UserName, Password, Address, DOB from Users1";
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            Grid_Users.DataSource = dt;
            Grid_Users.DataBind();
        }

            private void DeleteRecord(string SelectedID)
            {

               SqlConnection con = new SqlConnection(@"Data Source=localhost; Initial Catalog=Company_Printers2;Integrated Security=True");
               con.Open();
               SqlCommand cmd = new SqlCommand("delete from Users1 where UserID = @UserID)", con);
               cmd.Parameters.AddWithValue("@UserID", SelectedID);
               cmd.ExecuteNonQuery();
                con.Close();
         }

        private void SelectRecords()
        {
            int currentSelectedRec = 0;
            CheckBox chkAll = (CheckBox)Grid_Users.HeaderRow.Cells[0].FindControl("chkAll");
            chkAll.Checked = true;
            ArrayList arr = (ArrayList)ViewState["RecordsToBeDeleted"];
            for (int i = 0; i < Grid_Users.Rows.Count; i++)
            {
                CheckBox chk = (CheckBox)Grid_Users.Rows[i].Cells[0].FindControl("chk");
                if (chk != null)
                {
                    chk.Checked = arr.Contains(Grid_Users.DataKeys[i].Value);
                    if (!chk.Checked)
                    {
                        chkAll.Checked = false;
                    }
                    else
                    {
                        currentSelectedRec++;
                    }
                }
            }
            hdncnt.Value = (arr.Count - currentSelectedRec).ToString();
        }
        protected void OnPaging(object sender, GridViewPageEventArgs e)
        {
            Grid_Users.PageIndex = e.NewPageIndex;
            Grid_Users.DataBind();
            SelectRecords();
        }
        private void alertmsg(int SelectedReccount)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("<script type = 'text/javascript'>");
            sb.Append("alert('");
            sb.Append(SelectedReccount.ToString() + "  " + "   ");
            sb.Append("Records are  deleted.');");
            sb.Append("</script>");
            ClientScript.RegisterStartupScript(this.GetType(), "script", sb.ToString());
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            int count = 0;
            SelectRecords();
            Grid_Users.AllowPaging = false;
            Grid_Users.DataBind();
            ArrayList arr = (ArrayList)ViewState["RecordsToBeDeleted"];
            count = arr.Count;

            for (int i = 0; i < Grid_Users.Rows.Count; i++)
            {
                if (arr.Contains(Grid_Users.DataKeys[i].Value))
                {
                    DeleteRecord(Grid_Users.DataKeys[i].Value.ToString());
                    arr.Remove(Grid_Users.DataKeys[i].Value);
                }
            }
            ViewState["RecordsToBeDeleted"] = arr;
            hdncnt.Value = "0";
            Grid_Users.AllowPaging = true;
            BindGrid();
            alertmsg(count);
        }



        protected DataTable BindMenuData(int parentmenuId)
        {
            DataSet set = new DataSet();
            DataTable dt;
            DataRow dr;
            DataColumn menu;
            DataColumn pMenu;
            DataColumn title;
            DataColumn description;
            DataColumn URL;

            dt = new DataTable();

            menu = new DataColumn("MenuId", Type.GetType("System.Int32"));
            pMenu = new DataColumn("ParentId", Type.GetType("System.Int32"));
            title = new DataColumn("Title", Type.GetType("System.String"));
            description = new DataColumn("Description", Type.GetType("System.String"));
            URL = new DataColumn("URL", Type.GetType("System.String"));

            dt.Columns.Add(menu);
            dt.Columns.Add(pMenu);
            dt.Columns.Add(title);
            dt.Columns.Add(description);
            dt.Columns.Add(URL);

            dr = dt.NewRow();
            dr["MenuId"] = 1;
            dr["ParentId"] = 0;
            dr["Title"] = "Home";
            dr["Description"] = "";
            dr["URL"] = "~/Default.aspx";
            dt.Rows.Add(dr);

            dr = dt.NewRow();
            dr["MenuId"] = 2;
            dr["ParentId"] = 0;
            dr["Title"] = "Printers";
            dr["Description"] = "";
            dr["URL"] = "~/Printers.aspx";
            dt.Rows.Add(dr);

            dr = dt.NewRow();
            dr["MenuId"] = 3;
            dr["ParentId"] = 0;
            dr["Title"] = "Designations";
            dr["Description"] = "";
            dr["URL"] = "~/Designations.aspx";
            dt.Rows.Add(dr);

            set.Tables.Add(dt);
            var dv = set.Tables[0].DefaultView;
            dv.RowFilter = "ParentId='" + parentmenuId + "'";
            DataSet ds1 = new DataSet();
            var newdt = dv.ToTable();
            return newdt;
        }

        protected void DynamicMenuControlPopulation(DataTable dt, int parentMenuId, MenuItem parentMenuItem)
        {

            string currentPage = Path.GetFileName(Request.Url.AbsolutePath);
            foreach (DataRow row in dt.Rows)
            {
                MenuItem menuItem = new MenuItem
                {
                    Value = row["MenuId"].ToString(),
                    Text = row["Title"].ToString(),
                    NavigateUrl = row["URL"].ToString(),
                    Selected = row["URL"].ToString().EndsWith(currentPage, StringComparison.CurrentCultureIgnoreCase)
                };
                if (parentMenuId == 0)
                {
                    Menu1.Items.Add(menuItem);
                    DataTable dtChild = this.BindMenuData(int.Parse(menuItem.Value));
                    DynamicMenuControlPopulation(dtChild, int.Parse(menuItem.Value), menuItem);
                }
                else
                {

                    parentMenuItem.ChildItems.Add(menuItem);
                    DataTable dtChild = this.BindMenuData(int.Parse(menuItem.Value));
                    DynamicMenuControlPopulation(dtChild, int.Parse(menuItem.Value), menuItem);

                }
            }

        }

       
    }        
}