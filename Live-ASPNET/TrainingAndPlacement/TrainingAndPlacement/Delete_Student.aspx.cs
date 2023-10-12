using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Net.Mail;
using System.Net;
using System.Data;
using BAL;
using BEL;
using System.Configuration;
namespace TrainingAndPlacement
{
    public partial class Delete_Student : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myConnectionString"].ConnectionString);
        bal_message bal_msg = new bal_message();
        bel_message bel_msg = new bel_message();
        bal_Student bal_mem = new bal_Student();
        bel_Student bel_mem = new bel_Student();
        bal_Dept bal = new bal_Dept();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                all_regi_mem();

                bind_Department();
            }
        }
        protected void bind_Department()
        {
            {
                DataSet ds = bal.gvDepartment_Bind();
                ddlCourse.DataSource = ds;
                ddlCourse.DataTextField = "Department";
                ddlCourse.DataValueField = "Id";
                ddlCourse.DataBind();
                ddlCourse.Items.Insert(0, new ListItem("---Select----", string.Empty));
            }
        }
        protected void all_regi_mem()
        {
            try
            {
                DataSet dtbl = bal_mem.selectAll(); //bind table
                gvStudent.DataSource = dtbl;
                gvStudent.DataBind();
            }
            catch (Exception ex)
            {
                Response.Write("Oops! error occured :" + ex.Message.ToString());
            }
        }
        protected void Search_Click(object sender, EventArgs e)
        {
            try
            {

                if (ddlAcademic.SelectedIndex == 0)
                {
                    string script = "alert(\"Please Select Academic Year!\");"; ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
                }
                else if (ddlCourse.SelectedIndex == 0)
                {
                    string script = "alert(\"Please Select Course!\");"; ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
                }
                else 
                {
                    bel_mem.bel_Academic_Year = ddlAcademic.SelectedItem.Text;
                    bel_mem.bel_Course_Name = ddlCourse.SelectedValue;
                    DataSet ds = bal_mem.bindStudent_Year_Dept_wise(bel_mem);
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        gvStudent.DataSource = ds;
                        gvStudent.DataBind();
                    }
                    else
                    {
                        string script = "alert(\"Student not available!\");"; ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
                    }
                }
            }
            catch (Exception ex)
            {
                Response.Write("Oops! error occured :" + ex.Message.ToString());
            }
        }
        protected void chkBxSelect__CheckedChanged(object sender, EventArgs e)
        {

        }
        protected void btnDelete_Click(object sender, EventArgs e)
        {

            try
            {

                if (gvStudent.Rows.Count > 0)
                {
                    int i = 1, j = 1;
                    foreach (GridViewRow item in gvStudent.Rows)
                    {

                        if (item.RowType == DataControlRowType.DataRow)
                        {
                            CheckBox chkRow = (item.Cells[0].FindControl("chkBxSelect") as CheckBox);
                           try
                            {
                                if (chkRow.Checked)
                                {
                                   if (item.Cells[4].Text != "" && item.Cells[4].Text != "&nbsp;" && item.Cells[4].Text != null)
                                    {
                                       con.Open();
                                       string str = "Select count(*) from Student_Applied_Drive where Student_ID= '" + item.Cells[1].Text + "'";
                                        SqlCommand cmd = new SqlCommand(str, con);
                                        int count = (int)cmd.ExecuteScalar();
                                        con.Close();
                                        if (count == 0)
                                        {
                                            SqlCommand cmd1 = new SqlCommand("Delete_Student_Details ", con);
                                            cmd1.CommandType = CommandType.StoredProcedure;
                                            cmd1.Parameters.AddWithValue("@flag", 1);
                                            cmd1.Parameters.AddWithValue("@username", item.Cells[4].Text);

                                            if (con.State == ConnectionState.Closed)
                                            {
                                                con.Open();
                                            }

                                            int result = cmd1.ExecuteNonQuery();
                                            cmd1.Dispose();

                                            if (result == 0)
                                            {
                                                string script = "alert(\"Student Not Deleted!\");"; ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
                                            }
                                        }
                                        else
                                        {
                                            string script = "alert(\"Student Already Applied Drive!\");"; ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
                                        }
                                    }
                                }
                            }
                            catch (Exception ex)
                            {
                                Response.Write("Oops! error occured :" + ex.Message.ToString());
                            }
                        }
                    }
                }
                else
                {
                    string script = "alert(\"Record Not Available!\");"; ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
                }
                con.Close();
                all_regi_mem();
                string script1 = "alert(\"Student Deleted Succefully!\");"; ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script1, true);

                Session["CheckRefresh"] = Server.UrlDecode(System.DateTime.Now.ToString());
            }
            catch (Exception ex)
            {
                Response.Write("Oops! error occured :" + ex.Message.ToString());
            }


        }
        protected void gvStudent_RowCreated(object sender, GridViewRowEventArgs e)
        {

            if (e.Row.RowType == DataControlRowType.DataRow && (e.Row.RowState == DataControlRowState.Normal || e.Row.RowState == DataControlRowState.Alternate))
            {
                CheckBox chkBxSelect = (CheckBox)e.Row.Cells[1].FindControl("chkBxSelect");
                CheckBox chkBxHeader = (CheckBox)this.gvStudent.HeaderRow.FindControl("chkBxHeader");
                chkBxSelect.Attributes["onclick"] = string.Format("javascript:ChildClick(this,'{0}');", chkBxHeader.ClientID);
            }
        }
        protected void btnShow_All_Click(object sender, EventArgs e)
        {
            try
            {
                DataSet ds = bal_mem.selectAll();
                gvStudent.DataSource = ds;
                gvStudent.DataBind();

            }
            catch (Exception ex)
            {
                Response.Write("Oops! error occured :" + ex.Message.ToString());
            }
        }
    }
}