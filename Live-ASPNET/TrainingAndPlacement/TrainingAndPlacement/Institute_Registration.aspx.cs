using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.IO;
using BAL;
using BEL;
namespace TrainingAndPlacement.Master_Panel
{
    public partial class Institute_Registration : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["myConnectionString"].ConnectionString);
        bal_Institute bal_cp = new bal_Institute();
        bel_Institute bel_cp = new bel_Institute();
        bel_login login = new bel_login();
        bal_login bal_login = new bal_login();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                bind_info();
            }
        }
        protected void bind_info()
        {
            DataSet ds = new DataSet();
            //ds = bal_cp.select(bel_cp);
            SqlCommand cmd = new SqlCommand("Institute_Details", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@flag", 3);
            SqlDataAdapter adp1 = new SqlDataAdapter(cmd);
            adp1.Fill(ds);
            if (ds.Tables[0].Rows.Count > 0)
            {
             
                txtI_name.Text = ds.Tables[0].Rows[0][1].ToString();
                txtI_contact.Text = ds.Tables[0].Rows[0][2].ToString();
                txtI_email.Text = ds.Tables[0].Rows[0][3].ToString();
                txtI_web.Text = ds.Tables[0].Rows[0][4].ToString();
                txtI_add1.Text = ds.Tables[0].Rows[0][5].ToString();
                txtI_add2.Text = ds.Tables[0].Rows[0][6].ToString();
                txtI_city.Text = ds.Tables[0].Rows[0][7].ToString();
                txtI_disc.Text = ds.Tables[0].Rows[0][8].ToString();
                txtI_pin.Text = ds.Tables[0].Rows[0][9].ToString();
                txtsendmail.Text = ds.Tables[0].Rows[0][10].ToString();
                txtsendmailpwd.Text = ds.Tables[0].Rows[0][11].ToString();
                txtsmtp.Text = ds.Tables[0].Rows[0][12].ToString();
                txtport.Text = ds.Tables[0].Rows[0][13].ToString();
                txtlink.Text = ds.Tables[0].Rows[0][14].ToString();
                txtsmsid.Text = ds.Tables[0].Rows[0][15].ToString();
                txtsmspass.Text = ds.Tables[0].Rows[0][16].ToString();
            }
            Panel1.Enabled = false;
            btnsave.Visible = false;
            tbnclear.Visible = false;
            btnedit.Visible = true;
        }
        protected void btnedit_Click(object sender, EventArgs e)
        {
            Panel1.Enabled = true;
            btnsave.Visible = true;
            tbnclear.Visible = true;
            btnedit.Visible = false;
        }
        protected void btnsave_Click(object sender, EventArgs e)
        {
           
            bel_cp.bel_Institute_name = txtI_name.Text.Trim();
            bel_cp.bel_contact_no = txtI_contact.Text.Trim();
            bel_cp.bel_email_id = txtI_email.Text.Trim();
            bel_cp.bel_website = txtI_web.Text.Trim();
            bel_cp.bel_addressline1 = txtI_add1.Text.Trim();
            bel_cp.bel_addressline2 = txtI_add2.Text.Trim();
            bel_cp.bel_town = txtI_city.Text.Trim();
            bel_cp.bel_district = txtI_disc.Text.Trim();
            bel_cp.bel_post_code = txtI_pin.Text.Trim();
            bel_cp.bel_mail_Email_id = txtsendmail.Text.Trim();
            bel_cp.bel_mail_password = txtsendmailpwd.Text.Trim();
            bel_cp.bel_smtp = txtsmtp.Text.Trim();
            bel_cp.bel_port = txtport.Text.Trim();
            bel_cp.bel_link = txtlink.Text.Trim();
            bel_cp.bel_smsid = txtsmsid.Text.Trim();
            bel_cp.bel_smspass = txtsmspass.Text.Trim();

            try
            {
                int retVal = bal_cp.Institute_regi(bel_cp);
                if (retVal > 0)
                {
                    if (FileUpload1.HasFile)
                    {
                        // If tru Browser Image Path and image saved in folder
                        string student_photoURL = "~/img/logo.png";
                        FileUpload1.PostedFile.SaveAs(Server.MapPath(student_photoURL.Trim()));
                        // If tru Browser Image Path and image saved in folder
                    }
                    bind_info();
                    string script = "alert(\"Successfully Updated!\");"; ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
                }
                else
                {
                    string script = "alert(\"Update Details couldn't be saved!\");"; ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
                }
            }
            catch (Exception ex)
            {
                Response.Write("Oops! error occured :" + ex.Message.ToString());
            }
            finally
            {
                bal_cp = null;
                bel_cp = null;
            }
        }
        protected void tbnclear_Click(object sender, EventArgs e)
        {
            txtI_name.Text = "";
            txtI_contact.Text = "";
            txtI_email.Text = "";
            txtI_web.Text = "";
            txtI_add1.Text = "";
            txtI_add2.Text = "";
            txtI_city.Text = "";
            txtI_disc.Text = "";
            txtI_pin.Text = "";
            txtsendmail.Text = "";
            txtsendmailpwd.Text = "";
            txtsmtp.Text = "";
            txtport.Text = "";
            txtlink.Text = "";
            txtsmsid.Text = "";
            txtsmspass.Text = "";
        }
        
    }
}