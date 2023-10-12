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
    public class dal_Student
    {
        //bel_student_details bel = new bel_student_details();
        SqlConnection con = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["myConnectionString"].ConnectionString);
        SqlCommand cmd;
        SqlDataAdapter da;
        public int add_Stud(bel_Student bel)
        {
            int result;
            try
            {
                con.Open();
                cmd = new SqlCommand("Student_add_update ", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@flag", 1);
                cmd.Parameters.AddWithValue("@Stud_id", bel.bel_id);
                cmd.Parameters.AddWithValue("@Academic_Year", bel.bel_Academic_Year);
                cmd.Parameters.AddWithValue("@Course_Name", bel.bel_Course_Name);
                cmd.Parameters.AddWithValue("@Aadhaar_No", bel.bel_Aadhaar_No);
                cmd.Parameters.AddWithValue("@University_Reg_No", bel.bel_bel_University_Reg_No);
                cmd.Parameters.AddWithValue("@Class_ID", bel.bel_Class_ID);
                cmd.Parameters.AddWithValue("@Roll_No", bel.bel_Roll_No);
                cmd.Parameters.AddWithValue("@Student_Name", bel.bel_Student_Name);
                cmd.Parameters.AddWithValue("@Email", bel.bel_Email);
                cmd.Parameters.AddWithValue("@Contact_No", bel.bel_Contact_No);
                cmd.Parameters.AddWithValue("@alt_contact_no", bel.bel_alt_contact_no);
                cmd.Parameters.AddWithValue("@Mother_Name", bel.bel_Mother_Name);
                cmd.Parameters.AddWithValue("@Gender", bel.bel_Gender);
                cmd.Parameters.AddWithValue("@DOB", bel.bel_DOB);
                cmd.Parameters.AddWithValue("@Blood_Group", bel.bel_Blood_Group);
                cmd.Parameters.AddWithValue("@Mother_Tongue", bel.bel_Mother_Tongue);
                cmd.Parameters.AddWithValue("@Languages", bel.bel_Languages);
                cmd.Parameters.AddWithValue("@Admission_Date", bel.bel_Admission_Date);
                cmd.Parameters.AddWithValue("@Address", bel.bel_Address);
                cmd.Parameters.AddWithValue("@Nationality", bel.bel_Nationality);
                cmd.Parameters.AddWithValue("@Domicile", bel.bel_Domicile);
                cmd.Parameters.AddWithValue("@Religion", bel.bel_Religion);
                cmd.Parameters.AddWithValue("@Category", bel.bel_Category);
                cmd.Parameters.AddWithValue("@Caste", bel.bel_Caste);
                cmd.Parameters.AddWithValue("@Hostelite", bel.bel_Hostelite);
                cmd.Parameters.AddWithValue("@Handicap", bel.bel_Handicap);
                cmd.Parameters.AddWithValue("@Sport", bel.bel_Sport);
                cmd.Parameters.AddWithValue("@Defence", bel.bel_Defence);
                cmd.Parameters.AddWithValue("@PAN_No", bel.bel_PAN_No);
                cmd.Parameters.AddWithValue("@Passport_No", bel.bel_Passport_No);
                cmd.Parameters.AddWithValue("@Driving_License", bel.bel_Driving_License);
                cmd.Parameters.AddWithValue("@F_Name", bel.bel_F_Name);
                cmd.Parameters.AddWithValue("@F_Contact", bel.bel_F_Contact);
                cmd.Parameters.AddWithValue("@F_Email", bel.bel_F_Email);
                cmd.Parameters.AddWithValue("@F_Occupation", bel.bel_F_Occupation);
                cmd.Parameters.AddWithValue("@F_Organization", bel.bel_F_Organization);
                cmd.Parameters.AddWithValue("@F_Designation", bel.bel_F_Designation);
                cmd.Parameters.AddWithValue("@F_Address", bel.bel_F_Address);
                cmd.Parameters.AddWithValue("@F_Annual_Income", bel.bel_F_Annual_Income);
                cmd.Parameters.AddWithValue("@SSC_Board", bel.bel_SSC_Board);
                cmd.Parameters.AddWithValue("@SSC_Institute", bel.bel_SSC_Institute);
                cmd.Parameters.AddWithValue("@SSC_Percentage", bel.bel_SSC_Percentage);
                cmd.Parameters.AddWithValue("@SSC_Passed_Year", bel.bel_SSC_Passed_Year);
                cmd.Parameters.AddWithValue("@SSC_Attempt", bel.bel_SSC_Attempt);
                cmd.Parameters.AddWithValue("@HSC_Board", bel.bel_HSC_Board);
                cmd.Parameters.AddWithValue("@HSC_Institute", bel.bel_HSC_Institute);
                cmd.Parameters.AddWithValue("@HSC_Percentage", bel.bel_HSC_Percentage);
                cmd.Parameters.AddWithValue("@HSC_Passed_Year", bel.bel_HSC_Passed_Year);
                cmd.Parameters.AddWithValue("@HSC_Attempt", bel.bel_HSC_Attempt);
                cmd.Parameters.AddWithValue("@Diploma_Board", bel.bel_Diploma_Board);
                cmd.Parameters.AddWithValue("@Diploma_Institute", bel.bel_Diploma_Institute);
                cmd.Parameters.AddWithValue("@Diploma_Percentage", bel.bel_Diploma_Percentage);
                cmd.Parameters.AddWithValue("@Diploma_Passed_Year", bel.bel_Diploma_Passed_Year);
                cmd.Parameters.AddWithValue("@Diploma_Attempt", bel.bel_Diploma_Attempt);
                cmd.Parameters.AddWithValue("@UG_Board", bel.bel_UG_Board);
                cmd.Parameters.AddWithValue("@UG_Institute", bel.bel_UG_Institute);
                cmd.Parameters.AddWithValue("@UG_Percentage", bel.bel_UG_Percentage);
                cmd.Parameters.AddWithValue("@UG_Passed_Year", bel.bel_UG_Passed_Year);
                cmd.Parameters.AddWithValue("@UG_Attempt", bel.bel_UG_Attempt);
                cmd.Parameters.AddWithValue("@PG_Board", bel.bel_PG_Board);
                cmd.Parameters.AddWithValue("@PG_Institute", bel.bel_PG_Institute);
                cmd.Parameters.AddWithValue("@PG_Percentage", bel.bel_PG_Percentage);
                cmd.Parameters.AddWithValue("@PG_Passed_Year", bel.bel_PG_Passed_Year);
                cmd.Parameters.AddWithValue("@PG_Attempt", bel.bel_PG_Attempt);
                cmd.Parameters.AddWithValue("@Sem1_Obtained_Marks", bel.bel_Sem1_Obtained_Marks);
                cmd.Parameters.AddWithValue("@Sem1_Total_Marks", bel.bel_Sem1_Total_Marks);
                cmd.Parameters.AddWithValue("@Sem1_Percentage", bel.bel_Sem1_Percentage);
                cmd.Parameters.AddWithValue("@Sem1_SGPA", bel.bel_Sem1_SGPA);
                cmd.Parameters.AddWithValue("@Sem1_BackLog", bel.bel_Sem1_BackLog);
                cmd.Parameters.AddWithValue("@Sem2_Obtained_Marks", bel.bel_Sem2_Obtained_Marks);
                cmd.Parameters.AddWithValue("@Sem2_Total_Marks", bel.bel_Sem2_Total_Marks);
                cmd.Parameters.AddWithValue("@Sem2_Percentage", bel.bel_Sem2_Percentage);
                cmd.Parameters.AddWithValue("@Sem2_SGPA", bel.bel_Sem2_SGPA);
                cmd.Parameters.AddWithValue("@Sem2_BackLog", bel.bel_Sem2_BackLog);
                cmd.Parameters.AddWithValue("@Sem3_Obtained_Marks", bel.bel_Sem3_Obtained_Marks);
                cmd.Parameters.AddWithValue("@Sem3_Total_Marks", bel.bel_Sem3_Total_Marks);
                cmd.Parameters.AddWithValue("@Sem3_Percentage", bel.bel_Sem3_Percentage);
                cmd.Parameters.AddWithValue("@Sem3_SGPA", bel.bel_Sem3_SGPA);
                cmd.Parameters.AddWithValue("@Sem3_BackLog", bel.bel_Sem3_BackLog);
                cmd.Parameters.AddWithValue("@Sem4_Obtained_Marks", bel.bel_Sem4_Obtained_Marks);
                cmd.Parameters.AddWithValue("@Sem4_Total_Marks", bel.bel_Sem4_Total_Marks);
                cmd.Parameters.AddWithValue("@Sem4_Percentage", bel.bel_Sem4_Percentage);
                cmd.Parameters.AddWithValue("@Sem4_SGPA", bel.bel_Sem4_SGPA);
                cmd.Parameters.AddWithValue("@Sem4_BackLog", bel.bel_Sem4_BackLog);
                cmd.Parameters.AddWithValue("@Sem5_Obtained_Marks", bel.bel_Sem5_Obtained_Marks);
                cmd.Parameters.AddWithValue("@Sem5_Total_Marks", bel.bel_Sem5_Total_Marks);
                cmd.Parameters.AddWithValue("@Sem5_Percentage", bel.bel_Sem5_Percentage);
                cmd.Parameters.AddWithValue("@Sem5_SGPA", bel.bel_Sem5_SGPA);
                cmd.Parameters.AddWithValue("@Sem5_BackLog", bel.bel_Sem5_BackLog);
                cmd.Parameters.AddWithValue("@Sem6_Obtained_Marks", bel.bel_Sem6_Obtained_Marks);
                cmd.Parameters.AddWithValue("@Sem6_Total_Marks", bel.bel_Sem6_Total_Marks);
                cmd.Parameters.AddWithValue("@Sem6_Percentage", bel.bel_Sem6_Percentage);
                cmd.Parameters.AddWithValue("@Sem6_SGPA", bel.bel_Sem6_SGPA);
                cmd.Parameters.AddWithValue("@Sem6_BackLog", bel.bel_Sem6_BackLog);
                cmd.Parameters.AddWithValue("@Sem7_Obtained_Marks", bel.bel_Sem7_Obtained_Marks);
                cmd.Parameters.AddWithValue("@Sem7_Total_Marks", bel.bel_Sem7_Total_Marks);
                cmd.Parameters.AddWithValue("@Sem7_Percentage", bel.bel_Sem7_Percentage);
                cmd.Parameters.AddWithValue("@Sem7_SGPA", bel.bel_Sem7_SGPA);
                cmd.Parameters.AddWithValue("@Sem7_BackLog", bel.bel_Sem7_BackLog);
                cmd.Parameters.AddWithValue("@Sem8_Obtained_Marks", bel.bel_Sem8_Obtained_Marks);
                cmd.Parameters.AddWithValue("@Sem8_Total_Marks", bel.bel_Sem8_Total_Marks);
                cmd.Parameters.AddWithValue("@Sem8_Percentage", bel.bel_Sem8_Percentage);
                cmd.Parameters.AddWithValue("@Sem8_SGPA", bel.bel_Sem8_SGPA);
                cmd.Parameters.AddWithValue("@Sem8_BackLog", bel.bel_Sem8_BackLog);
                cmd.Parameters.AddWithValue("@Year1_Obtained_Marks", bel.bel_Year1_Obtained_Marks);
                cmd.Parameters.AddWithValue("@Year1_Total_Marks", bel.bel_Year1_Total_Marks);
                cmd.Parameters.AddWithValue("@Year1_Percentage", bel.bel_Year1_Percentage);
                cmd.Parameters.AddWithValue("@Year1_SGPA", bel.bel_Year1_SGPA);
                cmd.Parameters.AddWithValue("@Year1_BackLog", bel.bel_Year1_BackLog);
                cmd.Parameters.AddWithValue("@Year2_Obtained_Marks", bel.bel_Year2_Obtained_Marks);
                cmd.Parameters.AddWithValue("@Year2_Total_Marks", bel.bel_Year2_Total_Marks);
                cmd.Parameters.AddWithValue("@Year2_Percentage", bel.bel_Year2_Percentage);
                cmd.Parameters.AddWithValue("@Year2_SGPA", bel.bel_Year2_SGPA);
                cmd.Parameters.AddWithValue("@Year2_BackLog", bel.bel_Year2_BackLog);
                cmd.Parameters.AddWithValue("@Year3_Obtained_Marks", bel.bel_Year3_Obtained_Marks);
                cmd.Parameters.AddWithValue("@Year3_Total_Marks", bel.bel_Year3_Total_Marks);
                cmd.Parameters.AddWithValue("@Year3_Percentage", bel.bel_Year3_Percentage);
                cmd.Parameters.AddWithValue("@Year3_SGPA", bel.bel_Year3_SGPA);
                cmd.Parameters.AddWithValue("@Year3_BackLog", bel.bel_Year3_BackLog);
                cmd.Parameters.AddWithValue("@Year4_Obtained_Marks", bel.bel_Year4_Obtained_Marks);
                cmd.Parameters.AddWithValue("@Year4_Total_Marks", bel.bel_Year4_Total_Marks);
                cmd.Parameters.AddWithValue("@Year4_Percentage", bel.bel_Year4_Percentage);
                cmd.Parameters.AddWithValue("@Year4_SGPA", bel.bel_Year4_SGPA);
                cmd.Parameters.AddWithValue("@Year4_BackLog", bel.bel_Year4_BackLog);
                cmd.Parameters.AddWithValue("@Year5_Obtained_Marks", bel.bel_Year5_Obtained_Marks);
                cmd.Parameters.AddWithValue("@Year5_Total_Marks", bel.bel_Year5_Total_Marks);
                cmd.Parameters.AddWithValue("@Year5_Percentage", bel.bel_Year5_Percentage);
                cmd.Parameters.AddWithValue("@Year5_SGPA", bel.bel_Year5_SGPA);
                cmd.Parameters.AddWithValue("@Year5_BackLog", bel.bel_Year5_BackLog);
                cmd.Parameters.AddWithValue("@Gap_Year", bel.bel_Gap_Year);
                cmd.Parameters.AddWithValue("@Live_Backlogs", bel.bel_Live_Backlogs);
                cmd.Parameters.AddWithValue("@Dead_Backlogs", bel.bel_Dead_Backlogs);
                cmd.Parameters.AddWithValue("@Experience", bel.bel_Experience);
                cmd.Parameters.AddWithValue("@Entrance_Score", bel.bel_Entrance_Score);
                cmd.Parameters.AddWithValue("@Aggregate", bel.bel_Aggregate);
                cmd.Parameters.AddWithValue("@Approuvel", "No");
                cmd.Parameters.AddWithValue("@status", "Active");
                //cmd.Parameters.AddWithValue("@Photo", bel.bel_Stuphoto);
                //cmd.Parameters.AddWithValue("@Stud_Resume", bel.bel_Resume);
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
        public int update_Stud(bel_Student bel)
        {
            int result;
            try
            {
                con.Open();
                cmd = new SqlCommand("Student_add_update ", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@flag", 2);
                cmd.Parameters.AddWithValue("@Stud_id", bel.bel_id);
                cmd.Parameters.AddWithValue("@Academic_Year", bel.bel_Academic_Year);
                cmd.Parameters.AddWithValue("@Course_Name", bel.bel_Course_Name);
                cmd.Parameters.AddWithValue("@Aadhaar_No", bel.bel_Aadhaar_No);
                cmd.Parameters.AddWithValue("@University_Reg_No", bel.bel_bel_University_Reg_No);
                cmd.Parameters.AddWithValue("@Class_ID", bel.bel_Class_ID);
                cmd.Parameters.AddWithValue("@Roll_No", bel.bel_Roll_No);
                cmd.Parameters.AddWithValue("@Student_Name", bel.bel_Student_Name);
                cmd.Parameters.AddWithValue("@Contact_No", bel.bel_Contact_No);
                cmd.Parameters.AddWithValue("@alt_contact_no", bel.bel_alt_contact_no);
                cmd.Parameters.AddWithValue("@Mother_Name", bel.bel_Mother_Name);
                cmd.Parameters.AddWithValue("@Gender", bel.bel_Gender);
                cmd.Parameters.AddWithValue("@DOB", bel.bel_DOB);
                cmd.Parameters.AddWithValue("@Blood_Group", bel.bel_Blood_Group);
                cmd.Parameters.AddWithValue("@Mother_Tongue", bel.bel_Mother_Tongue);
                cmd.Parameters.AddWithValue("@Languages", bel.bel_Languages);
                cmd.Parameters.AddWithValue("@Admission_Date", bel.bel_Admission_Date);
                cmd.Parameters.AddWithValue("@Address", bel.bel_Address);
                cmd.Parameters.AddWithValue("@Nationality", bel.bel_Nationality);
                cmd.Parameters.AddWithValue("@Domicile", bel.bel_Domicile);
                cmd.Parameters.AddWithValue("@Religion", bel.bel_Religion);
                cmd.Parameters.AddWithValue("@Category", bel.bel_Category);
                cmd.Parameters.AddWithValue("@Caste", bel.bel_Caste);
                cmd.Parameters.AddWithValue("@Hostelite", bel.bel_Hostelite);
                cmd.Parameters.AddWithValue("@Handicap", bel.bel_Handicap);
                cmd.Parameters.AddWithValue("@Sport", bel.bel_Sport);
                cmd.Parameters.AddWithValue("@Defence", bel.bel_Defence);
                cmd.Parameters.AddWithValue("@PAN_No", bel.bel_PAN_No);
                cmd.Parameters.AddWithValue("@Passport_No", bel.bel_Passport_No);
                cmd.Parameters.AddWithValue("@Driving_License", bel.bel_Driving_License);
                cmd.Parameters.AddWithValue("@F_Name", bel.bel_F_Name);
                cmd.Parameters.AddWithValue("@F_Contact", bel.bel_F_Contact);
                cmd.Parameters.AddWithValue("@F_Email", bel.bel_F_Email);
                cmd.Parameters.AddWithValue("@F_Occupation", bel.bel_F_Occupation);
                cmd.Parameters.AddWithValue("@F_Organization", bel.bel_F_Organization);
                cmd.Parameters.AddWithValue("@F_Designation", bel.bel_F_Designation);
                cmd.Parameters.AddWithValue("@F_Address", bel.bel_F_Address);
                cmd.Parameters.AddWithValue("@F_Annual_Income", bel.bel_F_Annual_Income);
                cmd.Parameters.AddWithValue("@SSC_Board", bel.bel_SSC_Board);
                cmd.Parameters.AddWithValue("@SSC_Institute", bel.bel_SSC_Institute);
                cmd.Parameters.AddWithValue("@SSC_Percentage", bel.bel_SSC_Percentage);
                cmd.Parameters.AddWithValue("@SSC_Passed_Year", bel.bel_SSC_Passed_Year);
                cmd.Parameters.AddWithValue("@SSC_Attempt", bel.bel_SSC_Attempt);
                cmd.Parameters.AddWithValue("@HSC_Board", bel.bel_HSC_Board);
                cmd.Parameters.AddWithValue("@HSC_Institute", bel.bel_HSC_Institute);
                cmd.Parameters.AddWithValue("@HSC_Percentage", bel.bel_HSC_Percentage);
                cmd.Parameters.AddWithValue("@HSC_Passed_Year", bel.bel_HSC_Passed_Year);
                cmd.Parameters.AddWithValue("@HSC_Attempt", bel.bel_HSC_Attempt);
                cmd.Parameters.AddWithValue("@Diploma_Board", bel.bel_Diploma_Board);
                cmd.Parameters.AddWithValue("@Diploma_Institute", bel.bel_Diploma_Institute);
                cmd.Parameters.AddWithValue("@Diploma_Percentage", bel.bel_Diploma_Percentage);
                cmd.Parameters.AddWithValue("@Diploma_Passed_Year", bel.bel_Diploma_Passed_Year);
                cmd.Parameters.AddWithValue("@Diploma_Attempt", bel.bel_Diploma_Attempt);
                cmd.Parameters.AddWithValue("@UG_Board", bel.bel_UG_Board);
                cmd.Parameters.AddWithValue("@UG_Institute", bel.bel_UG_Institute);
                cmd.Parameters.AddWithValue("@UG_Percentage", bel.bel_UG_Percentage);
                cmd.Parameters.AddWithValue("@UG_Passed_Year", bel.bel_UG_Passed_Year);
                cmd.Parameters.AddWithValue("@UG_Attempt", bel.bel_UG_Attempt);
                cmd.Parameters.AddWithValue("@PG_Board", bel.bel_PG_Board);
                cmd.Parameters.AddWithValue("@PG_Institute", bel.bel_PG_Institute);
                cmd.Parameters.AddWithValue("@PG_Percentage", bel.bel_PG_Percentage);
                cmd.Parameters.AddWithValue("@PG_Passed_Year", bel.bel_PG_Passed_Year);
                cmd.Parameters.AddWithValue("@PG_Attempt", bel.bel_PG_Attempt);
                cmd.Parameters.AddWithValue("@Sem1_Obtained_Marks", bel.bel_Sem1_Obtained_Marks);
                cmd.Parameters.AddWithValue("@Sem1_Total_Marks", bel.bel_Sem1_Total_Marks);
                cmd.Parameters.AddWithValue("@Sem1_Percentage", bel.bel_Sem1_Percentage);
                cmd.Parameters.AddWithValue("@Sem1_SGPA", bel.bel_Sem1_SGPA);
                cmd.Parameters.AddWithValue("@Sem1_BackLog", bel.bel_Sem1_BackLog);
                cmd.Parameters.AddWithValue("@Sem2_Obtained_Marks", bel.bel_Sem2_Obtained_Marks);
                cmd.Parameters.AddWithValue("@Sem2_Total_Marks", bel.bel_Sem2_Total_Marks);
                cmd.Parameters.AddWithValue("@Sem2_Percentage", bel.bel_Sem2_Percentage);
                cmd.Parameters.AddWithValue("@Sem2_SGPA", bel.bel_Sem2_SGPA);
                cmd.Parameters.AddWithValue("@Sem2_BackLog", bel.bel_Sem2_BackLog);
                cmd.Parameters.AddWithValue("@Sem3_Obtained_Marks", bel.bel_Sem3_Obtained_Marks);
                cmd.Parameters.AddWithValue("@Sem3_Total_Marks", bel.bel_Sem3_Total_Marks);
                cmd.Parameters.AddWithValue("@Sem3_Percentage", bel.bel_Sem3_Percentage);
                cmd.Parameters.AddWithValue("@Sem3_SGPA", bel.bel_Sem3_SGPA);
                cmd.Parameters.AddWithValue("@Sem3_BackLog", bel.bel_Sem3_BackLog);
                cmd.Parameters.AddWithValue("@Sem4_Obtained_Marks", bel.bel_Sem4_Obtained_Marks);
                cmd.Parameters.AddWithValue("@Sem4_Total_Marks", bel.bel_Sem4_Total_Marks);
                cmd.Parameters.AddWithValue("@Sem4_Percentage", bel.bel_Sem4_Percentage);
                cmd.Parameters.AddWithValue("@Sem4_SGPA", bel.bel_Sem4_SGPA);
                cmd.Parameters.AddWithValue("@Sem4_BackLog", bel.bel_Sem4_BackLog);
                cmd.Parameters.AddWithValue("@Sem5_Obtained_Marks", bel.bel_Sem5_Obtained_Marks);
                cmd.Parameters.AddWithValue("@Sem5_Total_Marks", bel.bel_Sem5_Total_Marks);
                cmd.Parameters.AddWithValue("@Sem5_Percentage", bel.bel_Sem5_Percentage);
                cmd.Parameters.AddWithValue("@Sem5_SGPA", bel.bel_Sem5_SGPA);
                cmd.Parameters.AddWithValue("@Sem5_BackLog", bel.bel_Sem5_BackLog);
                cmd.Parameters.AddWithValue("@Sem6_Obtained_Marks", bel.bel_Sem6_Obtained_Marks);
                cmd.Parameters.AddWithValue("@Sem6_Total_Marks", bel.bel_Sem6_Total_Marks);
                cmd.Parameters.AddWithValue("@Sem6_Percentage", bel.bel_Sem6_Percentage);
                cmd.Parameters.AddWithValue("@Sem6_SGPA", bel.bel_Sem6_SGPA);
                cmd.Parameters.AddWithValue("@Sem6_BackLog", bel.bel_Sem6_BackLog);
                cmd.Parameters.AddWithValue("@Sem7_Obtained_Marks", bel.bel_Sem7_Obtained_Marks);
                cmd.Parameters.AddWithValue("@Sem7_Total_Marks", bel.bel_Sem7_Total_Marks);
                cmd.Parameters.AddWithValue("@Sem7_Percentage", bel.bel_Sem7_Percentage);
                cmd.Parameters.AddWithValue("@Sem7_SGPA", bel.bel_Sem7_SGPA);
                cmd.Parameters.AddWithValue("@Sem7_BackLog", bel.bel_Sem7_BackLog);
                cmd.Parameters.AddWithValue("@Sem8_Obtained_Marks", bel.bel_Sem8_Obtained_Marks);
                cmd.Parameters.AddWithValue("@Sem8_Total_Marks", bel.bel_Sem8_Total_Marks);
                cmd.Parameters.AddWithValue("@Sem8_Percentage", bel.bel_Sem8_Percentage);
                cmd.Parameters.AddWithValue("@Sem8_SGPA", bel.bel_Sem8_SGPA);
                cmd.Parameters.AddWithValue("@Sem8_BackLog", bel.bel_Sem8_BackLog);
                cmd.Parameters.AddWithValue("@Year1_Obtained_Marks", bel.bel_Year1_Obtained_Marks);
                cmd.Parameters.AddWithValue("@Year1_Total_Marks", bel.bel_Year1_Total_Marks);
                cmd.Parameters.AddWithValue("@Year1_Percentage", bel.bel_Year1_Percentage);
                cmd.Parameters.AddWithValue("@Year1_SGPA", bel.bel_Year1_SGPA);
                cmd.Parameters.AddWithValue("@Year1_BackLog", bel.bel_Year1_BackLog);
                cmd.Parameters.AddWithValue("@Year2_Obtained_Marks", bel.bel_Year2_Obtained_Marks);
                cmd.Parameters.AddWithValue("@Year2_Total_Marks", bel.bel_Year2_Total_Marks);
                cmd.Parameters.AddWithValue("@Year2_Percentage", bel.bel_Year2_Percentage);
                cmd.Parameters.AddWithValue("@Year2_SGPA", bel.bel_Year2_SGPA);
                cmd.Parameters.AddWithValue("@Year2_BackLog", bel.bel_Year2_BackLog);
                cmd.Parameters.AddWithValue("@Year3_Obtained_Marks", bel.bel_Year3_Obtained_Marks);
                cmd.Parameters.AddWithValue("@Year3_Total_Marks", bel.bel_Year3_Total_Marks);
                cmd.Parameters.AddWithValue("@Year3_Percentage", bel.bel_Year3_Percentage);
                cmd.Parameters.AddWithValue("@Year3_SGPA", bel.bel_Year3_SGPA);
                cmd.Parameters.AddWithValue("@Year3_BackLog", bel.bel_Year3_BackLog);
                cmd.Parameters.AddWithValue("@Year4_Obtained_Marks", bel.bel_Year4_Obtained_Marks);
                cmd.Parameters.AddWithValue("@Year4_Total_Marks", bel.bel_Year4_Total_Marks);
                cmd.Parameters.AddWithValue("@Year4_Percentage", bel.bel_Year4_Percentage);
                cmd.Parameters.AddWithValue("@Year4_SGPA", bel.bel_Year4_SGPA);
                cmd.Parameters.AddWithValue("@Year4_BackLog", bel.bel_Year4_BackLog);
                cmd.Parameters.AddWithValue("@Year5_Obtained_Marks", bel.bel_Year5_Obtained_Marks);
                cmd.Parameters.AddWithValue("@Year5_Total_Marks", bel.bel_Year5_Total_Marks);
                cmd.Parameters.AddWithValue("@Year5_Percentage", bel.bel_Year5_Percentage);
                cmd.Parameters.AddWithValue("@Year5_SGPA", bel.bel_Year5_SGPA);
                cmd.Parameters.AddWithValue("@Year5_BackLog", bel.bel_Year5_BackLog);
                cmd.Parameters.AddWithValue("@Gap_Year", bel.bel_Gap_Year);
                cmd.Parameters.AddWithValue("@Live_Backlogs", bel.bel_Live_Backlogs);
                cmd.Parameters.AddWithValue("@Dead_Backlogs", bel.bel_Dead_Backlogs);
                cmd.Parameters.AddWithValue("@Experience", bel.bel_Experience);
                cmd.Parameters.AddWithValue("@Entrance_Score", bel.bel_Entrance_Score);
                cmd.Parameters.AddWithValue("@Aggregate", bel.bel_Aggregate);
                cmd.Parameters.AddWithValue("@Photo", bel.bel_Stuphoto);
                cmd.Parameters.AddWithValue("@Stud_Resume", bel.bel_Resume);

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

        public DataSet select(bel_Student bel)
        {
            cmd = new SqlCommand("Student_add_update", con);
            try
            {
                con.Open();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@flag", 3);
                cmd.Parameters.AddWithValue("@Stud_id", bel.bel_id);
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
        public DataSet selectAll()
        {
            cmd = new SqlCommand("Student_add_update", con);
            try
            {
                con.Open();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@flag", 4);
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
        public DataSet bindStudent_Year_Dept_wise(bel_Student bel)
        {
            cmd = new SqlCommand("Student_add_update", con);
            try
            {
                con.Open();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@flag", 5);
                cmd.Parameters.AddWithValue("@Academic_Year", bel.bel_Academic_Year);
                cmd.Parameters.AddWithValue("@Course_Name", bel.bel_Course_Name);
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
        //---student Project Details----//

        public int add_Project(bel_Student bel)
        {
            int result;
            try
            {
                con.Open();
                cmd = new SqlCommand("Student_add_update ", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@flag", 6);
                cmd.Parameters.AddWithValue("@Stud_id", bel.bel_id);
                cmd.Parameters.AddWithValue("@Project_Type", bel.bel_Project_Type);
                cmd.Parameters.AddWithValue("@Project_Title", bel.bel_Project_Title);
                cmd.Parameters.AddWithValue("@Project_Domain", bel.bel_Project_Domain);
                cmd.Parameters.AddWithValue("@Project_Duration", bel.bel_Project_Duration);
                cmd.Parameters.AddWithValue("@Technologies", bel.bel_Technologies);
                cmd.Parameters.AddWithValue("@Team_Size", bel.bel_Team_Size);
                cmd.Parameters.AddWithValue("@Guide_Name", bel.bel_Guide_Name);
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

        public int update_Project(bel_Student bel)
        {
            int result;
            try
            {
                con.Open();
                cmd = new SqlCommand("Student_add_update ", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@flag", 7);
                cmd.Parameters.AddWithValue("@Stud_id", bel.bel_id);
                cmd.Parameters.AddWithValue("@Project_Type", bel.bel_Project_Type);
                cmd.Parameters.AddWithValue("@Project_Title", bel.bel_Project_Title);
                cmd.Parameters.AddWithValue("@Project_Domain", bel.bel_Project_Domain);
                cmd.Parameters.AddWithValue("@Project_Duration", bel.bel_Project_Duration);
                cmd.Parameters.AddWithValue("@Technologies", bel.bel_Technologies);
                cmd.Parameters.AddWithValue("@Team_Size", bel.bel_Team_Size);
                cmd.Parameters.AddWithValue("@Guide_Name", bel.bel_Guide_Name);
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
        public DataTable bind_ProjectTitle(bel_Student bel)
        {
            cmd = new SqlCommand("Student_add_update", con);
            try
            {
                con.Open();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Stud_id", bel.bel_id);
                cmd.Parameters.AddWithValue("@flag", 8);
                DataTable ds = new DataTable();
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

        public DataTable Bind_gvProject_Details(bel_Student bel)
        {
            cmd = new SqlCommand("Student_add_update", con);
            try
            {
                con.Open();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@flag", 9);
                cmd.Parameters.AddWithValue("@Stud_id", bel.bel_id);
                cmd.Parameters.AddWithValue("@Project_Title", bel.bel_Project_Title);
                DataTable dT = new DataTable();
                SqlDataAdapter adp1 = new SqlDataAdapter(cmd);
                adp1.Fill(dT);

                return dT;

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
        public DataSet Approuve_update(bel_Student bel)
        {
            cmd = new SqlCommand("Student_add_update", con);
            try
            {
                con.Open();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@flag", 10);
                cmd.Parameters.AddWithValue("@Stud_id", bel.bel_id);
                cmd.Parameters.AddWithValue("@Approuvel", bel.bel_Approuvel);
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
        

        public int Student_Applied_Drive(bel_Derive bel)     //add_student_Activity
        {
            int result;
            try
            {
                con.Open();
                cmd = new SqlCommand("SP_Student_Applied_Drive ", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@flag", 1);
                cmd.Parameters.AddWithValue("@Student_ID", bel.bel_id);
                cmd.Parameters.AddWithValue("@Acadamic_Year", bel.bel_Academic_Year);
                cmd.Parameters.AddWithValue("@Company_ID", bel.bel_Company_ID);
                cmd.Parameters.AddWithValue("@Company_Name", bel.bel_Company_name);
                cmd.Parameters.AddWithValue("@Drive_Id", bel.bel_Drive_Title);
                cmd.Parameters.AddWithValue("@AppliedDate", bel.bel_AppliedDate);
                cmd.Parameters.AddWithValue("@Round", bel.bel_Status);


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
        public DataSet bind_Applied_Students_wise(bel_Student bel)
        {
            cmd = new SqlCommand("Student_add_update", con);
            try
            {
                con.Open();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@flag", 11);
                cmd.Parameters.AddWithValue("@Academic_Year", bel.bel_Academic_Year);
                cmd.Parameters.AddWithValue("@Company_ID", bel.bel_Company_ID);
                cmd.Parameters.AddWithValue("@Drive_Id", bel.bel_Drive_Id);
                cmd.Parameters.AddWithValue("@Round", bel.bel_Round);
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
        public DataTable Applied_Student_List(bel_Student bel)
        {
            cmd = new SqlCommand("SP_Student_Applied_Drive", con);
            try
            {
                con.Open();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@flag", 6);
                cmd.Parameters.AddWithValue("@Acadamic_Year", bel.bel_Academic_Year);
                cmd.Parameters.AddWithValue("@Company_ID", bel.bel_Company_ID);
                cmd.Parameters.AddWithValue("@Drive_Id", bel.bel_Drive_Id);
                DataTable ds = new DataTable();
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
        public DataTable Forward_Student(bel_Derive bel)     //Forward_Student to Next Round
        {
            //int result;
            try
            {
                con.Open();
                cmd = new SqlCommand("usp_ForwardStudent ", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@DriveTitle", bel.bel_Drive_Title);
                cmd.Parameters.AddWithValue("@Round", bel.bel_Round);
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

        public int Update_Round(bel_Student bel)
        {
            int result;
            try
            {
                con.Open();
                cmd = new SqlCommand("SP_Student_Applied_Drive ", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@flag", 5);
                cmd.Parameters.AddWithValue("@Student_ID", bel.bel_id);
                cmd.Parameters.AddWithValue("@Drive_Id", bel.bel_Drive_Id);
                cmd.Parameters.AddWithValue("@Company_ID", bel.bel_Company_ID);
                cmd.Parameters.AddWithValue("@Round", bel.bel_Round);

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

        // Student Achivement
        public int Add_Achievment(bel_Student bel)
        {
            int result;
            try
            {
                con.Open();
                cmd = new SqlCommand("Sp_Add_Achievement_Details", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@flag", 1);
                cmd.Parameters.AddWithValue("@studentID", bel.bel_id);
                cmd.Parameters.AddWithValue("@Achievement_Title", bel.bel_Achievement_Title);
                cmd.Parameters.AddWithValue("@Achievement_Details", bel.bel_Achievement_Details);
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
        public DataTable bind_AchievementTitle(bel_Student bel)
        {
            cmd = new SqlCommand("Sp_Add_Achievement_Details", con);
            try
            {
                con.Open();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@flag", 2);
                cmd.Parameters.AddWithValue("@studentID", bel.bel_id);
                DataTable dT = new DataTable();
                SqlDataAdapter adp1 = new SqlDataAdapter(cmd);
                adp1.Fill(dT);

                return dT;

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
        public int Update_Achievment(bel_Student bel)
        {
            int result;
            try
            {
                con.Open();
                cmd = new SqlCommand("Sp_Add_Achievement_Details", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@flag", 3);
                cmd.Parameters.AddWithValue("@studentID", bel.bel_id);
                cmd.Parameters.AddWithValue("@Achievement_Title", bel.bel_Achievement_Title);
                cmd.Parameters.AddWithValue("@Achievement_Details", bel.bel_Achievement_Details);
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
        public DataTable Bind_gvAchievementDetails(bel_Student bel)
        {
            cmd = new SqlCommand("Sp_Add_Achievement_Details", con);
            try
            {
                con.Open();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@flag", 4);
                cmd.Parameters.AddWithValue("@studentID", bel.bel_id);
                cmd.Parameters.AddWithValue("@Achievement_Title", bel.bel_Achievement_Title);
                DataTable dT = new DataTable();
                SqlDataAdapter adp1 = new SqlDataAdapter(cmd);
                adp1.Fill(dT);

                return dT;

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

        // Student Technical
        public int Add_Technical(bel_Student bel)
        {
            int result;
            try
            {
                con.Open();
                cmd = new SqlCommand("Sp_Add_Technical_Details", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@flag", 1);
                cmd.Parameters.AddWithValue("@stuID", bel.bel_id);
                cmd.Parameters.AddWithValue("@Course_Title", bel.bel_Course_Name);
                cmd.Parameters.AddWithValue("@Technical_Details", bel.bel_Technical_Details);
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
        public int update_Technical(bel_Student bel)
        {
            int result;
            try
            {
                con.Open();
                cmd = new SqlCommand("Sp_Add_Technical_Details", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@flag", 3);
                cmd.Parameters.AddWithValue("@stuID", bel.bel_id);
                cmd.Parameters.AddWithValue("@Course_Title", bel.bel_Course_Name);
                cmd.Parameters.AddWithValue("@Technical_Details", bel.bel_Technical_Details);
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
        public DataTable bind_CourseTitle(bel_Student bel)
        {
            cmd = new SqlCommand("Sp_Add_Technical_Details", con);
            try
            {
                con.Open();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@stuID", bel.bel_id);
                cmd.Parameters.AddWithValue("@flag", 2);
                DataTable dT = new DataTable();
                SqlDataAdapter adp1 = new SqlDataAdapter(cmd);
                adp1.Fill(dT);

                return dT;

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
        public DataTable Bind_gvTechnicalDetails(bel_Student bel)
        {
            cmd = new SqlCommand("Sp_Add_Technical_Details", con);
            try
            {
                con.Open();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@flag", 4);
                cmd.Parameters.AddWithValue("@stuID", bel.bel_id);
                cmd.Parameters.AddWithValue("@Course_Title", bel.bel_Course_Name);
                DataTable dT = new DataTable();
                SqlDataAdapter adp1 = new SqlDataAdapter(cmd);
                adp1.Fill(dT);

                return dT;

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

        // Student Activity
        public int add_student_Activity(bel_Student bel)     //add_student_Activity
        {
            int result;
            try
            {
                con.Open();
                cmd = new SqlCommand("add_student_extraActivity ", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@flag", 1);
                cmd.Parameters.AddWithValue("@Student_id", bel.bel_id);
                cmd.Parameters.AddWithValue("@Activity_Title", bel.bel_Title);
                cmd.Parameters.AddWithValue("@Activity_Details", bel.bel_Details);
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

        public int Update_student_Activity(bel_Student bel)     //add_student_Activity
        {
            int result;
            try
            {
                con.Open();
                cmd = new SqlCommand("add_student_extraActivity ", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@flag", 3);
                cmd.Parameters.AddWithValue("@Student_id", bel.bel_id);
                cmd.Parameters.AddWithValue("@Activity_Title", bel.bel_Title);
                cmd.Parameters.AddWithValue("@Activity_Details", bel.bel_Details);
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

        public DataTable bind_student_extraActivity(bel_Student bel)
        {
            cmd = new SqlCommand("add_student_extraActivity", con);
            try
            {
                con.Open();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@flag", 2);
                cmd.Parameters.AddWithValue("@Student_id", bel.bel_id);
                DataTable ds = new DataTable();
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

        public DataTable Bind_gvstudent_extraActivity(bel_Student bel)
        {
            cmd = new SqlCommand("add_student_extraActivity", con);
            try
            {
                con.Open();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@flag", 4);
                cmd.Parameters.AddWithValue("@Student_id", bel.bel_id);
                cmd.Parameters.AddWithValue("@Activity_Title", bel.bel_Title);
                DataTable dT = new DataTable();
                SqlDataAdapter adp1 = new SqlDataAdapter(cmd);
                adp1.Fill(dT);

                return dT;

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
        //Reports Placed Unplaced Student
        public DataTable SelectAllPlace_Unplace_Stud_List() //All Student 1 ////
        {

            try
            {
                con.Open();
                cmd = new SqlCommand("Sp_Placed_Unplaced_Stud ", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@flag", 1);
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
        public DataTable SelectPlaced_Stud_List(bel_Student bel)
        {

            try
            {
                con.Open();
                cmd = new SqlCommand("Sp_Placed_Unplaced_Stud ", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@flag", 2);
                cmd.Parameters.AddWithValue("@Round", bel.bel_Round);
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
        public DataTable Select_Unplace_Stud_List(bel_Student bel)
        {

            try
            {
                con.Open();
                cmd = new SqlCommand("Sp_Placed_Unplaced_Stud ", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@flag", 3);
                cmd.Parameters.AddWithValue("@Round", bel.bel_Round);
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
        public DataTable SelectAllYear_Wise(bel_Student bel) //All Student  Yearly 2 ////
        {

            try
            {
                con.Open();
                cmd = new SqlCommand("Sp_Placed_Unplaced_Stud ", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@flag", 4);
                cmd.Parameters.AddWithValue("@Academic_Year", bel.bel_Academic_Year);
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
        public DataTable Year_WisePlaced(bel_Student bel)
        {

            try
            {
                con.Open();
                cmd = new SqlCommand("Sp_Placed_Unplaced_Stud ", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@flag", 5);
                cmd.Parameters.AddWithValue("@Academic_Year", bel.bel_Academic_Year);
                cmd.Parameters.AddWithValue("@Round", bel.bel_Round);
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
        public DataTable Year_WiseUnplaced(bel_Student bel)
        {

            try
            {
                con.Open();
                cmd = new SqlCommand("Sp_Placed_Unplaced_Stud ", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@flag", 6);
                cmd.Parameters.AddWithValue("@Academic_Year", bel.bel_Academic_Year);
                cmd.Parameters.AddWithValue("@Round", bel.bel_Round);
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
        public DataTable SelectAllDept_Wise(bel_Student bel) //All Student dept  Yearly 3////
        {

            try
            {
                con.Open();
                cmd = new SqlCommand("Sp_Placed_Unplaced_Stud ", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@flag", 7);
                cmd.Parameters.AddWithValue("@Course_Name", bel.bel_Course_Name);
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
        public DataTable Dept_WisePlaced(bel_Student bel)
        {

            try
            {
                con.Open();
                cmd = new SqlCommand("Sp_Placed_Unplaced_Stud ", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@flag", 8);
                cmd.Parameters.AddWithValue("@Course_Name", bel.bel_Course_Name);
                cmd.Parameters.AddWithValue("@Round", bel.bel_Round);
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
        public DataTable Dept_WiseUnPlaced(bel_Student bel)
        {

            try
            {
                con.Open();
                cmd = new SqlCommand("Sp_Placed_Unplaced_Stud ", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@flag", 9);
                cmd.Parameters.AddWithValue("@Course_Name", bel.bel_Course_Name);
                cmd.Parameters.AddWithValue("@Round", bel.bel_Round);
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
        public DataTable SelectAllDrive_Wise(bel_Student bel) //All Student drive  Yearly 4////
        {

            try
            {
                con.Open();
                cmd = new SqlCommand("Sp_Placed_Unplaced_Stud ", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@flag", 10);
                cmd.Parameters.AddWithValue("@Company_ID", bel.bel_Company_ID);
                cmd.Parameters.AddWithValue("@Drive_Id", bel.bel_Drive_Id);
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
        public DataTable Drive_WisePlaced(bel_Student bel)
        {

            try
            {
                con.Open();
                cmd = new SqlCommand("Sp_Placed_Unplaced_Stud ", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@flag", 11);
                cmd.Parameters.AddWithValue("@Company_ID", bel.bel_Company_ID);
                cmd.Parameters.AddWithValue("@Drive_Id", bel.bel_Drive_Id);
                cmd.Parameters.AddWithValue("@Round", bel.bel_Round);
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
        public DataTable Drive_WiseUnPlaced(bel_Student bel)
        {

            try
            {
                con.Open();
                cmd = new SqlCommand("Sp_Placed_Unplaced_Stud ", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@flag", 12);
                cmd.Parameters.AddWithValue("@Company_ID", bel.bel_Company_ID);
                cmd.Parameters.AddWithValue("@Drive_Id", bel.bel_Drive_Id);
                cmd.Parameters.AddWithValue("@Round", bel.bel_Round);
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
        public DataTable Select_year_Dept_Wise(bel_Student bel) //All Student Year Dept  Yearly 5////
        {

            try
            {
                con.Open();
                cmd = new SqlCommand("Sp_Placed_Unplaced_Stud ", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@flag", 13);
                cmd.Parameters.AddWithValue("@Academic_Year", bel.bel_Academic_Year);
                cmd.Parameters.AddWithValue("@Course_Name", bel.bel_Course_Name);
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
        public DataTable year_Dept_Wise_Placed(bel_Student bel)
        {

            try
            {
                con.Open();
                cmd = new SqlCommand("Sp_Placed_Unplaced_Stud ", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@flag", 14);
                cmd.Parameters.AddWithValue("@Academic_Year", bel.bel_Academic_Year);
                cmd.Parameters.AddWithValue("@Course_Name", bel.bel_Course_Name);
                cmd.Parameters.AddWithValue("@Round", bel.bel_Round);
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
        public DataTable year_Dept_Wise_UnPlaced(bel_Student bel)
        {

            try
            {
                con.Open();
                cmd = new SqlCommand("Sp_Placed_Unplaced_Stud ", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@flag", 15);
                cmd.Parameters.AddWithValue("@Academic_Year", bel.bel_Academic_Year);
                cmd.Parameters.AddWithValue("@Course_Name", bel.bel_Course_Name);
                cmd.Parameters.AddWithValue("@Round", bel.bel_Round);
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
        public DataTable Select_year_Drive_Wise(bel_Student bel) //All Student Year drive  Yearly 6////
        {

            try
            {
                con.Open();
                cmd = new SqlCommand("Sp_Placed_Unplaced_Stud ", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@flag", 16);
                cmd.Parameters.AddWithValue("@Academic_Year", bel.bel_Academic_Year);
                cmd.Parameters.AddWithValue("@Company_ID", bel.bel_Company_ID);
                cmd.Parameters.AddWithValue("@Drive_Id", bel.bel_Drive_Id);
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
        public DataTable year_Drive_Wise_Placed(bel_Student bel)
        {

            try
            {
                con.Open();
                cmd = new SqlCommand("Sp_Placed_Unplaced_Stud ", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@flag", 17);
                cmd.Parameters.AddWithValue("@Academic_Year", bel.bel_Academic_Year);
                cmd.Parameters.AddWithValue("@Company_ID", bel.bel_Company_ID);
                cmd.Parameters.AddWithValue("@Drive_Id", bel.bel_Drive_Id);
                cmd.Parameters.AddWithValue("@Round", bel.bel_Round);
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
        public DataTable year_Drive_Wise_UnPlaced(bel_Student bel)
        {

            try
            {
                con.Open();
                cmd = new SqlCommand("Sp_Placed_Unplaced_Stud ", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@flag", 18);
                cmd.Parameters.AddWithValue("@Academic_Year", bel.bel_Academic_Year);
                cmd.Parameters.AddWithValue("@Company_ID", bel.bel_Company_ID);
                cmd.Parameters.AddWithValue("@Drive_Id", bel.bel_Drive_Id);
                cmd.Parameters.AddWithValue("@Round", bel.bel_Round);
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


        public DataTable Select_Company_wise_Stud(bel_Student bel) //Company wise Student 1 ////
        {

            try
            {
                con.Open();
                cmd = new SqlCommand("Sp_Placed_Unplaced_Stud ", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@flag", 19);
                cmd.Parameters.AddWithValue("@Company_ID", bel.bel_Company_ID);
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
        public DataTable Select_Company_wise_Placed_Stud(bel_Student bel)
        {

            try
            {
                con.Open();
                cmd = new SqlCommand("Sp_Placed_Unplaced_Stud ", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@flag", 20);
                cmd.Parameters.AddWithValue("@Company_ID", bel.bel_Company_ID);
                cmd.Parameters.AddWithValue("@Round", bel.bel_Round);
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
        public DataTable Select_Company_wise_UnPlaced_Stud(bel_Student bel)
        {

            try
            {
                con.Open();
                cmd = new SqlCommand("Sp_Placed_Unplaced_Stud ", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@flag", 21);
                cmd.Parameters.AddWithValue("@Company_ID", bel.bel_Company_ID);
                cmd.Parameters.AddWithValue("@Round", bel.bel_Round);
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
        public DataTable Select_Company_Year_Wise_Stud(bel_Student bel) //Company year wise Student 2 ////
        {

            try
            {
                con.Open();
                cmd = new SqlCommand("Sp_Placed_Unplaced_Stud ", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@flag", 22);
                cmd.Parameters.AddWithValue("@Academic_Year", bel.bel_Academic_Year);
                cmd.Parameters.AddWithValue("@Company_ID", bel.bel_Company_ID);
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
        public DataTable Select_Company_Year_Wise_Placed_Stud(bel_Student bel)
        {

            try
            {
                con.Open();
                cmd = new SqlCommand("Sp_Placed_Unplaced_Stud ", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@flag", 23);
                cmd.Parameters.AddWithValue("@Academic_Year", bel.bel_Academic_Year);
                cmd.Parameters.AddWithValue("@Company_ID", bel.bel_Company_ID);
                cmd.Parameters.AddWithValue("@Round", bel.bel_Round);
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
        public DataTable Select_Company_Year_Wise_UnPlaced_Stud(bel_Student bel)
        {

            try
            {
                con.Open();
                cmd = new SqlCommand("Sp_Placed_Unplaced_Stud ", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@flag", 24);
                cmd.Parameters.AddWithValue("@Academic_Year", bel.bel_Academic_Year);
                cmd.Parameters.AddWithValue("@Company_ID", bel.bel_Company_ID);
                cmd.Parameters.AddWithValue("@Round", bel.bel_Round);
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

    }
}
