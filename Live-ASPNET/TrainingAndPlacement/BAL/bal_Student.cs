using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BEL;
using DAL;
using System.Data;
namespace BAL
{
    public class bal_Student
    {
        dal_Student dal = new dal_Student();
        public Int32 add_Stud(bel_Student bel_er)
        {
            try
            {
                return dal.add_Stud(bel_er);
            }
            catch (Exception ex)
            {
                throw;
            }
            finally
            {
                dal = null;
            }
        }
        public Int32 update_Stud(bel_Student bel_er)
        {
            try
            {
                return dal.update_Stud(bel_er);
            }
            catch (Exception ex)
            {
                throw;
            }
            finally
            {
                dal = null;
            }
        }
        public DataSet select(bel_Student bal)
        {
            return dal.select(bal);
        }

        public DataSet selectAll()
        {
            return dal.selectAll();
        }

        public DataSet bindStudent_Year_Dept_wise(bel_Student bal)
        {
            return dal.bindStudent_Year_Dept_wise(bal);
        }
        //----stud project---//
        public Int32 add_Project(bel_Student bel_er)
        {
            dal_Student dal_Pro = new dal_Student();
            try
            {
                return dal_Pro.add_Project(bel_er);
            }
            catch (Exception ex)
            {
                throw;
            }
            finally
            {
                dal_Pro = null;
            }
        }
        public DataTable bind_ProjectTitle(bel_Student bel)
        {
            return dal.bind_ProjectTitle(bel);
        }
        public DataTable Bind_gvProject_Details(bel_Student bal)
        {
            dal_Student dal = new dal_Student();
            return dal.Bind_gvProject_Details(bal);
        }
        public Int32 update_Project(bel_Student bel_er)
        {
            dal_Student dal = new dal_Student();
            try
            {
                return dal.update_Project(bel_er);
            }
            catch (Exception ex)
            {
                throw;
            }
            finally
            {
                dal = null;
            }
        }
        public DataSet Approuve_update(bel_Student bel_er)
        {
            dal_Student dal = new dal_Student();
            try
            {
                return dal.Approuve_update(bel_er);
            }
            catch (Exception ex)
            {
                throw;
            }
            finally
            {
                dal = null;
            }
        }
        public DataSet bind_Applied_Students_wise(bel_Student bal)
        {
            return dal.bind_Applied_Students_wise(bal);
        }

        public Int32 Student_Applied_Drive(bel_Derive bel)
        {
            try
            {
                return dal.Student_Applied_Drive(bel);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                dal = null;
            }
        }
        public DataTable Applied_Student_List(bel_Student bal)
        {
            return dal.Applied_Student_List(bal);
        }
        public DataTable Forward_Student(bel_Derive bel)
        {
            return dal.Forward_Student(bel);
        }

        public Int32 Update_Round(bel_Student bel)
        {
            try
            {
                return dal.Update_Round(bel);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                dal = null;
            }
        }

        // Student Achivement
        public Int32 Add_Achievment(bel_Student bel)
        {
            dal_Student dal = new dal_Student();
            try
            {
                return dal.Add_Achievment(bel);
            }
            catch (Exception ex)
            {
                throw;
            }
            finally
            {
                dal = null;
            }
        }
        public Int32 Update_Achievment(bel_Student bel)
        {
            dal_Student dal = new dal_Student();
            try
            {
                return dal.Update_Achievment(bel);
            }
            catch (Exception ex)
            {
                throw;
            }
            finally
            {
                dal = null;
            }
        }
        public DataTable bind_AchievementTitle(bel_Student bel)
        {
            return dal.bind_AchievementTitle(bel);
        }
        public DataTable Bind_gvAchievementDetails(bel_Student bal)
        {
            dal_Student dal = new dal_Student();

            return dal.Bind_gvAchievementDetails(bal);
        }

        // Student Technical
        public Int32 Add_Technical(bel_Student bel)
        {
            dal_Student dal = new dal_Student();
            try
            {
                return dal.Add_Technical(bel);
            }
            catch (Exception ex)
            {
                throw;
            }
            finally
            {
                dal = null;
            }
        }
        public Int32 update_Technical(bel_Student bel)
        {
            dal_Student dal = new dal_Student();
            try
            {
                return dal.update_Technical(bel);
            }
            catch (Exception ex)
            {
                throw;
            }
            finally
            {
                dal = null;
            }
        }
        public DataTable bind_CourseTitle(bel_Student bel)
        {
            return dal.bind_CourseTitle(bel);
        }
        public DataTable Bind_gvTechnicalDetails(bel_Student bal)
        {
            dal_Student dal = new dal_Student();

            return dal.Bind_gvTechnicalDetails(bal);
        }


