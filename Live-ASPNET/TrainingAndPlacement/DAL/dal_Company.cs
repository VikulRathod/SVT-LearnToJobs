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
    public class dal_Company
    {
        SqlConnection con = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["myConnectionString"].ConnectionString);
        SqlCommand cmd;
        SqlDataAdapter da;

        public int Add_Company(bel_Company bel)
        {
            int result;
            try
            {
                con.Open();
                cmd = new SqlCommand("Company_Details", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@flag", 1);
                cmd.Parameters.AddWithValue("@Company_id", bel.bel_Company_id);
                cmd.Parameters.AddWithValue("@Company_name", bel.bel_Company_name);
                cmd.Parameters.AddWithValue("@Contact_person", bel.bel_Contact_person);
                cmd.Parameters.AddWithValue("@Designation", bel.bel_Designation);
                cmd.Parameters.AddWithValue("@Mobile_no", bel.bel_Mobile_no);
                cmd.Parameters.AddWithValue("@office_no", bel.bel_office_no);
                cmd.Parameters.AddWithValue("@email_id", bel.bel_email_id);
                cmd.Parameters.AddWithValue("@website", bel.bel_website);
                cmd.Parameters.AddWithValue("@addressline", bel.bel_addressline);
                cmd.Parameters.AddWithValue("@company_type", bel.bel_service_type);
                cmd.Parameters.AddWithValue("@service_type", bel.bel_service_domain);
                cmd.Parameters.AddWithValue("@service_domain", bel.bel_service_domain);
                cmd.Parameters.AddWithValue("@Description", bel.bel_Description);
                cmd.Parameters.AddWithValue("@Registration_date", bel.bel_Registration_date);


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
        public int Update_Company(bel_Company bel)
        {
            int result;
            try
            {
                con.Open();
                cmd = new SqlCommand("Company_Details", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@flag", 2);
                cmd.Parameters.AddWithValue("@Company_id", bel.bel_Company_id);
                cmd.Parameters.AddWithValue("@Company_name", bel.bel_Company_name);
                cmd.Parameters.AddWithValue("@Contact_person", bel.bel_Contact_person);
                cmd.Parameters.AddWithValue("@Designation", bel.bel_Designation);
                cmd.Parameters.AddWithValue("@Mobile_no", bel.bel_Mobile_no);
                cmd.Parameters.AddWithValue("@office_no", bel.bel_office_no);
                cmd.Parameters.AddWithValue("@email_id", bel.bel_email_id);
                cmd.Parameters.AddWithValue("@website", bel.bel_website);
                cmd.Parameters.AddWithValue("@addressline", bel.bel_addressline);
                cmd.Parameters.AddWithValue("@company_type", bel.bel_service_type);
                cmd.Parameters.AddWithValue("@service_domain", bel.bel_service_domain);
                cmd.Parameters.AddWithValue("@Description", bel.bel_Description);

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
        public DataSet Select_Add_Update_Company(bel_Company bel)
        {
            try
            {
                con.Open();
                cmd = new SqlCommand("Company_Details", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@flag", 4);
                cmd.Parameters.AddWithValue("@Company_id", bel.bel_Company_id);

                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataSet dt = new DataSet();
                sda.Fill(dt);
                return dt;

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
        public DataSet bind_All_Company(bel_Company bel)
        {

            try
            {

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

                return dt;

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
        public DataSet ddlCompany_SelectedIndexChanged(bel_Company bel)
        {

            try
            {

                cmd = new SqlCommand("Company_Details", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@flag", 5);
                cmd.Parameters.AddWithValue("@Company_name", bel.bel_Company_name);


                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataSet dt = new DataSet();
                sda.Fill(dt);

                return dt;

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
        public DataSet Select_rptCompany_Registration(bel_Company bel)
        {
            try
            {
                con.Open();
                cmd = new SqlCommand("Company_Details", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@flag", 6);
                cmd.Parameters.AddWithValue("@start_date", bel.bel_start_date);
                cmd.Parameters.AddWithValue("@end_date", bel.bel_end_date);

                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataSet dt = new DataSet();
                sda.Fill(dt);
                return dt;

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
