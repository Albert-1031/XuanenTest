Imports System
Imports System.Data
Imports System.Configuration
Imports System.Collections
Imports System.Web
Imports System.Web.Security
Imports System.Web.UI
Imports System.Web.UI.WebControls
Imports System.Web.UI.WebControls.WebParts
Imports System.Web.UI.HtmlControls
Imports System.Drawing
Public Class NewCaptcha
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        ' 5位數字的驗證碼
        Dim str_Captcha As String = GetRandomNumberString(5)
        ' 用於驗證的Session
        Session.Add("CaptchaCode", str_Captcha)
        Me.CreateCheckCodeImage(str_Captcha)
    End Sub

    ' 隨機生成數字字符串
    Public Function GetRandomNumberString(ByVal int_NumberLength As Integer) As String
        Dim str_Number As String = String.Empty
        Dim theRandomNumber As New Random()
        For int_index As Integer = 0 To int_NumberLength - 1
            str_Number += theRandomNumber.[Next](10).ToString()
        Next
        Return str_Number
    End Function

    Private Sub CreateCheckCodeImage(ByVal checkCode As String)
        If checkCode Is Nothing OrElse checkCode.Trim() = [String].Empty Then
            Return
        End If

        Dim image As New System.Drawing.Bitmap(CInt(Math.Ceiling((checkCode.Length * 13.5))), 25)
        Dim g As System.Drawing.Graphics = Graphics.FromImage(image)

        Try
            '生成隨機生成器
            Dim random As New Random()

            '清空圖片背景色
            g.Clear(Color.White)
            For i As Integer = 0 To 24

                '畫圖片的背景噪音線
                Dim x1 As Integer = random.[Next](image.Width)
                Dim x2 As Integer = random.[Next](image.Width)
                Dim y1 As Integer = random.[Next](image.Height)
                Dim y2 As Integer = random.[Next](image.Height)

                g.DrawLine(New Pen(Color.Silver), x1, y1, x2, y2)
            Next

            Dim font As Font = New System.Drawing.Font("Arial", 14, (System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic))

            Dim brush As New System.Drawing.Drawing2D.LinearGradientBrush(New Rectangle(0, 0, image.Width, image.Height), Color.Blue, Color.DarkRed, 1.2F, True)
            g.DrawString(checkCode, font, brush, 2, 2)
            For i As Integer = 0 To 99

                '畫圖片的前景噪音點
                Dim x As Integer = random.[Next](image.Width)
                Dim y As Integer = random.[Next](image.Height)

                image.SetPixel(x, y, Color.FromArgb(random.[Next]()))
            Next

            '畫圖片的邊框線
            g.DrawRectangle(New Pen(Color.Silver), 0, 0, image.Width - 1, image.Height - 1)

            Dim ms As New System.IO.MemoryStream()
            image.Save(ms, System.Drawing.Imaging.ImageFormat.Gif)
            Response.ClearContent()
            Response.ContentType = "image/GIF"
            Response.BinaryWrite(ms.ToArray())
        Finally
            g.Dispose()
            image.Dispose()
        End Try
    End Sub
End Class