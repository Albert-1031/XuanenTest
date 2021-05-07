Imports System.Web.Mvc

Namespace Controllers
    Public Class IndexController
        Inherits Controller

        ' GET: Index
        Function Index() As ActionResult
            Dim connT As New SQL
            Dim tp01人數 As String = ""
            Dim tp02人數 As String = ""
            Dim tp03人數 As String = ""
            connT.SelectCommand = "select p02,p03 from wp01"
            Dim dvT As Data.DataView = connT.SelectQuery()
            If dvT.Count > 0 Then
                If Not IsDBNull(dvT.Item(0).Item("p02")) Then
                    tp01人數 = dvT.Item(0).Item("p02")
                End If
                If Not IsDBNull(dvT.Item(1).Item("p02")) Then
                    tp02人數 = dvT.Item(1).Item("p02")
                End If
                If Not IsDBNull(dvT.Item(2).Item("p02")) Then
                    tp03人數 = dvT.Item(2).Item("p02")
                End If
            End If


            '台北市max人數
            ViewBag.中山健身max = "70"  'tp01
            ViewBag.中山游泳max = "180"
            ViewBag.中正健身max = "250"  'jj01
            ViewBag.中正游泳max = "100"
            ViewBag.中正冰宮max = "0"
            ViewBag.信義健身max = "65"  'tp04
            ViewBag.信義游泳max = "164"
            ViewBag.文山健身max = "65"  'tp06

            '新北市max人數
            ViewBag.蘆洲健身max = "53"  'tp07
            ViewBag.蘆洲游泳max = "210"
            ViewBag.板橋健身max = "40"  'cg01
            ViewBag.板橋游泳max = "300"
            ViewBag.板橋冰宮max = "0"
            ViewBag.板樹健身max = "45"  'sl01
            ViewBag.板樹游泳max = "30"
            ViewBag.鶯歌健身max = "50"  'ds01

            '北區max人數
            ViewBag.宜蘭健身max = "80"  'ds02
            ViewBag.宜蘭游泳max = "180"
            ViewBag.桃園健身max = "75"  'tp13
            ViewBag.桃園游泳max = "120"
            ViewBag.桃園冰宮max = "0"
            ViewBag.中壢健身max = "90"  'tp15
            ViewBag.中壢游泳max = "180"
            ViewBag.南區健身max = "90"  'tp14

            '中區max人數
            ViewBag.港區健身max = "80"  'kc01
            ViewBag.港區游泳max = "0"
            ViewBag.南屯健身max = "120"  'nd01
            ViewBag.南屯游泳max = "200"
            ViewBag.南屯冰宮max = "0"
            ViewBag.朝馬健身max = "90"  'tp11
            ViewBag.朝馬游泳max = "180"
            ViewBag.長春健身max = "100"  'wd08

            '南區max人數
            ViewBag.鳳山健身max = "160"  'wd04
            ViewBag.鳳山游泳max = "230"


            '台北市目前人數
            ViewBag.中山健身 = tp01人數
            ViewBag.中山游泳 = "18"
            ViewBag.中正健身 = "18"
            ViewBag.中正游泳 = "18"
            ViewBag.中正冰宮 = "18"
            ViewBag.信義健身 = "18"
            ViewBag.信義游泳 = "18"
            ViewBag.文山健身 = "18"

            '新北市目前人數
            ViewBag.蘆洲健身 = "18"
            ViewBag.蘆洲游泳 = "18"
            ViewBag.板橋健身 = "18"
            ViewBag.板橋游泳 = "18"
            ViewBag.板橋冰宮 = "18"
            ViewBag.板樹健身 = "18"
            ViewBag.板樹游泳 = "18"
            ViewBag.鶯歌健身 = "18"

            '北區目前人數
            ViewBag.宜蘭健身 = "18"
            ViewBag.宜蘭游泳 = "18"
            ViewBag.桃園健身 = "18"
            ViewBag.桃園游泳 = "18"
            ViewBag.桃園冰宮 = "18"
            ViewBag.中壢健身 = "18"
            ViewBag.中壢游泳 = "18"
            ViewBag.南區健身 = "18"

            '中區目前人數
            ViewBag.港區健身 = "18"
            ViewBag.港區游泳 = "18"
            ViewBag.南屯健身 = "18"
            ViewBag.南屯游泳 = "18"
            ViewBag.南屯冰宮 = "18"
            ViewBag.朝馬健身 = "18"
            ViewBag.朝馬游泳 = "18"
            ViewBag.長春健身 = "18"

            '南區目前人數
            ViewBag.鳳山健身 = "18"
            ViewBag.鳳山游泳 = "18"


            Return View()
        End Function

    End Class
End Namespace