<%@ Page Language="C#" AutoEventWireup="true" CodeFile="TExaminationDetail.aspx.cs" Inherits="teacher_TExaminationDetail" %>

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
        <fieldset style="width: 454px; height: 335px">
            <legend class="mailTitle">试题详细信息</legend>&nbsp; &nbsp; &nbsp;&nbsp;<br />
            <table align="center" border="0" cellpadding="0" cellspacing="0" style="height: 321px"
                width="344">
                <tr>
                    <td style="height: 24px; text-align: right" width="87">
                        &nbsp;所属科目：</td>
                    <td colspan="2" style="height: 24px; text-align: left">
                        <asp:Label ID="lblkm" runat="server"></asp:Label>&nbsp;</td>
                </tr>
                <tr>
                    <td style="text-align: right">
                        &nbsp;试题题目：</td>
                    <td colspan="2" style="text-align: left">
                        <asp:TextBox ID="txtsubject" runat="server" TextMode="MultiLine"></asp:TextBox>&nbsp;</td>
                </tr>
                <tr>
                    <td style="text-align: right">
                        &nbsp;选项A：</td>
                    <td colspan="2" style="text-align: left">
                        <asp:TextBox ID="txtAnsA" runat="server" TextMode="MultiLine"></asp:TextBox>&nbsp;</td>
                </tr>
                <tr>
                    <td style="text-align: right">
                        &nbsp;选项B：</td>
                    <td colspan="2" style="text-align: left">
                        <asp:TextBox ID="txtAnsB" runat="server" TextMode="MultiLine"></asp:TextBox>&nbsp;</td>
                </tr>
                <tr>
                    <td style="text-align: right">
                        &nbsp;选项C：</td>
                    <td colspan="2" style="text-align: left">
                        <asp:TextBox ID="txtAnsC" runat="server" TextMode="MultiLine"></asp:TextBox></td>
                </tr>
                <tr>
                    <td style="text-align: right">
                        &nbsp;选项D：</td>
                    <td colspan="2" style="text-align: left">
                        <asp:TextBox ID="txtAnsD" runat="server" TextMode="MultiLine"></asp:TextBox>&nbsp;</td>
                </tr>
                <tr>
                    <td style="height: 27px; text-align: right">
                        &nbsp;正确选项：</td>
                    <td colspan="2" style="height: 27px; text-align: left">
                        <asp:RadioButtonList ID="rblRightAns" runat="server" RepeatDirection="Horizontal"
                            RepeatLayout="Flow">
                            <asp:ListItem Value="1">选项A</asp:ListItem>
                            <asp:ListItem Value="2">选项B</asp:ListItem>
                            <asp:ListItem Value="3">选项C</asp:ListItem>
                            <asp:ListItem Value="4">选项D</asp:ListItem>
                        </asp:RadioButtonList>&nbsp;</td>
                </tr>
                <tr>
                    <td style="height: 29px; text-align: right">
                        &nbsp;发布设置：</td>
                    <td style="height: 29px; text-align: left;" width="141">
                        <asp:CheckBox ID="cbFB" runat="server" Text="是否发布" /></td>
                    <td style="height: 29px" width="116">
                        &nbsp;</td>
                </tr>
                <tr>
                    <td colspan="3" style="text-align: center">
                        <asp:Button ID="btnconfirm" runat="server" OnClick="btnconfirm_Click" Text="确定" />
                        <asp:Button ID="btnconcel" runat="server" OnClick="btnconcel_Click" Text="取消" /></td>
                </tr>
            </table>
        </fieldset>
    
    </div>
    </form>
</body>
</html>
