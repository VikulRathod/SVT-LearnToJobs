using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.IO;
using System.Web.Services;
using System.Data.SqlClient;
using System.Globalization;
using System.Configuration;
using System.Text.RegularExpressions;
using BAL;
using BEL;

namespace TrainingAndPlacement
{
    public partial class Add_Dept : System.Web.UI.Page
    {
        DataSet ds = new DataSet();
        SqlConnection con = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["myConnectionString"].ConnectionString);
        bel_Dept bel = new bel_Dept();
        bal_Dept bal = new bal_Dept();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Bind_Department();
            }
        }

        protected void btnsave_Click(object sender, EventArgs e)
        {
            try
            {
                string str = "select count(*) from Add_Department where Department='" + txtDept_Name.Text + "'";
                SqlCommand cmd = new SqlCommand(str, con);
                con.Open();
                int count = (int)cmd.ExecuteScalar();
                con.Close();
                if (count <= 0)
                {
                    if (txtDept_Name.Text == "")
                    {
                        string script = "alert(\"Please Enter Department Name, PLease Retry!\");"; ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
                    }
                    else
                    {
                        bel.bel_Department = txtDept_Name.Text;

                        int result = bal.add_Department(bel);
                        if (result > 0)
                        {
                            txtDept_Name.Text = "";
                            Bind_Department();
                            string script = "alert(\"Department is Successfuly Add!\");"; ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
                        }
                        else
                        {
                            string script = "alert(\"Department is not Add !\");"; ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
                        }
                    }
                }
                else
                {
                    string script = "alert(\"Please Check Department Name already Exist!\");"; ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
                }

            }
            catch (Exception ex)
            {
                Response.Write("Oops! error occured :" + ex.Message.ToString());
            }
            finally
            {
                bal = null;
                bel = null;
            }
        }
        public void Bind_Department()
        {
            
            //DataSet ds = bal.gvDepartment_Bind();
            SqlCommand cmd = new SqlCommand("Department_Details", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@flag", 3);
            SqlDataAdapter adp1 = new SqlDataAdapter(cmd);
            adp1.Fill(ds);
            gvDepartment.DataSource = ds;
            gvDepartment.DataBind();
        }

       protected void gvDepartment_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {

            try
            {
                int idd = Convert.ToInt32(gvDepartment.DataKeys[e.RowIndex].Value);

                TextBox txtDepartment = gvDepartment.Rows[e.RowIndex].FindControl("txtDepartment") as TextBox;
                
                bel.bel_Id = idd;
                bel.bel_Department = txtDepartment.Text;

                int result = bal.update_Department(bel);

                gvDepartment.EditIndex = -1;
                Bind_Department();
            }
            catch (Exception ex)
            {
                Response.Write("Oops! error occured :" + ex.Message.ToString());
                //Response.Write("Oops! error occured :" + ex.Message.ToString());
            }
            finally
            {
                bal = null;
                bel = null;
            }

        }

        protected void gvDepartment_RowEditing(object sender, GridViewEditEventArgs e)
        {
            gvDepartment.EditIndex = e.NewEditIndex;

            Bind_Department();
        }

        protected void gvDepartment_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            gvDepartment.EditIndex = -1;
            Bind_Department();
        }

        protected void gvDepartment_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            try
            {
                int idd = Convert.ToInt32(gvDepartment.DataKeys[e.RowIndex].Value);

                bel.bel_Id = idd;
                DataSet ds = bal.Delete_Department(bel);
                Bind_Department();
            }
            catch (Exception ex)
            {
                Response.Write("Oops! error occured :" + ex.Message.ToString());
            }
            finally
            {
                bal = null;
                bel = null;
            }
        }

        
       
    }
}