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
using System.Drawing;
using BEL;
using BAL;
namespace TrainingAndPlacement
{
    public partial class Pri_rpt__Drive_info : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myConnectionString"].ConnectionString);
        SqlCommand cmd;
        bal_Company bal_C = new bal_Company();
        bel_Company bel_C = new bel_Company();
        bal_Drive bal_D = new bal_Drive();
        bel_Derive bel_D = new bel_Derive();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Company_ID"] != null && Session["Drive"] != null && Session["Academic"] != null)
            {
                Bind_Company_Details();
                Bind_Drive_Details();
                Set_Drive_Criteria();
                Bind_Drive_Schedule_Details();
            }
        }
        protected void Bind_Company_Details()
        {
            try
            {
                bel_C.bel_Company_id = Session["Company_ID"].ToString();
                DataSet ds = bal_C.Select_Add_Update_Company(bel_C);


                if (ds.Tables[0].Rows.Count > 0)
                {
                    txtcompany_name.Text = ds.Tables[0].Rows[0][2].ToString();
                    txtname.Text = ds.Tables[0].Rows[0][2].ToString();
                    txtperson.Text = ds.Tables[0].Rows[0][3].ToString();
                    txtDesignation.Text = ds.Tables[0].Rows[0][4].ToString();
                    txtContactNo.Text = ds.Tables[0].Rows[0][5].ToString();
                    txtofc_no.Text = ds.Tables[0].Rows[0][6].ToString();
                    txtcompany_email.Text = ds.Tables[0].Rows[0][7].ToString();
                    txtcweb.Text = ds.Tables[0].Rows[0][8].ToString();
                    txtc_address.Text = ds.Tables[0].Rows[0][9].ToString();
                    txtc_type.Text = ds.Tables[0].Rows[0][10].ToString();
                    txtc_services.Text = ds.Tables[0].Rows[0][11].ToString();
                    txtcdomain_services.Text = ds.Tables[0].Rows[0][12].ToString();
                    txtDescription.Text = ds.Tables[0].Rows[0][13].ToString();

                }
            }
            catch (Exception ex)
            {
                Response.Write("Oops! error occured :" + ex.Message.ToString());
            }
        }
        protected void Bind_Drive_Details()
        {
            try
            {
                cmd = new SqlCommand("SP_Add_Update_Drive", con);
                cmd.CommandType = CommandType.StoredProcedure;


                cmd.Parameters.AddWithValue("@flag", 4);
                cmd.Parameters.AddWithValue("@Drive_Id", Session["Drive"].ToString());
                DataTable dT = new DataTable();
                SqlDataAdapter adp1 = new SqlDataAdapter(cmd);
                adp1.Fill(dT);
                if (dT.Rows.Count > 0)
                {

                    ddlAcademic_Year.SelectedItem.Text = dT.Rows[0][1].ToString();
                    txtcompany_Id.Text = dT.Rows[0][2].ToString();
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
                    txtCourses.Text = dT.Rows[0][29].ToString();
                }
            }
            catch (Exception ex)
            {
                Response.Write("Oops! error occured :" + ex.Message.ToString());
            }
        }
        protected void Set_Drive_Criteria()
        {
            try
            {
                SqlCommand cmd = new SqlCommand("Sp_Set_Drive_Criteria", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@flag", 4);
                cmd.Parameters.AddWithValue("@Academic_Year", Session["Academic"].ToString());
                cmd.Parameters.AddWithValue("@Company_ID", Session["Company_ID"].ToString());
                cmd.Parameters.AddWithValue("@Drive_Id", Session["Drive"].ToString());

                DataTable dT = new DataTable();
                SqlDataAdapter adp1 = new SqlDataAdapter(cmd);
                adp1.Fill(dT);
                if (dT.Rows.Count > 0)
                {
                    txtSSCper.Text = dT.Rows[0][4].ToString();
                    txtsscPassingYear.Text = dT.Rows[0][5].ToString();
                    txtHSCper.Text = dT.Rows[0][6].ToString();
                    txthscPYear.Text = dT.Rows[0][7].ToString();
                    txtDiplomaper.Text = dT.Rows[0][8].ToString();
                    txtDpyear.Text = dT.Rows[0][9].ToString();
                    txtUGper.Text = dT.Rows[0][10].ToString();
                    txtUGPassingY.Text = dT.Rows[0][11].ToString();
                    txtPGper.Text = dT.Rows[0][12].ToString();
                    txtPGpassingY.Text = dT.Rows[0][13].ToString();

                    txt1sTYearper.Text = dT.Rows[0][14].ToString();
                    txt1styearPointer.Text = dT.Rows[0][15].ToString();
                    txt2yearper.Text = dT.Rows[0][16].ToString();
                    txt2Yearpointer.Text = dT.Rows[0][17].ToString();
                    txt3Yearper.Text = dT.Rows[0][18].ToString();
                    txt3Yearpointer.Text = dT.Rows[0][19].ToString();
                    txt4Yearper.Text = dT.Rows[0][20].ToString();
                    txt4thYPointer.Text = dT.Rows[0][21].ToString();
                    txt5thYper.Text = dT.Rows[0][22].ToString();
                    txt5thYpointer.Text = dT.Rows[0][23].ToString();
                    txtS1per.Text = dT.Rows[0][24].ToString();
                    txtS1pointer.Text = dT.Rows[0][25].ToString();
                    txtS2per.Text = dT.Rows[0][26].ToString();
                    txtS2Pointer.Text = dT.Rows[0][27].ToString();
                    txtS3per.Text = dT.Rows[0][28].ToString();
                    txtS3pointer.Text = dT.Rows[0][29].ToString();
                    txtS4per.Text = dT.Rows[0][30].ToString();
                    txtS4pointer.Text = dT.Rows[0][31].ToString();
                    txtS5per.Text = dT.Rows[0][32].ToString();
                    txtS5pointer.Text = dT.Rows[0][33].ToString();
                    txtS6per.Text = dT.Rows[0][34].ToString();
                    txtS6pointer.Text = dT.Rows[0][35].ToString();
                    txtS7per.Text = dT.Rows[0][36].ToString();
                    txtS7pointer.Text = dT.Rows[0][37].ToString();
                    txtS8per.Text = dT.Rows[0][38].ToString();
                    txtS8ponter.Text = dT.Rows[0][39].ToString();
                    ddlgap.SelectedValue = dT.Rows[0][40].ToString();
                    ddlLive_ATKT.SelectedValue = dT.Rows[0][41].ToString();
                    ddlDead_ATKT.SelectedValue = dT.Rows[0][42].ToString();
                    ddlExperience.SelectedValue = dT.Rows[0][43].ToString();
                    txtEntranceScore.Text = dT.Rows[0][44].ToString();
                    txtAggregate.Text = dT.Rows[0][45].ToString();
                }
            }
            catch (Exception ex)
            {
                Response.Write("Oops! error occured :" + ex.Message.ToString());
            }

        }
        protected void Bind_Drive_Schedule_Details()
        {
            try
            {
                bel_D.bel_Academic_Year = Session["Academic"].ToString();
                bel_D.bel_Company_ID = Session["Company_ID"].ToString();
                bel_D.bel_id = Session["Drive"].ToString();
                DataSet ds = bal_D.Bind_Schedule(bel_D);
                gvShowschedule.DataSource = ds;
                gvShowschedule.DataBind();
            }
            catch (Exception ex)
            {
                Response.Write("Oops! error occured :" + ex.Message.ToString());
            }
        }
    }
}