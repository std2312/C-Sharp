<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Subject.aspx.cs" Inherits="admin_Subject" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>无标题页</title>
    <link href="../Mystyle.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
<div style="text-align: center">
        <br />
        <br />
        <br />
        <br />
        &nbsp; &nbsp;
        <fieldset style="width: 406px; height: 61px; text-align: left">
        <legend class="mailTitle">注意事项</legend>
            <br />
            请不要随意对课程进行删除，因为删除课程名称之后，会影响系统的运行以及题目的读取！
            </fieldset>
        <br />
        <br />
        <br />
        &nbsp; &nbsp;
        <fieldset style="width: 406px; height: 200px">
            <legend class="mailTitle">科目设置</legend>
            <br />
            <table align="center" border="0" cellpadding="0" cellspacing="0" height="73" style="width: 378px">
                <tr>
                    <td style="width: 144px; height: 2px">
                        输入新课程：</td>
                    <td style="height: 2px" width="147">
        <asp:TextBox ID="txtKCName" runat="server"></asp:TextBox>&nbsp;</td>
                    <td style="height: 2px" width="58">
        <asp:Button ID="btnAdd" runat="server" OnClick="btnAdd_Click" Text="添加" />&nbsp;</td>
                    <td style="width: 33px; height: 2px">
        <asp:Button ID="btnDelete" runat="server" OnClick="btnDelete_Click" Text="删除" />&nbsp;</td>
                </tr>
                <tr>
                    <td colspan="4" style="text-align: center">
                        <br />
        <asp:ListBox ID="ListBox1" runat="server" Height="124px" Width="374px" SelectionMode="Multiple"></asp:ListBox>&nbsp;</td>
                </tr>
            </table>
        </fieldset>
    </div>
    </form>
</body>
</html>
