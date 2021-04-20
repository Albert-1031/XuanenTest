Imports System.Web.HttpContext
Imports System.Security.Cryptography
Imports System.Data
Imports System.Data.OleDb
Imports System.Net

Public Class websystem

    Public Sub _sub_message(s_EventType As String, s_EventFrom As String, s_Message1 As String, s_Message2 As String)

        Dim conn As New SQL
        If s_EventType.Length >= 10 Then s_EventType = s_EventType.Substring(0, 9)
        If s_EventFrom.Length >= 30 Then s_EventFrom = s_EventFrom.Substring(0, 29)
        If s_Message1.Length >= 255 Then s_Message1 = s_Message1.Substring(0, 254)
        If s_Message2.Length >= 255 Then s_Message2 = s_Message2.Substring(0, 254)

        conn.UpdateCommand = "insert into l02 (l01,l02,l03,l04,l05,l06) values ('" & s_EventType & "',getdate(),'" & s_EventFrom & "','0','" & s_Message1 & "','" & s_Message2 & "')"
        conn.Update()
    End Sub
    Function webapi_request(RequestURL As String, RequestData As String, ByRef result As String) As Integer
        Try
            Using webClient As WebClient = New System.Net.WebClient()
                webClient.Encoding = Encoding.UTF8
                webClient.Headers(HttpRequestHeader.ContentType) = "application/json"
                result = webClient.UploadString(RequestURL, RequestData)
            End Using
            Return 0
        Catch ex As Exception
            errReport._Report("callcenter-webapi_request", ex.Message)
            result = ex.Message
        End Try
        Return 1
    End Function
