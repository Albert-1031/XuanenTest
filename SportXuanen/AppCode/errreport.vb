Imports System.IO
Imports System.Security.Cryptography
Imports System.Text

Module errReport
    Sub _Report(_source As String, _message As String)
        Try
            Dim a As Integer = 0
            Dim _outpath As String = "d:\allec" & "\weblog\waris"
            While Not System.IO.Directory.Exists(_outpath)
                a += 1
                System.IO.Directory.CreateDirectory(_outpath)
                '系統沒有寫入權限?
                If a > 5 Then Exit Sub
            End While
            Dim objWriter_log As New System.IO.StreamWriter(_outpath & "\rfid_" & Now.Year.ToString.Substring(2, 2) & Now.Month.ToString("00") & Now.Day.ToString("00") & ".txt", True)
            '寫入log文字檔
            objWriter_log.WriteLine(Now.ToString("yyyy/MM/dd HH:mm:ss") & " 訊息來源:" & _source & " 內容:" & _message)
            objWriter_log.Flush()
            objWriter_log.Close()
            objWriter_log = Nothing
        Catch ex As Exception


        End Try
    End Sub
    Sub _reportDataview(_source As String, _dv As DataView)
        'For Each rowView As DataRowView In _dv
        'Dim sw = New System.IO.StringWriter
        Dim Table As DataTable = _dv.Table
            Dim s_json As String = ""
            Try
                s_json = Newtonsoft.Json.JsonConvert.SerializeObject(Table, Newtonsoft.Json.Formatting.Indented)
                _Report(_source, s_json)
            Catch ex As Exception

            End Try
        'Next
    End Sub
End Module






