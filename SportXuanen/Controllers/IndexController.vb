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
            Dim tp01健身留容人數 As Integer = 0
            Dim tp01游泳留容人數 As Integer = 0

            Dim jj01健身人數 As Integer = 0
            Dim jj01游泳人數 As Integer = 0
            Dim jj01健身留容人數 As Integer = 0
            Dim jj01游泳留容人數 As Integer = 0

            Dim tp04健身人數 As Integer = 0
            Dim tp04游泳人數 As Integer = 0
            Dim tp04健身留容人數 As Integer = 0
            Dim tp04游泳留容人數 As Integer = 0

            Dim tp06健身人數 As Integer = 0
            Dim tp06游泳人數 As Integer = 0
            Dim tp06健身留容人數 As Integer = 0
            Dim tp06游泳留容人數 As Integer = 0

            Dim tp03健身人數 As Integer = 0
            Dim tp03游泳人數 As Integer = 0
            Dim tp03健身留容人數 As Integer = 0
            Dim tp03游泳留容人數 As Integer = 0

            Dim wd02健身人數 As Integer = 0
            Dim wd02游泳人數 As Integer = 0
            Dim wd02健身留容人數 As Integer = 0
            Dim wd02游泳留容人數 As Integer = 0

            Dim slsc68健身人數 As Integer = 0
            Dim slsc68游泳人數 As Integer = 0
            Dim slsc68健身留容人數 As Integer = 0
            Dim slsc68游泳留容人數 As Integer = 0

            Dim tp12健身人數 As Integer = 0
            Dim tp12游泳人數 As Integer = 0
            Dim tp12健身留容人數 As Integer = 0
            Dim tp12游泳留容人數 As Integer = 0

            Dim tp02健身人數 As Integer = 0
            Dim tp02游泳人數 As Integer = 0
            Dim tp02健身留容人數 As Integer = 0
            Dim tp02游泳留容人數 As Integer = 0

            Dim wp05健身人數 As Integer = 0
            Dim wp05游泳人數 As Integer = 0
            Dim wp05健身留容人數 As Integer = 0
            Dim wp05游泳留容人數 As Integer = 0

#End Region
#Region "新北"
            Dim tp07健身人數 As Integer = 0
            Dim tp07游泳人數 As Integer = 0
            Dim tp07健身留容人數 As Integer = 0
            Dim tp07游泳留容人數 As Integer = 0

            Dim cg01健身人數 As Integer = 0
            Dim cg01游泳人數 As Integer = 0
            Dim cg01健身留容人數 As Integer = 0
            Dim cg01游泳留容人數 As Integer = 0

            Dim sl01健身人數 As Integer = 0
            Dim sl01游泳人數 As Integer = 0
            Dim sl01健身留容人數 As Integer = 0
            Dim sl01游泳留容人數 As Integer = 0

            Dim wd05健身人數 As Integer = 0
            Dim wd05游泳人數 As Integer = 0
            Dim wd05健身留容人數 As Integer = 0
            Dim wd05游泳留容人數 As Integer = 0

            Dim ds01健身人數 As Integer = 0
            Dim ds01游泳人數 As Integer = 0
            Dim ds01健身_2人數 As Integer = 0
            Dim ds01健身留容人數 As Integer = 0
            Dim ds01游泳留容人數 As Integer = 0
            Dim ds01健身留容_2人數 As Integer = 0

            Dim tp08健身人數 As Integer = 0
            Dim tp08游泳人數 As Integer = 0
            Dim tp08冰宮人數 As Integer = 0
            Dim tp08健身留容人數 As Integer = 0
            Dim tp08游泳留容人數 As Integer = 0
            Dim tp08冰宮留容人數 As Integer = 0

            Dim fe01健身人數 As Integer = 0
            Dim fe01游泳人數 As Integer = 0
            Dim fe01健身留容人數 As Integer = 0
            Dim fe01游泳留容人數 As Integer = 0

            Dim tp10健身人數 As Integer = 0
            Dim tp10游泳人數 As Integer = 0
            Dim tp10健身留容人數 As Integer = 0
            Dim tp10游泳留容人數 As Integer = 0

            Dim tp17健身人數 As Integer = 0
            Dim tp17游泳人數 As Integer = 0
            Dim tp17健身留容人數 As Integer = 0
            Dim tp17游泳留容人數 As Integer = 0

            Dim tp09健身人數 As Integer = 0
            Dim tp09游泳人數 As Integer = 0
            Dim tp09健身留容人數 As Integer = 0
            Dim tp09游泳留容人數 As Integer = 0

            Dim ts01健身人數 As Integer = 0
            Dim ts01游泳人數 As Integer = 0
            Dim ts01健身留容人數 As Integer = 0
            Dim ts01游泳留容人數 As Integer = 0

            Dim xwt88健身人數 As Integer = 0
            Dim xwt88游泳人數 As Integer = 0
            Dim xwt88健身留容人數 As Integer = 0
            Dim xwt88游泳留容人數 As Integer = 0

            Dim nt01健身人數 As Integer = 0
            Dim nt01游泳人數 As Integer = 0
            Dim nt01健身留容人數 As Integer = 0
            Dim nt01游泳留容人數 As Integer = 0
