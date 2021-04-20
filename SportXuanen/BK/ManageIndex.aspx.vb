Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Web
Imports System.Web.UI
Imports System.Web.UI.WebControls
Public Class ManageIndex
    Inherits System.Web.UI.Page
    Dim websystem As New websystem
    Public 功能資訊 As String()

    Public PowerStr As String = ""
    Public MenuOpenStyle As String = ""

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        '清除快取
        Response.Cache.SetCacheability(HttpCacheability.Public)
        Response.Cache.SetAllowResponseInBrowserHistory(False)

        LabelLogo.Text = "<div id='logo' style=""height: 60px;""><img src='" & ResolveClientUrl("~/images/logo_main.png") & "' height='60px' alt='#' /></div>"

        If Session("BK") <> Nothing Then
            LabelLoginName.Text = Session("BK") & "，您好！"
            Logout_but.Visible = True

            LabelFunTitle.Text = "作業項目"

            MenuOpenStyle = ""
            Panel_login.Visible = False
            Message_Lab.Text = ""
            CreateMenu()
        Else
            LabelLoginName.Text = "您好！"

            MenuOpenStyle = "display:none;"
            Panel_login.Visible = True
        End If
    End Sub

    Private Sub Login_but_Click(sender As Object, e As EventArgs) Handles Login_but.Click
        If Trim(txt_id.Text) <> Nothing AndAlso Trim(txt_password.Text) <> Nothing AndAlso Trim(Captcha_text.Text) = Session("CaptchaCode") Then
            '清除Session
            Session.RemoveAll()

            Dim IP As String = ""
            If HttpContext.Current.Request.ServerVariables("HTTP_X_FORWARDED_FOR") = String.Empty Then
                IP = HttpContext.Current.Request.ServerVariables("REMOTE_ADDR").ToString()
            Else
                IP = HttpContext.Current.Request.ServerVariables("HTTP_X_FORWARDED_FOR").ToString()
            End If

            '▼測試用▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼
            If IP = "::1" Then IP = "localhost"
            '▲測試用▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲

            Session.Add("IP", IP)

            Dim conn As New SQL
            Dim websystem As New websystem
            Dim 密碼 As String = websystem.GetMd5Hash(websystem.xss("all" & txt_password.Text.Trim(" ") & "ec"))
            conn.SelectCommand = "select * from WD01 where d02=@d02 and d03=@d03 and d04=1 "
            conn.SelectParameters.Add("d02", websystem.xss(txt_id.Text.Trim(" ")))
            conn.SelectParameters.Add("d03", 密碼)
            Dim dv As Data.DataView = conn.SelectQuery()
            If dv.Count > 0 Then
                Session.Add("BKID", dv.Item(0).Item("d00"))
                Session.Add("BK", dv.Item(0).Item("d01"))
                Session.Add("BKPoisiion", "Index")

                'd06    最後登入時間    getdate()
                'd07    最後登入IP      登入IP
                conn.UpdateCommand = "update WD01 set d05=getdate(),d06=@d06 where d00=@d00"
                conn.UpdateParameters.Add("d06", Session("IP"))
                conn.UpdateParameters.Add("d00", dv.Item(0).Item("d00"))
                conn.Update()

                'Sub_系統操作記錄(陣列)
                '陣列(0)=功能名稱
                '陣列(1)=操作方式
                '陣列(2)=操作人員
                '陣列(3)=操作說明
                '陣列(4)=詳細資料
                Dim 系統操作記錄 As String() = {"", "", "", "", "", ""}
                系統操作記錄(0) = "後台登入"
                系統操作記錄(1) = "後台登入"
                系統操作記錄(2) = Session("BK")
                系統操作記錄(3) = dv.Item(0).Item("d02")
                websystem.Sub_系統操作記錄(系統操作記錄)

                Response.Redirect("ManageIndex.aspx", False)
            Else
                txt_id.Text = ""
                txt_password.Text = ""
                Captcha_text.Text = ""
            End If
        End If
    End Sub

    Private Sub Logout_but_Click(sender As Object, e As EventArgs) Handles Logout_but.Click
        Session("BK") = Nothing
        Response.Redirect("ManageIndex.aspx", False)
    End Sub

    Sub CreateMenu()
        Dim conn As New SQL

        Dim Str As String = ""

        conn.SelectCommand = "select distinct A.z00 as 分類ID,A.z01 as 分類排序,A.z02 as 分類名稱 " &
                             "from WZ01 A,WZ01 B,WZ02 C " &
                             "where A.z00=B.z07 And B.z00=C.z02 And A.z08=1 And B.z08=1 And C.z01=@帳號ID And left(C.z03,1)=@R " &
                             "order by A.z01"
        conn.SelectParameters.Add("帳號ID", Session("BKID"))
        conn.SelectParameters.Add("R", "R")
        Dim dvA As Data.DataView = conn.SelectQuery()
        If dvA.Count > 0 Then
            Str = "<div id=""menu"">"
            For i As Integer = 0 To dvA.Count - 1
                Str += "<div id=""funmenumain" & i & """ class=""funmenumain01"" onclick=""funmenuclick(this," & i & ");"">" & dvA.Item(i).Item("分類名稱") & "</div>"

                Dim conn2 As New SQL
                conn2.SelectCommand = "select B.z02 As 功能名稱,B.z03 As ModuleName,B.z04 As FileName " &
                                      "from WZ01 A,WZ01 B,WZ02 C " &
                                      "where A.z00=B.z07 And B.z00=C.z02 And A.z08=1 And B.z08=1 And C.z01=@帳號ID And left(C.z03,1)=@R and A.z00=@分類ID " &
                                      "order by A.z01"
                conn2.SelectParameters.Add("帳號ID", Session("BKID"))
                conn2.SelectParameters.Add("R", "R")
                conn2.SelectParameters.Add("分類ID", dvA.Item(i).Item("分類ID"))
                Dim dvB As Data.DataView = conn2.SelectQuery()
                If dvB.Count > 0 Then
                    Dim tDisplay1 As String = ""
                    Dim tDisplay2 As String = ""
                    For j As Integer = 0 To dvB.Count - 1
                        If j = 0 Then
                            Str += "<div id=""funmenusub" & i & """ style=""display:none;"">    "
                        End If

                        Str += "    <div id=""funmenulist" & i & j & """ class=""funmenulist03"" onclick=""funlistclick(this);GoPage('ManageIndex2.aspx?module=" & dvB.Item(j).Item("ModuleName") & "&files=" & dvB.Item(j).Item("FileName") & "');"">" & dvB.Item(j).Item("功能名稱") & "</div>"

                        If j = dvB.Count - 1 Then
                            Str += "</div>"
                        End If
                    Next
                End If
                conn2.Dispose()

                '與上一個分類稍微留個白行
                Str += "<div class=""funwhite""></div>"
            Next
            Str += "</div>"
        End If

        menu_lab.Text = Str
    End Sub
End Class