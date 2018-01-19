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

public partial class Login : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnlogin_Click(object sender, EventArgs e)
    {
        if (txtCode.Text.Trim() != Session["verify"].ToString())
        {
            Response.Write("<script>alert('验证码错误');location='Login.aspx'</script>");
        }
        else
        {
            if (this.ddlstatus.SelectedValue == "学生")
            {
                if (BaseClass.CheckStudent(txtNum.Text.Trim(), txtPwd.Text.Trim()))
                {
                    Session["ID"] = txtNum.Text.Trim();
                    Response.Redirect("student/studentexam.aspx");
                }
                else
                {
                    Response.Write("<script>alert('您不是学生或者用户名和密码错误');location='Login.aspx'</script>");
                }
            }
            if (this.ddlstatus.SelectedValue == "教师")
            {
                if (BaseClass.CheckTeacher(txtNum.Text.Trim(), txtPwd.Text.Trim()))
                {
                    Session["teacher"] = txtNum.Text;
                    Response.Redirect("teacher/TeacherManage.aspx");
                }
                else
                {
                    Response.Write("<script>alert('您不是教师或者用户名和密码错误');location='Login.aspx'</script>");
                }
            }
            if (this.ddlstatus.SelectedValue == "管理员")
            {
                if (BaseClass.CheckAdmin(txtNum.Text.Trim(), txtPwd.Text.Trim()))
                {
                    Session["admin"] = txtNum.Text;
                    Response.Redirect("admin/AdminManage.aspx");
                }
                else
                {
                    Response.Write("<script>alert('您不是管理员或者用户名和密码错误');location='Login.aspx'</script>");
                }

            }
        }
    }
    protected void btnconcel_Click(object sender, EventArgs e)
    {
        RegisterStartupScript("提示", "<script>window.close();</script>");
    }
}
