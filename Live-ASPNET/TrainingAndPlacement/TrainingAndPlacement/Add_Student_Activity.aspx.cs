using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BAL;
using BEL;

namespace TrainingAndPlacement
{
    public partial class Add_Student_Activity : System.Web.UI.Page
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

                    bind_ActivityTitle();
                }
            }
            else
            {
                logout();
            }
        }
        protected void bind_ActivityTitle()
        {

            //bel.bel_id = txtstuID.Text;
            //DataTable dT = bal.bind_student_extraActivity(bel);

            cmd = new SqlCommand("add_student_extraActivity", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@flag", 2);
            cmd.Parameters.AddWithValue("@Student_id", txtstuID.Text);
            DataTable dt = new DataTable();
            SqlDataAdapter adp1 = new SqlDataAdapter(cmd);
            adp1.Fill(dt);
            ddlActivityTitle.DataSource = dt;
            ddlActivityTitle.DataTextField = "Activity_Title";
            ddlActivityTitle.DataValueField = "Activity_Title";
            ddlActivityTitle.DataBind();
            ddlActivityTitle.Items.Insert(0, new ListItem("---Select----", string.Empty));

            gvstudent_extraActivity.DataSource = dt;
            gvstudent_extraActivity.DataBind();
        }
        protected void btnsave_Click(object sender, EventArgs e)
        {
            try
            {
                string str = "select count(*) from Add_Student_Activity where Student_id='" + txtstuID.Text + "'and  Activity_Title='" + ddlActivityTitle.SelectedValue + "'";
                
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
                bind_ActivityTitle();
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
                if (txtActivityTitle.Text == "&nbsp;" || txtActivityTitle.Text == "" || txtActivityTitle.Text == string.Empty)
                {
                    string script = "alert(\"Please select ActivityTitle, PLease Retry!\");"; ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
                }
                else if (txtActivity_Details.Text == "&nbsp;" || txtActivity_Details.Text == "" || txtActivity_Details.Text == string.Empty)
                {
                    string script = "alert(\"Please select Activity_Details, PLease Retry!\");"; ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
                }
                else if (txtDescription.Text == "&nbsp;" || txtDescription.Text == "" || txtDescription.Text == string.Empty)
                {
                    string script = "alert(\"Please select Description, PLease Retry!\");"; ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
                }
                else
                {
                    bel.bel_id = txtstuID.Text;
                    bel.bel_Title = txtActivityTitle.Text;
                    bel.bel_Details = txtActivity_Details.Text;
                    bel.bel_Description = txtDescription.Text;

                    int retVal = bal.add_student_Activity(bel);

                    if (retVal > 0)
                    {
                        string script = "alert(\"  Activity Details Add successfully !\");"; ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
                    }
                    else
                    {
                        string script = "alert(\"Activity Details  couldn't be Saved, PLease Retry!\");"; ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
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
                bel.bel_Title = txtActivityTitle.Text;
                bel.bel_Details = txtActivity_Details.Text;
                bel.bel_Description = txtDescription.Text;

                try
                {
                    int retVal = bal.Update_student_Activity(bel);
                    if (retVal > 0)
                    {
                        clear();
                        string script = "alert(\"Activity Details updated Successfully!\");"; ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);

                    }
                    else
                    {
                        string script = "alert(\"Activity Details couldn't be  updated!\");"; ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);

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

        //protected void Bind_Activity()
        //{
        //    //try
        //    //{
        //    //    DataSet ds = bal.Bind_student_extraActivity(); //bind table
        //    //    gvStudentActivity.DataSource = ds;
        //    //    gvStudentActivity.DataBind();
        //    //}
        //    //catch (Exception ex)
        //    //{
        //    //    Response.Write("Oops! error occured :" + ex.Message.ToString());
        //    //}
        //}

        protected void btnclear_Click(object sender, EventArgs e)
        {
            clear();
        }
        protected void clear()
        {
            try
            {
                txtActivity_Details.Text = "";
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
                    bel.bel_Title = ddlActivityTitle.SelectedItem.Text;
                    dT = bal.Bind_gvstudent_extraActivity(bel);
                    gvstudent_extraActivity.DataSource = dT;
                    gvstudent_extraActivity.DataBind();
                    if (dT.Rows.Count > 0)
                    {
                        txtActivityTitle.Text = dT.Rows[0][1].ToString();
                        txtActivity_Details.Text = dT.Rows[0][2].ToString();
                        txtDescription.Text = dT.Rows[0][3].ToString();

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