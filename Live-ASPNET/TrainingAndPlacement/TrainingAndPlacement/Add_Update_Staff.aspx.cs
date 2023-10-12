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
    public partial class Add_Update_Staff : System.Web.UI.Page
    {
        string gender;
        SqlConnection con = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["myConnectionString"].ConnectionString);
        bal_emp_regi bal_er = new bal_emp_regi();
        bel_emp_regi bel_er = new bel_emp_regi();
        bel_login login = new bel_login();
        bal_login bal_login = new bal_login();
        bal_Dept bal = new bal_Dept();
        bal_Institute bal_cp = new bal_Institute();
        bel_Institute bel_cp = new bel_Institute();
        string userid, passwords, name, contact, email, web, add1, add2, city, District, pin, sendmail, sendmailpwd, smtp, port, link, smsid, smspass;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["login_id"] != null)
            {
                bind_profile();
                // userid = Session["login_id"].ToString();

                if (!Page.IsPostBack)
                {
                    bind_Department();
                    Radionew.Checked = true;
                    ID.Enabled = false;
                    Radioemail.Checked = true;
                    all_Registration();
                }
            }
            else
            {
                logout();
            }
        }
        protected void all_Registration()
        {
            try
            {
                con.Open();
                SqlCommand cmd1 = new SqlCommand("staff_add_update", con);
                cmd1.CommandType = CommandType.StoredProcedure;
                cmd1.Parameters.AddWithValue("@flag", 3);
                DataSet ds = new DataSet();
                SqlDataAdapter adp = new SqlDataAdapter(cmd1);
                adp.Fill(ds);
                gvsearch_name.DataSource = ds;
                gvsearch_name.DataBind();
            }
            catch (Exception ex)
            {
                Response.Write("Oops! error occured :" + ex.Message.ToString());
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
        public static string password(int PasswordLength)
        {
            string _allowedChars = "0123456789abcdefghijkmnopqrstuvwxyzABCDEFGHJKLMNOPQRSTUVWXYZ";
            Random randNum = new Random();
            char[] chars = new char[PasswordLength];
            int allowedCharCount = _allowedChars.Length;
            for (int i = 0; i < PasswordLength; i++)
            {
                chars[i] = _allowedChars[(int)((_allowedChars.Length) * randNum.NextDouble())];
            }
            return new string(chars);
        }
        protected void Radionew_CheckedChanged(object sender, EventArgs e)
        {
            // trainer_id();
            clear();
            ID.Enabled = false;
        }
        protected void Radiold_CheckedChanged(object sender, EventArgs e)
        {
            ID.Enabled = true;
        }
        protected void tbnclear_Click(object sender, EventArgs e)
        {
            clear();
        }

        protected void insert()
        {
            try
            {
                
                        passwords = password(8);
                        if (RadiomaleC.Checked)
                            gender = RadiomaleC.Text;
                        else
                            gender = RadiofemaleC.Text;

                        bel_er.bel_emp_id = txtC_emp_id.Text.Trim();
                        bel_er.bel_fnm = Fname.Text.Trim();
                        bel_er.bel_mnm = Mname.Text.Trim();
                        bel_er.bel_lnm = Lname.Text.Trim();
                        bel_er.bel_id_proof = ddlIdCardTypeC.SelectedItem.Text;
                        bel_er.bel_id_no = txtcardnoC.Text.Trim();
                        bel_er.bel_gender = gender;
                        bel_er.bel_dob = txtC_dob.Text;
                        bel_er.bel_address = txtC_address.Text.Trim();
                        bel_er.bel_city = txtC_City.Text.Trim();
                        bel_er.bel_state = txtC_state.Text.Trim();
                        bel_er.bel_pin = txtC_Pincode.Text.Trim();
                        bel_er.bel_contact = txtC_contact.Text.Trim();
                        bel_er.bel_alt_contact_no = txtC_alt.Text.Trim();
                        bel_er.bel_email = txtC_email.Text.Trim();
                        bel_er.bel_Department = ddlDepartment.SelectedValue;
                        bel_er.bel_Designation = ddlDesignation.SelectedItem.Text;
                        bel_er.bel_status = "Active";
                        bel_er.bel_Joining_Date = DateTime.Now.ToString("dd/MM/yyyy");

                        int retVal = bal_er.emp_regi(bel_er);
                        login_insert();
                        if (retVal <= 0)
                        {
                            string script = "alert(\"Staff Details couldn't be Saved!\");"; ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
                        }
                    
            }
            catch (Exception ex)
            {
                Response.Write("Oops! error occured :" + ex.Message.ToString());
            }
        }

        protected void emp_update()
        {
            try
            {
                string gender;
                if (RadiomaleC.Checked)
                    gender = RadiomaleC.Text;
                else
                    gender = RadiofemaleC.Text;

                bel_er.bel_emp_id = txtC_emp_id.Text.Trim();
                bel_er.bel_fnm = Fname.Text.Trim();
                bel_er.bel_mnm = Mname.Text.Trim();
                bel_er.bel_lnm = Lname.Text.Trim();
                bel_er.bel_id_proof = ddlIdCardTypeC.SelectedItem.Text;
                bel_er.bel_id_no = txtcardnoC.Text.Trim();
                bel_er.bel_gender = gender;
                bel_er.bel_dob = txtC_dob.Text;
                bel_er.bel_address = txtC_address.Text.Trim();
                bel_er.bel_city = txtC_City.Text.Trim();
                bel_er.bel_state = txtC_state.Text.Trim();
                bel_er.bel_pin = txtC_Pincode.Text.Trim();
                bel_er.bel_contact = txtC_contact.Text.Trim();
                bel_er.bel_alt_contact_no = txtC_alt.Text.Trim();
                bel_er.bel_email = txtC_email.Text.Trim();
                bel_er.bel_Department = ddlDepartment.SelectedValue;
                bel_er.bel_Designation = ddlDesignation.SelectedItem.Text;
                bel_er.bel_status = "Active";

                int retVal = bal_er.emp_update(bel_er);
                if (retVal <= 0)
                {
                    string script = "alert(\"Staff Details couldn't be updated!\");"; ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
                }
            }
            catch (Exception ex)
            {
                Response.Write("Oops! error occured :" + ex.Message.ToString());
            }
            finally
            {
                bal_er = null;
                bel_er = null;
            }

        }
        protected void login_insert()
        {

            try
            {
                login.bel_username = txtC_email.Text.Trim();
                login.bel_password = passwords;
                login.bel_role = ddlDesignation.SelectedValue;
                login.bel_status = "Active";

                int retVal = bal_login.login_insert(login);
            }
            catch (Exception ex)
            {
                Response.Write("Oops! error occured :" + ex.Message.ToString());
            }
        }
        protected void bind_profile()
        {
            try
            {
                DataSet ds = new DataSet();
                ds = bal_cp.select(bel_cp);
                if (ds.Tables[0].Rows.Count > 0)
                {
                    name = ds.Tables[0].Rows[0][1].ToString();
                    contact = ds.Tables[0].Rows[0][2].ToString();
                    email = ds.Tables[0].Rows[0][3].ToString();
                    web = ds.Tables[0].Rows[0][4].ToString();
                    add1 = ds.Tables[0].Rows[0][5].ToString();
                    add2 = ds.Tables[0].Rows[0][6].ToString();
                    city = ds.Tables[0].Rows[0][7].ToString();
                    District = ds.Tables[0].Rows[0][8].ToString();
                    pin = ds.Tables[0].Rows[0][9].ToString();
                    sendmail = ds.Tables[0].Rows[0][10].ToString();
                    sendmailpwd = ds.Tables[0].Rows[0][11].ToString();
                    smtp = ds.Tables[0].Rows[0][12].ToString();
                    port = ds.Tables[0].Rows[0][13].ToString();
                    link = ds.Tables[0].Rows[0][14].ToString();
                    smsid = ds.Tables[0].Rows[0][15].ToString();
                    smspass = ds.Tables[0].Rows[0][16].ToString();
                }
            }
            catch (Exception ex)
            {
                Response.Write("Oops! error occured :" + ex.Message.ToString());
            }
        }
        protected void send_SMS()
        {
            if (txtC_contact.Text != "")
            {
                string Number = txtC_contact.Text;
                string mesage = HttpUtility.UrlEncode(ddlDesignation.SelectedItem.Text + " " + " Registration @ " + Fname.Text + " " + Lname.Text + "\n User name:  " + txtC_email.Text + "\n Password: " + passwords + "\n Website: " + web);
                //string url = "http://bulksms.aphronsoftware.com/sendSMS?username=spsschool&message=" + mesage + "&sendername=SPSRPS&smstype=TRANS&numbers=" + txtmobile.Text + "&apikey=82c2b442-efbf-4884-b7f3-39f5645419bd";
                string url = "http://sms.bulksmsind.in/sendSMS?username=spsschool&message=" + mesage + "&sendername=SPSRPS&smstype=TRANS&numbers=" + Number + "&apikey=82c2b442-efbf-4884-b7f3-39f5645419bd";
                WebRequest request = WebRequest.Create(url);
                //WebRequest request = WebRequest.Create("http://bulksms.aphronsoftware.com?username=spsschool&pass=admin&senderid=SCHOOL&dest_mobileno=" + Number + "&message=" + mesage + "&response=Y");
                WebResponse webResp = request.GetResponse();
            }

        }
        public void send_mail()
        {
            try
            {
                if (txtC_email.Text != "" && sendmail != "")
                {
                    //if not, replace it with correct index
                    //email = item.Cells[4].Text;
                    //code to send email
                    //reciever email add
                    //email += item.Cells[4].Text;
                    MailAddress to = new MailAddress(txtC_email.Text);
                    //sender email address
                    MailAddress from = new MailAddress(sendmail);

                    MailMessage msg = new MailMessage();
                    //use reason shown in grid
                    msg.Subject = ddlDesignation.SelectedItem.Text + " " + " Registration mail @ " + name;

                    //you can similar extract FName, LName, Account number from grid
                    // and use it in your message body
                    //Keep your message body like 

                    string email_msg = "Dear Mr/Ms \t" + Fname.Text + " " + Lname.Text + " , \n\n Please find your login credentials below. We would suggest you to change your password after first time login. \n\n User Name :" + txtC_email.Text + "\n\n Password :" + passwords + ".\n \n\t  We are technology driven company providing the best platform to those who are genuinely looking for their Genius Student." + "\n\n\t" + "Over the coming days weeks and months we want to make you feel as Superior Customer Service " + "\n" + "at" + name + ", So please take advantage of some of our fantastic services,especially" + "\n" + "during the initial stages of your membership!" + "\n\n\t" + "We really hope that you'll stay with us for long time, so don't be shy in lettingus know" + "\n" + "As always, if you have questions, please feel free to Contact Us. We are happy to help!" + "\n" + "experiance with us" + "\n\n\n\n" + "Yours sincerely ," + "\n" + name + ", \n" + add1 + " " + add2 + "\n" + " Contact Number : " + contact + ".\n\n Email ID: " + email + ".\n\n Website: " + web + ".";

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
            client.Host = smtp;
            client.Port = Convert.ToInt32(port);
            client.EnableSsl = true;
            client.Credentials = new System.Net.NetworkCredential(sendmail, sendmailpwd);
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
        protected void clear()
        {
            try
            {
                Fname.Text = "";
                Mname.Text = "";
                Lname.Text = "";
                ddlDepartment.SelectedIndex = -1;
                txtcardnoC.Text = "";
                RadiomaleC.Checked = true;
                RadiofemaleC.Checked = false;
                txtC_dob.Text = "";
                txtC_contact.Text = "";
                txtC_alt.Text = "";
                txtC_email.Text = "";
                txtC_City.Text = "";
                txtC_state.Text = "";
                txtC_Pincode.Text = "";
                txtC_address.Text = "";

            }
            catch (Exception ex)
            {
                Response.Write("Oops! error occured :" + ex.Message.ToString());
            }

        }

        protected void logout()
        {
            Session.Abandon();
            Session.Clear();
            Session.RemoveAll();
            //Response.Redirect("~/login.aspx");
            //FormsAuthentication.SignOut();
            //Response.Redirect("~/login.aspx");
            if (Request.Cookies["LoginTime"] != null)
            {
                HttpCookie cookie = new HttpCookie("User");

                Response.Cookies.Add(cookie);
                Response.Cookies["LoginTime"].Expires = DateTime.Now.AddDays(-1d);
            }
            Response.Redirect("~/login.aspx");
        }


        protected void search_Click(object sender, EventArgs e)
        {
            search();
        }
        protected void gvsearch_name_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtC_emp_id.Text = gvsearch_name.SelectedRow.Cells[1].Text;
            Radiold.Checked = true;
            ID.Enabled = true;
            txtC_emp_id.Enabled = true;
            Radioemail.Checked = false;
            search();
        }
        protected void search()
        {
            DataSet ds = new DataSet();
            try
            {
                bel_er.bel_emp_id = txtC_emp_id.Text;
                ds = bal_er.bind_ID_wise(bel_er);

                if (ds.Tables[0].Rows.Count > 0)
                {
                    //bel_er.DataSource = ds;
                    //grdBookDetails.DataBind();

                    //  bal_er.emp_select(bel_er);


                    Fname.Text = ds.Tables[0].Rows[0][1].ToString();
                    Mname.Text = ds.Tables[0].Rows[0][2].ToString();
                    Lname.Text = ds.Tables[0].Rows[0][3].ToString();
                    ddlIdCardTypeC.Text = ds.Tables[0].Rows[0][4].ToString();
                    txtcardnoC.Text = ds.Tables[0].Rows[0][5].ToString();
                    gender = ds.Tables[0].Rows[0][6].ToString();
                    txtC_dob.Text = ds.Tables[0].Rows[0][7].ToString();
                    if (txtC_dob.Text != "")
                    {
                        txtC_dob.Text = Convert.ToDateTime(txtC_dob.Text).ToString("dd/MM/yyyy");
                    }
                    txtC_address.Text = ds.Tables[0].Rows[0][8].ToString();
                    txtC_City.Text = ds.Tables[0].Rows[0][9].ToString();
                    txtC_state.Text = ds.Tables[0].Rows[0][10].ToString();
                    txtC_Pincode.Text = ds.Tables[0].Rows[0][11].ToString();
                    txtC_contact.Text = ds.Tables[0].Rows[0][12].ToString();
                    txtC_alt.Text = ds.Tables[0].Rows[0][13].ToString();
                    txtC_email.Text = ds.Tables[0].Rows[0][14].ToString();
                    ddlDepartment.SelectedValue = ds.Tables[0].Rows[0][16].ToString();
                    ddlDesignation.SelectedValue = ds.Tables[0].Rows[0][17].ToString();

                    if (gender == "Male")
                    {
                        RadiofemaleC.Checked = false;
                        RadiomaleC.Checked = true;
                    }
                    else if (gender == "Female")
                    {
                        RadiomaleC.Checked = false;
                        RadiofemaleC.Checked = true;
                    }

                }
                else
                {
                    string script = "alert(\"Staff Id Not Found In Database!\");"; ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
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
                if (ddlDepartment.SelectedIndex == 0)
                {
                    string script = "alert(\"Please Select Department!\");"; ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
                }
                else if (ddlDesignation.SelectedIndex == 0)
                {
                    string script = "alert(\"Please Select Designation!\");"; ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
                }
                else
                {
                    passwords = password(8);
                    if (RadiomaleC.Checked)
                        gender = RadiomaleC.Text;
                    else
                        gender = RadiofemaleC.Text;

                    bel_er.bel_emp_id = txtC_emp_id.Text.Trim();
                    bel_er.bel_fnm = Fname.Text.Trim();
                    bel_er.bel_mnm = Mname.Text.Trim();
                    bel_er.bel_lnm = Lname.Text.Trim();
                    bel_er.bel_id_proof = ddlIdCardTypeC.SelectedItem.Text;
                    bel_er.bel_id_no = txtcardnoC.Text.Trim();
                    bel_er.bel_gender = gender;
                    bel_er.bel_dob = txtC_dob.Text;
                    bel_er.bel_address = txtC_address.Text.Trim();
                    bel_er.bel_city = txtC_City.Text.Trim();
                    bel_er.bel_state = txtC_state.Text.Trim();
                    bel_er.bel_pin = txtC_Pincode.Text.Trim();
                    bel_er.bel_contact = txtC_contact.Text.Trim();
                    bel_er.bel_alt_contact_no = txtC_alt.Text.Trim();
                    bel_er.bel_email = txtC_email.Text.Trim();
                    bel_er.bel_Department = ddlDepartment.SelectedValue;
                    bel_er.bel_Designation = ddlDesignation.SelectedItem.Text;
                    bel_er.bel_status = "Active";
                    bel_er.bel_Joining_Date = DateTime.Now.ToString("dd/MM/yyyy");

                    if (Radionew.Checked == true)
                    {
                        string cmdstr = "select count(*) from emp_regi where email='" + txtC_email.Text + "' ";
                        con.Open();
                        SqlCommand cmd = new SqlCommand(cmdstr, con);
                        int count = (int)cmd.ExecuteScalar();
                        con.Close();
                        if (count == 0)
                        {
                            string cmdstr1 = "select count(*) from Placement_Login where username='" + txtC_email.Text + "' ";
                            con.Open();
                            SqlCommand cmd1 = new SqlCommand(cmdstr1, con);
                            int count1 = (int)cmd1.ExecuteScalar();
                            con.Close();
                            if (count1 == 0)
                            {
                                int retVal = bal_er.emp_regi(bel_er);
                                if (retVal > 0)
                                {
                                    login_insert();
                                    if (Radiosms.Checked == true)
                                    {
                                        //insert();
                                        send_SMS();                                     // Send SMS
                                        string script = "alert(\"Staff Registration Successfully!\");"; ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
                                        clear();
                                    }
                                    else if (Radioemail.Checked == true)
                                    {
                                        //insert();
                                        send_mail();                                   // Send Mail
                                        string script = "alert(\"Staff Registration Successfully!\");"; ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
                                        clear();
                                    }
                                    else if (Radioboth.Checked == true)
                                    {
                                        //insert();
                                        send_SMS();                                     // Send SMS
                                        send_mail();                                   // Send Mail
                                        string script = "alert(\"Staff Registration Successfully!\");"; ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
                                        clear();
                                    }
                                    else
                                    {
                                        string script = "alert(\"Please Select Send Option!\");"; ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
                                    }
                                }
                            }
                            else
                            {
                                string script = "alert(\"Staff Email Id Already Existing, PLease Enter New Email Id!\");"; ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
                            }
                        }
                        else
                        {
                            string script = "alert(\"Staff Email Id Already Existing, PLease Enter New Email Id!\");"; ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
                        }
                    }
                    else if (Radiold.Checked == true)
                    {
                        int retVal = bal_er.emp_update(bel_er);
                        if (retVal > 0)
                        {
                            if (Radiosms.Checked == true)
                            {
                                //emp_update();
                                send_SMS();                                     // Send SMS
                                string script = "alert(\" Staff Successfully Updated!\");"; ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
                                clear();
                            }
                            else if (Radioemail.Checked == true)
                            {
                                //emp_update();
                                send_mail();                                   // Send Mail
                                string script = "alert(\"Staff Successfully Updated!\");"; ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
                                clear();
                            }
                            else if (Radioboth.Checked == true)
                            {
                                //emp_update();
                                send_SMS();                                     // Send SMS
                                send_mail();                                   // Send Mail
                                string script = "alert(\"Staff Update Successfully!\");"; ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
                                clear();
                            }
                            else
                            {
                                string script = "alert(\"Please Select Send Option!\");"; ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
                            }
                        }
                    }
                    else
                    {
                        string script = "alert(\"Please Select New / Update option!\");"; ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
                    }
                    Radionew.Checked = true;
                    all_Registration();
                }
            }

            catch (Exception ex)
            {
                Response.Write("Oops! error occured :" + ex.Message.ToString());
            }
            finally
            {
                bal_er = null;
                bel_er = null;
            }
        }
    }
}