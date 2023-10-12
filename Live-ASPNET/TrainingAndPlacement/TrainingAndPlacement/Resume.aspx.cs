using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.IO;
using System.Web.Services;
using System.Data.SqlClient;
using System.Globalization;
using System.Configuration;
using BEL;
using BAL;
namespace TrainingAndPlacement
{
    public partial class Resume : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["myConnectionString"].ConnectionString);
        SqlCommand cmd = new SqlCommand();
        bel_Student bel = new bel_Student();
        bal_Student bal = new bal_Student();
        string txtstudentID;
        protected void Page_Load(object sender, EventArgs e)
        {

            if (Session["Student_Id"] != null)
            {
                txtstudentID = Session["Student_Id"].ToString();
            }
            else
            {
                logout();
            }
            if (!Page.IsPostBack)
            {
                bind_ProjectTitle();
                bind_AchievementTitle();
                bind_ActivityTitle();
                bind_CourseTitle();
                

            }

        }
        protected void bind_ProjectTitle()
        {
            {

                bel.bel_id = txtstudentID;
                DataTable dt = bal.bind_ProjectTitle(bel);
                gvProject_Details.DataSource = dt;
                gvProject_Details.DataBind();
            }
        }
        protected void bind_AchievementTitle()
        {
            {
                
                bel.bel_id = txtstudentID;
                DataTable dT = bal.bind_AchievementTitle(bel);
                gvAchievementDetails.DataSource = dT;
                gvAchievementDetails.DataBind();
            }
        }
        protected void bind_ActivityTitle()
        {
            {

                bel.bel_id = txtstudentID;
                DataTable dT = bal.bind_student_extraActivity(bel);
                gvstudent_extraActivity.DataSource = dT;
                gvstudent_extraActivity.DataBind();
            }
        }
        protected void bind_CourseTitle()
        {
            {

                bel.bel_id = txtstudentID;
                DataTable dT = bal.bind_CourseTitle(bel);
                gvTechnicalDetails.DataSource = dT;
                gvTechnicalDetails.DataBind();
            }
        }
        protected void logout()
        {
            Session.Abandon();
            Session.Clear();
            Session.RemoveAll();
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