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
    public partial class Set_Drive_Schedule : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["myConnectionString"].ConnectionString);
        SqlCommand cmd = new SqlCommand();
        bel_Derive bel = new bel_Derive();
        bal_Drive bal = new bal_Drive();
        bal_Company bal_C = new bal_Company();
        bel_Company bel_C = new bel_Company();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                bind_All_Company();
                bind_Current_Round();
            }
        }
        protected void bind_All_Company()
        {
            DataSet ds = bal_C.bind_All_Company(bel_C);

            ddlCompany_ID.DataSource = ds;
            ddlCompany_ID.DataTextField = "company_name";
            ddlCompany_ID.DataValueField = "Company_id";
            ddlCompany_ID.DataBind();
            ddlCompany_ID.Items.Insert(0, new ListItem("Select All", string.Empty));
        }
        protected void bind_Current_Round()
        {
            SqlCommand cmd = new SqlCommand("Sp_Set_Drive_Schedule", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@flag", 6);
            cmd.Parameters.AddWithValue("@Round_Date", DateTime.Now.ToString("dd/MM/yyyy"));
            DataTable dt = new DataTable();
            SqlDataAdapter adp1 = new SqlDataAdapter(cmd);
            adp1.Fill(dt);
            gvShowschedule.DataSource = dt;
            gvShowschedule.DataBind();
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
                    cmd.Parameters.AddWithValue("@Company_ID", ddlCompany_ID.SelectedValue);
                    cmd.Parameters.AddWithValue("@Academic_Year", ddlAcademicYear.SelectedItem.Text);
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
        protected void btnsave_Click(object sender, EventArgs e)
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
                    string script = "alert(\"Please Drive_Title, PLease Retry!\");"; ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
                }
                else if (ddlRoundNumber.SelectedIndex == 0)
                {
                    string script = "alert(\"Please select RoundNumber, PLease Retry!\");"; ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
                }
                else if (txtRoundTitle.Text == "&nbsp;" || txtRoundTitle.Text == "" || txtRoundTitle.Text == string.Empty)
                {
                    string script = "alert(\"Please select RoundTitle, PLease Retry!\");"; ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
                }
                else if (txtRoundDate.Text == "&nbsp;" || txtRoundDate.Text == "" || txtRoundDate.Text == string.Empty)
                {
                    string script = "alert(\"Please select RoundDate, PLease Retry!\");"; ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
                }
                else if (txtRoundTiming.Text == "&nbsp;" || txtRoundTiming.Text == "" || txtRoundTiming.Text == string.Empty)
                {
                    string script = "alert(\"Please select txtRoundTiming, PLease Retry!\");"; ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
                }
                else if (txtVenue.Text == "&nbsp;" || txtVenue.Text == "" || txtVenue.Text == string.Empty)
                {
                    string script = "alert(\"Please Venue, PLease Retry!\");"; ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
                }
                else
                {
                    string str = "select count(*) from Set_Drive_Schedule where Academic_Year='" + ddlAcademicYear.SelectedItem.Text + "' AND Company_ID='" + ddlCompany_ID.SelectedValue + "' and Drive_Id ='" + ddlDrive_Title.SelectedValue + "' and Round_Number ='" + ddlRoundNumber.SelectedItem.Text + "'";
                    SqlCommand cmd = new SqlCommand(str, con);
                    con.Open();
                    int count = (int)cmd.ExecuteScalar();
                    con.Close();

                    if (count <= 0)
                    {
                        bel.bel_Academic_Year = ddlAcademicYear.SelectedItem.Text;
                        bel.bel_Company_ID = ddlCompany_ID.SelectedValue;
                        bel.bel_id = ddlDrive_Title.SelectedValue;
                        bel.bel_Round_Number = ddlRoundNumber.SelectedItem.Text;
                        bel.bel_Round_Title = txtRoundTitle.Text;
                        bel.bel_Round_Date = txtRoundDate.Text;
                        bel.bel_Round_Timing = txtRoundTiming.Text;
                        bel.bel_Venue = txtVenue.Text;
                        bel.bel_Description = txtDescription.Text;

                        int retVal = bal.Add_Drive_Schedule(bel);

                        if (retVal > 0)
                        {
                            string script = "alert(\"Add Drive Schedule successfully !\");"; ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
                        }
                        else
                        {
                            string script = "alert(\"Add Drive Schedule  details couldn't be Saved, PLease Retry!\");"; ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
                        }
                    }
                    else
                    {

                        bel.bel_Academic_Year = ddlAcademicYear.SelectedItem.Text;
                        bel.bel_Company_ID = ddlCompany_ID.SelectedValue;
                        bel.bel_id = ddlDrive_Title.SelectedValue;
                        bel.bel_Round_Number = ddlRoundNumber.SelectedItem.Text;
                        bel.bel_Round_Title = txtRoundTitle.Text;
                        bel.bel_Round_Date = txtRoundDate.Text;
                        bel.bel_Round_Timing = txtRoundTiming.Text;
                        bel.bel_Venue = txtVenue.Text;
                        bel.bel_Description = txtDescription.Text;

                        int retVal = bal.update_Drive_Schedule(bel);

                        if (retVal > 0)
                        {
                            string script = "alert(\" update Drive Schedule  successfully !\");"; ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
                         }
                        else
                        {
                            string script = "alert(\" update Drive Schedule details  couldn't be Saved, PLease Retry!\");"; ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
                        }
                    }

                }
                clear();
                bind_Current_Round();
            }
            catch (Exception ex)
            {
                Response.Write("Oops! error occured :" + ex.Message.ToString());
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

                ddlAcademicYear.SelectedIndex = 0;
                ddlCompany_ID.SelectedIndex = 0;
                ddlDrive_Title.SelectedIndex = 0;
                ddlRoundNumber.SelectedIndex = 0;
                txtRoundTitle.Text = "";
                txtRoundDate.Text = "";
                txtRoundTiming.Text = "";
                txtVenue.Text = "";
                txtDescription.Text = "";
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
                    string script = "alert(\"Please select AcademicYear, PLease Retry!\");"; ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
                }
                else if (ddlCompany_ID.SelectedIndex == 0)
                {
                    string script = "alert(\"Please select Company_ID, PLease Retry!\");"; ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
                }
                else if (ddlDrive_Title.SelectedIndex == 0)
                {
                    string script = "alert(\"Please Drive_Title, PLease Retry!\");"; ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
                }
                else
                {
                    string str = "select count(*) from Set_Drive_Schedule where Academic_Year='" + ddlAcademicYear.SelectedItem.Text + "' AND Company_ID='" + ddlCompany_ID.SelectedValue + "' and Drive_Id ='" + ddlDrive_Title.SelectedValue + "'";
                    SqlCommand cmd = new SqlCommand(str, con);
                    con.Open();
                    int count = (int)cmd.ExecuteScalar();
                    con.Close();

                    if (count > 0)
                    {
                        bel.bel_Academic_Year = ddlAcademicYear.SelectedItem.Text;
                        bel.bel_Company_ID = ddlCompany_ID.SelectedValue;
                        bel.bel_id = ddlDrive_Title.SelectedValue;
                        DataSet ds = bal.Bind_Schedule(bel);
                        gvShowschedule.DataSource = ds;
                        gvShowschedule.DataBind();
                    }
                }
            }
            catch (Exception ex)
            {
                Response.Write("Oops! error occured :" + ex.Message.ToString());
            }

        }

        protected void btnshowall_Click(object sender, EventArgs e)
        {
            try
            {
                bind_Current_Round();
            }
            catch (Exception ex)
            {
                Response.Write("Oops! error occured :" + ex.Message.ToString());
            }
        }

        protected void ddlRoundNumber_SelectedIndexChanged(object sender, EventArgs e)
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
                    string script = "alert(\"Please Drive_Title, PLease Retry!\");"; ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
                }
                else if (ddlRoundNumber.SelectedIndex == 0)
                {
                    string script = "alert(\"Please select RoundNumber, PLease Retry!\");"; ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
                }
                else
                {
                    bel.bel_Academic_Year = ddlAcademicYear.SelectedItem.Text;
                    bel.bel_Company_ID = ddlCompany_ID.SelectedValue;
                    bel.bel_id = ddlDrive_Title.SelectedValue;
                    bel.bel_Round_Number = ddlRoundNumber.Text;
                    DataSet ds = bal.Bind_Round_Drive_Schedule(bel);


                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        txtRoundTitle.Text = ds.Tables[0].Rows[0][5].ToString();
                        txtRoundDate.Text = ds.Tables[0].Rows[0][6].ToString();
                        txtRoundTiming.Text = ds.Tables[0].Rows[0][7].ToString();
                        txtVenue.Text = ds.Tables[0].Rows[0][8].ToString();
                        txtDescription.Text = ds.Tables[0].Rows[0][9].ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                Response.Write("Oops! error occured :" + ex.Message.ToString());
            }

        }
        protected void btnexcel_Click(object sender, EventArgs e)
        {
            try
            {
                if (gvShowschedule.Rows.Count > 0)
                {
                    Response.ClearContent();
                    Response.Buffer = true;
                    Response.AddHeader("content-disposition", string.Format("attachment; filename={0}", "Drive_Current Schedule_List.xls"));
                    Response.ContentType = "application/ms-excel";
                    StringWriter sw = new StringWriter();
                    HtmlTextWriter htw = new HtmlTextWriter(sw);
                    gvShowschedule.AllowPaging = false;
                    //Change the Header Row back to white color
                    gvShowschedule.HeaderRow.Style.Add("background-color", "#FFFFFF");
                    //Applying stlye to gridview header cells
                    for (int i = 0; i < gvShowschedule.HeaderRow.Cells.Count; i++)
                    {
                        gvShowschedule.HeaderRow.Cells[i].Style.Add("background-color", "#df5015");
                    }
                    gvShowschedule.RenderControl(htw);
                    Response.Write(sw.ToString());
                    Response.End();
                }
                else
                {
                    string script = "alert(\"Record Not Available!\");"; ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
                }
            }
            catch (Exception ex)
            {
                Response.Write("Oops! error occured :" + ex.Message.ToString());
            }
        }
        public override void VerifyRenderingInServerForm(Control control)
        {
            /* Verifies that the control is rendered */
        }
    }
}



