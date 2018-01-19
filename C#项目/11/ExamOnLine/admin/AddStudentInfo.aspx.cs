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
public partial class admin_AddStudentInfo : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["admin"] == null)
        {
            Response.Redirect("../Login.aspx");
        }
    }
    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        if (txtName.Text == "" || txtNum.Text == "" || txtPwd.Text == "")
        {
            MessageBox.Show("请将信息填写完整");
            return;
        }
        else
        {
            SqlConnection conn = BaseClass.DBCon();
            conn.Open();
            SqlCommand cmd = new SqlCommand("select count(*) from tb_Student where StudentNum='" + txtNum.Text + "'", conn);
            int i = Convert.ToInt32(cmd.ExecuteScalar());
            if (i > 0)
            {
                MessageBox.Show("此学号已经存在");
                return;
            }
            else
            {
                cmd = new SqlCommand("insert into tb_Student(StudentNum,StudentName,StudentSex,StudentPwd) values('" + txtNum.Text.Trim() + "','" + txtName.Text.Trim() + "','" + rblSex.SelectedValue.ToString() + "','" + txtPwd.Text.Trim() + "')", conn);
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("添加成功");
                btnConcel_Click(sender, e);
            }
        }
    }
    protected void btnConcel_Click(object sender, EventArgs e)
    {
        txtName.Text = "";
        txtNum.Text = "";
        txtPwd.Text = "";
    }
}
