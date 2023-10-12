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
    public partial class Pri_rptStud_Regi_list : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myConnectionString"].ConnectionString);
        bal_Student bal = new bal_Student();
        bel_Student bel = new bel_Student();
        bal_Dept bal_D = new bal_Dept();
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
                DataSet ds = bal_D.gvDepartment_Bind();
                ddlCourse.DataSource = ds;
                ddlCourse.DataTextField = "Department";
                ddlCourse.DataValueField = "Id";
                ddlCourse.DataBind();
                ddlCourse.Items.Insert(0, new System.Web.UI.WebControls.ListItem("----- Select Department -----", string.Empty));
            }
        }
        protected void all_regi_mem()
        {
            try
            {
                DataSet dtbl = bal.selectAll(); //bind table
                gmStudent_Regi.DataSource = dtbl;
                gmStudent_Regi.DataBind();
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
                    string script = "alert(\"plese select Academic Year !\");"; ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);

                }
                else if (ddlCourse.SelectedIndex == 0)
                {
                    string script = "alert(\"plese select Department!\");"; ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);

                }
                else
                {
                    bel.bel_Academic_Year = ddlAcademic.SelectedItem.Text;
                    bel.bel_Course_Name = ddlCourse.SelectedValue;
                    DataSet ds = bal.bindStudent_Year_Dept_wise(bel);
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        gmStudent_Regi.DataSource = ds;
                        gmStudent_Regi.DataBind();
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
                if (gmStudent_Regi.Rows.Count > 0)
                {
                    Response.Clear();
                    Response.Buffer = true;
                    Response.ClearContent();
                    Response.ClearHeaders();
                    Response.Charset = "";
                    string FileName = "Student_Registration_Reports" + DateTime.Now + ".xls";
                    StringWriter strwritter = new StringWriter();
                    HtmlTextWriter htmltextwrtter = new HtmlTextWriter(strwritter);
                    Response.Cache.SetCacheability(HttpCacheability.NoCache);
                    Response.ContentType = "application/vnd.ms-excel";
                    Response.AddHeader("Content-Disposition", "attachment;filename=" + FileName);
                    gmStudent_Regi.GridLines = GridLines.Both;
                    gmStudent_Regi.HeaderStyle.Font.Bold = true;
                    gmStudent_Regi.RenderControl(htmltextwrtter);
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