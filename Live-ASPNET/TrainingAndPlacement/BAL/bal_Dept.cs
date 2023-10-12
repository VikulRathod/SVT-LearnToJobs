using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAL;
using BEL;
namespace BAL
{
    public class bal_Dept
    {
        dal_Dept dal = new dal_Dept();

        public Int32 add_Department(bel_Dept bel_er)
        {
            dal_Dept dal = new dal_Dept();
            try
            {
                return dal.add_Department(bel_er);
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
        public Int32 update_Department(bel_Dept bel)
        {
            dal_Dept dal = new dal_Dept();
            try
            {
                return dal.update_Department(bel);
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
        public DataSet gvDepartment_Bind()
        {
            dal_Dept dal = new dal_Dept();
            try
            {
                return dal.gvDepartment_Bind();
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
        public DataSet Delete_Department(bel_Dept bel)
        {
            dal_Dept dal = new dal_Dept();
            try
            {
                return dal.Delete_Department(bel);
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
    }
}
