using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
namespace TrainingAndPlacement
{
    public partial class Site : System.Web.UI.MasterPage
    {
        SqlConnection con = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["myConnectionString"].ConnectionString);
        SqlCommand cmd = new SqlCommand();
        protected void Page_Load(object sender, EventArgs e)
        {
            //bind_profile();
        }
        //protected void bind_profile()
        //{
        //    try
        //    {
        //        cmd = new SqlCommand("Institute_Details", con);
        //        cmd.CommandType = CommandType.StoredProcedure;
        //        cmd.Parameters.AddWithValue("@flag", 3);
        //        DataSet ds = new DataSet();
        //        SqlDataAdapter sda = new SqlDataAdapter(cmd);
        //        sda.Fill(ds);
        //        if (ds.Tables[0].Rows.Count > 0)
        //        {
        //            txtcompany.Text = ds.Tables[0].Rows[0][1].ToString();
        //            Institute.Text = ds.Tables[0].Rows[0][1].ToString();
        //            email.Text = ds.Tables[0].Rows[0][3].ToString();
        //            web.Text = ds.Tables[0].Rows[0][4].ToString();
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        Response.Write("Oops! error occured :" + ex.Message.ToString());
        //    }
        //}
    }
}