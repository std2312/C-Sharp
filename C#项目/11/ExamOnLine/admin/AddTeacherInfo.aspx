<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AddTeacherInfo.aspx.cs" Inherits="admin_AddTeacherInfo" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>无标题页</title>
    <link href="../Mystyle.css" rel="stylesheet" type="text/css" />
</head>
<body style="text-align: center">
    <form id="form1" runat="server">
 <div>
        &nbsp;<br />
        <br />
        <br />
        <br />
        &nbsp;
    </div>
        <fieldset style="width: 406px; height: 200px">
            <legend class="mailTitle">添加教师信息</legend>
            <br />
            <table align="center" border="0" cellpadding="0" cellspacing="0" height="186" style="width: 341px">
                <tr>
                    <td style="text-align: center" width="120">
                    &nbsp;教师编号：</td>
                    <td style="text-align: left" width="281">
        <asp:TextBox ID="txtTeacherNum" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td style="text-align: center">
                    &nbsp;教师姓名：</td>
                    <td style="text-align: left">
        <asp:TextBox ID="txtTeacherName" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td style="text-align: center">
                    &nbsp;登录密码：</td>
                    <td style="text-align: left">
        <asp:TextBox ID="txtTeacherPwd" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td style="text-align: center">
                    &nbsp;负责课程：</td>
                    <td style="text-align: left">
        <asp:DropDownList ID="ddlTeacherKm" runat="server">
        </asp:DropDownList></td>
                </tr>
                <tr>
                    <td colspan="2" style="text-align: center">
        <asp:Button ID="btnAdd" runat="server" OnClick="btnAdd_Click" Text="添加" />
                    &nbsp;&nbsp;
        <asp:Button ID="btnconcel" runat="server" OnClick="btnconcel_Click" Text="重置" /></td>
                </tr>
            </table>
        </fieldset>
    </form>
</body>
</html>
