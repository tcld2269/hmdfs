<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="main.aspx.cs" Inherits="hm.Web.Controls.main" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
   <link href="../images/skin.css" rel="stylesheet" type="text/css" />
<style type="text/css">
<!--
body {
	margin-left: 0px;
	margin-top: 0px;
	margin-right: 0px;
	margin-bottom: 0px;
	background-color: #EEF2FB;
}
ul{
    list-style:none;
    margin:0px;
    padding:5px;
    text-align:left;
    font-size:12px;
}
ul li
{
    padding:5px
}
image{border:0px}
-->
</style>
</head>
<body>
<table width="100%" border="0" cellpadding="0" cellspacing="0">
  <tr>
    <td width="17" valign="top" background="../images/mail_leftbg.gif"><img src="../images/left-top-right.gif" width="17" height="29" /></td>
    <td valign="top" background="../images/content-bg.gif"><table width="100%" height="31" border="0" cellpadding="0" cellspacing="0" class="left_topbg" id="table2">
      <tr>
        <td height="31"><div class="titlebt">欢迎界面</div></td>
      </tr>
    </table></td>
    <td width="16" valign="top" background="../images/mail_rightbg.gif"><img src="../images/nav-right-bg.gif" width="16" height="29" /></td>
  </tr>
  <tr>
    <td valign="middle" background="../images/mail_leftbg.gif">&nbsp;</td>
    <td valign="top" bgcolor="#F7F8F9"><table width="98%" border="0" align="center" cellpadding="0" cellspacing="0">
      <tr>
        <td colspan="2" valign="top">&nbsp;</td>
        <td>&nbsp;</td>
        <td valign="top">&nbsp;</td>
      </tr>
      <tr>
        <td colspan="2" valign="top"><span class="left_bt"><asp:Literal ID="litLogInfo" runat="server"></asp:Literal></span><br>
              <br>
            <span class="left_txt">&nbsp;<img src="../images/ts.gif" width="16" height="16"> 提示：<br>
         <asp:Literal ID="litShowInfo" runat="server"></asp:Literal>
</span></td>
        <td width="7%">&nbsp;</td>
        <td width="40%" valign="top"><table width="100%" height="144" border="0" cellpadding="0" cellspacing="0" class="line_table">
          <tr>
            <td width="2%" height="27" background="../images/news-title-bg.gif"><img src="../images/news-title-bg.gif" width="2" height="27"/></td>
            <td width="98%" background="../images/news-title-bg.gif" class="left_bt2">最新动态</td>
          </tr>
          <tr>
            <td height="102" valign="top" colspan="2">
             <div style="height:112px; overflow:auto">
                            <ul>
                            <asp:Repeater ID="rptActive" runat="server">
                            <ItemTemplate>
                            <li><%#DataBinder.Eval(Container.DataItem,"kc") %></li>
                            </ItemTemplate>
                            </asp:Repeater>
                            </ul>
                            </div>
            </td>

          </tr>
          <tr>
            <td height="5" colspan="2">&nbsp;</td>
          </tr>
        </table></td>
      </tr>
      <tr>
        <td colspan="2">&nbsp;</td>
        <td>&nbsp;</td>
        <td>&nbsp;</td>
      </tr>
      <tr>
        <td colspan="2" valign="top"><!--JavaScript部分-->
              <SCRIPT language=javascript>
                  function secBoard(n) {
                      for (i = 0; i < secTable.cells.length; i++)
                          secTable.cells[i].className = "sec1";
                      secTable.cells[n].className = "sec2";
                      for (i = 0; i < mainTable.tBodies.length; i++)
                          mainTable.tBodies[i].style.display = "none";
                      mainTable.tBodies[n].style.display = "block";
                  }
          </SCRIPT>
              <!--HTML部分-->
              <TABLE width=100px border=0 cellPadding=0 cellSpacing=0 id=secTable>
                <TBODY>
                  <TR align=middle height=20>
                    <TD align="center" class=sec2 onclick=secBoard(0)>通知消息</TD>
                   
                  </TR>
                </TBODY>
              </TABLE>
          <TABLE class=main_tab id=mainTable cellSpacing=0
cellPadding=0 width=100% border=0>
                <!--关于TBODY标记-->
                <TBODY style="DISPLAY: block">
                  <TR>
                    <TD vAlign=top align=middle><TABLE width=98% height="133" border=0 align="center" cellPadding=0 cellSpacing=0>
                        <TBODY>
                          <TR>
                            <TD height="5" colspan="3"></TD>
                          </TR>
                          <TR>
                            <TD width="4%" height="28" background="../images/news-title-bg.gif"></TD>
                            <TD height="25" colspan="2" background="../images/news-title-bg.gif" class="left_txt"><asp:Literal ID="litMessages" runat="server"></asp:Literal></TD>
                          </TR>
                          <TR>
                            <TD bgcolor="#FAFBFC">&nbsp;</TD>
                            <TD width="99%" height="112" bgcolor="#FAFBFC" colspan="2">
                            <div style="height:112px; overflow:auto">
                            <ul>
                            <asp:Repeater ID="rptMessages" runat="server">
    <ItemTemplate>
    <li><img src="..../images/ico04.gif" /> <%#DataBinder.Eval(Container.DataItem,"bt") %></li>
    </ItemTemplate>
    </asp:Repeater>
                            
                            </ul>
                            </div>
                            
                            </TD>
                          </TR>
                          
                          <TR>
                            <TD height="5" colspan="3"></TD>
                          </TR>
                        </TBODY>
                    </TABLE></TD>
                  </TR>
                </TBODY>
                </TD>
                  </TR>
                </TBODY>
            </TABLE></td>
        <td>&nbsp;</td>
        <td valign="top"><table width="100%" height="144" border="0" cellpadding="0" cellspacing="0" class="line_table">
          <tr>
            <td width="7%" height="27" background="../images/news-title-bg.gif"><img src="../images/news-title-bg.gif" width="2" height="27"></td>
            <td width="93%" background="../images/news-title-bg.gif" class="left_bt2">使用说明</td>
          </tr>
          <tr>
            <td height="102" valign="top">&nbsp;</td>
            <td height="102" valign="top">
              <label>
              <textarea name="textarea" cols="90" rows="8" class="left_txt">使用说明</textarea>
              </label></td>
          </tr>
          <tr>
            <td height="5" colspan="2">&nbsp;</td>
          </tr>
        </table></td>
      </tr>
      <tr>
        <td height="40" colspan="4"><table width="100%" height="1" border="0" cellpadding="0" cellspacing="0" bgcolor="#CCCCCC">
          <tr>
            <td></td>
          </tr>
        </table></td>
      </tr>
      <tr>
        <td width="2%">&nbsp;</td>
        <td width="51%" class="left_txt"><img src="../images/icon-mail2.gif" width="16" height="11"> 服务邮箱：1164781677@qq.com<br>
              <img src="../images/icon-phone.gif" width="17" height="14"> 官方网站：http://www.jneou.com</td>
        <td>&nbsp;</td>
        <td>&nbsp;</td>
      </tr>
    </table></td>
    <td background="../images/mail_rightbg.gif">&nbsp;</td>
  </tr>
  <tr>
    <td valign="bottom" background="../images/mail_leftbg.gif"><img src="../images/buttom_left2.gif" width="17" height="17" /></td>
    <td background="../images/buttom_bgs.gif"><img src="../images/buttom_bgs.gif" width="17" height="17"></td>
    <td valign="bottom" background="../images/mail_rightbg.gif"><img src="../images/buttom_right2.gif" width="16" height="17" /></td>
  </tr>
</table>
</body>
</html>
