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
public partial class admin_Subject : System.Web.UI.Page
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
            while (sdr.Read())
            {
                ListBox1.Items.Add(sdr["LessonName"].ToString());
            }
        }
    }
    protected void btnAdd_Click(object sender, EventArgs e)
    {
        if (txtKCName.Text == "")
        {
            MessageBox.Show("请输入课程名称");
            return;
        }
        else
        {
            string systemTime = DateTime.Now.ToString();
            string strsql = "insert into tb_Lesson(LessonName,LessonDataTime) values('" + txtKCName.Text.Trim() + "','" + systemTime + "')";
            BaseClass.OperateData(strsql);
            txtKCName.Text = "";
            Response.Write("<script>alert('添加成功');location='Subject.aspx'</script>");
        }
    }
    protected void btnDelete_Click(object sender, EventArgs e)
    {
        if (ListBox1.SelectedValue.ToString() == "")
        {
            MessageBox.Show("请选择删除项目后删除");
            return;
        }
        else
        {
            string strsql = "delete from tb_Lesson where LessonName='" + ListBox1.SelectedItem.Text + "'";
            BaseClass.OperateData(strsql);
            Response.Write("<script>alert('删除成功');location='Subject.aspx'</script>");
        }
    }
}
