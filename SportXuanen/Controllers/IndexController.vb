Imports System.Web.Mvc

Namespace Controllers
    Public Class IndexController
        Inherits Controller

        ' GET: Index
        Function Index() As ActionResult
            Dim connT As New SQL


#Region "台北"
            Dim tp01健身人數 As Integer = 0
            Dim tp01游泳人數 As Integer = 0

            Dim jj01健身人數 As Integer = 0
            Dim jj01游泳人數 As Integer = 0

            Dim tp04健身人數 As Integer = 0
            Dim tp04游泳人數 As Integer = 0

            Dim tp06健身人數 As Integer = 0
            Dim tp06游泳人數 As Integer = 0

            Dim tp03健身人數 As Integer = 0
            Dim tp03游泳人數 As Integer = 0

            Dim wd02健身人數 As Integer = 0
            Dim wd02游泳人數 As Integer = 0

            Dim slsc68健身人數 As Integer = 0
            Dim slsc68游泳人數 As Integer = 0

            Dim tp12健身人數 As Integer = 0
            Dim tp12游泳人數 As Integer = 0

            Dim tp02健身人數 As Integer = 0
            Dim tp02游泳人數 As Integer = 0

#End Region
#Region "新北"
            Dim tp07健身人數 As Integer = 0
            Dim tp07游泳人數 As Integer = 0

            Dim cg01健身人數 As Integer = 0
            Dim cg01游泳人數 As Integer = 0

            Dim sl01健身人數 As Integer = 0
            Dim sl01游泳人數 As Integer = 0

            Dim ds01健身人數 As Integer = 0
            Dim ds01游泳人數 As Integer = 0
            Dim ds01健身_2人數 As Integer = 0

            Dim tp08健身人數 As Integer = 0
            Dim tp08游泳人數 As Integer = 0
            Dim tp08冰宮人數 As Integer = 0

            Dim fe01健身人數 As Integer = 0
            Dim fe01游泳人數 As Integer = 0

            Dim tp10健身人數 As Integer = 0
            Dim tp10游泳人數 As Integer = 0

            Dim tp17健身人數 As Integer = 0
            Dim tp17游泳人數 As Integer = 0

            Dim tp09健身人數 As Integer = 0
            Dim tp09游泳人數 As Integer = 0

            Dim ts01健身人數 As Integer = 0
            Dim ts01游泳人數 As Integer = 0

            Dim xwt88健身人數 As Integer = 0
            Dim xwt88游泳人數 As Integer = 0

            Dim nt01健身人數 As Integer = 0
            Dim nt01游泳人數 As Integer = 0
#End Region
#Region "北部"
            Dim ds02健身人數 As Integer = 0
            Dim ds02游泳人數 As Integer = 0

            Dim tp13健身人數 As Integer = 0
            Dim tp13游泳人數 As Integer = 0

            Dim tp15健身人數 As Integer = 0
            Dim tp15游泳人數 As Integer = 0

            Dim tp14健身人數 As Integer = 0
            Dim tp14游泳人數 As Integer = 0

            Dim ws01健身人數 As Integer = 0
            Dim ws01游泳人數 As Integer = 0

            Dim fe02健身人數 As Integer = 0
            Dim fe02游泳人數 As Integer = 0

            Dim tp16健身人數 As Integer = 0
            Dim tp16游泳人數 As Integer = 0
#End Region
#Region "中部"
            Dim kc01健身人數 As Integer = 0
            Dim kc01游泳人數 As Integer = 0

            Dim jb01健身人數 As Integer = 0
            Dim jb01游泳人數 As Integer = 0

            Dim tp11健身人數 As Integer = 0
            Dim tp11游泳人數 As Integer = 0

            Dim wd08健身人數 As Integer = 0
            Dim wd08游泳人數 As Integer = 0

            Dim nd01健身人數 As Integer = 0
            Dim nd01游泳人數 As Integer = 0
#End Region
#Region "南部"
            Dim wd04健身人數 As Integer = 0
            Dim wd04游泳人數 As Integer = 0
#End Region

            connT.SelectCommand = "select p01,p02,p03,p04 from wp01"
            Dim dvT As Data.DataView = connT.SelectQuery()
            If dvT.Count > 0 Then
                For i As Integer = 0 To dvT.Count - 1
                    Select Case dvT.Item(i).Item("p01")
