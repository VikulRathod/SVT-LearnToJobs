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
using BEL;
using BAL;
namespace TrainingAndPlacement
{
    public partial class HOD : System.Web.UI.MasterPage
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myConnectionString"].ConnectionString);
        SqlCommand cmd = new SqlCommand();

        bel_login bel_login = new bel_login();
        bal_login bal_login = new bal_login();
        bal_emp_regi bal_er = new bal_emp_regi();
        bel_emp_regi bel_er = new bel_emp_regi();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["login_id"] != null)
            {
                if (Session["User"] != null)
                {
                    if (Session["User"].ToString() == "HOD")
                    {
                        Coordinator_back.Visible = false;
                    }
                    else
                    {
                        logout();
                    }
                }
                else
                {
                    logout();
                }
                id_details();
            }
            else
            {
                logout();
            }
        }
        protected void id_details()
        {
            try
            {
                if (Session["login_id"] != null)
                {
                    SqlDataAdapter da = new SqlDataAdapter("Select * from emp_regi where email='" + Session["login_id"].ToString() + "'", con);
                    DataSet ds = new DataSet();
                    da.Fill(ds);
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        txtname.Text = ds.Tables[0].Rows[0][1].ToString() + " " + ds.Tables[0].Rows[0][3].ToString();
                        txtname1.Text = ds.Tables[0].Rows[0][1].ToString() + " " + ds.Tables[0].Rows[0][3].ToString();
                        Session["HOD_Id"] = ds.Tables[0].Rows[0][0].ToString();
                        Session["HOD_Department"] = ds.Tables[0].Rows[0][16].ToString();
                        //Select Image


                        //if (ds1.Tables[0].Rows.Count > 0)
                        //{
                        //    img.ImageUrl = ds1.Tables[0].Rows[0]["UserImagepath"].ToString();
                        //    Img1.ImageUrl = ds1.Tables[0].Rows[0]["UserImagepath"].ToString();
                        //    // Assiging image to Image Control
                        //}
                    }
                }
                else
                {
                    logout();
                }
            }
            catch (Exception ex)
            {
                Response.Write("Oops! error occured :" + ex.Message.ToString());
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

        protected void btnpswd_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                string str = "Select count(*) from Placement_Login where username= '" + Session["login_id"].ToString() + "' AND login_password='" + txtold_pwd.Text + "'";
                cmd = new SqlCommand(str, con);
                int count = (int)cmd.ExecuteScalar();
                con.Close();
                if (count > 0)
                {
                    txterror.Text = "";

                    bel_login.bel_username = Session["login_id"].ToString();
                    bel_login.bel_old = txtold_pwd.Text.Trim();
                    bel_login.bel_password = txtre_pwd.Text.Trim();
                    int login = bal_login.login_update(bel_login);

                    txtre_pwd.Text = "";
                    txtold_pwd.Text = "";
                    txtre_pwd.Text = "";
                    string script = "alert(\"Successfully Changing Admin password!\");"; ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
                }
                else
                {
                    txterror.Text = "  Please Check Correct User Id / Old Password";
                }
            }
            catch (Exception ex)
            {
                Response.Write("Oops! error occured :" + ex.Message.ToString());
            }
        }
        protected void Coordinator_back_Click(object sender, EventArgs e)
        {
            if (Session["User"] != null)
            {
                if (Session["User"].ToString() == "Admin")
                {
                    Response.Redirect("~/Admin_Home.aspx");
                }
                else if (Session["User"].ToString() == "Principal_Home")
                {
                    Response.Redirect("~/Admin_Home.aspx");
                }
                else
                {
                    logout();
                }
            }
            else
            {
                logout();
            }
        }
        protected void Coordinator_logout_Click(object sender, EventArgs e)
        {
            logout();
        }
    }
}