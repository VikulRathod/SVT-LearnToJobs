using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.IO;
using System.Text;
using System.Net.Mail;
using BEL;
using BAL;
namespace TrainingAndPlacement
{
    public partial class Student_place_Drives : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["myConnectionString"].ConnectionString);
        SqlCommand cmd;
        string Member_Id;
        bel_Derive bel = new bel_Derive();
        bal_Student bal = new bal_Student();
        bal_Drive bal_d = new bal_Drive();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Student_Id"] != null && Session["Courses_Id"] != null && Session["Gender"] != null)
            {
                if (!Page.IsPostBack)
                {
                    Bind_Place_Drive();
                }
            }
            else
            {
                logout();
            }
        }
        protected void Bind_Place_Drive()      // Member & Apply Debate ALL Detail View
        {
            try
            {
                SqlCommand cmd = new SqlCommand("Sp_Set_Drive_Criteria", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@flag", 6);
                cmd.Parameters.AddWithValue("@Gender", Session["Gender"].ToString());
                cmd.Parameters.AddWithValue("@Courses_Id", Session["Courses_Id"].ToString());
                cmd.Parameters.AddWithValue("@To_Date", DateTime.Now.ToString("dd/MM/yyyy"));
                DataTable dt = new DataTable();
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                sda.Fill(dt);
                gvplace_Drives.DataSource = dt;
                gvplace_Drives.DataBind();
                if (gvplace_Drives.Rows.Count <= 0)
                {
                    string script = "alert(\"Record Not Available!\");"; ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
                }

            }
            catch (Exception ex)
            {
                Response.Write("Oops! error occured :" + ex.Message.ToString());
            }
        }
        protected void gvplace_Drives_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            gvplace_Drives.PageIndex = e.NewPageIndex;
            Bind_Place_Drive();
        }
        protected void gvplace_Drives_RowCommand(object sender, GridViewCommandEventArgs e)
        {

            if (e.CommandName == "btnShowDrive")
            {
                int index = Convert.ToInt32(e.CommandArgument.ToString());
                Session["Drive"] = gvplace_Drives.Rows[index].Cells[0].Text.Trim();
                Session["Academic"] = gvplace_Drives.Rows[index].Cells[1].Text.Trim();
                Session["Company_ID"] = gvplace_Drives.Rows[index].Cells[2].Text.Trim();

                Response.Redirect("Stu_place_Drives_info.aspx");
            }
            else if (e.CommandName == "btnApply")
            {
                int index = Convert.ToInt32(e.CommandArgument.ToString());
                Session["Drive"] = gvplace_Drives.Rows[index].Cells[0].Text.Trim();
                Session["Academic"] = gvplace_Drives.Rows[index].Cells[1].Text.Trim();
                Session["Company_ID"] = gvplace_Drives.Rows[index].Cells[2].Text.Trim();
                Response.Redirect("Student_Apply_Drive.aspx");
            }
        }
        protected void logout()
        {
            Session.Abandon();
            Session.Clear();
            Session.RemoveAll();
            //Response.Redirect("~/login.aspx");
            //FormsAuthentication.SignOut();
            //Response.Redirect("~/login.aspx");
            if (Request.Cookies["LoginTime"] != null)
            {
                HttpCookie cookie = new HttpCookie("User");

                Response.Cookies.Add(cookie);
                Response.Cookies["LoginTime"].Expires = DateTime.Now.AddDays(-1d);
            }
            Response.Redirect("~/login.aspx");
        }
    }
}