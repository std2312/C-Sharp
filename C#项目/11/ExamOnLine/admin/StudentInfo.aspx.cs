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
public partial class admin_StudentInfo : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["admin"] == null)
        {
            Response.Redirect("../Login.aspx");
        }
        if (!IsPostBack)
        {
            string strsql = "select * from tb_Student order by ID desc";
            BaseClass.BindDG(gvStuInfo, "ID", strsql, "stuinfo");
        }
    }
    protected void btnserch_Click(object sender, EventArgs e)
    {
        if (txtKey.Text == "")
        {
            string strsql = "select * from tb_Student order by ID desc";
            BaseClass.BindDG(gvStuInfo, "ID", strsql, "stuinfo");
        }
        else
        {
            string stype = ddlType.SelectedItem.Text;
            string strsql = "";
            switch (stype)
            {
                case "学号":
                    strsql = "select * from tb_Student where StudentNum like '%" + txtKey.Text.Trim() + "%'";
                    BaseClass.BindDG(gvStuInfo, "ID", strsql, "stuinfo"); ;
                    break;
                case "姓名":
                    strsql = "select * from tb_Student where StudentName like '%" + txtKey.Text.Trim() + "%'";
                    BaseClass.BindDG(gvStuInfo, "ID", strsql, "stuinfo");
                    break;
            }
        }
    }
    protected void gvStuInfo_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {
        int id = (int)gvStuInfo.DataKeys[e.RowIndex].Value;
        string str = "delete from tb_Student where ID=" + id;
        BaseClass.OperateData(str);
        string strsql = "select * from tb_Student order by ID desc";
        BaseClass.BindDG(gvStuInfo, "ID", strsql, "stuinfo");
    }
    protected void gvStuInfo_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        gvStuInfo.PageIndex = e.NewPageIndex;
        string strsql = "select * from tb_Student order by ID desc";
        BaseClass.BindDG(gvStuInfo, "ID", strsql, "stuinfo");
    }
}
