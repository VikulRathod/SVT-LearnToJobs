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
    public class dal_Drive
    {
        bel_Derive bel = new bel_Derive();
        SqlConnection con = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["myConnectionString"].ConnectionString);
        SqlCommand cmd;
        SqlDataAdapter da;

        public int add_Drive(bel_Derive bel)
        {
            int result;
            try
            {
                con.Open();
                cmd = new SqlCommand("SP_Add_Update_Drive", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@flag", 1);
                cmd.Parameters.AddWithValue("@Academic_Year", bel.bel_Academic_Year);
                cmd.Parameters.AddWithValue("@Company_ID", bel.bel_Company_ID);
                cmd.Parameters.AddWithValue("@Company_name", bel.bel_Company_name);
                cmd.Parameters.AddWithValue("@Drive_Title", bel.bel_Drive_Title);
                cmd.Parameters.AddWithValue("@Post_Opened", bel.bel_Post_Opened);
                cmd.Parameters.AddWithValue("@Job_Type", bel.bel_Job_Type);
                cmd.Parameters.AddWithValue("@Job_Profile", bel.bel_Job_Profile);
                cmd.Parameters.AddWithValue("@Salary", bel.bel_Salary);
                cmd.Parameters.AddWithValue("@Vacancies", bel.bel_Vacancies);
                cmd.Parameters.AddWithValue("@Bond", bel.bel_Bond);
                cmd.Parameters.AddWithValue("@Bond_Duration", bel.bel_Bond_Duration);
                cmd.Parameters.AddWithValue("@Bond_Amount", bel.bel_Bond_Amount);
                cmd.Parameters.AddWithValue("@Bond_Terms", bel.bel_Bond_Terms);
                cmd.Parameters.AddWithValue("@Security_Deposite", bel.bel_Security_Deposite);
                cmd.Parameters.AddWithValue("@Joining_Date", bel.bel_Joining_Date);
                cmd.Parameters.AddWithValue("@Gender_Allowed", bel.bel_Gender_Allowed);
                cmd.Parameters.AddWithValue("@Recruitment_Method", bel.bel_Recruitment_Method);
                cmd.Parameters.AddWithValue("@Job_Location", bel.bel_Job_Location);
                cmd.Parameters.AddWithValue("@Reg_From_Date", bel.bel_Reg_From_Date);
                cmd.Parameters.AddWithValue("@Reg_To_Date", bel.bel_Reg_To_Date);
                cmd.Parameters.AddWithValue("@Doc_Needed", bel.bel_Doc_Needed);
                cmd.Parameters.AddWithValue("@Remark", bel.bel_Remark);
                cmd.Parameters.AddWithValue("@Company_Coordinator", bel.bel_Company_Coordinator);
                cmd.Parameters.AddWithValue("@Company_Designation", bel.bel_Company_Designation);
                cmd.Parameters.AddWithValue("@Company_Contact", bel.bel_Company_Contact);
                cmd.Parameters.AddWithValue("@Institute_Coordinator", bel.bel_Institute_Coordinator);
                cmd.Parameters.AddWithValue("@Institute_Designation", bel.bel_Institute_Designation);
                cmd.Parameters.AddWithValue("@Institute_Contact", bel.bel_Institute_Contact);
                cmd.Parameters.AddWithValue("@Courses", bel.bel_Courses);
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

        public int update_Drive(bel_Derive bel)
        {
            int result;
            try
            {
                con.Open();
                cmd = new SqlCommand("SP_Add_Update_Drive", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@flag", 2);
                cmd.Parameters.AddWithValue("@Drive_Id", bel.bel_id);
                cmd.Parameters.AddWithValue("@Academic_Year", bel.bel_Academic_Year);
                cmd.Parameters.AddWithValue("@Company_ID", bel.bel_Company_ID);
                cmd.Parameters.AddWithValue("@Company_name", bel.bel_Company_name);
                cmd.Parameters.AddWithValue("@Drive_Title", bel.bel_Drive_Title);
                cmd.Parameters.AddWithValue("@Post_Opened", bel.bel_Post_Opened);
                cmd.Parameters.AddWithValue("@Job_Type", bel.bel_Job_Type);
                cmd.Parameters.AddWithValue("@Job_Profile", bel.bel_Job_Profile);
                cmd.Parameters.AddWithValue("@Salary", bel.bel_Salary);
                cmd.Parameters.AddWithValue("@Vacancies", bel.bel_Vacancies);
                cmd.Parameters.AddWithValue("@Bond", bel.bel_Bond);
                cmd.Parameters.AddWithValue("@Bond_Duration", bel.bel_Bond_Duration);
                cmd.Parameters.AddWithValue("@Bond_Amount", bel.bel_Bond_Amount);
                cmd.Parameters.AddWithValue("@Bond_Terms", bel.bel_Bond_Terms);
                cmd.Parameters.AddWithValue("@Security_Deposite", bel.bel_Security_Deposite);
                cmd.Parameters.AddWithValue("@Joining_Date", bel.bel_Joining_Date);
                cmd.Parameters.AddWithValue("@Gender_Allowed", bel.bel_Gender_Allowed);
                cmd.Parameters.AddWithValue("@Recruitment_Method", bel.bel_Recruitment_Method);
                cmd.Parameters.AddWithValue("@Job_Location", bel.bel_Job_Location);
                cmd.Parameters.AddWithValue("@Reg_From_Date", bel.bel_Reg_From_Date);
                cmd.Parameters.AddWithValue("@Reg_To_Date", bel.bel_Reg_To_Date);
                cmd.Parameters.AddWithValue("@Doc_Needed", bel.bel_Doc_Needed);
                cmd.Parameters.AddWithValue("@Remark", bel.bel_Remark);
                cmd.Parameters.AddWithValue("@Company_Coordinator", bel.bel_Company_Coordinator);
                cmd.Parameters.AddWithValue("@Company_Designation", bel.bel_Company_Designation);
                cmd.Parameters.AddWithValue("@Company_Contact", bel.bel_Company_Contact);
                cmd.Parameters.AddWithValue("@Institute_Coordinator", bel.bel_Institute_Coordinator);
                cmd.Parameters.AddWithValue("@Institute_Designation", bel.bel_Institute_Designation);
                cmd.Parameters.AddWithValue("@Institute_Contact", bel.bel_Institute_Contact);
                //cmd.Parameters.AddWithValue("@Courses", bel.bel_Courses);
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
        public int update_Status(bel_Derive bel)
        {
            int result;
            try
            {
                con.Open();
                cmd = new SqlCommand("SP_Add_Update_Drive ", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@flag", 6);
                cmd.Parameters.AddWithValue("@Academic_Year", bel.bel_Academic_Year);
                cmd.Parameters.AddWithValue("@Company_ID", bel.bel_Company_ID);
                cmd.Parameters.AddWithValue("@Drive_Id", bel.bel_id);
                cmd.Parameters.AddWithValue("@Status", bel.bel_Status);
                

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
        public DataTable Place_Drive()
        {
            SqlCommand cmd = new SqlCommand("SP_Add_Update_Drive", con);
            try
            {
                con.Open();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@flag", 7);
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
        //-------Add_Drive_Criteria----------------//

        public int Add_Drive_Criteria(bel_Student bel_stu)
        {
            int result;
            try
            {
                con.Open();
                cmd = new SqlCommand("Sp_Set_Drive_Criteria", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@flag", 1);
                cmd.Parameters.AddWithValue("@Academic_Year", bel_stu.bel_Academic_Year);
                cmd.Parameters.AddWithValue("@Company_ID", bel_stu.bel_Company_ID);
                cmd.Parameters.AddWithValue("@Drive_Id", bel_stu.bel_Drive_Id);
                cmd.Parameters.AddWithValue("@SSC_Percentage", bel_stu.bel_SSC_Percentage);
                cmd.Parameters.AddWithValue("@Year1_Percentage", bel_stu.bel_Year1_Percentage);
                cmd.Parameters.AddWithValue("@Year1_SGPA", bel_stu.bel_Year1_SGPA);
                cmd.Parameters.AddWithValue("@SSC_Passed_Year", bel_stu.bel_SSC_Passed_Year);
                cmd.Parameters.AddWithValue("@Year2_Percentage", bel_stu.bel_Year2_Percentage);
                cmd.Parameters.AddWithValue("@Year2_SGPA", bel_stu.bel_Year2_SGPA);
                cmd.Parameters.AddWithValue("@HSC_Percentage", bel_stu.bel_HSC_Percentage);
                cmd.Parameters.AddWithValue("@Year3_Percentage", bel_stu.bel_Year3_Percentage);
                cmd.Parameters.AddWithValue("@Year3_SGPA", bel_stu.bel_Year3_SGPA);
                cmd.Parameters.AddWithValue("@HSC_Passed_Year", bel_stu.bel_HSC_Passed_Year);
                cmd.Parameters.AddWithValue("@Year4_Percentage", bel_stu.bel_Year4_Percentage);
                cmd.Parameters.AddWithValue("@Year4_SGPA", bel_stu.bel_Year4_SGPA);
                cmd.Parameters.AddWithValue("@Diploma_Percentage", bel_stu.bel_Diploma_Percentage);
                cmd.Parameters.AddWithValue("@Year5_Percentage", bel_stu.bel_Year5_Percentage);
                cmd.Parameters.AddWithValue("@Year5_SGPA", bel_stu.bel_Year5_SGPA);
                cmd.Parameters.AddWithValue("@Diploma_Passed_Year", bel_stu.bel_Diploma_Passed_Year);
                cmd.Parameters.AddWithValue("@Sem1_Percentage", bel_stu.bel_Sem1_Percentage);
                cmd.Parameters.AddWithValue("@Sem1_SGPA", bel_stu.bel_Sem1_SGPA);
                cmd.Parameters.AddWithValue("@UG_Percentage", bel_stu.bel_UG_Percentage);
                cmd.Parameters.AddWithValue("@Sem2_Percentage", bel_stu.bel_Sem2_Percentage);
                cmd.Parameters.AddWithValue("@Sem2_SGPA", bel_stu.bel_Sem2_SGPA);
                cmd.Parameters.AddWithValue("@UG_Passed_Year", bel_stu.bel_UG_Passed_Year);
                cmd.Parameters.AddWithValue("@Sem3_Percentage", bel_stu.bel_Sem3_Percentage);
                cmd.Parameters.AddWithValue("@Sem3_SGPA", bel_stu.bel_Sem3_SGPA);
                cmd.Parameters.AddWithValue("@PG_Percentage", bel_stu.bel_PG_Percentage);
                cmd.Parameters.AddWithValue("@Sem4_Percentage", bel_stu.bel_Sem4_Percentage);
                cmd.Parameters.AddWithValue("@Sem4_SGPA", bel_stu.bel_Sem4_SGPA);
                cmd.Parameters.AddWithValue("@PG_Passed_Year", bel_stu.bel_PG_Passed_Year);
                cmd.Parameters.AddWithValue("@Sem5_Percentage", bel_stu.bel_Sem5_Percentage);
                cmd.Parameters.AddWithValue("@Sem5_SGPA", bel_stu.bel_Sem5_SGPA);
                cmd.Parameters.AddWithValue("@Gap_Year", bel_stu.bel_Gap_Year);
                cmd.Parameters.AddWithValue("@Sem6_Percentage", bel_stu.bel_Sem6_Percentage);
                cmd.Parameters.AddWithValue("@Sem6_SGPA", bel_stu.bel_Sem6_SGPA);
                cmd.Parameters.AddWithValue("@Live_Backlogs", bel_stu.bel_Live_Backlogs);
                cmd.Parameters.AddWithValue("@Sem7_Percentage", bel_stu.bel_Sem7_Percentage);
                cmd.Parameters.AddWithValue("@Sem7_SGPA", bel_stu.bel_Sem7_SGPA);
                cmd.Parameters.AddWithValue("@Dead_Backlogs", bel_stu.bel_Dead_Backlogs);
                cmd.Parameters.AddWithValue("@Sem8_Percentage", bel_stu.bel_Sem8_Percentage);
                cmd.Parameters.AddWithValue("@Sem8_SGPA", bel_stu.bel_Sem8_SGPA);
                cmd.Parameters.AddWithValue("@Experience", bel_stu.bel_Experience);
                cmd.Parameters.AddWithValue("@Entrance_Score", bel_stu.bel_Entrance_Score);
                cmd.Parameters.AddWithValue("@Aggregate", bel_stu.bel_Aggregate);

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
        public int Update_Drive_Criteria(bel_Student bel_stu)
        {
            int result;
            try
            {
                con.Open();
                cmd = new SqlCommand("Sp_Set_Drive_Criteria", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@flag", 2);
                cmd.Parameters.AddWithValue("@Academic_Year", bel_stu.bel_Academic_Year);
                cmd.Parameters.AddWithValue("@Company_ID", bel_stu.bel_Company_ID);
                cmd.Parameters.AddWithValue("@Drive_Id", bel_stu.bel_Drive_Id);
                cmd.Parameters.AddWithValue("@SSC_Percentage", bel_stu.bel_SSC_Percentage);
                cmd.Parameters.AddWithValue("@Year1_Percentage", bel_stu.bel_Year1_Percentage);
                cmd.Parameters.AddWithValue("@Year1_SGPA", bel_stu.bel_Year1_SGPA);
                cmd.Parameters.AddWithValue("@SSC_Passed_Year", bel_stu.bel_SSC_Passed_Year);
                cmd.Parameters.AddWithValue("@Year2_Percentage", bel_stu.bel_Year2_Percentage);
                cmd.Parameters.AddWithValue("@Year2_SGPA", bel_stu.bel_Year2_SGPA);
                cmd.Parameters.AddWithValue("@HSC_Percentage", bel_stu.bel_HSC_Percentage);
                cmd.Parameters.AddWithValue("@Year3_Percentage", bel_stu.bel_Year3_Percentage);
                cmd.Parameters.AddWithValue("@Year3_SGPA", bel_stu.bel_Year3_SGPA);
                cmd.Parameters.AddWithValue("@HSC_Passed_Year", bel_stu.bel_HSC_Passed_Year);
                cmd.Parameters.AddWithValue("@Year4_Percentage", bel_stu.bel_Year4_Percentage);
                cmd.Parameters.AddWithValue("@Year4_SGPA", bel_stu.bel_Year4_SGPA);
                cmd.Parameters.AddWithValue("@Diploma_Percentage", bel_stu.bel_Diploma_Percentage);
                cmd.Parameters.AddWithValue("@Year5_Percentage", bel_stu.bel_Year5_Percentage);
                cmd.Parameters.AddWithValue("@Year5_SGPA", bel_stu.bel_Year5_SGPA);
                cmd.Parameters.AddWithValue("@Diploma_Passed_Year", bel_stu.bel_Diploma_Passed_Year);
                cmd.Parameters.AddWithValue("@Sem1_Percentage", bel_stu.bel_Sem1_Percentage);
                cmd.Parameters.AddWithValue("@Sem1_SGPA", bel_stu.bel_Sem1_SGPA);
                cmd.Parameters.AddWithValue("@UG_Percentage", bel_stu.bel_UG_Percentage);
                cmd.Parameters.AddWithValue("@Sem2_Percentage", bel_stu.bel_Sem2_Percentage);
                cmd.Parameters.AddWithValue("@Sem2_SGPA", bel_stu.bel_Sem2_SGPA);
                cmd.Parameters.AddWithValue("@UG_Passed_Year", bel_stu.bel_UG_Passed_Year);
                cmd.Parameters.AddWithValue("@Sem3_Percentage", bel_stu.bel_Sem3_Percentage);
                cmd.Parameters.AddWithValue("@Sem3_SGPA", bel_stu.bel_Sem3_SGPA);
                cmd.Parameters.AddWithValue("@PG_Percentage", bel_stu.bel_PG_Percentage);
                cmd.Parameters.AddWithValue("@Sem4_Percentage", bel_stu.bel_Sem4_Percentage);
                cmd.Parameters.AddWithValue("@Sem4_SGPA", bel_stu.bel_Sem4_SGPA);
                cmd.Parameters.AddWithValue("@PG_Passed_Year", bel_stu.bel_PG_Passed_Year);
                cmd.Parameters.AddWithValue("@Sem5_Percentage", bel_stu.bel_Sem5_Percentage);
                cmd.Parameters.AddWithValue("@Sem5_SGPA", bel_stu.bel_Sem5_SGPA);
                cmd.Parameters.AddWithValue("@Gap_Year", bel_stu.bel_Gap_Year);
                cmd.Parameters.AddWithValue("@Sem6_Percentage", bel_stu.bel_Sem6_Percentage);
                cmd.Parameters.AddWithValue("@Sem6_SGPA", bel_stu.bel_Sem6_SGPA);
                cmd.Parameters.AddWithValue("@Live_Backlogs", bel_stu.bel_Live_Backlogs);
                cmd.Parameters.AddWithValue("@Sem7_Percentage", bel_stu.bel_Sem7_Percentage);
                cmd.Parameters.AddWithValue("@Sem7_SGPA", bel_stu.bel_Sem7_SGPA);
                cmd.Parameters.AddWithValue("@Dead_Backlogs", bel_stu.bel_Dead_Backlogs);
                cmd.Parameters.AddWithValue("@Sem8_Percentage", bel_stu.bel_Sem8_Percentage);
                cmd.Parameters.AddWithValue("@Sem8_SGPA", bel_stu.bel_Sem8_SGPA);
                cmd.Parameters.AddWithValue("@Experience", bel_stu.bel_Experience);
                cmd.Parameters.AddWithValue("@Entrance_Score", bel_stu.bel_Entrance_Score);
                cmd.Parameters.AddWithValue("@Aggregate", bel_stu.bel_Aggregate);

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
        //------end-Add_Drive_Criteria----------------//
        public int Add_Drive_Schedule(bel_Derive bel)
        {
            int result;
            try
            {
                cmd = new SqlCommand("Sp_Set_Drive_Schedule", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@flag", 1);
                cmd.Parameters.AddWithValue("@Academic_Year", bel.bel_Academic_Year);
                cmd.Parameters.AddWithValue("@Company_ID ", bel.bel_Company_ID);
                cmd.Parameters.AddWithValue("@Drive_Id", bel.bel_id);
                cmd.Parameters.AddWithValue("@Round_Number", bel.bel_Round_Number);
                cmd.Parameters.AddWithValue("@Round_Title", bel.bel_Round_Title);
                cmd.Parameters.AddWithValue("@Round_Date", bel.bel_Round_Date);
                cmd.Parameters.AddWithValue("@Round_Timing", bel.bel_Round_Timing);
                cmd.Parameters.AddWithValue("@Venue", bel.bel_Venue);
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
        public int update_Drive_Schedule(bel_Derive bel)
        {
            int result;
            try
            {
                cmd = new SqlCommand("Sp_Set_Drive_Schedule", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@flag", 2);
                cmd.Parameters.AddWithValue("@Academic_Year", bel.bel_Academic_Year);
                cmd.Parameters.AddWithValue("@Company_ID", bel.bel_Company_ID);
                cmd.Parameters.AddWithValue("@Drive_Id", bel.bel_id);
                cmd.Parameters.AddWithValue("@Round_Number", bel.bel_Round_Number);
                cmd.Parameters.AddWithValue("@Round_Title", bel.bel_Round_Title);
                cmd.Parameters.AddWithValue("@Round_Date", bel.bel_Round_Date);
                cmd.Parameters.AddWithValue("@Round_Timing", bel.bel_Round_Timing);
                cmd.Parameters.AddWithValue("@Venue", bel.bel_Venue);
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
        public DataSet Bind_Schedule(bel_Derive bel)
        {

            try
            {

                cmd = new SqlCommand("Sp_Set_Drive_Schedule", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@flag", 3);
                cmd.Parameters.AddWithValue("@Academic_Year", bel.bel_Academic_Year);
                cmd.Parameters.AddWithValue("@Company_ID", bel.bel_Company_ID);
                cmd.Parameters.AddWithValue("@Drive_Id", bel.bel_id);

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
        public DataSet Bind_Round_Drive_Schedule(bel_Derive bel)
        {

            try
            {

                cmd = new SqlCommand("Sp_Set_Drive_Schedule", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@flag", 4);
                cmd.Parameters.AddWithValue("@Company_ID", bel.bel_Company_ID);
                cmd.Parameters.AddWithValue("@Academic_Year", bel.bel_Academic_Year);
                cmd.Parameters.AddWithValue("@Drive_Id", bel.bel_id);
                cmd.Parameters.AddWithValue("@Round_Number", bel.bel_Round_Number);


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

        public int Add_TotalMarks(bel_Derive bel)
        {
            int result;
            try
            {
                con.Open();
                cmd = new SqlCommand("Sp_Add_Total_Marks", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@flag", 1);
                cmd.Parameters.AddWithValue("@Academic_Year", bel.bel_Academic_Year);
                cmd.Parameters.AddWithValue("@First_Year_Marks", bel.bel_First_Year_Marks);
                cmd.Parameters.AddWithValue("@Second_Year_Marks", bel.bel_Second_Year_Marks);
                cmd.Parameters.AddWithValue("@Third_Year_Marks", bel.bel_Third_Year_Marks);
                cmd.Parameters.AddWithValue("@Fourth_Year_Marks", bel.bel_Fourth_Year_Marks);
                cmd.Parameters.AddWithValue("@Fifth_Year_Marks", bel.bel_Fifth_Year_Marks);
                cmd.Parameters.AddWithValue("@Sem_1_Marks", bel.bel_Sem_1_Marks);
                cmd.Parameters.AddWithValue("@Sem_2_Marks", bel.bel_Sem_2_Marks);
                cmd.Parameters.AddWithValue("@Sem_3_Marks", bel.bel_Sem_3_Marks);
                cmd.Parameters.AddWithValue("@Sem_4_Marks", bel.bel_Sem_4_Marks);
                cmd.Parameters.AddWithValue("@Sem_5_Marks", bel.bel_Sem_5_Marks);
                cmd.Parameters.AddWithValue("@Sem_6_Marks", bel.bel_Sem_6_Marks);
                cmd.Parameters.AddWithValue("@Sem_7_Marks", bel.bel_Sem_7_Marks);
                cmd.Parameters.AddWithValue("@Sem_8_Marks", bel.bel_Sem_8_Marks);
                cmd.Parameters.AddWithValue("@Sem_9_Marks", bel.bel_Sem_9_Marks);
                cmd.Parameters.AddWithValue("@Sem_10_Marks", bel.bel_Sem_10_Marks);
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
