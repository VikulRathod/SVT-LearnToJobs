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
    public class dal_login
    {
        SqlConnection con = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["myConnectionString"].ConnectionString);
        SqlCommand cmd;
        public int login_insert(bel_login bel)
        {
            try
            {
                int result;
                con.Open();
                SqlCommand cmd = new SqlCommand("Login_Details", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@flag", 1);
                cmd.Parameters.AddWithValue("@username", bel.bel_username);
                cmd.Parameters.AddWithValue("@password", bel.bel_password);
                cmd.Parameters.AddWithValue("@role", bel.bel_role);
                cmd.Parameters.AddWithValue("@status", bel.bel_status);

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
        public int login_update(bel_login bel)
        {
            try
            {
                int result;
                con.Open();
                SqlCommand cmd = new SqlCommand("Login_Details", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@flag", 2);
                cmd.Parameters.AddWithValue("@username", bel.bel_username);
                cmd.Parameters.AddWithValue("@password", bel.bel_password);
                cmd.Parameters.AddWithValue("@old_pswd", bel.bel_old);
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
        public int login_status_update(bel_login bel)
        {
            try
            {
                int result;
                con.Open();
                SqlCommand cmd = new SqlCommand("Login_Details", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@flag", 4);
                cmd.Parameters.AddWithValue("@username", bel.bel_username);
                cmd.Parameters.AddWithValue("@status", bel.bel_status);
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
        public DataSet select_All(bel_login bel)
        {

            try
            {
                con.Open();
                cmd = new SqlCommand("Login_Details", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@flag", 5);
                DataSet ds = new DataSet();
                SqlDataAdapter adp1 = new SqlDataAdapter(cmd);
                adp1.Fill(ds);

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
        public DataSet select_user(bel_login bel)
        {

            try
            {
                con.Open();
                cmd = new SqlCommand("Login_Details", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@flag", 6);
                cmd.Parameters.AddWithValue("@username", bel.bel_username);
                DataSet ds = new DataSet();
                SqlDataAdapter adp1 = new SqlDataAdapter(cmd);
                adp1.Fill(ds);

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
        public DataSet select_AllStaff(bel_login bel)
        {

            try
            {
                con.Open();
                cmd = new SqlCommand("Login_Details", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@flag", 7);
                DataSet ds = new DataSet();
                SqlDataAdapter adp1 = new SqlDataAdapter(cmd);
                adp1.Fill(ds);

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


        public DataSet select_Staff(bel_login bel)
        {

            try
            {
                con.Open();
                cmd = new SqlCommand("Login_Details", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@flag", 8);
                cmd.Parameters.AddWithValue("@username", bel.bel_username);
                DataSet ds = new DataSet();
                SqlDataAdapter adp1 = new SqlDataAdapter(cmd);
                adp1.Fill(ds);

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
