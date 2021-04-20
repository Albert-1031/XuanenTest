Imports System.Web.Mvc
Imports System.Web.Routing

Public Class Global_asax
    Inherits HttpApplication

    Sub Application_Start(sender As Object, e As EventArgs)
        ' 在應用程式啟動時引發
        AreaRegistration.RegisterAllAreas()
        RouteConfig.RegisterRoutes(RouteTable.Routes)
    End Sub

    Sub Application_Error(ByVal sender As Object, ByVal e As EventArgs)
        ' 在錯誤發生時引發
        _Report("Application_Error", Server.GetLastError.GetBaseException.Message)
        _Report("Application_Error", Server.GetLastError.GetBaseException.StackTrace)
    End Sub
End Class