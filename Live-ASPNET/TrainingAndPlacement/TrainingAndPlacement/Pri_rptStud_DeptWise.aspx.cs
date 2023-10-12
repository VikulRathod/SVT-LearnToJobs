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
    public partial class Pri_rptStud_DeptWise : System.Web.UI.Page
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
                Yearly.Visible = false;
                RadioDept.Checked = true;
                Department.Visible = true;
                bind_Department();
            }
        }
        protected void bind_Department()
        {
            {
                DataSet ds = bal_d.gvDepartment_Bind();
                ddlCourse.DataSource = ds;
                ddlCourse.DataTextField = "Department";
                ddlCourse.DataValueField = "Id";
                ddlCourse.DataBind();
                ddlCourse.Items.Insert(0, new System.Web.UI.WebControls.ListItem("----- Select Company -----", string.Empty));
            }
        }
        protected void RadioDept_CheckedChanged(object sender, EventArgs e)
        {
            Yearly.Visible = false;
            Department.Visible = true;
        }
        protected void Radioyear_dept_CheckedChanged(object sender, EventArgs e)
        {
            Yearly.Visible = true;
            Department.Visible = true;
           
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
                    if (RadioDept.Checked == true)
                    {
                        if (ddlround.SelectedIndex == 1)
                        {
                            bind_Apply_Dept_Wise();
                        }
                        else if (ddlround.SelectedIndex == 2)
                        {
                            bind_Apply_Dept_Wise_Placed();
                        }
                        else if (ddlround.SelectedIndex == 3)
                        {
                            bind_Apply_Dept_Wise_UnPlaced();
                        }
                        else
                        {
                            string script = "alert(\"Please Select Apply Status!\");"; ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
                        }
                    }
                    else if (Radioyear_dept.Checked == true)
                    {
                        if (ddlround.SelectedIndex == 1)
                        {
                            bind_Apply_year_Dept_Wise();
                        }
                        else if (ddlround.SelectedIndex == 2)
                        {
                            bind_Apply_year_Dept_Wise_Placed();
                        }
                        else if (ddlround.SelectedIndex == 3)
                        {
                            bind_Apply_year_Dept_Wise_UnPlaced();
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
        //Department Radio Button Selected
        protected void bind_Apply_Dept_Wise()
        {
            try
            {
                bel.bel_Course_Name = ddlCourse.SelectedValue;
                DataTable dt = bal.SelectAllDept_Wise(bel);
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
        protected void bind_Apply_Dept_Wise_Placed()
        {
            try
            {
                bel.bel_Course_Name = ddlCourse.SelectedValue;
                bel.bel_Round = ddlround.SelectedValue;

                DataTable dt = bal.Dept_WisePlaced(bel);
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
        protected void bind_Apply_Dept_Wise_UnPlaced()
        {
            try
            {
                bel.bel_Course_Name = ddlCourse.SelectedValue;
                bel.bel_Round = "Placed";

                DataTable dt = bal.Dept_WiseUnPlaced(bel);
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
        //Yealry & Department Radio Button Selected
        protected void bind_Apply_year_Dept_Wise()
        {
            try
            {
                bel.bel_Academic_Year = ddlAcademicYear.SelectedItem.Text;
                bel.bel_Course_Name = ddlCourse.SelectedValue;

                DataTable dt = bal.Select_year_Dept_Wise(bel);
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
        protected void bind_Apply_year_Dept_Wise_Placed()
        {
            try
            {
                bel.bel_Academic_Year = ddlAcademicYear.SelectedItem.Text;
                bel.bel_Course_Name = ddlCourse.SelectedValue;
                bel.bel_Round = ddlround.SelectedValue;

                DataTable dt = bal.year_Dept_Wise_Placed(bel);
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
        protected void bind_Apply_year_Dept_Wise_UnPlaced()
        {
            try
            {
                bel.bel_Academic_Year = ddlAcademicYear.SelectedItem.Text;
                bel.bel_Course_Name = ddlCourse.SelectedValue;
                bel.bel_Round = "Placed";

                DataTable dt = bal.year_Dept_Wise_UnPlaced(bel);
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