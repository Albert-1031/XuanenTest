Imports System.Data.OleDb
Imports System.Data
Imports System.IO
Imports System.Security.Cryptography
Public Class AccMt
    Inherits System.Web.UI.Page
    Dim websystem As New websystem
    Dim pagesystem As New pagesystem
    Dim DataRecordID As Integer = 0
    Dim TotalCount As Integer
    Dim TotalPage As Integer
    Public PageSize As Integer = websystem.Fun_PageSize()
    Public CurrentPage As Integer
    Public DelList As String = ""
    Public 關鍵字 As String = ""
    Public 啟用狀態 As Integer = -1

    Public db_table_name As String = "WD01"
    Public function_module As String = "ManageFiles1"
    Public function_files As String = "AccMt"
    Public function_baseurl As String = "ManageIndex2.aspx?module=" & function_module & "&files=" & function_files
    Public function_formlist_url As String = function_baseurl
    Public function_PageRecord As String
    Public function_PageRecordBySeset As String

    Public PageTitleName As String = ""
    Public 功能資訊 As String()
    Public PowerStr As String = ""
    Public MenuOpenStyle As String = ""
    Public 網頁ID As Integer = 1
    Public RADE_R As String = ""
    Public RADE_A As String = ""
    Public RADE_D As String = ""
    Public RADE_E As String = ""
    Dim colspantotal As Integer = 7

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Session("BK") = Nothing Then
            '清除Session
            Session.RemoveAll()
            Response.Redirect("ManageIndex.aspx")
        End If

        subform_List.Action = function_formlist_url
        '記錄參數返回時要用
        function_PageRecord = function_baseurl & "&F2=" & Request("F2") & "&F3=" & Request("F3") & "&KW=" & Request("KW") & "&OP=" & Request("OP")
        '專門給返回按鈕用的
        function_PageRecordBySeset = function_baseurl & "&action=" & Request("action") & "&tFlag=" & Request("tFlag") & "&ID=" & Request("ID")

        'Fun_功能資訊(功能ID,帳號ID)
        '陣例(0)：ICON
        '陣列(1)：功能名稱
        '陣列(2)：授權
        功能資訊 = websystem.Fun_功能資訊後台(網頁ID, Session("BKID"))
        PageTitleName = 功能資訊(1)
        PowerStr = 功能資訊(2)

        '▼權限相關處理▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼
        RADE_R = "display:none"
        RADE_A = "display:none"
        RADE_E = "display:none"
        RADE_D = "display:none"

        If (InStr(1, PowerStr, "R")) >= 1 Then
            RADE_R = ""
        End If
        If (InStr(1, PowerStr, "A")) >= 1 Then
            RADE_A = ""
        End If
        If (InStr(1, PowerStr, "E")) >= 1 Then
            RADE_E = ""
        End If
        If (InStr(1, PowerStr, "D")) >= 1 Then
            LabelDelAll.Text += "  <th style=""width:1%"" align=""center"" nowrap=""nowrap""><input type=""checkbox"" onclick=""CheckAccess(0, this)"" name=""chkall"" title=""選擇或取消全部""></th>"
            colspantotal += 1
            RADE_D = ""
        End If
        '▲權限相關處理▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲

        '┬ 使用次數處理 ┬┬┬┬┬┬┬┬┬┬┬┬┬┬┬┬┬┬┬┬┬┬┬┬┬┬┬┬┬┬┬┬┬┬┬┬┬┬┬┬┬┬┬┬┬┬┬┬┬┬┬┬┬┬┬┬┬┬┬┬┬┬┬┬┬┬┬┬┬┬┬┬┬┬┬┬┬┬┬┐

        If Session("BKPoisiion") <> 功能資訊(1) Then
            Session.Remove("BKPoisiion")
            Session.Add("BKPoisiion", 功能資訊(1))
        End If

        '┴ 使用次數處理 ┴┴┴┴┴┴┴┴┴┴┴┴┴┴┴┴┴┴┴┴┴┴┴┴┴┴┴┴┴┴┴┴┴┴┴┴┴┴┴┴┴┴┴┴┴┴┴┴┴┴┴┴┴┴┴┴┴┴┴┴┴┴┴┴┴┴┴┴┴┴┴┴┴┴┴┴┴┴┴┘

        Select Case Request("tFlag")
            Case 0
                '防呆
                NewAndEditCheck()
            Case 1
                '新增
                PageTitle.Text = PageTitleName & " >> 新增"
                PanelEdit.Visible = True
                Edit_But.Visible = False
                lab_Button.Text += "<img src=""../images/btn_cancel.png"" border=""0"" width=""60"" onClick=""GoPage('" & function_PageRecord & "');"" />"
                lab_Button.Text += "<img src=""../images/btn_return.png"" border=""0"" width=""60"" onClick=""GoPage('" & function_PageRecordBySeset & "');"" />"

                subform_Action.Action = function_PageRecord & "&ID=" & DataRecordID & "&action=addin"
                Notic_Lab.Text = ""
            Case 2, 3
                '修改 , 觀看
                If IsNumeric(Request("ID")) Then DataRecordID = Request("ID")
                PanelEdit.Visible = True
                Add_But.Visible = False
                subform_Action.Action = function_PageRecord & "&ID=" & DataRecordID & "&action=editin"

                Dim conn As New SQL
                conn.SelectCommand = "select * from WD01 where d00=@d00"
                conn.SelectParameters.Add("d00", DataRecordID)
                Dim dv As Data.DataView = conn.SelectQuery()
                If dv.Count > 0 Then
                    If Not IsDBNull(dv.Item(0).Item("d01")) Then txt_Name.Text = dv.Item(0).Item("d01")
                    If Not IsDBNull(dv.Item(0).Item("d02")) Then txt_Acc.Text = dv.Item(0).Item("d02")
                    If Not IsDBNull(dv.Item(0).Item("d04")) Then
                        If dv.Item(0).Item("d04") = 0 Then rbn_state2.Checked = True
                    End If
                End If

                Select Case Request("tFlag")
                    Case "3"
                        PageTitle.Text = PageTitleName & " >> 觀看"
                        Edit_But.Visible = False
                        lab_Button.Text += "<img src=""../images/btn_cancel2.png"" border=""0"" width=""60"" onClick=""GoPage('" & function_PageRecord & "');"" />"

                        Notic_Lab.Text = ""

                        txt_Name.Enabled = False
                        txt_Acc.Enabled = False
                        txt_Code.Enabled = False
                        rbn_state1.Enabled = False
                        rbn_state2.Enabled = False
                    Case Else
                        PageTitle.Text = PageTitleName & " >> 修改"
                        lab_Button.Text += "<img src=""../images/btn_cancel.png"" border=""0"" width=""60"" onClick=""GoPage('" & function_PageRecord & "');"" />"
                        lab_Button.Text += "<img src=""../images/btn_return.png"" border=""0"" width=""60"" onClick=""GoPage('" & function_PageRecordBySeset & "');"" />"
                End Select
            Case 4
                '刪除
                DataRecordID = Request("ID")
                DelOne(DataRecordID)
                Response.Write("<script>GoPage('" & function_PageRecord & "');</script>")
            Case 5
                '勾選刪除
                Dim DelList As String = Request("D")
                If DelList <> "" Then
                    Dim DelList2() As String = Split(DelList, ",")
                    For i As Integer = 0 To DelList2.Length - 1
                        If IsNumeric(DelList2(i)) Then
                            DelOne(DelList2(i))
                        End If
                    Next
                End If
                Response.Write("<script>GoPage('" & function_PageRecord & "');</script>")
            Case 6, 7
                '觀看or設定權限
                '權限設定&內容
                If (InStr(1, PowerStr, "E")) >= 1 OrElse (InStr(1, PowerStr, "R")) >= 1 Then PanelPower.Visible = True
                If IsNumeric(Request("ID")) Then DataRecordID = Request("ID")

                Dim 帳號名稱 As String = websystem.Fun_欄位值("WD01", "d01", "d00", DataRecordID)
                If 帳號名稱 <> "" Then 帳號名稱 = " >> " & 帳號名稱

                PageTitle.Text = PageTitleName & 帳號名稱 & " >> 權限設定"
                powerform_Action.Action = function_PageRecord & "&ID=" & DataRecordID & "&action=powerin"

                Dim isDisabled As String = ""
                If Request("tFlag") = "7" Then
                    PageTitle.Text = PageTitleName & 帳號名稱 & " >> 權限內容"
                    Edit_But2.Visible = False
                    '返回
                    lab_Button2.Text += "<img src=""../images/btn_cancel2.png"" border=""0"" width=""60"" onClick=""GoPage('" & function_PageRecord & "');"" />"
                    isDisabled = " disabled"
                End If

                If InStr(1, PowerStr, "E") >= 1 Then
                    '取消
                    lab_Button2.Text += "<img src=""../images/btn_cancel.png"" border=""0"" width=""60"" onClick=""GoPage('" & function_PageRecord & "');"" />"
                    '復原
                    lab_Button2.Text += "<img src=""../images/btn_return.png"" border=""0"" width=""60"" onClick=""GoPage('" & function_PageRecordBySeset & "');"" />"
                End If

                Dim conn As New SQL
                conn.SelectCommand = "select X.群組ID,X.大分類,X.功能ID,X.小分類,X.權限,Y.Z03 as 授權 " &
                                     "from (select A.z00 as 群組ID,A.z02 as 大分類,A.z01 as BigSort,B.z00 as 功能ID,B.z02 as 小分類,B.z01 as SmallSort,B.z09 as 權限 from WZ01 A,WZ01 B where A.z00=B.z07 and A.z08=1 and B.z08=1) X " &
                                     "left join (select Z01,Z02,Z03 from WZ02 where Z01=@帳號ID) Y on X.功能ID=Y.Z02 " &
                                     "order by X.BigSort,X.SmallSort"
                conn.SelectParameters.Add("帳號ID", DataRecordID)
                Dim dv As Data.DataView = conn.SelectQuery()
                If dv.Count > 0 Then
                    If Request("tFlag") <> "7" Then LabelFunList.Text += "<div align=left><input type=checkbox name=dels onClick=CheckAccess2(this,0)>全選</div>"
                    LabelFunList.Text += "<table style=width:100%; border-collapse: collapse;padding: 0px;>"
                    Dim GroupName As String = ""
                    Dim isR As String = ""
                    Dim isA As String = ""
                    Dim isE As String = ""
                    Dim isD As String = ""
                    Dim 權限 As String = ""
                    Dim 授權 As String = ""
                    For kk As Integer = 0 To dv.Count - 1
                        If Not IsDBNull(dv.Item(kk).Item("權限")) Then 權限 = dv.Item(kk).Item("權限") Else 權限 = ""
                        If Not IsDBNull(dv.Item(kk).Item("授權")) Then 授權 = dv.Item(kk).Item("授權") Else 授權 = ""
                        If GroupName <> dv.Item(kk).Item("大分類") Then
                            GroupName = dv.Item(kk).Item("大分類")
                            LabelFunList.Text += "	<thead>"
                            LabelFunList.Text += "		<tr>"
                            LabelFunList.Text += "			<th align=left colspan=5  class=TTCssP>" & dv.Item(kk).Item("大分類")
                            If Request("tFlag") <> "7" Then
                                LabelFunList.Text += "			    <input type=checkbox name=dels onClick=CheckAccess2(this," & dv.Item(kk).Item("群組ID") & ")>全選"
                            End If
                            LabelFunList.Text += "			</th>"
                            LabelFunList.Text += "		</tr>"
                            LabelFunList.Text += "	</thead>"
                            LabelFunList.Text += "	<thead>"
                            LabelFunList.Text += "		<tr>"
                            LabelFunList.Text += "			<td style=width:40% class=TTCss>名稱</td>"
                            LabelFunList.Text += "			<td style=width:15% class=TTCss>觀看</td>"
                            LabelFunList.Text += "			<td style=width:15% class=TTCss>新增</td>"
                            LabelFunList.Text += "			<td style=width:15% class=TTCss>修改</td>"
                            LabelFunList.Text += "			<td style=width:15% class=TTCss>刪除</td>"
                            LabelFunList.Text += "		</tr>"
                            LabelFunList.Text += "	</thead>"
                        End If
                        LabelFunList.Text += "	<tbody>"
                        LabelFunList.Text += "	    <tr>"
                        LabelFunList.Text += "	        <td align=center valign=top class=TDCssP>" & dv.Item(kk).Item("小分類") & "</td>"
                        LabelFunList.Text += "	        <td align=center class=TDCssP valign=top>"
                        If InStr(權限, "R") > 0 Then
                            isR = ""
                            If InStr(授權, "R") > 0 Then isR = " checked"
                            isR = isR & isDisabled
                            LabelFunList.Text += "	            <input type=checkbox name=dels_" & dv.Item(kk).Item("群組ID") & "_" & dv.Item(kk).Item("功能ID") & " value=R" & isR & ">"
                        End If
                        LabelFunList.Text += "	        </td>"
                        LabelFunList.Text += "	        <td align=center class=TDCssP>"
                        If InStr(權限, "A") > 0 Then
                            isA = ""
                            If InStr(授權, "A") > 0 Then isA = " checked"
                            isA = isA & isDisabled
                            LabelFunList.Text += "	            <input type=checkbox name=dels_" & dv.Item(kk).Item("群組ID") & "_" & dv.Item(kk).Item("功能ID") & " value=A" & isA & ">"
                        End If
                        LabelFunList.Text += "	        </td>"
                        LabelFunList.Text += "	        <td align=center class=TDCssP>"
                        If InStr(權限, "E") > 0 Then
                            isE = ""
                            If InStr(授權, "E") > 0 Then isE = " checked"
                            isE = isE & isDisabled
                            LabelFunList.Text += "	            <input type=checkbox name=dels_" & dv.Item(kk).Item("群組ID") & "_" & dv.Item(kk).Item("功能ID") & " value=E" & isE & ">"
                        End If
                        LabelFunList.Text += "	        </td>"
                        LabelFunList.Text += "	        <td align=center class=TDCssP>"
                        If InStr(權限, "D") > 0 Then
                            isD = ""
                            If InStr(授權, "D") > 0 Then isD = " checked"
                            isD = isD & isDisabled
                            LabelFunList.Text += "	            <input type=checkbox name=dels_" & dv.Item(kk).Item("群組ID") & "_" & dv.Item(kk).Item("功能ID") & " value=D" & isD & ">"
                        End If
                        LabelFunList.Text += "	        </td>"
                        LabelFunList.Text += "	    </tr>"
                        LabelFunList.Text += "	</tbody>"
                    Next
                    LabelFunList.Text += "</table>"
                End If
            Case Else
                If (InStr(1, PowerStr, "R")) >= 1 Then PageTitle.Text = PageTitleName : PanelList.Visible = True

                Dim conn As New SQL

                '■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■
                'pagesize(幾筆分一頁)
                If Request("F2") <> "" AndAlso IsNumeric(Request("F2")) Then PageSize = Request("F2")
                If Request("F3") <> "" AndAlso IsNumeric(Request("F3")) Then CurrentPage = Request("F3")
                '分頁相關 START◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆

                If Request("KW") <> "" Then 關鍵字 = websystem.xss(Request("KW"))
                If IsNumeric(Request("OP")) Then 啟用狀態 = Request("OP")
                KeyWord_text.Value = 關鍵字
                OpenStr_drop.Value = 啟用狀態

                '取得「總頁數」
                Dim SQL As String = " select count(*) from WD01 where 1=1 "
                If 關鍵字.Length > 0 Then
                    SQL = SQL & " and (d01 like @KeyWord or d02 like @KeyWord) "
                    conn.SelectParameters.Add("KeyWord", "%" & 關鍵字 & "%")
                End If
                If 啟用狀態 <> -1 Then
                    SQL = SQL & "and (d04=@d04) "
                    conn.SelectParameters.Add("d04", 啟用狀態)
                End If
                conn.SelectCommand = SQL
                Dim dv1 As Data.DataView = conn.SelectQuery()
                If dv1.Count > 0 Then
                    TotalCount = dv1.Item(0).Item(0)
                    If dv1.Item(0).Item(0) Mod PageSize > 0 Then
                        TotalPage = (dv1.Item(0).Item(0) \ PageSize) + 1
                    Else
                        TotalPage = (dv1.Item(0).Item(0) \ PageSize)
                    End If
                Else
                    TotalCount = 0
                    TotalPage = 0
                End If
                If CurrentPage > TotalPage Then CurrentPage = TotalPage
                If CurrentPage = 0 Then CurrentPage = 1
                Dim ArgName As String = "flag,flag2,flag3,flag4"
                Dim NecURL As String = "'" & function_baseurl & "&F2=' + flag + '&F3=' + flag2 + '&KW=' + flag3 + '&OP=' + flag4 "
                Dim UniURL As String = ",'" & 關鍵字 & "','" & 啟用狀態 & "'"
                If TotalCount <> 0 Then
                    CPage1.Text = pagesystem.UrlReq(ArgName, NecURL, UniURL, CurrentPage, TotalPage, PageSize)
                    CPage2.Text = pagesystem.UrlReq(ArgName, NecURL, UniURL, CurrentPage, TotalPage, PageSize)
                End If
                '分頁相關   END◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆

                SQL = "SELECT * FROM ( " &
                      "    select Row_number() OVER (ORDER BY d00 desc) as Serial,* from WD01 where 1=1 "
                If 關鍵字.Length > 0 Then
                    SQL = SQL & " and (d01 like @KeyWord2 or d02 like @KeyWord2) "
                    conn.SelectParameters.Add("KeyWord2", "%" & 關鍵字 & "%")
                End If
                If 啟用狀態 <> -1 Then
                    SQL = SQL & "and (d04=@d04_2) "
                    conn.SelectParameters.Add("d04_2", 啟用狀態)
                End If
                SQL += ") AS Thread "
                SQL += "where (Thread.Serial > (@pagenum * @PageSize)) and (Thread.Serial <= ((@pagenum+1) * @PageSize))"
                conn.SelectCommand = SQL
                conn.SelectParameters.Add("pagenum", CurrentPage - 1)
                conn.SelectParameters.Add("PageSize", TypeCode.Int32, PageSize.ToString())
                Dim dv As Data.DataView = conn.SelectQuery()
                Try
                    If dv.Count > 0 Then
                        Repeater1.Visible = True
                        LabelNoData.Visible = False
                        Dim pds As PagedDataSource = New PagedDataSource()
                        pds.DataSource = dv
                        pds.AllowPaging = False
                        Repeater1.DataSource = pds
                        Repeater1.DataBind()
                        conn.DataBind()
                    Else
                        Repeater1.Visible = False
                        LabelNoData.Visible = True
                        LabelNoData.Text = "<tr class=""TDCss""><td colspan=" & colspantotal & " align=""center"">目前沒有任何資料</td></tr>"
                    End If
                Catch ex As Exception
                    Repeater1.Visible = False
                    LabelNoData.Visible = True
                    If Session("SportAcc") = "allec" Then
                        LabelNoData.Text = "<tr class=""TDCss""><td colspan=" & colspantotal & " align=""center""><font color=red>" & ex.Message & "</font></td></tr>"
                    Else
                        LabelNoData.Text = "<tr class=""TDCss""><td colspan=" & colspantotal & "  align=""center"">目前沒有任何資料</td></tr>"
                    End If
                End Try
        End Select
    End Sub

    Sub DelOne(ByVal DelId As String)
        Dim conn As New SQL

        'Sub_系統操作記錄(陣列)
        '陣列(0)=功能名稱
        '陣列(1)=操作方式
        '陣列(2)=操作人員
        '陣列(3)=操作說明
        '陣列(4)=詳細資料
        Dim 系統操作記錄 As String() = {"", "", "", "", "", ""}
        系統操作記錄(0) = "帳號密碼管理"
        系統操作記錄(1) = "刪除"
        系統操作記錄(2) = Session("BK")
        系統操作記錄(3) = DelId
        系統操作記錄(4) = "編號@@★@@" & DelId
        websystem.Sub_系統操作記錄(系統操作記錄)

        conn.DeleteCommand = "delete from " & db_table_name & " where d00=@d00"
        conn.DeleteParameters.Add("d00", DelId)
        conn.Delete()
    End Sub

    Sub NewAndEditCheck()
        Dim E As String = "0"
        Dim MsgStr As String = ""
        DataRecordID = Request("ID")
        Dim ActSTE As String = Request.QueryString("action")

        Dim conn As New SQL

        Select Case ActSTE
            Case "powerin"
                '先刪除舊資料
                conn.DeleteCommand = "delete from WZ02 where Z01=@Z01"
                conn.DeleteParameters.Add("Z01", DataRecordID)
                conn.Delete()

                '再重新新增
                Dim b As String
                Using a = New StreamReader(Request.InputStream)
                    b = a.ReadToEnd
                End Using
                Dim c() As String = Split(b, "&")
                conn.SelectCommand = "select A.z00 as 群組ID,B.z00 as 功能ID " &
                                     "from WZ01 A,WZ01 B " &
                                     "where A.z00=B.z07 and A.z08=1 and B.z08=1 " &
                                     "order by A.z01,B.z01"
                Dim dv As Data.DataView = conn.SelectQuery()
                If dv.Count > 0 Then
                    For kk As Integer = 0 To dv.Count - 1
                        Dim conn2 As New SQL

                        Dim thisValue As String = ""
                        'checkbox dels_群組ID_功能ID
                        For kk2 As Integer = 0 To c.Length - 1
                            If c(kk2).IndexOf("dels_" & dv.Item(kk).Item("群組ID") & "_" & dv.Item(kk).Item("功能ID") & "=") <> -1 Then
                                thisValue = thisValue & c(kk2).Split("=")(1)
                            End If
                        Next

                        If thisValue <> "" Then
                            conn2.InsertCommand = "insert into WZ02(z01,z02,z03)values(@z01,@z02,@z03)"
                            conn2.InsertParameters.Add("z01", DataRecordID)
                            conn2.InsertParameters.Add("z02", dv.Item(kk).Item("功能ID"))
                            conn2.InsertParameters.Add("z03", thisValue)
                            conn2.Insert()
                        End If
                    Next
                End If

                'Sub_系統操作記錄(陣列)
                '陣列(0)=功能名稱
                '陣列(1)=操作方式
                '陣列(2)=操作人員
                '陣列(3)=操作說明
                '陣列(4)=詳細資料

                'Fun_欄位值(資料表名稱,欄位名稱,自動編號欄位名稱,自動編號)
                Dim 修改人姓名 As String = ""
                修改人姓名 = websystem.Fun_欄位值("WD01", "d01", "d00", DataRecordID)

                Dim 系統操作記錄 As String() = {"", "", "", "", "", ""}
                系統操作記錄(0) = "帳號密碼管理"
                系統操作記錄(1) = "修改"
                系統操作記錄(2) = Session("BK")
                系統操作記錄(3) = "修改權限"
                系統操作記錄(4) = "姓名@@★@@" & 修改人姓名
                websystem.Sub_系統操作記錄(系統操作記錄)

                MsgStr = "修改成功"
                GoTo DoEnd
            Case Else
                'd01 姓名
                Dim d01 As String = websystem.xss(Request.Form("txt_Name"))
                If d01.Length = 0 Then
                    E = "1"
                    MsgStr = "姓名不可以空白"
                    GoTo DoEnd
                Else
                    'websystem.Fun_重複(資料表名稱,自動編號,自動編號欄位名稱,判斷欄位名稱,判斷內容值)
                    If websystem.Fun_重複(db_table_name, DataRecordID, "d00", "d01", d01) Then
                        E = "1"
                        MsgStr = "姓名重複"
                        GoTo DoEnd
                    End If
                End If

                'd02 帳號
                Dim d02 As String = websystem.xss(Request.Form("txt_Acc"))
                If d02.Length = 0 Then
                    E = "1"
                    MsgStr = "帳號不可以空白"
                    GoTo DoEnd
                Else
                    'websystem.Fun_重複(資料表名稱,自動編號,自動編號欄位名稱,判斷欄位名稱,判斷內容值)
                    If websystem.Fun_重複(db_table_name, DataRecordID, "d00", "d02", d02) Then
                        E = "1"
                        MsgStr = "帳號重複"
                        GoTo DoEnd
                    End If
                End If

                'd03 密碼
                Dim d03 As String = websystem.xss(Request.Form("txt_Code"))
                If ActSTE = "addin" AndAlso d03 = "" Then
                    E = "1"
                    MsgStr = "密碼不可以空白"
                    GoTo DoEnd
                End If

                'd04 啟用狀態 rbn_state1啟用(1)、rbn_state2停用(0)
                Dim d04 As Integer = 1
                Dim 啟用狀態 As String = "啟用"
                If Request.Form("rbn_state") = "rbn_state2" Then d04 = 0 : 啟用狀態 = "停用"

                '再做資料寫入
                If E = "0" Then
                    Select Case ActSTE
                        Case "editin"
                            Dim 修改前WD01 As String = Fun_WD01內容(DataRecordID)

                            conn.UpdateCommand = " update " & db_table_name & " set d01=@d01,d02=@d02,d04=@d04 where d00=@d00"
                            conn.UpdateParameters.Add("d01", d01)
                            conn.UpdateParameters.Add("d02", d02)
                            conn.UpdateParameters.Add("d04", d04)
                            conn.UpdateParameters.Add("d00", DataRecordID)
                            conn.Update()

                            If d03.Length > 0 Then
                                d03 = websystem.GetMd5Hash(websystem.xss("all" & d03.Trim("") & "ec"))

                                conn.UpdateCommand = "update " & db_table_name & " set d03=@d03 where d00=@d00_2 "
                                conn.UpdateParameters.Add("d00_2", DataRecordID)
                                conn.UpdateParameters.Add("d03", d03)
                                conn.Update()
                            End If

                            Dim 修改後WD01 As String = Fun_WD01內容(DataRecordID)

                            If 修改前WD01 <> 修改後WD01 Then
                                'Sub_系統操作記錄(陣列)
                                '陣列(0)=功能名稱
                                '陣列(1)=操作方式
                                '陣列(2)=操作人員
                                '陣列(3)=操作說明
                                '陣列(4)=詳細資料

                                Dim 系統操作記錄 As String() = {"", "", "", "", "", ""}
                                系統操作記錄(0) = "帳號密碼管理"
                                系統操作記錄(1) = "修改"
                                系統操作記錄(2) = Session("BK")
                                系統操作記錄(3) = d01
                                系統操作記錄(4) = "姓名@@☆@@帳號@@☆@@啟用@@★@@" & d01 & "@@☆@@" & d02 & "@@☆@@" & 啟用狀態
                                websystem.Sub_系統操作記錄(系統操作記錄)
                            End If

                            MsgStr = "修改成功"
                        Case "addin"
                            d03 = websystem.GetMd5Hash(websystem.xss("all" & d03.Trim("") & "ec"))

                            conn.InsertCommand = "insert into " & db_table_name & "(d01,d02,d03,d04) values(@d01,@d02,@d03,@d04)"
                            conn.InsertParameters.Add("d01", d01)
                            conn.InsertParameters.Add("d02", d02)
                            conn.InsertParameters.Add("d03", d03)
                            conn.InsertParameters.Add("d04", d04)
                            conn.Insert()

                            'Sub_系統操作記錄(陣列)
                            '陣列(0)=功能名稱
                            '陣列(1)=操作方式
                            '陣列(2)=操作人員
                            '陣列(3)=操作說明
                            '陣列(4)=詳細資料
                            Dim 系統操作記錄 As String() = {"", "", "", "", "", ""}
                            系統操作記錄(0) = "帳號密碼管理"
                            系統操作記錄(1) = "新增"
                            系統操作記錄(2) = Session("BK")
                            系統操作記錄(3) = d01
                            系統操作記錄(4) = "姓名@@☆@@帳號@@☆@@啟用@@★@@" & d01 & "@@☆@@" & d02 & "@@☆@@" & 啟用狀態
                            websystem.Sub_系統操作記錄(系統操作記錄)

                            MsgStr = "新增成功"
                    End Select
                End If
        End Select

