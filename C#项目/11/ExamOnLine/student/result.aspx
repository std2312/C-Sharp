<%@ Page Language="C#" AutoEventWireup="true" CodeFile="result.aspx.cs" Inherits="student_result" %>

<%@ Register Src="../UserControls/Header1.ascx" TagName="Header1" TagPrefix="uc1" %>
<%@ Register Src="../UserControls/Fooder.ascx" TagName="Fooder" TagPrefix="uc2" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>在线考试结果</title>
    <style type="text/css">
<!--
.bian {
	border: 1px solid #158BB7;
}
.STYLE2 {color: #FFFFFF; font-weight: bold; }
.ce {
	border-top-width: 1px;
	border-right-width: 1px;
	border-bottom-width: 1px;
	border-left-width: 1px;
	border-top-style: none;
	border-right-style: none;
	border-bottom-style: none;
	border-left-style: solid;
	border-top-color: #158BB7;
	border-right-color: #158BB7;
	border-bottom-color: #158BB7;
	border-left-color: #158BB7;
}
-->
</style>
    
    <script language=javascript>
    function keydown2()
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
      var titletext=years+"年"+month+"月"+dates+"日"+hours+":"+Minutes+":"+Seconds;
      setTimeout("showtime()",1000);
      document.getElementById("lbldate").innerText=titletext;
    }
    </script>
    
    <script language=javascript>
    function click()
    {
      event.returnValue=false;
      alert("当前设置不允许使用右键！");
    }
    document.oncontextmenu=click;
    </script>

    <link href="../Mystyle.css" rel="stylesheet" type="text/css" />
</head>
<body onkeydown="keydown2()" background="../Image/back_01.gif" onload="showtime()">
    <form id="form1" runat="server">
  <div style="text-align: center">
        <br />
        <table align="center" bgcolor="#ffffff" border="0" cellpadding="0" cellspacing="0"
            width="778" style="height: 582px">
            <tr>
                <td height="47">
                    <uc1:Header1 ID="Header1_1" runat="server" />
                </td>
            </tr>
            <tr>
                <td bgcolor="#ecf9ff" height="31" style="text-align: right">
                    <asp:Label ID="lbldate" runat="server"></asp:Label>
                    &nbsp; &nbsp; &nbsp;</td>
            </tr>
            <tr>
                <td height="36">
                    <img height="53" src="../Image/emame_03.gif"
                        width="778" /></td>
            </tr>
            <tr>
                <td style="height: 310px">
                    <table align="center" border="1" cellpadding="0" class="bian"
                        height="61" width="500" bordercolor="#158bb7">
                        <tr>
                            <td background="../Image/bg.gif" height="20">
                                <div align="center" class="STYLE2">
                                    <span style="color: #ffffff">考试科目</span></div>
                            </td>
                            <td background="../Image/bg.gif">
                                <div align="center" class="STYLE2">
                                    <span style="color: #ffffff">考生学号</span></div>
                            </td>
                            <td background="../Image/bg.gif" style="width: 145px">
                                <div align="center" class="STYLE2">
                                    <span style="color: #ffffff">考生姓名</span></div>
                            </td>
                            <td background="../Image/bg.gif" style="width: 127px">
                                <div align="center" class="STYLE2">
                                    <span style="color: #ffffff">考试成绩</span></div>
                            </td>
                        </tr>
                        <tr>
                            <td height="36">
                                <asp:Label ID="lblkm" runat="server" Text="Label"></asp:Label>&nbsp;</td>
                            <td>
                                &nbsp;<asp:Label ID="lblnum" runat="server" Text="Label"></asp:Label></td>
                            <td style="width: 145px">
                                &nbsp;<asp:Label ID="lblname" runat="server" Text="Label"></asp:Label></td>
                            <td style="width: 127px">
                                &nbsp;<asp:Label ID="lblResult" runat="server" Font-Bold="False"></asp:Label></td>
                        </tr>
                    </table>
                </td>
            </tr>
            <tr>
                <td style="height: 30px">
                    <uc2:Fooder ID="Fooder1" runat="server" />
                </td>
            </tr>
        </table>
    </div>
    </form>
</body>
</html>