#End Region
#Region "北部"
            Dim ds02健身人數 As Integer = 0
            Dim ds02游泳人數 As Integer = 0
            Dim ds02健身留容人數 As Integer = 0
            Dim ds02游泳留容人數 As Integer = 0

            Dim tp13健身人數 As Integer = 0
            Dim tp13游泳人數 As Integer = 0
            Dim tp13健身留容人數 As Integer = 0
            Dim tp13游泳留容人數 As Integer = 0

            Dim tp15健身人數 As Integer = 0
            Dim tp15游泳人數 As Integer = 0
            Dim tp15健身留容人數 As Integer = 0
            Dim tp15游泳留容人數 As Integer = 0


            Dim tp14健身人數 As Integer = 0
            Dim tp14游泳人數 As Integer = 0
            Dim tp14健身留容人數 As Integer = 0
            Dim tp14游泳留容人數 As Integer = 0


            Dim ws01健身人數 As Integer = 0
            Dim ws01游泳人數 As Integer = 0
            Dim ws01健身留容人數 As Integer = 0
            Dim ws01游泳留容人數 As Integer = 0


            Dim fe02健身人數 As Integer = 0
            Dim fe02游泳人數 As Integer = 0
            Dim fe02健身留容人數 As Integer = 0
            Dim fe02游泳留容人數 As Integer = 0


            Dim tp16健身人數 As Integer = 0
            Dim tp16游泳人數 As Integer = 0
            Dim tp16健身留容人數 As Integer = 0
            Dim tp16游泳留容人數 As Integer = 0


            Dim tp18健身人數 As Integer = 0
            Dim tp18游泳人數 As Integer = 0
            Dim tp18健身留容人數 As Integer = 0
            Dim tp18游泳留容人數 As Integer = 0

            Dim um01健身人數 As Integer = 0
            Dim um01游泳人數 As Integer = 0
            Dim um01健身留容人數 As Integer = 0
            Dim um01游泳留容人數 As Integer = 0

#End Region
#Region "中部"
            Dim kc01健身人數 As Integer = 0
            Dim kc01游泳人數 As Integer = 0
            Dim kc01健身留容人數 As Integer = 0
            Dim kc01游泳留容人數 As Integer = 0

            Dim jb01健身人數 As Integer = 0
            Dim jb01游泳人數 As Integer = 0
            Dim jb01健身留容人數 As Integer = 0
            Dim jb01游泳留容人數 As Integer = 0


            Dim tp11健身人數 As Integer = 0
            Dim tp11游泳人數 As Integer = 0
            Dim tp11健身留容人數 As Integer = 0
            Dim tp11游泳留容人數 As Integer = 0


            Dim wd08健身人數 As Integer = 0
            Dim wd08游泳人數 As Integer = 0
            Dim wd08健身留容人數 As Integer = 0
            Dim wd08游泳留容人數 As Integer = 0


            Dim nd01健身人數 As Integer = 0
            Dim nd01游泳人數 As Integer = 0
            Dim nd01健身留容人數 As Integer = 0
            Dim nd01游泳留容人數 As Integer = 0


            Dim tz01健身人數 As Integer = 0
            Dim tz01游泳人數 As Integer = 0
            Dim tz01健身留容人數 As Integer = 0
            Dim tz01游泳留容人數 As Integer = 0


            Dim wd15健身人數 As Integer = 0
            Dim wd15游泳人數 As Integer = 0
            Dim wd15健身留容人數 As Integer = 0
            Dim wd15游泳留容人數 As Integer = 0

            Dim wd14健身人數 As Integer = 0
            Dim wd14游泳人數 As Integer = 0
            Dim wd14健身留容人數 As Integer = 0
            Dim wd14游泳留容人數 As Integer = 0

#End Region
#Region "南部"
            Dim wd04健身人數 As Integer = 0
            Dim wd04游泳人數 As Integer = 0
            Dim wd04健身留容人數 As Integer = 0
            Dim wd04游泳留容人數 As Integer = 0

            Dim pt01健身人數 As Integer = 0
            Dim pt01游泳人數 As Integer = 0
            Dim pt01健身留容人數 As Integer = 0
            Dim pt01游泳留容人數 As Integer = 0

            Dim wd16健身人數 As Integer = 0
            Dim wd16游泳人數 As Integer = 0
            Dim wd16健身留容人數 As Integer = 0
            Dim wd16游泳留容人數 As Integer = 0

            Dim zy01健身人數 As Integer = 0
            Dim zy01游泳人數 As Integer = 0
            Dim zy01健身留容人數 As Integer = 0
            Dim zy01游泳留容人數 As Integer = 0
