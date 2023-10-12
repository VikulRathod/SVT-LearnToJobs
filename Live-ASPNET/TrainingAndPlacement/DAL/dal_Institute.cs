using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using BEL;
using System.Configuration;
namespace DAL
{
    public class dal_Institute
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myConnectionString"].ConnectionString);
        SqlCommand cmd = new SqlCommand();
        public int add_Institute_prof(bel_Institute bel)
        {
            int count;
            int result;
            con.Open();
            cmd = new SqlCommand("Institute_Details", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@flag", 4);
            count = (int)cmd.ExecuteScalar();
            con.Close();
            if (count <= 0)
            {
                try
                {
                    con.Open();
                    cmd = new SqlCommand("Institute_Details", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@flag", 1);
                    cmd.Parameters.AddWithValue("@Institute_name", bel.bel_Institute_name);
                    cmd.Parameters.AddWithValue("@contact_no", bel.bel_contact_no);
                    cmd.Parameters.AddWithValue("@email_id", bel.bel_email_id);
                    cmd.Parameters.AddWithValue("@website", bel.bel_website);
                    cmd.Parameters.AddWithValue("@addressline1", bel.bel_addressline1);
                    cmd.Parameters.AddWithValue("@addressline2", bel.bel_addressline2);
                    cmd.Parameters.AddWithValue("@town", bel.bel_town);
                    cmd.Parameters.AddWithValue("@district", bel.bel_district);
                    cmd.Parameters.AddWithValue("@post_code", bel.bel_post_code);
                    cmd.Parameters.AddWithValue("@mail_Email_id", bel.bel_mail_Email_id);
                    cmd.Parameters.AddWithValue("@mail_password", bel.bel_mail_password);
                    cmd.Parameters.AddWithValue("@smtp", bel.bel_smtp);
                    cmd.Parameters.AddWithValue("@port", bel.bel_port);
                    cmd.Parameters.AddWithValue("@link", bel.bel_link);
                    cmd.Parameters.AddWithValue("@smsid", bel.bel_smsid);
                    cmd.Parameters.AddWithValue("@smspass", bel.bel_smspass);

                    if (con.State == ConnectionState.Closed)
                    {
                        con.Open();
                    }

                    result = cmd.ExecuteNonQuery();
                    cmd.Dispose();

                    if (result > 0)
                    {
                        return result;
                    }
                    else
                    {
                        return 0;
                    }
                }


                catch (Exception ex)
                {
                    throw ex;
                }
                finally
                {
                    con.Close();
                }
            }
            else
            {

                try
                {
                    con.Open();
                    cmd = new SqlCommand("Institute_Details", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@flag", 2);
                    cmd.Parameters.AddWithValue("@Institute_name", bel.bel_Institute_name);
                    cmd.Parameters.AddWithValue("@contact_no", bel.bel_contact_no);
                    cmd.Parameters.AddWithValue("@email_id", bel.bel_email_id);
                    cmd.Parameters.AddWithValue("@website", bel.bel_website);
                    cmd.Parameters.AddWithValue("@addressline1", bel.bel_addressline1);
                    cmd.Parameters.AddWithValue("@addressline2", bel.bel_addressline2);
                    cmd.Parameters.AddWithValue("@town", bel.bel_town);
                    cmd.Parameters.AddWithValue("@district", bel.bel_district);
                    cmd.Parameters.AddWithValue("@post_code", bel.bel_post_code);
                    cmd.Parameters.AddWithValue("@mail_Email_id", bel.bel_mail_Email_id);
                    cmd.Parameters.AddWithValue("@mail_password", bel.bel_mail_password);
                    cmd.Parameters.AddWithValue("@smtp", bel.bel_smtp);
                    cmd.Parameters.AddWithValue("@port", bel.bel_port);
                    cmd.Parameters.AddWithValue("@link", bel.bel_link);
                    cmd.Parameters.AddWithValue("@smsid", bel.bel_smsid);
                    cmd.Parameters.AddWithValue("@smspass", bel.bel_smspass);

                    if (con.State == ConnectionState.Closed)
                    {
                        con.Open();
                    }

                    result = cmd.ExecuteNonQuery();
                    cmd.Dispose();

                    if (result > 0)
                    {
                        return result;
                    }
                    else
                    {
                        return 0;
                    }
                }


                catch (Exception ex)
                {
                    throw ex;
                }
                finally
                {
                    con.Close();
                }
            }
        }
        public DataSet select(bel_Institute bel_cp)
        {
            SqlCommand cmd = new SqlCommand("Institute_Details", con);
            try
            {
                con.Open();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@flag", 3);
                DataSet ds = new DataSet();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(ds);
                return ds;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                con.Close();
            }

        }
    }
}
