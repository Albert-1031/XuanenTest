Imports System.Web
Imports System.Web.Configuration

Module SystemConfig
    Public db As New 資料庫連線_OLEDB


    Sub New()
        If String.IsNullOrEmpty(db.ConnectionString) Then db.ConnectionString = WebConfigurationManager.ConnectionStrings("db_connect_bodhi").ConnectionString
    End Sub
End Module