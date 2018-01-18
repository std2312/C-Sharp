using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Data.SqlClient;
public partial class admin_AdminManage : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["admin"] == null)
        {
            Response.Redirect("../Login.aspx");
        }
        else
        {
            lblwz.Text = Session["admin"].ToString();
            SqlConnection conn = BaseClass.DBCon();
            conn.Open();
            SqlCommand cmd = new SqlCommand("select AdminName from tb_Admin where AdminNum='" + lblwz.Text + "'", conn);
            lblname.Text = cmd.ExecuteScalar().ToString();
            conn.Close();
        }
    }
    protected void LinkButton1_Click(object sender, EventArgs e)
    {
        Response.Redirect("Logout.aspx");
    }
}