#Region "台北Case"
                        Case "tp01"
                            tp01游泳人數 = dvT.Item(i).Item("p02")
                            tp01健身人數 = dvT.Item(i).Item("p03")
                        Case "jj01"
                            jj01游泳人數 = dvT.Item(i).Item("p02")
                            jj01健身人數 = dvT.Item(i).Item("p03")
                        Case "tp04"
                            tp04游泳人數 = dvT.Item(i).Item("p02")
                            tp04健身人數 = dvT.Item(i).Item("p03")
                        Case "tp06"
                            tp06游泳人數 = dvT.Item(i).Item("p02")
                            tp06健身人數 = dvT.Item(i).Item("p03")
                        Case "tp03"
                            tp03游泳人數 = dvT.Item(i).Item("p02")
                            tp03健身人數 = dvT.Item(i).Item("p03")
                        Case "wd02"
                            wd02游泳人數 = dvT.Item(i).Item("p02")
                            wd02健身人數 = dvT.Item(i).Item("p03")
                        Case "slsc68"
                            slsc68游泳人數 = dvT.Item(i).Item("p02")
                            slsc68健身人數 = dvT.Item(i).Item("p03")
                        Case "tp12"
                            tp12游泳人數 = dvT.Item(i).Item("p02")
                            tp12健身人數 = dvT.Item(i).Item("p03")
                        Case "tp02"
                            tp02游泳人數 = dvT.Item(i).Item("p02")
                            tp02健身人數 = dvT.Item(i).Item("p03")

#End Region
#Region "新北Case"
                        Case "tp07"
                            tp07游泳人數 = dvT.Item(i).Item("p02")
                            tp07健身人數 = dvT.Item(i).Item("p03")
                        Case "cg01"
                            cg01游泳人數 = dvT.Item(i).Item("p02")
                            cg01健身人數 = dvT.Item(i).Item("p03")
                        Case "sl01"
                            sl01游泳人數 = dvT.Item(i).Item("p02")
                            sl01健身人數 = dvT.Item(i).Item("p03")
                        Case "ds01"
                            ds01游泳人數 = dvT.Item(i).Item("p02")
                            ds01健身人數 = dvT.Item(i).Item("p03")
                            ds01健身_2人數 = dvT.Item(i).Item("p04")
                        Case "tp08"
                            tp08游泳人數 = dvT.Item(i).Item("p02")
                            tp08健身人數 = dvT.Item(i).Item("p03")
                            tp08冰宮人數 = dvT.Item(i).Item("p04")
                        Case "fe01"
                            fe01游泳人數 = dvT.Item(i).Item("p02")
                            fe01健身人數 = dvT.Item(i).Item("p03")
                        Case "tp10"
                            tp10游泳人數 = dvT.Item(i).Item("p02")
                            tp10健身人數 = dvT.Item(i).Item("p03")
                        Case "tp17"
                            tp17游泳人數 = dvT.Item(i).Item("p02")
                            tp17健身人數 = dvT.Item(i).Item("p03")
                        Case "tp09"
                            tp09游泳人數 = dvT.Item(i).Item("p02")
                            tp09健身人數 = dvT.Item(i).Item("p03")
                        Case "ts01"
                            ts01游泳人數 = dvT.Item(i).Item("p02")
                            ts01健身人數 = dvT.Item(i).Item("p03")
                        Case "xwt88"
                            xwt88游泳人數 = dvT.Item(i).Item("p02")
                            xwt88健身人數 = dvT.Item(i).Item("p03")
                        Case "nt01"
                            nt01游泳人數 = dvT.Item(i).Item("p02")
                            nt01健身人數 = dvT.Item(i).Item("p03")


