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
    public partial class Pri_rptCompany_Regi : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myConnectionString"].ConnectionString);
        bel_Company bel = new bel_Company();
        bal_Company bal = new bal_Company();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                DateTime today = DateTime.Today;
                DateTime start = new DateTime(today.Year, today.Month, 1);
                txtstart_date.Text = Convert.ToDateTime(start).ToString("dd/MM/yyyy");
                txtend_date.Text = Convert.ToDateTime(today).ToString("dd/MM/yyyy");
                alldisplay();
            }
        }
        protected void alldisplay()
        {

            DataSet ds = bal.bind_All_Company(bel);
            gvCompany.DataSource = ds;
            gvCompany.DataBind();
        }
        protected void Search_Click(object sender, EventArgs e)
        {

            try
            {
                if (Convert.ToDateTime(txtstart_date.Text) > Convert.ToDateTime(txtend_date.Text))
                {
                    string script = "alert(\"Please Select Valid Date!\");"; ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
                }
                else
                {
                    bel.bel_start_date = txtstart_date.Text;
                    bel.bel_end_date = txtend_date.Text;
                    DataSet ds = bal.Select_rptCompany_Registration(bel);
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        gvCompany.DataSource = ds;
                        gvCompany.DataBind();
                    }
                    else
                    {
                        string script = "alert(\"Company not available!\");"; ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
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
                if (gvCompany.Rows.Count > 0)
                {
                   Response.Clear();
                    Response.Buffer = true;
                    Response.ClearContent();
                    Response.ClearHeaders();
                    Response.Charset = "";
                    string FileName = "Company_Registration_List" + DateTime.Now + ".xls";
                    StringWriter strwritter = new StringWriter();
                    HtmlTextWriter htmltextwrtter = new HtmlTextWriter(strwritter);
                    Response.Cache.SetCacheability(HttpCacheability.NoCache);
                    Response.ContentType = "application/vnd.ms-excel";
                    Response.AddHeader("Content-Disposition", "attachment;filename=" + FileName);
                    gvCompany.GridLines = GridLines.Both;
                    gvCompany.HeaderStyle.Font.Bold = true;
                    gvCompany.RenderControl(htmltextwrtter);
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