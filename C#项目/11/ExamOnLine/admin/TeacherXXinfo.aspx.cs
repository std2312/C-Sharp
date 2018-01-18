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
public partial class admin_TeacherXXinfo : System.Web.UI.Page
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
            id = Convert.ToInt32(Request.QueryString["Tid"]);
            SqlConnection conn = BaseClass.DBCon();
            conn.Open();
            SqlCommand cmd = new SqlCommand("select * from tb_Teacher where ID=" + id, conn);
            SqlDataReader sdr = cmd.ExecuteReader();
            sdr.Read();
            txtTName.Text = sdr["TeacherName"].ToString();
            txtTNum.Text = sdr["TeacherNum"].ToString();
            txtTPwd.Text = sdr["TeacherPwd"].ToString();
            int kmid = Convert.ToInt32(sdr["TeacherCourse"].ToString());
            sdr.Close();
            cmd = new SqlCommand("select LessonName from tb_Lesson where ID=" + kmid, conn);
            string KmName = cmd.ExecuteScalar().ToString();
            cmd = new SqlCommand("select * from tb_Lesson", conn);
            sdr = cmd.ExecuteReader();
            ddlTKm.DataSource = sdr;
            ddlTKm.DataTextField = "LessonName";
            ddlTKm.DataValueField = "ID";
            ddlTKm.DataBind();
            ddlTKm.SelectedValue = kmid.ToString();
            conn.Close();
        }
    }
    protected void btnSava_Click(object sender, EventArgs e)
    {
        if (txtTName.Text == "" || txtTPwd.Text == "")
        {
            MessageBox.Show("请将信息填写完整");
            return;
        }
        else
        {
            string strsql = "update tb_Teacher set TeacherName='" + txtTName.Text.Trim() + "',TeacherPwd='" + txtTPwd.Text.Trim() + "',TeacherCourse='" + ddlTKm.SelectedValue.ToString() + "' where ID=" + id;
            BaseClass.OperateData(strsql);
            Response.Redirect("TeacherInfo.aspx");
        }
    }
    protected void btnConcel_Click(object sender, EventArgs e)
    {
        Response.Redirect("TeacherInfo.aspx");
    }
}
