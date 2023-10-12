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
    public class bal_message
    {
        public DataSet bind_grid()// bind grid all
        {
            dal_message msg = new dal_message();
            try
            {
                return msg.bind_grid();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            { msg = null; }
        }

        public DataTable bind_grid_members()// bind all members
        {
            dal_message msg = new dal_message();
            try
            {
                return msg.bind_grid_members();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            { msg = null; }
        }
        public DataTable bind_Regi_Renewal_members()// bind all members registration and renewal Detail
        {
            dal_message msg = new dal_message();
            try
            {
                return msg.bind_Regi_Renewal_members();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            { msg = null; }
        }
        public DataTable bind_grid_trainners()// bind all trainners
        {
            dal_message msg = new dal_message();
            try
            {
                return msg.bind_grid_trainners();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                msg = null;
            }
        }

        public Int32 add_event(bel_message bel)
        {

            dal_message msg = new dal_message();
            try
            {
                return msg.add_event(bel);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                msg = null;
            }
        }

        public DataTable bind_ddlevent()// bind ddl event
        {
            dal_message msg = new dal_message();
            try
            {
                return msg.bind_ddlevent();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            { msg = null; }
        }

        public DataSet GetElement(bel_message bel_msg)
        {
            dal_message msg = new dal_message();
            return msg.GetElement(bel_msg);
            throw new NotImplementedException();
        }

        public DataTable gridbind_byempid(bel_message bel_msg)
        {
            dal_message msg = new dal_message();
            try
            {
                return msg.binggrid_byempid(bel_msg);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            throw new NotImplementedException();
        }

        public DataTable gridbind_bymemid(bel_message bel_msg)
        {
            dal_message dal_msg = new dal_message();
            try
            {
                return dal_msg.gridbind_bymemid(bel_msg);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            throw new NotImplementedException();
        }
        public DataTable gridbind_bymemclass(bel_message bel_msg)
        {
            dal_message dal_msg = new dal_message();
            try
            {
                return dal_msg.gridbind_bymemclass(bel_msg);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            throw new NotImplementedException();
        }
        public DataTable gridbind_bymemHouse_Colour(bel_message bel_msg)
        {
            dal_message dal_msg = new dal_message();
            try
            {
                return dal_msg.gridbind_bymemHouse_Colour(bel_msg);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            throw new NotImplementedException();
        }
        public DataTable gridbind_bymemclass_colour(bel_message bel_msg)
        {
            dal_message dal_msg = new dal_message();
            try
            {
                return dal_msg.gridbind_bymemclass_colour(bel_msg);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            throw new NotImplementedException();
        }
        public Int32 Insert_Notification(bel_message bel)
        {

            dal_message msg = new dal_message();
            try
            {
                return msg.Insert_Notification(bel);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                msg = null;
            }
        }
    }
}