#End Region

            connT.SelectCommand = "select p01,isnull(p02,0) as p02,isnull(p03,0) as p03,isnull(p04,0) as p04,isnull(p06,0) as p06,isnull(p07,0) as p07,isnull(p08,0) as p08 from wp01"
            Dim dvT As Data.DataView = connT.SelectQuery()
            If dvT.Count > 0 Then
                For i As Integer = 0 To dvT.Count - 1
                    Select Case dvT.Item(i).Item("p01")
#Region "台北Case"
                        Case "tp01"
                            tp01游泳人數 = dvT.Item(i).Item("p02")
                            tp01健身人數 = dvT.Item(i).Item("p03")
                            tp01游泳留容人數 = dvT.Item(i).Item("p06")
                            tp01健身留容人數 = dvT.Item(i).Item("p07")


                        Case "jj01"
                            jj01游泳人數 = dvT.Item(i).Item("p02")
                            jj01健身人數 = dvT.Item(i).Item("p03")
                            jj01游泳留容人數 = dvT.Item(i).Item("p06")
                            jj01健身留容人數 = dvT.Item(i).Item("p07")

                        Case "tp04"
                            tp04游泳人數 = dvT.Item(i).Item("p02")
                            tp04健身人數 = dvT.Item(i).Item("p03")
                            tp04游泳留容人數 = dvT.Item(i).Item("p06")
                            tp04健身留容人數 = dvT.Item(i).Item("p07")

                        Case "tp06"
                            tp06游泳人數 = dvT.Item(i).Item("p02")
                            tp06健身人數 = dvT.Item(i).Item("p03")
                            tp06游泳留容人數 = dvT.Item(i).Item("p06")
                            tp06健身留容人數 = dvT.Item(i).Item("p07")

                        Case "tp03"
                            tp03游泳人數 = dvT.Item(i).Item("p02")
                            tp03健身人數 = dvT.Item(i).Item("p03")
                            tp03游泳留容人數 = dvT.Item(i).Item("p06")
                            tp03健身留容人數 = dvT.Item(i).Item("p07")

                        Case "wd02"
                            wd02游泳人數 = dvT.Item(i).Item("p02")
                            wd02健身人數 = dvT.Item(i).Item("p03")
                            wd02游泳留容人數 = dvT.Item(i).Item("p06")
                            wd02健身留容人數 = dvT.Item(i).Item("p07")

                        Case "slsc68"
                            slsc68游泳人數 = dvT.Item(i).Item("p02")
                            slsc68健身人數 = dvT.Item(i).Item("p03")
                            slsc68游泳留容人數 = dvT.Item(i).Item("p06")
                            slsc68健身留容人數 = dvT.Item(i).Item("p07")

                        Case "tp12"
                            tp12游泳人數 = dvT.Item(i).Item("p02")
                            tp12健身人數 = dvT.Item(i).Item("p03")
                            tp12游泳留容人數 = dvT.Item(i).Item("p06")
                            tp12健身留容人數 = dvT.Item(i).Item("p07")

                        Case "tp02"
                            tp02游泳人數 = dvT.Item(i).Item("p02")
                            tp02健身人數 = dvT.Item(i).Item("p03")
                            tp02游泳留容人數 = dvT.Item(i).Item("p06")
                            tp02健身留容人數 = dvT.Item(i).Item("p07")

                        Case "wp05"
                            wp05游泳人數 = dvT.Item(i).Item("p02")
                            wp05健身人數 = dvT.Item(i).Item("p03")
                            wp05游泳留容人數 = dvT.Item(i).Item("p06")
                            wp05健身留容人數 = dvT.Item(i).Item("p07")



