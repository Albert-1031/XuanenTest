Imports System
Imports System.IO
Imports System.Collections.Generic
Imports System.Linq
Imports System.Web
Public Class ManageIndex2
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim write As StringWriter = New StringWriter
        Server.Execute("BKmanage/Managefiles.aspx", write, True)
        Response.Write(write)
    End Sub
End Class