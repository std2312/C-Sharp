<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StudentInfo.aspx.cs" Inherits="admin_StudentInfo" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>无标题页</title>
    <link href="../Mystyle.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
<div>
        <br />
        <br />
        &nbsp; &nbsp; &nbsp; &nbsp;<br />
        <br />
        <br />
    
    </div>
    <fieldset style="width: 544px; height: 236px">
    <legend class="mailTitle">考生基本信息</legend>
        <br />
        <asp:Label ID="Label1" runat="server" Text="查询条件："></asp:Label>
        <asp:DropDownList ID="ddlType"
            runat="server" Height="13px">
            <asp:ListItem Selected="True">学号</asp:ListItem>
            <asp:ListItem>姓名</asp:ListItem>
        </asp:DropDownList>
        <asp:Label ID="Label2" runat="server" Text="关键字："></asp:Label>
        <asp:TextBox ID="txtKey" runat="server" Height="13px"></asp:TextBox>
        <asp:Button ID="btnserch" runat="server" OnClick="btnserch_Click"
            Text="查看" /><br />
        <br />
        <asp:GridView ID="gvStuInfo" runat="server" AutoGenerateColumns="False" BackColor="White"
            BorderColor="DeepSkyBlue" BorderStyle="None" BorderWidth="1px" CellPadding="3" Width="537px" OnRowDeleting="gvStuInfo_RowDeleting" AllowPaging="True" OnPageIndexChanging="gvStuInfo_PageIndexChanging" PageSize="8">
            <FooterStyle BackColor="White" ForeColor="#000066" />
            <Columns>
                <asp:BoundField DataField="StudentNum" HeaderText="学号" />
                <asp:BoundField DataField="StudentName" HeaderText="姓名" />
                <asp:BoundField DataField="StudentPwd" HeaderText="密码" />
                <asp:BoundField DataField="StudentSex" HeaderText="性别" />
                <asp:CommandField HeaderText="删除" ShowDeleteButton="True" />
                <asp:HyperLinkField DataNavigateUrlFields="ID" DataNavigateUrlFormatString="ChangeStudentInfo.aspx?stuid={0}"
                    HeaderText="修改" Text="修改信息" />
            </Columns>
            <RowStyle ForeColor="#000066" Height="15px" HorizontalAlign="Center" VerticalAlign="Middle" />
            <SelectedRowStyle BackColor="#669999" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="White" ForeColor="#000066" HorizontalAlign="Center" />
            <HeaderStyle BackColor="Transparent" Font-Bold="False" ForeColor="Black" Height="15px" />
        </asp:GridView>
        <br />
    </fieldset>
    </form>
</body>
</html>
