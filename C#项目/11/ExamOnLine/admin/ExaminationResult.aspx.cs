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
public partial class admin_ExaminationResult : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["admin"] == null)
        {
            Response.Redirect("../Login.aspx");
        }
        if (!IsPostBack)
        {
            string strsql = "select * from tb_score order by ID desc";
            BaseClass.BindDG(gvExaminationresult, "ID", strsql, "result");
        }
    }
    protected void gvExaminationInfo_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {
        int id = (int)gvExaminationresult.DataKeys[e.RowIndex].Value;
        string strsql = "delete from tb_score where ID=" + id;
        BaseClass.OperateData(strsql);
        string strsql1 = "select * from tb_score order by ID desc";
        BaseClass.BindDG(gvExaminationresult, "ID", strsql1, "result");
    }
    protected void gvExaminationresult_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        gvExaminationresult.PageIndex = e.NewPageIndex;
        string strsql = "select * from tb_score order by ID desc";
        BaseClass.BindDG(gvExaminationresult, "ID", strsql, "result");
    }
}
