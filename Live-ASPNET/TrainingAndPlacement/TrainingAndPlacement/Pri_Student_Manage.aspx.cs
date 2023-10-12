using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.IO;
using BAL;
using BEL;
using System.Data.SqlClient;
using System.Configuration;
namespace TrainingAndPlacement
{
    public partial class Pri_Student_Manage : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myConnectionString"].ConnectionString);
        bal_Student bal = new bal_Student();
        bel_Student bel = new bel_Student();
        bal_Dept bal_D = new bal_Dept();
        string filename;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                all_regi_mem();
                bind_Department();
            }
        }
        protected void all_regi_mem()
        {
            try
            {
                DataSet dtbl = bal.selectAll(); //bind table
                gvregi_mem.DataSource = dtbl;
                gvregi_mem.DataBind();
            }
            catch (Exception ex)
            {
                Response.Write("Oops! error occured :" + ex.Message.ToString());
            }
        }
        protected void bind_Department()
        {
            {
                DataSet ds = bal_D.gvDepartment_Bind();
                ddlCourse.DataSource = ds;
                ddlCourse.DataTextField = "Department";
                ddlCourse.DataValueField = "Id";
                ddlCourse.DataBind();
                ddlCourse.Items.Insert(0, new ListItem("---Select----", string.Empty));
            }
        }
        protected void Search_Click(object sender, EventArgs e)
        {

            bel.bel_Academic_Year = ddlAcademic.SelectedItem.ToString();
            bel.bel_Course_Name = ddlCourse.SelectedValue;
            DataSet ds = bal.bindStudent_Year_Dept_wise(bel);
            if (ds.Tables[0].Rows.Count > 0)
            {
                gvregi_mem.DataSource = ds;
                gvregi_mem.DataBind();
            }
            else
            {
                string script = "alert(\"Record not available!\");"; ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
            }
        }
        protected void btnSend_Click(object sender, EventArgs e)
        {
            int i = 1, j = 1;
            foreach (GridViewRow item in gvregi_mem.Rows)
            {
                try
                {
                    if (item.Cells[4].Text != "" && item.Cells[4].Text != "&nbsp;" && item.Cells[4].Text != null)
                    {
                        Session["Send_Email"] += item.Cells[4].Text;
                    }
                    if (j < gvregi_mem.Rows.Count)
                    {
                        Session["Send_Email"] = Session["Send_Email"] + ";";
                        j++;
                    }
                    if (item.Cells[5].Text != "" && item.Cells[5].Text != "&nbsp;" && item.Cells[5].Text != null)
                    {
                        Session["Send_SMS"] += item.Cells[5].Text;
                    }
                    if (i < gvregi_mem.Rows.Count)
                    {
                        Session["Send_SMS"] = Session["Send_SMS"] + ",";
                        i++;
                    }
                }
                catch (Exception ex)
                {
                    Response.Write("Oops! error occured :" + ex.Message.ToString());
                }
            }
            Response.Redirect("Send_Notification.aspx");
        }
    }
}