#End Region
#Region "新北Case"
                        Case "tp07"
                            tp07游泳人數 = dvT.Item(i).Item("p02")
                            tp07健身人數 = dvT.Item(i).Item("p03")
                            tp07游泳留容人數 = dvT.Item(i).Item("p06")
                            tp07健身留容人數 = dvT.Item(i).Item("p07")

                        Case "cg01"
                            cg01游泳人數 = dvT.Item(i).Item("p02")
                            cg01健身人數 = dvT.Item(i).Item("p03")
                            cg01游泳留容人數 = dvT.Item(i).Item("p06")
                            cg01健身留容人數 = dvT.Item(i).Item("p07")

                        Case "sl01"
                            sl01游泳人數 = dvT.Item(i).Item("p02")
                            sl01健身人數 = dvT.Item(i).Item("p03")
                            sl01游泳留容人數 = dvT.Item(i).Item("p06")
                            sl01健身留容人數 = dvT.Item(i).Item("p07")

                        Case "wd05"
                            wd05游泳人數 = dvT.Item(i).Item("p02")
                            wd05健身人數 = dvT.Item(i).Item("p03")
                            wd05游泳留容人數 = dvT.Item(i).Item("p06")
                            wd05健身留容人數 = dvT.Item(i).Item("p07")

                        Case "ds01"
                            ds01游泳人數 = dvT.Item(i).Item("p02")
                            ds01健身人數 = dvT.Item(i).Item("p03")
                            ds01健身_2人數 = dvT.Item(i).Item("p04")
                            ds01游泳留容人數 = dvT.Item(i).Item("p06")
                            ds01健身留容人數 = dvT.Item(i).Item("p07")
                            ds01健身留容_2人數 = dvT.Item(i).Item("p08")

                        Case "tp08"
                            tp08游泳人數 = dvT.Item(i).Item("p02")
                            tp08健身人數 = dvT.Item(i).Item("p03")
                            tp08冰宮人數 = dvT.Item(i).Item("p04")
                            tp08游泳留容人數 = dvT.Item(i).Item("p06")
                            tp08健身留容人數 = dvT.Item(i).Item("p07")
                            tp08冰宮留容人數 = dvT.Item(i).Item("p08")

                        Case "fe01"
                            fe01游泳人數 = dvT.Item(i).Item("p02")
                            fe01健身人數 = dvT.Item(i).Item("p03")
                            fe01游泳留容人數 = dvT.Item(i).Item("p06")
                            fe01健身留容人數 = dvT.Item(i).Item("p07")

                        Case "tp10"
                            tp10游泳人數 = dvT.Item(i).Item("p02")
                            tp10健身人數 = dvT.Item(i).Item("p03")
                            tp10游泳留容人數 = dvT.Item(i).Item("p06")
                            tp10健身留容人數 = dvT.Item(i).Item("p07")

                        Case "tp17"
                            tp17游泳人數 = dvT.Item(i).Item("p02")
                            tp17健身人數 = dvT.Item(i).Item("p03")
                            tp17游泳留容人數 = dvT.Item(i).Item("p06")
                            tp17健身留容人數 = dvT.Item(i).Item("p07")

                        Case "tp09"
                            tp09游泳人數 = dvT.Item(i).Item("p02")
                            tp09健身人數 = dvT.Item(i).Item("p03")
                            tp09游泳留容人數 = dvT.Item(i).Item("p06")
                            tp09健身留容人數 = dvT.Item(i).Item("p07")

                        Case "ts01"
                            ts01游泳人數 = dvT.Item(i).Item("p02")
                            ts01健身人數 = dvT.Item(i).Item("p03")
                            ts01游泳留容人數 = dvT.Item(i).Item("p06")
                            ts01健身留容人數 = dvT.Item(i).Item("p07")

                        Case "xwt88"
                            xwt88游泳人數 = dvT.Item(i).Item("p02")
                            xwt88健身人數 = dvT.Item(i).Item("p03")
                            xwt88游泳留容人數 = dvT.Item(i).Item("p06")
                            xwt88健身留容人數 = dvT.Item(i).Item("p07")

                        Case "nt01"
                            nt01游泳人數 = dvT.Item(i).Item("p02")
                            nt01健身人數 = dvT.Item(i).Item("p03")
                            nt01游泳留容人數 = dvT.Item(i).Item("p06")
                            nt01健身留容人數 = dvT.Item(i).Item("p07")



#End Region
#Region "北部Case"
                        Case "ds02"
                            ds02游泳人數 = dvT.Item(i).Item("p02")
                            ds02健身人數 = dvT.Item(i).Item("p03")
                            ds02游泳留容人數 = dvT.Item(i).Item("p06")
                            ds02健身留容人數 = dvT.Item(i).Item("p07")

                        Case "tp13"
                            tp13游泳人數 = dvT.Item(i).Item("p02")
                            tp13健身人數 = dvT.Item(i).Item("p03")
                            tp13游泳留容人數 = dvT.Item(i).Item("p06")
                            tp13健身留容人數 = dvT.Item(i).Item("p07")

                        Case "tp15"
                            tp15游泳人數 = dvT.Item(i).Item("p02")
                            tp15健身人數 = dvT.Item(i).Item("p03")
                            tp15游泳留容人數 = dvT.Item(i).Item("p06")
                            tp15健身留容人數 = dvT.Item(i).Item("p07")

                        Case "tp14"
                            tp14游泳人數 = dvT.Item(i).Item("p02")
                            tp14健身人數 = dvT.Item(i).Item("p03")
                            tp14游泳留容人數 = dvT.Item(i).Item("p06")
                            tp14健身留容人數 = dvT.Item(i).Item("p07")

                        Case "ws01"
                            ws01游泳人數 = dvT.Item(i).Item("p02")
                            ws01健身人數 = dvT.Item(i).Item("p03")
                            ws01游泳留容人數 = dvT.Item(i).Item("p06")
                            ws01健身留容人數 = dvT.Item(i).Item("p07")

                        Case "fe02"
                            fe02游泳人數 = dvT.Item(i).Item("p02")
                            fe02健身人數 = dvT.Item(i).Item("p03")
                            fe02游泳留容人數 = dvT.Item(i).Item("p06")
                            fe02健身留容人數 = dvT.Item(i).Item("p07")

                        Case "tp16"
                            tp16游泳人數 = dvT.Item(i).Item("p02")
                            tp16健身人數 = dvT.Item(i).Item("p03")
                            tp16游泳留容人數 = dvT.Item(i).Item("p06")
                            tp16健身留容人數 = dvT.Item(i).Item("p07")

                        Case "tp18"
                            tp18游泳人數 = dvT.Item(i).Item("p02")
                            tp18健身人數 = dvT.Item(i).Item("p03")
                            tp18游泳留容人數 = dvT.Item(i).Item("p06")
                            tp18健身留容人數 = dvT.Item(i).Item("p07")

                        Case "um01"
                            um01游泳人數 = dvT.Item(i).Item("p02")
                            um01健身人數 = dvT.Item(i).Item("p03")
                            um01游泳留容人數 = dvT.Item(i).Item("p06")
                            um01健身留容人數 = dvT.Item(i).Item("p07")


