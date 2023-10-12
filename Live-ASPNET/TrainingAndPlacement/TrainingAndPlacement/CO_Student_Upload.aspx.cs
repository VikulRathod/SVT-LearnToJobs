using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

using BAL;
using System.Data.SqlClient;
using System.Data.OleDb;
namespace TrainingAndPlacement
{
    public partial class CO_Student_Upload : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["myConnectionString"].ConnectionString);
        bal_Dept bal = new bal_Dept();
        int emailcount = 0;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                bind_Department();
            }
            linkblack.NavigateUrl = "~/doc/Black.xlsx";
            linkdemo.NavigateUrl = "~/doc/Demo.xlsx";
        }
        protected void bind_Department()
        {
            {
                DataSet ds = bal.gvDepartment_Bind();
                ddlCourse_Name.DataSource = ds;
                ddlCourse_Name.DataTextField = "Department";
                ddlCourse_Name.DataValueField = "Id";
                ddlCourse_Name.DataBind();
                ddlCourse_Name.Items.Insert(0, new ListItem("---Select----", string.Empty));
            }
        }
        protected void btnUpload_Click(object sender, EventArgs e)
        {
            try
            {
                if (ddlAcademic.SelectedIndex == 0)
                {
                    string script = "alert(\"Please select Academic Year!\");"; ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
                }
                else if (ddlCourse_Name.SelectedIndex == 0)
                {
                    string script = "alert(\"Please select Course Name!\");"; ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
                }
                else if (FileUpload1.HasFile)
                {
                    OleDbConnection conn;
                    OleDbCommand cmd;
                    OleDbDataAdapter da;
                    DataSet ds;
                    string query;
                    string connString = "";
                    string strFileName = FileUpload1.FileName;
                    //Label24.Text = strFileName;
                    string strFileType = System.IO.Path.GetExtension(FileUpload1.FileName).ToString().ToLower();

                    // Check file type
                    if (strFileType.Trim() == ".xls" || strFileType.Trim() == ".xlsx")
                    {
                        FileUpload1.SaveAs(Server.MapPath(("~/temp/" + (strFileName + strFileType))));
                    }
                    else
                    {
                        //Label23.Text = "Only excel files allowed.";
                        //Label23.ForeColor = Drawing.Color.Red;
                        // Label23.Visible = true;
                        //Panel11.Visible = false;
                        gmStudent_Regi.Visible = false;
                        return;
                    }
                    string strNewPath = Server.MapPath(("~/temp/" + (strFileName + strFileType)));
                    // Connection String to Excel Workbook
                    if (strFileType.Trim() == ".xls")
                    {
                        connString = ("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + (strNewPath + ";Extended Properties=\"Excel 8.0;HDR=Yes;IMEX=2\""));
                    }
                    else if (strFileType.Trim() == ".xlsx")
                    {
                        connString = ("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + (strNewPath + ";Extended Properties=\"Excel 12.0;HDR=Yes;IMEX=2\""));
                    }
                    query = "SELECT * FROM [Sheet1$]";
                    conn = new OleDbConnection(connString);
                    // Open connection
                    if ((conn.State == ConnectionState.Closed))
                    {
                        conn.Open();
                    }
                    // Create the command object
                    cmd = new OleDbCommand(query, conn);
                    da = new OleDbDataAdapter(cmd);
                    ds = new DataSet();
                    da.Fill(ds);
                    gmStudent_Regi.DataSource = ds.Tables[0];
                    gmStudent_Regi.DataBind();
                    string script = "alert(\"information retrieved successfully. Press save button.!\");"; ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
                    //Label23.Text = "information retrieved successfully. Press save button.";
                    //Label27.Visible = true;
                    //Panel11.Visible = true;
                    //Panel18.Visible = true;
                    gmStudent_Regi.Visible = true;
                    da.Dispose();
                    conn.Close();
                    conn.Dispose();
                }
                else
                {
                    string script = "alert(\"Please select an excel file first.!\");"; ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
                    //Label23.Text = "Please select an excel file first.";
                    //Panel11.Visible = false;
                    gmStudent_Regi.Visible = false;
                    //Label23.Visible = true;
                }
            }

            catch (Exception ex)
            {
                Response.Write("Oops! error occured :" + ex.Message.ToString());
            }
            //finally
            //{
            //    bal = null;
            //    bel = null;
            //}

        }
        protected void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                //string ayear,dept,adharno,name,email,contactno;
                con.Open();
                DataTable dt = new DataTable();
                DataTable dt1 = new DataTable();
                dt.Columns.Add("Academic_Year", typeof(string));
                dt.Columns.Add("Course_Name", typeof(string));
                dt.Columns.Add("Aadhaar_No", typeof(string));
                dt.Columns.Add("University_Reg_No", typeof(string));
                dt.Columns.Add("Class_ID", typeof(string));
                dt.Columns.Add("Roll_No", typeof(string));
                dt.Columns.Add("Student_Name", typeof(string));
                dt.Columns.Add("Email", typeof(string));
                dt.Columns.Add("Contact_No", typeof(string));
                dt.Columns.Add("alt_contact_no", typeof(string));
                dt.Columns.Add("Mother_Name", typeof(string));
                dt.Columns.Add("Gender", typeof(string));
                dt.Columns.Add("DOB", typeof(string));
                dt.Columns.Add("Blood_Group", typeof(string));
                dt.Columns.Add("Mother_Tongue", typeof(string));
                dt.Columns.Add("Languages", typeof(string));
                dt.Columns.Add("Admission_Date", typeof(string));
                dt.Columns.Add("Address", typeof(string));
                dt.Columns.Add("Nationality", typeof(string));
                dt.Columns.Add("Domicile", typeof(string));
                dt.Columns.Add("Religion", typeof(string));
                dt.Columns.Add("Category", typeof(string));
                dt.Columns.Add("Caste", typeof(string));
                dt.Columns.Add("Hostelite", typeof(string));
                dt.Columns.Add("Handicap", typeof(string));
                dt.Columns.Add("Sport", typeof(string));
                dt.Columns.Add("Defence", typeof(string));
                dt.Columns.Add("PAN_No", typeof(string));
                dt.Columns.Add("Passport_No", typeof(string));
                dt.Columns.Add("Driving_License", typeof(string));
                dt.Columns.Add("F_Name", typeof(string));
                dt.Columns.Add("F_Contact", typeof(string));
                dt.Columns.Add("F_Email", typeof(string));
                dt.Columns.Add("F_Occupation", typeof(string));
                dt.Columns.Add("F_Organization", typeof(string));
                dt.Columns.Add("F_Designation", typeof(string));
                dt.Columns.Add("F_Address", typeof(string));
                dt.Columns.Add("F_Annual_Income", typeof(string));
                dt.Columns.Add("SSC_Board", typeof(string));
                dt.Columns.Add("SSC_Institute", typeof(string));
                dt.Columns.Add("SSC_Percentage", typeof(string));
                dt.Columns.Add("SSC_Passed_Year", typeof(string));
                dt.Columns.Add("SSC_Attempt", typeof(string));
                dt.Columns.Add("HSC_Board", typeof(string));
                dt.Columns.Add("HSC_Institute", typeof(string));
                dt.Columns.Add("HSC_Percentage", typeof(string));
                dt.Columns.Add("HSC_Passed_Year", typeof(string));
                dt.Columns.Add("HSC_Attempt", typeof(string));
                dt.Columns.Add("Diploma_Board", typeof(string));
                dt.Columns.Add("Diploma_Institute", typeof(string));
                dt.Columns.Add("Diploma_Percentage", typeof(string));
                dt.Columns.Add("Diploma_Passed_Year", typeof(string));
                dt.Columns.Add("Diploma_Attempt", typeof(string));
                dt.Columns.Add("UG_Board", typeof(string));
                dt.Columns.Add("UG_Institute", typeof(string));
                dt.Columns.Add("UG_Percentage", typeof(string));
                dt.Columns.Add("UG_Passed_Year", typeof(string));
                dt.Columns.Add("UG_Attempt", typeof(string));
                dt.Columns.Add("PG_Board", typeof(string));
                dt.Columns.Add("PG_Institute", typeof(string));
                dt.Columns.Add("PG_Percentage", typeof(string));
                dt.Columns.Add("PG_Passed_Year", typeof(string));
                dt.Columns.Add("PG_Attempt", typeof(string));
                dt.Columns.Add("Sem1_Obtained_Marks", typeof(string));
                dt.Columns.Add("Sem1_Total_Marks", typeof(string));
                dt.Columns.Add("Sem1_Percentage", typeof(string));
                dt.Columns.Add("Sem1_SGPA", typeof(string));
                dt.Columns.Add("Sem1_BackLog", typeof(string));
                dt.Columns.Add("Sem2_Obtained_Marks", typeof(string));
                dt.Columns.Add("Sem2_Total_Marks", typeof(string));
                dt.Columns.Add("Sem2_Percentage", typeof(string));
                dt.Columns.Add("Sem2_SGPA", typeof(string));
                dt.Columns.Add("Sem2_BackLog", typeof(string));
                dt.Columns.Add("Sem3_Obtained_Marks", typeof(string));
                dt.Columns.Add("Sem3_Total_Marks", typeof(string));
                dt.Columns.Add("Sem3_Percentage", typeof(string));
                dt.Columns.Add("Sem3_SGPA", typeof(string));
                dt.Columns.Add("Sem3_BackLog", typeof(string));
                dt.Columns.Add("Sem4_Obtained_Marks", typeof(string));
                dt.Columns.Add("Sem4_Total_Marks", typeof(string));
                dt.Columns.Add("Sem4_Percentage", typeof(string));
                dt.Columns.Add("Sem4_SGPA", typeof(string));
                dt.Columns.Add("Sem4_BackLog", typeof(string));
                dt.Columns.Add("Sem5_Obtained_Marks", typeof(string));
                dt.Columns.Add("Sem5_Total_Marks", typeof(string));
                dt.Columns.Add("Sem5_Percentage", typeof(string));
                dt.Columns.Add("Sem5_SGPA", typeof(string));
                dt.Columns.Add("Sem5_BackLog", typeof(string));
                dt.Columns.Add("Sem6_Obtained_Marks", typeof(string));
                dt.Columns.Add("Sem6_Total_Marks", typeof(string));
                dt.Columns.Add("Sem6_Percentage", typeof(string));
                dt.Columns.Add("Sem6_SGPA", typeof(string));
                dt.Columns.Add("Sem6_BackLog", typeof(string));
                dt.Columns.Add("Sem7_Obtained_Marks", typeof(string));
                dt.Columns.Add("Sem7_Total_Marks", typeof(string));
                dt.Columns.Add("Sem7_Percentage", typeof(string));
                dt.Columns.Add("Sem7_SGPA", typeof(string));
                dt.Columns.Add("Sem7_BackLog", typeof(string));
                dt.Columns.Add("Sem8_Obtained_Marks", typeof(string));
                dt.Columns.Add("Sem8_Total_Marks", typeof(string));
                dt.Columns.Add("Sem8_Percentage", typeof(string));
                dt.Columns.Add("Sem8_SGPA", typeof(string));
                dt.Columns.Add("Sem8_BackLog", typeof(string));
                dt.Columns.Add("Year1_Obtained_Marks", typeof(string));
                dt.Columns.Add("Year1_Total_Marks", typeof(string));
                dt.Columns.Add("Year1_Percentage", typeof(string));
                dt.Columns.Add("Year1_SGPA", typeof(string));
                dt.Columns.Add("Year1_BackLog", typeof(string));
                dt.Columns.Add("Year2_Obtained_Marks", typeof(string));
                dt.Columns.Add("Year2_Total_Marks", typeof(string));
                dt.Columns.Add("Year2_Percentage", typeof(string));
                dt.Columns.Add("Year2_SGPA", typeof(string));
                dt.Columns.Add("Year2_BackLog", typeof(string));
                dt.Columns.Add("Year3_Obtained_Marks", typeof(string));
                dt.Columns.Add("Year3_Total_Marks", typeof(string));
                dt.Columns.Add("Year3_Percentage", typeof(string));
                dt.Columns.Add("Year3_SGPA", typeof(string));
                dt.Columns.Add("Year3_BackLog", typeof(string));
                dt.Columns.Add("Year4_Obtained_Marks", typeof(string));
                dt.Columns.Add("Year4_Total_Marks", typeof(string));
                dt.Columns.Add("Year4_Percentage", typeof(string));
                dt.Columns.Add("Year4_SGPA", typeof(string));
                dt.Columns.Add("Year4_BackLog", typeof(string));
                dt.Columns.Add("Year5_Obtained_Marks", typeof(string));
                dt.Columns.Add("Year5_Total_Marks", typeof(string));
                dt.Columns.Add("Year5_Percentage", typeof(string));
                dt.Columns.Add("Year5_SGPA", typeof(string));
                dt.Columns.Add("Year5_BackLog", typeof(string));
                dt.Columns.Add("Gap_Year", typeof(string));
                dt.Columns.Add("Live_Backlogs", typeof(string));
                dt.Columns.Add("Dead_Backlogs", typeof(string));
                dt.Columns.Add("Experience", typeof(string));
                dt.Columns.Add("Entrance_Score", typeof(string));
                dt.Columns.Add("Aggregate", typeof(string));
                dt.Columns.Add("status", typeof(string));
                dt.Columns.Add("Approuvel", typeof(string));

                //Login Details
                dt1.Columns.Add("username", typeof(string));
                dt1.Columns.Add("login_password", typeof(string));
                dt1.Columns.Add("login_role", typeof(string));
                dt1.Columns.Add("status", typeof(string));

                foreach (GridViewRow row in gmStudent_Regi.Rows)
                {
                    if (row.Cells[7].Text != "" && row.Cells[7].Text != "&nbsp;")
                    {
                        string cmdstr = "select count(*) from Student_Registration where Email='" + row.Cells[7].Text + "' ";
                        SqlCommand cmd2 = new SqlCommand(cmdstr, con);
                        int count2 = (int)cmd2.ExecuteScalar();
                        if (count2 == 0)
                        {
                            string cmdstr1 = "select count(*) from Placement_Login where username='" + row.Cells[7].Text + "' ";
                            SqlCommand cmd1 = new SqlCommand(cmdstr1, con);
                            int count1 = (int)cmd1.ExecuteScalar();
                            if (count1 == 0)
                            {
                                //Student Registration
                                dt.Rows.Add(ddlAcademic.SelectedValue, ddlCourse_Name.SelectedValue, row.Cells[2].Text, row.Cells[3].Text, row.Cells[4].Text, row.Cells[5].Text, row.Cells[6].Text, row.Cells[7].Text, row.Cells[8].Text, row.Cells[9].Text, row.Cells[10].Text, row.Cells[11].Text, row.Cells[12].Text, row.Cells[13].Text, row.Cells[14].Text, row.Cells[15].Text, row.Cells[16].Text, row.Cells[17].Text, row.Cells[18].Text, row.Cells[19].Text, row.Cells[20].Text, row.Cells[21].Text, row.Cells[22].Text
                                    , row.Cells[23].Text, row.Cells[24].Text, row.Cells[25].Text, row.Cells[26].Text, row.Cells[27].Text, row.Cells[28].Text, row.Cells[29].Text, row.Cells[30].Text, row.Cells[31].Text, row.Cells[32].Text, row.Cells[33].Text, row.Cells[34].Text, row.Cells[35].Text, row.Cells[36].Text, row.Cells[37].Text, row.Cells[38].Text, row.Cells[39].Text, row.Cells[40].Text, row.Cells[41].Text, row.Cells[42].Text, row.Cells[43].Text
                                    , row.Cells[44].Text, row.Cells[45].Text, row.Cells[46].Text, row.Cells[47].Text, row.Cells[48].Text, row.Cells[49].Text, row.Cells[50].Text, row.Cells[51].Text, row.Cells[52].Text, row.Cells[53].Text, row.Cells[54].Text, row.Cells[55].Text, row.Cells[56].Text, row.Cells[57].Text, row.Cells[58].Text, row.Cells[59].Text, row.Cells[60].Text, row.Cells[61].Text, row.Cells[62].Text, row.Cells[63].Text
                                    , row.Cells[64].Text, row.Cells[65].Text, row.Cells[66].Text, row.Cells[67].Text, row.Cells[68].Text, row.Cells[69].Text, row.Cells[70].Text, row.Cells[71].Text, row.Cells[72].Text, row.Cells[73].Text, row.Cells[74].Text, row.Cells[75].Text, row.Cells[76].Text, row.Cells[77].Text, row.Cells[78].Text, row.Cells[79].Text, row.Cells[80].Text, row.Cells[81].Text, row.Cells[82].Text, row.Cells[83].Text, row.Cells[84].Text
                                    , row.Cells[85].Text, row.Cells[86].Text, row.Cells[87].Text, row.Cells[88].Text, row.Cells[89].Text, row.Cells[90].Text, row.Cells[91].Text, row.Cells[92].Text, row.Cells[93].Text, row.Cells[94].Text, row.Cells[95].Text, row.Cells[96].Text, row.Cells[97].Text, row.Cells[98].Text, row.Cells[99].Text, row.Cells[100].Text, row.Cells[101].Text, row.Cells[102].Text, row.Cells[103].Text, row.Cells[104].Text, row.Cells[105].Text, row.Cells[106].Text
                                    , row.Cells[107].Text, row.Cells[108].Text, row.Cells[109].Text, row.Cells[110].Text, row.Cells[111].Text, row.Cells[112].Text, row.Cells[113].Text, row.Cells[114].Text, row.Cells[115].Text, row.Cells[116].Text, row.Cells[117].Text, row.Cells[118].Text, row.Cells[119].Text, row.Cells[120].Text, row.Cells[121].Text, row.Cells[122].Text, row.Cells[123].Text, row.Cells[124].Text, row.Cells[125].Text, row.Cells[126].Text, row.Cells[127].Text
                                    , row.Cells[128].Text, row.Cells[129].Text, row.Cells[130].Text, row.Cells[131].Text, row.Cells[132].Text, row.Cells[133].Text, "Active", "No");
                                //Login Details
                                dt1.Rows.Add(row.Cells[7].Text, row.Cells[7].Text, "Student", "Active");

                                //Send Notification
                                Session["Send_Email"] += row.Cells[7].Text;
                                Session["Send_SMS"] += row.Cells[8].Text;
                            }
                            else
                            {
                                emailcount++;
                                string script = "alert(\"Student Email Id Already Existing, PLease Enter New Email Id!\");"; ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
                            }
                        }
                        else
                        {
                            emailcount++;
                            string script = "alert(\"Student Email Id Already Existing, PLease Enter New Email Id!\");"; ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
                        }
                    }
                    else
                    {
                        emailcount++;
                    }
                }
                if (emailcount == 0)
                {
                    if (dt.Rows.Count > 0)
                    {
                        // Dim conString As String = ConfigurationManager.ConnectionStrings("conStr").ConnectionString
                        // Using con As New SqlConnection(conString)
                        using (SqlBulkCopy sqlBulkCopy = new SqlBulkCopy(con))
                        {
                            // Set the database table name in which records will be inserted in bulk
                            sqlBulkCopy.DestinationTableName = "Student_Registration";

                            // Map the DataTable columns with that of the database table. Optional if database table column and datatable columns names are same
                            sqlBulkCopy.ColumnMappings.Add("Academic_Year", "Academic_Year");
                            sqlBulkCopy.ColumnMappings.Add("Course_Name", "Course_Name");
                            sqlBulkCopy.ColumnMappings.Add("Aadhaar_No", "Aadhaar_No");
                            sqlBulkCopy.ColumnMappings.Add("University_Reg_No", "University_Reg_No");
                            sqlBulkCopy.ColumnMappings.Add("Class_ID", "Class_ID");
                            sqlBulkCopy.ColumnMappings.Add("Roll_No", "Roll_No");
                            sqlBulkCopy.ColumnMappings.Add("Student_Name", "Student_Name");
                            sqlBulkCopy.ColumnMappings.Add("Email", "Email");
                            sqlBulkCopy.ColumnMappings.Add("Contact_No", "Contact_No");
                            sqlBulkCopy.ColumnMappings.Add("alt_contact_no", "alt_contact_no");
                            sqlBulkCopy.ColumnMappings.Add("Mother_Name", "Mother_Name");
                            sqlBulkCopy.ColumnMappings.Add("Gender", "Gender");
                            sqlBulkCopy.ColumnMappings.Add("DOB", "DOB");
                            sqlBulkCopy.ColumnMappings.Add("Blood_Group", "Blood_Group");
                            sqlBulkCopy.ColumnMappings.Add("Mother_Tongue", "Mother_Tongue");
                            sqlBulkCopy.ColumnMappings.Add("Languages", "Languages");
                            sqlBulkCopy.ColumnMappings.Add("Admission_Date", "Admission_Date");
                            sqlBulkCopy.ColumnMappings.Add("Address", "Address");
                            sqlBulkCopy.ColumnMappings.Add("Nationality", "Nationality");
                            sqlBulkCopy.ColumnMappings.Add("Domicile", "Domicile");
                            sqlBulkCopy.ColumnMappings.Add("Religion", "Religion");
                            sqlBulkCopy.ColumnMappings.Add("Category", "Category");
                            sqlBulkCopy.ColumnMappings.Add("Caste", "Caste");
                            sqlBulkCopy.ColumnMappings.Add("Hostelite", "Hostelite");
                            sqlBulkCopy.ColumnMappings.Add("Handicap", "Handicap");
                            sqlBulkCopy.ColumnMappings.Add("Sport", "Sport");
                            sqlBulkCopy.ColumnMappings.Add("Defence", "Defence");
                            sqlBulkCopy.ColumnMappings.Add("PAN_No", "PAN_No");
                            sqlBulkCopy.ColumnMappings.Add("Passport_No", "Passport_No");
                            sqlBulkCopy.ColumnMappings.Add("Driving_License", "Driving_License");
                            sqlBulkCopy.ColumnMappings.Add("F_Name", "F_Name");
                            sqlBulkCopy.ColumnMappings.Add("F_Contact", "F_Contact");
                            sqlBulkCopy.ColumnMappings.Add("F_Email", "F_Email");
                            sqlBulkCopy.ColumnMappings.Add("F_Occupation", "F_Occupation");
                            sqlBulkCopy.ColumnMappings.Add("F_Organization", "F_Organization");
                            sqlBulkCopy.ColumnMappings.Add("F_Designation", "F_Designation");
                            sqlBulkCopy.ColumnMappings.Add("F_Address", "F_Address");
                            sqlBulkCopy.ColumnMappings.Add("F_Annual_Income", "F_Annual_Income");
                            sqlBulkCopy.ColumnMappings.Add("SSC_Board", "SSC_Board");
                            sqlBulkCopy.ColumnMappings.Add("SSC_Institute", "SSC_Institute");
                            sqlBulkCopy.ColumnMappings.Add("SSC_Percentage", "SSC_Percentage");
                            sqlBulkCopy.ColumnMappings.Add("SSC_Passed_Year", "SSC_Passed_Year");
                            sqlBulkCopy.ColumnMappings.Add("SSC_Attempt", "SSC_Attempt");
                            sqlBulkCopy.ColumnMappings.Add("HSC_Board", "HSC_Board");
                            sqlBulkCopy.ColumnMappings.Add("HSC_Institute", "HSC_Institute");
                            sqlBulkCopy.ColumnMappings.Add("HSC_Percentage", "HSC_Percentage");
                            sqlBulkCopy.ColumnMappings.Add("HSC_Passed_Year", "HSC_Passed_Year");
                            sqlBulkCopy.ColumnMappings.Add("HSC_Attempt", "HSC_Attempt");
                            sqlBulkCopy.ColumnMappings.Add("Diploma_Board", "Diploma_Board");
                            sqlBulkCopy.ColumnMappings.Add("Diploma_Institute", "Diploma_Institute");
                            sqlBulkCopy.ColumnMappings.Add("Diploma_Percentage", "Diploma_Percentage");
                            sqlBulkCopy.ColumnMappings.Add("Diploma_Passed_Year", "Diploma_Passed_Year");
                            sqlBulkCopy.ColumnMappings.Add("Diploma_Attempt", "Diploma_Attempt");
                            sqlBulkCopy.ColumnMappings.Add("UG_Board", "UG_Board");
                            sqlBulkCopy.ColumnMappings.Add("UG_Institute", "UG_Institute");
                            sqlBulkCopy.ColumnMappings.Add("UG_Percentage", "UG_Percentage");
                            sqlBulkCopy.ColumnMappings.Add("UG_Passed_Year", "UG_Passed_Year");
                            sqlBulkCopy.ColumnMappings.Add("UG_Attempt", "UG_Attempt");
                            sqlBulkCopy.ColumnMappings.Add("PG_Board", "PG_Board");
                            sqlBulkCopy.ColumnMappings.Add("PG_Institute", "PG_Institute");
                            sqlBulkCopy.ColumnMappings.Add("PG_Percentage", "PG_Percentage");
                            sqlBulkCopy.ColumnMappings.Add("PG_Passed_Year", "PG_Passed_Year");
                            sqlBulkCopy.ColumnMappings.Add("PG_Attempt", "PG_Attempt");
                            sqlBulkCopy.ColumnMappings.Add("Sem1_Obtained_Marks", "Sem1_Obtained_Marks");
                            sqlBulkCopy.ColumnMappings.Add("Sem1_Total_Marks", "Sem1_Total_Marks");
                            sqlBulkCopy.ColumnMappings.Add("Sem1_Percentage", "Sem1_Percentage");
                            sqlBulkCopy.ColumnMappings.Add("Sem1_SGPA", "Sem1_SGPA");
                            sqlBulkCopy.ColumnMappings.Add("Sem1_BackLog", "Sem1_BackLog");
                            sqlBulkCopy.ColumnMappings.Add("Sem2_Obtained_Marks", "Sem2_Obtained_Marks");
                            sqlBulkCopy.ColumnMappings.Add("Sem2_Total_Marks", "Sem2_Total_Marks");
                            sqlBulkCopy.ColumnMappings.Add("Sem2_Percentage", "Sem2_Percentage");
                            sqlBulkCopy.ColumnMappings.Add("Sem2_SGPA", "Sem2_SGPA");
                            sqlBulkCopy.ColumnMappings.Add("Sem2_BackLog", "Sem2_BackLog");
                            sqlBulkCopy.ColumnMappings.Add("Sem3_Obtained_Marks", "Sem3_Obtained_Marks");
                            sqlBulkCopy.ColumnMappings.Add("Sem3_Total_Marks", "Sem3_Total_Marks");
                            sqlBulkCopy.ColumnMappings.Add("Sem3_Percentage", "Sem3_Percentage");
                            sqlBulkCopy.ColumnMappings.Add("Sem3_SGPA", "Sem3_SGPA");
                            sqlBulkCopy.ColumnMappings.Add("Sem3_BackLog", "Sem3_BackLog");
                            sqlBulkCopy.ColumnMappings.Add("Sem4_Obtained_Marks", "Sem4_Obtained_Marks");
                            sqlBulkCopy.ColumnMappings.Add("Sem4_Total_Marks", "Sem4_Total_Marks");
                            sqlBulkCopy.ColumnMappings.Add("Sem4_Percentage", "Sem4_Percentage");
                            sqlBulkCopy.ColumnMappings.Add("Sem4_SGPA", "Sem4_SGPA");
                            sqlBulkCopy.ColumnMappings.Add("Sem4_BackLog", "Sem4_BackLog");
                            sqlBulkCopy.ColumnMappings.Add("Sem5_Obtained_Marks", "Sem5_Obtained_Marks");
                            sqlBulkCopy.ColumnMappings.Add("Sem5_Total_Marks", "Sem5_Total_Marks");
                            sqlBulkCopy.ColumnMappings.Add("Sem5_Percentage", "Sem5_Percentage");
                            sqlBulkCopy.ColumnMappings.Add("Sem5_SGPA", "Sem5_SGPA");
                            sqlBulkCopy.ColumnMappings.Add("Sem5_BackLog", "Sem5_BackLog");
                            sqlBulkCopy.ColumnMappings.Add("Sem6_Obtained_Marks", "Sem6_Obtained_Marks");
                            sqlBulkCopy.ColumnMappings.Add("Sem6_Total_Marks", "Sem6_Total_Marks");
                            sqlBulkCopy.ColumnMappings.Add("Sem6_Percentage", "Sem6_Percentage");
                            sqlBulkCopy.ColumnMappings.Add("Sem6_SGPA", "Sem6_SGPA");
                            sqlBulkCopy.ColumnMappings.Add("Sem6_BackLog", "Sem6_BackLog");
                            sqlBulkCopy.ColumnMappings.Add("Sem7_Obtained_Marks", "Sem7_Obtained_Marks");
                            sqlBulkCopy.ColumnMappings.Add("Sem7_Total_Marks", "Sem7_Total_Marks");
                            sqlBulkCopy.ColumnMappings.Add("Sem7_Percentage", "Sem7_Percentage");
                            sqlBulkCopy.ColumnMappings.Add("Sem7_SGPA", "Sem7_SGPA");
                            sqlBulkCopy.ColumnMappings.Add("Sem7_BackLog", "Sem7_BackLog");
                            sqlBulkCopy.ColumnMappings.Add("Sem8_Obtained_Marks", "Sem8_Obtained_Marks");
                            sqlBulkCopy.ColumnMappings.Add("Sem8_Total_Marks", "Sem8_Total_Marks");
                            sqlBulkCopy.ColumnMappings.Add("Sem8_Percentage", "Sem8_Percentage");
                            sqlBulkCopy.ColumnMappings.Add("Sem8_SGPA", "Sem8_SGPA");
                            sqlBulkCopy.ColumnMappings.Add("Sem8_BackLog", "Sem8_BackLog");
                            sqlBulkCopy.ColumnMappings.Add("Year1_Obtained_Marks", "Year1_Obtained_Marks");
                            sqlBulkCopy.ColumnMappings.Add("Year1_Total_Marks", "Year1_Total_Marks");
                            sqlBulkCopy.ColumnMappings.Add("Year1_Percentage", "Year1_Percentage");
                            sqlBulkCopy.ColumnMappings.Add("Year1_SGPA", "Year1_SGPA");
                            sqlBulkCopy.ColumnMappings.Add("Year1_BackLog", "Year1_BackLog");
                            sqlBulkCopy.ColumnMappings.Add("Year2_Obtained_Marks", "Year2_Obtained_Marks");
                            sqlBulkCopy.ColumnMappings.Add("Year2_Total_Marks", "Year2_Total_Marks");
                            sqlBulkCopy.ColumnMappings.Add("Year2_Percentage", "Year2_Percentage");
                            sqlBulkCopy.ColumnMappings.Add("Year2_SGPA", "Year2_SGPA");
                            sqlBulkCopy.ColumnMappings.Add("Year2_BackLog", "Year2_BackLog");
                            sqlBulkCopy.ColumnMappings.Add("Year3_Obtained_Marks", "Year3_Obtained_Marks");
                            sqlBulkCopy.ColumnMappings.Add("Year3_Total_Marks", "Year3_Total_Marks");
                            sqlBulkCopy.ColumnMappings.Add("Year3_Percentage", "Year3_Percentage");
                            sqlBulkCopy.ColumnMappings.Add("Year3_SGPA", "Year3_SGPA");
                            sqlBulkCopy.ColumnMappings.Add("Year3_BackLog", "Year3_BackLog");
                            sqlBulkCopy.ColumnMappings.Add("Year4_Obtained_Marks", "Year4_Obtained_Marks");
                            sqlBulkCopy.ColumnMappings.Add("Year4_Total_Marks", "Year4_Total_Marks");
                            sqlBulkCopy.ColumnMappings.Add("Year4_Percentage", "Year4_Percentage");
                            sqlBulkCopy.ColumnMappings.Add("Year4_SGPA", "Year4_SGPA");
                            sqlBulkCopy.ColumnMappings.Add("Year4_BackLog", "Year4_BackLog");
                            sqlBulkCopy.ColumnMappings.Add("Year5_Obtained_Marks", "Year5_Obtained_Marks");
                            sqlBulkCopy.ColumnMappings.Add("Year5_Total_Marks", "Year5_Total_Marks");
                            sqlBulkCopy.ColumnMappings.Add("Year5_Percentage", "Year5_Percentage");
                            sqlBulkCopy.ColumnMappings.Add("Year5_SGPA", "Year5_SGPA");
                            sqlBulkCopy.ColumnMappings.Add("Year5_BackLog", "Year5_BackLog");
                            sqlBulkCopy.ColumnMappings.Add("Gap_Year", "Gap_Year");
                            sqlBulkCopy.ColumnMappings.Add("Live_Backlogs", "Live_Backlogs");
                            sqlBulkCopy.ColumnMappings.Add("Dead_Backlogs", "Dead_Backlogs");
                            sqlBulkCopy.ColumnMappings.Add("Experience", "Experience");
                            sqlBulkCopy.ColumnMappings.Add("Entrance_Score", "Entrance_Score");
                            sqlBulkCopy.ColumnMappings.Add("Aggregate", "Aggregate");
                            sqlBulkCopy.ColumnMappings.Add("status", "status");
                            sqlBulkCopy.ColumnMappings.Add("Approuvel", "Approuvel");
                            sqlBulkCopy.WriteToServer(dt);

                        }
                    }
                    else
                    {
                        string script = "alert(\"Record Not Found, Please Upload Excel file!\");"; ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
                    }
                    if (dt1.Rows.Count > 0)
                    {
                        // Using con As New SqlConnection(conString)
                        using (SqlBulkCopy BulkCopy = new SqlBulkCopy(con))
                        {
                            // Set the database table name in which records will be inserted in bulk
                            BulkCopy.DestinationTableName = "Placement_Login";

                            // Map the DataTable columns with that of the database table. Optional if database table column and datatable columns names are same
                            BulkCopy.ColumnMappings.Add("username", "username");
                            BulkCopy.ColumnMappings.Add("login_password", "login_password");
                            BulkCopy.ColumnMappings.Add("login_role", "login_role");
                            BulkCopy.ColumnMappings.Add("status", "status");
                            BulkCopy.WriteToServer(dt1);

                            string script = "alert(\"information saved successfully.!\");"; ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
                        }
                    }
                }
                else
                {
                    string script = "alert(\"Some Student Email Id Missing, Please Check Email Id Column then retry!\");"; ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
                }
                
                con.Close();
            }

            catch (Exception ex)
            {
                Response.Write("Oops! error occured :" + ex.Message.ToString());
            }

        }
        protected void btnsend_Click(object sender, EventArgs e)
        {
            try
            {
                if (Session["Send_Email"] != null && Session["Send_SMS"] != null)
                {
                    Response.Redirect("Send_Notification.aspx");
                }
                else
                {
                    string script = "alert(\"Student Not Added!\");"; ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
                }
            }
            catch (Exception ex)
            {
                Response.Write("Oops! error occured :" + ex.Message.ToString());
            }
        }
    }
}