Imports System.Data
Imports System.Data.OleDb

Public Class 資料庫連線_OLEDB
    Public ConnectionString As String = Web.Configuration.WebConfigurationManager.ConnectionStrings("db_connect_bodhi").ConnectionString
    Public Lock資料連線 As New Object
    Event ThrowException(detail As String)
    Public 資料連線 As OleDbConnection
    Public Property 連線字串() As String
        Get
            Return ConnectionString
        End Get
        Set(ByVal value As String)
            ConnectionString = value
        End Set
    End Property

    Public Function [Select](ByVal s語法 As String, ByVal m參數 As OleDbParameter(), ByRef mDataset As DataSet, ByRef catchException As Exception, Optional timeout As Integer = 30) As Boolean
        Return 查詢(s語法, m參數, mDataset, catchException, timeout)
    End Function
    Public Function 查詢(ByVal s語法 As String, ByVal m參數 As OleDbParameter(), ByRef mDataset As DataSet, ByRef catchException As Exception, Optional timeout As Integer = 30) As Boolean
        If String.IsNullOrEmpty(s語法) Then Return False

        ' 避免多緒使用資料庫
        Dim bResult As Boolean = False
        SyncLock Lock資料連線
            If 資料連線 Is Nothing Then ' 如果尚未連線                
                資料連線 = New OleDbConnection()
                資料連線.ConnectionString = ConnectionString
                Try
                    資料連線.Open()
                Catch ex As Exception
                    RaiseEvent ThrowException(ex.Message)
                    'MsgBox("開啟資料庫失敗!!!in class", MsgBoxStyle.OkOnly Or MsgBoxStyle.Critical Or MsgBoxStyle.ApplicationModal, "警告視窗")
                    Return False
                End Try
            End If
            If 資料連線.State.ToString.ToUpper <> "OPEN" Then
                RaiseEvent ThrowException("資料庫未開啟連線")
                If Not 重新連線() Then Return False
            End If
            Dim sda As New OleDbDataAdapter(s語法, 資料連線)
            '20161214 , run sql command will course error 'timeout' , so I add thsi command ...
            sda.SelectCommand.CommandTimeout = timeout
            Dim ds As New DataSet()
            If m參數 IsNot Nothing Then sda.SelectCommand.Parameters.AddRange(m參數)
            Try
                sda.Fill(ds)
                bResult = True
                mDataset = ds
                sda.SelectCommand.Parameters.Clear()
                GoTo 釋放配接
            Catch ex As Exception
                _Report("OLEDB", s語法)
                _Report("OLEDB", ex.Message.ToString)
                RaiseEvent ThrowException(ex.Message)
                catchException = ex
                GoTo 釋放資料
            End Try
釋放資料:
            ds.Dispose()
            ds = Nothing