#End Region
#Region "中部Case"
                        Case "kc01"
                            kc01游泳人數 = dvT.Item(i).Item("p02")
                            kc01游泳留容人數 = dvT.Item(i).Item("p06")

                        Case "jb01"
                            jb01游泳人數 = dvT.Item(i).Item("p02")
                            jb01健身人數 = dvT.Item(i).Item("p03")
                            jb01游泳留容人數 = dvT.Item(i).Item("p06")
                            jb01健身留容人數 = dvT.Item(i).Item("p07")

                        Case "tp11"
                            tp11游泳人數 = dvT.Item(i).Item("p02")
                            tp11健身人數 = dvT.Item(i).Item("p03")
                            tp11游泳留容人數 = dvT.Item(i).Item("p06")
                            tp11健身留容人數 = dvT.Item(i).Item("p07")

                        Case "wd08"
                            wd08游泳人數 = dvT.Item(i).Item("p02")
                            wd08健身人數 = dvT.Item(i).Item("p03")
                            wd08游泳留容人數 = dvT.Item(i).Item("p06")
                            wd08健身留容人數 = dvT.Item(i).Item("p07")

                        Case "nd01"
                            nd01游泳人數 = dvT.Item(i).Item("p02")
                            nd01健身人數 = dvT.Item(i).Item("p03")
                            nd01游泳留容人數 = dvT.Item(i).Item("p06")
                            nd01健身留容人數 = dvT.Item(i).Item("p07")

                        Case "tz01"
                            tz01游泳人數 = dvT.Item(i).Item("p02")
                            tz01健身人數 = dvT.Item(i).Item("p03")
                            tz01游泳留容人數 = dvT.Item(i).Item("p06")
                            tz01健身留容人數 = dvT.Item(i).Item("p07")

                        Case "wd15"
                            wd15游泳人數 = dvT.Item(i).Item("p02")
                            wd15健身人數 = dvT.Item(i).Item("p03")
                            wd15游泳留容人數 = dvT.Item(i).Item("p06")
                            wd15健身留容人數 = dvT.Item(i).Item("p07")

                        Case "wd14"
                            wd14游泳人數 = dvT.Item(i).Item("p02")
                            wd14健身人數 = dvT.Item(i).Item("p03")
                            wd14游泳留容人數 = dvT.Item(i).Item("p06")
                            wd14健身留容人數 = dvT.Item(i).Item("p07")


#End Region
#Region "南部Case"
                        Case "wd04"
                            wd04游泳人數 = dvT.Item(i).Item("p02")
                            wd04健身人數 = dvT.Item(i).Item("p03")
                            wd04游泳留容人數 = dvT.Item(i).Item("p06")
                            wd04健身留容人數 = dvT.Item(i).Item("p07")

                        Case "pt01"
                            pt01游泳人數 = dvT.Item(i).Item("p02")
                            pt01健身人數 = dvT.Item(i).Item("p03")
                            pt01游泳留容人數 = dvT.Item(i).Item("p06")
                            pt01健身留容人數 = dvT.Item(i).Item("p07")

                        Case "wd16"
                            wd16游泳人數 = dvT.Item(i).Item("p02")
                            wd16健身人數 = dvT.Item(i).Item("p03")
                            wd16游泳留容人數 = dvT.Item(i).Item("p06")
                            wd16健身留容人數 = dvT.Item(i).Item("p07")

                        Case "zy01"
                            zy01游泳人數 = dvT.Item(i).Item("p02")
                            zy01健身人數 = dvT.Item(i).Item("p03")
                            zy01游泳留容人數 = dvT.Item(i).Item("p06")
                            zy01健身留容人數 = dvT.Item(i).Item("p07")

                    End Select
                Next
            End If
#End Region


