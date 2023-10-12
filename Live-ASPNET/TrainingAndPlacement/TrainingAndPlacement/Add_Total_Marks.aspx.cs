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
    public partial class Add_Total_Marks : System.Web.UI.Page
    {

        SqlConnection con = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["myConnectionString"].ConnectionString);
        SqlCommand cmd = new SqlCommand();
        bel_Derive bel = new bel_Derive();
        bal_Drive bal = new bal_Drive();

        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void btnsave_Click(object sender, EventArgs e)
        {
            try
            {
                if (ddlAcademicYear.SelectedIndex == 0)
                {
                    string script = "alert(\"Please select AcademicYear, PLease Retry!\");"; ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
                }
                else if (txt1YMarks.Text == "&nbsp;" || txt1YMarks.Text == "" || txt1YMarks.Text == string.Empty)
                {
                    string script = "alert(\"Please select 1YMarks, PLease Retry!\");"; ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
                }
                else if (txt2YMarks.Text == "&nbsp;" || txt2YMarks.Text == "" || txt2YMarks.Text == string.Empty)
                {
                    string script = "alert(\"Please select 2YMarks, PLease Retry!\");"; ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
                }
                else if (txt3YMarks.Text == "&nbsp;" || txt3YMarks.Text == "" || txt3YMarks.Text == string.Empty)
                {
                    string script = "alert(\"Please select 3YMarks, PLease Retry!\");"; ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
                }
                else if (txt4YMarks.Text == "&nbsp;" || txt4YMarks.Text == "" || txt4YMarks.Text == string.Empty)
                {
                    string script = "alert(\"Please select 4YMarks, PLease Retry!\");"; ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
                }
                else if (txt5YMarks.Text == "&nbsp;" || txt5YMarks.Text == "" || txt5YMarks.Text == string.Empty)
                {
                    string script = "alert(\"Please select 5YMarks, PLease Retry!\");"; ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
                }
                else if (txtS1Marks.Text == "&nbsp;" || txtS1Marks.Text == "" || txtS1Marks.Text == string.Empty)
                {
                    string script = "alert(\"Please select S1Marks, PLease Retry!\");"; ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
                }
                else if (txtS2Marks.Text == "&nbsp;" || txtS2Marks.Text == "" || txtS2Marks.Text == string.Empty)
                {
                    string script = "alert(\"Please select S2Marks, PLease Retry!\");"; ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
                }
                else if (txtS3Marks.Text == "&nbsp;" || txtS3Marks.Text == "" || txtS3Marks.Text == string.Empty)
                {
                    string script = "alert(\"Please select S3Marks, PLease Retry!\");"; ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
                }
                else if (txtS4Marks.Text == "&nbsp;" || txtS4Marks.Text == "" || txtS4Marks.Text == string.Empty)
                {
                    string script = "alert(\"Please select S4Marks, PLease Retry!\");"; ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
                }
                else if (txtS5Marks.Text == "&nbsp;" || txtS5Marks.Text == "" || txtS5Marks.Text == string.Empty)
                {
                    string script = "alert(\"Please select S5Marks, PLease Retry!\");"; ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
                }
                else if (txtS6Marks.Text == "&nbsp;" || txtS6Marks.Text == "" || txtS6Marks.Text == string.Empty)
                {
                    string script = "alert(\"Please select S6Marks, PLease Retry!\");"; ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
                }
                else if (txtS7Marks.Text == "&nbsp;" || txtS7Marks.Text == "" || txtS7Marks.Text == string.Empty)
                {
                    string script = "alert(\"Please select S7Marks, PLease Retry!\");"; ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
                }
                else if (txtS8Marks.Text == "&nbsp;" || txtS8Marks.Text == "" || txtS8Marks.Text == string.Empty)
                {
                    string script = "alert(\"Please select S8Marks, PLease Retry!\");"; ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
                }
                else if (txtS9Marks.Text == "&nbsp;" || txtS9Marks.Text == "" || txtS9Marks.Text == string.Empty)
                {
                    string script = "alert(\"Please select S9Marks, PLease Retry!\");"; ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
                }
                else if (txtS10Marks.Text == "&nbsp;" || txtS10Marks.Text == "" || txtS10Marks.Text == string.Empty)
                {
                    string script = "alert(\"Please select S10Marks, PLease Retry!\");"; ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
                }

                else
                {

                    if (ddlAcademicYear.SelectedIndex == 0)
                    {
                        string script = "alert(\" successfully Add Data !\");"; ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
                    }
                    else
                    {
                        string script = "alert(\" Already exist Academic year, PLease Retry!\");"; ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
                    }

                    bel.bel_Academic_Year = ddlAcademicYear.SelectedItem.Text;
                    bel.bel_First_Year_Marks = txt1YMarks.Text;
                    bel.bel_Second_Year_Marks = txt2YMarks.Text;
                    bel.bel_Third_Year_Marks = txt3YMarks.Text;
                    bel.bel_Fourth_Year_Marks = txt4YMarks.Text;
                    bel.bel_Fifth_Year_Marks = txt5YMarks.Text;
                    bel.bel_Sem_1_Marks = txtS1Marks.Text;
                    bel.bel_Sem_2_Marks = txtS2Marks.Text;
                    bel.bel_Sem_3_Marks = txtS3Marks.Text;
                    bel.bel_Sem_4_Marks = txtS4Marks.Text;
                    bel.bel_Sem_5_Marks = txtS5Marks.Text;
                    bel.bel_Sem_6_Marks = txtS6Marks.Text;
                    bel.bel_Sem_7_Marks = txtS7Marks.Text;
                    bel.bel_Sem_8_Marks = txtS8Marks.Text;
                    bel.bel_Sem_9_Marks = txtS9Marks.Text;
                    bel.bel_Sem_10_Marks = txtS10Marks.Text;
                   
                    //con.Open();
                    //cmd = new SqlCommand("Sp_Add_Total_Marks", con);
                    //cmd.CommandType = CommandType.StoredProcedure;
                    //cmd.Parameters.AddWithValue("@flag", 1);
                    //cmd.Parameters.AddWithValue("@Academic_Year", ddlAcademicYear.SelectedItem.Text);
                    //cmd.Parameters.AddWithValue("@First_Year_Marks", txt1YMarks.Text);
                    //cmd.Parameters.AddWithValue("@Second_Year_Marks", txt2YMarks.Text);
                    //cmd.Parameters.AddWithValue("@Third_Year_Marks", txt3YMarks.Text);
                    //cmd.Parameters.AddWithValue("@Fourth_Year_Marks", txt4YMarks.Text);
                    //cmd.Parameters.AddWithValue("@Fifth_Year_Marks", txt5YMarks.Text);
                    //cmd.Parameters.AddWithValue("@Sem_1_Marks", txtS1Marks.Text);
                    //cmd.Parameters.AddWithValue("@Sem_2_Marks", txtS2Marks.Text);
                    //cmd.Parameters.AddWithValue("@Sem_3_Marks", txtS3Marks.Text);
                    //cmd.Parameters.AddWithValue("@Sem_4_Marks", txtS4Marks.Text);
                    //cmd.Parameters.AddWithValue("@Sem_5_Marks", txtS5Marks.Text);
                    //cmd.Parameters.AddWithValue("@Sem_6_Marks", txtS6Marks.Text);
                    //cmd.Parameters.AddWithValue("@Sem_7_Marks", txtS7Marks.Text);
                    //cmd.Parameters.AddWithValue("@Sem_8_Marks", txtS8Marks.Text);
                    //cmd.Parameters.AddWithValue("@Sem_9_Marks", txtS9Marks.Text);
                    //cmd.Parameters.AddWithValue("@Sem_10_Marks", txtS10Marks.Text);

                    int retVal = bal.Add_TotalMarks(bel);

                    if (retVal > 0)
                    {
                        string script = "alert(\"Registration successfully !\");"; ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
                    }

                    else
                    {
                        string script = "alert(\"Registration details couldn't be Saved, PLease Retry!\");"; ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
                    }

                    con.Close();

                }
            }

            catch (Exception ex)
            {
               Response.Write("Oops! error occured :" + ex.Message.ToString());

            }
            finally
            {
                bal = null;
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
                txt1YMarks.Text = "";
                txt2YMarks.Text = "";
                txt3YMarks.Text = "";
                txt4YMarks.Text = "";
                txt5YMarks.Text = "";
                txtS1Marks.Text = "";
                txtS2Marks.Text = "";
                txtS3Marks.Text = "";
                txtS4Marks.Text = "";
                txtS5Marks.Text = "";
                txtS6Marks.Text = "";
                txtS7Marks.Text = "";
                txtS8Marks.Text = "";
                txtS9Marks.Text = "";
                txtS10Marks.Text = "";

            }
            catch (Exception ex)
            {
               Response.Write("Oops! error occured :" + ex.Message.ToString());
            }

        }
    }
}


