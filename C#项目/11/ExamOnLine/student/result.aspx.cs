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
public partial class student_result : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        string Rans = Session["Ans"].ToString();//正确答案
        int j = Convert.ToInt32(Request.QueryString["BInt"]);
        string Sans = Session["Sans"].ToString();
        int StuScore = 0;
        for (int i = 0; i < j; i++)
        {
            if (Rans.Substring(i, 1).Equals(Sans.Substring(i, 1)))
            {
                StuScore += 2;
            }
        }
        this.lblResult.Text = StuScore.ToString();
        this.lblkm.Text = Session["KM"].ToString();
        this.lblnum.Text = Session["ID"].ToString();
        this.lblname.Text = Session["name"].ToString();
        string strsql = "update tb_score set score='" + StuScore.ToString() + "' where StudentID='" + Session["ID"].ToString() + "' and LessonName='" + Session["KM"].ToString() + "'";
        BaseClass.OperateData(strsql);
    }
}
