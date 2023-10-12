using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Net;
using System.IO;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Net.Mail;
using System.Net.Mime;
using System.Text;
using System.Web.Security;
using BAL;
using BEL;
namespace TrainingAndPlacement
{
    public partial class login : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["myConnectionString"].ConnectionString);
        SqlCommand cmd = new SqlCommand();
        string email, pwd, contcts, email_from, email_pwd, sms_id, sms_pwd, userid, passwords, pack_id, Membership_id, txtc_name, rxrc_contact, txtc_email, txtc_web, txtc_add1, txtc_add2, txtc_pin;
        
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                FormsAuthentication.SignOut();

                HttpCookie cookie = Request.Cookies["LoginTime"];
                HttpCookie cookie1 = Request.Cookies["user_id"];
                if (cookie != null)
                {

                    if (!string.IsNullOrEmpty(cookie.Values["UserType"]))
                    {
                        if (cookie.Values["UserType"].ToString() == "Principal")
                        {
                            Session["User"] = "Principal";
                            Session["login_id"] = cookie1.Values["Userid"].ToString();         // pass login ID
                            Response.Redirect("~/Principal_Home.aspx");
                        }
                        else if (cookie.Values["UserType"].ToString() == "Admin")
                        {
                            Session["User"] = "Admin";
                            Session["login_id"] = cookie1.Values["Userid"].ToString();         // pass login ID
                            Response.Redirect("~/Admin_Home.aspx");
                        }
                        else if (cookie.Values["UserType"].ToString() == "HOD")
                        {
                            Session["User"] = "HOD";
                            Session["login_id"] = cookie1.Values["Userid"].ToString();         // pass login ID
                            Response.Redirect("~/HOD_Home.aspx");
                        }
                        else if (cookie.Values["UserType"].ToString() == "Coordinator")
                        {
                            Session["User"] = "Coordinator";
                            Session["login_id"] = cookie1.Values["Userid"].ToString();         // pass login ID
                            Response.Redirect("~/Coordinator_Home.aspx");
                        }
                        else if (cookie.Values["UserType"].ToString() == "Company")
                        {
                            Session["User"] = "Company";
                            Session["login_id"] = cookie1.Values["Userid"].ToString();        // pass login ID
                            Response.Redirect("~/Company_Profile.aspx");
                        }
                        else if (cookie.Values["UserType"].ToString() == "Student")
                        {
                            Session["User"] = "Student";
                            Session["login_id"] = cookie1.Values["Userid"].ToString();         // pass login ID
                            Response.Redirect("~/Student_Home.aspx");
                        }
                        else
                        {
                            Response.Redirect("~/login.aspx");
                        }
                    }

                }
                //else
                //{
                //    Response.Redirect("login.aspx");
                //}

            }
        }
        protected void btnlogin_Click(object sender, EventArgs e)
        {
            if (Authenticateuser(username.Text, password.Text))
            {
                SqlDataAdapter da = new SqlDataAdapter("Select * from Placement_Login where username='" + username.Text + "' and login_password='" + password.Text + "'", con);
                DataSet ds = new DataSet();
                HttpCookie cookie = new HttpCookie("LoginTime");
                HttpCookie cookie1 = new HttpCookie("user_id");
                da.Fill(ds);
                cookie1.Values.Add("Userid", username.Text);
                // cookie["LoginTime"] = "Teacher";
                cookie1.Expires = DateTime.Now.AddDays(365);
                Response.Cookies.Add(cookie1);
                //.  string role = ds.Tables[0].Rows[0][2].ToString();
                if (ds.Tables[0].Rows[0][2].ToString() == "Principal" && ds.Tables[0].Rows[0][3].ToString() == "Active")
                {
                    Session["User"] = "Principal";
                    cookie.Values.Add("UserType", "Principal");
                    // cookie["LoginTime"] = "Admin";
                    cookie.Expires = DateTime.Now.AddDays(365);
                    Response.Cookies.Add(cookie);
                    Session["login_id"] = cookie1.Values["Userid"].ToString();        // pass login ID
                    Response.Redirect("~/Principal_Home.aspx");
                }
                else if (ds.Tables[0].Rows[0][2].ToString() == "Admin" && ds.Tables[0].Rows[0][3].ToString() == "Active")
                {
                    Session["User"] = "Admin";
                    cookie.Values.Add("UserType", "Admin");
                    // cookie["LoginTime"] = "Admin";
                    cookie.Expires = DateTime.Now.AddDays(365);
                    Response.Cookies.Add(cookie);
                    Session["login_id"] = cookie1.Values["Userid"].ToString();        // pass login ID
                    Response.Redirect("~/Admin_Home.aspx");
                }
                else if (ds.Tables[0].Rows[0][2].ToString() == "HOD" && ds.Tables[0].Rows[0][3].ToString() == "Active")
                {
                    Session["User"] = "HOD";
                    cookie.Values.Add("UserType", "HOD");
                    // cookie["LoginTime"] = "Teacher";
                    cookie.Expires = DateTime.Now.AddDays(365);
                    Response.Cookies.Add(cookie);

                    Session["login_id"] = cookie1.Values["Userid"].ToString();        // pass login ID
                    Response.Redirect("~/HOD_Home.aspx");
                }
                else if (ds.Tables[0].Rows[0][2].ToString() == "Coordinator" && ds.Tables[0].Rows[0][3].ToString() == "Active")
                {
                    Session["User"] = "Coordinator";
                    cookie.Values.Add("UserType", "Coordinator");
                    // cookie["LoginTime"] = "Teacher";
                    cookie.Expires = DateTime.Now.AddDays(365);
                    Response.Cookies.Add(cookie);

                    Session["login_id"] = cookie1.Values["Userid"].ToString();        // pass login ID
                    Response.Redirect("~/Coordinator_Home.aspx");
                }
                else if (ds.Tables[0].Rows[0][2].ToString() == "Company" && ds.Tables[0].Rows[0][3].ToString() == "Active")
                {
                    Session["User"] = "Company";
                    cookie.Values.Add("UserType", "Company");
                    // cookie["LoginTime"] = "Teacher";
                    cookie.Expires = DateTime.Now.AddDays(365);
                    Response.Cookies.Add(cookie);

                    Session["login_id"] = cookie1.Values["Userid"].ToString();        // pass login ID
                    Response.Redirect("~/Company_Profile.aspx");
                }
                else if (ds.Tables[0].Rows[0][2].ToString() == "Student" && ds.Tables[0].Rows[0][3].ToString() == "Active")
                {
                    Session["User"] = "Student";
                    cookie.Values.Add("UserType", "Student");
                    // cookie["LoginTime"] = "Student";
                    cookie.Expires = DateTime.Now.AddDays(365);
                    Response.Cookies.Add(cookie);

                    Session["login_id"] = cookie1.Values["Userid"].ToString();        // pass login ID
                    Session["Student_Id"] = cookie1.Values["Userid"].ToString();        // pass login ID
                    Response.Redirect("~/Student_Home.aspx");
                }
                else
                {
                    Label1.Text = "Account is not activated yet. Please contact Administartor for more details..!";
                    Session["User"] = null;
                }
            }
            else
            {
                Label1.Text = "Username and/or password is incorrect.";
                Session["User"] = null;
            }
        }

        private bool Authenticateuser(string username, string password)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("user_login", con);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter paramusername = new SqlParameter("@username", username);
                SqlParameter parampassword = new SqlParameter("@password", password);

                cmd.Parameters.Add(paramusername);
                cmd.Parameters.Add(parampassword);
                con.Open();
                int returncode = (int)cmd.ExecuteScalar();


                return returncode == 1;
                con.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        protected void btnfogot_request_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtforgot.Text == "")
                {
                    txterror.Text = "Please Enter User Name";
                }
                else
                {
                    con.Open();
                    string str = "Select count(*) from Placement_Login where username='" + txtforgot.Text + "'";
                    cmd = new SqlCommand(str, con);
                    int count = (int)cmd.ExecuteScalar();
                    con.Close();
                    if (count > 0)
                    {
                        bind_profile();
                        txterror.Text = "";
                        SqlDataAdapter sda = new SqlDataAdapter("Select * from Placement_Login where username='" + txtforgot.Text + "'", con);
                        DataSet ds = new DataSet();
                        sda.Fill(ds);
                        if (ds.Tables[0].Rows[0][2].ToString() == "Principal")
                        {
                            SqlDataAdapter da = new SqlDataAdapter("Select * from emp_regi where emp_id='" + txtforgot.Text + "'", con);
                            DataSet ds1 = new DataSet();
                            da.Fill(ds1);
                            pwd = ds.Tables[0].Rows[0][1].ToString();
                            email = ds1.Tables[0].Rows[0][15].ToString();
                            contcts = ds1.Tables[0].Rows[0][13].ToString();
                        }
                        else if (ds.Tables[0].Rows[0][2].ToString() == "Admin")
                        {
                            SqlDataAdapter da = new SqlDataAdapter("Select * from emp_regi where emp_id='" + txtforgot.Text + "'", con);
                            DataSet ds1 = new DataSet();
                            da.Fill(ds1);
                            pwd = ds.Tables[0].Rows[0][1].ToString();
                            email = ds1.Tables[0].Rows[0][15].ToString();
                            contcts = ds1.Tables[0].Rows[0][13].ToString();
                        }
                        else if (ds.Tables[0].Rows[0][2].ToString() == "HOD")
                        {
                            SqlDataAdapter da = new SqlDataAdapter("Select * from emp_regi where emp_id='" + txtforgot.Text + "'", con);
                            DataSet ds1 = new DataSet();
                            da.Fill(ds1);
                            pwd = ds.Tables[0].Rows[0][1].ToString();
                            email = ds1.Tables[0].Rows[0][15].ToString();
                            contcts = ds1.Tables[0].Rows[0][13].ToString();
                        }
                        else if (ds.Tables[0].Rows[0][2].ToString() == "Coordinator")
                        {
                            SqlDataAdapter da = new SqlDataAdapter("Select * from emp_regi where emp_id='" + txtforgot.Text + "'", con);
                            DataSet ds1 = new DataSet();
                            da.Fill(ds1);
                            pwd = ds.Tables[0].Rows[0][1].ToString();
                            email = ds1.Tables[0].Rows[0][15].ToString();
                            contcts = ds1.Tables[0].Rows[0][13].ToString();
                        }
                        else if (ds.Tables[0].Rows[0][2].ToString() == "Student")
                        {
                            SqlDataAdapter da = new SqlDataAdapter("Select * from Student_Registration where id='" + txtforgot.Text + "'", con);
                            DataSet ds1 = new DataSet();
                            da.Fill(ds1);
                            pwd = ds.Tables[0].Rows[0][1].ToString();
                            email = ds1.Tables[0].Rows[0][8].ToString();
                            contcts = ds1.Tables[0].Rows[0][9].ToString();
                        }
                        else if (ds.Tables[0].Rows[0][2].ToString() == "Company")
                        {
                            SqlDataAdapter da = new SqlDataAdapter("Select * from Company_Registration where Company_id='" + txtforgot.Text + "'", con);
                            DataSet ds1 = new DataSet();
                            da.Fill(ds1);
                            pwd = ds.Tables[0].Rows[0][1].ToString();
                            email = ds1.Tables[0].Rows[0][15].ToString();
                            contcts = ds1.Tables[0].Rows[0][13].ToString();
                        }
                        else
                        {
                            txterror.Text = "Username is incorrect";
                        }
                        //Email Send
                        if (email != "" && email_from != "")
                        {
                            MailAddress to = new MailAddress(email);
                            //sender email address
                            MailAddress from = new MailAddress(email_from);

                            MailMessage msg = new MailMessage();
                            //use reason shown in grid
                            msg.Subject = txtc_name + " @Login Details";

                            //you can similar extract FName, LName, Account number from grid
                            // and use it in your message body
                            //Keep your message body like 

                            string email_msg = "Dear User, \n\t We are happy that you have Chosen " + txtc_name + " to put across your views.  Please find your login credentials below. \n User name: " + txtforgot.Text + ". \n >Password: " + pwd + ".\n \n\t  We are technology driven company providing the best platform to those who are genuinely looking for their Genius Student." + "\n\n\t" + "Over the coming days weeks and months we want to make you feel as Superior Customer Service " + "\n" + "at" + txtc_name + ", So please take advantage of some of our fantastic services,especially" + "\n" + "during the initial stages of your membership!" + "\n\n\t" + "We really hope that you'll stay with us for long time, so don't be shy in lettingus know" + "\n" + "As always, if you have questions, please feel free to Contact Us. We are happy to help!" + "\n" + "experiance with us" + "\n\n\n\n" + "Yours sincerely ," + "\n" + txtc_name + ", \n" + txtc_add1 + " " + txtc_add2 + "\n" + " Contact Number : " + rxrc_contact + ".\n\n Email ID: " + txtc_email + ".\n\n Website: " + txtc_web + ".";
                            msg.Body = email_msg;
                            msg.From = from;
                            msg.To.Add(to);

                            SendEMail(msg);
                            txtforgot.Text = "";
                            Response.Write("<script LANGUEGE='Javascript'>alert(' Password Send on Registed Email Id')</script>");
                        }

                        //SMS Send
                        if (contcts != "")
                        {
                            string Number = contcts;
                            string mesage = "Student Login @ " + txtc_name + "\n User name:  " + txtforgot.Text + "\n Password: " + pwd + "Website: " + txtc_web;
                            string url = "http://sms.squarevisiontech.com/app/smsapi/index.php?key=45B3E075155572&campaign=13330&routeid=20&type=text&contacts=" + Number + "&senderid=SPSRPS&msg=" + mesage;
                            WebRequest request = WebRequest.Create(url);
                            //WebRequest request = WebRequest.Create("http://bulksms.aphronsoftware.com?username=spsschool&pass=admin&senderid=SCHOOL&dest_mobileno=" + Number + "&message=" + mesage + "&response=Y");
                            WebResponse webResp = request.GetResponse();
                        }
                    }
                    else
                    {
                        txterror.Text = "Username is incorrect";
                    }
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

            try
            {
                client.Send(mail);
            }
            catch (Exception ex)
            {
                Console.WriteLine("{0} Exception caught.", ex);
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
    }
}