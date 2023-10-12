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
using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.text.html;
using iTextSharp.text.html.simpleparser;
using System.Drawing.Printing;

namespace TrainingAndPlacement
{
    public partial class Pri_rptStud_Apply_Drive : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myConnectionString"].ConnectionString);
        bal_message bal_msg = new bal_message();
        bel_message bel_msg = new bel_message();
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
                ddlCompany_ID.Items.Insert(0, new System.Web.UI.WebControls.ListItem("----- Select Department -----", string.Empty));
            }
        }
        protected void ddlCompany_ID_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (ddlAcademicYear.SelectedIndex == 0)
                {
                    string script = "alert(\"Please Select Academic Year!\");"; ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
                }
                if (ddlCompany_ID.SelectedIndex == 0)
                {
                    string script = "alert(\"Please Select Company ID !\");"; ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
                }
                else
                {
                    SqlCommand cmd = new SqlCommand("SP_Add_Update_Drive", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@flag", 9);
                    cmd.Parameters.AddWithValue("@Academic_Year", ddlAcademicYear.SelectedItem.Text);
                    cmd.Parameters.AddWithValue("@Company_ID", ddlCompany_ID.SelectedValue);
                    DataTable dT = new DataTable();
                    SqlDataAdapter adp1 = new SqlDataAdapter(cmd);
                    adp1.Fill(dT);

                    ddlDrive.DataSource = dT;
                    ddlDrive.DataTextField = "Drive_Title";
                    ddlDrive.DataValueField = "Drive_Id";
                    ddlDrive.DataBind();
                    ddlDrive.Items.Insert(0, new System.Web.UI.WebControls.ListItem("----- Select Department -----", string.Empty));
                }
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
                if (ddlAcademicYear.SelectedIndex == 0)
                {
                    string script = "alert(\"Please Select Academic Year!\");"; ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
                }
                else if (ddlCompany_ID.SelectedIndex == 0)
                {
                    string script = "alert(\"Please Select Company ID !\");"; ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
                }
                else if (ddlDrive.SelectedIndex == 0)
                {
                    string script = "alert(\"Please Select Drive!\");"; ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
                }
                else
                {
                    bel.bel_Academic_Year = ddlAcademicYear.SelectedValue;
                    bel.bel_Company_ID = ddlCompany_ID.SelectedValue;
                    bel.bel_Drive_Id = ddlDrive.SelectedValue;
                    DataTable dt = bal.Applied_Student_List(bel);
                    if (dt.Rows.Count > 0)
                    {
                        gvStudent_Apply.DataSource = dt;
                        gvStudent_Apply.DataBind();
                    }
                    else
                    {
                        string script = "alert(\"Record not available!\");"; ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
                    }
                }
            }
            catch (Exception ex)
            {
                Response.Write("Oops! error occured :" + ex.Message.ToString());
            }
        }
        protected void btnexcel_Click(object sender, EventArgs e)
        {
            try
            {
                if (gvStudent_Apply.Rows.Count > 0)
                {
                    Response.Clear();
                    Response.Buffer = true;
                    Response.ClearContent();
                    Response.ClearHeaders();
                    Response.Charset = "";
                    string FileName = "Student_Apply_Drive_List" + DateTime.Now + ".xls";
                    StringWriter strwritter = new StringWriter();
                    HtmlTextWriter htmltextwrtter = new HtmlTextWriter(strwritter);
                    Response.Cache.SetCacheability(HttpCacheability.NoCache);
                    Response.ContentType = "application/vnd.ms-excel";
                    Response.AddHeader("Content-Disposition", "attachment;filename=" + FileName);
                    gvStudent_Apply.GridLines = GridLines.Both;
                    gvStudent_Apply.HeaderStyle.Font.Bold = true;
                    gvStudent_Apply.RenderControl(htmltextwrtter);
                    Response.Write(strwritter.ToString());
                    Response.End();
                }
                else
                {
                    string script = "alert(\"Record Not Available!\");"; ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
                }
            }
            catch (Exception ex)
            {
                Response.Write("Oops! error occured :" + ex.Message.ToString());
            }
        }
        public override void VerifyRenderingInServerForm(Control control)
        {
            /* Verifies that the control is rendered */
        }
    }
}