#Region "台北人數"
            ViewBag.台北店家0 = "中山運動中心"
            ViewBag.台北店家0_健身 = tp01健身人數
            ViewBag.台北店家0_游泳 = tp01游泳人數
            ViewBag.台北店家0_健身max = tp01健身留容人數
            ViewBag.台北店家0_游泳max = tp01游泳留容人數

            ViewBag.台北店家1 = "中正運動中心"
            ViewBag.台北店家1_健身 = jj01健身人數
            ViewBag.台北店家1_游泳 = jj01游泳人數
            ViewBag.台北店家1_健身max = jj01健身留容人數
            ViewBag.台北店家1_游泳max = jj01游泳留容人數

            ViewBag.台北店家2 = "信義運動中心"
            ViewBag.台北店家2_健身 = tp04健身人數
            ViewBag.台北店家2_游泳 = tp04游泳人數
            ViewBag.台北店家2_健身max = tp04健身留容人數
            ViewBag.台北店家2_游泳max = tp04游泳留容人數

            ViewBag.台北店家3 = "文山運動中心"
            ViewBag.台北店家3_健身 = tp06健身人數
            ViewBag.台北店家3_游泳 = tp06游泳人數
            ViewBag.台北店家3_健身max = tp06健身留容人數
            ViewBag.台北店家3_游泳max = tp06游泳留容人數

            ViewBag.台北店家4 = "大安運動中心"
            ViewBag.台北店家4_健身 = tp03健身人數
            ViewBag.台北店家4_游泳 = tp03游泳人數
            ViewBag.台北店家4_健身max = tp03健身留容人數
            ViewBag.台北店家4_游泳max = tp03游泳留容人數

            ViewBag.台北店家5 = "大同運動中心"
            ViewBag.台北店家5_健身 = wd02健身人數
            ViewBag.台北店家5_游泳 = wd02游泳人數
            ViewBag.台北店家5_健身max = wd02健身留容人數
            ViewBag.台北店家5_游泳max = wd02游泳留容人數

            ViewBag.台北店家6 = "士林運動中心"
            ViewBag.台北店家6_健身 = slsc68健身人數
            ViewBag.台北店家6_游泳 = slsc68游泳人數
            ViewBag.台北店家6_健身max = slsc68健身留容人數
            ViewBag.台北店家6_游泳max = slsc68游泳留容人數

            ViewBag.台北店家7 = "內湖運動中心"
            ViewBag.台北店家7_健身 = tp12健身人數
            ViewBag.台北店家7_游泳 = tp12游泳人數
            ViewBag.台北店家7_健身max = tp12健身留容人數
            ViewBag.台北店家7_游泳max = tp12游泳留容人數

            ViewBag.台北店家8 = "南港運動中心"
            ViewBag.台北店家8_健身 = tp02健身人數
            ViewBag.台北店家8_游泳 = tp02游泳人數
            ViewBag.台北店家8_健身max = tp02健身留容人數
            ViewBag.台北店家8_游泳max = tp02游泳留容人數

            ViewBag.台北店家9 = "青年公園運動園區"
            ViewBag.台北店家9_健身 = wp05健身人數
            ViewBag.台北店家9_游泳 = wp05游泳人數
            ViewBag.台北店家9_健身max = wp05健身留容人數
            ViewBag.台北店家9_游泳max = wp05游泳留容人數
