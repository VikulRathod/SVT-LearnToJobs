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
    public class bal_Drive
    {
        dal_Drive dal_D = new dal_Drive();

        public Int32 add_Drive(bel_Derive bel_er)
        {
            try
            {
                return dal_D.add_Drive(bel_er);
            }
            catch (Exception ex)
            {
                throw;
            }
            finally
            {
                dal_D = null;
            }
        }
        public Int32 update_Drive(bel_Derive bel)
        {
            try
            {
                return dal_D.update_Drive(bel);
            }
            catch (Exception ex)
            {
                throw;
            }
            finally
            {
                dal_D = null;
            }
        }
        public Int32 update_Status(bel_Derive bel)
        {
            try
            {
                return dal_D.update_Status(bel);
            }
            catch (Exception ex)
            {
                throw;
            }
            finally
            {
                dal_D = null;
            }
        }
        public DataTable Place_Drive()
        {
            return dal_D.Place_Drive();
        }
        //-------Drive--Criteria----//
        public Int32 Add_Drive_Criteria(bel_Student bel)
        {
            try
            {
                return dal_D.Add_Drive_Criteria(bel);
            }
            catch (Exception ex)
            {
                throw;
            }
            finally
            {
                dal_D = null;
            }
        }

        public Int32 Update_Drive_Criteria(bel_Student bel)
        {
            try
            {
                return dal_D.Update_Drive_Criteria(bel);
            }
            catch (Exception ex)
            {
                throw;
            }
            finally
            {
                dal_D = null;
            }
        }
        //--------end--Drive---Criteria---//
        public Int32 Add_Drive_Schedule(bel_Derive bel_er)
        {
            try
            {
                return dal_D.Add_Drive_Schedule(bel_er);
            }
            catch (Exception ex)
            {
                throw;
            }
            finally
            {
                dal_D = null;
            }
        }
        public Int32 update_Drive_Schedule(bel_Derive bel_er)
        {
            try
            {
                return dal_D.update_Drive_Schedule(bel_er);
            }
            catch (Exception ex)
            {
                throw;
            }
            finally
            {
                dal_D = null;
            }

        }
        public DataSet Bind_Schedule(bel_Derive bel_er)
        {
            try
            {
                return dal_D.Bind_Schedule(bel_er);
            }
            catch (Exception ex)
            {
                throw;
            }
            finally
            {
                dal_D = null;
            }

        }
        public DataSet Bind_Round_Drive_Schedule(bel_Derive bel_er)
        {
            try
            {
                return dal_D.Bind_Round_Drive_Schedule(bel_er);
            }
            catch (Exception ex)
            {
                throw;
            }
            finally
            {
                dal_D = null;
            }
        }
        public Int32 Add_TotalMarks(bel_Derive bel)
        {
            try
            {
                return dal_D.Add_TotalMarks(bel);
            }
            catch (Exception ex)
            {
                throw;
            }
            finally
            {
                dal_D = null;
            }
        }
    }
}
