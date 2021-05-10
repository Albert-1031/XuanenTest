@Code
    Layout = Nothing
End Code

@RenderPage("../Shared/_Header.vbhtml")


<div id="banner">
    <a href="../Product/Product02"><img src="../images/_index/index_lyaout_V2_Final_Cut-11.png" alt="運動場館的最佳幫手"></a>
</div>

<form id="subform_MainBlock" action="@(Html.Raw(ViewBag.GoTo首頁))" style="width: 100%;height: 100%;">
    <script type="text/javascript">
        $(document).ready(function () {
            //var center = ['tp01', 'tp04', 'tp06', 'tp07', 'tp11', 'tp13', 'tp14', 'tp15', 'jj01', 'cg01', 'sl01', 'ds01', 'ds02', 'kc01', 'nd01', 'wd04', 'wd08'];
            var center = ['@Url.Content("~/Api/getdata?c=tp01")',
                '@Url.Content("~/Api/getdata?c=jj01")',
                '@Url.Content("~/Api/getdata?c=tp04")',
                '@Url.Content("~/Api/getdata?c=tp06")',
                '@Url.Content("~/Api/getdata?c=tp07")',
                '@Url.Content("~/Api/getdata?c=cg01")',
                '@Url.Content("~/Api/getdata?c=sl01")',
                '@Url.Content("~/Api/getdata?c=ds01")',
                '@Url.Content("~/Api/getdata?c=ds02")',
                '@Url.Content("~/Api/getdata?c=tp13")',
                '@Url.Content("~/Api/getdata?c=tp15")',
                '@Url.Content("~/Api/getdata?c=tp14")',
                '@Url.Content("~/Api/getdata?c=kc01")',
                '@Url.Content("~/Api/getdata?c=nd01")',
                '@Url.Content("~/Api/getdata?c=tp11")',
                '@Url.Content("~/Api/getdata?c=wd08")',
                '@Url.Content("~/Api/getdata?c=wd04")']

            for (var i = 0; i < center.length; i++) {
                var TargetUrl = center[i];
                $.ajax({
                    type: 'get',
                    url: TargetUrl,
                    success: function (loaddata) {
                    },
                });
            }
        });
    </script>
</form>

