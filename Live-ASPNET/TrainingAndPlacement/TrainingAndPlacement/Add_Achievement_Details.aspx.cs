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
    public partial class Add_Achievement_Details : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["myConnectionString"].ConnectionString);
        SqlCommand cmd = new SqlCommand();
        bel_Student bel = new bel_Student();
        bal_Student bal = new bal_Student();
       
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Student_Id"] != null)
            {
                txtstudentID.Text = Session["Student_Id"].ToString();
            }
            else
            {
                logout();
            }
            if (!Page.IsPostBack)
            {

                bind_AchievementTitle();
            }
        }
        protected void bind_AchievementTitle()
        {

            //bel.bel_id = txtstudentID.Text;
            //DataTable dT = bal.bind_AchievementTitle(bel);

            cmd = new SqlCommand("Sp_Add_Achievement_Details", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@flag", 2);
            cmd.Parameters.AddWithValue("@studentID", txtstudentID.Text);
            DataTable dt = new DataTable();
            SqlDataAdapter adp1 = new SqlDataAdapter(cmd);
            adp1.Fill(dt);
            ddlAchievementTitle.DataSource = dt;
            ddlAchievementTitle.DataTextField = "Achievement_Title";
            ddlAchievementTitle.DataValueField = "Achievement_Title";
            ddlAchievementTitle.DataBind();
            ddlAchievementTitle.Items.Insert(0, new ListItem("---Select----", string.Empty));

            gvAchievementDetails.DataSource = dt;
            gvAchievementDetails.DataBind();
        }
        protected void btnsave_Click(object sender, EventArgs e)
        {
            try
            {
                string str = "select count(*) from Add_Achievement where studentID='" + txtstudentID.Text + "'and  Achievement_Title='" + ddlAchievementTitle.SelectedValue + "'";
                SqlCommand cmd = new SqlCommand(str, con);
                con.Open();
                int count = (int)cmd.ExecuteScalar();
                con.Close();
                if (count <= 0)
                {
                    insert();
                }
                else
                {
                    update();
                }
                bind_AchievementTitle();
            }

            catch (Exception ex)
            {
                Response.Write("Oops! error occured :" + ex.Message.ToString());
            }
            finally
            {
                bal = null;
                bel = null;
            }

        }
        protected void insert()
        {
            try
            {
                if (txtAchievement_Title.Text == "&nbsp;" || txtAchievement_Title.Text == "" || txtAchievement_Title.Text == string.Empty)
                {
                    string script = "alert(\"Please select Achievement_Title, PLease Retry!\");"; ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
                }
                else if (txtAchievement_Details.Text == "&nbsp;" || txtAchievement_Details.Text == "" || txtAchievement_Details.Text == string.Empty)
                {
                    string script = "alert(\"Please select Achievement_Details, PLease Retry!\");"; ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
                }
                else if (txtDescription.Text == "&nbsp;" || txtDescription.Text == "" || txtDescription.Text == string.Empty)
                {
                    string script = "alert(\"Please select Description, PLease Retry!\");"; ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
                }
                else
                {


                    bel.bel_id = txtstudentID.Text;
                    bel.bel_Achievement_Title = txtAchievement_Title.Text;
                    bel.bel_Achievement_Details = txtAchievement_Details.Text;
                    bel.bel_Description = txtDescription.Text;

                    int retVal = bal.Add_Achievment(bel);

                    if (retVal > 0)
                    {
                        string script = "alert(\"Achievement  Details Add successfully !\");"; ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
                    }
                    else
                    {
                        string script = "alert(\"Achievement Details  couldn't be Saved, PLease Retry!\");"; ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
                    }

                    con.Close();

                }
            }

            catch (Exception ex)
            {
                Response.Write("Oops! error occured :" + ex.Message.ToString());
            }
        }
        protected void update()
        {
            try
            {
                bel.bel_id = txtstudentID.Text;
                bel.bel_Achievement_Title = txtAchievement_Title.Text;
                bel.bel_Achievement_Details = txtAchievement_Details.Text;
                bel.bel_Description = txtDescription.Text;
                try
                {
                    int retVal = bal.Update_Achievment(bel);
                    if (retVal > 0)
                    {
                        clear();
                        string script = "alert(\"Achievement Details updated Successfully!\");"; ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);

                    }
                    else
                    {
                        string script = "alert(\"Achievement Details couldn't be  updated!\");"; ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);

                    }
                }
                catch (Exception ex)
                {
                    Response.Write("Oops! error occured :" + ex.Message.ToString());
                }
                finally
                {
                    bal = null;
                    bel = null;
                }
            }
            catch (Exception ex)
            {
                Response.Write("Oops! error occured :" + ex.Message.ToString());
            }
        }

        protected void btnclear_Click(object sender, EventArgs e)
        {
            clear();
        }
        protected void clear()
        {
            try
            {
                txtAchievement_Details.Text = "";
                txtDescription.Text = "";
            }
            catch (Exception ex)
            {
                Response.Write("Oops! error occured :" + ex.Message.ToString());
            }
        }

        protected void btnsearch_Click(object sender, EventArgs e)
        {
            search();
        }


        protected void search()
        {

            try
            {
                if (txtstudentID.Text == "")
                {
                    string script = "alert(\"Please select studentID, PLease Retry!\");"; ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
                }
                else
                {
                    DataTable dT = new DataTable();
                    bel.bel_id = txtstudentID.Text;
                    bel.bel_Achievement_Title = ddlAchievementTitle.SelectedItem.Text;
                    dT = bal.Bind_gvAchievementDetails(bel);
                    gvAchievementDetails.DataSource = dT;
                    gvAchievementDetails.DataBind();
                    if (dT.Rows.Count > 0)
                    {

                        txtAchievement_Title.Text = dT.Rows[0][2].ToString();
                        txtAchievement_Details.Text = dT.Rows[0][3].ToString();
                        txtDescription.Text = dT.Rows[0][4].ToString();
                    }

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
    }
}