#Region "基本"
    Function rpterror(ByVal message As String, ByVal pro As String) As Boolean
        Current.Items.Add("message", message)
        Current.Items.Add("pro", pro)
        Current.Server.Transfer("~/DefaultError.html", False)
        Return True
    End Function

    Function xss(ByVal filter_string As String) As String
        '防XSS攻擊
        '特定字串
        Try
            If Not String.IsNullOrEmpty(filter_string) Then
                If filter_string.Contains("ascript") Then
                    rpterror("資料輸入錯誤!", "一般程式")
                ElseIf filter_string.Contains("\r\n") Then
                    rpterror("資料輸入錯誤!", "一般程式")
                ElseIf filter_string.Contains("&#x") Then
                    rpterror("資料輸入錯誤!", "一般程式")
                Else
                    Return filter_string
                End If
            End If
        Catch ex As Exception

        End Try

        Return ""
    End Function

    Function xss2(ByVal filter_string As String) As String
        If Not filter_string Is Nothing Then
            '防XSS攻擊
            '特定字串
            If filter_string.Contains("ascript") Then
                Return ""
            ElseIf filter_string.Contains("\r\n") Then
                Return ""
            ElseIf filter_string.Contains("&#x") Then
                Return ""
            Else
                Return filter_string
            End If
        End If
        Return ""
    End Function

    'YYYYMMDDHHMM
    Function YYYYMMDDHHMM(ByVal date_string As String) As String
        If date_string IsNot Nothing Then
            Return Year(date_string) & "/" & Right("0" & Month(date_string), 2) & "/" & Right("0" & Day(date_string), 2) & " " & Right("0" & Hour(date_string), 2) & ":" & Right("0" & Minute(date_string), 2)
        Else
            Return ""
        End If
    End Function

    '日期格式：YYYY/MM/DD HH:MM:SS
    Function departDate(ByVal date_string As String) As String
        If date_string IsNot Nothing Then
            Return Year(date_string) & "/" & Right("0" & Month(date_string), 2) & "/" & Right("0" & Day(date_string), 2) & " " & Right("0" & Hour(date_string), 2) & ":" & Right("0" & Minute(date_string), 2) & ":" & Right("0" & Second(date_string), 2)
        Else
            Return ""
        End If
    End Function

    '日期格式：YYYY/M/D
    Function FormatOnlyDate(ByVal date_string As String) As String
        If date_string IsNot Nothing Then
            Return Year(date_string) & "/" & Right("0" & Month(date_string), 2) & "/" & Right("0" & Day(date_string), 2)
        Else
            Return ""
        End If
    End Function

    '日期(補0)：YYYY/MM/DD
    Function FormatOnlyDateZero(ByVal DateStr As String) As String
        If DateStr IsNot Nothing Then
            Return Year(DateStr) & "/" & Right("0" & Month(DateStr), 2) & "/" & Right("0" & Day(DateStr), 2)
        Else
            Return ""
        End If
    End Function

    '日期(補0)：YYYY-MM-DD
    Function FormatDateZero(ByVal DateStr As String) As String
        If DateStr IsNot Nothing Then
            Return Year(DateStr) & "-" & Right("0" & Month(DateStr), 2) & "-" & Right("0" & Day(DateStr), 2)
        Else
            Return ""
        End If
    End Function

    '時間(補0)：HH:MM:SS
    Function FormatTimeZero(ByVal DateStr As String) As String
        If DateStr IsNot Nothing Then
            Return Right("0" & Hour(DateStr), 2) & ":" & Right("0" & Minute(DateStr), 2) & ":" & Right("0" & Second(DateStr), 2)
        Else
            Return ""
        End If
    End Function

    '日期(補0)：MM-DD
    Function FormatDateZero2(ByVal DateStr As String) As String
        If DateStr IsNot Nothing Then
            Return Right("0" & Month(DateStr), 2) & "-" & Right("0" & Day(DateStr), 2)
        Else
            Return ""
        End If
    End Function

    '日期(補0)：YYYY年MM月DD日
    Function Format年月日(ByVal date_string As String) As String
        If date_string IsNot Nothing Then
            Return Year(date_string) & "年" & Right("0" & Month(date_string), 2) & "月" & Right("0" & Day(date_string), 2) & "日"
        Else
            Return ""
        End If
    End Function

    '日期(補0)：MM月DD日
    Function FormatDateZero3(ByVal DateStr As String) As String
        If DateStr IsNot Nothing Then
            Return Right("0" & Month(DateStr), 2) & "月" & Right("0" & Day(DateStr), 2) & "日"
        Else
            Return ""
        End If
    End Function

    '時間(補0)：HH:MM
    Function FormatTimeZero2(ByVal DateStr As String) As String
        If DateStr IsNot Nothing Then
            Return Right("0" & Hour(DateStr), 2) & ":" & Right("0" & Minute(DateStr), 2)
        Else
            Return ""
        End If
    End Function

    '日期(補0)：YYYY-MM-DD HH:MM:SS
    Function FormatDateTimeZero(ByVal DateStr As String) As String
        If DateStr IsNot Nothing Then
            Return Year(DateStr) & "-" & Right("0" & Month(DateStr), 2) & "-" & Right("0" & Day(DateStr), 2) & " " & Right("0" & Hour(DateStr), 2) & ":" & Right("0" & Minute(DateStr), 2) & ":" & Right("0" & Second(DateStr), 2)
        Else
            Return ""
        End If
    End Function

    Function FormatDateTimeZero2(ByVal DateStr As String) As String
        If DateStr IsNot Nothing Then
            Return Year(DateStr) & "-" & Right("0" & Month(DateStr), 2) & "-" & Right("0" & Day(DateStr), 2) & " " & Right("0" & Hour(DateStr), 2) & ":" & Right("0" & Minute(DateStr), 2)
        Else
            Return ""
        End If
    End Function

    '日期(補0)：YYYYMMDD(匯出用)
    Function FormatOnlyDate2(ByVal date_string As String) As String
        If date_string IsNot Nothing Then
            Return Year(date_string) & Right("0" & Month(date_string), 2) & Right("0" & Day(date_string), 2)
        Else
            Return ""
        End If
    End Function

    Function FormatFullDateTime(ByVal date_string As String) As String
        If date_string IsNot Nothing Then
            Return Year(date_string) & Right("0" & Month(date_string), 2) & Right("0" & Day(date_string), 2) & Right("0" & Hour(date_string), 2) & Right("0" & Minute(date_string), 2) & Right("0" & Second(date_string), 2)
        Else
            Return ""
        End If
    End Function

    Function ExcelTDCSS() As String
        Return "mso-number-format:\@;"
        'Return "mso-style-parent:style0;font-size:10.0pt;font-family:Arial Unicode MS, sans-serif;mso-font-charset:0;mso-number-format:\@;text-align:left;border:.5pt solid black;white-space:normal;height:16.5pt;border-top:none;"
    End Function

    Function ExcelTDCSS_Center() As String
        Return "mso-number-format:\@;"
        'Return "mso-style-parent:style0;font-size:10.0pt;font-family:Arial Unicode MS, sans-serif;mso-font-charset:0;mso-number-format:\@;text-align:center;border:.5pt solid black;white-space:normal;height:16.5pt;border-top:none;"
    End Function

    '月初
    Function Fun_FirstDate(ByVal date_string As String) As String
        If date_string IsNot Nothing Then
            Return Year(date_string) & "/" & Month(date_string) & "/1"
        Else
            Return ""
        End If
    End Function

    '月初(補0)
    Function Fun_FirstDateZero(ByVal date_string As String) As String
        If date_string IsNot Nothing Then
            Return Year(date_string) & "/" & Right("0" & Month(date_string), 2) & "/01"
        Else
            Return ""
        End If
    End Function

    '月底
    Function Fun_EndDate(ByVal date_string As String) As String
        If date_string IsNot Nothing Then
            Dim D1, D2 As String
            D1 = Year(date_string) & "/" & Month(date_string) & "/1"
            D2 = DateAdd("d", -1, DateAdd("m", 1, Year(date_string) & "/" & Month(date_string) & "/1"))
            Return D2
        Else
            Return ""
        End If
    End Function

    '月底(補0)
    Function Fun_EndDateZero(ByVal date_string As String) As String
        If date_string IsNot Nothing Then
            Dim D1, D2 As String
            D1 = Year(date_string) & "/" & Month(date_string) & "/1"
            D2 = DateAdd("d", -1, DateAdd("m", 1, D1))
            Return Year(D2) & "/" & Right("0" & Month(D2), 2) & "/" & Day(D2)
        Else
            Return ""
        End If
    End Function

    '內容(Str2)太長依字數(BrN)換行
    Function DoBr(ByVal Str2 As String, ByVal BrN As String) As String
        Dim theStr As String = ""
        For i As Integer = 1 To Len(Str2)
            theStr = theStr & Mid(Str2, i, 1)
            If i Mod BrN = 0 Then theStr = theStr & "<br>"
        Next
        DoBr = theStr
    End Function

    '將(tValue)串接在(tStr)中，並依(tSplit)分隔
    Function Fun_字串連結(ByVal tStr As String, ByVal tValue As String, ByVal tSplit As String) As String
        Dim 字串連結 As String = ""
        If tStr = "" Then
            字串連結 = tValue
        Else
            字串連結 = tStr & tSplit & tValue
        End If
        Return 字串連結
    End Function

    'ASP.NET只能輸入正整數的正規表示法
    Public Function IsVali(ByVal str As String) As Boolean
        Dim flog As Boolean = False
        Dim strPatern As String = "^([1-9]\d*)$"
        Dim reg As New Regex(strPatern)
        If reg.IsMatch(str) Then
            flog = True
        End If
        Return flog
    End Function

    Public Function IsPhoneNumber(ByVal str As String) As Boolean
        Dim EMatch As String = "^09[0-9]{8}$"
        Dim EReg As Regex = New Regex(EMatch)
        Dim HasValidate As Boolean = EReg.IsMatch(str)
        Return HasValidate
    End Function

    Function Fun_PageSize() As Integer
        Return 20
    End Function
    Function Fun_PageSize2() As Integer
        Return 15
    End Function

    Public Function IsEmail(ByVal str As String) As Boolean
        Dim EMatch As String = "(\w+)@(\w+)\.(\w+)"
        Dim EReg As Regex = New Regex(EMatch)
        Return EReg.IsMatch(str)
    End Function

    Public Function Is日期格式(ByVal str As String) As Boolean
        Dim EMatch As String = "^(1[9][0-9][0-9]|2[0][0-9][0-9])[- / .]([1-9]|0[1-9]|1[0-2])[- / .]([1-9]|0[1-9]|1[0-9]|2[0-9]|3[0-1])$"
        Dim EReg As Regex = New Regex(EMatch)
        Dim HasValidate As Boolean = EReg.IsMatch(str)
        Return HasValidate
    End Function

    'https://social.msdn.microsoft.com/Forums/zh-CN/590bd6a8-57d7-4041-81da-80fe8b832b77/md5
    Function GetMd5Hash(ByVal 字串 As String) As String
        Dim md5Hash As MD5 = MD5.Create()

        ' Convert the input string to a byte array and compute the hash.
        Dim data As Byte() = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(字串))

        ' Create a new Stringbuilder to collect the bytes
        ' and create a string.
        Dim sBuilder As New StringBuilder()

        ' Loop through each byte of the hashed data 
        ' and format each one as a hexadecimal string.
        For i As Integer = 0 To data.Length - 1
            sBuilder.Append(data(i).ToString("x2"))
        Next

        ' Return the hexadecimal string.
        Return sBuilder.ToString().ToUpper()
    End Function

    Function The_Round(ByVal tNum As Double, ByVal tLen As Integer) As Double
        Return Math.Round(tNum, tLen, MidpointRounding.AwayFromZero)
    End Function