#End Region
#Region "北部Case"
                        Case "ds02"
                            ds02游泳人數 = dvT.Item(i).Item("p02")
                            ds02健身人數 = dvT.Item(i).Item("p03")
                        Case "tp13"
                            tp13游泳人數 = dvT.Item(i).Item("p02")
                            tp13健身人數 = dvT.Item(i).Item("p03")
                        Case "tp15"
                            tp15游泳人數 = dvT.Item(i).Item("p02")
                            tp15健身人數 = dvT.Item(i).Item("p03")
                        Case "tp14"
                            tp14游泳人數 = dvT.Item(i).Item("p02")
                            tp14健身人數 = dvT.Item(i).Item("p03")
                        Case "ws01"
                            ws01游泳人數 = dvT.Item(i).Item("p02")
                            ws01健身人數 = dvT.Item(i).Item("p03")
                        Case "fe02"
                            fe02游泳人數 = dvT.Item(i).Item("p02")
                            fe02健身人數 = dvT.Item(i).Item("p03")
                        Case "tp16"
                            tp16游泳人數 = dvT.Item(i).Item("p02")
                            tp16健身人數 = dvT.Item(i).Item("p03")

#End Region
#Region "中部Case"
                        Case "kc01"
                            kc01游泳人數 = dvT.Item(i).Item("p02")
                        Case "jb01"
                            jb01游泳人數 = dvT.Item(i).Item("p02")
                            jb01健身人數 = dvT.Item(i).Item("p03")
                        Case "tp11"
                            tp11游泳人數 = dvT.Item(i).Item("p02")
                            tp11健身人數 = dvT.Item(i).Item("p03")
                        Case "wd08"
                            wd08游泳人數 = dvT.Item(i).Item("p02")
                            wd08健身人數 = dvT.Item(i).Item("p03")
                        Case "nd01"
                            nd01游泳人數 = dvT.Item(i).Item("p02")
                            nd01健身人數 = dvT.Item(i).Item("p03")

#End Region
#Region "南部Case"
                        Case "wd04"
                            wd04游泳人數 = dvT.Item(i).Item("p02")
                            wd04健身人數 = dvT.Item(i).Item("p03")
                    End Select
                Next
            End If
#End Region


#Region "台北人數"
            ViewBag.台北店家0 = "中山運動中心"
            ViewBag.台北店家0_健身 = tp01健身人數
            ViewBag.台北店家0_游泳 = tp01游泳人數
            ViewBag.台北店家0_健身max = "50"
            ViewBag.台北店家0_游泳max = "100"

            ViewBag.台北店家1 = "中正運動中心"
            ViewBag.台北店家1_健身 = jj01健身人數
            ViewBag.台北店家1_游泳 = jj01游泳人數
            ViewBag.台北店家1_健身max = "100"
            ViewBag.台北店家1_游泳max = "100"

            ViewBag.台北店家2 = "信義運動中心"
            ViewBag.台北店家2_健身 = tp04健身人數
            ViewBag.台北店家2_游泳 = tp04游泳人數
            ViewBag.台北店家2_健身max = "65"
            ViewBag.台北店家2_游泳max = "100"

            ViewBag.台北店家3 = "文山運動中心"
            ViewBag.台北店家3_健身 = tp06健身人數
            ViewBag.台北店家3_游泳 = tp06游泳人數
            ViewBag.台北店家3_健身max = "65"
            ViewBag.台北店家3_游泳max = "100"

            ViewBag.台北店家4 = "大安運動中心"
            ViewBag.台北店家4_健身 = tp03健身人數
            ViewBag.台北店家4_游泳 = tp03游泳人數
            ViewBag.台北店家4_健身max = "70"
            ViewBag.台北店家4_游泳max = "100"

            ViewBag.台北店家5 = "大同運動中心"
            ViewBag.台北店家5_健身 = wd02健身人數
            ViewBag.台北店家5_游泳 = wd02游泳人數
            ViewBag.台北店家5_健身max = "90"
            ViewBag.台北店家5_游泳max = "100"

            ViewBag.台北店家6 = "士林運動中心"
            ViewBag.台北店家6_健身 = slsc68健身人數
            ViewBag.台北店家6_游泳 = slsc68游泳人數
            ViewBag.台北店家6_健身max = "70"
            ViewBag.台北店家6_游泳max = "100"

            ViewBag.台北店家7 = "內湖運動中心"
            ViewBag.台北店家7_健身 = tp12健身人數
            ViewBag.台北店家7_游泳 = tp12游泳人數
            ViewBag.台北店家7_健身max = "99"
            ViewBag.台北店家7_游泳max = "99"

            ViewBag.台北店家8 = "南港運動中心"
            ViewBag.台北店家8_健身 = tp02健身人數
            ViewBag.台北店家8_游泳 = tp02游泳人數
            ViewBag.台北店家8_健身max = "85"
            ViewBag.台北店家8_游泳max = "100"
