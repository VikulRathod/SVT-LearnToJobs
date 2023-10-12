using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
using System.Data;
using System.Configuration;
using System.Data.SqlClient;
using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.text.html;
using iTextSharp.text.html.simpleparser;
using System.Drawing.Printing;
using BEL;
using BAL;

namespace TrainingAndPlacement
{
    public partial class Pri_rptCompany_Drivewise : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myConnectionString"].ConnectionString);
        bel_Derive bel = new bel_Derive();
        bal_Drive bal = new bal_Drive();
        bal_Company bal_C = new bal_Company();
        bel_Company bel_C = new bel_Company();
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
                ddlCompany.DataSource = ds;
                ddlCompany.DataTextField = "company_name";
                ddlCompany.DataValueField = "Company_id";
                ddlCompany.DataBind();
                ddlCompany.Items.Insert(0, new System.Web.UI.WebControls.ListItem("----- Select Company -----", string.Empty));
            }
        }
        protected void Search_Click(object sender, EventArgs e)
        {

            try
            {
                if (ddlCompany.SelectedIndex == 0)
                {
                    string script = "alert(\"Please Select Company ID !\");"; ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
                }
                else
                {
                    SqlCommand cmd = new SqlCommand("SP_Add_Update_Drive", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@flag", 9);
                    cmd.Parameters.AddWithValue("@Academic_Year", ddlAcademic.SelectedItem.Text);
                    cmd.Parameters.AddWithValue("@Company_ID", ddlCompany.SelectedValue);
                    DataTable dt = new DataTable();
                    SqlDataAdapter adp1 = new SqlDataAdapter(cmd);
                    adp1.Fill(dt);
                    if (dt.Rows.Count > 0)
                    {
                        gvCompany_Drive.DataSource = dt;
                        gvCompany_Drive.DataBind();
                    }
                    else
                    {
                        string script = "alert(\"Drive not available!\");"; ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
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
                if (gvCompany_Drive.Rows.Count > 0)
                {
                    Response.Clear();
                    Response.Buffer = true;
                    Response.ClearContent();
                    Response.ClearHeaders();
                    Response.Charset = "";
                    string FileName = "Company_Drive_List" + DateTime.Now + ".xls";
                    StringWriter strwritter = new StringWriter();
                    HtmlTextWriter htmltextwrtter = new HtmlTextWriter(strwritter);
                    Response.Cache.SetCacheability(HttpCacheability.NoCache);
                    Response.ContentType = "application/vnd.ms-excel";
                    Response.AddHeader("Content-Disposition", "attachment;filename=" + FileName);
                    gvCompany_Drive.GridLines = GridLines.Both;
                    gvCompany_Drive.HeaderStyle.Font.Bold = true;
                    gvCompany_Drive.RenderControl(htmltextwrtter);
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