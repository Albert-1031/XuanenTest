Imports System.Web.Mvc

Namespace Controllers
    Public Class ContactUsController
        Inherits Controller

        ' GET: ContactUs
        Function ContactUs01() As ActionResult
            Select Case Request("tFlag")
                Case 0
                    Dim conn As New SQL
                    Dim E As String = "0"
                    Dim MsgStr As String = ""

                    Dim 姓名 As String = Request("txtName")
                    Dim 電話 As String = Request("txtPhone")
                    Dim 場館名稱 As String = Request("txtPlace")
                    Dim 場館業務屬性 As String = Request("Venue_Att")
                    Dim 其他洽詢內容 As String = Request("txtContact")

                    If 姓名.Length = 0 Then
                        E = "1"
                        MsgStr = "您尚未輸入[您的姓名]"
                        GoTo DoEnd
                    End If

                    If 電話.Length = 0 Then
                        E = "1"
                        MsgStr = "您尚未輸入[您的電話]"
                        GoTo DoEnd
                    End If

                    If 場館名稱.Length = 0 Then
                        E = "1"
                        MsgStr = "您尚未輸入[您的場館名稱]"
                        GoTo DoEnd
                    End If

                    If 場館業務屬性.Length = 0 Then
                        E = "1"
                        MsgStr = "您尚未選擇[您的場館業務屬性]"
                        GoTo DoEnd
                    End If

                    conn.SelectParameters.Add("姓名", 姓名)
                    conn.SelectParameters.Add("電話", 電話)
                    conn.SelectParameters.Add("場館名稱", 場館名稱)
                    conn.SelectParameters.Add("場館業務屬性", 場館業務屬性)
                    conn.SelectParameters.Add("其他洽詢內容", 其他洽詢內容)
                    Dim dv As Data.DataView = conn.SelectQuery()

                    Dim 寄件者EMail As String = "services@allec.com.tw"
                    Dim 寄件者PW As String = "allec123"
                    Dim 寄件者姓名 As String = "客服人員"
                    Dim 主旨 As String = "來自璿恩資訊官網的訊息"
                    Dim 內容 As String = ""

                    內容 = "<html><body>" &
                        "<p><font color=red>【此郵件為系統自動發送，請勿回信!!】</font></p><br/>" &
                        "－－－－－在官網填寫的資料如下－－－－－<br>" &
                        "姓名：" & 姓名 & "<br>" &
                        "電話：<br>" & 電話 & "<br>" &
                        "場館名稱：<br>" & 場館名稱 & "<br>" &
                        "場館的業務屬性：<br>" & 場館業務屬性 & "<br>" &
                        "其他洽詢內容：<br>" & 其他洽詢內容 & "<br>" &
                        "－－－－－－－－－－－－－－－－－－<br><br>" &
                        "</body></html>"

                    Dim enc As Encoding = Encoding.GetEncoding("utf-8")
                    Dim mail As New System.Net.Mail.MailMessage()

                    Dim cred As New System.Net.NetworkCredential(寄件者EMail, 寄件者PW)

                    '收件者
                    mail.To.Add(New Net.Mail.MailAddress("sales@xuanen.com.tw", "璿恩客服", enc))

                    '主旨
                    mail.Subject = 主旨
                    mail.SubjectEncoding = enc

                    '寄件者
                    mail.From = New System.Net.Mail.MailAddress(寄件者EMail, 寄件者姓名)

                    'HTML內文
                    mail.IsBodyHtml = True
                    mail.BodyEncoding = enc
                    mail.Body = 內容

                    Dim smtp As New System.Net.Mail.SmtpClient("smtp.gmail.com")

                    '順序有差
                    smtp.UseDefaultCredentials = False
                    smtp.EnableSsl = True
                    smtp.Credentials = cred
                    smtp.Port = 587

                    '送出Mail
                    smtp.Send(mail)

DoEnd:
                    Response.Write(E & "," & MsgStr & ",")
                    Response.Flush()
                    Response.SuppressContent = True
                    Return View()
                Case Else
                    ViewBag.顯示1 = ""
            End Select
            Return View()
        End Function
    End Class
End Namespace