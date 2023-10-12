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
    public partial class Stu_place_Drives_info : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myConnectionString"].ConnectionString);
        SqlCommand cmd;
        bal_Company bal_C = new bal_Company();
        bel_Company bel_C = new bel_Company();
        bal_Drive bal_D = new bal_Drive();
        bel_Derive bel_D = new bel_Derive();
        bal_Student bal = new bal_Student();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Company_ID"] != null && Session["Drive"] != null && Session["Academic"] != null)
            {
                Bind_Company_Details();
                Bind_Drive_Details();
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
            catch(Exception ex)
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