#End Region
#Region "新北人數"
            ViewBag.新北店家0 = "蘆洲運動中心"
            ViewBag.新北店家0_健身 = tp07健身人數
            ViewBag.新北店家0_游泳 = tp07游泳人數
            ViewBag.新北店家0_健身max = tp07健身留容人數
            ViewBag.新北店家0_游泳max = tp07游泳留容人數

            ViewBag.新北店家1 = "板橋運動中心"
            ViewBag.新北店家1_健身 = cg01健身人數
            ViewBag.新北店家1_游泳 = cg01游泳人數
            ViewBag.新北店家1_健身max = cg01健身留容人數
            ViewBag.新北店家1_游泳max = cg01游泳留容人數

            ViewBag.新北店家2 = "樹林體育園區"
            ViewBag.新北店家2_健身 = sl01健身人數
            ViewBag.新北店家2_游泳 = sl01游泳人數
            ViewBag.新北店家2_健身max = sl01健身留容人數
            ViewBag.新北店家2_游泳max = sl01游泳留容人數

            ViewBag.新北店家3 = "鶯歌運動中心"
            ViewBag.新北店家3_健身 = ds01健身_2人數
            ViewBag.新北店家3_健身max = ds01健身留容_2人數

            ViewBag.新北店家4 = "土城運動中心"
            ViewBag.新北店家4_健身 = tp08健身人數
            ViewBag.新北店家4_游泳 = tp08游泳人數
            ViewBag.新北店家4_冰宮 = tp08冰宮人數
            ViewBag.新北店家4_健身max = tp08健身留容人數
            ViewBag.新北店家4_游泳max = tp08游泳留容人數
            ViewBag.新北店家4_冰宮max = tp08冰宮留容人數

            ViewBag.新北店家5 = "三重運動中心"
            ViewBag.新北店家5_健身 = fe01健身人數
            ViewBag.新北店家5_游泳 = fe01游泳人數
            ViewBag.新北店家5_健身max = fe01健身留容人數
            ViewBag.新北店家5_游泳max = fe01游泳留容人數

            ViewBag.新北店家6 = "永和運動中心"
            ViewBag.新北店家6_健身 = tp10健身人數
            ViewBag.新北店家6_游泳 = tp10游泳人數
            ViewBag.新北店家6_健身max = tp10健身留容人數
            ViewBag.新北店家6_游泳max = tp10游泳留容人數

            ViewBag.新北店家7 = "林口運動中心"
            ViewBag.新北店家7_健身 = tp17健身人數
            ViewBag.新北店家7_游泳 = tp17游泳人數
            ViewBag.新北店家7_健身max = tp17健身留容人數
            ViewBag.新北店家7_游泳max = tp17游泳留容人數

            ViewBag.新北店家8 = "汐止運動中心"
            ViewBag.新北店家8_健身 = tp09健身人數
            ViewBag.新北店家8_游泳 = tp09游泳人數
            ViewBag.新北店家8_健身max = tp09健身留容人數
            ViewBag.新北店家8_游泳max = tp09游泳留容人數

            ViewBag.新北店家9 = "淡水運動中心"
            ViewBag.新北店家9_健身 = ts01健身人數
            ViewBag.新北店家9_游泳 = ts01游泳人數
            ViewBag.新北店家9_健身max = ts01健身留容人數
            ViewBag.新北店家9_游泳max = ts01游泳留容人數

            ViewBag.新北店家10 = "泰山運動中心"
            ViewBag.新北店家10_健身 = xwt88健身人數
            ViewBag.新北店家10_游泳 = xwt88游泳人數
            ViewBag.新北店家10_健身max = xwt88健身留容人數
            ViewBag.新北店家10_游泳max = xwt88游泳留容人數

            ViewBag.新北店家11 = "三鶯運動中心"
            ViewBag.新北店家11_健身 = ds01健身人數
            ViewBag.新北店家11_游泳 = ds01游泳人數
            ViewBag.新北店家11_健身max = ds01健身留容人數
            ViewBag.新北店家11_游泳max = ds01游泳留容人數

            ViewBag.新北店家12 = "樹林運動中心"
            ViewBag.新北店家12_健身 = nt01健身人數
            ViewBag.新北店家12_游泳 = nt01游泳人數
            ViewBag.新北店家12_健身max = nt01健身留容人數
            ViewBag.新北店家12_游泳max = nt01游泳留容人數

            ViewBag.新北店家13 = "泰山體育園區"
            ViewBag.新北店家13_健身 = wd05健身人數
            ViewBag.新北店家13_游泳 = wd05游泳人數
            ViewBag.新北店家13_健身max = wd05健身留容人數
            ViewBag.新北店家13_游泳max = wd05游泳留容人數

#End Region
#Region "北部人數"
            ViewBag.北部店家0 = "宜蘭運動中心"
            ViewBag.北部店家0_健身 = ds02健身人數
            ViewBag.北部店家0_游泳 = ds02游泳人數
            ViewBag.北部店家0_健身max = ds02健身留容人數
            ViewBag.北部店家0_游泳max = ds02游泳留容人數

            ViewBag.北部店家1 = "桃園運動中心"
            ViewBag.北部店家1_健身 = tp13健身人數
            ViewBag.北部店家1_游泳 = tp13游泳人數
            ViewBag.北部店家1_健身max = tp13健身留容人數
            ViewBag.北部店家1_游泳max = tp13游泳留容人數

            ViewBag.北部店家2 = "中壢運動中心"
            ViewBag.北部店家2_健身 = tp15健身人數
            ViewBag.北部店家2_游泳 = tp15游泳人數
            ViewBag.北部店家2_健身max = tp15健身留容人數
            ViewBag.北部店家2_游泳max = tp15游泳留容人數

            ViewBag.北部店家4 = "南區青少年活動中心"
            ViewBag.北部店家4_健身 = tp14健身人數
            ViewBag.北部店家4_游泳 = tp14游泳人數
            ViewBag.北部店家4_健身max = tp14健身留容人數
            ViewBag.北部店家4_游泳max = tp14游泳留容人數

            ViewBag.北部店家3 = "大溪運動中心"
            ViewBag.北部店家3_健身 = ws01健身人數
            ViewBag.北部店家3_游泳 = ws01游泳人數
            ViewBag.北部店家3_健身max = ws01健身留容人數
            ViewBag.北部店家3_游泳max = ws01游泳留容人數

            ViewBag.北部店家5 = "竹北運動中心"
            ViewBag.北部店家5_健身 = fe02健身人數
            ViewBag.北部店家5_游泳 = fe02游泳人數
            ViewBag.北部店家5_健身max = fe02健身留容人數
            ViewBag.北部店家5_游泳max = fe02游泳留容人數

            ViewBag.北部店家6 = "竹光運動中心"
            ViewBag.北部店家6_健身 = tp16健身人數
            ViewBag.北部店家6_游泳 = tp16游泳人數
            ViewBag.北部店家6_健身max = tp16健身留容人數
            ViewBag.北部店家6_游泳max = tp16游泳留容人數

            ViewBag.北部店家7 = "八德運動中心"
            ViewBag.北部店家7_健身 = tp18健身人數
            ViewBag.北部店家7_游泳 = tp18游泳人數
            ViewBag.北部店家7_健身max = tp18健身留容人數
            ViewBag.北部店家7_游泳max = tp18游泳留容人數

            ViewBag.北部店家8 = "聯園活動中心"
            ViewBag.北部店家8_健身 = um01健身人數
            ViewBag.北部店家8_游泳 = um01游泳人數
            ViewBag.北部店家8_健身max = um01健身留容人數
            ViewBag.北部店家8_游泳max = um01游泳留容人數

