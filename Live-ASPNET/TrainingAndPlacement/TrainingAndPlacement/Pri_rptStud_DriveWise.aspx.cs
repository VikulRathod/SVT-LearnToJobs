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
    public partial class Pri_rptStud_DriveWise : System.Web.UI.Page
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
                Drive.Visible = false;
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
                ddlCompany_ID.Items.Insert(0, new System.Web.UI.WebControls.ListItem("----- Select Company -----", string.Empty));
            }
        }
        protected void ddlCompany_ID_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (RadioDrive.Checked)
            {
                Bind_Drive();
            }
            else if (Radioyear_drive.Checked)
            {
                Bind_Drive1();
            }
        }
        protected void Bind_Drive()
        {
            try
            {
                if (ddlCompany_ID.SelectedIndex == 0)
                {
                    string script = "alert(\"Please Select Company ID !\");"; ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
                }
                else
                {
                    SqlCommand cmd = new SqlCommand("SP_Add_Update_Drive", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@flag", 8);
                    cmd.Parameters.AddWithValue("@Company_ID", ddlCompany_ID.SelectedValue);
                    DataTable dT = new DataTable();
                    SqlDataAdapter adp1 = new SqlDataAdapter(cmd);
                    adp1.Fill(dT);

                    ddlDrive.DataSource = dT;
                    ddlDrive.DataTextField = "Drive_Title";
                    ddlDrive.DataValueField = "Drive_Id";
                    ddlDrive.DataBind();
                    ddlDrive.Items.Insert(0, new System.Web.UI.WebControls.ListItem("----- Select Drive -----", string.Empty));
                }
            }
            catch (Exception ex)
            {
                Response.Write("Oops! error occured :" + ex.Message.ToString());
            }
        }
        protected void Bind_Drive1()
        {
            try
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
                    DataTable dT = new DataTable();
                    SqlDataAdapter adp1 = new SqlDataAdapter(cmd);
                    adp1.Fill(dT);

                    ddlDrive.DataSource = dT;
                    ddlDrive.DataTextField = "Drive_Title";
                    ddlDrive.DataValueField = "Drive_Id";
                    ddlDrive.DataBind();
                    ddlDrive.Items.Insert(0, new System.Web.UI.WebControls.ListItem("----- Select Drive -----", string.Empty));
                }
            }
            catch (Exception ex)
            {
                Response.Write("Oops! error occured :" + ex.Message.ToString());
            }
        }
        protected void RadioDrive_CheckedChanged(object sender, EventArgs e)
        {
            Yearly.Visible = false;
            Drive.Visible = true;
            Bind_Drive();
        }
        protected void Radioyear_drive_CheckedChanged(object sender, EventArgs e)
        {
            Yearly.Visible = true;
            Drive.Visible = true;
            Bind_Drive1();
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
                    if (RadioDrive.Checked == true)
                    {
                        if (ddlround.SelectedIndex == 1)
                        {
                            bind_Apply_Drive_Wise();
                        }
                        else if (ddlround.SelectedIndex == 2)
                        {
                            bind_Apply_Drive_Wise_Placed();
                        }
                        else if (ddlround.SelectedIndex == 3)
                        {
                            bind_Apply_Drive_Wise_UnPlaced();
                        }
                        else
                        {
                            string script = "alert(\"Please Select Apply Status!\");"; ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
                        }
                    }

                    else if (Radioyear_drive.Checked == true)
                    {
                        if (ddlround.SelectedIndex == 1)
                        {
                            bind_Apply_year_Drive_Wise();
                        }
                        else if (ddlround.SelectedIndex == 2)
                        {
                            bind_Apply_year_Drive_Wise_Placed();
                        }
                        else if (ddlround.SelectedIndex == 3)
                        {
                            bind_Apply_year_Drive_Wise_UnPlaced();
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
        //Drive Radio Button Selected
        protected void bind_Apply_Drive_Wise()
        {
            try
            {
                bel.bel_Company_ID = ddlCompany_ID.SelectedValue;
                bel.bel_Drive_Id = ddlDrive.SelectedValue;

                DataTable dt = bal.SelectAllDrive_Wise(bel);
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
        protected void bind_Apply_Drive_Wise_Placed()
        {
            try
            {
                bel.bel_Company_ID = ddlCompany_ID.SelectedValue;
                bel.bel_Drive_Id = ddlDrive.SelectedValue;
                bel.bel_Round = ddlround.SelectedValue;

                DataTable dt = bal.Drive_WisePlaced(bel);
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
        protected void bind_Apply_Drive_Wise_UnPlaced()
        {
            try
            {
                bel.bel_Company_ID = ddlCompany_ID.SelectedValue;
                bel.bel_Drive_Id = ddlDrive.SelectedValue;
                bel.bel_Round = "Placed";

                DataTable dt = bal.Drive_WiseUnPlaced(bel);
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
        //Yealy & Drive Radio Button Selected
        protected void bind_Apply_year_Drive_Wise()
        {
            try
            {
                bel.bel_Academic_Year = ddlAcademicYear.SelectedItem.Text;
                bel.bel_Company_ID = ddlCompany_ID.SelectedValue;
                bel.bel_Drive_Id = ddlDrive.SelectedValue;

                DataTable dt = bal.Select_year_Drive_Wise(bel);
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
        protected void bind_Apply_year_Drive_Wise_Placed()
        {
            try
            {
                bel.bel_Academic_Year = ddlAcademicYear.SelectedItem.Text;
                bel.bel_Company_ID = ddlCompany_ID.SelectedValue;
                bel.bel_Drive_Id = ddlDrive.SelectedValue;
                bel.bel_Round = ddlround.SelectedValue;

                DataTable dt = bal.year_Drive_Wise_Placed(bel);
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
        protected void bind_Apply_year_Drive_Wise_UnPlaced()
        {
            try
            {
                bel.bel_Academic_Year = ddlAcademicYear.SelectedItem.Text;
                bel.bel_Company_ID = ddlCompany_ID.SelectedValue;
                bel.bel_Drive_Id = ddlDrive.SelectedValue;
                bel.bel_Round = "Placed";

                DataTable dt = bal.year_Drive_Wise_UnPlaced(bel);
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