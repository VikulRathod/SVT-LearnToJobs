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
    public partial class Add_Technical_Details : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["myConnectionString"].ConnectionString);
        SqlCommand cmd = new SqlCommand();
        bel_Student bel = new bel_Student();
        bal_Student bal = new bal_Student();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Student_Id"] != null)
            {
                txtstuID.Text = Session["Student_Id"].ToString();
                if (!Page.IsPostBack)
                {
                    bind_CourseTitle();
                }
            }
            else
            {
                logout();
            }
        }
        protected void bind_CourseTitle()
        {
            {
                //bel.bel_id = txtstuID.Text;
                //DataTable dT = bal.bind_CourseTitle(bel);
                cmd = new SqlCommand("Sp_Add_Technical_Details", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@stuID", txtstuID.Text);
                cmd.Parameters.AddWithValue("@flag", 2);
                DataTable dt = new DataTable();
                SqlDataAdapter adp1 = new SqlDataAdapter(cmd);
                adp1.Fill(dt);
                ddlCourseTitle.DataSource = dt;
                ddlCourseTitle.DataTextField = "Course_Title";
                ddlCourseTitle.DataValueField = "Course_Title";
                ddlCourseTitle.DataBind();
                ddlCourseTitle.Items.Insert(0, new ListItem("---Select----", string.Empty));

                gvTechnicalDetails.DataSource = dt;
                gvTechnicalDetails.DataBind();
            }
        }
       


        protected void btnsave_Click(object sender, EventArgs e)
        {
              try
            {
                string str = "select count(*) from Add_Technical_Deatils where stuID='" + txtstuID.Text + "' and Course_Title='" + ddlCourseTitle.SelectedValue + "'";
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
                bind_CourseTitle();
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
                if (txtCourseTitle.Text == "&nbsp;" || txtCourseTitle.Text == "" || txtCourseTitle.Text == string.Empty)
                {
                    string script = "alert(\"Please select CourseTitle, PLease Retry!\");"; ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
                }
                else if (txtTechnical_Details.Text == "&nbsp;" || txtTechnical_Details.Text == "" || txtTechnical_Details.Text == string.Empty)
                {
                    string script = "alert(\"Please select Technical_Details, PLease Retry!\");"; ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
                }
                else if (txtDescription.Text == "&nbsp;" || txtDescription.Text == "" || txtDescription.Text == string.Empty)
                {
                    string script = "alert(\"Please select Description, PLease Retry!\");"; ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
                }
                else
                {
                    bel.bel_id = txtstuID.Text;
                    bel.bel_Course_Name = txtCourseTitle.Text;
                    bel.bel_Technical_Details = txtTechnical_Details.Text;
                    bel.bel_Description = txtDescription.Text;

                    int retVal = bal.Add_Technical(bel);

                    if (retVal > 0)
                    {
                        clear();
                        string script = "alert(\"  Technical Details Add successfully !\");"; ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
                    }
                    else
                    {
                        string script = "alert(\"Technical Details  couldn't be Saved, PLease Retry!\");"; ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
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
                    bel.bel_id = txtstuID.Text;
                    bel.bel_Course_Name = txtCourseTitle.Text;
                    bel.bel_Technical_Details = txtTechnical_Details.Text;
                    bel.bel_Description = txtDescription.Text;
                   
                try
                {
                    int retVal = bal.update_Technical(bel);
                    if (retVal > 0)
                    {
                        clear();
                        string script = "alert(\"Technical Details updated Successfully!\");"; ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
                      
                    }
                    else
                    {
                        string script = "alert(\"Technical Details couldn't be  updated!\");"; ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
                        
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

                
                txtTechnical_Details.Text = "";
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
                if (txtstuID.Text == "")
                {
                    string script = "alert(\"Please select studentID, PLease Retry!\");"; ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
                }
                else
                {

                        DataTable dT = new DataTable();
                        bel.bel_id = txtstuID.Text;
                        bel.bel_Course_Name = ddlCourseTitle.SelectedItem.Text;
                        dT = bal.Bind_gvTechnicalDetails(bel);
                        gvTechnicalDetails.DataSource = dT;
                        gvTechnicalDetails.DataBind();
                        if (dT.Rows.Count > 0)
                        {
                            txtCourseTitle.Text = dT.Rows[0][2].ToString();
                            txtTechnical_Details.Text = dT.Rows[0][3].ToString();
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
