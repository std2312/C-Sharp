<%@ Page Language="C#" AutoEventWireup="true" CodeFile="studentexam.aspx.cs" Inherits="student_studentexam" %>

<%@ Register Src="../UserControls/Fooder.ascx" TagName="Fooder" TagPrefix="uc1" %>
<%@ Register Src="../UserControls/Header1.ascx" TagName="Header1" TagPrefix="uc2" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>无标题页</title>
    <link href="../Mystyle.css" rel="stylesheet" type="text/css" />
</head>
<body background="../Image/back_01.gif">
    <form id="form1" runat="server">
 <div style="text-align: center">
        &nbsp;</div>
        <table align="center" bgcolor="#ffffff" border="0" cellpadding="0" cellspacing="0"
            width="778">
            <tr>
                <td colspan="6" style="height: 46px">
                    <uc2:Header1 ID="Header1_1" runat="server" />
                </td>
            </tr>
            <tr>
                <td bgcolor="#ecf9ff" height="24">
                    <div align="right">
                        学号：</div>
                </td>
                <td bgcolor="#ecf9ff" height="24" style="text-align: left" width="134">
        <asp:Label ID="lblNum" runat="server" Text="Label"></asp:Label>&nbsp;</td>
                <td bgcolor="#ecf9ff" width="43">
                    <div align="right">
                        姓名：</div>
                </td>
                <td bgcolor="#ecf9ff" style="text-align: left" width="85">
        <asp:Label ID="lblName" runat="server"></asp:Label>&nbsp;</td>
                <td bgcolor="#ecf9ff" width="44">
                    <div align="right">
                        性别：</div>
                </td>
                <td bgcolor="#ecf9ff" style="text-align: left" width="406">
        <asp:Label ID="lblsex" runat="server"></asp:Label>&nbsp;</td>
            </tr>
            <tr>
                <td colspan="6" height="53">
                    <asp:Image ID="Image1" runat="server" Height="53px" ImageUrl="~/Image/rule_03.gif"
                        Width="778px" /></td>
            </tr>
            <tr>
                <td height="288" width="66">
                    <p>
                        &nbsp;</p>
                </td>
                <td colspan="5" style="text-align: left" valign="top">
        <asp:Panel ID="Panel1" runat="server" Height="50px" Width="698px">
            <br />
            <br />
            1.不得携带笔记、便携式计算机、书包或其他物品进入考场。请将这些物品交给考试管理员妥善保管。
            <br />
            <br />
            2.考场内请保持安静，不得交谈和走动。
            <br />
            <br />
            3.不得参阅其他人屏幕上的答题，不得参阅笔记及任何资料。
            <br />
            <br />
            4.如有任何疑问，请暂停考试、举手示意管理员解决。
            <br />
            <br />
            5.若出现意外情况（如停电、机器故障等），请立即示意管理员解决。
            <br />
            <br />
            6.不得以任何方式将考题内容带出考场。
            <br />
            <br />
            7.凡有违反上述规定中的任何一条者，考场管理员有权提出警告直至终止其考试、取消其考试成绩和考试资格。
            <br />
            <br />
            8.任何人都有权利和义务维护认证考试的公平性和公正性，举报一切违反考场规则的行为。<br />
            <br />
            <br />
            <div style="text-align: center">
                <table border="0" cellpadding="0" cellspacing="0" style="width: 180px; height: 74px">
                    <tr>
                        <td style="width: 100px; text-align: center">
            <asp:CheckBox
                ID="ckbCheck" runat="server" Text="已经仔细阅读了考试规则" Width="180px" /></td>
                    </tr>
                    <tr>
                        <td style="width: 100px; text-align: center" align="center">
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="已经阅读完考试制度" Width="181px" /></td>
                    </tr>
                </table>
            </div>
            </asp:Panel>
        <asp:Panel ID="Panel2" runat="server" Height="50px" Visible="False" Width="698px">
            <br />
            <br />
            <br />
            <br />
            <table align="center" border="0" cellpadding="0" cellspacing="0" height="30" width="486">
                <tr>
                    <td style="text-align: center">
            <asp:Label ID="Label3" runat="server" Text="选择考试科目："></asp:Label>&nbsp;<asp:DropDownList
                ID="ddlKm" runat="server">
            </asp:DropDownList>
            <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="开始考试" /></td>
                </tr>
            </table>
            <br />
            <div style="text-align: center">
                &nbsp;
            </div>
        </asp:Panel>
                </td>
            </tr>
            <tr>
                <td colspan="6" height="36">
                    <uc1:Fooder ID="Fooder1" runat="server" />
                </td>
            </tr>
        </table>
    </form>
</body>
</html>