<div id="article" style="background-image:url(../images/bg/product_02-05.png)">
    <!--運動中心即時人流-->
    <div class="section01" style="width:100%">
        <img class="mobile_index_txt" src="../images/_index/index_lyaout_V3_Final_Cut-43.png" alt="運動中心人流顯示" style="width:30%; margin-top:10%"><br>
        <a href="#jump_taipei">
            <table class="people_ot">
                <tr>
                    <td style="width:220px; height:80px; line-height:18px">
                        <h4>台北市</h4>
                        <p>中山運動中心</p>
                    </td>
                </tr>
                <tr class="people_ot_tr1">
                    <td>
                        <table>
                            <tr>
                                <td style="padding-top:2px; width:60px; height:60px; padding-left:10px;">
                                    <img src="../images/_index/index_lyaout_V3_Final_Cut-30.png" alt="運動中心人流顯示_健身icon">
                                </td>
                                <td style="padding-top:12px; width:60px; padding-top:10px">
                                    <font class="people_ot_fo1">@(ViewBag.中山健身) /</font>
                                </td>
                                <td style="padding-top:15px">
                                    <font class="people_ot_fo2">@(ViewBag.中山健身max)人</font>
                                </td>
                            </tr>
                        </table>
                    </td>
                </tr>
                <tr class="people_ot_tr2">
                    <td>
                        <table>
                            <tr>
                                <td style="padding-top:2px; width:60px; height:60px; padding-left:10px;">
                                    <img src="../images/_index/index_lyaout_V3_Final_Cut-31.png" alt="運動中心人流顯示_游泳icon">
                                </td>
                                <td style="padding-top:12px; width:60px; padding-top:10px">
                                    <font class="people_ot_fo1">@(ViewBag.中山游泳) /</font>
                                </td>
                                <td style="padding-top:15px">
                                    <font class="people_ot_fo2">@(ViewBag.中山游泳max)人</font>
                                </td>
                            </tr>
                        </table>
                    </td>
                </tr>
            </table>
        </a>

        <a href="#jump_xinbei">
            <table class="people_ot">
                <tr>
                    <td colspan="3" style="width:220px; height:80px; line-height:18px">
                        <h4>新北市</h4>
                        <p>蘆洲運動中心</p>
                    </td>
                </tr>
                <tr class="people_ot_tr1">
                    <td>
                        <table>
                            <tr>
                                <td style="padding-top:2px; width:60px; height:60px; padding-left:10px;">
                                    <img src="../images/_index/index_lyaout_V3_Final_Cut-30.png" alt="運動中心人流顯示_健身icon">
                                </td>
                                <td style="padding-top:12px; width:60px; padding-top:10px">
                                    <font class="people_ot_fo1">@(ViewBag.蘆洲健身) /</font>
                                </td>
                                <td style="padding-top:15px">
                                    <font class="people_ot_fo2">@(ViewBag.蘆洲健身max)人</font>
                                </td>
                            </tr>
                        </table>
                    </td>
                </tr>
                <tr class="people_ot_tr2">
                    <td>
                        <table>
                            <tr>
                                <td style="padding-top:2px; width:60px; height:60px; padding-left:10px;">
                                    <img src="../images/_index/index_lyaout_V3_Final_Cut-31.png" alt="運動中心人流顯示_游泳icon">
                                </td>
                                <td style="padding-top:12px; width:60px; padding-top:10px">
                                    <font class="people_ot_fo1">@(ViewBag.蘆洲游泳) /</font>
                                </td>
                                <td style="padding-top:15px">
                                    <font class="people_ot_fo2">@(ViewBag.蘆洲游泳max)人</font>
                                </td>
                            </tr>
                        </table>
                    </td>
                </tr>
            </table>
        </a>

        <a href="#jump_taoyuan">
            <table class="people_ot">
                <tr>
                    <td colspan="3" style="width:220px; height:80px; line-height:18px">
                        <h4>桃園市</h4>
                        <p>桃園運動中心</p>
                    </td>
                </tr>
                <tr class="people_ot_tr1">
                    <td>
                        <table>
                            <tr>
                                <td style="padding-top:2px; width:60px; height:60px; padding-left:10px;">
                                    <img src="../images/_index/index_lyaout_V3_Final_Cut-30.png" alt="運動中心人流顯示_健身icon">
                                </td>
                                <td style="padding-top:12px; width:60px; padding-top:10px">
                                    <font class="people_ot_fo1">@(ViewBag.桃園健身) /</font>
                                </td>
                                <td style="padding-top:15px">
                                    <font class="people_ot_fo2">@(ViewBag.桃園健身max)人</font>
                                </td>
                            </tr>
                        </table>
                    </td>
                </tr>
                <tr class="people_ot_tr2">
                    <td>
                        <table>
                            <tr>
                                <td style="padding-top:2px; width:60px; height:60px; padding-left:10px;">
                                    <img src="../images/_index/index_lyaout_V3_Final_Cut-31.png" alt="運動中心人流顯示_游泳icon">
                                </td>
                                <td style="padding-top:12px; width:60px; padding-top:10px">
                                    <font class="people_ot_fo1">@(ViewBag.桃園游泳) /</font>
                                </td>
                                <td style="padding-top:15px">
                                    <font class="people_ot_fo2">@(ViewBag.桃園游泳max)人</font>
                                </td>
                            </tr>
                        </table>
                    </td>
                </tr>
            </table>
        </a>
    </div>

    <!--服務場館-->
    <div class="section01" style="margin-top:10%">
        <img class="mobile_index_txt" src="../images/_index/index_lyaout_V2_Final_Cut-26.png" alt="專注於運動產業我們服務那些場館呢" style="width:75%; margin-top:10%"><br>
        <img src="../images/_index/index_lyaout_V2_Final_Cut-12.png" alt="大型動場館國民運動中心" style="width:45%; margin-top:7%; margin-left:5%; float:left">
        <img src="../images/_index/index_lyaout_V2_Final_Cut-13.png" alt="大型動場館國民運動中心" style="width:45%; margin-top:15%"><br>
        <img src="../images/_index/index_lyaout_V2_Final_Cut-14.png" alt="個人工作室俱樂部" style="width:45%; margin-top:10%; float:right">
        <img src="../images/_index/index_lyaout_V2_Final_Cut-15.png" alt="個人工作室俱樂部" style="width:45%; margin-top:12%"><br>
        <img src="../images/_index/index_lyaout_V2_Final_Cut-16.png" alt="連鎖健身房" style="width:45%; margin-top:11%">
        <img src="../images/_index/index_lyaout_V2_Final_Cut-17.png" alt="連鎖健身房" style="width:45%; margin-top:-25%; float:right"><br>
    </div>
