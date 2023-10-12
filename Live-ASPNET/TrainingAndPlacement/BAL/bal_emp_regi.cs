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
    public class bal_emp_regi
    {
        public Int32 emp_regi(bel_emp_regi bel_er)
        {

            dal_emp_regi dal_regi = new dal_emp_regi();
            try
            {
                return dal_regi.add_emp(bel_er);
            }
            catch (Exception ex)
            {
                throw;
            }
            finally
            {
                dal_regi = null;
            }
        }

        public Int32 emp_update(bel_emp_regi bel_er)
        {
            dal_emp_regi dal_empupdate = new dal_emp_regi();
            try
            {
                return dal_empupdate.update_emp(bel_er);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                dal_empupdate = null;
            }
        }

        public DataSet bind_ID_wise(bel_emp_regi bel_er)
        {
            dal_emp_regi dal_emp_select = new dal_emp_regi();
            try
            {
                return dal_emp_select.bind_ID_wise(bel_er);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                dal_emp_select = null;
            }
        }

        public DataSet Bind_Email_Id_Wise(bel_emp_regi bel_er)
        {
            dal_emp_regi dal_emp_select = new dal_emp_regi();
            // dal_emp_regi dal_empupdate = new dal_emp_regi();
            try
            {
                return dal_emp_select.Bind_Email_Id_Wise(bel_er);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                dal_emp_select = null;
            }
        }
        public DataSet Select_AllStaff()
        {
            dal_emp_regi dal_emp_select = new dal_emp_regi();
            try
            {
                return dal_emp_select.Select_AllStaff();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                dal_emp_select = null;
            }
        }
        public DataSet DesignationWise_Staff(bel_emp_regi bel_er)
        {
            dal_emp_regi dal_emp_select = new dal_emp_regi();
            try
            {
                return dal_emp_select.DesignationWise_Staff(bel_er);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                dal_emp_select = null;
            }
        }
    }
}
