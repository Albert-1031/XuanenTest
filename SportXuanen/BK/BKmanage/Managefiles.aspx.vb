Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Web
Imports System.Web.UI
Imports System.Web.UI.WebControls
Imports System.IO
Public Class Managefiles
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        Dim m_module As String = ""
        Dim m_files As String = ""
        m_module = Request.QueryString("module")
        m_files = Request.QueryString("files")
        Dim targetUrl As String = "BKmanage/" + m_module + "/" + m_files + ".aspx"

        '檔案在server 中的絕對路徑
        Dim targetPateh As String = Server.MapPath("~/") + "BK\\BKmanage\\" + m_module + "\\" + m_files + ".aspx"

        Dim write As StringWriter = New StringWriter()

        If (System.IO.File.Exists(targetPateh)) Then
            Try
                Dim 功能名稱 As String = ""
                Dim connF As New SQL
                connF.SelectCommand = "select B.z02 as BN,A.z02 as SN from WZ01 A,WZ01 B where A.z07=B.z00 and A.z03=@m_module and A.z04=@m_files"
                connF.SelectParameters.Add("m_module", m_module)
                connF.SelectParameters.Add("m_files", m_files)
                Dim dvF As Data.DataView = connF.SelectQuery()
                If dvF.Count > 0 Then
                    功能名稱 = " >> " & dvF.Item(0).Item("BN") & " >> " & dvF.Item(0).Item("SN")
                End If
                dvF.Dispose()
                connF.Dispose()

                AccessJS.Text = "<script>SetTitle('" & 功能名稱 & "');</script>"

                Server.Execute(targetUrl, write, True)
                Response.Write(write)
            Catch ex As Exception

            End Try
        End If
        Return
    End Sub
End Class