#End Region
#Region "新北人數"
            ViewBag.新北店家0 = "蘆洲運動中心"
            ViewBag.新北店家0_健身 = tp07健身人數
            ViewBag.新北店家0_游泳 = tp07游泳人數
            ViewBag.新北店家0_健身max = "38"
            ViewBag.新北店家0_游泳max = "105"

            ViewBag.新北店家1 = "板橋運動中心"
            ViewBag.新北店家1_健身 = cg01健身人數
            ViewBag.新北店家1_游泳 = cg01游泳人數
            ViewBag.新北店家1_健身max = "40"
            ViewBag.新北店家1_游泳max = "300"

            ViewBag.新北店家2 = "樹林體育園區"
            ViewBag.新北店家2_健身 = sl01健身人數
            ViewBag.新北店家2_游泳 = sl01游泳人數
            ViewBag.新北店家2_健身max = "45"
            ViewBag.新北店家2_游泳max = "30"

            ViewBag.新北店家3 = "鶯歌運動中心"
            ViewBag.新北店家3_健身 = ds01健身_2人數
            ViewBag.新北店家3_健身max = "50"

            ViewBag.新北店家4 = "土城運動中心"
            ViewBag.新北店家4_健身 = tp08健身人數
            ViewBag.新北店家4_游泳 = tp08游泳人數
            ViewBag.新北店家4_冰宮 = tp08冰宮人數
            ViewBag.新北店家4_健身max = "50"
            ViewBag.新北店家4_游泳max = "115"
            ViewBag.新北店家4_冰宮max = "100"

            ViewBag.新北店家5 = "三重運動中心"
            ViewBag.新北店家5_健身 = fe01健身人數
            ViewBag.新北店家5_游泳 = fe01游泳人數
            ViewBag.新北店家5_健身max = "50"
            ViewBag.新北店家5_游泳max = "175"

            ViewBag.新北店家6 = "永和運動中心"
            ViewBag.新北店家6_健身 = tp10健身人數
            ViewBag.新北店家6_游泳 = tp10游泳人數
            ViewBag.新北店家6_健身max = "35"
            ViewBag.新北店家6_游泳max = "150"

            ViewBag.新北店家7 = "林口運動中心"
            ViewBag.新北店家7_健身 = tp17健身人數
            ViewBag.新北店家7_游泳 = tp17游泳人數
            ViewBag.新北店家7_健身max = "40"
            ViewBag.新北店家7_游泳max = "100"

            ViewBag.新北店家8 = "汐止運動中心"
            ViewBag.新北店家8_健身 = tp09健身人數
            ViewBag.新北店家8_游泳 = tp09游泳人數
            ViewBag.新北店家8_健身max = "40"
            ViewBag.新北店家8_游泳max = "100"

            ViewBag.新北店家9 = "淡水運動中心"
            ViewBag.新北店家9_健身 = ts01健身人數
            ViewBag.新北店家9_游泳 = ts01游泳人數
            ViewBag.新北店家9_健身max = "50"
            ViewBag.新北店家9_游泳max = "200"

            ViewBag.新北店家10 = "新五泰運動中心"
            ViewBag.新北店家10_健身 = xwt88健身人數
            ViewBag.新北店家10_游泳 = xwt88游泳人數
            ViewBag.新北店家10_健身max = "45"
            ViewBag.新北店家10_游泳max = "120"

            ViewBag.新北店家11 = "三鶯運動中心"
            ViewBag.新北店家11_健身 = ds01健身人數
            ViewBag.新北店家11_游泳 = ds01游泳人數
            ViewBag.新北店家11_健身max = "50"
            ViewBag.新北店家11_游泳max = "200"

            ViewBag.新北店家12 = "樹林運動中心"
            ViewBag.新北店家12_健身 = nt01健身人數
            ViewBag.新北店家12_游泳 = nt01游泳人數
            ViewBag.新北店家12_健身max = "50"
            ViewBag.新北店家12_游泳max = "175"

