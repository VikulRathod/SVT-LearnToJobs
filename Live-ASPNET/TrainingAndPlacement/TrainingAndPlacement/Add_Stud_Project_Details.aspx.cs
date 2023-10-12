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
using System.Text.RegularExpressions;
using System.Net.Mail;
using System.Net;
using BAL;
using BEL;
namespace TrainingAndPlacement
{
    public partial class Add_Stud_Project_Details : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["myConnectionString"].ConnectionString);
        SqlCommand cmd = new SqlCommand();
        string status = "Active";
        bal_Student bal_mem = new bal_Student();
        bel_Student bel_mem = new bel_Student();
        bal_Institute bal_cp = new bal_Institute();
        bel_login login = new bel_login();
        bal_login bal_login = new bal_login();
        DataSet ds = new DataSet();
        DataSet dT = new DataSet();
        DateTime date = DateTime.Now.AddYears(-2);

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Student_Id"] != null)
            {
                txtStud_id.Text = Session["Student_Id"].ToString();
                if (!Page.IsPostBack)
                {
                    bind_ProjectTitle();
                }
            }
            else
            {
                logout();
            }
        }

        protected void bind_ProjectTitle()
        {

            //bel_mem.bel_id = txtStud_id.Text;
            //DataTable dt = bal_mem.bind_ProjectTitle(bel_mem);
            cmd = new SqlCommand("Student_add_update", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Stud_id", txtStud_id.Text);
            cmd.Parameters.AddWithValue("@flag", 8);
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);
            ddlProjectTitle.DataSource = dt;
            ddlProjectTitle.DataTextField = "Project_Title";
            ddlProjectTitle.DataValueField = "Project_Title";
            ddlProjectTitle.DataBind();
            ddlProjectTitle.Items.Insert(0, new ListItem("---Select----", string.Empty));

            gvProject_Details.DataSource = dt;

            gvProject_Details.DataBind();
        }
        protected void btnsave_Click(object sender, EventArgs e)
        {
            try
            {
                string str = "select count(*) from Stud_Project_Details where Student_ID='" + txtStud_id.Text + "' and Project_Title='" + ddlProjectTitle.SelectedValue + "'";
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
                bind_ProjectTitle();
            }

            catch (Exception ex)
            {
                Response.Write("Oops! error occured :" + ex.Message.ToString());
            }
        }

        protected void insert()
        {
            try
            {
                if (txtProject_Type.Text == "")
                {
                    string script = "alert(\"Please Enter Project Type!\");"; ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
                }
                else
                {
                    //package_id1();
                    // passwords = password(8);
                    // userid = Session["login_id"].ToString();        // Received login ID
                    //package_save();

                    try
                    {

                        bel_mem.bel_id = txtStud_id.Text;
                        bel_mem.bel_Project_Type = txtProject_Type.Text;
                        bel_mem.bel_Project_Title = txtProject_Title.Text;
                        bel_mem.bel_Project_Domain = txtProject_Domain.Text;
                        bel_mem.bel_Project_Duration = txtProject_Duration.Text;
                        bel_mem.bel_Technologies = txtTechnologies.Text;
                        bel_mem.bel_Team_Size = txtTeam_Size.Text;
                        bel_mem.bel_Guide_Name = txtGuide_Name.Text;
                        bel_mem.bel_Description = txtDescription.Text;
                        int retVal = bal_mem.add_Project(bel_mem);
                        // login_insert();
                        if (retVal > 0)
                        {
                            string script = "alert(\"Project Details Add Successfully!\");"; ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
                        }
                        else
                        {
                            string script = "alert(\"Project details couldn't be Added!\");"; ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
                        }

                    }
                    catch (Exception ex)
                    {
                        Response.Write("Oops! error occured :" + ex.Message.ToString());
                    }
                    finally
                    {
                        bal_mem = null;
                        bel_mem = null;
                    }
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

                bel_mem.bel_id = txtStud_id.Text;
                bel_mem.bel_Project_Type = txtProject_Type.Text;
                bel_mem.bel_Project_Title = txtProject_Title.Text;
                bel_mem.bel_Project_Domain = txtProject_Domain.Text;
                bel_mem.bel_Project_Duration = txtProject_Duration.Text;
                bel_mem.bel_Technologies = txtTechnologies.Text;
                bel_mem.bel_Team_Size = txtTeam_Size.Text;
                bel_mem.bel_Guide_Name = txtGuide_Name.Text;
                bel_mem.bel_Description = txtDescription.Text;
                try
                {
                    int retVal = bal_mem.update_Project(bel_mem);
                    if (retVal > 0)
                    {
                        string script = "alert(\"Project Details Successfully Updated!\");"; ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);

                    }
                    else
                    {
                        string script = "alert(\"Project details couldn't be updated!\");"; ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
                    }
                }
                catch (Exception ex)
                {
                    Response.Write("Oops! error occured :" + ex.Message.ToString());
                }
                finally
                {
                    bal_mem = null;
                    bel_mem = null;
                }
            }
            catch (Exception ex)
            {
                Response.Write("Oops! error occured :" + ex.Message.ToString());
            }
        }

        protected void btnsearch_Click(object sender, EventArgs e)
        {

            try
            {
                if (ddlProjectTitle.SelectedItem.Text == "")
                {
                    string script = "alert(\"Please Select Project Title !\");"; ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
                }
                else
                {
                    DataTable dT = new DataTable();
                    bel_mem.bel_id = txtStud_id.Text;
                    bel_mem.bel_Project_Title = ddlProjectTitle.SelectedItem.Text;
                    dT = bal_mem.Bind_gvProject_Details(bel_mem);
                    gvProject_Details.DataSource = dT;
                    gvProject_Details.DataBind();
                    if (dT.Rows.Count > 0)
                    {
                        txtStud_id.Text = dT.Rows[0][1].ToString();
                        txtProject_Type.Text = dT.Rows[0][2].ToString();
                        txtProject_Title.Text = dT.Rows[0][3].ToString();
                        txtProject_Domain.Text = dT.Rows[0][4].ToString();
                        txtProject_Duration.Text = dT.Rows[0][5].ToString();
                        txtTechnologies.Text = dT.Rows[0][6].ToString();
                        txtTeam_Size.Text = dT.Rows[0][7].ToString();
                        txtGuide_Name.Text = dT.Rows[0][8].ToString();
                        txtDescription.Text = dT.Rows[0][9].ToString();
                    }
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
                txtStud_id.Text = "";
                txtProject_Type.Text = "";
                txtProject_Title.Text = "";
                txtProject_Domain.Text = "";
                txtProject_Duration.Text = "";
                txtTechnologies.Text = "";
                txtTeam_Size.Text = "";
                txtGuide_Name.Text = "";
                txtDescription.Text = "";

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