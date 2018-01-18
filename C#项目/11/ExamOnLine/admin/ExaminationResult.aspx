<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ExaminationResult.aspx.cs" Inherits="admin_ExaminationResult" %>

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
        <br />
        <br />
        &nbsp;&nbsp;<fieldset style="width: 406px; height: 61px; text-align: left">
            <legend class="mailTitle">考试结果</legend>
            <br />
            &nbsp;<asp:GridView ID="gvExaminationresult" runat="server" AutoGenerateColumns="False" BackColor="White"
            BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="3" OnRowDeleting="gvExaminationInfo_RowDeleting"
            Width="556px" AllowPaging="True" OnPageIndexChanging="gvExaminationresult_PageIndexChanging" PageSize="8">
            <FooterStyle BackColor="White" ForeColor="#000066" />
            <Columns>
                <asp:BoundField DataField="StudentID" HeaderText="学号">
                    <ItemStyle HorizontalAlign="Center" Width="120px" />
                </asp:BoundField>
                <asp:BoundField DataField="StudentName" HeaderText="姓名">
                    <ItemStyle HorizontalAlign="Center" Width="100px" />
                </asp:BoundField>
                <asp:BoundField DataField="LessonName" HeaderText="考试科目">
                    <ItemStyle HorizontalAlign="Center" Width="120px" />
                </asp:BoundField>
                <asp:BoundField DataField="score" HeaderText="分数">
                    <ItemStyle HorizontalAlign="Center" Width="30px" />
                </asp:BoundField>
                <asp:CommandField HeaderText="删除" ShowDeleteButton="True">
                    <ItemStyle HorizontalAlign="Center" Width="30px" />
                </asp:CommandField>
            </Columns>
            <RowStyle ForeColor="#000066" Height="15px" HorizontalAlign="Left" />
            <SelectedRowStyle BackColor="#669999" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="White" ForeColor="#000066" HorizontalAlign="Center" />
            <HeaderStyle BackColor="#006699" Font-Bold="True" ForeColor="White" Height="15px" />
        </asp:GridView>
            <br />
        </fieldset>
    </div>
    </form>
</body>
</html>
