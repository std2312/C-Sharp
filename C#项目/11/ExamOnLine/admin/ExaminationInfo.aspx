<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ExaminationInfo.aspx.cs" Inherits="admin_ExaminationInfo" %>

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
        选择科目：<asp:DropDownList ID="ddlEkm" runat="server">
        </asp:DropDownList>&nbsp;
        <asp:Button ID="btnSerch" runat="server" Text="查看" OnClick="btnSerch_Click" />
        &nbsp;
        <asp:Label ID="Label1" runat="server" Text="当前搜索试题类别："></asp:Label>&nbsp;
        <asp:Label ID="lbltype" runat="server"></asp:Label><br />
        <br />
        <br />
        <asp:GridView ID="gvExaminationInfo" runat="server" AutoGenerateColumns="False" BackColor="White"
            BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="3" Width="586px" OnRowDeleting="gvExaminationInfo_RowDeleting" AllowPaging="True" OnPageIndexChanging="gvExaminationInfo_PageIndexChanging" PageSize="8">
            <FooterStyle BackColor="White" ForeColor="#000066" />
            <Columns>
                <asp:BoundField DataField="testContent" HeaderText="题目" />
                <asp:TemplateField HeaderText="发布">
                    <ItemStyle HorizontalAlign="Center" Width="30px" />
                    <ItemTemplate>
                        <%#Getstatus(Convert.ToString(Eval("pub"))) %>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:HyperLinkField DataNavigateUrlFields="ID" DataNavigateUrlFormatString="ExaminationDetail.aspx?Eid={0}"
                    HeaderText="查看/修改" Text="详细信息">
                    <ItemStyle HorizontalAlign="Center" Width="60px" />
                </asp:HyperLinkField>
                <asp:CommandField HeaderText="删除" ShowDeleteButton="True">
                    <ItemStyle HorizontalAlign="Center" Width="30px" />
                </asp:CommandField>
            </Columns>
            <RowStyle ForeColor="#000066" Height="15px" HorizontalAlign="Left" />
            <SelectedRowStyle BackColor="#669999" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="White" ForeColor="#000066" HorizontalAlign="Center" />
            <HeaderStyle BackColor="#006699" Font-Bold="True" ForeColor="White" Height="15px" />
        </asp:GridView>
    
    </div>
    </form>
</body>
</html>
