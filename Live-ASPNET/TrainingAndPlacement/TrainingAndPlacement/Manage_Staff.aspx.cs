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
    public partial class Manage_Staff : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myConnectionString"].ConnectionString);
        bal_message bal_msg = new bal_message();
        bel_message bel_msg = new bel_message();
        bal_Student bal_mem = new bal_Student();
        bel_Student bel_mem = new bel_Student();
        bel_emp_regi bel_emp = new bel_emp_regi();
        bal_emp_regi bal_emp = new bal_emp_regi();
        bal_Dept bal = new bal_Dept();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                all_Registration();
            }
        }


        protected void all_Registration()
        {
            try
            {

                DataSet ds = bal_emp.Select_AllStaff(); //bind table
                gvManageStaff.DataSource = ds;
                gvManageStaff.DataBind();
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

                if (ddlStaff.SelectedIndex == 0)
                {
                    all_Registration();
                    ddlStaff.SelectedIndex = 0;
                }
                else
                {
                    bel_emp.bel_Designation = ddlStaff.SelectedItem.Text;

                    DataSet ds = bal_emp.DesignationWise_Staff(bel_emp);
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        gvManageStaff.DataSource = ds;
                        gvManageStaff.DataBind();
                    }
                    else
                    {
                        string script = "alert(\"Staff not available!\");"; ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
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

                if (gvManageStaff.Rows.Count > 0)
                {
                    int i = 1, j = 1;
                    foreach (GridViewRow item in gvManageStaff.Rows)
                    {

                        if (item.RowType == DataControlRowType.DataRow)
                        {
                            CheckBox chkRow = (item.Cells[0].FindControl("chkBxSelect") as CheckBox);
                            string str = gvManageStaff.Rows[0].Cells[11].Text;
                            try
                            {
                                if (chkRow.Checked)
                                {

                                    if (item.Cells[4].Text != "" && item.Cells[4].Text != "&nbsp;" && item.Cells[4].Text != null)
                                    {
                                        Session["Send_Email"] += item.Cells[4].Text;
                                    }
                                    if (j < gvManageStaff.Rows.Count)
                                    {
                                        Session["Send_Email"] = Session["Send_Email"] + ";";
                                        j++;
                                    }
                                    if (item.Cells[5].Text != "" && item.Cells[5].Text != "&nbsp;" && item.Cells[5].Text != null)
                                    {
                                        Session["Send_SMS"] += item.Cells[5].Text;
                                    }
                                    if (i < gvManageStaff.Rows.Count)
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
                string script = "alert(\"Staff Not Selected!\");"; ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
            }
        }
        protected void chkBxSelect__CheckedChanged(object sender, EventArgs e)
        {

        }
        protected void gvManageStaff_RowCreated(object sender, GridViewRowEventArgs e)
        {

            if (e.Row.RowType == DataControlRowType.DataRow && (e.Row.RowState == DataControlRowState.Normal || e.Row.RowState == DataControlRowState.Alternate))
            {
                CheckBox chkBxSelect = (CheckBox)e.Row.Cells[1].FindControl("chkBxSelect");
                CheckBox chkBxHeader = (CheckBox)this.gvManageStaff.HeaderRow.FindControl("chkBxHeader");
                chkBxSelect.Attributes["onclick"] = string.Format("javascript:ChildClick(this,'{0}');", chkBxHeader.ClientID);
            }
        }
    }
}