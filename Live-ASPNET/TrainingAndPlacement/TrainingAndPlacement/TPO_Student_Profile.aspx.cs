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
using BEL;
using BAL;
namespace TrainingAndPlacement
{
    public partial class TPO_Student_Profile : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["myConnectionString"].ConnectionString);
        bal_Student bal_mem = new bal_Student();
        bel_Student bel_mem = new bel_Student();
        bal_Dept bal = new bal_Dept();
        SqlCommand cmd = new SqlCommand();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                bind_Department();
            }
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
        protected void Search_Click(object sender, EventArgs e)
        {
            student_Registration();
            bind_Project();
            bind_Technical_Details();
            bind_Activity();
            bind_Achievement();
        }
        protected void student_Registration()
        {
            try
            {
                if (txtStudID.Text == "")
                {
                    string script = "alert(\"Please Check Student Id!\");"; ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
                }
                else
                {
                    DataSet ds = new DataSet();
                    bel_mem.bel_id = txtStudID.Text;
                    ds = bal_mem.select(bel_mem);
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        txtacademic.Text = ds.Tables[0].Rows[0][1].ToString();
                        ddlCourse_Name.SelectedValue = ds.Tables[0].Rows[0][2].ToString();
                        txtcardno.Text = ds.Tables[0].Rows[0][3].ToString();
                        txtuni_regiNo.Text = ds.Tables[0].Rows[0][4].ToString();
                        txtClass_ID.Text = ds.Tables[0].Rows[0][5].ToString();
                        txtRoll_No.Text = ds.Tables[0].Rows[0][6].ToString();
                        txtStudent_Name.Text = ds.Tables[0].Rows[0][7].ToString();
                        txtEmail.Text = ds.Tables[0].Rows[0][8].ToString();
                        txtcontact.Text = ds.Tables[0].Rows[0][9].ToString();
                        txtalt_No.Text = ds.Tables[0].Rows[0][10].ToString();
                        txtMother_Name.Text = ds.Tables[0].Rows[0][11].ToString();
                        txtGender.Text = ds.Tables[0].Rows[0][12].ToString();
                        txtDateofBirth.Text = ds.Tables[0].Rows[0][13].ToString();
                        txtBlood.Text = ds.Tables[0].Rows[0][14].ToString();
                        txtMother_Tongue.Text = ds.Tables[0].Rows[0][15].ToString();
                        txtLanguages.Text = ds.Tables[0].Rows[0][16].ToString();
                        txtAdmissionDate.Text = ds.Tables[0].Rows[0][17].ToString();
                        txtAddress.Text = ds.Tables[0].Rows[0][18].ToString();
                        txtNationality.Text = ds.Tables[0].Rows[0][19].ToString();
                        txtDomicile.Text = ds.Tables[0].Rows[0][20].ToString();
                        txtReligion.Text = ds.Tables[0].Rows[0][21].ToString();
                        txtCategory.Text = ds.Tables[0].Rows[0][22].ToString();
                        txtCaste.Text = ds.Tables[0].Rows[0][23].ToString();
                        txtHostelite.Text = ds.Tables[0].Rows[0][24].ToString();
                        txtHandicap.Text = ds.Tables[0].Rows[0][25].ToString();
                        txtSport.Text = ds.Tables[0].Rows[0][26].ToString();
                        txtDefence.Text = ds.Tables[0].Rows[0][27].ToString();
                        txtPan.Text = ds.Tables[0].Rows[0][28].ToString();
                        txtPassport_No.Text = ds.Tables[0].Rows[0][29].ToString();
                        txtDriving_License.Text = ds.Tables[0].Rows[0][30].ToString();
                        txtFather.Text = ds.Tables[0].Rows[0][31].ToString();
                        txtfcontact.Text = ds.Tables[0].Rows[0][32].ToString();
                        txtfather_Email.Text = ds.Tables[0].Rows[0][33].ToString();
                        txtOccupation.Text = ds.Tables[0].Rows[0][34].ToString();
                        txtOrganization.Text = ds.Tables[0].Rows[0][35].ToString();
                        txtDesignation.Text = ds.Tables[0].Rows[0][36].ToString();
                        txtfAddress.Text = ds.Tables[0].Rows[0][37].ToString();
                        txtIncome.Text = ds.Tables[0].Rows[0][38].ToString();
                        txt10board.Text = ds.Tables[0].Rows[0][39].ToString();
                        txt10sub.Text = ds.Tables[0].Rows[0][40].ToString();
                        txt10percent.Text = ds.Tables[0].Rows[0][41].ToString();
                        txt10year.Text = ds.Tables[0].Rows[0][42].ToString();
                        txt10Attempt.Text = ds.Tables[0].Rows[0][43].ToString();
                        txt12board.Text = ds.Tables[0].Rows[0][44].ToString();
                        txt12sub.Text = ds.Tables[0].Rows[0][45].ToString();
                        txt12percent.Text = ds.Tables[0].Rows[0][46].ToString();
                        txt12year.Text = ds.Tables[0].Rows[0][47].ToString();
                        txt12Attempt.Text = ds.Tables[0].Rows[0][48].ToString();
                        txtdipboard.Text = ds.Tables[0].Rows[0][49].ToString();
                        txtdisub.Text = ds.Tables[0].Rows[0][50].ToString();
                        txtdipercent.Text = ds.Tables[0].Rows[0][51].ToString();
                        txtdiyear.Text = ds.Tables[0].Rows[0][52].ToString();
                        txtdiAttempt.Text = ds.Tables[0].Rows[0][53].ToString();
                        txtdeboard.Text = ds.Tables[0].Rows[0][54].ToString();
                        txtdesub.Text = ds.Tables[0].Rows[0][55].ToString();
                        txtdepercent.Text = ds.Tables[0].Rows[0][56].ToString();
                        txtdeyear.Text = ds.Tables[0].Rows[0][57].ToString();
                        txtdeAttempt.Text = ds.Tables[0].Rows[0][58].ToString();
                        txtpgeboard.Text = ds.Tables[0].Rows[0][59].ToString();
                        txtpgesub.Text = ds.Tables[0].Rows[0][60].ToString();
                        txtpgepercent.Text = ds.Tables[0].Rows[0][61].ToString();
                        txtpgeyear.Text = ds.Tables[0].Rows[0][62].ToString();
                        txtpgAttempt.Text = ds.Tables[0].Rows[0][63].ToString();
                        sem1_Obtained_Marks.Text = ds.Tables[0].Rows[0][64].ToString();
                        sem1_Total_Marks.Text = ds.Tables[0].Rows[0][65].ToString();
                        sem1_Percentage.Text = ds.Tables[0].Rows[0][66].ToString();
                        sem1_SGPA.Text = ds.Tables[0].Rows[0][67].ToString();
                        sem1_Backlogs.Text = ds.Tables[0].Rows[0][68].ToString();
                        sem2_Obtained_Marks.Text = ds.Tables[0].Rows[0][69].ToString();
                        sem2_Total_Marks.Text = ds.Tables[0].Rows[0][70].ToString();
                        sem2_Percentage.Text = ds.Tables[0].Rows[0][71].ToString();
                        sem2_SGPA.Text = ds.Tables[0].Rows[0][72].ToString();
                        sem2_Backlogs.Text = ds.Tables[0].Rows[0][73].ToString();
                        sem3_Obtained_Marks.Text = ds.Tables[0].Rows[0][74].ToString();
                        sem3_Total_Marks.Text = ds.Tables[0].Rows[0][75].ToString();
                        sem3_Percentage.Text = ds.Tables[0].Rows[0][76].ToString();
                        sem3_SGPA.Text = ds.Tables[0].Rows[0][77].ToString();
                        sem3_Backlogs.Text = ds.Tables[0].Rows[0][78].ToString();
                        sem4_Obtained_Marks.Text = ds.Tables[0].Rows[0][79].ToString();
                        sem4_Total_Marks.Text = ds.Tables[0].Rows[0][80].ToString();
                        sem4_Percentage.Text = ds.Tables[0].Rows[0][81].ToString();
                        sem4_SGPA.Text = ds.Tables[0].Rows[0][82].ToString();
                        sem4_Backlogs.Text = ds.Tables[0].Rows[0][83].ToString();
                        sem5_Obtained_Marks.Text = ds.Tables[0].Rows[0][84].ToString();
                        sem5_Total_Marks.Text = ds.Tables[0].Rows[0][85].ToString();
                        sem5_Percentage.Text = ds.Tables[0].Rows[0][86].ToString();
                        sem5_SGPA.Text = ds.Tables[0].Rows[0][87].ToString();
                        sem5_Backlogs.Text = ds.Tables[0].Rows[0][88].ToString();
                        sem6_Obtained_Marks.Text = ds.Tables[0].Rows[0][89].ToString();
                        sem6_Total_Marks.Text = ds.Tables[0].Rows[0][90].ToString();
                        sem6_Percentage.Text = ds.Tables[0].Rows[0][91].ToString();
                        sem6_SGPA.Text = ds.Tables[0].Rows[0][92].ToString();
                        sem6_Backlogs.Text = ds.Tables[0].Rows[0][93].ToString();
                        sem7_Obtained_Marks.Text = ds.Tables[0].Rows[0][94].ToString();
                        sem7_Total_Marks.Text = ds.Tables[0].Rows[0][95].ToString();
                        sem7_Percentage.Text = ds.Tables[0].Rows[0][96].ToString();
                        sem7_SGPA.Text = ds.Tables[0].Rows[0][97].ToString();
                        sem7_Backlogs.Text = ds.Tables[0].Rows[0][98].ToString();
                        sem8_Obtained_Marks.Text = ds.Tables[0].Rows[0][99].ToString();
                        sem8_Total_Marks.Text = ds.Tables[0].Rows[0][100].ToString();
                        sem8_Percentage.Text = ds.Tables[0].Rows[0][101].ToString();
                        sem8_SGPA.Text = ds.Tables[0].Rows[0][102].ToString();
                        sem8_Backlogs.Text = ds.Tables[0].Rows[0][103].ToString();
                        txt1Year_mark.Text = ds.Tables[0].Rows[0][104].ToString();
                        txt1Year_Total_Mark.Text = ds.Tables[0].Rows[0][105].ToString();
                        txt1Year_Percentage.Text = ds.Tables[0].Rows[0][106].ToString();
                        txt1Year_sgpa.Text = ds.Tables[0].Rows[0][107].ToString();
                        txt1Year_backlogs.Text = ds.Tables[0].Rows[0][108].ToString();
                        txt2Year_mark.Text = ds.Tables[0].Rows[0][109].ToString();
                        txt2Year_Total_Mark.Text = ds.Tables[0].Rows[0][110].ToString();
                        txt2Year_Percentage.Text = ds.Tables[0].Rows[0][111].ToString();
                        txt2Year_sgpa.Text = ds.Tables[0].Rows[0][112].ToString();
                        txt2Year_backlogs.Text = ds.Tables[0].Rows[0][113].ToString();
                        txt3Year_mark.Text = ds.Tables[0].Rows[0][114].ToString();
                        txt3Year_Total_Mark.Text = ds.Tables[0].Rows[0][115].ToString();
                        txt3Year_Percentage.Text = ds.Tables[0].Rows[0][116].ToString();
                        txt3Year_sgpa.Text = ds.Tables[0].Rows[0][117].ToString();
                        txt3Year_backlogs.Text = ds.Tables[0].Rows[0][118].ToString();
                        txt4Year_mark.Text = ds.Tables[0].Rows[0][119].ToString();
                        txt4Year_Total_Mark.Text = ds.Tables[0].Rows[0][120].ToString();
                        txt4Year_Percentage.Text = ds.Tables[0].Rows[0][121].ToString();
                        txt4Year_sgpa.Text = ds.Tables[0].Rows[0][122].ToString();
                        txt4Year_backlogs.Text = ds.Tables[0].Rows[0][123].ToString();
                        txt5Year_mark.Text = ds.Tables[0].Rows[0][124].ToString();
                        txt5Year_Total_Mark.Text = ds.Tables[0].Rows[0][125].ToString();
                        txt5Year_Percentage.Text = ds.Tables[0].Rows[0][126].ToString();
                        txt5Year_sgpa.Text = ds.Tables[0].Rows[0][127].ToString();
                        txt5Year_backlogs.Text = ds.Tables[0].Rows[0][128].ToString();
                        txtGap_Year.Text = ds.Tables[0].Rows[0][129].ToString();
                        txtLive_Backlogs.Text = ds.Tables[0].Rows[0][130].ToString();
                        txtDead_Backlogs.Text = ds.Tables[0].Rows[0][131].ToString();
                        txtExperience.Text = ds.Tables[0].Rows[0][132].ToString();
                        txtEntrance_Score.Text = ds.Tables[0].Rows[0][133].ToString();
                        txtAggregate.Text = ds.Tables[0].Rows[0][134].ToString();
                    }
                    else
                    {
                        string script = "alert(\"Invalid Search Student Id!\");"; ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
                    }
                }
            }
            catch (Exception ex)
            {
                Response.Write("Oops! error occured :" + ex.Message.ToString());
            }
        }
        protected void bind_Project()
        {
            try
            {
                //bel_mem.bel_id = txtStud_id.Text;
                //DataTable dt = bal_mem.bind_ProjectTitle(bel_mem);
                cmd = new SqlCommand("Student_add_update", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Stud_id", txtStudID.Text);
                cmd.Parameters.AddWithValue("@flag", 8);
                DataTable dt = new DataTable();
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                sda.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    error2.Text = "";
                    gvProject_Details.DataSource = dt;

                    gvProject_Details.DataBind();
                }
                else
                {
                    error2.Text = "Record not Available!";
                }
            }
            catch (Exception ex)
            {
                Response.Write("Oops! error occured :" + ex.Message.ToString());
            }
        }
        protected void bind_Technical_Details()
        {
            try
            {
                cmd = new SqlCommand("Sp_Add_Technical_Details", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@stuID", txtStudID.Text);
                cmd.Parameters.AddWithValue("@flag", 2);
                DataTable dt = new DataTable();
                SqlDataAdapter adp1 = new SqlDataAdapter(cmd);
                adp1.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    error3.Text = "";
                    gvTechnicalDetails.DataSource = dt;
                    gvTechnicalDetails.DataBind();
                }
                else
                {
                    error3.Text = "Record not Available!";
                }
            }
            catch (Exception ex)
            {
                Response.Write("Oops! error occured :" + ex.Message.ToString());
            }
        }
        protected void bind_Activity()
        {
            try
            {
                cmd = new SqlCommand("add_student_extraActivity", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@flag", 2);
                cmd.Parameters.AddWithValue("@Student_id", txtStudID.Text);
                DataTable dt = new DataTable();
                SqlDataAdapter adp1 = new SqlDataAdapter(cmd);
                adp1.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    error4.Text = "";
                    gvstudent_extraActivity.DataSource = dt;
                    gvstudent_extraActivity.DataBind();
                }
                else
                {
                    error4.Text = "Record not Available!";
                }
            }
            catch (Exception ex)
            {
                Response.Write("Oops! error occured :" + ex.Message.ToString());
            }
        }
        protected void bind_Achievement()
        {
            try
            {
                cmd = new SqlCommand("Sp_Add_Achievement_Details", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@flag", 2);
                cmd.Parameters.AddWithValue("@studentID", txtStudID.Text);
                DataTable dt = new DataTable();
                SqlDataAdapter adp1 = new SqlDataAdapter(cmd);
                adp1.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    error5.Text = "";
                    gvAchievementDetails.DataSource = dt;
                    gvAchievementDetails.DataBind();
                }
                else
                {
                    error5.Text = "Record not Available!";
                }
            }
            catch (Exception ex)
            {
                Response.Write("Oops! error occured :" + ex.Message.ToString());
            }
        }
    }
}