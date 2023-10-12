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
namespace Digital_School_MIS
{
    public partial class Login_Details : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["myConnectionString"].ConnectionString);
        bel_login login = new bel_login();
        bal_login bal_login = new bal_login();
        DataSet ds = new DataSet();
        DataTable dt = new DataTable();
        SqlCommand cmd;
        SqlDataAdapter da;
        string email_from, email_pwd, txtc_name, rxrc_contact, txtc_email, txtc_web, txtc_add1, txtc_add2, txtc_pin;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                all__display();
            }
        }
        protected void btnsearch_Click(object sender, EventArgs e)
        {

            DataSet ds = new DataSet();
            try
            {
                login.bel_username = txtid.Text;
                ds = bal_login.select_user(login);
                if (ds.Tables[0].Rows.Count > 0)
                {
                    gvUser.DataSource = ds;
                    gvUser.DataBind();

                }
                else
                {
                    string script = "alert(\"Invalid User Name\");"; ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
                }
            }
            catch (Exception ex)
            {
                Response.Write("Oops! error occured :" + ex.Message.ToString());
            }
        }

        protected void all__display()
        {

            DataSet ds = new DataSet();
            try
            {
                ds = bal_login.select_All(login);
                if (ds.Tables[0].Rows.Count > 0)
                {
                    gvUser.DataSource = ds;
                    gvUser.DataBind();

                }
                else
                {
                    string script = "alert(\"No User Availabel!\");"; ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
                }
            }
            catch (Exception ex)
            {
                Response.Write("Oops! error occured :" + ex.Message.ToString());
            }


        }

        protected void bind_profile()
        {
            try
            {
                SqlDataAdapter sda = new SqlDataAdapter("select * from company_profile", con);
                DataTable ds = new DataTable();
                sda.Fill(ds);
                txtc_name = ds.Rows[0].ItemArray[0].ToString();
                rxrc_contact = ds.Rows[0].ItemArray[1].ToString();
                txtc_email = ds.Rows[0].ItemArray[2].ToString();
                txtc_web = ds.Rows[0].ItemArray[3].ToString();
                txtc_add1 = ds.Rows[0].ItemArray[4].ToString();
                txtc_add2 = ds.Rows[0].ItemArray[5].ToString();
                txtc_pin = ds.Rows[0].ItemArray[8].ToString();
                email_from = ds.Rows[0].ItemArray[9].ToString();
                email_pwd = ds.Rows[0].ItemArray[10].ToString();
            }
            catch (Exception ex)
            {
                Response.Write("Oops! error occured :" + ex.Message.ToString());
            }
        }
        protected void Page_PreRender(object sender, EventArgs e)
        {
            ViewState["CheckRefresh"] = Session["CheckRefresh"];
        }

        protected void btnActive_Click(object sender, EventArgs e)
        {
            //if (Session["CheckRefresh"].ToString() == ViewState["CheckRefresh"].ToString())
            {
                int i = 1, j = 1;

                if (gvUser.Rows.Count > 0)
                {
                    foreach (GridViewRow item in gvUser.Rows)
                    {

                        if (item.RowType == DataControlRowType.DataRow)
                        {
                            CheckBox chkRow = (item.Cells[0].FindControl("chkBxSelect") as CheckBox);
                            string str = gvUser.Rows[0].Cells[4].Text;
                            try
                            {
                                if (chkRow.Checked)
                                {
                                    login.bel_username = item.Cells[4].Text;
                                    login.bel_status = "Active";
                                    gvUser.EditIndex = -1;
                                    int retVal = bal_login.login_status_update(login);


                                    if (item.Cells[3].Text != "" && item.Cells[3].Text != "&nbsp;" && item.Cells[3].Text != null)
                                    {
                                        Session["Send_Email"] += item.Cells[3].Text;
                                    }
                                    if (j < gvUser.Rows.Count)
                                    {
                                        Session["Send_Email"] = Session["Send_Email"] + ";";
                                        j++;
                                    }
                                    if (item.Cells[2].Text != "" && item.Cells[2].Text != "&nbsp;" && item.Cells[2].Text != null)
                                    {
                                        Session["Send_SMS"] += item.Cells[2].Text;
                                    }
                                    if (i < gvUser.Rows.Count)
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
                all__display();
                string script1 = "alert(\"Login Detail Email Send Successfully!\");"; ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script1, true);
            }
            //else
            {
                string script = "alert(\"Student Not Selected!\");"; ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
            }
            Session["CheckRefresh"] = Server.UrlDecode(System.DateTime.Now.ToString());
            Response.Redirect("Send_Notification.aspx");


        }
        protected void btnDeactive_Click(object sender, EventArgs e)
        {
            //if (Session["CheckRefresh"].ToString() == ViewState["CheckRefresh"].ToString())
            {
                int i = 1, j = 1;

                if (gvUser.Rows.Count > 0)
                {
                    foreach (GridViewRow item in gvUser.Rows)
                    {

                        if (item.RowType == DataControlRowType.DataRow)
                        {
                            CheckBox chkRow = (item.Cells[0].FindControl("chkBxSelect") as CheckBox);
                            string str = gvUser.Rows[0].Cells[4].Text;
                            try
                            {
                                if (chkRow.Checked)
                                {
                                    login.bel_username = item.Cells[4].Text;
                                    login.bel_status = "Deactive";
                                    gvUser.EditIndex = -1;
                                    int retVal = bal_login.login_status_update(login);


                                    if (item.Cells[3].Text != "" && item.Cells[3].Text != "&nbsp;" && item.Cells[3].Text != null)
                                    {
                                        Session["Send_Email"] += item.Cells[3].Text;
                                    }
                                    if (j < gvUser.Rows.Count)
                                    {
                                        Session["Send_Email"] = Session["Send_Email"] + ";";
                                        j++;
                                    }
                                    if (item.Cells[2].Text != "" && item.Cells[2].Text != "&nbsp;" && item.Cells[2].Text != null)
                                    {
                                        Session["Send_SMS"] += item.Cells[2].Text;
                                    }
                                    if (i < gvUser.Rows.Count)
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
                all__display();
                string script1 = "alert(\"Login Detail Email Send Successfully!\");"; ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script1, true);
            }
            //else
            {
                string script = "alert(\"Student Not Selected!\");"; ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
            }
            Session["CheckRefresh"] = Server.UrlDecode(System.DateTime.Now.ToString());
            Response.Redirect("Send_Notification.aspx");

        }

        protected void gvUser_RowCreated(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.DataRow && (e.Row.RowState == DataControlRowState.Normal || e.Row.RowState == DataControlRowState.Alternate))
            {
                CheckBox chkBxSelect = (CheckBox)e.Row.Cells[1].FindControl("chkBxSelect");
                CheckBox chkBxHeader = (CheckBox)this.gvUser.HeaderRow.FindControl("chkBxHeader");
                chkBxSelect.Attributes["onclick"] = string.Format("javascript:ChildClick(this,'{0}');", chkBxHeader.ClientID);
            }
        }

    }
}