#End Region

#Region "功能"
    'Fun_功能資訊(功能ID,帳號ID)
    '陣列(0)：ICON
    '陣例(1)：功能名稱
    '陣列(2)：授權
    Function Fun_功能資訊後台(ByVal 功能ID As Integer, ByVal 帳號ID As Integer) As String()
        Dim thisFunInfo() As String = {"", "", ""}
        Dim conn_f As New SQL
        conn_f.SelectCommand = "select A.z02 as 功能名稱,A.z03 as ModuleName,A.z04 as FileName,B.Z03 as 授權 " &
                               "from WZ01 A " &
                               "left join WZ02 B on A.z00=B.z02 and B.z01=@帳號ID " &
                               "where A.z99=@功能ID"
        conn_f.SelectParameters.Add("帳號ID", 帳號ID)
        conn_f.SelectParameters.Add("功能ID", 功能ID)
        Dim dv_f As Data.DataView = conn_f.SelectQuery()
        If dv_f.Count > 0 Then
            thisFunInfo(1) = dv_f.Item(0).Item("功能名稱")
            If Not IsDBNull(dv_f.Item(0).Item("授權")) Then thisFunInfo(2) = dv_f.Item(0).Item("授權")
        End If
        Return thisFunInfo
    End Function

    '判斷資料是否重複
    'Fun_重複(資料表名稱,自動編號,自動編號欄位名稱,判斷欄位名稱,判斷內容值)
    Function Fun_重複(ByVal tTableName As String, ByVal tID As Integer, ByVal tIDField As String, ByVal 欄位 As String, ByVal 內容 As String) As Boolean
        Dim 重複 As Integer = False

        Dim connF As New SQL
        connF.SelectCommand = "select " & tIDField & " from " & tTableName & " where " & 欄位 & "=@內容 and " & tIDField & "<>@ID"
        connF.SelectParameters.Add("內容", 內容)
        connF.SelectParameters.Add("ID", tID)
        Dim dvF As Data.DataView = connF.SelectQuery()
        If Not dvF Is Nothing AndAlso dvF.Count > 0 Then
            重複 = True
        End If

        Return 重複
    End Function

    '判斷資料是否重複
    'Fun_重複2(資料表名稱,自動編號,自動編號欄位名稱,判斷欄位名稱,判斷內容值,判斷欄位名稱2,判斷內容值2)
    Function Fun_重複2(ByVal tTableName As String, ByVal tID As Integer, ByVal tIDField As String, ByVal 欄位 As String, ByVal 內容 As String, ByVal 欄位2 As String, ByVal 內容2 As String) As Boolean
        Dim 重複 As Integer = False

        Dim connF As New SQL
        connF.SelectCommand = "select count(*) from " & tTableName & " where " & 欄位 & "=@內容 and " & 欄位2 & "=@內容2 and " & tIDField & "<>@ID"
        connF.SelectParameters.Add("內容", 內容)
        connF.SelectParameters.Add("內容2", 內容2)
        connF.SelectParameters.Add("ID", tID)
        Dim dvF As Data.DataView = connF.SelectQuery()
        If Not dvF Is Nothing AndAlso dvF.Item(0).Item(0) > 0 Then
            重複 = True
        End If

        Return 重複
    End Function

    '判斷資料是否重複
    'Fun_重複3(資料表名稱,自動編號,自動編號欄位名稱,判斷欄位名稱,判斷內容值,判斷欄位名稱2,判斷內容值2,判斷欄位名稱3,判斷內容值3)
    Function Fun_重複3(ByVal tTableName As String, ByVal tID As Integer, ByVal tIDField As String, ByVal 欄位 As String, ByVal 內容 As String, ByVal 欄位2 As String, ByVal 內容2 As String, ByVal 欄位3 As String, ByVal 內容3 As String) As Boolean
        Dim 重複 As Integer = False

        Dim connF As New SQL
        connF.SelectCommand = "select count(*) from " & tTableName & " where " & 欄位 & "=@內容 and " & 欄位2 & "=@內容2 and " & 欄位3 & "=@內容3 and " & tIDField & "<>@ID"
        connF.SelectParameters.Add("內容", 內容)
        connF.SelectParameters.Add("內容2", 內容2)
        connF.SelectParameters.Add("內容3", 內容3)
        connF.SelectParameters.Add("ID", tID)
        Dim dvF As Data.DataView = connF.SelectQuery()
        If Not dvF Is Nothing AndAlso dvF.Item(0).Item(0) > 0 Then
            重複 = True
        End If

        Return 重複
    End Function

    'Sub_系統操作記錄(陣列)
    '陣列(0)=功能名稱
    '陣列(1)=操作方式
    '陣列(2)=操作人員
    '陣列(3)=操作說明
    '陣列(4)=詳細資料
    Sub Sub_系統操作記錄(ByVal 操作記錄() As String)
        '資料表：WS01_系統操作記錄
        '欄位名稱	中文名稱	型態		長度	備註
        's00		自動編號	int			
        's01		功能名稱	nvarchar	20	
        's02		操作時間	datetime		
        's03		操作方式	nvarchar	4	
        's04		操作人員	nvarchar	10	
        's05        來源IP      nvarchar	15
        's06		操作說明	text			    取一個代表，例如會員資料(會員名稱)、產品資料(產品名稱)…等
        's07		詳細資料	text			    欄位1@1@欄位2@1@欄位3@2@資料1@1@資料2@1@資料3
        's08		來源位置	int			        0:未知；1:體育局；2:中心

        Dim 來源位置 As String = HttpContext.Current.Session("BKKind")
        If Not IsNumeric(來源位置) Then 來源位置 = "0"

        Dim conn2 As New SQL
        conn2.InsertCommand = "insert into WS01(s01,s02,s03,s04,s05,s06,s07,s08)values(@功能名稱,getdate(),@操作方式,@操作人員,@來源IP,@操作說明,@詳細資料,@來源位置)"
        conn2.InsertParameters.Add("功能名稱", 操作記錄(0))
        conn2.InsertParameters.Add("操作方式", 操作記錄(1))
        conn2.InsertParameters.Add("操作人員", 操作記錄(2))
        conn2.InsertParameters.Add("來源IP", HttpContext.Current.Session("IP"))
        conn2.InsertParameters.Add("操作說明", 操作記錄(3))
        conn2.InsertParameters.Add("詳細資料", 操作記錄(4))
        conn2.InsertParameters.Add("來源位置", 來源位置)
        conn2.Insert()
    End Sub

    Sub Sub_系統使用次數紀錄(ByVal 功能名稱 As String, ByVal 來源位置 As Integer)
        '資料表：WS02_系統使用次數
        '欄位名稱	中文名稱	型態		長度	備註
        's00		自動編號	int			
        's01        功能名稱    nvarchar    20
        's02        日期        date
        's03        操作次數    int
        's04        來源位置    int                 0:未知；1:體育局；2:中心 

        If 功能名稱.Length > 0 Then
            Dim conn As New SQL

            Try
                conn.SelectCommand = "select * from WS02 where s01=@s01 and s02=@s02 and s04=@s04 "
                conn.SelectParameters.Add("s01", 功能名稱)
                conn.SelectParameters.Add("s02", FormatDateZero(Now()))
                conn.SelectParameters.Add("s04", 來源位置)

                Dim dv As Data.DataView = conn.SelectQuery()
                If dv.Count > 0 Then
                    conn.UpdateCommand = "update WS02 set s03=s03+1 where s01=@s01 and s02=@s02 and s04=@s04 "
                    conn.UpdateParameters.Add("s01", 功能名稱)
                    conn.UpdateParameters.Add("s02", FormatDateZero(Now()))
                    conn.UpdateParameters.Add("s04", 來源位置)
                    conn.Update()
                Else
                    conn.InsertCommand = "insert into WS02 (s01, s02, s03, s04) values(@s01, @s02, @s03, @s04) "
                    conn.InsertParameters.Add("s01", 功能名稱)
                    conn.InsertParameters.Add("s02", FormatDateZero(Now()))
                    conn.InsertParameters.Add("s03", "1")
                    conn.InsertParameters.Add("s04", 來源位置)
                    conn.Insert()
                End If
            Catch ex As Exception
                _sub_message("SystemRecord", "Web", "SystemRecord", "error --> " & ex.ToString())
            End Try
        End If

    End Sub

    '取欄位內容(例如：群組名稱、帳號名稱…等)
    'Fun_欄位值(資料表名稱,欄位名稱,自動編號欄位名稱,自動編號)
    Function Fun_欄位值(ByVal 資料表名稱 As String, ByVal 欄位名稱 As String, ByVal 自動編號欄位名稱 As String, ByVal 自動編號 As Integer) As String
        Dim 欄位值 As String = ""

        Dim connF As New SQL
        connF.SelectCommand = "select " & 欄位名稱 & " from " & 資料表名稱 & " where " & 自動編號欄位名稱 & "=@資料ID"
        connF.SelectParameters.Add("資料ID", 自動編號)
        Dim dvF As Data.DataView = connF.SelectQuery()
        If dvF.Count > 0 AndAlso Not IsDBNull(dvF.Item(0).Item(0)) Then 欄位值 = dvF.Item(0).Item(0)

        Return 欄位值
    End Function

    '取「多個」欄位內容(例如：場地編號[陣列0],場地簡稱[陣列1]…等)
    'Fun_欄位值_多(資料表名稱,欄位名稱[以,分隔],自動編號欄位名稱,自動編號)
    Function Fun_欄位值_多(ByVal 資料表名稱 As String, ByVal 欄位名稱 As String, ByVal 自動編號欄位名稱 As String, ByVal 自動編號 As Integer) As String()
        Dim 欄位名稱List() As String = 欄位名稱.Split(",")

        Dim 欄位值_多(欄位名稱List.Length) As String
        For f As Integer = 0 To 欄位值_多.Length - 1
            欄位值_多(f) = ""
        Next

        Dim connF As New SQL
        connF.SelectCommand = "select " & 欄位名稱 & " from " & 資料表名稱 & " where " & 自動編號欄位名稱 & "=@資料ID"
        connF.SelectParameters.Add("資料ID", 自動編號)
        Dim dvF As Data.DataView = connF.SelectQuery()
        If dvF.Count > 0 Then

            For ff As Integer = 0 To 欄位名稱List.Length - 1
                If Not IsDBNull(dvF.Item(0).Item(0)) Then 欄位值_多(ff) = dvF.Item(0).Item(欄位名稱List(ff))
            Next
        End If

        Return 欄位值_多
    End Function
#End Region
End Class
