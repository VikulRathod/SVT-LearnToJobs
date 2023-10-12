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
using BEL;
using BAL;

namespace TrainingAndPlacement
{
    public partial class Set_Drive_Criteria : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["myConnectionString"].ConnectionString);
        SqlCommand cmd = new SqlCommand();
        bel_Derive bel = new bel_Derive();
        bal_Drive bal = new bal_Drive();
        bel_Student bel_stu = new bel_Student();
        bal_Student bal_stud = new bal_Student();
        bal_Company bal_C = new bal_Company();
        bel_Company bel_C = new bel_Company();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
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
                ddlCompany_ID.DataValueField = "Company_ID";
                ddlCompany_ID.DataBind();
                ddlCompany_ID.Items.Insert(0, new ListItem("Select All", string.Empty));
            }
        }
        protected void btnsave_Click(object sender, EventArgs e)
        {
            try
            {
                string str = "select count(*) from Set_Drive_Criteria where Academic_Year='" + ddlAcademicYear.SelectedItem.Text + "' AND Company_ID='" + ddlCompany_ID.SelectedValue + "' and Drive_Id ='" + ddlDrive_Title.SelectedValue+ "'";

                SqlCommand cmd = new SqlCommand(str, con);
                con.Open();
                int count = (int)cmd.ExecuteScalar();
                con.Close();
                if (count <= 0)
                {
                    insert();

                }
                else
                {
                    update();
                }
            }

            catch (Exception ex)
            {
                Response.Write("Oops! error occured :" + ex.Message.ToString());
            }
            finally
            {
                bel_stu = null;
                bel = null;
            }
        }
        protected void insert()
        {
            try
            {
                if (ddlAcademicYear.SelectedIndex == 0)
                {
                    string script = "alert(\"Please select AcademicYear, PLease Retry!\");"; ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
                }
                else if (ddlCompany_ID.SelectedIndex == 0)
                {
                    string script = "alert(\"Please select Company_ID, PLease Retry!\");"; ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
                }
                else if (ddlDrive_Title.SelectedIndex == 0)
                {
                    string script = "alert(\"Please select Drive_Title, PLease Retry!\");"; ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
                }
                if (txtsscPassingYear.Text == "" || Convert.ToInt32(txtsscPassingYear.Text) <= 0)
                {
                    string script = "alert(\"Please Enter SSC Passing Year, PLease Retry!\");"; ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
                }
                else if (txthscPYear.Text=="" || Convert.ToInt32(txthscPYear.Text)<=0)
                {
                    string script = "alert(\"Please Enter HSC Passing Year, PLease Retry!\");"; ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
                }
                else if (txtDpyear.Text == "")
                {
                    string script = "alert(\"Please Enter Diploma Passing Year or Zero, PLease Retry!\");"; ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
                }
                else if (txtUGPassingY.Text == "" || Convert.ToInt32(txtUGPassingY.Text) <= 0)
                {
                    string script = "alert(\"Please Enter UG Passing Year, PLease Retry!\");"; ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
                }
                else
                {

                    try
                    {
                        bel_stu.bel_Academic_Year = ddlAcademicYear.SelectedValue;
                        bel_stu.bel_Company_ID = ddlCompany_ID.SelectedValue;
                        bel_stu.bel_Drive_Id = ddlDrive_Title.SelectedValue;
                        bel_stu.bel_SSC_Percentage = txtSSCper.Text;
                        bel_stu.bel_Year1_Percentage = txt1sTYearper.Text;
                        bel_stu.bel_Year1_SGPA = txt1styearPointer.Text;
                        bel_stu.bel_SSC_Passed_Year = txtsscPassingYear.Text;
                        bel_stu.bel_Year2_Percentage = txt2yearper.Text;
                        bel_stu.bel_Year2_SGPA = txt2Yearpointer.Text;
                        bel_stu.bel_HSC_Percentage = txtHSCper.Text;
                        bel_stu.bel_Year3_Percentage = txt3Yearper.Text;
                        bel_stu.bel_Year3_SGPA = txt3Yearpointer.Text;
                        bel_stu.bel_HSC_Passed_Year = txthscPYear.Text;
                        bel_stu.bel_Year4_Percentage = txt4Yearper.Text;
                        bel_stu.bel_Year4_SGPA = txt4thYPointer.Text;
                        bel_stu.bel_Diploma_Percentage = txtDiplomaper.Text;
                        bel_stu.bel_Year5_Percentage = txt5thYper.Text;
                        bel_stu.bel_Year5_SGPA = txt5thYpointer.Text;
                        bel_stu.bel_Diploma_Passed_Year = txtDpyear.Text;
                        bel_stu.bel_Sem1_Percentage = txtS1per.Text;
                        bel_stu.bel_Sem1_SGPA = txtS1pointer.Text;
                        bel_stu.bel_UG_Percentage = txtUGper.Text;
                        bel_stu.bel_Sem2_Percentage = txtS2per.Text;
                        bel_stu.bel_Sem2_SGPA = txtS2Pointer.Text;
                        bel_stu.bel_UG_Passed_Year = txtUGPassingY.Text;
                        bel_stu.bel_Sem3_Percentage = txtS3per.Text;
                        bel_stu.bel_Sem3_SGPA = txtS3pointer.Text;
                        bel_stu.bel_PG_Percentage = txtPGper.Text;
                        bel_stu.bel_Sem4_Percentage = txtS4per.Text;
                        bel_stu.bel_Sem4_SGPA = txtS4pointer.Text;
                        bel_stu.bel_PG_Passed_Year = txtPGpassingY.Text;
                        bel_stu.bel_Sem5_Percentage = txtS5per.Text;
                        bel_stu.bel_Sem5_SGPA = txtS5pointer.Text;
                        bel_stu.bel_Sem6_Percentage = txtS6per.Text;
                        bel_stu.bel_Sem6_SGPA = txtS6pointer.Text;
                        bel_stu.bel_Sem7_Percentage = txtS7per.Text;
                        bel_stu.bel_Sem7_SGPA = txtS7pointer.Text;
                        bel_stu.bel_Gap_Year = ddlgap.SelectedValue;
                        bel_stu.bel_Live_Backlogs = ddlLive_ATKT.SelectedValue;
                        bel_stu.bel_Dead_Backlogs = ddlDead_ATKT.SelectedValue;
                        bel_stu.bel_Sem8_Percentage = txtS8per.Text;
                        bel_stu.bel_Sem8_SGPA = txtS8ponter.Text;
                        bel_stu.bel_Experience = ddlExperience.SelectedValue;
                        bel_stu.bel_Entrance_Score = txtEntranceScore.Text;
                        bel_stu.bel_Aggregate = txtAggregate.Text;

                        int retVal = bal.Add_Drive_Criteria(bel_stu);

                        if (retVal > 0)
                        {
                            string script = "alert(\"Drive Criteria add Successfully!\");"; ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
                            clear();
                        }
                        else
                        {
                            string script = "alert(\"Drive Criteria does not Add !\");"; ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);

                        }

                    }
                    catch (Exception ex)
                    {
                        Response.Write("Oops! error occured :" + ex.Message.ToString());
                    }
                    finally
                    {
                        bel_stu = null;
                        bel = null;
                    }
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
                if (ddlAcademicYear.SelectedIndex == 0)
                {
                    string script = "alert(\"Please select AcademicYear, PLease Retry!\");"; ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
                }
                else if (ddlCompany_ID.SelectedIndex == 0)
                {
                    string script = "alert(\"Please select Company_ID, PLease Retry!\");"; ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
                }
                else if (ddlDrive_Title.SelectedIndex == 0)
                {
                    string script = "alert(\"Please select Drive_Title, PLease Retry!\");"; ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
                }
                if (txtsscPassingYear.Text == "" || Convert.ToInt32(txtsscPassingYear.Text) <= 0)
                {
                    string script = "alert(\"Please Enter SSC Passing Year, PLease Retry!\");"; ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
                }
                else if (txthscPYear.Text=="" || Convert.ToInt32(txthscPYear.Text)<=0)
                {
                    string script = "alert(\"Please Enter HSC Passing Year, PLease Retry!\");"; ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
                }
                else if (txtUGPassingY.Text == "" || Convert.ToInt32(txtUGPassingY.Text) <= 0)
                {
                    string script = "alert(\"Please Enter UG Passing Year, PLease Retry!\");"; ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
                }
                else
                {
                    bel_stu.bel_Academic_Year = ddlAcademicYear.SelectedValue;
                    bel_stu.bel_Company_ID = ddlCompany_ID.SelectedValue;
                    bel_stu.bel_Drive_Id = ddlDrive_Title.SelectedValue;
                    bel_stu.bel_SSC_Percentage = txtSSCper.Text;
                    bel_stu.bel_Year1_Percentage = txt1sTYearper.Text;
                    bel_stu.bel_Year1_SGPA = txt1styearPointer.Text;
                    bel_stu.bel_SSC_Passed_Year = txtsscPassingYear.Text;
                    bel_stu.bel_Year2_Percentage = txt2yearper.Text;
                    bel_stu.bel_Year2_SGPA = txt2Yearpointer.Text;
                    bel_stu.bel_HSC_Percentage = txtHSCper.Text;
                    bel_stu.bel_Year3_Percentage = txt3Yearper.Text;
                    bel_stu.bel_Year3_SGPA = txt3Yearpointer.Text;
                    bel_stu.bel_HSC_Passed_Year = txthscPYear.Text;
                    bel_stu.bel_Year4_Percentage = txt4Yearper.Text;
                    bel_stu.bel_Year4_SGPA = txt4thYPointer.Text;
                    bel_stu.bel_Diploma_Percentage = txtDiplomaper.Text;
                    bel_stu.bel_Year5_Percentage = txt5thYper.Text;
                    bel_stu.bel_Year5_SGPA = txt5thYpointer.Text;
                    bel_stu.bel_Diploma_Passed_Year = txtDpyear.Text;
                    bel_stu.bel_Sem1_Percentage = txtS1per.Text;
                    bel_stu.bel_Sem1_SGPA = txtS1pointer.Text;
                    bel_stu.bel_UG_Percentage = txtUGper.Text;
                    bel_stu.bel_Sem2_Percentage = txtS2per.Text;
                    bel_stu.bel_Sem2_SGPA = txtS2Pointer.Text;
                    bel_stu.bel_UG_Passed_Year = txtUGPassingY.Text;
                    bel_stu.bel_Sem3_Percentage = txtS3per.Text;
                    bel_stu.bel_Sem3_SGPA = txtS3pointer.Text;
                    bel_stu.bel_PG_Percentage = txtPGper.Text;
                    bel_stu.bel_Sem4_Percentage = txtS4per.Text;
                    bel_stu.bel_Sem4_SGPA = txtS4pointer.Text;
                    bel_stu.bel_PG_Passed_Year = txtPGpassingY.Text;
                    bel_stu.bel_Sem5_Percentage = txtS5per.Text;
                    bel_stu.bel_Sem5_SGPA = txtS5pointer.Text;
                    bel_stu.bel_Gap_Year = ddlgap.SelectedValue;
                    bel_stu.bel_Sem6_Percentage = txtS6per.Text;
                    bel_stu.bel_Sem6_SGPA = txtS6pointer.Text;
                    bel_stu.bel_Live_Backlogs = ddlLive_ATKT.SelectedValue;
                    bel_stu.bel_Sem7_Percentage = txtS7per.Text;
                    bel_stu.bel_Sem7_SGPA = txtS7pointer.Text;
                    bel_stu.bel_Dead_Backlogs = ddlDead_ATKT.SelectedValue;
                    bel_stu.bel_Sem8_Percentage = txtS8per.Text;
                    bel_stu.bel_Sem8_SGPA = txtS8ponter.Text;
                    bel_stu.bel_Experience = ddlExperience.SelectedValue;
                    bel_stu.bel_Entrance_Score = txtEntranceScore.Text;
                    bel_stu.bel_Aggregate = txtAggregate.Text;


                    int retVal = bal.Update_Drive_Criteria(bel_stu);
                    if (retVal > 0)
                    {
                        string script = "alert(\"Drive Criteria Update !\");"; ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
                        clear();
                    }
                    else
                    {
                        string script = "alert(\"Drive Criteria does not Updated !\");"; ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);

                    }
                }
            }
            catch (Exception ex)
            {
                Response.Write("Oops! error occured :" + ex.Message.ToString());
            }
            finally
            {
                bel_stu = null;
                bel = null;
            }
        }

        protected void btnclear_Click(object sender, EventArgs e)
        {
            clear();
        }

        protected void clear()
        {
            try
            {
                ddlAcademicYear.SelectedIndex = -1;
                ddlCompany_ID.SelectedIndex = -1;
                ddlDrive_Title.SelectedIndex = -1;
                txtSSCper.Text = "";
                txt1sTYearper.Text = "";
                txt1styearPointer.Text = "";
                txtsscPassingYear.Text = "";
                txt2yearper.Text = "";
                txt2Yearpointer.Text = "";
                txtHSCper.Text = "";
                txt3Yearper.Text = "";
                txt3Yearpointer.Text = "";
                txthscPYear.Text = "";
                txt4Yearper.Text = "";
                txt4thYPointer.Text = "";
                txtDiplomaper.Text = "";
                txt5thYper.Text = "";
                txt5thYpointer.Text = "";
                txtDpyear.Text = "";
                txtS1per.Text = "";
                txtS1pointer.Text = "";
                txtUGper.Text = "";
                txtS2per.Text = "";
                txtS2Pointer.Text = "";
                txtUGPassingY.Text = "";
                txtS3per.Text = "";
                txtS3pointer.Text = "";
                txtPGper.Text = "";
                txtS4per.Text = "";
                txtS4pointer.Text = "";
                txtPGpassingY.Text = "";
                txtS5per.Text = "";
                txtS5pointer.Text = "";
                ddlgap.SelectedIndex = 0;
                txtS6per.Text = "";
                txtS6pointer.Text = "";
                ddlLive_ATKT.SelectedIndex = 0;
                txtS7per.Text = "";
                txtS7pointer.Text = "";
                ddlDead_ATKT.SelectedIndex = 0;
                txtS8per.Text = "";
                txtS8ponter.Text = "";
                ddlExperience.SelectedIndex = 0;
                txtEntranceScore.Text = "";
                txtAggregate.Text = "";
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
                if (ddlAcademicYear.SelectedIndex == 0)
                {
                    string script = "alert(\"Please Select Acadmic Year !\");"; ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
                }
                else if (ddlCompany_ID.SelectedIndex == 0)
                {
                    string script = "alert(\"Please Select Company_ID !\");"; ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
                }
                else
                {
                    SqlCommand cmd = new SqlCommand("SP_Add_Update_Drive", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@flag", 5);
                    cmd.Parameters.AddWithValue("@Academic_Year", ddlAcademicYear.SelectedValue);
                    cmd.Parameters.AddWithValue("@Company_ID", ddlCompany_ID.SelectedValue);
                    cmd.Parameters.AddWithValue("@Reg_To_Date", DateTime.Now.ToString("dd/MM/yyyy"));
                    DataTable dT = new DataTable();
                    SqlDataAdapter adp1 = new SqlDataAdapter(cmd);
                    adp1.Fill(dT);
                    ddlDrive_Title.DataSource = dT;
                    ddlDrive_Title.DataTextField = "Drive_Title";
                    ddlDrive_Title.DataValueField = "Drive_Id";
                    ddlDrive_Title.DataBind();
                    ddlDrive_Title.Items.Insert(0, new ListItem("Select All", string.Empty));

                }
            }
            catch (Exception ex)
            {
                Response.Write("Oops! error occured :" + ex.Message.ToString());
            }

        }
        protected void ddlDrive_Title_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (ddlAcademicYear.SelectedIndex == 0)
                {
                    string script = "alert(\"Please Select Acadmic Year !\");"; ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
                }
                else if (ddlCompany_ID.SelectedIndex == 0)
                {
                    string script = "alert(\"Please Select Company_ID !\");"; ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
                }
                else if (ddlDrive_Title.SelectedIndex == 0)
                {
                    string script = "alert(\"Please Select Drive title !\");"; ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
                }
                else
                {
                    SqlCommand cmd = new SqlCommand("Sp_Set_Drive_Criteria", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@flag", 4);
                    cmd.Parameters.AddWithValue("@Academic_Year", ddlAcademicYear.SelectedValue);
                    cmd.Parameters.AddWithValue("@Company_ID", ddlCompany_ID.SelectedValue);
                    cmd.Parameters.AddWithValue("@Drive_Id", ddlDrive_Title.SelectedValue);

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
            }
            catch (Exception ex)
            {
                Response.Write("Oops! error occured :" + ex.Message.ToString());
            }

        }
    }
}
          
        

 