</div>

<div id="article" style="background-image:url(../images/bg/product_01-04.png); background-position-y:0%">
    <!--了解更多-->
    <div class="section02 , mobile_index_img" style="padding-bottom:15%">
        <a href="../Product/Product01"><img src="../images/_index/index_lyaout_V2_Final_Cut-18.png" alt="了解更多" style="width:25%; margin-top:10%;"></a><br>
        <img src="../images/_index/index_lyaout_V2_Final_Cut-19.png" alt="立即與我們聯絡" style="width:20%; margin-top:5%">
        <img src="../images/_index/index_lyaout_V2_Final_Cut-21.png" alt="讓我們與您聯絡" style="width:20%; margin-left:20%"><br>
        <img src="../images/_index/index_lyaout_V2_Final_Cut-20.png" alt="立即與我們聯絡" style="width:24%; margin-top:5%; margin-bottom:5%; margin-left:-4%">
        <a href="../ContactUs/ContactUs01"><img src="../images/_index/index_lyaout_V2_Final_Cut-22.png" alt="讓我們與您聯絡" style="width:18%; margin-bottom:5%; margin-left:19%"></a><br>
    </div>
</div>

<div id="article2">
    <div id="article" style="background-image:url(../images/bg/product_02-05.png); background-position-y:58%">
        <!--各場即時人流-->
        <div class="section01">
            <img class="mobile_txt" src="../images/_index/index_lyaout_V3_Final_Cut-34.png" alt="各場館即時人流" style="width:33%; margin-top:5%"><br>
            <div class="site_people">
                <h3 id="jump_taipei">台北市</h3>
                <img src="../images/_index/index_lyaout_V3_Final_Cut-37.png" alt="各場館即時人流箭頭" style="display: inline-block; position: relative; z-index: 2; width: 15px; top:-150px">

                <table class="site_people_tb" border="0" style="margin-top:110px">
                    <tr>
                        <td colspan="3" style="width:160px; height:45px">
                            <h4>中山運動中心</h4>
                        </td>
                    </tr>
                    <tr>
                        <td style="height:100px; vertical-align:middle">
                            <img src="../images/_index/index_lyaout_V3_Final_Cut-40.png" alt="各場館即時人流_健身icon" style="width:30px"><br>
                            <img src="../images/_index/index_lyaout_V3_Final_Cut-41.png" alt="各場館即時人流_游泳icon" style="width:30px">
                        </td>
                        <td style="height:100px; vertical-align:middle; line-height:36px; font-size:28px">
                            <font class="site_people_fitness">@(ViewBag.中山健身)</font><br>
                            <font class="site_people_swim">@(ViewBag.中山游泳)</font>
                        </td>
                        <td style="height:100px; vertical-align:middle; line-height:36px; padding-top:10px">
                            <font class="site_people_fitness">/ @(ViewBag.中山健身max)人</font><br>
                            <font class="site_people_swim">/ @(ViewBag.中山游泳max)人</font>
                        </td>
                    </tr>
                </table>

                <table class="site_people_tb" border="0" style="margin-top:110px">
                    <tr>
                        <td colspan="3" style="width:160px; height:45px">
                            <h4>中正運動中心</h4>
                        </td>
                    </tr>
                    <tr>
                        <td style="height:100px; vertical-align:middle">
                            <img src="../images/_index/index_lyaout_V3_Final_Cut-40.png" alt="各場館即時人流_健身icon" style="width:30px"><br>
                            <img src="../images/_index/index_lyaout_V3_Final_Cut-41.png" alt="各場館即時人流_游泳icon" style="width:30px"><br>
                            <img src="../images/_index/index_lyaout_V3_Final_Cut-42.png" alt="各場館即時人流_冰宮icon" style="width:30px">
                        </td>
                        <td style="height:100px; vertical-align:middle; line-height:36px; font-size:28px">
                            <font class="site_people_fitness">@(ViewBag.中正健身)</font><br>
                            <font class="site_people_swim">@(ViewBag.中正游泳)</font><br>
                            <font class="site_people_ice">@(ViewBag.中正冰宮)</font>
                        </td>
                        <td style="height:100px; vertical-align:middle; line-height:36px; padding-top:10px">
                            <font class="site_people_fitness">/ @(ViewBag.中正健身max)人</font><br>
                            <font class="site_people_swim">/ @(ViewBag.中正游泳max)人</font><br>
                            <font class="site_people_ice">/ @(ViewBag.中正冰宮max)人</font>
                        </td>
                    </tr>
                </table>

                <table class="site_people_tb" border="0" style="margin-top:110px">
                    <tr>
                        <td colspan="3" style="width:160px; height:45px">
                            <h4>信義運動中心</h4>
                        </td>
                    </tr>
                    <tr>
                        <td style="height:100px; vertical-align:middle">
                            <img src="../images/_index/index_lyaout_V3_Final_Cut-40.png" style="width:30px"><br>
                            <img src="../images/_index/index_lyaout_V3_Final_Cut-41.png" style="width:30px">
                        </td>
                        <td style="height:100px; vertical-align:middle; line-height:36px; font-size:28px">
                            <font class="site_people_fitness">@(ViewBag.信義健身)</font><br>
                            <font class="site_people_swim">@(ViewBag.信義游泳)</font>
                        </td>
                        <td style="height:100px; vertical-align:middle; line-height:36px; padding-top:10px">
                            <font class="site_people_fitness">/ @(ViewBag.信義健身max)人</font><br>
                            <font class="site_people_swim">/ @(ViewBag.信義游泳max)人</font>
                        </td>
                    </tr>
                </table>

                <table class="site_people_tb" border="0" style="margin-top:110px">
                    <tr>
                        <td colspan="3" style="width:160px; height:45px">
                            <h4>文山運動中心</h4>
                        </td>
                    </tr>
                    <tr>
                        <td style="height:100px; vertical-align:middle">
                            <img src="../images/_index/index_lyaout_V3_Final_Cut-40.png" style="width:30px">
                        </td>
                        <td style="height:100px; vertical-align:middle; line-height:36px; font-size:28px">
                            <font class="site_people_fitness">@(ViewBag.文山健身)</font>
                        </td>
                        <td style="height:100px; vertical-align:middle; line-height:36px; padding-top:10px">
                            <font class="site_people_fitness">/ @(ViewBag.文山健身max)人</font>
                        </td>
                    </tr>
                </table>

                <img src="../images/_index/index_lyaout_V3_Final_Cut-37_2.png" style="display: inline-block; position: relative; z-index: 2; width: 15px; top:-150px">

            </div>
            <div class="site_people">
                <h3 id="jump_xinbei">新北市</h3>
                <img src="../images/_index/index_lyaout_V3_Final_Cut-37.png" style="display: inline-block; position: relative; z-index: 2; width: 15px; top:-150px">

                <table class="site_people_tb" border="0" style="margin-top:110px">
                    <tr>
                        <td colspan="3" style="width:160px; height:45px">
                            <h4>蘆洲運動中心</h4>
                        </td>
                    </tr>
                    <tr>
                        <td style="height:100px; vertical-align:middle">
                            <img src="../images/_index/index_lyaout_V3_Final_Cut-40.png" style="width:30px"><br>
                            <img src="../images/_index/index_lyaout_V3_Final_Cut-41.png" style="width:30px">
                        </td>
                        <td style="height:100px; vertical-align:middle; line-height:36px; font-size:28px">
                            <font class="site_people_fitness">@(ViewBag.蘆洲健身)</font><br>
                            <font class="site_people_swim">@(ViewBag.蘆洲游泳)</font>
                        </td>
                        <td style="height:100px; vertical-align:middle; line-height:36px; padding-top:10px">
                            <font class="site_people_fitness">/ @(ViewBag.蘆洲健身max)人</font><br>
                            <font class="site_people_swim">/ @(ViewBag.蘆洲游泳max)人</font>
                        </td>
                    </tr>
                </table>

                <table class="site_people_tb" border="0" style="margin-top:110px">
                    <tr>
                        <td colspan="3" style="width:160px; height:45px">
                            <h4>板橋運動中心</h4>
                        </td>
                    </tr>
                    <tr>
                        <td style="height:100px; vertical-align:middle">
                            <img src="../images/_index/index_lyaout_V3_Final_Cut-40.png" style="width:30px"><br>
                            <img src="../images/_index/index_lyaout_V3_Final_Cut-41.png" style="width:30px"><br>
                            <img src="../images/_index/index_lyaout_V3_Final_Cut-42.png" style="width:30px">
                        </td>
                        <td style="height:100px; vertical-align:middle; line-height:36px; font-size:28px">
                            <font class="site_people_fitness">@(ViewBag.板橋健身)</font><br>
                            <font class="site_people_swim">@(ViewBag.板橋游泳)</font><br>
                            <font class="site_people_ice">@(ViewBag.板橋冰宮)</font>
                        </td>
                        <td style="height:100px; vertical-align:middle; line-height:36px; padding-top:10px">
                            <font class="site_people_fitness">/ @(ViewBag.板橋健身max)人</font><br>
                            <font class="site_people_swim">/ @(ViewBag.板橋游泳max)人</font><br>
                            <font class="site_people_ice">/ @(ViewBag.板橋冰宮max)人</font>
                        </td>
                    </tr>
                </table>

                <table class="site_people_tb" border="0" style="margin-top:110px">
                    <tr>
                        <td colspan="3" style="width:160px; height:45px">
                            <h4>板樹運動中心</h4>
                        </td>
                    </tr>
                    <tr>
                        <td style="height:100px; vertical-align:middle">
                            <img src="../images/_index/index_lyaout_V3_Final_Cut-40.png" style="width:30px"><br>
                            <img src="../images/_index/index_lyaout_V3_Final_Cut-41.png" style="width:30px">
                        </td>
                        <td style="height:100px; vertical-align:middle; line-height:36px; font-size:28px">
                            <font class="site_people_fitness">@(ViewBag.板樹健身)</font><br>
                            <font class="site_people_swim">@(ViewBag.板樹游泳)</font>
                        </td>
                        <td style="height:100px; vertical-align:middle; line-height:36px; padding-top:10px">
                            <font class="site_people_fitness">/ @(ViewBag.板樹健身max)人</font><br>
                            <font class="site_people_swim">/ @(ViewBag.板樹游泳max)人</font>
                        </td>
                    </tr>
                </table>

                <table class="site_people_tb" border="0" style="margin-top:110px">
                    <tr>
                        <td colspan="3" style="width:160px; height:45px">
                            <h4>鶯歌運動中心</h4>
                        </td>
                    </tr>
                    <tr>
                        <td style="height:100px; vertical-align:middle">
                            <img src="../images/_index/index_lyaout_V3_Final_Cut-40.png" style="width:30px">
                        </td>
                        <td style="height:100px; vertical-align:middle; line-height:36px; font-size:28px">
                            <font class="site_people_fitness">@(ViewBag.鶯歌健身)</font>
                        </td>
                        <td style="height:100px; vertical-align:middle; line-height:36px; padding-top:10px">
                            <font class="site_people_fitness">/ @(ViewBag.鶯歌健身max)人</font>
                        </td>
                    </tr>
                </table>

                <img src="../images/_index/index_lyaout_V3_Final_Cut-37_2.png" style="display: inline-block; position: relative; z-index: 2; width: 15px; top:-150px">

            </div>
            <div class="site_people">
                <h3 id="jump_taoyuan">北部地區</h3>
                <img src="../images/_index/index_lyaout_V3_Final_Cut-37.png" style="display: inline-block; position: relative; z-index: 2; width: 15px; top:-150px">

                <table class="site_people_tb" border="0" style="margin-top:110px">
                    <tr>
                        <td colspan="3" style="width:160px; height:45px">
                            <h4>宜蘭運動中心</h4>
                        </td>
                    </tr>
                    <tr>
                        <td style="height:100px; vertical-align:middle">
                            <img src="../images/_index/index_lyaout_V3_Final_Cut-40.png" style="width:30px"><br>
                            <img src="../images/_index/index_lyaout_V3_Final_Cut-41.png" style="width:30px">
                        </td>
                        <td style="height:100px; vertical-align:middle; line-height:36px; font-size:28px">
                            <font class="site_people_fitness">@(ViewBag.宜蘭健身)</font><br>
                            <font class="site_people_swim">@(ViewBag.宜蘭游泳)</font>
                        </td>
                        <td style="height:100px; vertical-align:middle; line-height:36px; padding-top:10px">
                            <font class="site_people_fitness">/ @(ViewBag.宜蘭健身max)人</font><br>
                            <font class="site_people_swim">/ @(ViewBag.宜蘭游泳max)人</font>
                        </td>
                    </tr>
                </table>

                <table class="site_people_tb" border="0" style="margin-top:110px">
                    <tr>
                        <td colspan="3" style="width:160px; height:45px">
                            <h4>桃園運動中心</h4>
                        </td>
                    </tr>
                    <tr>
                        <td style="height:100px; vertical-align:middle">
                            <img src="../images/_index/index_lyaout_V3_Final_Cut-40.png" style="width:30px"><br>
                            <img src="../images/_index/index_lyaout_V3_Final_Cut-41.png" style="width:30px"><br>
                            <img src="../images/_index/index_lyaout_V3_Final_Cut-42.png" style="width:30px">
                        </td>
                        <td style="height:100px; vertical-align:middle; line-height:36px; font-size:28px">
                            <font class="site_people_fitness">@(ViewBag.桃園健身)</font><br>
                            <font class="site_people_swim">@(ViewBag.桃園游泳)</font><br>
                            <font class="site_people_ice">@(ViewBag.桃園冰宮)</font>
                        </td>
                        <td style="height:100px; vertical-align:middle; line-height:36px; padding-top:10px">
                            <font class="site_people_fitness">/ @(ViewBag.桃園健身max)人</font><br>
                            <font class="site_people_swim">/ @(ViewBag.桃園游泳max)人</font><br>
                            <font class="site_people_ice">/ @(ViewBag.桃園冰宮max)人</font>
                        </td>
                    </tr>
                </table>

                <table class="site_people_tb" border="0" style="margin-top:110px">
                    <tr>
                        <td colspan="3" style="width:160px; height:45px">
                            <h4>中壢運動中心</h4>
                        </td>
                    </tr>
                    <tr>
                        <td style="height:100px; vertical-align:middle">
                            <img src="../images/_index/index_lyaout_V3_Final_Cut-40.png" style="width:30px"><br>
                            <img src="../images/_index/index_lyaout_V3_Final_Cut-41.png" style="width:30px">
                        </td>
                        <td style="height:100px; vertical-align:middle; line-height:36px; font-size:28px">
                            <font class="site_people_fitness">@(ViewBag.中壢健身)</font><br>
                            <font class="site_people_swim">@(ViewBag.中壢游泳)</font>
                        </td>
                        <td style="height:100px; vertical-align:middle; line-height:36px; padding-top:10px">
                            <font class="site_people_fitness">/ @(ViewBag.中壢健身max)人</font><br>
                            <font class="site_people_swim">/ @(ViewBag.中壢游泳max)人</font>
                        </td>
                    </tr>
                </table>

                <table class="site_people_tb" border="0" style="margin-top:110px">
                    <tr>
                        <td colspan="3" style="width:160px; height:45px">
                            <h4>南區運動中心</h4>
                        </td>
                    </tr>
                    <tr>
                        <td style="height:100px; vertical-align:middle">
                            <img src="../images/_index/index_lyaout_V3_Final_Cut-40.png" style="width:30px">
                        </td>
                        <td style="height:100px; vertical-align:middle; line-height:36px; font-size:28px">
                            <font class="site_people_fitness">@(ViewBag.南區健身)</font>
                        </td>
                        <td style="height:100px; vertical-align:middle; line-height:36px; padding-top:10px">
                            <font class="site_people_fitness">/ @(ViewBag.南區健身max)人</font>
                        </td>
                    </tr>
                </table>

                <img src="../images/_index/index_lyaout_V3_Final_Cut-37_2.png" style="display: inline-block; position: relative; z-index: 2; width: 15px; top:-150px">

            </div>
            <div class="site_people">
                <h3>中部地區</h3>
                <img src="../images/_index/index_lyaout_V3_Final_Cut-37.png" style="display: inline-block; position: relative; z-index: 2; width: 15px; top:-150px">

                <table class="site_people_tb" border="0" style="margin-top:110px">
                    <tr>
                        <td colspan="3" style="width:160px; height:45px">
                            <h4>港區運動中心</h4>
                        </td>
                    </tr>
                    <tr>
                        <td style="height:100px; vertical-align:middle">
                            <img src="../images/_index/index_lyaout_V3_Final_Cut-40.png" style="width:30px"><br>
                            <img src="../images/_index/index_lyaout_V3_Final_Cut-41.png" style="width:30px">
                        </td>
                        <td style="height:100px; vertical-align:middle; line-height:36px; font-size:28px">
                            <font class="site_people_fitness">@(ViewBag.港區健身)</font><br>
                            <font class="site_people_swim">@(ViewBag.港區游泳)</font>
                        </td>
                        <td style="height:100px; vertical-align:middle; line-height:36px; padding-top:10px">
                            <font class="site_people_fitness">/ @(ViewBag.港區健身max)人</font><br>
                            <font class="site_people_swim">/ @(ViewBag.港區游泳max)人</font>
                        </td>
                    </tr>
                </table>

                <table class="site_people_tb" border="0" style="margin-top:110px">
                    <tr>
                        <td colspan="3" style="width:160px; height:45px">
                            <h4>南屯運動中心</h4>
                        </td>
                    </tr>
                    <tr>
                        <td style="height:100px; vertical-align:middle">
                            <img src="../images/_index/index_lyaout_V3_Final_Cut-40.png" style="width:30px"><br>
                            <img src="../images/_index/index_lyaout_V3_Final_Cut-41.png" style="width:30px"><br>
                            <img src="../images/_index/index_lyaout_V3_Final_Cut-42.png" style="width:30px">
                        </td>
                        <td style="height:100px; vertical-align:middle; line-height:36px; font-size:28px">
                            <font class="site_people_fitness">@(ViewBag.南屯健身)</font><br>
                            <font class="site_people_swim">@(ViewBag.南屯游泳)</font><br>
                            <font class="site_people_ice">@(ViewBag.南屯冰宮)</font>
                        </td>
                        <td style="height:100px; vertical-align:middle; line-height:36px; padding-top:10px">
                            <font class="site_people_fitness">/ @(ViewBag.南屯健身max)人</font><br>
                            <font class="site_people_swim">/ @(ViewBag.南屯游泳max)人</font><br>
                            <font class="site_people_ice">/ @(ViewBag.南屯冰宮max)人</font>
                        </td>
                    </tr>
                </table>

                <table class="site_people_tb" border="0" style="margin-top:110px">
                    <tr>
                        <td colspan="3" style="width:160px; height:45px">
                            <h4>朝馬運動中心</h4>
                        </td>
                    </tr>
                    <tr>
                        <td style="height:100px; vertical-align:middle">
                            <img src="../images/_index/index_lyaout_V3_Final_Cut-40.png" style="width:30px"><br>
                            <img src="../images/_index/index_lyaout_V3_Final_Cut-41.png" style="width:30px">
                        </td>
                        <td style="height:100px; vertical-align:middle; line-height:36px; font-size:28px">
                            <font class="site_people_fitness">@(ViewBag.朝馬健身)</font><br>
                            <font class="site_people_swim">@(ViewBag.朝馬游泳)</font>
                        </td>
                        <td style="height:100px; vertical-align:middle; line-height:36px; padding-top:10px">
                            <font class="site_people_fitness">/ @(ViewBag.朝馬健身max)人</font><br>
                            <font class="site_people_swim">/ @(ViewBag.朝馬游泳max)人</font>
                        </td>
                    </tr>
                </table>

                <table class="site_people_tb" border="0" style="margin-top:110px">
                    <tr>
                        <td colspan="3" style="width:160px; height:45px">
                            <h4>長春運動中心</h4>
                        </td>
                    </tr>
                    <tr>
                        <td style="height:100px; vertical-align:middle">
                            <img src="../images/_index/index_lyaout_V3_Final_Cut-40.png" style="width:30px">
                        </td>
                        <td style="height:100px; vertical-align:middle; line-height:36px; font-size:28px">
                            <font class="site_people_fitness">@(ViewBag.長春健身)</font>
                        </td>
                        <td style="height:100px; vertical-align:middle; line-height:36px; padding-top:10px">
                            <font class="site_people_fitness">/ @(ViewBag.長春健身max)人</font>
                        </td>
                    </tr>
                </table>

                <img src="../images/_index/index_lyaout_V3_Final_Cut-37_2.png" style="display: inline-block; position: relative; z-index: 2; width: 15px; top:-150px">

            </div>
            <div class="site_people">
                <h3>南部地區</h3>

                <table class="site_people_tb" border="0" style="margin-top:110px">
                    <tr>
                        <td colspan="3" style="width:160px; height:45px">
                            <h4>鳳山運動中心</h4>
                        </td>
                    </tr>
                    <tr>
                        <td style="height:100px; vertical-align:middle">
                            <img src="../images/_index/index_lyaout_V3_Final_Cut-40.png" style="width:30px"><br>
                            <img src="../images/_index/index_lyaout_V3_Final_Cut-41.png" style="width:30px">
                        </td>
                        <td style="height:100px; vertical-align:middle; line-height:36px; font-size:28px">
                            <font class="site_people_fitness">@(ViewBag.鳳山健身)</font><br>
                            <font class="site_people_swim">@(ViewBag.鳳山游泳)</font>
                        </td>
                        <td style="height:100px; vertical-align:middle; line-height:36px; padding-top:10px">
                            <font class="site_people_fitness">/ @(ViewBag.鳳山健身max)人</font><br>
                            <font class="site_people_swim">/ @(ViewBag.鳳山游泳max)人</font>
                        </td>
                    </tr>
                </table>

            </div>
        </div>
    </div>
</div>

@RenderPage("../Shared/_Footer.vbhtml")

