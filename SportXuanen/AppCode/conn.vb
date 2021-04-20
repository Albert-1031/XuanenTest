Imports Microsoft.VisualBasic
Imports System.Data
Imports System.Data.SqlClient
Imports System.Web.Configuration
Imports System.Web.UI
Imports System.Data.Common

Public Class SQL
    Inherits SqlDataSource
    Public a As String = Nothing
    Sub New()
        MyBase.ConnectionString = WebConfigurationManager.ConnectionStrings("db_connect").ConnectionString
    End Sub

    Private Sub SQL_Selecting(sender As Object, e As SqlDataSourceSelectingEventArgs) Handles Me.Selecting
        e.Command.CommandTimeout = 1200
    End Sub

    Public Function SelectQuery() As DataView
        Dim dv As DataView = MyBase.Select(New DataSourceSelectArguments)
        'SQL 隱碼攻擊防範
        If SelectCommand.Contains("'") Then
            Return Nothing
        End If
        If SelectCommand.Contains("--") Then
            Return Nothing
        End If
        SelectQuery = dv
    End Function

    Public Function UpdateQuery() As Integer
        Dim 錯誤次數 As Integer = 0
        If UpdateCommand.Contains("'") Then
            錯誤次數 = 錯誤次數 + 1
        End If
        If UpdateCommand.Contains("--") Then
            錯誤次數 = 錯誤次數 + 1
        End If

        'MsgBox(錯誤次數)
        If 錯誤次數 > 0 Then
            Return 0
        Else
            Dim update_rs As Integer = MyBase.Update()
            Return update_rs
        End If
    End Function

    Public Function SelectQuery2() As DataView
        Dim dv As DataView = MyBase.Select(New DataSourceSelectArguments)
        If SelectCommand.Contains("--") Then
            Return Nothing
        End If
        SelectQuery2 = dv
    End Function

    'Private Sub SQL_Inserted(sender As Object, e As SqlDataSourceStatusEventArgs) Handles Me.Inserted
    '    Dim command As DbCommand
    '    command = e.Command
    '    a = command.Parameters("@z00").Value.ToString()
    'End Sub

    'Public Function GetNewUserNo() As String
    '    Return a
    'End Function
    'Private Sub SQL_Inserting(sender As Object, e As SqlDataSourceCommandEventArgs) Handles Me.Inserting
    '    Dim insertedKey As SqlParameter
    '    insertedKey = New SqlParameter("@z00", SqlDbType.BigInt)
    '    insertedKey.Direction = ParameterDirection.Output
    '    e.Command.Parameters.Add(insertedKey)
    'End Sub
End Class

