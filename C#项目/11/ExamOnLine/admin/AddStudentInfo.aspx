<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AddStudentInfo.aspx.cs" Inherits="admin_AddStudentInfo" %>

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
        &nbsp;<br />
        <br />
        &nbsp;
    </div>
        <fieldset style="width: 406px; height: 200px">
            <legend class="mailTitle">添加考生信息</legend>
            <br />
            <table align="center" border="0" cellpadding="0" cellspacing="0" height="186" style="width: 341px">
                <tr>
                    <td style="text-align: center" width="120">
                    &nbsp;考生编号：</td>
                    <td style="text-align: left" width="281">
        <asp:TextBox ID="txtNum" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td style="text-align: center">
                    &nbsp;考生姓名：</td>
                    <td style="text-align: left">
        <asp:TextBox ID="txtName" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td style="text-align: center">
                    &nbsp;考生性别：</td>
                    <td style="text-align: left">
                    <asp:RadioButtonList ID="rblSex" runat="server" RepeatDirection="Horizontal"
            RepeatLayout="Flow">
            <asp:ListItem Selected="True">男</asp:ListItem>
            <asp:ListItem>女</asp:ListItem>
        </asp:RadioButtonList></td>
                </tr>
                <tr>
                    <td style="text-align: center">
                    &nbsp;考生密码：</td>
                    <td style="text-align: left">
        <asp:TextBox ID="txtPwd" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td colspan="2" style="text-align: center">
        <asp:Button ID="btnSubmit" runat="server" OnClick="btnSubmit_Click" Text="添加" />
                    &nbsp;&nbsp;
        <asp:Button ID="btnConcel" runat="server" OnClick="btnConcel_Click" Text="重置" /></td>
                </tr>
            </table>
        </fieldset>
    </form>
</body>
</html>
