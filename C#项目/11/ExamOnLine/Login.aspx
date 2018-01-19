<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Login.aspx.cs" Inherits="Login" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>无标题页</title>
    <link href="Mystyle.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
<br />
        <br />
        <table align="center" background="Image/login.gif" border="0" cellpadding="0" cellspacing="0"
            height="294" width="464">
            <tr>
                <td colspan="5" height="131">
                    &nbsp;</td>
            </tr>
            <tr>
                <td height="25" style="width: 180px">
                    &nbsp;</td>
                <td style="width: 69px">
                    <div align="center">
                        账 号：</div>
                </td>
                <td colspan="2" width="158" style="text-align: left">
                    <asp:TextBox ID="txtNum" runat="server" Height="13px" Width="125px"></asp:TextBox></td>
                <td style="text-align: left; width: 67px;">
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtNum"
                        Display="Dynamic" ErrorMessage="请输入学生证号" ForeColor="DarkGray" Font-Size="10pt">*</asp:RequiredFieldValidator>&nbsp;</td>
            </tr>
            <tr>
                <td height="25" style="width: 180px">
                    &nbsp;</td>
                <td height="25" style="width: 69px">
                    <div align="center">
                    密 码：</div>
                </td>
                <td colspan="2" height="25" style="text-align: left">
                    <asp:TextBox ID="txtPwd" runat="server" MaxLength="12" TextMode="Password" Width="125px" Height="13px"></asp:TextBox>&nbsp;</td>
                <td height="25" style="text-align: left; width: 67px;">
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtPwd"
                        Display="Dynamic" ErrorMessage="密码不为空" ForeColor="DimGray" Font-Size="10pt">*</asp:RequiredFieldValidator>&nbsp;</td>
            </tr>
            <tr>
                <td height="25" style="width: 180px">
                    &nbsp;</td>
                <td height="25" style="width: 69px">
                    <div align="center">
                        身 份：</div>
                </td>
                <td colspan="2" height="25" style="text-align: left">
                    <asp:DropDownList ID="ddlstatus" runat="server">
                        <asp:ListItem Selected="True">学生</asp:ListItem>
                        <asp:ListItem>教师</asp:ListItem>
                        <asp:ListItem>管理员</asp:ListItem>
                    </asp:DropDownList>&nbsp;</td>
                <td height="25" style="width: 67px">
                    &nbsp;</td>
            </tr>
            <tr>
                <td height="25" style="width: 180px">
                    &nbsp;</td>
                <td height="25" style="width: 69px">
                    <div align="center">
                    验证码：</div>
                </td>
                <td height="25" style="width: 22px; text-align: left">
                    <asp:TextBox ID="txtCode" runat="server" Height="13px" Width="60px"></asp:TextBox></td>
                <td style="text-align: left">
                    <asp:Image ID="Image1" runat="server" Width="56px" BorderColor="Gray" BorderWidth="1px" Height="17px" ImageUrl="~/Image.aspx" /></td>
                <td height="25" style="text-align: left; width: 67px;">
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="txtCode"
                        Display="Dynamic" ErrorMessage="请输入验证码" ForeColor="DimGray" Font-Size="10pt">*</asp:RequiredFieldValidator>&nbsp;</td>
            </tr>
            <tr>
                <td colspan="5" height="25" style="text-align: center">
                    &nbsp;<asp:Button ID="btnlogin" runat="server" Text="登录" OnClick="btnlogin_Click" />
                    &nbsp;&nbsp; &nbsp;<asp:Button ID="btnconcel" runat="server" Text="取消" OnClick="btnconcel_Click" CausesValidation="False" /></td>
            </tr>
            <tr>
                <td colspan="5">
                    &nbsp;</td>
            </tr>
        </table>
        <br />
        <br />
        <br />
        <br />
        <asp:ValidationSummary ID="ValidationSummary1" runat="server" ShowMessageBox="True"
            ShowSummary="False" />
    </form>
</body>
</html>
