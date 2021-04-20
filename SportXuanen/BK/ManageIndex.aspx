<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="ManageIndex.aspx.vb" Inherits="SportXuanen.ManageIndex" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html charset=utf-8"/>
    <meta name="viewport" content="width=device-width" />
    <title>後台管理</title>
    <script src="<%=ResolveClientUrl("~/script/jquery-1.11.0.js")%>"></script>
    <script src="<%=ResolveClientUrl("~/script/jquery-migrate-1.2.1.js")%>"></script>
    <script src="<%=ResolveClientUrl("~/script/function.js")%>"></script>
    <link type="text/css" rel="stylesheet" href="<%=ResolveClientUrl("~/css/funtitle.css")%>" />
    <link type="text/css" rel="stylesheet" href="<%=ResolveClientUrl("~/css/layout.css")%>" />
    <script type="text/javascript">
        var tHeight = getBrowserHeight() - 170;
        document.write("<style type='text/css'>");
        document.write("#left{height:" + tHeight + "px;;}");
        document.write("#center{height:" + tHeight + "px;;}");
        document.write("#right{height:" + tHeight + "px;;}");
        document.write("</style>");
    </script>
</head>
<body style="margin:0;padding:0;">
    <form runat="server">
    <table width="100%" border="0" cellspacing="0" cellpadding="0" style="border-collapse: collapse;">
	    <tr>
		    <td style="width:100%;">
                <div id="header">
                    <table width="100%" border="0" cellspacing="0" cellpadding="0">
  			            <tr>
    			            <td style="text-align:left">
    				            <asp:Label ID="LabelLogo" runat="server"></asp:Label>
    			            </td>
    			            <td style="text-align:right">
    				            <img src='../images/banner.png' height='65' alt='#' />
                            </td>
    		            </tr>
		            </table>
                </div>
            </td>
        </tr>
       <tr>
		    <td id="header2">
		    	<table width="100%" border="0" cellspacing="0" cellpadding="0">
		    		<tr>
                        <td><div style="width:222px;height:50px;background-color:#2b6d97;text-align:center;vertical-align:middle;line-height:50px;color:white;"><asp:Label ID="LabelFunTitle" runat="server"></asp:Label></div></td>
		    			<td width="97%"><div style="color:white;"><asp:Label ID="LabelFunTitle2" runat="server"></asp:Label></div></td>
		    			<td width="1%" nowrap align="right"><div style="color:black;"><asp:Label ID="LabelLoginName" runat="server"></asp:Label></div></td>
		    			<td width="1%" nowrap align="right"><asp:ImageButton ID="Logout_but" runat="server" ImageUrl="~/images/btn_logout.png" width="60" Visible="false" /></td>
		    		</tr>
		    	</table>
		    </td>
	    </tr>
        <tr>
		    <td style="width:100%;">
			    <div id="main">
                     <script type="text/javascript">
                         function GoPage(TargetUrl) {
                             $.ajax({
                                 type: 'post',
                                 url: TargetUrl,
                                 success: function (loaddata) {
                                     $('#MainDisplayArea').html(loaddata);
                                 },
                                 //顯示錯誤訊息
                                 error: function (XMLHttpRequest, textStatus, errorThrown) {
                                     $('#MainDisplayArea').html(XMLHttpRequest.readyState + XMLHttpRequest.status + XMLHttpRequest.responseText);
                                 }
                             });
                         }
                         function SetTitle(v) {
                             $('#LabelFunTitle2').html(v);
                         }
                         function funmenuclick(v,v2) {
                             $('div[id*="funmenusub0"]').hide();
                             $('div[class="funmenumain11"]').removeClass().addClass("funmenumain01");
                             v.className = "funmenumain11";
                             funsubclick(v2)
                         }
                         function funsubclick(v2) {
                             $('div[id*="funmenusub"]').hide();
                             $('#funmenusub' + v2).show();
                         }
                         function funlistclick(v) {
                             $('div[class="funmenulist33"]').removeClass().addClass("funmenulist03");
                             v.className = "funmenulist33";
                         }
                         function ReloadCaptchaImage() {
                             document.getElementById('CaptchaImage').src = '<%=ResolveClientUrl("~/BK/NewCaptcha.aspx")%>?img=' + Math.random();
                         }
                    </script>
                    <table width="100%" border="0" cellspacing="0" cellpadding="0">
	                    <tr>
                            <td align="center" class="funCSS" style="<%=MenuOpenStyle%>;">
			                    <asp:Label ID="menu_lab" runat="server"  ></asp:Label>
		                    </td>
		                    <td id="right" style="text-align:center;vertical-align:top;background-color:#F6F6F6">              
                                <div id="MainDisplayArea">
                                    <asp:Label ID="Message_Lab" runat="server"></asp:Label>
                                    <asp:Panel ID="Panel_login" runat="server" Visible ="false" >
                                        <center>
                                        <br /><br /><br /><br /><br />
                                        <table width="300" class="TABLECSS_Content" style="text-align:center">
                                            <tr >
                                                <td width="10%" nowrap="nowrap" class="TTCss">帳號</td>
                                                <td width="40%" nowrap="nowrap" class="TDCss" colspan="3" align="left" valign="top">
                                                    <asp:TextBox ID="txt_id"  runat="server"></asp:TextBox>
                                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="必填" ValidationGroup="tCheck" ControlToValidate="txt_id" Display="Dynamic" ForeColor="#FF3300"></asp:RequiredFieldValidator>
                                                </td>
                                            </tr>
                                            <tr >
                                                <td width="10%" nowrap="nowrap" class="TTCss">密碼</td>
                                                <td width="40%" nowrap="nowrap" class="TDCss" colspan="3" align="left" valign="top">
                                                    <asp:TextBox ID="txt_password" TextMode="Password" runat="server"></asp:TextBox>
                                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="必填" ValidationGroup="tCheck" ControlToValidate="txt_password" Display="Dynamic" ForeColor="#FF3300"></asp:RequiredFieldValidator>
                                                </td>
                                            </tr>
                                            <tr >
                                                <td width="10%" nowrap="nowrap" class="TTCss">驗證碼</td>
                                                <td width="40%" nowrap="nowrap" class="TDCss" colspan="3" align="left" valign="top">
                                                    <asp:TextBox ID="Captcha_text" autocomplete="off" runat="server"></asp:TextBox>
                                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="必填" ValidationGroup="tCheck" ControlToValidate="Captcha_text" Display="Dynamic" ForeColor="#FF3300"></asp:RequiredFieldValidator>
                                                    <br />
                                                    <asp:Image id="CaptchaImage" runat="server" ImageUrl="./NewCaptcha.aspx" ImageAlign="Middle" onclick="ReloadCaptchaImage()" style="cursor: pointer;" />
                                                </td>
                                            </tr>
                                            <tr >
                                                <td colspan="4" align="center" valign="top">
                                                    <asp:ImageButton ID="Login_but" runat="server" ImageUrl="~/images/btn_login.png" width="60" ValidationGroup="tCheck" />
                                                </td>
                                            </tr>
                                        </table>  
                                        </center>
                                    </asp:Panel>
                                </div>
		                    </td>
	                    </tr>
                    </table>
                </div>
            </td>
        </tr> 
        <tr>
		    <td style="width:100%;">
			    <div id="footer">
                    Copyright © 2020 璿恩資訊有限公司 All Rights Reserved
                </div>
            </td>
        </tr>
    </table>
    </form>
</body>
</html>
