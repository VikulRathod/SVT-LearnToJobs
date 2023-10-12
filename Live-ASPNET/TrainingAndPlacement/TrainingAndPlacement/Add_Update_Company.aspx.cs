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
using BEL;
using BAL;
namespace TrainingAndPlacement.Master_Panel
{
    public partial class Add_Update_Company : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["myConnectionString"].ConnectionString);
        bal_Company bal = new bal_Company();
        bel_Company bel = new bel_Company();

        SqlCommand cmd = new SqlCommand();
        bel_login login = new bel_login();
        bal_login bal_login = new bal_login();
        string email_from, email_pwd, userid, txtc_name, rxrc_contact, txtc_email, txtc_web, txtc_add1, txtc_add2, txtc_pin;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                bind_profile();
                Company_id();
                bind_All_Company();
            }

        }
        private void Company_id()
        {

            SqlDataAdapter sds = new SqlDataAdapter("Auto_Company_id", con);
            sds.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            sds.Fill(dt);
            txtcompany_id.Text = dt.Rows[0][0].ToString();
        }
        protected void bind_All_Company()
        {
            try
            {

                //DataSet ds = bal.bind_All_Company(bel);
                cmd = new SqlCommand("Company_Details", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@flag", 3);
                cmd.Parameters.AddWithValue("@Company_name", bel.bel_Company_name);
                cmd.Parameters.AddWithValue("@Company_id", bel.bel_Company_id);

                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataSet dt = new DataSet();
                sda.Fill(dt);
                gvCompany.DataSource = dt;
                gvCompany.DataBind();

                ddlCompany.DataSource = dt;
                ddlCompany.DataTextField = "company_name";
                ddlCompany.DataValueField = "Company_id";
                ddlCompany.DataBind();
                ddlCompany.Items.Insert(0, new ListItem("-----Add New Company-----", string.Empty));
            }
            catch(Exception ex)
            {
                Response.Write("Oops! error occured :" + ex.Message.ToString());
            }
        }
        protected void ddlCompany_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ddlCompany.SelectedIndex != 0)
            {
                txtcompany_id.Text = ddlCompany.SelectedValue;
                Search();
            }
            else
            {
                Company_id();
            }
        }
        protected void Search()
        {
            try
            {
                if (txtcompany_id.Text == "")
                {
                    string script = "alert(\"Please enter company_id!\");"; ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
                }

                else
                {
                    bel.bel_Company_id = txtcompany_id.Text;
                    DataSet ds = bal.Select_Add_Update_Company(bel);


                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        txtcompany_id.Text = ds.Tables[0].Rows[0][1].ToString();
                        txtcompany_name.Text = ds.Tables[0].Rows[0][2].ToString();
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
                        gvCompany.DataSource = ds;
                        gvCompany.DataBind();

                    }

                }
            }
            catch (Exception ex)
            {
                Response.Write("Oops! error occured :" + ex.Message.ToString());
            }
        }
        protected void tbnclear_Click(object sender, EventArgs e)
        {
            clear();
        }
        protected void btnsave_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtcompany_name.Text == "nbsp;" || txtcompany_name.Text == "" || txtcompany_name.Text == String.Empty)
                {
                    string script = "alert(\"Please Enter company_name,Please Retry!\");"; ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
                }
                ////else if (txtperson.Text == "nbsp;" || txtperson.Text == "" || txtperson.Text == String.Empty)
                ////{
                ////    string script = "alert(\"Please select person,Please Retry!\");"; ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
                ////}
                ////else if (txtDesignation.Text == "nbsp;" || txtDesignation.Text == "" || txtDesignation.Text == String.Empty)
                //{
                //    string script = "alert(\"Please select Medium,Please Retry!\");"; ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
                //}
                else if (txtContactNo.Text == "nbsp;" || txtContactNo.Text == "" || txtContactNo.Text == String.Empty)
                {
                    string script = "alert(\"Please Enter ContactNo,Please Retry!\");"; ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
                }

                //else if (txtofc_no.Text == "nbsp;" || txtofc_no.Text == "" || txtofc_no.Text == String.Empty)
                //{
                //    string script = "alert(\"Please select ofc_no,Please Retry!\");"; ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
                //}
                else if (txtcompany_email.Text == "nbsp;" || txtcompany_email.Text == "" || txtcompany_email.Text == String.Empty)
                {
                    string script = "alert(\"Please Enter company_email,Please Retry!\");"; ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
                }
                //else if (txtcweb.Text == "nbsp;" || txtcweb.Text == "" || txtcweb.Text == String.Empty)
                //{
                //    string script = "alert(\"Please select cweb,Please Retry!\");"; ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
                //}
                //else if (txtc_address.Text == "nbsp;" || txtc_address.Text == "" || txtc_address.Text == String.Empty)
                //{
                //    string script = "alert(\"Please select c_address,Please Retry!\");"; ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
                //}
                //else if (txtc_type.Text == "nbsp;" || txtc_type.Text == "" || txtc_type.Text == String.Empty)
                //{
                //    string script = "alert(\"Please select c_type,Please Retry!\");"; ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
                //}
                //else if (txtc_services.Text == "nbsp;" || txtc_services.Text == "" || txtc_services.Text == String.Empty)
                //{
                //    string script = "alert(\"Please select services,Please Retry!\");"; ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
                //}
                //else if (txtcdomain_services.Text == "nbsp;" || txtcdomain_services.Text == "" || txtcdomain_services.Text == String.Empty)
                //{
                //    string script = "alert(\"Please select cdomain_services,Please Retry!\");"; ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
                //}
                //else if (txtDescription.Text == "nbsp;" || txtDescription.Text == "" || txtDescription.Text == String.Empty)
                //{
                //    string script = "alert(\"Please select Description,Please Retry!\");"; ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
                //}
                else
                {
                    if (ddlCompany.SelectedIndex == 0)
                    {
                        string cmdstr = "select count(*) from Company_Registration where Company_name='" + txtcompany_name.Text + "' ";
                        con.Open();
                        SqlCommand cmd2 = new SqlCommand(cmdstr, con);
                        int count2 = (int)cmd2.ExecuteScalar();
                        con.Close();
                        if (count2 == 0)
                        {
                            Company_id();
                            bel.bel_Company_id = txtcompany_id.Text;
                            bel.bel_Company_name = txtcompany_name.Text;
                            bel.bel_Contact_person = txtperson.Text;
                            bel.bel_Designation = txtDesignation.Text;
                            bel.bel_Mobile_no = txtContactNo.Text;
                            bel.bel_office_no = txtofc_no.Text;
                            bel.bel_email_id = txtcompany_email.Text;
                            bel.bel_website = txtcweb.Text;
                            bel.bel_addressline = txtc_address.Text;
                            bel.bel_company_type = txtc_type.Text;
                            bel.bel_service_type = txtc_services.Text;
                            bel.bel_service_domain = txtcdomain_services.Text;
                            bel.bel_Description = txtDescription.Text;
                            bel.bel_Registration_date = DateTime.Now.ToString("dd/MM/yyyy");


                            int retVal = bal.Add_Company(bel);

                            if (retVal > 0)
                            {
                                clear();
                                string script = "alert(\" Company Registration successfully !\");"; ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
                            }
                            else
                            {
                                string script = "alert(\"Company Registration  details couldn't be Saved, PLease Retry!\");"; ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
                            }
                        }
                        else
                        {
                            string script = "alert(\"Company Name Already Existing, PLease Enter New Company Name!\");"; ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
                        }
                    }
                    else
                    {
                        bel.bel_Company_id = txtcompany_id.Text;
                        bel.bel_Company_name = txtcompany_name.Text;
                        bel.bel_Contact_person = txtperson.Text;
                        bel.bel_Designation = txtDesignation.Text;
                        bel.bel_Mobile_no = txtContactNo.Text;
                        bel.bel_office_no = txtofc_no.Text;
                        bel.bel_email_id = txtcompany_email.Text;
                        bel.bel_website = txtcweb.Text;
                        bel.bel_addressline = txtc_address.Text;
                        bel.bel_company_type = txtc_type.Text;
                        bel.bel_service_type = txtc_services.Text;
                        bel.bel_service_domain = txtcdomain_services.Text;
                        bel.bel_Description = txtDescription.Text;

                        int retVal = bal.Update_Company(bel);


                        if (retVal > 0)
                        {
                            clear();
                            string script = "alert(\"Update Company Registration successfully !\");"; ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
                        }
                        else
                        {
                            string script = "alert(\"Company Registration  details couldn't be Update, PLease Retry!\");"; ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
                        }
                    }
                }
            }

            catch (Exception ex)
            {
                Response.Write("Oops! error occured :" + ex.Message.ToString());
            }
            finally
            {
                bel = null;
                bal = null;
                con.Close();
            }
        }
        protected void bind_profile()
        {
            try
            {
                SqlCommand cmd = new SqlCommand("Institute_Details", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@flag", 3);
                DataSet ds = new DataSet();
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                sda.Fill(ds);
                if (ds.Tables[0].Rows.Count > 0)
                {
                    txtc_name = ds.Tables[0].Rows[0][2].ToString();
                    rxrc_contact = ds.Tables[0].Rows[0][3].ToString();
                    txtc_email = ds.Tables[0].Rows[0][4].ToString();
                    txtc_web = ds.Tables[0].Rows[0][5].ToString();
                    txtc_add1 = ds.Tables[0].Rows[0][6].ToString();
                    txtc_add2 = ds.Tables[0].Rows[0][7].ToString();
                    txtc_pin = ds.Tables[0].Rows[0][8].ToString();
                    email_from = ds.Tables[0].Rows[0][9].ToString();
                    email_pwd = ds.Tables[0].Rows[0][10].ToString();
                }
            }
            catch (Exception ex)
            {
                Response.Write("Oops! error occured :" + ex.Message.ToString());
            }
        }
        public void send_mail()
        {

            try
            {
                if (txtcompany_email.Text != "" && email_from != "")
                {
                    //if not, replace it with correct index
                    //code to send email
                    //reciever email add
                    MailAddress to = new MailAddress(txtcompany_email.Text);
                    //sender email address
                    MailAddress from = new MailAddress(email_from);

                    MailMessage msg = new MailMessage();
                    //use reason shown in grid
                    msg.Subject = "Company Registration mail @ " + txtc_name;

                    //you can similar extract FName, LName, Account number from grid
                    // and use it in your message body
                    //Keep your message body like 

                    string email_msg = "Dear Mr/Ms " + txtcompany_name.Text + ", \n\n \n\t" + "Over the coming days weeks and months we want to make you feel as Superior Customer Service " + "\n" + "at" + txtc_name + ", So please take advantage of some of our fantastic services,especially" + "\n" + "during the initial stages of your membership!" + "\n\n\t" + "We really hope that you'll stay with us for long time, so don't be shy in lettingus know" + "\n" + "As always, if you have questions, please feel free to Contact Us. We are happy to help!" + "\n" + "experiance with us" + "\n\n\n\n" + "Yours sincerely ," + "\n" + txtc_name + ", \n" + txtc_add1 + " " + txtc_add2 + "\n" + " Contact Number : " + rxrc_contact + ".\n\n Email ID: " + txtc_email + ".\n\n Website: " + txtc_web + ".";
                    msg.Body = email_msg;
                    msg.From = from;
                    msg.To.Add(to);

                    SendEMail(msg);
                }
            }
            catch (Exception ex)
            {
                Response.Write("Oops! error occured :" + ex.Message.ToString());
            }
        }
        private void SendEMail(MailMessage mail)
        {
            SmtpClient client = new SmtpClient();
            client.Host = "smtp.gmail.com";
            client.Port = 587;
            client.EnableSsl = true;
            client.Credentials = new System.Net.NetworkCredential(email_from, email_pwd);
            client.DeliveryMethod = SmtpDeliveryMethod.Network;
            try
            {
                client.Send(mail);
            }
            catch (Exception ex)
            {
                Console.WriteLine("{0} Exception caught.", ex);
            }
        }
        protected void send_SMS()
        {
            if (txtperson.Text != "")
            {
                string Number = txtperson.Text;
                string mesage = HttpUtility.UrlEncode("Company Registration @ " + txtc_name + "\n Website: " + txtc_web);
                string url = "http://sms.squarevisiontech.com/app/smsapi/index.php?key=45B3E075155572&campaign=13330&routeid=20&type=text&contacts=" + Number + "&senderid=SPSRPS&msg=" + mesage;
                WebRequest request = WebRequest.Create(url);
                //WebRequest request = WebRequest.Create("http://bulksms.aphronsoftware.com?username=spsschool&pass=admin&senderid=SCHOOL&dest_mobileno=" + Number + "&message=" + mesage + "&response=Y");
                WebResponse webResp = request.GetResponse();
            }
        }
        protected void clear()
        {
            try
            {
                Company_id();
                txtcompany_id.Text = "";
                txtcompany_name.Text = "";
                txtperson.Text = "";
                txtDesignation.Text = "";
                txtContactNo.Text = "";
                txtofc_no.Text = "";
                txtcompany_email.Text = "";
                txtcweb.Text = "";
                txtc_address.Text = "";
                txtc_type.Text = "";
                txtc_services.Text = "";
                txtcdomain_services.Text = "";
                txtDescription.Text = "";
                bind_All_Company(); 
            }
            catch (Exception ex)
            {
                Response.Write("Oops! error occured :" + ex.Message.ToString());
            }

        }
    }
}