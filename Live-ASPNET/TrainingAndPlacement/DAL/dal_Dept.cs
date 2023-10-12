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
   public class dal_Dept
    {
       bel_Dept bel = new bel_Dept();
        SqlConnection con = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["myConnectionString"].ConnectionString);
        SqlCommand cmd;
        SqlDataAdapter da;

        public int add_Department(bel_Dept bel)
        {
            int result;
            try
            {
                con.Open();
                cmd = new SqlCommand("Department_Details", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@flag", 1);
                cmd.Parameters.AddWithValue("@Department", bel.bel_Department);
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
        public int update_Department(bel_Dept bel)
        {
            int result;
            try
            {
                con.Open();
                cmd = new SqlCommand("Department_Details ", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@flag", 2);
                cmd.Parameters.AddWithValue("@Id", bel.bel_Id);
                cmd.Parameters.AddWithValue("@Department", bel.bel_Department);
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

        public DataSet gvDepartment_Bind()
        {
            SqlCommand cmd = new SqlCommand("Department_Details", con);
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
        public DataSet SelectByID(bel_Dept bel)
        {
            SqlCommand cmd = new SqlCommand("Department_Details", con);
            try
            {
                con.Open();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@flag", 4);
                cmd.Parameters.AddWithValue("@Id", bel.bel_Id);
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
        public DataSet Delete_Department(bel_Dept bel)
        {
            SqlCommand cmd = new SqlCommand("Department_Details", con);
            try
            {
                con.Open();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@flag", 5);
                cmd.Parameters.AddWithValue("@Id", bel.bel_Id);
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
