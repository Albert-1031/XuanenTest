﻿Imports System.Data.OleDb
Imports System.Web.Mvc

Namespace Controllers
    Public Class ApiController
        Inherits Controller

        ' GET: Index
        Function getdata() As ActionResult
            Dim b As Boolean = False
            Dim objParams() As OleDbParameter = Nothing
            Dim ex As Exception = Nothing
            Dim ds As DataSet = Nothing
            Dim ds1 As Integer = 0
            Dim sql_command As String = ""
            Dim rs As Integer = 255
            Dim centercode As String = String.Empty
            Dim _jsondata As String = String.Empty
            Dim sdata As New class_人數
            Try
                centercode = Request("c")
            Catch ex1 As Exception
                rs = 255
            End Try
            If centercode.Contains("-") Or centercode.Contains("'") Or centercode.Contains(";") Then
                Return View()
            End If
            If Not String.IsNullOrEmpty(centercode) Then

                rs = 254
                centercode = centercode.ToLower
                sql_command = "select top 1 * from wp01 where p01=?"
                objParams = New OleDbParameter() {db.產生參數("p01", OleDbType.VarWChar, centercode)}
                b = db.Select(sql_command, objParams, ds, ex)
                objParams = Nothing
                If b Then
                    If ds.Tables(0).Rows.Count > 0 Then
                        '有資料
                        Dim lastdate As DateTime
                        If Date.TryParse(ds.Tables(0).Rows(0)("p05"), lastdate) Then
                            If DateDiff(DateInterval.Minute, lastdate, Now) > 5 Then
                                If 更新人數資料(centercode, sdata, 0) Then
                                    rs = 0
                                End If
                            Else
                                rs = 0
                                sdata.游泳池 = ds.Tables(0).Rows(0)("p02")
                                sdata.健身房 = ds.Tables(0).Rows(0)("p03")
                                sdata.冰宮 = ds.Tables(0).Rows(0)("p04")

                            End If
                        Else
                            '資料時間有誤?重新拉取資料
                            If 更新人數資料(centercode, sdata, 0) Then
                                rs = 0
                            End If
                        End If
                    Else
                        '沒有任何資料，建立他~
                        If 更新人數資料(centercode, sdata, 1) Then
                            rs = 0
                        End If
                    End If
                End If

            Else
                rs = 253
            End If

            Return Content(returnjson(rs, sdata), "application/json")
        End Function
        ''' <summary>
        ''' 更新人流
        ''' </summary>
        ''' <param name="centercode"></param>
        ''' <param name="sdata"></param>
        ''' <param name="action">update 資料 1/新增資料</param>
        ''' <returns></returns>
        Function 更新人數資料(centercode As String, ByRef sdata As class_人數, action As Integer) As Boolean
            Dim b As Boolean = False
            Dim objParams() As OleDbParameter = Nothing
            Dim ex As Exception = Nothing
            Dim ds As DataSet = Nothing
            Dim ds1 As Integer = 0
            Dim sql_command As String = ""
            '查詢人數
            Dim targeturl As String = 中心網址(centercode)
            If Not String.IsNullOrEmpty(targeturl) Then
                Try
                    Dim targeturl2 As String = "http://" & targeturl & "/display/discode.aspx?action=z1"
                    Dim rsdata As String

                    rsdata = __fun_Brower_GetData(targeturl2)
                    If Not String.IsNullOrEmpty(rsdata) Then
                        Dim a As String() = rsdata.Split(",")
                        If a.Length > 0 Then
                            sdata.游泳池 = a(0)
                        End If
                    End If
                    rsdata = String.Empty
                    targeturl2 = "http://" & targeturl & "/display/discode.aspx?action=z2"
                    rsdata = __fun_Brower_GetData(targeturl2)
                    If Not String.IsNullOrEmpty(rsdata) Then
                        Dim a As String() = rsdata.Split(",")
                        If a.Length > 0 Then
                            sdata.健身房 = a(0)
                        End If
                    End If
                    '更新本機人留資料
                    Select Case action
                        Case 0 'update 
                            sql_command = "update wp01 set p02=" & sdata.游泳池 & ",p03=" & sdata.健身房 & ",p04=" & sdata.冰宮 & ",p05=getdate() where p01='" & centercode & "'"
                        Case 1 'insert
                            sql_command = "insert into wp01 (p01,p02,p03,p04,p05) values ('" & centercode & "'," & sdata.游泳池 & "," & sdata.健身房 & "," & sdata.冰宮 & ",getdate());"
                    End Select
                    b = db.Update(sql_command, objParams, ds1, ex)
                    Return True
                Catch ex1 As Exception
                End Try
            End If
            Return False
        End Function

        Function 中心網址(centercode As String) As String
            Dim rsurl As String = String.Empty
            Dim allecurl As String = ".allec.com.tw"
            Dim xuanenurl As String = ".xuanen.com.tw"
            Select Case centercode.Substring(0, 2)
                Case "tp", "wd", "jj", "ds", "ts", "cg", "nd", "fe", "kc", "sl", "jb"
                    rsurl = centercode & allecurl
                Case "wp"
                    rsurl = centercode & allecurl
            End Select
            Select Case centercode
                Case "slsc68", "xwt88", "tsc01"
                    rsurl = centercode & allecurl
            End Select

            Return rsurl
        End Function



        Function returnjson(rs As Integer, sdata As class_人數) As String
            Return "{""rs"":" & rs & ",""d1"":" & sdata.游泳池 & ",""d2"":" & sdata.健身房 & ",""d3"":" & sdata.冰宮 & "}"
        End Function
        Public Function __fun_Brower_GetData(TargetURL As String) As String
            Try
                Dim fr As System.Net.HttpWebRequest
                Dim targetURI As New Uri(TargetURL)
                Dim rs As String = ""
                fr = DirectCast(System.Net.HttpWebRequest.Create(targetURI), System.Net.HttpWebRequest)
                'fr.Timeout = 10000
                Try
                    'If (fr.GetResponse().ContentLength > 0) Then
                    Dim str As New System.IO.StreamReader(fr.GetResponse().GetResponseStream())
                    rs = str.ReadToEnd
                    str.Close()
                    ' End If
                Catch ex As Exception
                    fr.Abort()
                End Try
                Return rs
            Catch ex As System.Net.WebException
                'Error in accessing the resource, handle it
            End Try
            Return ""
        End Function
    End Class
    Public Class class_人數
        Public 游泳池 As Integer = 0
        Public 健身房 As Integer = 0
        Public 冰宮 As Integer = 0
    End Class
End Namespace