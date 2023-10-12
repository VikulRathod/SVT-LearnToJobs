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
    public partial class Student_Apply_Drive : System.Web.UI.Page
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
            if (Session["Student_Id"] != null && Session["Company_ID"] != null && Session["Drive"] != null && Session["Academic"] != null && Session["Placed"] != null)
            {
                string str = "select count(*) from Set_Drive_Criteria where Academic_Year='" + Session["Academic"].ToString() + "' and Company_ID='" + Session["Company_ID"].ToString() + "' and Drive_Id='" + Session["Drive"].ToString() + "'";
                SqlCommand cmd = new SqlCommand(str, con);
                con.Open();
                int count = (int)cmd.ExecuteScalar();
                con.Close();
                if (count > 0)
                {
                    Bind_Drive_Criteria();
                    Bind_Eligibility_Criteria();
                }
                else
                {
                    btnApply.Enabled = false;
                    string script = "alert(\"Drive Criteria Not Set!!!\");"; ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
                }
                if (Session["Placed"].ToString() == "Placed")
                {
                    btnApply.Enabled = false;
                }
                string str1 = "select count(*) from Student_Applied_Drive where Student_ID ='" + Session["Student_Id"].ToString() + "' and Drive_Id='" + Session["Drive"].ToString() + "'";
                SqlCommand cmd1 = new SqlCommand(str1, con);
                con.Open();
                int count1 = (int)cmd1.ExecuteScalar();
                con.Close();
                if (count1 > 0) 
                {
                    btnApply.Enabled = false;
                }
            }
            else
            {
                Response.Redirect("Student_place_Drives.aspx");
            }
        }
        protected void Bind_Drive_Criteria()
        {
            try
            {
                SqlCommand cmd = new SqlCommand("Sp_Set_Drive_Criteria", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@flag", 5);
                cmd.Parameters.AddWithValue("@Company_ID", Session["Company_ID"].ToString());
                cmd.Parameters.AddWithValue("@Academic_Year", Session["Academic"].ToString());
                cmd.Parameters.AddWithValue("@Drive_Id", Session["Drive"].ToString());
                cmd.Parameters.AddWithValue("@Stud_id", Session["Student_Id"].ToString());
                DataTable dt = new DataTable();
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                sda.Fill(dt);

                DataTable dt2 = new DataTable();
                dt2.Columns.AddRange(new DataColumn[4] { new DataColumn("Header"), new DataColumn("rcriteria"), new DataColumn("scriteria"), new DataColumn("abcriteria") });
                dt2.Rows.Add("SSC Marks");
                dt2.Rows.Add("SSC Passing Year");
                dt2.Rows.Add("HSC Marks");
                dt2.Rows.Add("HSC Passing Year");
                dt2.Rows.Add("DIPLOMA Marks");
                dt2.Rows.Add("DIPLOMA Passing Year");
                dt2.Rows.Add("UG Marks");
                dt2.Rows.Add("UG Passing Year");
                dt2.Rows.Add("PG Marks");
                dt2.Rows.Add("PG Passing Year");

                dt2.Rows.Add("First Year %");
                dt2.Rows.Add("Second Year %");
                dt2.Rows.Add("Third Year %");
                dt2.Rows.Add("Fourth Year %");
                dt2.Rows.Add("Fifth Year %");
                dt2.Rows.Add("Semester 1 %");
                dt2.Rows.Add("Semester 2 %");
                dt2.Rows.Add("Semester 3 %");
                dt2.Rows.Add("Semester 4 %");
                dt2.Rows.Add("Semester 5 %");
                dt2.Rows.Add("Semester 6 %");
                dt2.Rows.Add("Semester 7 %");
                dt2.Rows.Add("Semester 8 %");
                dt2.Rows.Add("Aggregate %");

                dt2.Rows.Add("First Year Pointer");
                dt2.Rows.Add("Second Year Pointer");
                dt2.Rows.Add("Third Year Pointer");
                dt2.Rows.Add("Fourth Year Pointer");
                dt2.Rows.Add("Fifth Year Pointer");
                dt2.Rows.Add("Semester 1 Pointer");
                dt2.Rows.Add("Semester 2 Pointer");
                dt2.Rows.Add("Semester 3 Pointer");
                dt2.Rows.Add("Semester 4 Pointer");
                dt2.Rows.Add("Semester 5 Pointer");
                dt2.Rows.Add("Semester 6 Pointer");
                dt2.Rows.Add("Semester 7 Pointer");
                dt2.Rows.Add("Semester 8 Pointer");

                dt2.Rows.Add("GAP Duration (Max)");
                dt2.Rows.Add("Live Backlogs (Max)");
                dt2.Rows.Add("Dead Backlogs (Max)");
                dt2.Rows.Add("Experience (Min)");
                dt2.Rows.Add("Entrance Score");

                for (int i = 0; i < dt.Columns.Count; i++)
                {
                    for (int j = 0; j < dt.Rows.Count; j++)
                    {
                        dt2.Rows[i][j + 1] = dt.Rows[j][i];
                    }
                }
                gvPlace_Drive.DataSource = dt2;
                gvPlace_Drive.DataBind();
            }
            catch (Exception ex)
            {
                btnApply.Enabled = false;
                Response.Write("Oops! error occured :" + ex.Message.ToString());
            }
        }
        protected void Bind_Eligibility_Criteria()
        {
            int Y = 0, N = 0;
            foreach (GridViewRow item in gvPlace_Drive.Rows)
            {
                try
                {
                    int row = item.RowIndex;
                    if (item.Cells[1].Text != "" && item.Cells[1].Text != "&nbsp;" && item.Cells[1].Text != string.Empty && item.Cells[2].Text != "" && item.Cells[2].Text != "&nbsp;" && item.Cells[2].Text != string.Empty)
                    {
                        if (row == 1 || row == 3 || row == 5 || row == 7 || row == 9)
                        {
                            if (row == 5)
                            {
                                if (Convert.ToDecimal(item.Cells[1].Text) > 0)
                                {
                                    if (Convert.ToDecimal(item.Cells[1].Text) == Convert.ToDecimal(item.Cells[2].Text))
                                    {
                                        item.Cells[3].Text = "YES";
                                        Y++;
                                        item.Cells[3].ForeColor = Color.Green;
                                    }
                                    else
                                    {
                                        item.Cells[3].Text = "NO";
                                        N++;

                                        item.Cells[3].ForeColor = Color.Red;
                                    }
                                }
                                else
                                {
                                    item.Cells[3].Text = "YES";
                                    Y++;
                                    item.Cells[3].ForeColor = Color.Green;
                                }
                            }
                            else
                            {
                                if (Convert.ToDecimal(item.Cells[1].Text) == Convert.ToDecimal(item.Cells[2].Text))
                                {
                                    item.Cells[3].Text = "YES";
                                    Y++;
                                    item.Cells[3].ForeColor = Color.Green;
                                }
                                else
                                {
                                    item.Cells[3].Text = "NO";
                                    N++;

                                    item.Cells[3].ForeColor = Color.Red;
                                }
                            }
                        }
                        else if (row == 37 || row == 38 || row == 39)
                        {
                            if (Convert.ToDecimal(item.Cells[1].Text) <= Convert.ToDecimal(item.Cells[2].Text))
                            {
                                item.Cells[3].Text = "YES";
                                Y++;
                                item.Cells[3].ForeColor = Color.Green;
                            }
                            else
                            {
                                item.Cells[3].Text = "NO";
                                N++;

                                item.Cells[3].ForeColor = Color.Red;
                            }
                        }
                        else if (Convert.ToDecimal(item.Cells[1].Text) <= Convert.ToDecimal(item.Cells[2].Text))
                        {
                            item.Cells[3].Text = "YES";
                            Y++;
                            item.Cells[3].ForeColor = Color.Green;
                        }
                        else
                        {
                            item.Cells[3].Text = "NO";
                            N++;

                            item.Cells[3].ForeColor = Color.Red;
                        }
                    }
                    else
                    {
                        string script = "alert(\"Drive Criteria Not Set!!!\");"; ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
                    }
                }
                catch (Exception ex)
                {
                    btnApply.Enabled = false;
                    Response.Write("Oops! error occured :" + ex.Message.ToString());
                }
            }
            txteligible.Text = Convert.ToString(Y).ToString();
            txtineligible.Text = Convert.ToString(N).ToString();
            if (N != 0)
            {
                txtmsg.Text = "You are not Eligible as Drive Criteria";
                txtmsg.ForeColor = Color.Red;
                btnApply.Enabled = false;
            }
            else
            {
                txtmsg.Text = "Congratulations!! You are eligible for this drive.";
            }
        }
        protected void btnApply_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtineligible.Text == "0" && Session["Student_Id"] != null && Session["Company_ID"] != null && Session["Drive"] != null && Session["Academic"] != null)
                {
                    bel_D.bel_id = Session["Student_Id"].ToString();
                    bel_D.bel_Academic_Year = Session["Academic"].ToString();
                    bel_D.bel_Company_ID = Session["Company_ID"].ToString();
                    bel_D.bel_Company_name = Session["Student_Id"].ToString();
                    bel_D.bel_Drive_Title = Session["Drive"].ToString();
                    bel_D.bel_AppliedDate = DateTime.Now.ToString("dd/MM/yyyy");
                    bel_D.bel_Status = "Round1";


                    int Result = bal.Student_Applied_Drive(bel_D);
                    if (Result > 0)
                    {
                        btnApply.Enabled = false;
                       string script = "alert(\"Applied Successfully!!!\");"; ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
                    }
                    else
                    {
                        string script = "alert(\"Drive couldn't be Applied!!!\");"; ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
                    }
                }
                else
                {
                    Response.Redirect("Student_place_Drives.aspx");
                }
            }

            catch (Exception ex)
            {
                btnApply.Enabled = false;
                Response.Write("Oops! error occured :" + ex.Message.ToString());
            }
            finally
            {

            }
        }
    }
}