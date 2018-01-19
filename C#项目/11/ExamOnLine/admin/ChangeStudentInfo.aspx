<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ChangeStudentInfo.aspx.cs" Inherits="admin_ChangeStudentInfo" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>无标题页</title>
    <link href="../Mystyle.css" rel="stylesheet" type="text/css" />
</head>
<body style="text-align: center">
    <form id="form1" runat="server">
 <br />
        <br />
        <br />
        <br />
        <br />
        <br />
    <fieldset style="WIDTH: 406px; HEIGHT: 200px">
    <legend class="mailTitle">修改考生信息</legend>
        <br />
        <table align="center" border="0" cellpadding="0" cellspacing="0"  height="186" style="width: 341px">
            <tr>
                <td style="text-align: center" width="120">
                    &nbsp;考生编号：</td>
                <td width="281" style="text-align: left">
        <asp:TextBox ID="txtStuNum" runat="server" ReadOnly="True"></asp:TextBox></td>
            </tr>
            <tr>
                <td style="text-align: center">
                    &nbsp;考生姓名：</td>
                <td style="text-align: left">
        <asp:TextBox ID="txtStuName" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td style="text-align: center">
                    &nbsp;考生性别：</td>
                <td style="text-align: left">
        <asp:RadioButtonList ID="rblSex" runat="server" RepeatDirection="Horizontal" RepeatLayout="Flow">
            <asp:ListItem>男</asp:ListItem>
            <asp:ListItem>女</asp:ListItem>
        </asp:RadioButtonList></td>
            </tr>
            <tr>
                <td style="text-align: center">
                    &nbsp;考生密码：</td>
                <td style="text-align: left">
        <asp:TextBox ID="txtStuPwd" runat="server" MaxLength="12"></asp:TextBox></td>
            </tr>
            <tr>
                <td colspan="2" style="text-align: center">
                    &nbsp;
        <asp:Button ID="btnSava" runat="server" OnClick="btnSava_Click" Text="保存" />
        <asp:Button ID="btnConcel" runat="server" OnClick="btnConcel_Click" Text="取消" /></td>
            </tr>
        </table>
    </fieldset>
    <div>
        &nbsp;
        &nbsp;</div>
    </form>
</body>
</html>
