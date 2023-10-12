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
    public partial class Student_Apply_Drive_Extra : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myConnectionString"].ConnectionString);
        bal_Student bal = new bal_Student();
        bel_Student bel = new bel_Student();
        bal_Company bal_C = new bal_Company();
        bel_Company bel_C = new bel_Company();
        bal_Dept bal_D = new bal_Dept();
        bal_Drive bal_Drive = new bal_Drive();
        bel_Derive bel_Drive = new bel_Derive();

        string filename;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                bind_Department();
                bind_All_Company();
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
                ddlCourse.Items.Insert(0, new ListItem("-Select-", string.Empty));
            }
        }
        protected void bind_All_Company()
        {
            try
            {

                DataSet ds = bal_C.bind_All_Company(bel_C);
                ddlCompany_ID.DataSource = ds;
                ddlCompany_ID.DataTextField = "company_name";
                ddlCompany_ID.DataValueField = "Company_id";
                ddlCompany_ID.DataBind();
                ddlCompany_ID.Items.Insert(0, new System.Web.UI.WebControls.ListItem("- Select Company -", string.Empty));
            }
            catch (Exception ex)
            {
                Response.Write("Oops! error occured :" + ex.Message.ToString());
            }
        }
        protected void ddlCompany_ID_SelectedIndexChanged(object sender, EventArgs e)
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
                    cmd.Parameters.AddWithValue("@Reg_To_Date", DateTime.Now.ToString("dd/MM/yyyy"));
                    DataTable dt = new DataTable();
                    SqlDataAdapter adp1 = new SqlDataAdapter(cmd);
                    adp1.Fill(dt);
                    if (dt.Rows.Count > 0)
                    {
                        ddlDrive.DataSource = dt;
                        ddlDrive.DataTextField = "Drive_Title";
                        ddlDrive.DataValueField = "Drive_Id";
                        ddlDrive.DataBind();
                        ddlDrive.Items.Insert(0, new System.Web.UI.WebControls.ListItem("- Select Drive -", string.Empty));
                    }

                }
            }
            catch (Exception ex)
            {
                Response.Write("Oops! error occured :" + ex.Message.ToString());
            }
        }
        protected void Search_Click(object sender, EventArgs e)
        {

            bel.bel_Academic_Year = ddlAcademic.SelectedItem.ToString();
            bel.bel_Course_Name = ddlCourse.SelectedValue;
            DataSet ds = bal.bindStudent_Year_Dept_wise(bel);
            if (ds.Tables[0].Rows.Count > 0)
            {
                gvStudent.DataSource = ds;
                gvStudent.DataBind();
            }
            else
            {
                string script = "alert(\"Record not available!\");"; ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
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

        protected void btnApply_Drive_Click(object sender, EventArgs e)
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
                else if (ddlDrive.SelectedIndex == 0)
                {
                    string script = "alert(\"Please Select Drive!\");"; ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
                }
                else if (gvStudent.Rows.Count > 0)
                {

                    con.Open();
                    DataTable dt = new DataTable();
                    DataTable dt1 = new DataTable();
                    dt.Columns.Add("Student_ID", typeof(string));
                    dt.Columns.Add("Acadamic_Year", typeof(string));
                    dt.Columns.Add("Company_ID", typeof(string));
                    dt.Columns.Add("Company_Name", typeof(string));
                    dt.Columns.Add("Drive_Id", typeof(string));
                    dt.Columns.Add("AppliedDate", typeof(string));
                    dt.Columns.Add("Round", typeof(string));

                    foreach (GridViewRow item in gvStudent.Rows)
                    {

                        if (item.RowType == DataControlRowType.DataRow)
                        {
                            CheckBox chkRow = (item.Cells[0].FindControl("chkBxSelect") as CheckBox);
                            try
                            {
                                if (chkRow.Checked)
                                {

                                    if (item.Cells[1].Text != "" && item.Cells[1].Text != "&nbsp;" && item.Cells[1].Text != null)
                                    {
                                        dt.Rows.Add(item.Cells[1].Text, ddlAcademic.SelectedValue, ddlCompany_ID.SelectedValue, ddlCompany_ID.SelectedItem.Text, ddlDrive.SelectedValue, DateTime.Now.ToString("dd/MM/yyyy"), "Round1");
                                        
                                        //bel_Drive.bel_id = item.Cells[1].Text;
                                        //bel_Drive.bel_Academic_Year = ddlAcademicYear.SelectedValue;
                                        //bel_Drive.bel_Company_name = ddlCompany_ID.SelectedItem.Text;
                                        //bel_Drive.bel_Company_ID = ddlCompany_ID.SelectedValue;
                                        //bel_Drive.bel_Drive_Title = ddlDrive.SelectedValue;
                                        //bel_Drive.bel_AppliedDate = DateTime.Now.ToString("dd/MM/yyyy");
                                        //bel_Drive.bel_Status = "Round1";
                                        
                                        //int Result = bal.Student_Applied_Drive(bel_Drive);
                                        ////if (Result > 0)
                                        ////{
                                        ////    string script = "alert(\"Applied Successfully!!!\");"; ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
                                        ////}
                                        ////else
                                        ////{
                                        ////    string script = "alert(\"Drive couldn't be Applied!!!\");"; ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
                                        ////}
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


                    if (dt.Rows.Count > 0)
                    {
                        // Dim conString As String = ConfigurationManager.ConnectionStrings("conStr").ConnectionString
                        // Using con As New SqlConnection(conString)
                        using (SqlBulkCopy sqlBulkCopy = new SqlBulkCopy(con))
                        {
                            // Set the database table name in which records will be inserted in bulk
                            sqlBulkCopy.DestinationTableName = "Student_Applied_Drive";

                            // Map the DataTable columns with that of the database table. Optional if database table column and datatable columns names are same
                            sqlBulkCopy.ColumnMappings.Add("Student_ID", "Student_ID");
                            sqlBulkCopy.ColumnMappings.Add("Acadamic_Year", "Acadamic_Year");
                            sqlBulkCopy.ColumnMappings.Add("Company_ID", "Company_ID");
                            sqlBulkCopy.ColumnMappings.Add("Company_Name", "Company_Name");
                            sqlBulkCopy.ColumnMappings.Add("Drive_Id", "Drive_Id");
                            sqlBulkCopy.ColumnMappings.Add("AppliedDate", "AppliedDate");
                            sqlBulkCopy.ColumnMappings.Add("Round", "Round");
                            sqlBulkCopy.WriteToServer(dt);
                            string script1 = "alert(\"Applied Successfully!!!\");"; ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script1, true);
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
        }
    }
}