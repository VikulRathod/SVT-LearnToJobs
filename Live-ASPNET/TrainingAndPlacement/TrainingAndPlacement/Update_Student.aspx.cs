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
    public partial class Update_Student : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["myConnectionString"].ConnectionString);
        SqlCommand cmd = new SqlCommand();
        string status = "Active";
        bal_Student bal_mem = new bal_Student();
        bel_Student bel_mem = new bel_Student();
        bal_Institute bal_cp = new bal_Institute();
        bel_login login = new bel_login();
        bal_login bal_login = new bal_login();
        bal_Dept bal = new bal_Dept();
        DateTime date = DateTime.Now.AddYears(-2);
        string Student_ResumeURL;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Student_Id"] != null)
            {
                if (!IsPostBack)
                {
                    bind_Department();
                    search();
                }
            }
            else
            {
                logout();
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
        protected void search()
        {
            DataSet ds = new DataSet();
            try
            {

                string str = "select count(*) from Student_Registration where Student_ID='" + Session["Student_Id"].ToString() + "'";
                SqlCommand cmd = new SqlCommand(str, con);
                con.Open();
                int count = (int)cmd.ExecuteScalar();
                con.Close();
                if (count > 0)
                {

                    bel_mem.bel_id = Session["Student_Id"].ToString();
                    ds = bal_mem.select(bel_mem);
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        txtAcadmic.Text = ds.Tables[0].Rows[0][1].ToString();
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
                        ddlGender.SelectedValue = ds.Tables[0].Rows[0][12].ToString();
                        txtdob.Text = ds.Tables[0].Rows[0][13].ToString();
                        ddlBlood.SelectedValue = ds.Tables[0].Rows[0][14].ToString();
                        txtMother_Tongue.Text = ds.Tables[0].Rows[0][15].ToString();
                        txtLanguages.Text = ds.Tables[0].Rows[0][16].ToString();
                        txtAdmission_Date.Text = ds.Tables[0].Rows[0][17].ToString();
                        txtAddress.Text = ds.Tables[0].Rows[0][18].ToString();
                        tstNationality.Text = ds.Tables[0].Rows[0][19].ToString();
                        txtDomicile.Text = ds.Tables[0].Rows[0][20].ToString();
                        txtReligion.Text = ds.Tables[0].Rows[0][21].ToString();
                        txtCategory.Text = ds.Tables[0].Rows[0][22].ToString();
                        txtCaste.Text = ds.Tables[0].Rows[0][23].ToString();
                        ddlHostelite.SelectedValue = ds.Tables[0].Rows[0][24].ToString();
                        ddlHandicap.SelectedValue = ds.Tables[0].Rows[0][25].ToString();
                        ddlSport.SelectedValue = ds.Tables[0].Rows[0][26].ToString();
                        ddlDefence.SelectedValue = ds.Tables[0].Rows[0][27].ToString();
                        txtPan.Text = ds.Tables[0].Rows[0][28].ToString();
                        txtPassport_No.Text = ds.Tables[0].Rows[0][29].ToString();
                        txtDriving_License.Text = ds.Tables[0].Rows[0][30].ToString();
                        txtFather.Text = ds.Tables[0].Rows[0][31].ToString();
                        txtfcontact.Text = ds.Tables[0].Rows[0][32].ToString();
                        txtfather_Email.Text = ds.Tables[0].Rows[0][33].ToString();
                        txtOccupation.Text = ds.Tables[0].Rows[0][34].ToString();
                        txtOrganization.Text = ds.Tables[0].Rows[0][35].ToString();
                        txtDesignation.Text = ds.Tables[0].Rows[0][36].ToString();
                        txtAddress.Text = ds.Tables[0].Rows[0][37].ToString();
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
                        ddlgap.SelectedValue = ds.Tables[0].Rows[0][129].ToString();
                        ddlLive_ATKT.SelectedValue = ds.Tables[0].Rows[0][130].ToString();
                        ddlDead_ATKT.SelectedValue = ds.Tables[0].Rows[0][131].ToString();
                        ddlExperience.SelectedValue = ds.Tables[0].Rows[0][132].ToString();
                        txtEntrance_Score.Text = ds.Tables[0].Rows[0][133].ToString();
                        txtAggregate.Text = ds.Tables[0].Rows[0][134].ToString();
                        Approval.Text = ds.Tables[0].Rows[0][136].ToString();
                        if (Approval.Text == "&nbsp;" || Approval.Text == "" || Approval.Text == string.Empty || Approval.Text == "No")
                        {
                            Approval.Text = "Approval Pending";
                        }
                        //SelectImage;
                        ViewState["ImgPhotos"] = ds.Tables[0].Rows[0][137].ToString();
                        if (ViewState["ImgPhotos"] != "&nbsp;" && ViewState["ImgPhotos"] != "" && ViewState["ImgPhotos"] != string.Empty)
                        {
                            byte[] bytes = (byte[])(ds.Tables[0].Rows[0][137]);
                            ViewState["ImgPhotos"] = bytes;
                            string base64String = Convert.ToBase64String(bytes, 0, bytes.Length);
                            img.ImageUrl = "data:image/png;base64," + base64String;
                        }
                        Student_ResumeURL = ds.Tables[0].Rows[0][138].ToString();
                        if (Student_ResumeURL == "&nbsp;" || Student_ResumeURL == "" || Student_ResumeURL == string.Empty || Student_ResumeURL != "Placed")
                        {
                            linkResume.NavigateUrl= Student_ResumeURL;
                        }
                        Placed.Text = ds.Tables[0].Rows[0][139].ToString();
                        if (Placed.Text == "&nbsp;" || Placed.Text == "" || Placed.Text == string.Empty || Placed.Text != "Placed")
                        {
                            Placed.Text = "Not Placed";
                        }
                    }
                }
                else
                {
                    string script = "alert(\"Invalid Search Student Id!\");"; ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
                }


            }
            catch (Exception ex)
            {
                Response.Write("Oops! error occured :" + ex.Message.ToString());
            }
        }

        protected void btnsave_Click(object sender, EventArgs e)
        {

            string str = "select count(*) from Student_Registration where Student_ID='" + Session["Student_Id"].ToString() + "'";
            SqlCommand cmd = new SqlCommand(str, con);
            con.Open();
            int count = (int)cmd.ExecuteScalar();
            con.Close();
            if (count > 0)
            {
                try
                {
                    bel_mem.bel_id = Session["Student_Id"].ToString();
                    bel_mem.bel_Academic_Year = txtAcadmic.Text;
                    bel_mem.bel_Course_Name = ddlCourse_Name.SelectedValue;
                    bel_mem.bel_Aadhaar_No = txtcardno.Text;
                    bel_mem.bel_bel_University_Reg_No = txtuni_regiNo.Text;
                    bel_mem.bel_Class_ID = txtClass_ID.Text;
                    bel_mem.bel_Roll_No = txtRoll_No.Text;
                    bel_mem.bel_Student_Name = txtStudent_Name.Text;
                    bel_mem.bel_Email = txtEmail.Text;
                    bel_mem.bel_Contact_No = txtcontact.Text;
                    bel_mem.bel_alt_contact_no = txtalt_No.Text;
                    bel_mem.bel_Mother_Name = txtMother_Name.Text;
                    bel_mem.bel_Gender = ddlGender.SelectedValue;
                    bel_mem.bel_DOB = txtdob.Text;
                    bel_mem.bel_Blood_Group = ddlBlood.SelectedValue;
                    bel_mem.bel_Mother_Tongue = txtMother_Tongue.Text;
                    bel_mem.bel_Languages = txtLanguages.Text;
                    bel_mem.bel_Admission_Date = txtAdmission_Date.Text;
                    bel_mem.bel_Address = txtAddress.Text;
                    bel_mem.bel_Nationality = tstNationality.Text;
                    bel_mem.bel_Domicile = txtDomicile.Text;
                    bel_mem.bel_Religion = txtReligion.Text;
                    bel_mem.bel_Category = txtCategory.Text;
                    bel_mem.bel_Caste = txtCaste.Text;
                    bel_mem.bel_Hostelite = ddlHostelite.SelectedValue;
                    bel_mem.bel_Handicap = ddlHandicap.SelectedValue;
                    bel_mem.bel_Sport = ddlSport.SelectedValue;
                    bel_mem.bel_Defence = ddlDefence.SelectedValue;
                    bel_mem.bel_PAN_No = txtPan.Text;
                    bel_mem.bel_Passport_No = txtPassport_No.Text;
                    bel_mem.bel_Driving_License = txtDriving_License.Text;
                    bel_mem.bel_F_Name = txtFather.Text;
                    bel_mem.bel_F_Contact = txtfcontact.Text;
                    bel_mem.bel_F_Email = txtfather_Email.Text;
                    bel_mem.bel_F_Occupation = txtOccupation.Text;
                    bel_mem.bel_F_Organization = txtOrganization.Text;
                    bel_mem.bel_F_Designation = txtDesignation.Text;
                    bel_mem.bel_F_Address = txtAddress.Text;
                    bel_mem.bel_F_Annual_Income = txtIncome.Text;
                    bel_mem.bel_SSC_Board = txt10board.Text;
                    bel_mem.bel_SSC_Institute = txt10sub.Text;
                    bel_mem.bel_SSC_Percentage = txt10percent.Text;
                    bel_mem.bel_SSC_Passed_Year = txt10year.Text;
                    bel_mem.bel_SSC_Attempt = txt10Attempt.Text;
                    bel_mem.bel_HSC_Board = txt12board.Text;
                    bel_mem.bel_HSC_Institute = txt12sub.Text;
                    bel_mem.bel_HSC_Percentage = txt12percent.Text;
                    bel_mem.bel_HSC_Passed_Year = txt12year.Text;
                    bel_mem.bel_HSC_Attempt = txt12Attempt.Text;
                    bel_mem.bel_Diploma_Board = txtdipboard.Text;
                    bel_mem.bel_Diploma_Institute = txtdisub.Text;
                    bel_mem.bel_Diploma_Percentage = txtdipercent.Text;
                    bel_mem.bel_Diploma_Passed_Year = txtdiyear.Text;
                    bel_mem.bel_Diploma_Attempt = txtdiAttempt.Text;
                    bel_mem.bel_UG_Board = txtdeboard.Text;
                    bel_mem.bel_UG_Institute = txtdesub.Text;
                    bel_mem.bel_UG_Percentage = txtdepercent.Text;
                    bel_mem.bel_UG_Passed_Year = txtdeyear.Text;
                    bel_mem.bel_UG_Attempt = txtdeAttempt.Text;
                    bel_mem.bel_PG_Board = txtpgeboard.Text;
                    bel_mem.bel_PG_Institute = txtpgesub.Text;
                    bel_mem.bel_PG_Percentage = txtpgepercent.Text;
                    bel_mem.bel_PG_Passed_Year = txtpgeyear.Text;
                    bel_mem.bel_PG_Attempt = txtpgAttempt.Text;
                    bel_mem.bel_Sem1_Obtained_Marks = sem1_Obtained_Marks.Text;
                    bel_mem.bel_Sem1_Total_Marks = sem1_Total_Marks.Text;
                    bel_mem.bel_Sem1_Percentage = sem1_Percentage.Text;
                    bel_mem.bel_Sem1_SGPA = sem1_SGPA.Text;
                    bel_mem.bel_Sem1_BackLog = sem1_Backlogs.Text;
                    bel_mem.bel_Sem2_Obtained_Marks = sem2_Obtained_Marks.Text;
                    bel_mem.bel_Sem2_Total_Marks = sem2_Total_Marks.Text;
                    bel_mem.bel_Sem2_Percentage = sem2_Percentage.Text;
                    bel_mem.bel_Sem2_SGPA = sem2_SGPA.Text;
                    bel_mem.bel_Sem2_BackLog = sem2_Backlogs.Text;
                    bel_mem.bel_Sem3_Obtained_Marks = sem3_Obtained_Marks.Text;
                    bel_mem.bel_Sem3_Total_Marks = sem3_Total_Marks.Text;
                    bel_mem.bel_Sem3_Percentage = sem3_Percentage.Text;
                    bel_mem.bel_Sem3_SGPA = sem3_SGPA.Text;
                    bel_mem.bel_Sem3_BackLog = sem3_Backlogs.Text;
                    bel_mem.bel_Sem4_Obtained_Marks = sem4_Obtained_Marks.Text;
                    bel_mem.bel_Sem4_Total_Marks = sem4_Total_Marks.Text;
                    bel_mem.bel_Sem4_Percentage = sem4_Percentage.Text;
                    bel_mem.bel_Sem4_SGPA = sem4_SGPA.Text;
                    bel_mem.bel_Sem4_BackLog = sem4_Backlogs.Text;
                    bel_mem.bel_Sem5_Obtained_Marks = sem5_Obtained_Marks.Text;
                    bel_mem.bel_Sem5_Total_Marks = sem5_Total_Marks.Text;
                    bel_mem.bel_Sem5_Percentage = sem5_Percentage.Text;
                    bel_mem.bel_Sem5_SGPA = sem5_SGPA.Text;
                    bel_mem.bel_Sem5_BackLog = sem5_Backlogs.Text;
                    bel_mem.bel_Sem6_Obtained_Marks = sem6_Obtained_Marks.Text;
                    bel_mem.bel_Sem6_Total_Marks = sem6_Total_Marks.Text;
                    bel_mem.bel_Sem6_Percentage = sem6_Percentage.Text;
                    bel_mem.bel_Sem6_SGPA = sem6_SGPA.Text;
                    bel_mem.bel_Sem6_BackLog = sem6_Backlogs.Text;
                    bel_mem.bel_Sem7_Obtained_Marks = sem7_Obtained_Marks.Text;
                    bel_mem.bel_Sem7_Total_Marks = sem7_Total_Marks.Text;
                    bel_mem.bel_Sem7_Percentage = sem7_Percentage.Text;
                    bel_mem.bel_Sem7_SGPA = sem7_SGPA.Text;
                    bel_mem.bel_Sem7_BackLog = sem7_Backlogs.Text;
                    bel_mem.bel_Sem8_Obtained_Marks = sem8_Obtained_Marks.Text;
                    bel_mem.bel_Sem8_Total_Marks = sem8_Total_Marks.Text;
                    bel_mem.bel_Sem8_Percentage = sem8_Percentage.Text;
                    bel_mem.bel_Sem8_SGPA = sem8_SGPA.Text;
                    bel_mem.bel_Sem8_BackLog = sem8_Backlogs.Text;
                    bel_mem.bel_Year1_Obtained_Marks = txt1Year_mark.Text;
                    bel_mem.bel_Year1_Total_Marks = txt1Year_Total_Mark.Text;
                    bel_mem.bel_Year1_Percentage = txt1Year_Percentage.Text;
                    bel_mem.bel_Year1_SGPA = txt1Year_sgpa.Text;
                    bel_mem.bel_Year1_BackLog = txt1Year_backlogs.Text;
                    bel_mem.bel_Year2_Obtained_Marks = txt2Year_mark.Text;
                    bel_mem.bel_Year2_Total_Marks = txt2Year_Total_Mark.Text;
                    bel_mem.bel_Year2_Percentage = txt2Year_Percentage.Text;
                    bel_mem.bel_Year2_SGPA = txt2Year_sgpa.Text;
                    bel_mem.bel_Year2_BackLog = txt2Year_backlogs.Text;
                    bel_mem.bel_Year3_Obtained_Marks = txt3Year_mark.Text;
                    bel_mem.bel_Year3_Total_Marks = txt3Year_Total_Mark.Text;
                    bel_mem.bel_Year3_Percentage = txt3Year_Percentage.Text;
                    bel_mem.bel_Year3_SGPA = txt3Year_sgpa.Text;
                    bel_mem.bel_Year3_BackLog = txt3Year_backlogs.Text;
                    bel_mem.bel_Year4_Obtained_Marks = txt4Year_mark.Text;
                    bel_mem.bel_Year4_Total_Marks = txt4Year_Total_Mark.Text;
                    bel_mem.bel_Year4_Percentage = txt4Year_Percentage.Text;
                    bel_mem.bel_Year4_SGPA = txt4Year_sgpa.Text;
                    bel_mem.bel_Year4_BackLog = txt4Year_backlogs.Text;
                    bel_mem.bel_Year5_Obtained_Marks = txt5Year_mark.Text;
                    bel_mem.bel_Year5_Total_Marks = txt5Year_Total_Mark.Text;
                    bel_mem.bel_Year5_Percentage = txt5Year_Percentage.Text;
                    bel_mem.bel_Year5_SGPA = txt5Year_sgpa.Text;
                    bel_mem.bel_Year5_BackLog = txt5Year_backlogs.Text;
                    bel_mem.bel_Gap_Year = ddlgap.SelectedValue;
                    bel_mem.bel_Live_Backlogs = ddlLive_ATKT.SelectedValue;
                    bel_mem.bel_Dead_Backlogs = ddlDead_ATKT.SelectedValue;
                    bel_mem.bel_Experience = ddlExperience.SelectedValue;
                    bel_mem.bel_Entrance_Score = txtEntrance_Score.Text;
                    bel_mem.bel_Aggregate = txtAggregate.Text;
                    

                    if (ResumeUpload.HasFile)
                    {
                        // If tru Browser Image Path and image saved in folder
                        Student_ResumeURL = "~/Student_Resume/" + Session["Student_Id"].ToString() + ".doc";
                        ResumeUpload.PostedFile.SaveAs(Server.MapPath(Student_ResumeURL.Trim()));
                        // If tru Browser Image Path and image saved in folder
                    }
                    bel_mem.bel_Resume = Student_ResumeURL;
                    //Profile Photo Upload
                    if (ViewState["ImgPhotos"] is String)
                    {
                        bel_mem.bel_memphoto = false;
                        bel_mem.bel_Stuphoto = null;

                        //cmd.Parameters.AddWithValue("@Photos", new byte[Convert.ToInt32(0)]);
                    }
                    else
                    {
                        bel_mem.bel_memphoto = true;
                        bel_mem.bel_Stuphoto = (byte[])ViewState["ImgPhotos"];
                    }

                    int retVal = bal_mem.update_Stud(bel_mem);
                    if (retVal > 0)
                    {
                        string script = "alert(\"Student Successfully Updated!\");"; ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
                        //clear();
                    }
                    else
                    {
                        string script = "alert(\"Student details couldn't be updated!\");"; ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
                    }
                }
                catch (Exception ex)
                {
                    Response.Write("Oops! error occured :" + ex.Message.ToString());
                }
                finally
                {
                    bal_mem = null;
                    bel_mem = null;
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

                txtAcadmic.Text = "";
                ddlCourse_Name.SelectedIndex = 0;
                txtcardno.Text = "";
                txtuni_regiNo.Text = "";
                txtClass_ID.Text = "";
                txtRoll_No.Text = "";
                txtStudent_Name.Text = "";
                txtEmail.Text = "";
                txtcontact.Text = "";
                txtalt_No.Text = "";
                txtMother_Name.Text = "";
                ddlGender.SelectedIndex = 0;
                txtdob.Text = "";
                ddlBlood.SelectedIndex = 0;
                txtMother_Tongue.Text = "";
                txtLanguages.Text = "";
                txtAdmission_Date.Text = "";
                txtAddress.Text = "";
                tstNationality.Text = "";
                txtDomicile.Text = "";
                txtReligion.Text = "";
                txtCategory.Text = "";
                txtCaste.Text = "";
                ddlHostelite.SelectedIndex = 0;
                ddlHandicap.SelectedIndex = 0;
                ddlSport.SelectedIndex = 0;
                ddlDefence.SelectedIndex = 0;
                txtPan.Text = "";
                txtPassport_No.Text = "";
                txtDriving_License.Text = "";
                txtFather.Text = "";
                txtfcontact.Text = "";
                txtfather_Email.Text = "";
                txtOccupation.Text = "";
                txtOrganization.Text = "";
                txtDesignation.Text = "";
                txtAddress.Text = "";
                txtIncome.Text = "";
                txt10board.Text = "";
                txt10sub.Text = "";
                txt10percent.Text = "";
                txt10year.Text = "";
                txt10Attempt.Text = "";
                txt12board.Text = "";
                txt12sub.Text = "";
                txt12percent.Text = "";
                txt12year.Text = "";
                txt12Attempt.Text = "";
                txtdipboard.Text = "";
                txtdisub.Text = "";
                txtdipercent.Text = "";
                txtdiyear.Text = "";
                txtdiAttempt.Text = "";
                txtdeboard.Text = "";
                txtdesub.Text = "";
                txtdepercent.Text = "";
                txtdeyear.Text = "";
                txtdeAttempt.Text = "";
                txtpgeboard.Text = "";
                txtpgesub.Text = "";
                txtpgepercent.Text = "";
                txtpgeyear.Text = "";
                txtpgAttempt.Text = "";

                sem1_Obtained_Marks.Text = "";
                sem1_Total_Marks.Text = "";
                sem1_Percentage.Text = "";
                sem1_SGPA.Text = "";
                sem1_Backlogs.Text = "";
                sem2_Obtained_Marks.Text = "";
                sem2_Total_Marks.Text = "";
                sem2_Percentage.Text = "";
                sem2_SGPA.Text = "";
                sem2_Backlogs.Text = "";
                sem3_Obtained_Marks.Text = "";
                sem3_Total_Marks.Text = "";
                sem3_Percentage.Text = "";
                sem3_SGPA.Text = "";
                sem3_Backlogs.Text = "";
                sem4_Obtained_Marks.Text = "";
                sem4_Total_Marks.Text = "";
                sem4_Percentage.Text = "";
                sem4_SGPA.Text = "";
                sem4_Backlogs.Text = "";
                sem5_Obtained_Marks.Text = "";
                sem5_Total_Marks.Text = "";
                sem5_Percentage.Text = "";
                sem5_SGPA.Text = "";
                sem5_Backlogs.Text = "";
                sem6_Obtained_Marks.Text = "";
                sem6_Total_Marks.Text = "";
                sem6_Percentage.Text = "";
                sem6_SGPA.Text = "";
                sem6_Backlogs.Text = "";
                sem7_Obtained_Marks.Text = "";
                sem7_Total_Marks.Text = "";
                sem7_Percentage.Text = "";
                sem7_SGPA.Text = "";
                sem7_Backlogs.Text = "";
                sem8_Obtained_Marks.Text = "";
                sem8_Total_Marks.Text = "";
                sem8_Percentage.Text = "";
                sem8_SGPA.Text = "";
                sem8_Backlogs.Text = "";
                txt1Year_mark.Text = "";
                txt1Year_Total_Mark.Text = "";
                txt1Year_Percentage.Text = "";
                txt1Year_sgpa.Text = "";
                txt1Year_backlogs.Text = "";
                txt2Year_mark.Text = "";
                txt2Year_Total_Mark.Text = "";
                txt2Year_Percentage.Text = "";
                txt2Year_sgpa.Text = "";
                txt2Year_backlogs.Text = "";
                txt3Year_mark.Text = "";
                txt3Year_Total_Mark.Text = "";
                txt3Year_Percentage.Text = "";
                txt3Year_sgpa.Text = "";
                txt3Year_backlogs.Text = "";
                txt4Year_mark.Text = "";
                txt4Year_Total_Mark.Text = "";
                txt4Year_Percentage.Text = "";
                txt4Year_sgpa.Text = "";
                txt4Year_backlogs.Text = "";
                txt5Year_mark.Text = "";
                txt5Year_Total_Mark.Text = "";
                txt5Year_Percentage.Text = "";
                txt5Year_sgpa.Text = "";
                txt5Year_backlogs.Text = "";
                ddlExperience.SelectedIndex = 0;
                ddlLive_ATKT.SelectedIndex = 0;
                ddlDead_ATKT.SelectedIndex = 0;
                ddlExperience.SelectedIndex = 0;
                txtEntrance_Score.Text = "";
                txtAggregate.Text = "";
            }
            catch (Exception ex)
            {
                Response.Write("Oops! error occured :" + ex.Message.ToString());
            }

        }

        protected void btnImgUpload_Click(object sender, EventArgs e)
        {
            if (FileUpload1.HasFile)
            {
                string filepath = FileUpload1.PostedFile.FileName;
                string fileName = Path.GetFileName(filepath);
                string exc = Path.GetExtension(fileName);
                string contenttype = string.Empty;
                switch (exc)
                {
                    case ".jpeg":
                        contenttype = "image/jpeg";
                        break;

                    case ".jpg":
                        contenttype = "image.jpg";
                        break;

                    case ".png":
                        contenttype = "image/png";
                        break;


                }
                if (contenttype != string.Empty)
                {
                    Stream fs = FileUpload1.PostedFile.InputStream;
                    BinaryReader br = new BinaryReader(fs);
                    Byte[] bytes = br.ReadBytes((Int32)fs.Length);
                    ViewState["ImgPhotos"] = bytes;
                    string base64string = Convert.ToBase64String(bytes, 0, bytes.Length);
                    img.ImageUrl = "data:image/png;base64," + base64string;
                    img.Visible = true;
                }
                else
                {
                    string script = "alert(\"Please Check Student ID!\");"; ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
                }
            }
        }
        protected void logout()
        {
            Session.Abandon();
            Session.Clear();
            Session.RemoveAll();
            if (Request.Cookies["LoginTime"] != null)
            {
                HttpCookie cookie = new HttpCookie("User");

                Response.Cookies.Add(cookie);
                Response.Cookies["LoginTime"].Expires = DateTime.Now.AddDays(-1d);
            }
            Response.Redirect("~/login.aspx");
        }
     }
}