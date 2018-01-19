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
public partial class teacher_TExaminationDetail : System.Web.UI.Page
{
    private static int id;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["teacher"] == null)
        {
            Response.Redirect("../Login.aspx");
        }
        if (!IsPostBack)
        {
            id = Convert.ToInt32(Request.QueryString["Eid"]);
            SqlConnection conn = BaseClass.DBCon();
            conn.Open();
            SqlCommand cmd = new SqlCommand("select * from tb_test where ID=" + id, conn);
            SqlDataReader sdr = cmd.ExecuteReader();
            sdr.Read();
            txtsubject.Text = sdr["testContent"].ToString();
            txtAnsA.Text = sdr["testAns1"].ToString();
            txtAnsB.Text = sdr["testAns2"].ToString();
            txtAnsC.Text = sdr["testAns3"].ToString();
            txtAnsD.Text = sdr["testAns4"].ToString();
            rblRightAns.SelectedValue = sdr["rightAns"].ToString();
            string fb = sdr["pub"].ToString();
            if (fb == "1")
                cbFB.Checked = true;
            else
                cbFB.Checked = false;
            lblkm.Text = sdr["testCourse"].ToString();
            sdr.Close();
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
            string str = "update tb_test set testContent='" + txtsubject.Text.Trim() + "',testAns1='" + txtAnsA.Text.Trim() + "',testAns2='" + txtAnsB.Text.Trim() + "',testAns3='" + txtAnsC.Text.Trim() + "',testAns4='" + txtAnsD.Text + "',rightAns='" + rblRightAns.SelectedValue.ToString() + "',pub='" + isfb + "' where ID=" + id;
            BaseClass.OperateData(str);
            Response.Redirect("TExaminationInfo.aspx");
        }
    }
    protected void btnconcel_Click(object sender, EventArgs e)
    {
        Response.Redirect("TExaminationInfo.aspx");
    }
}
