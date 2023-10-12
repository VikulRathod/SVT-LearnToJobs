using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.IO;
using BAL;
using BEL;
using System.Data.SqlClient;
using System.Configuration;
namespace TrainingAndPlacement
{
    public partial class TPO_Registered_Students : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myConnectionString"].ConnectionString);
        bal_Company bal_C = new bal_Company();
        bel_Company bel_C = new bel_Company();
        bal_Student bal = new bal_Student();
        bel_Student bel = new bel_Student();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                bind_All_Company();

            }
        }
        protected void bind_All_Company()
        {
            {

                DataSet ds = bal_C.bind_All_Company(bel_C);
                ddlCompany_ID.DataSource = ds;
                ddlCompany_ID.DataTextField = "company_name";
                ddlCompany_ID.DataValueField = "Company_id";
                ddlCompany_ID.DataBind();
                ddlCompany_ID.Items.Insert(0, new ListItem("Select All", string.Empty));
            }
        }
        protected void ddlCompany_ID_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ddlCompany_ID.SelectedIndex == 0)
            {
                string script = "alert(\"Please Select Company ID !\");"; ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
            }
            else
            {
                SqlCommand cmd = new SqlCommand("SP_Add_Update_Drive", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@flag", 5);
                cmd.Parameters.AddWithValue("@Academic_Year", ddlAcademicYear.SelectedItem.Text);
                cmd.Parameters.AddWithValue("@Company_ID", ddlCompany_ID.SelectedValue);
                cmd.Parameters.AddWithValue("@Reg_To_Date", DateTime.Now.ToString("dd/MM/yyyy"));
                DataTable dT = new DataTable();
                SqlDataAdapter adp1 = new SqlDataAdapter(cmd);
                adp1.Fill(dT);

                ddlDrive.DataSource = dT;
                ddlDrive.DataTextField = "Drive_Title";
                ddlDrive.DataValueField = "Drive_Id";
                ddlDrive.DataBind();

            }
        }

        protected void Search_Click(object sender, EventArgs e)
        {
            try
            {
                if (ddlAcademicYear.SelectedIndex == 0)
                {
                    string script = "alert(\"Please Select Academic Year!\");"; ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
                }
                else if (ddlCompany_ID.SelectedIndex == 0)
                {
                    string script = "alert(\"Please Select Company!\");"; ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
                }
                //else if (ddlDrive.SelectedIndex == 0)
                //{
                //    string script = "alert(\"Please Select Drive!\");"; ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
                //}
                else if (ddlround.SelectedIndex == 0)
                {
                    string script = "alert(\"Please Select Round!\");"; ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
                }
                else
                {
                    bel.bel_Academic_Year = ddlAcademicYear.SelectedItem.Text;
                    bel.bel_Company_ID = ddlCompany_ID.SelectedValue;
                    bel.bel_Drive_Id = ddlDrive.SelectedValue;
                    bel.bel_Round = ddlround.SelectedItem.Text;
                    DataSet ds = bal.bind_Applied_Students_wise(bel);
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
        protected void Approve_Click(object sender, EventArgs e)
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
                            string str = gvStudent.Rows[0].Cells[1].Text;
                            try
                            {
                                if (chkRow.Checked)
                                {

                                    if (item.Cells[3].Text != "" && item.Cells[3].Text != "&nbsp;" && item.Cells[3].Text != null)
                                    {
                                        Session["Send_Email"] += item.Cells[3].Text;
                                    }
                                    if (j < gvStudent.Rows.Count)
                                    {
                                        Session["Send_Email"] = Session["Send_Email"] + ";";
                                        j++;
                                    }
                                    if (item.Cells[2].Text != "" && item.Cells[2].Text != "&nbsp;" && item.Cells[2].Text != null)
                                    {
                                        Session["Send_SMS"] += item.Cells[2].Text;
                                    }
                                    if (i < gvStudent.Rows.Count)
                                    {
                                        Session["Send_SMS"] = Session["Send_SMS"] + ",";
                                        i++;
                                    }

                                }
                            }
                            catch (Exception ex)
                            {
                                Response.Write("Oops! error occured :" + ex.Message.ToString());
                                //Response.Write("Oops! error occured :" + ex.Message.ToString());
                            }
                        }
                    }
                }
                else
                {
                    string script = "alert(\"Record Not Available!\");"; ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
                }
                //all_regi_mem();
                string script1 = "alert(\"Student Approuve Succefully!\");"; ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script1, true);

                Session["CheckRefresh"] = Server.UrlDecode(System.DateTime.Now.ToString());
            }
            catch (Exception ex)
            {
                Response.Write("Oops! error occured :" + ex.Message.ToString());
            }
            if (Session["Send_Email"] != null && Session["Send_SMS"] != null)
            {
                Response.Redirect("Send_Notification.aspx");
            }
            else
            {
                string script = "alert(\"Student Not Selected!\");"; ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
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
    }
}