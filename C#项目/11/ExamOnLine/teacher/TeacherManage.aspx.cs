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
public partial class teacher_TeacherManage : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["teacher"] == null)
        {
            Response.Redirect("../Login.aspx");
        }
        else
        {
            lblwz.Text = Session["teacher"].ToString();
            SqlConnection conn = BaseClass.DBCon();
            conn.Open();
            SqlCommand cmd = new SqlCommand("select * from tb_Teacher where TeacherNum='" + lblwz.Text + "'", conn);
            SqlDataReader sdr = cmd.ExecuteReader();
            sdr.Read();
            lblname.Text = sdr["TeacherName"].ToString();
            int id = Convert.ToInt32(sdr["TeacherCourse"].ToString());
            sdr.Close();
            cmd = new SqlCommand("select LessonName from tb_Lesson where ID=" + id, conn);
            lblkc.Text = cmd.ExecuteScalar().ToString();
            Session["KCname"] = lblkc.Text;
            conn.Close();
        }
    }
    protected void LinkButton1_Click(object sender, EventArgs e)
    {
        Response.Redirect("TLogout.aspx");
    }
}
