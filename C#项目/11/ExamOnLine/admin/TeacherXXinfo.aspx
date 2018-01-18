<%@ Page Language="C#" AutoEventWireup="true" CodeFile="TeacherXXinfo.aspx.cs" Inherits="admin_TeacherXXinfo" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>无标题页</title>
    <link href="../Mystyle.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
 <div style="text-align: center">
        &nbsp;<br />
        <br />
        <br />
        <br />
        &nbsp;
        <fieldset style="width: 406px; height: 200px">
            <legend class="mailTitle">教师详细信息</legend>
            <br />
            <table align="center" border="0" cellpadding="0" cellspacing="0" height="186" style="width: 341px">
                <tr>
                    <td style="text-align: center" width="120">
                        &nbsp;教师编号：</td>
                    <td style="text-align: left" width="281">
        <asp:TextBox ID="txtTNum" runat="server" ReadOnly="True"></asp:TextBox></td>
                </tr>
                <tr>
                    <td style="text-align: center">
                        &nbsp;教师姓名：</td>
                    <td style="text-align: left">
        <asp:TextBox ID="txtTName" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td style="text-align: center">
                        &nbsp;登录密码：</td>
                    <td style="text-align: left">
        <asp:TextBox ID="txtTPwd" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td style="text-align: center">
                        &nbsp;负责课程：</td>
                    <td style="text-align: left">
        <asp:DropDownList ID="ddlTKm" runat="server">
        </asp:DropDownList></td>
                </tr>
                <tr>
                    <td colspan="2" style="text-align: center">
        <asp:Button ID="btnSave" runat="server" OnClick="btnSava_Click" Text="保存" />
                        &nbsp;
        <asp:Button ID="btnConcel" runat="server" OnClick="btnConcel_Click" Text="取消" /></td>
                </tr>
            </table>
        </fieldset>
    </div>
    </form>
</body>
</html>
