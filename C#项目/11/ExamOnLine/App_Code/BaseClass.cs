using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Data.SqlClient;
/// <summary>
/// BaseClass 的摘要说明
/// </summary>
public class BaseClass
{
	public BaseClass()
	{
		//
		// TODO: 在此处添加构造函数逻辑
		//
	}
    public static SqlConnection DBCon()
    {
        return new SqlConnection("server=.;database=db_ExamOnline;uid=sa;pwd=");
    }

    public static void BindDG(GridView dg, string id, string strSql, string Tname)
    {
        SqlConnection conn = DBCon();
        SqlDataAdapter sda = new SqlDataAdapter(strSql, conn);
        DataSet ds = new DataSet();
        sda.Fill(ds, Tname);
        dg.DataSource = ds.Tables[Tname];
        dg.DataKeyNames = new string[] { id };
        dg.DataBind();
    }
    public static void OperateData(string strsql)
    {
        SqlConnection conn = DBCon();
        conn.Open();
        SqlCommand cmd = new SqlCommand(strsql, conn);
        cmd.ExecuteNonQuery();
        conn.Close();
    }
    //================如果是学生登录=========================================
    public static bool CheckStudent(string studentNum, string studentPwd)
    {
        SqlConnection conn = DBCon();
        conn.Open();
        SqlCommand cmd = new SqlCommand("select count(*) from tb_Student where StudentNum='" + studentNum + "' and StudentPwd='" + studentPwd + "'", conn);
        int i = Convert.ToInt32(cmd.ExecuteScalar());
        if (i > 0)
        {
            return true;
        }
        else
        {
            return false;
        }
        conn.Close();
    }
    //================如果是教师登录=========================================
    public static bool CheckTeacher(string teacherNum, string teacherPwd)
    {
        SqlConnection conn = DBCon();
        conn.Open();
        SqlCommand cmd = new SqlCommand("select count(*) from tb_Teacher where TeacherNum='" + teacherNum + "' and TeacherPwd='" + teacherPwd + "'", conn);
        int i = Convert.ToInt32(cmd.ExecuteScalar());
        if (i > 0)
        {
            return true;
        }
        else
        {
            return false;
        }
        conn.Close();
    }
    //================如果是管理员登录=========================================
    public static bool CheckAdmin(string adminNum, string adminPwd)
    {
        SqlConnection conn = DBCon();
        conn.Open();
        SqlCommand cmd = new SqlCommand("select count(*) from tb_Admin where AdminNum='" + adminNum + "' and adminPwd='" + adminPwd + "'", conn);
        int i = Convert.ToInt32(cmd.ExecuteScalar());
        if (i > 0)
        {
            return true;
        }
        else
        {
            return false;
        }
        conn.Close();
    }
}
