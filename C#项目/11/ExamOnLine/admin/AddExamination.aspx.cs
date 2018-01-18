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
public partial class admin_AddExamination : System.Web.UI.Page
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
            this.ddlkm.DataSource = sdr;
            this.ddlkm.DataTextField = "LessonName";
            this.ddlkm.DataValueField = "ID";
            this.ddlkm.DataBind();
            this.ddlkm.SelectedIndex = 0;
            conn.Close();
        }
    }
    protected void btnconfirm_Click(object sender, EventArgs e)
    {
        if (txtsubject.Text == "" || txtAnsA.Text == "" || txtAnsB.Text == "" || txtAnsC.Text == "" || txtAnsD.Text == "")
        {
            MessageBox.Show("请将信息填写完整");
            return;
        }
        else
        {
            string isfb = "";
            if (cbFB.Checked == true)
                isfb = "1";
            else
                isfb = "0";
            string str = "insert into tb_test(testContent,testAns1,testAns2,testAns3,testAns4,rightAns,pub,testCourse) values('" + txtsubject.Text.Trim() + "','" + txtAnsA.Text.Trim() + "','" + txtAnsB.Text.Trim() + "','" + txtAnsC.Text.Trim() + "','" + txtAnsD.Text.Trim() + "','" + rblRightAns.SelectedValue.ToString() + "','" + isfb + "','" + ddlkm.SelectedItem.Text + "')";
            BaseClass.OperateData(str);
            btnconcel_Click(sender, e);
        }
    }
    protected void btnconcel_Click(object sender, EventArgs e)
    {
        txtsubject.Text = "";
        txtAnsD.Text = "";
        txtAnsC.Text = "";
        txtAnsB.Text = "";
        txtAnsA.Text = "";
    }
}
