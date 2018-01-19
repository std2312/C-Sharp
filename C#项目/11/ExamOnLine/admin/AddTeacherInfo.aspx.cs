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
public partial class admin_AddTeacherInfo : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["admin"] == null)
        {
            Response.Redirect("../Login.aspx");
        }
        if (!IsPostBack)
        {
            SqlConnection conn = BaseClass.DBCon();
            conn.Open();
            SqlCommand cmd = new SqlCommand("select * from tb_Lesson", conn);
            SqlDataReader sdr = cmd.ExecuteReader();
            ddlTeacherKm.DataSource = sdr;
            ddlTeacherKm.DataTextField = "LessonName";
            ddlTeacherKm.DataValueField = "ID";
            ddlTeacherKm.DataBind();
            ddlTeacherKm.SelectedIndex = 0;
            conn.Close();
        }
    }
    protected void btnAdd_Click(object sender, EventArgs e)
    {
        if (txtTeacherName.Text == "" || txtTeacherNum.Text == "" || txtTeacherPwd.Text == "")
        {
            MessageBox.Show("请将信息填写完整");
            return;
        }
        else
        {
            SqlConnection conn = BaseClass.DBCon();
            conn.Open();
            SqlCommand cmd = new SqlCommand("select count(*) from tb_Teacher where TeacherNum='" + txtTeacherNum.Text.Trim() + "'", conn);
            int t = Convert.ToInt32(cmd.ExecuteScalar());
            if (t > 0)
            {
                MessageBox.Show("此教师编号已经存在");
                return;
            }
            else
            {
                string str = "insert into tb_Teacher(TeacherNum,TeacherName,TeacherPwd,TeacherCourse) values('" + txtTeacherNum.Text.Trim() + "','" + txtTeacherName.Text.Trim() + "','" + txtTeacherPwd.Text.Trim() + "','" + ddlTeacherKm.SelectedValue.ToString() + "')";
                BaseClass.OperateData(str);
                MessageBox.Show("教师信息添加成功");
                btnconcel_Click(sender, e);
            }
        }
    }
    protected void btnconcel_Click(object sender, EventArgs e)
    {
        txtTeacherPwd.Text = "";
        txtTeacherNum.Text = "";
        txtTeacherName.Text = "";
    }
}