DoEnd:
        Response.Write(E & "," & MsgStr & ",")
        Return
    End Sub

    Private Sub Repeater1_ItemDataBound(sender As Object, e As RepeaterItemEventArgs) Handles Repeater1.ItemDataBound
        If (e.Item.ItemType = ListItemType.Item) Or (e.Item.ItemType = ListItemType.AlternatingItem) Then
            If Not IsDBNull(e.Item.DataItem("d04")) Then
                If e.Item.DataItem("d04") = 1 Then
                    CType(e.Item.FindControl("lab_Status"), Label).Text = "啟用"
                Else
                    CType(e.Item.FindControl("lab_Status"), Label).Text = "<font color=red>停用</font>"
                End If

                '勾選刪除
                If (InStr(1, PowerStr, "D")) >= 1 Then
                    CType(e.Item.FindControl("LabelDelA"), Label).Text = "<td style=""width:1%"" align=""center"" nowrap=""nowrap""><input type=""checkbox"" value=""" & e.Item.DataItem("d00") & """ name=""dels""></td>"
                Else
                    CType(e.Item.FindControl("LabelDelA"), Label).Text = ""
                End If

                ''權限
                If (InStr(1, PowerStr, "E")) >= 1 Then
                    CType(e.Item.FindControl("LabelPower"), Label).Text = "<img src=""../images/power.gif"" border=""0"" title=""權限設定"" onclick=""GoPage('" & function_PageRecord & "&tFlag=6&ID=" & e.Item.DataItem("d00") & "');"" />"
                Else
                    CType(e.Item.FindControl("LabelPower"), Label).Text = "<img src=""../images/power.gif"" border=""0"" title=""權限內容"" onclick=""GoPage('" & function_PageRecord & "&tFlag=7&ID=" & e.Item.DataItem("d00") & "');"" />"
                End If
            End If
        End If
    End Sub

    Function Fun_WD01內容(ByVal tID As Integer) As String
        Dim WD01內容 As StringBuilder = New StringBuilder

        Dim connF As New SQL
        connF.SelectCommand = "select * from WD01 where d00=@d00"
        connF.SelectParameters.Add("d00", tID)
        Dim dvF As Data.DataView = connF.SelectQuery()
        If dvF.Count > 0 Then
            Dim d01 As String = ""
            Dim d02 As String = ""
            Dim d03 As String = ""
            Dim d04 As String = ""

            If Not IsDBNull(dvF.Item(0).Item("d01")) Then d01 = dvF.Item(0).Item("d01")
            If Not IsDBNull(dvF.Item(0).Item("d02")) Then d02 = dvF.Item(0).Item("d02")
            If Not IsDBNull(dvF.Item(0).Item("d03")) Then d03 = dvF.Item(0).Item("d03")
            If Not IsDBNull(dvF.Item(0).Item("d04")) Then d04 = dvF.Item(0).Item("d04")

            WD01內容.Append(d01 & "、")
            WD01內容.Append(d02 & "、")
            WD01內容.Append(d03 & "、")
            WD01內容.Append(d04 & "、")
        End If

        Return WD01內容.ToString()
    End Function
End Class