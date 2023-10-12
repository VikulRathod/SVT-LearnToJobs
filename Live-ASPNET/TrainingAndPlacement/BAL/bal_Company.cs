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
    public class bal_Company
    {
        dal_Company bal_Add = new dal_Company();

        public Int32 Add_Company(bel_Company bel)
        {
            try
            {
                return bal_Add.Add_Company(bel);
            }
            catch (Exception ex)
            {
                throw;
            }
            finally
            {
                bal_Add = null;
            }
        }
        public int Update_Company(bel_Company bel)
        {
            try
            {
                return bal_Add.Update_Company(bel);
            }
            catch (Exception ex)
            {
                throw;
            }
            finally
            {
                bal_Add = null;
            }
        }
        public DataSet Select_Add_Update_Company(bel_Company bel)
        {
            try
            {
                return bal_Add.Select_Add_Update_Company(bel);
            }
            catch (Exception ex)
            {
                throw;
            }
            finally
            {
                bal_Add = null;
            }
        }
        public DataSet bind_All_Company(bel_Company bel)
        {
            try
            {
                return bal_Add.bind_All_Company(bel);
            }
            catch (Exception ex)
            {
                throw;
            }
            finally
            {
                bal_Add = null;
            }

        }
        public DataSet Select_rptCompany_Registration(bel_Company bel)
        {
            try
            {
                return bal_Add.Select_rptCompany_Registration(bel);
            }
            catch (Exception ex)
            {
                throw;
            }
            finally
            {
                bal_Add = null;
            }
        }
    }
}
