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
public partial class student_studentexam : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            lblNum.Text = Session["ID"].ToString();
            SqlConnection conn = BaseClass.DBCon();
            conn.Open();
            SqlCommand cmd = new SqlCommand("select * from tb_Student where StudentNum='" + Session["ID"].ToString() + "'", conn);
            SqlDataReader sdr = cmd.ExecuteReader();
            sdr.Read();
            lblName.Text = sdr["StudentName"].ToString();
            lblsex.Text = sdr["StudentSex"].ToString();
            conn.Close();
            Session["name"] = lblName.Text;
            Session["sex"] = lblsex.Text;
            BindDropDownList();
        }
    }
    private void BindDropDownList()
    {
        SqlConnection conn = BaseClass.DBCon();
        conn.Open();
        SqlCommand cmd = new SqlCommand("select * from tb_Lesson", conn);
        SqlDataReader sdr = cmd.ExecuteReader();
        ddlKm.DataSource = sdr;
        ddlKm.DataTextField = "LessonName";
        ddlKm.DataBind();
        conn.Close();
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        if (ckbCheck.Checked == true)
        {
            Panel1.Visible = false;
            Panel2.Visible = true;
            Image1.ImageUrl = "~/Image/kemu_03.gif";
        }
        else
        {
            MessageBox.Show("请接受考试规则");
        }
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        string StuID = Session["ID"].ToString();//考生的编号
        string StuKC = ddlKm.SelectedItem.Text;//选择的考试科目
        SqlConnection conn = BaseClass.DBCon();
        conn.Open();
        SqlCommand cmd = new SqlCommand("select count(*) from tb_Score where StudentID='" + StuID + "' and LessonName='" + StuKC + "'", conn);
        int i = Convert.ToInt32(cmd.ExecuteScalar());
        if (i > 0)
        {
            MessageBox.Show("你已经参加过此科目的考试了");
        }
        else
        {

            cmd = new SqlCommand("select count(*) from tb_test where testCourse='" + StuKC + "'", conn);
            int N = Convert.ToInt32(cmd.ExecuteScalar());

            if (N > 0)
            {
                cmd = new SqlCommand("insert into tb_Score(StudentID,LessonName,StudentName) values('" + StuID + "','" + StuKC + "','" + lblName.Text + "')", conn);
                cmd.ExecuteNonQuery();
                conn.Close();
                Session["KM"] = StuKC;
                Session["falg"] = 1;
                Response.Write("<script>window.open('StartExam.aspx','newwindow','status=1,scrollbars=1,resizable=1')</script>");
                Response.Write("<script>window.opener=null;window.close();</script>");
            }
            else
            {
                MessageBox.Show("此科目没有考试题");
                return;
            }
        }
    }
}
