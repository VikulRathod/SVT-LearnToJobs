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
    public class bal_Institute
    {
        dal_Institute dal_regi1 = new dal_Institute();
        public Int32 Institute_regi(bel_Institute bel_er)
        {

            try
            {
                return dal_regi1.add_Institute_prof(bel_er);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                bel_er = null;
                dal_regi1 = null;
            }
        }

        public System.Data.DataSet select(bel_Institute bel_cp)
        {
            try
            {
                return dal_regi1.select(bel_cp);
                throw new NotImplementedException();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                bel_cp = null;
                dal_regi1 = null;
            }
        }
    }
}
