Imports System.Web.Mvc

Namespace Controllers
    Public Class IndexController
        Inherits Controller

        ' GET: Index
        Function Index() As ActionResult
            Dim connT As New SQL
            '台北
            Dim tp01健身人數 As Integer = 0
            Dim tp01游泳人數 As Integer = 0
            Dim jj01健身人數 As Integer = 0
            Dim jj01游泳人數 As Integer = 0
            Dim jj01冰宮人數 As Integer = 0
            Dim tp04健身人數 As Integer = 0
            Dim tp04游泳人數 As Integer = 0
            Dim tp06健身人數 As Integer = 0

            '新北
            Dim tp07健身人數 As Integer = 0
            Dim tp07游泳人數 As Integer = 0
            Dim cg01健身人數 As Integer = 0
            Dim cg01游泳人數 As Integer = 0
            Dim cg01冰宮人數 As Integer = 0
            Dim sl01健身人數 As Integer = 0
            Dim sl01游泳人數 As Integer = 0
            Dim ds01健身人數 As Integer = 0

            '北區
            Dim ds02健身人數 As Integer = 0
            Dim ds02游泳人數 As Integer = 0
            Dim tp13健身人數 As Integer = 0
            Dim tp13游泳人數 As Integer = 0
            Dim tp13冰宮人數 As Integer = 0
            Dim tp15健身人數 As Integer = 0
            Dim tp15游泳人數 As Integer = 0
            Dim tp14健身人數 As Integer = 0

            '中區
            Dim kc01健身人數 As Integer = 0
            Dim kc01游泳人數 As Integer = 0
            Dim nd01健身人數 As Integer = 0
            Dim nd01游泳人數 As Integer = 0
            Dim nd01冰宮人數 As Integer = 0
            Dim tp11健身人數 As Integer = 0
            Dim tp11游泳人數 As Integer = 0
            Dim wd08健身人數 As Integer = 0

            '南區
            Dim wd04健身人數 As Integer = 0
            Dim wd04游泳人數 As Integer = 0

            connT.SelectCommand = "select p01,p02,p03,p04 from wp01"
            Dim dvT As Data.DataView = connT.SelectQuery()
            If dvT.Count > 0 Then
                For i As Integer = 0 To dvT.Count - 1
                    Select Case dvT.Item(i).Item("p01")
                        '台北
                        Case "tp01"
                            tp01游泳人數 = dvT.Item(i).Item("p02")
                            tp01健身人數 = dvT.Item(i).Item("p03")
                        Case "jj01"
                            jj01游泳人數 = dvT.Item(i).Item("p02")
                            jj01健身人數 = dvT.Item(i).Item("p03")
                            jj01冰宮人數 = dvT.Item(i).Item("p04")
                        Case "tp04"
                            tp04游泳人數 = dvT.Item(i).Item("p02")
                            tp04健身人數 = dvT.Item(i).Item("p03")
                        Case "tp06"
                            tp06健身人數 = dvT.Item(i).Item("p03")

                        '新北
                        Case "tp07"
                            tp07游泳人數 = dvT.Item(i).Item("p02")
                            tp07健身人數 = dvT.Item(i).Item("p03")
                        Case "cg01"
                            cg01游泳人數 = dvT.Item(i).Item("p02")
                            cg01健身人數 = dvT.Item(i).Item("p03")
                            cg01冰宮人數 = dvT.Item(i).Item("p04")
                        Case "sl01"
                            sl01游泳人數 = dvT.Item(i).Item("p02")
                            sl01健身人數 = dvT.Item(i).Item("p03")
                        Case "ds01"
                            ds01健身人數 = dvT.Item(i).Item("p03")

                        '北區
                        Case "ds02"
                            ds02游泳人數 = dvT.Item(i).Item("p02")
                            ds02健身人數 = dvT.Item(i).Item("p03")
                        Case "tp13"
                            tp13游泳人數 = dvT.Item(i).Item("p02")
                            tp13健身人數 = dvT.Item(i).Item("p03")
                            tp13冰宮人數 = dvT.Item(i).Item("p04")
                        Case "tp15"
                            tp15游泳人數 = dvT.Item(i).Item("p02")
                            tp15健身人數 = dvT.Item(i).Item("p03")
                        Case "tp14"
                            tp14健身人數 = dvT.Item(i).Item("p03")

                        '中區
                        Case "kc01"
                            kc01游泳人數 = dvT.Item(i).Item("p02")
                            kc01健身人數 = dvT.Item(i).Item("p03")
                        Case "nd01"
                            nd01游泳人數 = dvT.Item(i).Item("p02")
                            nd01健身人數 = dvT.Item(i).Item("p03")
                            nd01冰宮人數 = dvT.Item(i).Item("p04")
                        Case "tp11"
                            tp11游泳人數 = dvT.Item(i).Item("p02")
                            tp11健身人數 = dvT.Item(i).Item("p03")
                        Case "wd08"
                            wd08健身人數 = dvT.Item(i).Item("p03")

                        '南區
                        Case "wd04"
                            wd04游泳人數 = dvT.Item(i).Item("p02")
                            wd04健身人數 = dvT.Item(i).Item("p03")
                    End Select
                Next
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


            '台北市目前人數-------------------
            ViewBag.中山健身 = tp01健身人數
            ViewBag.中山游泳 = tp01游泳人數
            ViewBag.中正健身 = jj01健身人數
            ViewBag.中正游泳 = jj01游泳人數
            ViewBag.中正冰宮 = jj01冰宮人數
            ViewBag.信義健身 = tp04健身人數
            ViewBag.信義游泳 = tp04游泳人數
            ViewBag.文山健身 = tp06健身人數

            '新北市目前人數
            ViewBag.蘆洲健身 = tp07健身人數
            ViewBag.蘆洲游泳 = tp07游泳人數
            ViewBag.板橋健身 = cg01健身人數
            ViewBag.板橋游泳 = cg01游泳人數
            ViewBag.板橋冰宮 = cg01冰宮人數
            ViewBag.板樹健身 = sl01健身人數
            ViewBag.板樹游泳 = sl01游泳人數
            ViewBag.鶯歌健身 = ds01健身人數

            '北區目前人數
            ViewBag.宜蘭健身 = ds02健身人數
            ViewBag.宜蘭游泳 = ds02游泳人數
            ViewBag.桃園健身 = tp13健身人數
            ViewBag.桃園游泳 = tp13游泳人數
            ViewBag.桃園冰宮 = tp13冰宮人數
            ViewBag.中壢健身 = tp15健身人數
            ViewBag.中壢游泳 = tp15游泳人數
            ViewBag.南區健身 = tp14健身人數

            '中區目前人數
            ViewBag.港區健身 = kc01健身人數
            ViewBag.港區游泳 = kc01游泳人數
            ViewBag.南屯健身 = nd01健身人數
            ViewBag.南屯游泳 = nd01游泳人數
            ViewBag.南屯冰宮 = nd01冰宮人數
            ViewBag.朝馬健身 = tp11健身人數
            ViewBag.朝馬游泳 = tp11游泳人數
            ViewBag.長春健身 = wd08健身人數

            '南區目前人數
            ViewBag.鳳山健身 = wd04健身人數
            ViewBag.鳳山游泳 = wd04游泳人數

            Return View()
        End Function

    End Class
End Namespace