釋放配接:
            sda.Dispose()
            sda = Nothing
        End SyncLock
        Return bResult
    End Function
    Public Function Update(ByVal s語法 As String, ByVal m參數 As OleDbParameter(), ByRef firstColumn As Object, ByRef catchException As Exception) As Boolean
        Return 命令(s語法, m參數, firstColumn, catchException)
    End Function
    Public Function 命令(ByVal s語法 As String, ByVal m參數 As OleDbParameter(), ByRef firstColumn As Object, ByRef catchException As Exception) As Boolean
        If String.IsNullOrEmpty(s語法) Then Return False
        ' 避免多緒使用資料庫
        Dim bResult As Boolean = False
        'SyncLock Lock資料連線
        If 資料連線 Is Nothing Then ' 如果尚未連線
                資料連線 = New OleDbConnection(ConnectionString)
                Try
                    資料連線.Open()
                Catch ex As Exception
                    RaiseEvent ThrowException(ex.Message)
                    'MsgBox("開啟資料庫失敗!!!", MsgBoxStyle.OkOnly Or MsgBoxStyle.Critical Or MsgBoxStyle.ApplicationModal, "警告視窗")
                    Return False
                End Try
            End If
            If 資料連線.State.ToString.ToUpper <> "OPEN" Then
                RaiseEvent ThrowException("資料庫未開啟連線")
                If Not 重新連線() Then Return False
            End If
            Dim cmd As OleDbCommand = 資料連線.CreateCommand()
            cmd.CommandText = s語法
            If m參數 IsNot Nothing Then cmd.Parameters.AddRange(m參數)
        Try
            firstColumn = cmd.ExecuteScalar()
            bResult = True
        Catch ex As Exception
            _Report("OLEDB", s語法)
            _Report("OLEDB", ex.Message.ToString)
            RaiseEvent ThrowException(ex.Message)
                catchException = ex
            End Try
            cmd.Dispose()
            cmd = Nothing
        'End SyncLock
        Return bResult
    End Function
    Public Function Update2(ByVal s語法 As String, ByVal m參數 As OleDbParameter(), ByRef firstColumn As Object, ByRef catchException As Exception) As Integer
        Return 命令2(s語法, m參數, firstColumn, catchException)
    End Function
    '可以取得自動編號值
    Public Function 命令2(ByVal s語法 As String, ByVal m參數 As OleDbParameter(), ByRef firstColumn As Object, ByRef catchException As Exception) As Integer
        If String.IsNullOrEmpty(s語法) Then Return 0
        ' 避免多緒使用資料庫
        Dim bResult As Boolean = False
        'SyncLock Lock資料連線
        If 資料連線 Is Nothing Then ' 如果尚未連線
            資料連線 = New OleDbConnection(ConnectionString)
            Try
                資料連線.Open()
            Catch ex As Exception
                RaiseEvent ThrowException(ex.Message)
                'MsgBox("開啟資料庫失敗!!!", MsgBoxStyle.OkOnly Or MsgBoxStyle.Critical Or MsgBoxStyle.ApplicationModal, "警告視窗")
                Return False
            End Try
        End If
        If 資料連線.State.ToString.ToUpper <> "OPEN" Then
            RaiseEvent ThrowException("資料庫未開啟連線")
            If Not 重新連線() Then Return False
        End If
        Dim cmd As OleDbCommand = 資料連線.CreateCommand()
        cmd.CommandText = s語法 & ";SELECT @@identity"
        If m參數 IsNot Nothing Then cmd.Parameters.AddRange(m參數)
        Try
            firstColumn = cmd.ExecuteScalar()
            bResult = True
            cmd.Dispose()
            cmd = Nothing
            If Not IsDBNull(firstColumn) Then Return firstColumn

        Catch ex As Exception
            RaiseEvent ThrowException(ex.Message)
            catchException = ex
            Return 0
        End Try
        'cmd.CommandText = ";SELECT @@identity"
        'Try
        '    firstColumn = cmd.ExecuteScalar()
        '    bResult = True

        'Catch ex As Exception

        '    RaiseEvent ThrowException(ex.Message)
        '    catchException = ex
        'End Try

        'cmd.Dispose()
        'cmd = Nothing
        'If Not IsDBNull(firstColumn) Then Return firstColumn
        Return 0
    End Function
    Public Function Update(ByVal s語法 As String, ByVal m參數 As OleDbParameter(), ByRef iAffectedRows As Integer, ByRef catchException As Exception) As Boolean
        Return 命令(s語法, m參數, iAffectedRows, catchException)
    End Function
    Public Function 命令(ByVal s語法 As String, ByVal m參數 As OleDbParameter(), ByRef iAffectedRows As Integer, ByRef catchException As Exception) As Boolean
        If String.IsNullOrEmpty(s語法) Then Return False
        ' 避免多緒使用資料庫
        Dim bResult As Boolean = False
        'SyncLock Lock資料連線
        If 資料連線 Is Nothing Then ' 如果尚未連線
            資料連線 = New OleDbConnection(ConnectionString)
            Try
                資料連線.Open()
            Catch ex As Exception
                RaiseEvent ThrowException(ex.Message)
                'MsgBox("開啟資料庫失敗!!!", MsgBoxStyle.OkOnly Or MsgBoxStyle.Critical Or MsgBoxStyle.ApplicationModal, "警告視窗")
                Return False
            End Try
        End If
        If 資料連線.State.ToString.ToUpper <> "OPEN" Then
            RaiseEvent ThrowException("資料庫未開啟連線")
            If Not 重新連線() Then Return False
        End If
        Dim cmd As OleDbCommand = 資料連線.CreateCommand()
        cmd.CommandText = s語法
        If m參數 IsNot Nothing Then cmd.Parameters.AddRange(m參數)
        Try
            iAffectedRows = cmd.ExecuteNonQuery()
            bResult = True
        Catch ex As Exception
            RaiseEvent ThrowException(ex.Message)
            catchException = ex
        End Try
        cmd.Dispose()
        cmd = Nothing
        'End SyncLock
        Return bResult
    End Function

    Public Function 產生參數(ByVal s名稱 As String, ByVal m型別 As OleDbType, ByVal m資料 As Object) As OleDbParameter
        Dim objParam As New OleDbParameter(s名稱, m型別)
        objParam.Value = m資料
        Return objParam
    End Function
    Public Function 產生參數(ByVal s名稱 As String, ByVal m型別 As OleDbType, ByVal i長度 As Integer, ByVal m資料 As Object) As OleDbParameter
        Dim objParam As New OleDbParameter(s名稱, m型別, i長度)
        objParam.Value = m資料
        Return objParam
    End Function
    Public Function 重新連線() As Boolean
        關閉連線()
        資料連線 = New OleDbConnection(ConnectionString)
        Try
            資料連線.Open()
            Return True
        Catch ex As Exception
            RaiseEvent ThrowException(ex.Message)
            'MsgBox("開啟資料庫失敗!!!", MsgBoxStyle.OkOnly Or MsgBoxStyle.Critical Or MsgBoxStyle.ApplicationModal, "警告視窗")

        End Try
        Return False
    End Function
    Public Function 關閉連線() As Integer
        Try
            If 資料連線 IsNot Nothing Then
                資料連線.Close()
                資料連線.Dispose()
                資料連線 = Nothing
            End If
            Return 0
        Catch ex As Exception

        End Try
        Return 1
    End Function
    Public Function 檢查資料庫是否可用() As Integer
        ' 避免多緒使用資料庫
        Dim bResult As Boolean = False
        'SyncLock Lock資料連線Check

        If 資料連線 Is Nothing Then ' 如果尚未連線
            資料連線 = New OleDbConnection(ConnectionString)
            Try
                資料連線.Open()
                Return 0
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
        'End SyncLock
        Return 1
    End Function

End Class