        // Student Activity
        public Int32 add_student_Activity(bel_Student bel)
        {
            dal_Student dal = new dal_Student();
            try
            {
                return dal.add_student_Activity(bel);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                dal = null;
            }
        }
        public Int32 Update_student_Activity(bel_Student bel)
        {
            dal_Student dal = new dal_Student();
            try
            {
                return dal.Update_student_Activity(bel);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                dal = null;
            }
        }

        public DataTable bind_student_extraActivity(bel_Student bel)
        {
            return dal.bind_student_extraActivity(bel);
        }

        public DataTable Bind_gvstudent_extraActivity(bel_Student bel)
        {
            dal_Student dal = new dal_Student();

            return dal.Bind_gvstudent_extraActivity(bel);
        }

        //Reports Placed Unplaced Student
        //-----All Stud 1---------//
        public DataTable SelectAllPlace_Unplace_Stud_List()
        {
            return dal.SelectAllPlace_Unplace_Stud_List();
        }
        public DataTable SelectPlaced_Stud_List(bel_Student bal)
        {
            return dal.SelectPlaced_Stud_List(bal);
        }
        public DataTable Select_Unplace_Stud_List(bel_Student bal)
        {
            return dal.Select_Unplace_Stud_List(bal);
        }

        //-------Yearly Stud 2------//
        public DataTable SelectAllYear_Wise(bel_Student bal)
        {
            return dal.SelectAllYear_Wise(bal);
        }
        public DataTable Year_WisePlaced(bel_Student bal)
        {
            return dal.Year_WisePlaced(bal);
        }
        public DataTable Year_WiseUnplaced(bel_Student bal)
        {
            return dal.Year_WiseUnplaced(bal);
        }

        //-------Yearly Stud 3------//
        public DataTable SelectAllDept_Wise(bel_Student bal)
        {
            return dal.SelectAllDept_Wise(bal);
        }
        public DataTable Dept_WisePlaced(bel_Student bal)
        {
            return dal.Dept_WisePlaced(bal);
        }
        public DataTable Dept_WiseUnPlaced(bel_Student bal)
        {
            return dal.Dept_WiseUnPlaced(bal);
        }

        //-------Yearly Stud 4------//
        public DataTable SelectAllDrive_Wise(bel_Student bal)
        {
            return dal.SelectAllDrive_Wise(bal);
        }
        public DataTable Drive_WisePlaced(bel_Student bal)
        {
            return dal.Drive_WisePlaced(bal);
        }
        public DataTable Drive_WiseUnPlaced(bel_Student bal)
        {
            return dal.Drive_WiseUnPlaced(bal);
        }

        //-------Yearly Stud 5------//
        public DataTable Select_year_Dept_Wise(bel_Student bal)
        {
            return dal.Select_year_Dept_Wise(bal);
        }
        public DataTable year_Dept_Wise_Placed(bel_Student bal)
        {
            return dal.year_Dept_Wise_Placed(bal);
        }
        public DataTable year_Dept_Wise_UnPlaced(bel_Student bal)
        {
            return dal.year_Dept_Wise_UnPlaced(bal);
        }

        //-------Yearly Dept Stud 6------//
        public DataTable Select_year_Drive_Wise(bel_Student bal)
        {
            return dal.Select_year_Drive_Wise(bal);
        }
        public DataTable year_Drive_Wise_Placed(bel_Student bal)
        {
            return dal.year_Drive_Wise_Placed(bal);
        }
        public DataTable year_Drive_Wise_UnPlaced(bel_Student bal)
        {
            return dal.year_Drive_Wise_UnPlaced(bal);
        }

        //-----Company wise Stud---------//
        public DataTable Select_Company_wise_Stud(bel_Student bal)
        {
            return dal.Select_Company_wise_Stud(bal);
        }
        public DataTable Select_Company_wise_Placed_Stud(bel_Student bal)
        {
            return dal.Select_Company_wise_Placed_Stud(bal);
        }
        public DataTable Select_Company_wise_UnPlaced_Stud(bel_Student bal)
        {
            return dal.Select_Company_wise_UnPlaced_Stud(bal);
        }

        //-------Yearly & Company Stud------//
        public DataTable Select_Company_Year_Wise_Stud(bel_Student bal)
        {
            return dal.Select_Company_Year_Wise_Stud(bal);
        }
        public DataTable Select_Company_Year_Wise_Placed_Stud(bel_Student bal)
        {
            return dal.Select_Company_Year_Wise_Placed_Stud(bal);
        }
        public DataTable Select_Company_Year_Wise_UnPlaced_Stud(bel_Student bal)
        {
            return dal.Select_Company_Year_Wise_UnPlaced_Stud(bal);
        }
    }
}
