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
public partial class admin_ExaminationInfo : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["admin"] == null)
        {
            Response.Redirect("../Login.aspx");
        }
        if (!IsPostBack)
        {
            string strsql = "select * from tb_test order by ID desc";
            BaseClass.BindDG(gvExaminationInfo, "ID", strsql, "ExaminationInfo");
            SqlConnection conn = BaseClass.DBCon();
            conn.Open();
            SqlCommand cmd = new SqlCommand("select * from tb_Lesson", conn);
            SqlDataReader sdr = cmd.ExecuteReader();
            this.ddlEkm.DataSource = sdr;
            this.ddlEkm.DataTextField = "LessonName";
            this.ddlEkm.DataValueField = "ID";
            this.ddlEkm.DataBind();
            this.ddlEkm.SelectedIndex = 0;
            conn.Close();
        }
    }
    public string Getstatus(string zt)
    {
        if (zt == "0")
            return "否";
        else
            return "是";
    }
    protected void btnSerch_Click(object sender, EventArgs e)
    {
        string strsql = "select * from tb_test where testCourse='" + ddlEkm.SelectedItem.Text + "'";
        BaseClass.BindDG(gvExaminationInfo, "ID", strsql, "Result");
        lbltype.Text = ddlEkm.SelectedItem.Text;
    }
    protected void gvExaminationInfo_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {
        int id = (int)gvExaminationInfo.DataKeys[e.RowIndex].Value;
        string sql = "delete from tb_test where ID=" + id;
        BaseClass.OperateData(sql);
        string strsql = "select * from tb_test order by ID desc";
        BaseClass.BindDG(gvExaminationInfo, "ID", strsql, "ExaminationInfo");
    }
    protected void gvExaminationInfo_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        gvExaminationInfo.PageIndex = e.NewPageIndex;
        string strsql = "select * from tb_test order by ID desc";
        BaseClass.BindDG(gvExaminationInfo, "ID", strsql, "ExaminationInfo");
    }
}
