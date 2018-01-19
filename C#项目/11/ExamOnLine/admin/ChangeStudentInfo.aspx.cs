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
public partial class admin_ChangeStudentInfo : System.Web.UI.Page
{
    private static int id;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["admin"] == null)
        {
            Response.Redirect("../Login.aspx");
        }
        if (!IsPostBack)
        {
            id = Convert.ToInt32(Request.QueryString["stuid"]);
            SqlConnection conn = BaseClass.DBCon();
            conn.Open();
            SqlCommand cmd = new SqlCommand("select * from tb_Student where ID=" + id, conn);
            SqlDataReader sdr = cmd.ExecuteReader();
            sdr.Read();
            txtStuName.Text = sdr["StudentName"].ToString();
            txtStuNum.Text = sdr["StudentNum"].ToString();
            txtStuPwd.Text = sdr["StudentPwd"].ToString();
            rblSex.SelectedValue = sdr["StudentSex"].ToString();
            sdr.Close();
            conn.Close();
        }
    }
    protected void btnSava_Click(object sender, EventArgs e)
    {
        if (txtStuName.Text.Trim() == "" || txtStuPwd.Text.Trim() == "")
        {
            MessageBox.Show("请将信息填写完整");
            return;
        }
        else
        {
            string str = "update tb_Student set StudentName='" + txtStuName.Text.Trim() + "',StudentPwd='" + txtStuPwd.Text.Trim() + "',StudentSex='" + rblSex.SelectedItem.Text + "' where ID=" + id;
            BaseClass.OperateData(str);
            Response.Redirect("StudentInfo.aspx");
        }
    }
    protected void btnConcel_Click(object sender, EventArgs e)
    {
        Response.Redirect("StudentInfo.aspx");
    }
}
