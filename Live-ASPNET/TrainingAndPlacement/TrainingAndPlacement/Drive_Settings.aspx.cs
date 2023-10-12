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
    public partial class Drive_Settings : System.Web.UI.Page
    {
        DataTable dt = new DataTable();
        SqlConnection con = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["myConnectionString"].ConnectionString);
        bel_Derive bel = new bel_Derive();
        bal_Drive bal = new bal_Drive();
        bal_Company bal_C = new bal_Company();
        bel_Company bel_C = new bel_Company();
        string status = "Active";
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
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
                ddlCompany_ID.DataValueField = "Company_id";
                ddlCompany_ID.DataBind();
                ddlCompany_ID.Items.Insert(0, new ListItem("Select All", string.Empty));
            }
        }

        protected void ddlCompany_ID_SelectedIndexChanged(object sender, EventArgs e)
        {
            bind_Drive_by_Company();
        }
        protected void bind_Drive_by_Company()
        {
            if (ddlCompany_ID.SelectedIndex == 0)
            {
                string script = "alert(\"Please Select Company ID !\");"; ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
            }
            else
            {
                SqlCommand cmd = new SqlCommand("SP_Add_Update_Drive", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@flag", 5);
                cmd.Parameters.AddWithValue("@Academic_Year", ddlAcademic.SelectedItem.Text);
                cmd.Parameters.AddWithValue("@Company_ID", ddlCompany_ID.SelectedValue);
                cmd.Parameters.AddWithValue("@Reg_To_Date", DateTime.Now.ToString("dd/MM/yyyy"));
                DataTable dT = new DataTable();
                SqlDataAdapter adp1 = new SqlDataAdapter(cmd);
                adp1.Fill(dT);

                ddlDriveTitle.DataSource = dT;
                ddlDriveTitle.DataTextField = "Drive_Title";
                ddlDriveTitle.DataValueField = "Drive_Id";
                ddlDriveTitle.DataBind();
                ddlDriveTitle.Items.Insert(0, new ListItem("---Select----", string.Empty));
                gvDrive.DataSource = dT;
                gvDrive.DataBind();
            }
        }
        protected void btnsave_Click(object sender, EventArgs e)
        {
            try
            {
                if (ddlAcademic.SelectedIndex == 0)
                {
                    string script = "alert(\"Please select AcademicYear, PLease Retry!\");"; ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
                }
                else if (ddlCompany_ID.SelectedIndex == 0)
                {
                    string script = "alert(\"Please select Company_ID, PLease Retry!\");"; ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
                }
                else if (ddlDriveTitle.SelectedIndex == 0)
                {
                    string script = "alert(\"Please Drive_Title, PLease Retry!\");"; ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
                }
                else
                {
                    bel.bel_Academic_Year = ddlAcademic.SelectedItem.Text;
                    bel.bel_Company_ID = ddlCompany_ID.SelectedValue;
                    bel.bel_id = ddlDriveTitle.SelectedValue;
                    bel.bel_Status = "Active";
                    int result = bal.update_Status(bel);
                    if (result > 0)
                    {
                        string script = "alert(\"Drive is Activated !\");"; ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
                    }
                    else
                    {
                        string script = "alert(\"Drive is not Activated !\");"; ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
                    }
                    bind_Drive_by_Company();
                }
            }
            catch (Exception ex)
            {
                Response.Write("Oops! error occured :" + ex.Message.ToString());
            }
        }

        protected void tbnDeactive_Click(object sender, EventArgs e)
        {
            try
            {
                if (ddlAcademic.SelectedIndex == 0)
                {
                    string script = "alert(\"Please select AcademicYear, PLease Retry!\");"; ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
                }
                else if (ddlCompany_ID.SelectedIndex == 0)
                {
                    string script = "alert(\"Please select Company_ID, PLease Retry!\");"; ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
                }
                else if (ddlDriveTitle.SelectedIndex == 0)
                {
                    string script = "alert(\"Please Drive_Title, PLease Retry!\");"; ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
                }
                else
                {
                    bel.bel_Academic_Year = ddlAcademic.SelectedItem.Text;
                    bel.bel_Company_ID = ddlCompany_ID.SelectedValue;
                    bel.bel_id = ddlDriveTitle.SelectedValue;
                    bel.bel_Status = "Deactive";
                    int result = bal.update_Status(bel);
                    if (result > 0)
                    {
                        string script = "alert(\"Drive is DeActivated !\");"; ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
                    }
                    else
                    {
                        string script = "alert(\"Drive is not DeActivated !\");"; ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
                    }
                    bind_Drive_by_Company();
                }
            }
            catch (Exception ex)
            {
                Response.Write("Oops! error occured :" + ex.Message.ToString());
            }
        }
    }
}