#End Region
#Region "北部人數"
            ViewBag.北部店家0 = "宜蘭運動中心"
            ViewBag.北部店家0_健身 = ds02健身人數
            ViewBag.北部店家0_游泳 = ds02游泳人數
            ViewBag.北部店家0_健身max = "50"
            ViewBag.北部店家0_游泳max = "100"

            ViewBag.北部店家1 = "桃園運動中心"
            ViewBag.北部店家1_健身 = tp13健身人數
            ViewBag.北部店家1_游泳 = tp13游泳人數
            ViewBag.北部店家1_健身max = "75"
            ViewBag.北部店家1_游泳max = "120"

            ViewBag.北部店家2 = "中壢運動中心"
            ViewBag.北部店家2_健身 = tp15健身人數
            ViewBag.北部店家2_游泳 = tp15游泳人數
            ViewBag.北部店家2_健身max = "90"
            ViewBag.北部店家2_游泳max = "99"

            ViewBag.北部店家4 = "南區青少年活動中心"
            ViewBag.北部店家4_健身 = tp14健身人數
            ViewBag.北部店家4_游泳 = tp14游泳人數
            ViewBag.北部店家4_健身max = "90"
            ViewBag.北部店家4_游泳max = "100"

            ViewBag.北部店家3 = "大溪國小運動中心"
            ViewBag.北部店家3_健身 = ws01健身人數
            ViewBag.北部店家3_游泳 = ws01游泳人數
            ViewBag.北部店家3_健身max = "72"
            ViewBag.北部店家3_游泳max = "144"

            ViewBag.北部店家5 = "竹北運動中心"
            ViewBag.北部店家5_健身 = fe02健身人數
            ViewBag.北部店家5_游泳 = fe02游泳人數
            ViewBag.北部店家5_健身max = "150"
            ViewBag.北部店家5_游泳max = "350"

            ViewBag.北部店家6 = "竹光運動中心"
            ViewBag.北部店家6_健身 = tp16健身人數
            ViewBag.北部店家6_游泳 = tp16游泳人數
            ViewBag.北部店家6_健身max = "75"
            ViewBag.北部店家6_游泳max = "180"

#End Region
#Region "中部人數"
            ViewBag.中部店家0 = "港區運動公園"
            ViewBag.中部店家0_健身 = kc01健身人數
            ViewBag.中部店家0_健身max = "80"

            ViewBag.中部店家1 = "彰北運動中心"
            ViewBag.中部店家1_健身 = jb01健身人數
            ViewBag.中部店家1_游泳 = jb01游泳人數
            ViewBag.中部店家1_健身max = "80"
            ViewBag.中部店家1_游泳max = "200"

            ViewBag.中部店家2 = "朝馬運動中心"
            ViewBag.中部店家2_健身 = tp11健身人數
            ViewBag.中部店家2_游泳 = tp11游泳人數
            ViewBag.中部店家2_健身max = "90"
            ViewBag.中部店家2_游泳max = "180"

            ViewBag.中部店家3 = "長春運動中心"
            ViewBag.中部店家3_健身 = wd08健身人數
            ViewBag.中部店家3_游泳 = wd08游泳人數
            ViewBag.中部店家3_健身max = "100"
            ViewBag.中部店家3_游泳max = "200"

            ViewBag.中部店家4 = "南屯運動中心"
            ViewBag.中部店家4_健身 = nd01健身人數
            ViewBag.中部店家4_游泳 = nd01游泳人數
            ViewBag.中部店家4_健身max = "120"
            ViewBag.中部店家4_游泳max = "200"

#End Region
#Region "南部人數"
            ViewBag.南部店家0 = "鳳山運動園區"
            ViewBag.南部店家0_健身 = wd04健身人數
            ViewBag.南部店家0_游泳 = wd04游泳人數
            ViewBag.南部店家0_健身max = "100"
            ViewBag.南部店家0_游泳max = "230"

            ViewBag.南部店家1 = "屏東運動中心"
            ViewBag.南部店家1_健身 = "暫無"
            ViewBag.南部店家1_游泳 = "暫無"
            ViewBag.南部店家1_健身max = "暫無"
            ViewBag.南部店家1_游泳max = "暫無"

#End Region

            Return View()
        End Function

    End Class
End Namespace