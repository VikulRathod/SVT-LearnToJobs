using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using BEL;
namespace DAL
{
    public class dal_message
    {
        SqlConnection con = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["myConnectionString"].ConnectionString);


        public int add_event(bel_message bel)
        {
            int result;
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("message_details", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@flag", 1);
                cmd.Parameters.AddWithValue("@subject", bel.bel_esub);
                cmd.Parameters.AddWithValue("@body", bel.bel_ebody);


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
        public DataSet bind_grid() //select all
        {
            try
            {
                SqlCommand cmd = new SqlCommand("message_details", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@flag", 2);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataSet dt = new DataSet();
                sda.Fill(dt);

                return dt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataTable bind_grid_members() //select all Members
        {
            try
            {
                SqlCommand cmd1 = new SqlCommand("Search_Student_details", con);
                con.Open();
                cmd1.CommandType = CommandType.StoredProcedure;
                cmd1.Parameters.AddWithValue("@flag", 6);
                DataTable d1 = new DataTable();
                SqlDataAdapter sd1 = new SqlDataAdapter(cmd1);
                sd1.Fill(d1);
                return (d1);
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
        public DataTable bind_grid_trainners() //select all trainners
        {
            try
            {
                SqlCommand cmd1 = new SqlCommand("staff_details", con);
                con.Open();
                cmd1.CommandType = CommandType.StoredProcedure;
                cmd1.Parameters.AddWithValue("@flag", 1);
                DataTable d1 = new DataTable();
                SqlDataAdapter sd1 = new SqlDataAdapter(cmd1);
                sd1.Fill(d1);
                return (d1);
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

        public DataTable bind_ddlevent()// binding ddl event
        {
            try
            {
                SqlCommand cmd = new SqlCommand("message_details", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@flag", 2);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
                return ds.Tables[0];
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataSet GetElement(bel_message bel_msg) //retrive and show data in subject and body by ddl change
        {
            try
            {
                SqlCommand cmd = new SqlCommand("message_details", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@flag", 3);
                cmd.Parameters.AddWithValue("@id", bel_msg.bel_eid);

                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataSet dt = new DataSet();
                sda.Fill(dt);

                return dt;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public DataTable binggrid_byempid(bel_message bel_msg) //retrive and show data in subject and body by ddl change
        {
            SqlCommand cmd = new SqlCommand("staff_details", con);
            try
            {
                con.Open();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("id", bel_msg.bel_empid);
                cmd.Parameters.AddWithValue("@flag", 2);
                DataTable ds = new DataTable();
                SqlDataAdapter adp1 = new SqlDataAdapter(cmd);
                adp1.Fill(ds);

                return (ds);

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
        public DataTable gridbind_bymemid(bel_message bel_msg)
        {
            SqlCommand cmd = new SqlCommand("Search_Student_details", con);
            try
            {
                con.Open();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", bel_msg.bel_memid);
                cmd.Parameters.AddWithValue("@flag", 2);
                DataTable ds = new DataTable();
                SqlDataAdapter adp1 = new SqlDataAdapter(cmd);
                adp1.Fill(ds);

                return (ds);

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
        public DataTable gridbind_bymemclass(bel_message bel_msg)
        {
            SqlCommand cmd = new SqlCommand("Search_Student_details", con);
            try
            {
                con.Open();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Class", bel_msg.bel_memclass);
                cmd.Parameters.AddWithValue("@flag", 9);
                DataTable ds = new DataTable();
                SqlDataAdapter adp1 = new SqlDataAdapter(cmd);
                adp1.Fill(ds);

                return (ds);

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
        public DataTable gridbind_bymemHouse_Colour(bel_message bel_msg)
        {
            SqlCommand cmd = new SqlCommand("Search_Student_details", con);
            try
            {
                con.Open();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@House_Colour", bel_msg.bel_memhouse);
                cmd.Parameters.AddWithValue("@flag", 10);
                DataTable ds = new DataTable();
                SqlDataAdapter adp1 = new SqlDataAdapter(cmd);
                adp1.Fill(ds);

                return (ds);

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
        public DataTable bind_Regi_Renewal_members() //select all Members
        {
            try
            {
                SqlCommand cmd1 = new SqlCommand("Search_Student_details", con);
                con.Open();
                cmd1.CommandType = CommandType.StoredProcedure;
                cmd1.Parameters.AddWithValue("@flag", 11);
                DataTable d1 = new DataTable();
                SqlDataAdapter sd1 = new SqlDataAdapter(cmd1);
                sd1.Fill(d1);
                return (d1);
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
        public DataTable gridbind_bymemclass_colour(bel_message bel_msg)
        {
            SqlCommand cmd = new SqlCommand("Search_Student_details", con);
            try
            {
                con.Open();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Class", bel_msg.bel_memclass);
                cmd.Parameters.AddWithValue("@House_Colour", bel_msg.bel_memhouse);
                cmd.Parameters.AddWithValue("@flag", 12);
                DataTable ds = new DataTable();
                SqlDataAdapter adp1 = new SqlDataAdapter(cmd);
                adp1.Fill(ds);

                return (ds);

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

        public int Insert_Notification(bel_message bel_msg)
        {
            int result;
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("Send_Notification_Details", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@flag", 1);
                cmd.Parameters.AddWithValue("@Login_id", bel_msg.bel_empid);
                cmd.Parameters.AddWithValue("@Subject_Type", bel_msg.bel_Send_Type);
                cmd.Parameters.AddWithValue("@Message", bel_msg.bel_Message);
                cmd.Parameters.AddWithValue("@Contact_No", bel_msg.bel_Contact_No);
                cmd.Parameters.AddWithValue("@Email_Id", bel_msg.bel_Email_Id);
                cmd.Parameters.AddWithValue("@SMS_Send_Date", bel_msg.bel_SMS_Send_Date);
                cmd.Parameters.AddWithValue("@Send_Type", bel_msg.bel_Send_Type);


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
}
