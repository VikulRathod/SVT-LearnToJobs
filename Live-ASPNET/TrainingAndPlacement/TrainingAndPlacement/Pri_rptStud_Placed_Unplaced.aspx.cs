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
    public partial class Pri_rptStud_Placed_Unplaced : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myConnectionString"].ConnectionString);
        bel_Student bel = new bel_Student();
        bal_Student bal = new bal_Student();
        bal_Company bal_C = new bal_Company();
        bel_Company bel_C = new bel_Company();
        bal_Dept bal_d = new bal_Dept();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                RadioAll.Checked = true;
                Yearly.Visible = false;
            }
        }
        protected void RadioAll_CheckedChanged(object sender, EventArgs e)
        {
            RadioAll.Checked = true;
            Yearly.Visible = false;
          
        }
        protected void RadioYearly_CheckedChanged(object sender, EventArgs e)
        {
            Yearly.Visible = true;
           
        }
        protected void Search_Click(object sender, EventArgs e)
        {
            try
            {
                if (ddlround.SelectedIndex == 0)
                {
                    string script = "alert(\"Please Select Round Status!\");"; ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
                }
                else
                {
                    if (RadioAll.Checked == true)
                    {
                        if (ddlround.SelectedIndex == 1)
                        {
                            bind_Apply_All_Student();
                        }
                        else if (ddlround.SelectedIndex == 2)
                        {
                            bind_Apply_All_Placed();
                        }
                        else if (ddlround.SelectedIndex == 3)
                        {
                            bind_Apply_All_UnPlaced();
                        }
                        else
                        {
                            string script = "alert(\"Please Select Apply Status!\");"; ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
                        }
                    }
                    else if (RadioYearly.Checked == true)
                    {
                        if (ddlround.SelectedIndex == 1)
                        {
                            bind_Apply_Year_Wise();
                        }
                        else if (ddlround.SelectedIndex == 2)
                        {
                            bind_Apply_Year_Wise_Placed();
                        }
                        else if (ddlround.SelectedIndex == 3)
                        {
                            bind_Apply_Year_Wise_UnPlaced();
                        }
                        else
                        {
                            string script = "alert(\"Please Select Apply Status!\");"; ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
                        }
                    }
                    else
                    {
                        string script = "alert(\"Please Select Search Option!\");"; ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
                    }
                }
            }
            catch (Exception ex)
            {
                Response.Write("Oops! error occured :" + ex.Message.ToString());
            }
        }
        //all Radio Button Selected
        protected void bind_Apply_All_Student()
        {
            try
            {
                DataTable dt = bal.SelectAllPlace_Unplace_Stud_List();
                if (dt.Rows.Count > 0)
                {
                    gvStudent_Apply_Status.DataSource = dt;
                    gvStudent_Apply_Status.DataBind();
                }
                else
                {
                    string script = "alert(\"Record not available!\");"; ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
                }
            }
            catch (Exception ex)
            {
                Response.Write("Oops! error occured :" + ex.Message.ToString());
            }
        }
        protected void bind_Apply_All_Placed()
        {
            try
            {
                bel.bel_Round = ddlround.SelectedValue;

                DataTable dt = bal.SelectPlaced_Stud_List(bel);
                if (dt.Rows.Count > 0)
                {
                    gvStudent_Apply_Status.DataSource = dt;
                    gvStudent_Apply_Status.DataBind();
                }
                else
                {
                    string script = "alert(\"Record not available!\");"; ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
                }
            }
            catch (Exception ex)
            {
                Response.Write("Oops! error occured :" + ex.Message.ToString());
            }
        }
        protected void bind_Apply_All_UnPlaced()
        {
            try
            {
                bel.bel_Round = "Placed";

                DataTable dt = bal.Select_Unplace_Stud_List(bel);
                if (dt.Rows.Count > 0)
                {
                    gvStudent_Apply_Status.DataSource = dt;
                    gvStudent_Apply_Status.DataBind();
                }
                else
                {
                    string script = "alert(\"Record not available!\");"; ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
                }
            }
            catch (Exception ex)
            {
                Response.Write("Oops! error occured :" + ex.Message.ToString());
            }
        }

        //Year Radio Button Selected
        protected void bind_Apply_Year_Wise()
        {
            try
            {
                bel.bel_Academic_Year = ddlAcademicYear.SelectedItem.Text;
                DataTable dt = bal.SelectAllYear_Wise(bel);
                if (dt.Rows.Count > 0)
                {
                    gvStudent_Apply_Status.DataSource = dt;
                    gvStudent_Apply_Status.DataBind();
                }
                else
                {
                    string script = "alert(\"Record not available!\");"; ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
                }
            }
            catch (Exception ex)
            {
                Response.Write("Oops! error occured :" + ex.Message.ToString());
            }
        }
        protected void bind_Apply_Year_Wise_Placed()
        {
            try
            {
                bel.bel_Academic_Year = ddlAcademicYear.SelectedItem.Text;
                bel.bel_Round = ddlround.SelectedValue;
                DataTable dt = bal.Year_WisePlaced(bel);
                if (dt.Rows.Count > 0)
                {
                    gvStudent_Apply_Status.DataSource = dt;
                    gvStudent_Apply_Status.DataBind();
                }
                else
                {
                    string script = "alert(\"Record not available!\");"; ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
                }
            }
            catch (Exception ex)
            {
                Response.Write("Oops! error occured :" + ex.Message.ToString());
            }
        }
        protected void bind_Apply_Year_Wise_UnPlaced()
        {
            try
            {
                bel.bel_Academic_Year = ddlAcademicYear.SelectedItem.Text;
                bel.bel_Round = "Placed";
                DataTable dt = bal.Year_WiseUnplaced(bel);
                if (dt.Rows.Count > 0)
                {
                    gvStudent_Apply_Status.DataSource = dt;
                    gvStudent_Apply_Status.DataBind();
                }
                else
                {
                    string script = "alert(\"Record not available!\");"; ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
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
                if (gvStudent_Apply_Status.Rows.Count > 0)
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
                    gvStudent_Apply_Status.GridLines = GridLines.Both;
                    gvStudent_Apply_Status.HeaderStyle.Font.Bold = true;
                    gvStudent_Apply_Status.RenderControl(htmltextwrtter);
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