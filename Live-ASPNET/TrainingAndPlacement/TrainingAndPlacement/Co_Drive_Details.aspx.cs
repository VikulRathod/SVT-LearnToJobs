using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.IO;
using System.Text;
using System.Net.Mail;
using BEL;
using BAL;
namespace TrainingAndPlacement
{
    public partial class Co_Drive_Details : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["myConnectionString"].ConnectionString);
        SqlCommand cmd;
        bel_Derive bel = new bel_Derive();
        bal_Drive bal_d = new bal_Drive();
        bal_Company bal_C = new bal_Company();
        bel_Company bel_C = new bel_Company();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                bind_All_Company();
                Bind_Place_Drive();
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
        protected void Bind_Place_Drive()      // Member & Apply Debate ALL Detail View
        {
            try
            {
                SqlCommand cmd = new SqlCommand("SP_Add_Update_Drive", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@flag", 3);
                DataTable dt = new DataTable();
                SqlDataAdapter adp1 = new SqlDataAdapter(cmd);
                adp1.Fill(dt);
                gvplace_Drives.DataSource = dt;
                gvplace_Drives.DataBind();
                if (gvplace_Drives.Rows.Count <= 0)
                {
                    string script = "alert(\"Record Not Available!\");"; ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
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
                    cmd.Parameters.AddWithValue("@flag", 9);
                    cmd.Parameters.AddWithValue("@Academic_Year", ddlAcademicYear.SelectedValue);
                    cmd.Parameters.AddWithValue("@Company_ID", ddlCompany_ID.SelectedValue);
                    DataTable dt = new DataTable();
                    SqlDataAdapter adp1 = new SqlDataAdapter(cmd);
                    adp1.Fill(dt);
                    ddlDrive_Title.DataSource = dt;
                    ddlDrive_Title.DataTextField = "Drive_Title";
                    ddlDrive_Title.DataValueField = "Drive_Id";
                    ddlDrive_Title.DataBind();
                    ddlDrive_Title.Items.Insert(0, new ListItem("Select All", string.Empty));
                    gvplace_Drives.DataSource = dt;
                    gvplace_Drives.DataBind();
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
                    Bind_Place_Drive();
                }
                else
                {
                    SqlCommand cmd = new SqlCommand("Sp_Set_Drive_Criteria", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@flag", 4);
                    cmd.Parameters.AddWithValue("@Academic_Year", ddlAcademicYear.SelectedValue);
                    cmd.Parameters.AddWithValue("@Company_ID", ddlCompany_ID.SelectedValue);
                    cmd.Parameters.AddWithValue("@Drive_Id", ddlDrive_Title.SelectedValue);

                    DataTable dt = new DataTable();
                    SqlDataAdapter adp1 = new SqlDataAdapter(cmd);
                    adp1.Fill(dt);
                    if (dt.Rows.Count > 0)
                    {
                        gvplace_Drives.DataSource = dt;
                        gvplace_Drives.DataBind();
                    }
                    else
                    {
                        Bind_Place_Drive();
                    }
                }
            }
            catch (Exception ex)
            {
                Response.Write("Oops! error occured :" + ex.Message.ToString());
            }

        }
        protected void gvplace_Drives_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            gvplace_Drives.PageIndex = e.NewPageIndex;
            Bind_Place_Drive();
        }
        protected void gvplace_Drives_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            try
            {
                if (e.CommandName == "btnShowDrive")
                {
                    int index = Convert.ToInt32(e.CommandArgument.ToString());
                    Session["Drive"] = gvplace_Drives.Rows[index].Cells[0].Text.Trim();
                    Session["Academic"] = gvplace_Drives.Rows[index].Cells[1].Text.Trim();
                    Session["Company_ID"] = gvplace_Drives.Rows[index].Cells[2].Text.Trim();

                    Response.Redirect("Co_Drive_info.aspx");
                }
            }
            catch (Exception ex)
            {
                Response.Write("Oops! error occured :" + ex.Message.ToString());
            }
        }
    }
}