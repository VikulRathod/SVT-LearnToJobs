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
    public class dal_emp_regi
    {
        SqlConnection con = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["myConnectionString"].ConnectionString);
        SqlCommand cmd = new SqlCommand();
        SqlDataAdapter da = new SqlDataAdapter();
        public int add_emp(bel_emp_regi bel)
        {
            int result;
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("staff_add_update", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@flag", 1);
                cmd.Parameters.AddWithValue("@fnm", bel.bel_fnm);
                cmd.Parameters.AddWithValue("@mnm", bel.bel_mnm);
                cmd.Parameters.AddWithValue("@lnm", bel.bel_lnm);
                cmd.Parameters.AddWithValue("@id_proof", bel.bel_id_proof);
                cmd.Parameters.AddWithValue("@id_no", bel.bel_id_no);
                cmd.Parameters.AddWithValue("@gender", bel.bel_gender);
                cmd.Parameters.AddWithValue("@dob", bel.bel_dob);
                cmd.Parameters.AddWithValue("@address", bel.bel_address);
                cmd.Parameters.AddWithValue("@city", bel.bel_city);
                cmd.Parameters.AddWithValue("@state", bel.bel_state);
                cmd.Parameters.AddWithValue("@pin", bel.bel_pin);
                cmd.Parameters.AddWithValue("@contact", bel.bel_contact);
                cmd.Parameters.AddWithValue("@alt_contact_no", bel.bel_alt_contact_no);
                cmd.Parameters.AddWithValue("@email", bel.bel_email);
                cmd.Parameters.AddWithValue("@status", bel.bel_status);
                cmd.Parameters.AddWithValue("@Designation", bel.bel_Designation);
                cmd.Parameters.AddWithValue("@Department", bel.bel_Department);
                cmd.Parameters.AddWithValue("@Joining_Date", bel.bel_Joining_Date);
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
        public int update_emp(bel_emp_regi bel)
        {
            int result;
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("staff_add_update", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@flag", 2);
                cmd.Parameters.AddWithValue("@emp_id", bel.bel_emp_id);
                cmd.Parameters.AddWithValue("@fnm", bel.bel_fnm);
                cmd.Parameters.AddWithValue("@mnm", bel.bel_mnm);
                cmd.Parameters.AddWithValue("@lnm", bel.bel_lnm);
                cmd.Parameters.AddWithValue("@id_proof", bel.bel_id_proof);
                cmd.Parameters.AddWithValue("@id_no", bel.bel_id_no);
                cmd.Parameters.AddWithValue("@gender", bel.bel_gender);
                cmd.Parameters.AddWithValue("@dob", bel.bel_dob);
                cmd.Parameters.AddWithValue("@address", bel.bel_address);
                cmd.Parameters.AddWithValue("@city", bel.bel_city);
                cmd.Parameters.AddWithValue("@state", bel.bel_state);
                cmd.Parameters.AddWithValue("@pin", bel.bel_pin);
                cmd.Parameters.AddWithValue("@contact", bel.bel_contact);
                cmd.Parameters.AddWithValue("@alt_contact_no", bel.bel_alt_contact_no);
                cmd.Parameters.AddWithValue("@email", bel.bel_email);
                cmd.Parameters.AddWithValue("@status", bel.bel_status);
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
        public DataSet Select_AllStaff()
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
        public DataSet bind_ID_wise(bel_emp_regi bel)
        {

            try
            {

                con.Open();
                SqlCommand cmd1 = new SqlCommand("staff_add_update", con);
                cmd1.CommandType = CommandType.StoredProcedure;
                cmd1.Parameters.AddWithValue("@emp_id", bel.bel_emp_id);
                cmd1.Parameters.AddWithValue("@flag", 4);
                DataSet ds = new DataSet();
                SqlDataAdapter adp = new SqlDataAdapter(cmd1);
                adp.Fill(ds);
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
        public DataSet Bind_Email_Id_Wise(bel_emp_regi bel)
        {

            try
            {

                con.Open();
                SqlCommand cmd1 = new SqlCommand("staff_add_update", con);
                cmd1.CommandType = CommandType.StoredProcedure;
                cmd1.Parameters.AddWithValue("@email", bel.bel_email);
                cmd1.Parameters.AddWithValue("@flag", 7);
                DataSet ds = new DataSet();
                SqlDataAdapter adp = new SqlDataAdapter(cmd1);
                adp.Fill(ds);
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
        public DataSet DesignationWise_Staff(bel_emp_regi bel)
        {

            try
            {

                con.Open();
                SqlCommand cmd1 = new SqlCommand("staff_add_update", con);
                cmd1.CommandType = CommandType.StoredProcedure;
                cmd1.Parameters.AddWithValue("@flag", 8);
                cmd1.Parameters.AddWithValue("@Designation", bel.bel_Designation);

                DataSet ds = new DataSet();
                SqlDataAdapter adp = new SqlDataAdapter(cmd1);
                adp.Fill(ds);
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
