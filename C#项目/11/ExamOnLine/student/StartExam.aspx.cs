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
public partial class student_StartExam : System.Web.UI.Page
{
    public string Ans = null;
    public int tNUM;
    protected void Page_Load(object sender, EventArgs e)
    {
            lblEndtime.Text = "考试时间为10分钟，每小题2分，考试已用时：";
            lblStuNum.Text = Session["ID"].ToString();
            lblStuName.Text = Session["name"].ToString();
            lblStuSex.Text = Session["sex"].ToString();
            lblStuKM.Text = "[" + Session["KM"].ToString() + "]" + "考试试题";
            int i = 1;
            SqlConnection conn = BaseClass.DBCon();
            conn.Open();
            SqlCommand cmd = new SqlCommand("select top 10 * from tb_test where testCourse='" + Session["KM"].ToString() + "' order by newid()", conn);
            SqlDataReader sdr = cmd.ExecuteReader();
            while (sdr.Read())
            {

                Literal littxt = new Literal();
                Literal litti = new Literal();
                RadioButtonList cbk = new RadioButtonList();
                cbk.ID = "cbk" + i.ToString();
                littxt.Text = i.ToString() + "、" + Server.HtmlEncode(sdr["testContent"].ToString()) + "<br><Blockquote>";
                litti.Text = "</Blockquote>";
                cbk.Items.Add("A. " + Server.HtmlEncode(sdr["testAns1"].ToString()));
                cbk.Items.Add("B. " + Server.HtmlEncode(sdr["testAns2"].ToString()));
                cbk.Items.Add("C. " + Server.HtmlEncode(sdr["testAns3"].ToString()));
                cbk.Items.Add("D. " + Server.HtmlEncode(sdr["testAns4"].ToString()));
                cbk.Font.Size = 11;
                for (int j = 1; j <= 4; j++)
                {
                    cbk.Items[j - 1].Value = j.ToString();
                }
                Ans += sdr[6].ToString();
                if (Session["a"] == null)
                {
                    Session["Ans"] = Ans;
                }
                Panel1.Controls.Add(littxt);
                Panel1.Controls.Add(cbk);
                Panel1.Controls.Add(litti);
                i++;
                tNUM++;
            }
            sdr.Close();
            conn.Close();
            Session["a"] = 1;
    }
    protected void btnsubmit_Click(object sender, EventArgs e)
    {
        string msc = "";
        for (int i = 1; i <= tNUM; i++)
        {
            RadioButtonList list = (RadioButtonList)Panel1.FindControl("cbk" + i.ToString());
            if (list != null)
            {
                if (list.SelectedValue.ToString() != "")
                {

                    msc += list.SelectedValue.ToString();
                }
                else
                {
                    msc += "0";
                }
            }
        }
        Session["Sans"] = msc;//考生答案
        string sql = "update tb_score set RigthAns='" + Ans + "' where StudentID='" + lblStuNum.Text + "'";
        BaseClass.OperateData(sql);
        string strsql = "update tb_score set StudentAns='" + msc + "' where StudentID='" + lblStuNum.Text + "'";
        BaseClass.OperateData(strsql);
        Response.Redirect("result.aspx?BInt=" + tNUM.ToString());
    }
}
