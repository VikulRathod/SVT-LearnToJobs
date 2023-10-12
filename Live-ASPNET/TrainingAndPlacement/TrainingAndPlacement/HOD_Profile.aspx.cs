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
using System.Net.Mail;
using System.Net;
using BAL;
using BEL;

namespace TrainingAndPlacement
{
    public partial class HOD_Profile : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["myConnectionString"].ConnectionString);
        bal_emp_regi bal_er = new bal_emp_regi();
        bel_emp_regi bel_er = new bel_emp_regi();
        bal_Dept bal = new bal_Dept();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["HOD_Id"] != null && Session["HOD_Id"] != "" && Session["HOD_Id"] != string.Empty && Session["HOD_Id"] != "&nbsp;")
            {
                bind_Department();
                search();
            }
        }
        protected void bind_Department()
        {
            {
                DataSet ds = bal.gvDepartment_Bind();
                ddlDepartment.DataSource = ds;
                ddlDepartment.DataTextField = "Department";
                ddlDepartment.DataValueField = "Id";
                ddlDepartment.DataBind();
                ddlDepartment.Items.Insert(0, new ListItem("---Select----", string.Empty));
            }
        }
        protected void search()
        {
            DataSet ds = new DataSet();
            try
            {
                bel_er.bel_emp_id = Session["HOD_Id"].ToString();
                ds = bal_er.bind_ID_wise(bel_er);

                if (ds.Tables[0].Rows.Count > 0)
                {

                    ddlDepartment.SelectedValue = ds.Tables[0].Rows[0][16].ToString();
                    Fname.Text = ds.Tables[0].Rows[0][1].ToString();
                    Mname.Text = ds.Tables[0].Rows[0][2].ToString();
                    Lname.Text = ds.Tables[0].Rows[0][3].ToString();
                    txtcardnoC.Text = ds.Tables[0].Rows[0][4].ToString() + " -" + ds.Tables[0].Rows[0][5].ToString();
                    txtgender.Text = ds.Tables[0].Rows[0][6].ToString();
                    txtC_dob.Text = ds.Tables[0].Rows[0][7].ToString();
                    if (txtC_dob.Text != "")
                    {
                        txtC_dob.Text = Convert.ToDateTime(txtC_dob.Text).ToString("dd/MM/yyyy");
                    }
                    txtC_address.Text = ds.Tables[0].Rows[0][11].ToString();
                    txtC_City.Text = ds.Tables[0].Rows[0][8].ToString();
                    txtC_state.Text = ds.Tables[0].Rows[0][9].ToString();
                    txtC_Pincode.Text = ds.Tables[0].Rows[0][10].ToString();
                    txtC_contact.Text = ds.Tables[0].Rows[0][12].ToString();
                    txtC_alt.Text = ds.Tables[0].Rows[0][13].ToString();
                    txtC_email.Text = ds.Tables[0].Rows[0][14].ToString();


                }
                else
                {
                    string script = "alert(\"HOD Id Not Found In Database!\");"; ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
                }
            }
            catch (Exception ex)
            {
                Response.Write("Oops! error occured :" + ex.Message.ToString());
            }
        }
    }
}