Imports Microsoft.VisualBasic
Imports System.Web.HttpContext
Imports System.Web

Public Class pagesystem
    Function UrlReq(ByVal a As String, ByVal b As String, ByVal c As String, ByVal CurrentPage As Integer, ByVal TotalPage As Integer, Optional ByVal PSub As Integer = 3) As String
        Dim Cpage1 As String = ""
        HttpContext.Current.Response.Write(" <script type=""text/javascript"" > ")
        HttpContext.Current.Response.Write("    function CPage(" & a & ") { ")
        HttpContext.Current.Response.Write("        GoPage(" & b & ")")
        HttpContext.Current.Response.Write(" } ")
        HttpContext.Current.Response.Write(" </script> ")
        Dim NowPage As Integer = CurrentPage
        Dim MaxPage As Integer = NowPage + 3
        Dim MiniPage As Integer = NowPage - 3
        If MaxPage > TotalPage Then MaxPage = TotalPage
        If MiniPage < 1 Then MiniPage = 1
        Cpage1 = ""
        If NowPage > 1 Then
            Dim NPC1 As Integer = NowPage - 1
            Cpage1 += " <a href=""javascript:{CPage(" & PSub & "," & 1 & c & ");}"" > 第一頁</a>　"
            Cpage1 += " <a href=""javascript:{CPage(" & PSub & "," & NPC1 & c & ");}"" >上一頁</a>　"
            If NowPage > 4 Then Cpage1 = Cpage1 & "...　"
        Else
            Cpage1 = Cpage1 & "第一頁　"
            Cpage1 = Cpage1 & "<　"
        End If

        For i As Integer = MiniPage To MaxPage
            If NowPage <> i Then
                Cpage1 += " <a href=""javascript:{CPage(" & PSub & "," & i & c & ");}"" >" & i & "</a>　"
            Else
                Cpage1 = Cpage1 & i & "　"
            End If
        Next

        If NowPage < MaxPage Then
            Dim NPC2 As Integer = NowPage + 1
            If (TotalPage - 3) > NowPage Then Cpage1 = Cpage1 & "...　"
            Cpage1 += " <a href=""javascript:{CPage(" & PSub & "," & NPC2 & c & ");}"" >下一頁</a>　"
            Cpage1 += " <a href=""javascript:{CPage(" & PSub & "," & TotalPage & c & ");}"" >最後頁</a>　"
        Else
            Cpage1 = Cpage1 & " >　"
            Cpage1 = Cpage1 & " 最後頁　"
        End If
        Cpage1 = Cpage1 & "第"
        Cpage1 += " <input id=""CP1"" type=""text"" maxlength=""9"" onKeyUp=""value=value.replace(/[^\d]/g,'')"" onbeforepaste=""clipboardData.setData('text',clipboardData.getData('text').replace(/[^\d]/g,''))""　 value=""" & NowPage & """ size=""4""/>頁，共" & TotalPage & "頁" & "　"
        Cpage1 += " <input id=""CP1C"" type=""button"" value=""確定"" onclick=""CPage(" & PSub & ",document.getElementById('subform_List').CP1.value" & c & " );""  />"
        Cpage1 = Cpage1 & "　"
        Return Cpage1
    End Function

    Function UrlReqT2(ByVal a As String, ByVal b As String, ByVal c As String, ByVal CurrentPage As Integer, ByVal TotalPage As Integer, Optional ByVal PSub As Integer = 3) As String
        Dim Cpage1 As String = ""
        HttpContext.Current.Response.Write(" <script type=""text/javascript"" > ")
        HttpContext.Current.Response.Write("    function CPage(" & a & ") { ")
        HttpContext.Current.Response.Write("        GoIndexPage(" & b & ")")
        HttpContext.Current.Response.Write(" } ")
        HttpContext.Current.Response.Write(" </script> ")
        Dim NowPage As Integer = CurrentPage
        Dim MaxPage As Integer = NowPage + 3
        Dim MiniPage As Integer = NowPage - 3
        If MaxPage > TotalPage Then MaxPage = TotalPage
        If MiniPage < 1 Then MiniPage = 1
        Cpage1 = ""
        If NowPage > 1 Then
            Dim NPC1 As Integer = NowPage - 1
            Cpage1 += " <a href=""javascript:{CPage(" & PSub & "," & 1 & c & ");}"" > 第一頁</a>　"
            Cpage1 += " <a href=""javascript:{CPage(" & PSub & "," & NPC1 & c & ");}"" >上一頁</a>　"
            If NowPage > 4 Then Cpage1 = Cpage1 & "...　"
        Else
            Cpage1 = Cpage1 & "第一頁　"
            Cpage1 = Cpage1 & "<　"
        End If

        For i As Integer = MiniPage To MaxPage
            If NowPage <> i Then
                Cpage1 += " <a href=""javascript:{CPage(" & PSub & "," & i & c & ");}"" >" & i & "</a>　"
            Else
                Cpage1 = Cpage1 & i & "　"
            End If
        Next

        If NowPage < MaxPage Then
            Dim NPC2 As Integer = NowPage + 1
            If (TotalPage - 3) > NowPage Then Cpage1 = Cpage1 & "...　"
            Cpage1 += " <a href=""javascript:{CPage(" & PSub & "," & NPC2 & c & ");}"" >下一頁</a>　"
            Cpage1 += " <a href=""javascript:{CPage(" & PSub & "," & TotalPage & c & ");}"" >最後頁</a>　"
        Else
            Cpage1 = Cpage1 & " >　"
            Cpage1 = Cpage1 & " 最後頁　"
        End If
        Cpage1 = Cpage1 & "第"
        Cpage1 += " <input id=""CP1"" type=""text"" maxlength=""9"" onKeyUp=""value=value.replace(/[^\d]/g,'')"" onbeforepaste=""clipboardData.setData('text',clipboardData.getData('text').replace(/[^\d]/g,''))""　 value=""" & NowPage & """ size=""4""/>頁，共" & TotalPage & "頁" & "　"
        Cpage1 += " <input id=""CP1C"" type=""button"" value=""確定"" onclick=""CPage(" & PSub & ",document.getElementById('subform_List').CP1.value" & c & " );""  />"
        Cpage1 = Cpage1 & "　"
        Return Cpage1
    End Function
    Function UrlReqPA(ByVal a As String, ByVal b As String, ByVal c As String, ByVal CurrentPage As Integer, ByVal TotalPage As Integer, Optional ByVal PSub As Integer = 3) As String
        Dim Cpage1 As String = ""
        HttpContext.Current.Response.Write(" <script type=""text/javascript"" > ")
        HttpContext.Current.Response.Write("    function CPage(" & a & ") { ")
        HttpContext.Current.Response.Write("        GoPage(" & b & ")")
        HttpContext.Current.Response.Write(" } ")
        HttpContext.Current.Response.Write(" </script> ")
        Dim NowPage As Integer = CurrentPage
        Dim MaxPage As Integer = NowPage + 3
        Dim MiniPage As Integer = NowPage - 3
        If MaxPage > TotalPage Then MaxPage = TotalPage
        If MiniPage < 1 Then MiniPage = 1
        Cpage1 = ""

        Cpage1 = Cpage1 & "<tr>"
        If NowPage > 1 Then
            Dim NPC1 As Integer = NowPage - 1
            Cpage1 += "<td><input class=""form_buttonPA""  type=""button""  value=""上一頁"" onClick=""javascript:{CPage(" & PSub & "," & NPC1 & c & ");}"" /></td>"
        Else
            ' Cpage1 = Cpage1 & "第一頁　"
            ' Cpage1 = Cpage1 & "<　"
        End If

        If NowPage < MaxPage Then
            Dim NPC2 As Integer = NowPage + 1
            Cpage1 += "<td><input class=""form_buttonPA""  type=""button""  value=""下一頁"" onClick=""javascript:{CPage(" & PSub & "," & NPC2 & c & ");}"" /></td>"
        Else
            ' Cpage1 = Cpage1 & " >　"
            ' Cpage1 = Cpage1 & " 最後頁　"
        End If
        Cpage1 = Cpage1 & " </tr> "
        Cpage1 = Cpage1 & "　"
        Return Cpage1
    End Function

    Function UrlReqPB(ByVal a As String, ByVal b As String, ByVal c As String, ByVal CurrentPage As Integer, ByVal TotalPage As Integer, Optional ByVal PSub As Integer = 3) As String
        Dim Cpage1 As String = ""
        HttpContext.Current.Response.Write(" <script type=""text/javascript"" > ")
        HttpContext.Current.Response.Write("    function CPage(" & a & ") { ")
        HttpContext.Current.Response.Write("        GoPage(" & b & ")")
        HttpContext.Current.Response.Write(" } ")
        HttpContext.Current.Response.Write(" </script> ")
        Dim NowPage As Integer = CurrentPage
        Dim MaxPage As Integer = NowPage + 3
        Dim MiniPage As Integer = NowPage - 3
        If MaxPage > TotalPage Then MaxPage = TotalPage
        If MiniPage < 1 Then MiniPage = 1
        Cpage1 = ""

        Cpage1 = Cpage1 & "<tr>"
        If NowPage > 1 Then
            Dim NPC1 As Integer = NowPage - 1
            Cpage1 += "<td><input class=""form_buttonPB""  type=""button""  value=""上一頁"" onClick=""javascript:{CPage(" & PSub & "," & NPC1 & c & ");}"" /></td>"
        Else
            ' Cpage1 = Cpage1 & "第一頁　"
            ' Cpage1 = Cpage1 & "<　"
        End If

        If NowPage < MaxPage Then
            Dim NPC2 As Integer = NowPage + 1
            Cpage1 += "<td><input class=""form_buttonPB""  type=""button""  value=""下一頁"" onClick=""javascript:{CPage(" & PSub & "," & NPC2 & c & ");}"" /></td>"
        Else
            ' Cpage1 = Cpage1 & " >　"
            ' Cpage1 = Cpage1 & " 最後頁　"
        End If
        Cpage1 = Cpage1 & " </tr> "
        Cpage1 = Cpage1 & "　"
        Return Cpage1
    End Function
End Class
