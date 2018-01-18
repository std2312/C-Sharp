<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StartExam.aspx.cs" Inherits="student_StartExam" %>

<%@ Register Src="../UserControls/Header1.ascx" TagName="Header1" TagPrefix="uc1" %>
<%@ Register Src="../UserControls/Fooder.ascx" TagName="Fooder" TagPrefix="uc2" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>在线考试系统</title>
    
    
    <script language="javascript" type="text/javascript">
    self.moveTo(0,0);
    self.resizeTo(screen.availWidth,screen.availHeight);
    function keydown()
    {
      if(event.keyCode==8)//屏蔽退格键
      {
        event.keyCode=0;
        event.returnValue=false;
      }
      if(event.keyCode==13)//屏蔽回车键
      {
        event.keyCode=0;
        event.returnValue=false;
      }
       if(event.keyCode==116)//屏蔽F5刷新键
      {
        event.keyCode=0;
        event.returnValue=false;
      }
    }
    
    function showtime()
    {
      var now=new Date();
      years=now.getFullYear();
      month=now.getMonth()+1;
      dates=now.getDate();
      hours=now.getHours();
      Minutes=now.getMinutes();
      Seconds=now.getSeconds();
      if(hours<10)
      hours="0"+hours;
      if(Minutes<10)
      Minutes="0"+Minutes;
      if(Seconds<10)
      Seconds="0"+Seconds;
      var titletext="当前日期时间为>>>"+years+"年"+month+"月"+dates+"日"+hours+":"+Minutes+":"+Seconds;
      setTimeout("showtime()",1000);
      document.title=titletext;
    }

    </script>
    <link href="../Mystyle.css" rel="stylesheet" type="text/css" />
</head>
<body 　onkeydown="keydown()" onload="showtime()" oncontextmenu="return false" onselectstart="return false" background="../Image/back_01.gif" id="bntOk">
    <form id="form1" runat="server">
<SCRIPT language="javascript">
<!--
var sec=0;
var min=0;
var hou=0;
flag=0;
idt=window.setTimeout("ls();",1000);
function ls()
{
sec++;
if(sec==60){sec=0;min+=1;}
if(min==60){min=0;hou+=1;}
document.getElementById("lbltime").innerText=min+"分"+sec+"秒";
idt=window.setTimeout("ls();",1000);
if(min==10)
{
    document.getElementById("btnsubmit").click();
}
}

//-->
</SCRIPT>
    <div style="text-align: left">
        &nbsp;&nbsp;&nbsp; &nbsp;&nbsp;<br />
        <table align="center" bgcolor="#ffffff" border="0" cellpadding="0" cellspacing="0"
            height="678" width="778">
            <tr>
                <td colspan="7" height="46">
                    <uc1:Header1 ID="Header1_1" runat="server" />
                </td>
            </tr>
            <tr>
                <td bgcolor="#ecf9ff" width="93" style="height: 23px">
                    <div align="right">
                        学号：</div>
                </td>
                <td bgcolor="#ecf9ff" width="107" style="height: 23px">
                    <asp:Label ID="lblStuNum"
            runat="server"></asp:Label></td>
                <td bgcolor="#ecf9ff" width="43" style="height: 23px">
                    <div align="right">
                        姓名：</div>
                </td>
                <td bgcolor="#ecf9ff" width="85" style="height: 23px">
                    <asp:Label
                ID="lblStuName" runat="server"></asp:Label></td>
                <td bgcolor="#ecf9ff" width="44" style="height: 23px">
                    <div align="right">
                        性别：</div>
                </td>
                <td bgcolor="#ecf9ff" width="54" style="height: 23px">
        <asp:Label ID="lblStuSex" runat="server"></asp:Label></td>
                <td bgcolor="#ecf9ff" width="352" style="height: 23px">
                    &nbsp;<asp:Button ID="btnsubmit" runat="server" OnClick="btnsubmit_Click" Text="交卷" UseSubmitBehavior="False" />
                    </td>
            </tr>
            <tr>
                <td colspan="7" height="53">
                    <img height="53" src="../Image/exame_05.gif" width="778" /></td>
            </tr>
            <tr>
                <td colspan="7" height="45" style="text-align: center">
        <asp:Label ID="lblStuKM" runat="server" Font-Bold="True" Font-Size="18pt"></asp:Label></td>
            </tr>
            <tr>
                <td colspan="7" height="36" style="text-align: center">
        <asp:Label ID="lblEndtime" runat="server"></asp:Label>
                    <asp:Label ID="lbltime" runat="server" Font-Bold="True" ForeColor="#C04000"></asp:Label></td>
            </tr>
            <tr>
                <td height="457">
                    &nbsp;</td>
                <td colspan="6" height="457" valign="top">
                    &nbsp;<asp:Panel ID="Panel1" runat="server" Height="50px" Width="547px">
        </asp:Panel>
                    &nbsp;
                </td>
            </tr>
            <tr>
                <td colspan="7" height="18">
                    <uc2:Fooder ID="Fooder1" runat="server" />
                </td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>
