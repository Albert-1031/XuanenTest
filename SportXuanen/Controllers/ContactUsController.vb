Imports System.Web.Mvc

Namespace Controllers
    Public Class ContactUsController
        Inherits Controller

        ' GET: ContactUs
        Function ContactUs01() As ActionResult
            ViewBag.聯絡我們 = Url.Content("~/ContactUs/ContactUs01")
            Dim E As String = "0"
            Dim MsgStr As String = ""
            Select Case Request("tFlag")
                Case 0
                    ViewBag.電話 = "0948646546"
                Case Else
                    ViewBag.電話 = "0948646541"
            End Select
DoEnd:
            Response.Write(E & "," & MsgStr)
            Response.Flush()
            Response.SuppressContent = True
            Return View()
        End Function
    End Class
End Namespace