using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.IO;
using System.Web.Services;
using System.Data.SqlClient;
using System.Globalization;
using System.Configuration;
using System.Text.RegularExpressions;
using System.Net.Mail;
using System.Net;
using BAL;
using BEL;

namespace TrainingAndPlacement
{
    public partial class Add_update_Drive : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["myConnectionString"].ConnectionString);
        SqlCommand cmd = new SqlCommand();
        string status = "Active";
        bal_Drive bal_D = new bal_Drive();
        bel_Derive bel_D = new bel_Derive();
        bal_Company bal = new bal_Company();
        bel_Company bel = new bel_Company();
        bal_Dept bal_Dept = new bal_Dept();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                bind_DriveTitle();
                bind_All_Company();
                bind_Department();
            }
        }

        protected void bind_DriveTitle()
        {

            
                SqlCommand cmd = new SqlCommand("SP_Add_Update_Drive", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@flag", 3);
                DataTable dT = new DataTable();
                SqlDataAdapter adp1 = new SqlDataAdapter(cmd);
                adp1.Fill(dT);

                ddlDrive_name.DataSource = dT;
                ddlDrive_name.DataTextField = "Drive_Title";
                ddlDrive_name.DataValueField = "Drive_Id";
                ddlDrive_name.DataBind();
                ddlDrive_name.Items.Insert(0, new ListItem("---Add Drive----", string.Empty));
            
        }
        protected void bind_All_Company()
        {
            {

                DataSet ds = bal.bind_All_Company(bel);
                ddlCompany_ID.DataSource = ds;
                ddlCompany_ID.DataTextField = "company_name";
                ddlCompany_ID.DataValueField = "Company_id";
                ddlCompany_ID.DataBind();
                ddlCompany_ID.Items.Insert(0, new ListItem("Select All", string.Empty));

            }
        }
        protected void bind_Department()
        {
            {
                DataSet ds = bal_Dept.gvDepartment_Bind();
                checkCourses.DataSource = ds;
                checkCourses.DataTextField = "Department";
                checkCourses.DataValueField = "Id";
                checkCourses.DataBind();
            }
        }
        protected void ddlDrive_name_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (ddlDrive_name.SelectedIndex == 0)
                {
                    clear();
                }
                else
                {
                    checkCourses.ClearSelection();
                    cmd = new SqlCommand("SP_Add_Update_Drive", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@flag", 4);
                    cmd.Parameters.AddWithValue("@Drive_Id", ddlDrive_name.SelectedValue);
                    DataTable dT = new DataTable();
                    SqlDataAdapter adp1 = new SqlDataAdapter(cmd);
                    adp1.Fill(dT);
                    if (dT.Rows.Count > 0)
                    {
                        ddlAcademic_Year.SelectedValue = dT.Rows[0][1].ToString();
                        ddlCompany_ID.SelectedValue = dT.Rows[0][2].ToString();
                        txtcompany_name.Text = dT.Rows[0][3].ToString();
                        txtDrive_Title.Text = dT.Rows[0][4].ToString();
                        txtPost_Opened.Text = dT.Rows[0][5].ToString();
                        txtJob_Type.Text = dT.Rows[0][6].ToString();
                        txtJob_Profile.Text = dT.Rows[0][7].ToString();
                        txtSalary.Text = dT.Rows[0][8].ToString();
                        txtVacancies.Text = dT.Rows[0][9].ToString();
                        ddlbond.SelectedItem.Text = dT.Rows[0][10].ToString();
                        txtBond_Duration.Text = dT.Rows[0][11].ToString();
                        txtBond_Amount.Text = dT.Rows[0][12].ToString();
                        txtBond_Terms.Text = dT.Rows[0][13].ToString();
                        txtSecurity_Deposite.Text = dT.Rows[0][14].ToString();
                        txtJoining_Date.Text = dT.Rows[0][15].ToString();
                        ddlGender_Allowed.SelectedItem.Text = dT.Rows[0][16].ToString();
                        txtRecruitment_Method.Text = dT.Rows[0][17].ToString();
                        txtJob_Location.Text = dT.Rows[0][18].ToString();
                        txtfrom.Text = dT.Rows[0][19].ToString();
                        txtto.Text = dT.Rows[0][20].ToString();
                        txtdoc_Needed.Text = dT.Rows[0][21].ToString();
                        txtRemark.Text = dT.Rows[0][22].ToString();
                        txtCompany_Coordinator.Text = dT.Rows[0][23].ToString();
                        txtCompany_Designation.Text = dT.Rows[0][24].ToString();
                        txtcompany_contact.Text = dT.Rows[0][25].ToString(); ;
                        txtInstitute_Coordi.Text = dT.Rows[0][26].ToString();
                        txtInstitute_Designation.Text = dT.Rows[0][27].ToString();
                        txtInstitute_Contact.Text = dT.Rows[0][28].ToString();
                        CheckboxsItems();
                    }
                }
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
                    txtcompany_name.Text = ddlCompany_ID.SelectedItem.Text;
                }
            }
            catch (Exception ex)
            {
                Response.Write("Oops! error occured :" + ex.Message.ToString());
            }
        }
        protected void btnsave_Click(object sender, EventArgs e)
        {
            try
            {
                if (ddlAcademic_Year.SelectedIndex==0)
                {
                    string script = "alert(\"Please select Academic Year,Please Retry!\");"; ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
                }
                else if (ddlCompany_ID.SelectedIndex == 0)
                {
                    string script = "alert(\"Please select company ID,Please Retry!\");"; ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
                }
                else if (txtDrive_Title.Text == "nbsp;" || txtDrive_Title.Text == "" || txtDrive_Title.Text == String.Empty)
                {
                    string script = "alert(\"Please Enter Drive Title,Please Retry!\");"; ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
                }
                else if (txtJoining_Date.Text == "nbsp;" || txtJoining_Date.Text == "" || txtJoining_Date.Text == String.Empty)
                {
                    string script = "alert(\"Please Enter Joining Date,Please Retry!\");"; ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
                }
                else if (txtfrom.Text == "nbsp;" || txtfrom.Text == "" || txtfrom.Text == String.Empty)
                {
                    string script = "alert(\"Please Eneter Registration From Date ,Please Retry!\");"; ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
                }
                else if (txtto.Text == "nbsp;" || txtto.Text == "" || txtto.Text == String.Empty)
                {
                    string script = "alert(\"Please Enter Registration To Date,Please Retry!\");"; ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
                }
                else if (ddlDrive_name.SelectedIndex == 0)
                {
                    insert();
                    clear();
                }
                else
                {
                    update();
                    clear();
                }
                
            }

            catch (Exception ex)
            {
                Response.Write("Oops! error occured :" + ex.Message.ToString());
            }
            finally
            {
                bal_D = null;
                bel_D = null;
            }
        }
        protected void insert()
        {
            try
            {
                try
                {
                    string cmdstr = "select count(*) from Add_Update_Drive where Drive_Title='" + txtDrive_Title.Text + " (" + ddlCompany_ID.SelectedValue + ")" + "' ";
                    con.Open();
                    SqlCommand cmd2 = new SqlCommand(cmdstr, con);
                    int count2 = (int)cmd2.ExecuteScalar();
                    con.Close();
                    if (count2 == 0)
                    {
                        Add_Courses_checklistbox();
                        bel_D.bel_Academic_Year = ddlAcademic_Year.SelectedItem.Text;
                        bel_D.bel_Company_ID = ddlCompany_ID.SelectedValue;
                        bel_D.bel_Company_name = txtcompany_name.Text;
                        bel_D.bel_Drive_Title = txtDrive_Title.Text + " (" + ddlCompany_ID.SelectedValue + ")";
                        bel_D.bel_Post_Opened = txtPost_Opened.Text;
                        bel_D.bel_Job_Type = txtJob_Type.Text;
                        bel_D.bel_Job_Profile = txtJob_Profile.Text;
                        bel_D.bel_Salary = txtSalary.Text;
                        bel_D.bel_Vacancies = txtVacancies.Text;
                        bel_D.bel_Bond = ddlbond.SelectedItem.Text;
                        bel_D.bel_Bond_Duration = txtBond_Duration.Text;
                        bel_D.bel_Bond_Amount = txtBond_Amount.Text;
                        bel_D.bel_Bond_Terms = txtBond_Terms.Text;
                        bel_D.bel_Security_Deposite = txtSecurity_Deposite.Text;
                        bel_D.bel_Joining_Date = txtJoining_Date.Text;
                        bel_D.bel_Gender_Allowed = ddlGender_Allowed.SelectedItem.Text;
                        bel_D.bel_Recruitment_Method = txtRecruitment_Method.Text;
                        bel_D.bel_Job_Location = txtJob_Location.Text;
                        bel_D.bel_Reg_From_Date = txtfrom.Text;
                        bel_D.bel_Reg_To_Date = txtto.Text;
                        bel_D.bel_Doc_Needed = txtdoc_Needed.Text;
                        bel_D.bel_Remark = txtRemark.Text;
                        bel_D.bel_Company_Coordinator = txtCompany_Coordinator.Text;
                        bel_D.bel_Company_Designation = txtCompany_Designation.Text;
                        bel_D.bel_Company_Contact = txtcompany_contact.Text;
                        bel_D.bel_Institute_Coordinator = txtInstitute_Coordi.Text;
                        bel_D.bel_Institute_Designation = txtInstitute_Designation.Text;
                        bel_D.bel_Institute_Contact = txtInstitute_Contact.Text;
                        bel_D.bel_Courses = txtCourses.Text;
                        int retVal = bal_D.add_Drive(bel_D);

                        if (retVal > 0)
                        {
                            string script = "alert(\"Drive Registration Successfully!\");"; ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
                        }
                        else
                        {
                            string script = "alert(\"Drive details couldn't be Saved!\");"; ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
                        }
                    }
                    else
                    {
                        string script = "alert(\"Drive title Already Existing, PLease Enter New Drive title!\");"; ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
                    }
                }
                catch (Exception ex)
                {
                    Response.Write("Oops! error occured :" + ex.Message.ToString());
                }
                finally
                {
                    bal_D = null;
                    bel_D = null;
                }
            }
            catch (Exception ex)
            {
                Response.Write("Oops! error occured :" + ex.Message.ToString());
            }
        }
        protected void update()
        {
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                    string strquery = "delete from Add_Drice_Courses where Drive_ID = '" + ddlDrive_name.SelectedValue + "'";
                    cmd = new SqlCommand(strquery, con);
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
                Update_Courses_checklistbox();
                bel_D.bel_id = ddlDrive_name.SelectedValue;
                bel_D.bel_Academic_Year = ddlAcademic_Year.SelectedItem.Text;
                bel_D.bel_Company_ID = ddlCompany_ID.SelectedValue;
                bel_D.bel_Company_name = txtcompany_name.Text;
                bel_D.bel_Drive_Title = txtDrive_Title.Text;
                bel_D.bel_Post_Opened = txtPost_Opened.Text;
                bel_D.bel_Job_Type = txtJob_Type.Text;
                bel_D.bel_Job_Profile = txtJob_Profile.Text;
                bel_D.bel_Salary = txtSalary.Text;
                bel_D.bel_Vacancies = txtVacancies.Text;
                bel_D.bel_Bond = ddlbond.SelectedItem.Text;
                bel_D.bel_Bond_Duration = txtBond_Duration.Text;
                bel_D.bel_Bond_Amount = txtBond_Amount.Text;
                bel_D.bel_Bond_Terms = txtBond_Terms.Text;
                bel_D.bel_Security_Deposite = txtSecurity_Deposite.Text;
                bel_D.bel_Joining_Date = txtJoining_Date.Text;
                bel_D.bel_Gender_Allowed = ddlGender_Allowed.SelectedItem.Text;
                bel_D.bel_Recruitment_Method = txtRecruitment_Method.Text;
                bel_D.bel_Job_Location = txtJob_Location.Text;
                bel_D.bel_Reg_From_Date = txtfrom.Text;
                bel_D.bel_Reg_To_Date = txtto.Text;
                bel_D.bel_Doc_Needed = txtdoc_Needed.Text;
                bel_D.bel_Remark = txtRemark.Text;
                bel_D.bel_Company_Coordinator = txtCompany_Coordinator.Text;
                bel_D.bel_Company_Designation = txtCompany_Designation.Text;
                bel_D.bel_Company_Contact = txtcompany_contact.Text;
                bel_D.bel_Institute_Coordinator = txtInstitute_Coordi.Text;
                bel_D.bel_Institute_Designation = txtInstitute_Designation.Text;
                bel_D.bel_Institute_Contact = txtInstitute_Contact.Text;
                bel_D.bel_Courses = txtCourses.Text;

                try
                {
                    int retVal = bal_D.update_Drive(bel_D);
                    if (retVal > 0)
                    {
                        string script = "alert(\"Drive Successfully Updated!\");"; ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
                     }
                    else
                    {
                        string script = "alert(\"Drive couldn't be updated!\");"; ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
                    }
                }
                catch (Exception ex)
                {
                    Response.Write("Oops! error occured :" + ex.Message.ToString());
                }
                finally
                {
                    bal_D = null;
                    bel_D = null;
                }
            }
            catch (Exception ex)
            {
                Response.Write("Oops! error occured :" + ex.Message.ToString());
            }
        }
        private void Add_Courses_checklistbox()
        {
            txtCourses.Text = "";
            //int j = 1;
            for (int i = 0; i <= checkCourses.Items.Count - 1; i++)
            {
                if (checkCourses.Items[i].Selected)//changed 1 to i 
                {
                    txtCourses.Text += checkCourses.Items[i].Value + ","; //changed 1 to i
                }
                //if (j < checkCourses.Items.Count)//changed 1 to i 
                //{
                //    txtCourses.Text += ","; //changed 1 to i
                //    j++;
                //}
            }
        }
        private void Update_Courses_checklistbox()
        {
            txtCourses.Text = "";
            for (int i = 0; i <= checkCourses.Items.Count - 1; i++)
            {
                if (checkCourses.Items[i].Selected)//changed 1 to i 
                {
                    txtCourses.Text += checkCourses.Items[i].Value; //changed 1 to i
                    if (con.State == ConnectionState.Closed)
                    {
                        con.Open();
                        string strquery = "INSERT into Add_Drice_Courses (Drive_ID,Courses_Id) values('" + ddlDrive_name.SelectedValue + "','" + checkCourses.Items[i].Value + "')";
                        cmd = new SqlCommand(strquery, con);
                        cmd.ExecuteNonQuery();
                        con.Close();
                    }
                }
                //if (j < checkCourses.Items.Count)//changed 1 to i 
                //{
                //    txtCourses.Text += ","; //changed 1 to i
                //    j++;
                //}
            }
        }
        private void CheckboxsItems()
        {
            SqlDataAdapter da = new SqlDataAdapter("Select Courses_Id from Add_Drice_Courses where Drive_ID ='" + ddlDrive_name.SelectedValue + "' ", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            int count = dt.Rows.Count;
            for (int i = 0; i <= count - 1; i++)
            {
                int str = Convert.ToInt32(dt.Rows[i][0]);
                foreach (ListItem item in checkCourses.Items)
                {
                    int j = Convert.ToInt32(item.Value);
                    if (str == j)
                    {
                        item.Selected = true;
                    }
                }
            }
        }
        protected void tbnclear_Click(object sender, EventArgs e)
        {
            clear();
        }
        protected void clear()
        {
            try
            {
                ddlAcademic_Year.SelectedIndex = 0;
                ddlCompany_ID.SelectedIndex = 0;
                txtcompany_name.Text = "";
                txtDrive_Title.Text = "";
                txtPost_Opened.Text = "";
                txtJob_Type.Text = "";
                txtJob_Profile.Text = "";
                txtSalary.Text = "";
                txtVacancies.Text = "";
                ddlbond.SelectedIndex = 0;
                txtBond_Duration.Text = "";
                txtBond_Amount.Text = "";
                txtBond_Terms.Text = "";
                txtSecurity_Deposite.Text = "";
                txtJoining_Date.Text = "";
                ddlGender_Allowed.SelectedIndex = 0;
                txtRecruitment_Method.Text = "";
                txtJob_Location.Text = "";
                txtfrom.Text = "";
                txtto.Text = "";
                txtdoc_Needed.Text = "";
                txtRemark.Text = "";
                txtCompany_Coordinator.Text = "";
                txtCompany_Designation.Text = "";
                txtcompany_contact.Text = "";
                txtInstitute_Coordi.Text = "";
                txtInstitute_Designation.Text = "";
                txtInstitute_Contact.Text = "";
                txtCourses.Text = "";
                checkCourses.ClearSelection();
                bind_DriveTitle();
            }
            catch (Exception ex)
            {
                Response.Write("Oops! error occured :" + ex.Message.ToString());
            }
        }

    }
}