using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using BEL;
using DAL;
namespace BAL
{
    public class bal_login
    {
        dal_login dal_login = new dal_login();

        public Int32 login_insert(bel_login bel_er)
        {

            try
            {
                return dal_login.login_insert(bel_er);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                dal_login = null;
            }
        }

        public Int32 login_update(bel_login bel_er)
        {

            try
            {
                return dal_login.login_update(bel_er);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                dal_login = null;
            }
        }

        public Int32 login_status_update(bel_login bel_er)
        {
            dal_login dal_login = new dal_login();
            return dal_login.login_status_update(bel_er);
        }
        public DataSet select_user(bel_login bel_er)
        {
            return dal_login.select_user(bel_er);
        }
        public DataSet select_All(bel_login bel_er)
        {
            return dal_login.select_All(bel_er);
        }
        public DataSet select_AllStaff(bel_login bel_er)
        {
            return dal_login.select_AllStaff(bel_er);
        }
        public DataSet select_Staff(bel_login bel_er)
        {
            return dal_login.select_Staff(bel_er);
        }
    }
}
