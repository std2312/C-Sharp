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
public partial class admin_TeacherInfo : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["admin"] == null)
        {
            Response.Redirect("../Login.aspx");
        }
        if (!IsPostBack)
        {
            string strsql = "select * from tb_Teacher order by ID desc";
            BaseClass.BindDG(gvTeacher, "ID", strsql, "teacher");
        }
    }
    public string GetKmName(int num)
    {
        SqlConnection conn = BaseClass.DBCon();
        conn.Open();
        SqlCommand cmd = new SqlCommand("select LessonName from tb_Lesson where ID=" + num, conn);
        string kname = cmd.ExecuteScalar().ToString();
        return kname;
    }
    protected void gvTeacher_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {
        int id = (int)gvTeacher.DataKeys[e.RowIndex].Value;
        string str = "delete from tb_Teacher where ID=" + id;
        BaseClass.OperateData(str);
        string strsql = "select * from tb_Teacher order by ID desc";
        BaseClass.BindDG(gvTeacher, "ID", strsql, "teacher");
    }
    protected void gvTeacher_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        gvTeacher.PageIndex = e.NewPageIndex;
        string strsql = "select * from tb_Teacher order by ID desc";
        BaseClass.BindDG(gvTeacher, "ID", strsql, "teacher");
    }
}