#End Region
#Region "中部人數"
            ViewBag.中部店家0 = "港區運動公園"
            ViewBag.中部店家0_健身 = kc01健身人數
            ViewBag.中部店家0_健身max = kc01健身留容人數

            ViewBag.中部店家1 = "彰北運動中心"
            ViewBag.中部店家1_健身 = jb01健身人數
            ViewBag.中部店家1_游泳 = jb01游泳人數
            ViewBag.中部店家1_健身max = jb01健身留容人數
            ViewBag.中部店家1_游泳max = jb01游泳留容人數

            ViewBag.中部店家2 = "朝馬運動中心"
            ViewBag.中部店家2_健身 = tp11健身人數
            ViewBag.中部店家2_游泳 = tp11游泳人數
            ViewBag.中部店家2_健身max = tp11健身留容人數
            ViewBag.中部店家2_游泳max = tp11游泳留容人數

            ViewBag.中部店家3 = "長春運動中心"
            ViewBag.中部店家3_健身 = wd08健身人數
            ViewBag.中部店家3_游泳 = wd08游泳人數
            ViewBag.中部店家3_健身max = wd08健身留容人數
            ViewBag.中部店家3_游泳max = wd08游泳留容人數

            ViewBag.中部店家4 = "南屯運動中心"
            ViewBag.中部店家4_健身 = nd01健身人數
            ViewBag.中部店家4_游泳 = nd01游泳人數
            ViewBag.中部店家4_健身max = nd01健身留容人數
            ViewBag.中部店家4_游泳max = nd01游泳留容人數

            ViewBag.中部店家5 = "潭子運動中心"
            ViewBag.中部店家5_健身 = tz01健身人數
            ViewBag.中部店家5_游泳 = tz01游泳人數
            ViewBag.中部店家5_健身max = tz01健身留容人數
            ViewBag.中部店家5_游泳max = tz01游泳留容人數

            ViewBag.中部店家6 = "沙鹿運動中心"
            ViewBag.中部店家6_健身 = wd15健身人數
            ViewBag.中部店家6_游泳 = wd15游泳人數
            ViewBag.中部店家6_健身max = wd15健身留容人數
            ViewBag.中部店家6_游泳max = wd15游泳留容人數

            ViewBag.中部店家7 = "大里運動中心"
            ViewBag.中部店家7_健身 = wd14健身人數
            ViewBag.中部店家7_游泳 = wd14游泳人數
            ViewBag.中部店家7_健身max = wd14健身留容人數
            ViewBag.中部店家7_游泳max = wd14游泳留容人數

#End Region
#Region "南部人數"
            ViewBag.南部店家0 = "鳳山運動園區"
            ViewBag.南部店家0_健身 = wd04健身人數
            ViewBag.南部店家0_游泳 = wd04游泳人數
            ViewBag.南部店家0_健身max = wd04健身留容人數
            ViewBag.南部店家0_游泳max = wd04游泳留容人數

            ViewBag.南部店家1 = "屏東運動中心"
            ViewBag.南部店家1_健身 = pt01健身人數
            ViewBag.南部店家1_游泳 = pt01游泳人數
            ViewBag.南部店家1_健身max = pt01健身留容人數
            ViewBag.南部店家1_游泳max = pt01游泳留容人數

            ViewBag.南部店家2 = "苓雅運動中心"
            ViewBag.南部店家2_健身 = wd16健身人數
            ViewBag.南部店家2_游泳 = wd16游泳人數
            ViewBag.南部店家2_健身max = wd16健身留容人數
            ViewBag.南部店家2_游泳max = wd16游泳留容人數

            ViewBag.南部店家3 = "左營運動中心"
            ViewBag.南部店家3_健身 = zy01健身人數
            ViewBag.南部店家3_游泳 = zy01游泳人數
            ViewBag.南部店家3_健身max = zy01健身留容人數
            ViewBag.南部店家3_游泳max = zy01游泳留容人數

#End Region

            Return View()
        End Function

    End Class
End Namespace