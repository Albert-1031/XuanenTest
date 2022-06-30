<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="AccMt.aspx.vb" Inherits="SportXuanen.AccMt" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <div class="KeyWord" align="left"><asp:Label ID="PageTitle" runat="server"></asp:Label></div>
    <asp:Panel ID="PanelList" runat="server" Visible="false">
        <script>
            $("#subform_List").submit(function (e) {
                var formObj = $(this);
                var formURL = formObj.attr("action");
                
                var KeyWord = KeyWord_text.value;
                var OpenStr = OpenStr_drop.value;
                var SendUrl = formURL + '&KW=' + KeyWord + '&OP=' + OpenStr ; 
                GoPage(SendUrl);
                return false;
            });
            function CheckAccess(flag, flag2) {
                var tDels = '';
                var form = document.getElementById("subform_List");
                var len = form.elements.length;
                for (var i = 0; i < len; i++) {
                    var e = form.elements[i];
                    if (e.name == 'dels') {
                        if (flag == 0) {
                            if (flag2.checked) { e.checked = true; } else { e.checked = false; }
                        } else {
                            if (e.checked) {
                                if (tDels == '') {
                                    tDels = e.value;
                                } else {
                                    tDels = tDels + ',' + e.value;
                                }
                            }
                        }
                    }
                }
                return tDels;
            }
        </script>
        <table style="width:100%; border-collapse: collapse;padding: 0px;">
            <tr>
                <td align="left">
                <form id="subform_List" runat="server">
                    <span>啟用狀態：</span>
                    <select id="OpenStr_drop" runat="server">
                        <option value="-1">全部</option>
                        <option value="0">停用</option>
                        <option value="1">啟用</option>
                    </select>
                    <span>關鍵字查詢：</span>
                    <input type="text" id="KeyWord_text" name="KeyWord_text" size="15" runat="server"/>
                    <asp:Button ID="Search_But" runat="server" Text="搜尋" /> 
                    <br/>
                    <img src="../images/Add.ico" border="0"  style="<%=RADE_A%>" title="新增" onclick ="GoPage('<%=function_PageRecord%>&tFlag=1');" />
                    <img src="<%=ResolveClientUrl("~/images/Del.ico")%>" border="0"  style="<%=RADE_D%>"  title="勾選刪除" onclick ="if(confirm('確定刪除資料？')){GoPage('<%=function_PageRecord%>&tFlag=5&D='+ CheckAccess(1,1) );}" />
                    <br/>
                    <asp:Label ID="CPage1" runat="server"></asp:Label> 
                    <table width="100%" id="subform_list2" class="tablesorter">
                        <thead> 
                            <tr class="table_TTCss">
                                <asp:Label ID="LabelDelAll" runat="server"></asp:Label>
                                <th style="width:1%" align="center" nowrap="nowrap">項次</th>
                                <th style="width:1%" align="center" nowrap="nowrap">姓名</th>
                                <th style="width:1%" align="center" nowrap="nowrap">帳號</th>
                                <th style="width:1%" align="center" nowrap="nowrap">啟用狀態</th>
                                <th style="width:1%" align="center" nowrap="nowrap">最後登入時間</th>
                                <th style="width:1%" align="center" nowrap="nowrap">執行</th>
                            </tr>
                        </thead>
                        <tbody> 
                            <asp:Repeater ID="Repeater1" runat="server">
                                <ItemTemplate>
                                    <tr class="table_TDCss">
                                        <asp:Label ID="LabelDelA" runat="server"></asp:Label>
                                        <td style="width:1%" align="center" nowrap="nowrap"><%# DataBinder.Eval(Container.DataItem, "Serial")%></td>
                                        <td style="width:1%" align="center" nowrap="nowrap"><%# DataBinder.Eval(Container.DataItem, "d01")%></td>
                                        <td style="width:1%" align="center" nowrap="nowrap"><%# DataBinder.Eval(Container.DataItem, "d02")%></td>
                                        <td style="width:1%" align="center" nowrap="nowrap"><asp:Label ID="lab_Status" runat="server"></asp:Label></td>
                                        <td style="width:1%" align="center" nowrap="nowrap"><%# DataBinder.Eval(Container.DataItem, "d05")%></td>
                                        <td style="width:1%" align="center" nowrap="nowrap">
                                            <img src="../images/search.ico" border="0" title="觀看" style="<%=RADE_R%>" onclick ="GoPage('<%=function_PageRecord%>&tFlag=3&ID=<%# DataBinder.Eval(Container.DataItem, "d00")%>');" />
                                            <img src="../images/edit.png" border="0" title="修改"  style="<%=RADE_E%>"  onclick ="GoPage('<%=function_PageRecord%>&tFlag=2&ID=<%# DataBinder.Eval(Container.DataItem, "d00")%>');" />
                                            <img src="../images/del.ico" border="0" title="刪除"  style="<%=RADE_D%>"  onclick ="if(confirm('確定刪除資料？')){GoPage('<%=function_PageRecord%>&tFlag=4&ID=<%# DataBinder.Eval(Container.DataItem, "d00")%>');}" />
                                            <asp:Label ID="LabelPower" runat="server"></asp:Label>
                                        </td>
                                    </tr>
                                </ItemTemplate>
                                <AlternatingItemTemplate>
                                    <tr class="table_TDCss2">
                                        <asp:Label ID="LabelDelA" runat="server"></asp:Label>
                                        <td style="width:1%" align="center" nowrap="nowrap"><%# DataBinder.Eval(Container.DataItem, "Serial")%></td>
                                        <td style="width:1%" align="center" nowrap="nowrap"><%# DataBinder.Eval(Container.DataItem, "d01")%></td>
                                        <td style="width:1%" align="center" nowrap="nowrap"><%# DataBinder.Eval(Container.DataItem, "d02")%></td>
                                        <td style="width:1%" align="center" nowrap="nowrap"><asp:Label ID="lab_Status" runat="server"></asp:Label></td>
                                        <td style="width:1%" align="center" nowrap="nowrap"><%# DataBinder.Eval(Container.DataItem, "d05")%></td>
                                        <td style="width:1%" align="center" nowrap="nowrap">
                                            <img src="../images/search.ico" border="0" title="觀看" style="<%=RADE_R%>" onclick ="GoPage('<%=function_PageRecord%>&tFlag=3&ID=<%# DataBinder.Eval(Container.DataItem, "d00")%>');" />
                                            <img src="../images/edit.png" border="0" title="修改"  style="<%=RADE_E%>"  onclick ="GoPage('<%=function_PageRecord%>&tFlag=2&ID=<%# DataBinder.Eval(Container.DataItem, "d00")%>');" />
                                            <img src="../images/del.ico" border="0" title="刪除"  style="<%=RADE_D%>"  onclick ="if(confirm('確定刪除資料？')){GoPage('<%=function_PageRecord%>&tFlag=4&ID=<%# DataBinder.Eval(Container.DataItem, "d00")%>');}" />
                                            <asp:Label ID="LabelPower" runat="server"></asp:Label>
                                        </td>
                                    </tr>
                                </AlternatingItemTemplate>
                            </asp:Repeater>
                        </tbody> 
                        <asp:Label ID="LabelNoData" runat="server" Visible="false"></asp:Label>
                    </table>
                    <asp:Label ID="CPage2" runat="server"></asp:Label>
                </form>
                </td>
            </tr>
        </table>
    </asp:Panel>
    <asp:Panel ID="PanelEdit" runat="server" Visible="false">
        <script>
            $("#subform_Action").submit(function (e) {
                var CheckFlag = true 
                var formObj = $(this);
                var formURL = formObj.attr("action");
                var formURL1 = formObj.attr("action") + '&tFlag=0';

                var formData = new FormData();
                formData.append("txt_Name", $('#txt_Name').val());
                formData.append("txt_Acc", $('#txt_Acc').val());
                formData.append("txt_Code", $('#txt_Code').val());
                formData.append("hidden_Code", $('#hidden_Code').val());
                formData.append("rbn_state", $('input[name=rbn_state]:checked').val());

                e.preventDefault();
                $.ajax({
                    url: formURL1,
                    type: 'POST',
                    data: formData,
                    async: false,
                    cache: false,
                    contentType: false,
                    processData: false,
                    success: function (data) {
                        var m1 = data.split(",");
                        if(m1[0]==1){
                            CheckFlag = false;
                        }
                        alert(m1[1]);
                    }
                });
                if (CheckFlag) {
                    GoPage(formURL);
                }
                return false;
            });
        </script>
        <table style="width:100%; border-collapse: collapse;padding: 0px;">
            <tr>
                <td align="left">
                    <form id="subform_Action" runat="server"> 
                        <br/>
                        <table width="50%" class="TABLECSS_Content" style="text-align:center">
                            <tr>
                                <td width="10%" nowrap="nowrap" class="TTCss"><span class="ReqCss">*</span>姓名</td>
                                <td width="40%" nowrap="nowrap" class="TDCss" align="left" valign="top">
                                    <asp:TextBox ID="txt_Name" MaxLength="10" runat="server"></asp:TextBox>
                                </td>
                            </tr>
                            <tr>
                                <td width="10%" nowrap="nowrap" class="TTCss"><span class="ReqCss">*</span>帳號</td>
                                <td width="40%" nowrap="nowrap" class="TDCss" align="left" valign="top">
                                    <asp:TextBox ID="txt_Acc" MaxLength="20" runat="server"></asp:TextBox>
                                </td>
                            </tr>
                            <tr>
                                <td width="10%" nowrap="nowrap" class="TTCss"><span class="ReqCss">*</span>密碼</td>
                                <td width="40%" nowrap="nowrap" class="TDCss" align="left" valign="top">
                                    <asp:TextBox ID="txt_Code" MaxLength="20" TextMode="Password" runat="server" PasswordChar="*"></asp:TextBox>
                                    <asp:HiddenField ID="hidden_Code" runat="server" />
                                    <asp:Label ID="Notic_Lab" runat="server" Text="(如不修改可留空)"></asp:Label>
                                </td>
                            </tr>
                            <tr>
                                <td width="10%" nowrap="nowrap" class="TTCss"><span class="ReqCss">*</span>啟用</td>
                                <td width="40%" nowrap="nowrap" class="TDCss" align="left" valign="top">
                                    <asp:RadioButton ID="rbn_state1" GroupName="rbn_state" Text="啟用" Checked="true" runat="server" />
                                    <asp:RadioButton ID="rbn_state2" GroupName="rbn_state" Text="停用" runat="server" />
                                </td>
                            </tr>
                            <tr>
                                <td colspan="2" align="center" valign="top">
                                    <asp:ImageButton ID="Add_But" runat="server" ImageUrl="~/images/btn_submit.png" width="60" />
                                    <asp:ImageButton ID="Edit_But" runat="server" ImageUrl="~/images/btn_submit.png" width="60" />
                                    <asp:Label ID="lab_Button" runat="server"/>
                                </td>
                            </tr>
                        </table>
                    </form>
                </td>
            </tr>
        </table>
    </asp:Panel>
    <asp:Panel ID="PanelPower" runat="server" Visible="false">
        <script>
            $("#powerform_Action").submit(function (e) {
                var CheckFlag = true 
                var formObj = $(this);
                var formURL = formObj.attr("action");
                var formURL1 = formObj.attr("action") + '&tFlag=0';
                var formData=$('#powerform_Action').serialize();
                e.preventDefault();
                $.ajax({
                    url: formURL1,
                    type: 'POST',
                    data: formData,
                    async: false,
                    cache: false,
                    contentType: false,
                    processData: false,
                    success: function (data) {
                        var m1 = data.split(",");
                        if(m1[0]==1){ 
                            CheckFlag = false;
                        } 
                        alert(m1[1]);
                    }
                });
                if (CheckFlag) {
                    GoPage(formURL);
                }
                return false;
            });
            function CheckAccess2(flag,flag2) {
                var form = document.getElementById("powerform_Action");
                var len = form.elements.length;
                for (var i = 0; i < len; i++) {
                    var e = form.elements[i];
                    if(flag2==0) {
                        if (flag.checked) { e.checked = true; } else { e.checked = false; }
                    }
                    else {
                        if (e.name.indexOf('_'+flag2+'_') != -1) {
                            if (flag.checked) { e.checked = true; } else { e.checked = false; }
                        }
                    }
                }
            }
        </script>
        <table style="width:100%; border-collapse: collapse;padding: 0px;">
            <tr>
                <td>
                    <form id="powerform_Action" runat="server"> 
                        <br/>
                        <table width="50%" class="TABLECSS_Content" style="text-align:center">
                            <tr>
                                <td colspan="2" width="100%" align="center" valign="top">
                                    <asp:Label ID="LabelFunList" runat="server" Visible="true"></asp:Label>
                                </td>
                            </tr>
                            <tr>
                                <td colspan="2" width="100%" align="center" valign="top">
                                    <asp:ImageButton ID="Edit_But2" runat="server" ImageUrl="~/images/btn_submit.png" width="60" />
                                    <asp:Label ID="lab_Button2" runat="server"/>
                                </td>
                            </tr>
                        </table>
                    </form>
                </td>
            </tr>
        </table>
    </asp:Panel>
</body>
</html>