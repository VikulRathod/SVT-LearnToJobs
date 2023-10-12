using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using BAL;
using BEL;
namespace sanskarpublicschool
{
    public partial class Student_attendance : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["myConnectionString"].ConnectionString);
        SqlCommand cmd;
        bal_Company bal_C = new bal_Company();
        bel_Company bel_C = new bel_Company();
        bel_Student bel = new bel_Student();
        bal_Student bal = new bal_Student();
        bal_Drive bal_D = new bal_Drive();
        bel_Derive bel_D = new bel_Derive();
        string userid;
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
                ddlCompany_ID.Items.Insert(0, new ListItem("Select All", string.Empty));
            }
        }
        protected void ddlCompany_ID_SelectedIndexChanged(object sender, EventArgs e)
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
                DataTable dT = new DataTable();
                SqlDataAdapter adp1 = new SqlDataAdapter(cmd);
                adp1.Fill(dT);

                ddlDrive.DataSource = dT;
                ddlDrive.DataTextField = "Drive_Title";
                ddlDrive.DataValueField = "Drive_Id";
                ddlDrive.DataBind();
                ddlDrive.Items.Insert(0, new ListItem("---Select----", string.Empty));
                //gvStudent.DataSource = dT;
                //gvStudent.DataBind();
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
                    string script = "alert(\"Please Select Company!\");"; ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
                }
                else if (ddlDrive.SelectedIndex == 0)
                {
                    string script = "alert(\"Please Select Drive!\");"; ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
                }
                else if (ddlround.SelectedIndex == 0)
                {
                    string script = "alert(\"Please Select Round!\");"; ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
                }
                else
                {
                    bel.bel_Academic_Year = ddlAcademicYear.SelectedValue;
                    bel.bel_Company_ID = ddlCompany_ID.SelectedValue;
                    bel.bel_Drive_Id = ddlDrive.SelectedValue;
                    bel.bel_Round = ddlround.SelectedValue;
                    DataSet ds = bal.bind_Applied_Students_wise(bel);
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        gvStudent.DataSource = ds;
                        gvStudent.DataBind();
                    }
                    else
                    {
                        string script = "alert(\"Student not available!\");"; ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
                    }

                }
            }
            catch (Exception ex)
            {
                Response.Write("Oops! error occured :" + ex.Message.ToString());
            }
        }
        protected void btnSave_Click(object sender, EventArgs e)
        {

            try
            {
                if (gvStudent.Rows.Count > 0)
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
                    else if (ddlround.SelectedIndex == 0)
                    {
                        string script = "alert(\"Please Select Round!\");"; ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
                    }
                    else
                    {
                        con.Open();
                        string abc = null;
                        for (int i = 0; i < gvStudent.Rows.Count; i++)
                        {
                            DropDownList ddl1 = (DropDownList)gvStudent.Rows[i].FindControl("ddlPresent");
                            abc = ddl1.SelectedValue;
                            if (abc != "" && abc != "" && abc != null && abc != "&nbsp;" && abc != "Select")
                            {
                                //con.Open();
                                //var x = DateTime.Parse(txtdate.Text).ToString("MM-dd-yyyy");
                                string cmdstr = "select count(*) from Student_Round_Attendance where Student_ID='" + gvStudent.Rows[i].Cells[0].Text + "' AND Acadamic_Year='" + ddlAcademicYear.SelectedValue + "' AND Company_ID='" + ddlCompany_ID.SelectedValue + "' AND  Drive_Id='" + ddlDrive.SelectedValue + "' AND  Round='" + ddlround.SelectedValue + "'";
                                
                                cmd = new SqlCommand(cmdstr, con);

                                int count = (int)cmd.ExecuteScalar();
                                
                                if (count <= 0)
                                {
                                    cmd = new SqlCommand("SP_Student_Round_Attendance ", con);
                                    cmd.CommandType = CommandType.StoredProcedure;
                                    cmd.Parameters.AddWithValue("@flag", 1);
                                    cmd.Parameters.AddWithValue("@Student_ID", gvStudent.Rows[i].Cells[0].Text);
                                    cmd.Parameters.AddWithValue("@Acadamic_Year", ddlAcademicYear.SelectedValue);
                                    cmd.Parameters.AddWithValue("@Company_ID", ddlCompany_ID.SelectedValue);
                                    cmd.Parameters.AddWithValue("@Company_Name", ddlCompany_ID.SelectedItem.Text);
                                    cmd.Parameters.AddWithValue("@Drive_Id", ddlDrive.SelectedValue);
                                    cmd.Parameters.AddWithValue("@Drive_name", ddlDrive.SelectedItem.Text);
                                    cmd.Parameters.AddWithValue("@Round", ddlround.SelectedValue);
                                    cmd.Parameters.AddWithValue("@Present", abc);
                                    int retVal = cmd.ExecuteNonQuery();
                                    if(retVal>0)
                                    {
                                        string script = "alert(\"Student Round Attendance Saved Successfully!\");"; ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
                                    }
                                    else
                                    {

                                    }
                                }
                                else
                                {
                                    cmd = new SqlCommand("SP_Student_Round_Attendance ", con);
                                    cmd.CommandType = CommandType.StoredProcedure;
                                    cmd.Parameters.AddWithValue("@flag", 2);
                                    cmd.Parameters.AddWithValue("@Student_ID", gvStudent.Rows[i].Cells[0].Text);
                                    cmd.Parameters.AddWithValue("@Acadamic_Year", ddlAcademicYear.SelectedValue);
                                    cmd.Parameters.AddWithValue("@Company_ID", ddlCompany_ID.SelectedValue);
                                    cmd.Parameters.AddWithValue("@Drive_Id", ddlDrive.SelectedValue);
                                    cmd.Parameters.AddWithValue("@Round", ddlround.SelectedValue);
                                    cmd.Parameters.AddWithValue("@Present", abc);
                                    int retVal = cmd.ExecuteNonQuery();
                                    if (retVal > 0)
                                    {
                                        string script = "alert(\"Student Round Attendance Update Successfully!\");"; ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
                                    }
                                    else
                                    {

                                    }
                                }
                            }
                        }
                        
                    }
                }
                else
                {
                    string script = "alert(\"Record Not Found!\");"; ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
                }
            }
            catch (Exception ex)
            {
                Response.Write("Oops! error occured :" + ex.Message.ToString());
            }
            finally
            {
                con.Close();
            }
        }
    }
}