@Code
    Layout = "../Shared/_Header.vbhtml"
End Code

@*@RenderPage("../Shared/_Header.vbhtml")*@

<script src="../js/bootstrap.min.js"></script>
<style>
    @@import url(../css/bootstrap.min.css);

    .site_people_tb .long_sn {
        font-size: 17px;
    }
</style>

<div id="banner">
    <a href="../Product/Product02"><img src="../images/_index/index_lyaout_V2_Final_Cut-11.png" alt="運動場館的最佳幫手"></a>
</div>

<form id="subform_MainBlock" action="@(Html.Raw(ViewBag.GoTo首頁))" style="width: 100%;height: 100%;">
    <script type="text/javascript">
        $(document).ready(function () {
            $('#myCarousel').carousel({
                interval: false
            })
            $('#myCarousel2').carousel({
                interval: false
            })
            $('#myCarousel3').carousel({
                interval: false
            })
            $('#myCarousel4').carousel({
                interval: false
            })
            $('#myCarousel5').carousel({
                interval: false
            })

            //把c傳到getdata()
            var center = ['@Url.Content("~/Api/getdata?c=tp01")',
                '@Url.Content("~/Api/getdata?c=jj01")',
                '@Url.Content("~/Api/getdata?c=tp04")',
                '@Url.Content("~/Api/getdata?c=tp06")',
                '@Url.Content("~/Api/getdata?c=tp03")',
                '@Url.Content("~/Api/getdata?c=wd02")',
                '@Url.Content("~/Api/getdata?c=slsc68")',
                '@Url.Content("~/Api/getdata?c=tp12")',
                '@Url.Content("~/Api/getdata?c=tp02")',
                '@Url.Content("~/Api/getdata?c=tp07")',
                '@Url.Content("~/Api/getdata?c=cg01")',
                '@Url.Content("~/Api/getdata?c=sl01")',
                '@Url.Content("~/Api/getdata?c=ds01")',
                '@Url.Content("~/Api/getdata?c=tp08")',
                '@Url.Content("~/Api/getdata?c=fe01")',
                '@Url.Content("~/Api/getdata?c=tp10")',
                '@Url.Content("~/Api/getdata?c=tp09")',
                '@Url.Content("~/Api/getdata?c=ts01")',
                '@Url.Content("~/Api/getdata?c=xwt88")',
                '@Url.Content("~/Api/getdata?c=nt01")',
                '@Url.Content("~/Api/getdata?c=ds02")',
                '@Url.Content("~/Api/getdata?c=tp17")',
                '@Url.Content("~/Api/getdata?c=tp13")',
                '@Url.Content("~/Api/getdata?c=tp15")',
                '@Url.Content("~/Api/getdata?c=tp14")',
                '@Url.Content("~/Api/getdata?c=ws01")',
                '@Url.Content("~/Api/getdata?c=fe02")',
                '@Url.Content("~/Api/getdata?c=tp16")',
                '@Url.Content("~/Api/getdata?c=kc01")',
                '@Url.Content("~/Api/getdata?c=jb01")',
                '@Url.Content("~/Api/getdata?c=tp11")',
                '@Url.Content("~/Api/getdata?c=wd08")',
                '@Url.Content("~/Api/getdata?c=nd01")',
                '@Url.Content("~/Api/getdata?c=wd04")',
                '@Url.Content("~/Api/getdata?c=wp05")',
                '@Url.Content("~/Api/getdata?c=pt01")',
                '@Url.Content("~/Api/getdata?c=tp18")',
                '@Url.Content("~/Api/getdata?c=tz01")',
                '@Url.Content("~/Api/getdata?c=zy01")',
                '@Url.Content("~/Api/getdata?c=wd16")',
                '@Url.Content("~/Api/getdata?c=um01")',
                '@Url.Content("~/Api/getdata?c=wd14")',
                '@Url.Content("~/Api/getdata?c=wd05")',
                '@Url.Content("~/Api/getdata?c=wd15")']


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
                                    <font class="people_ot_fo1">@(ViewBag.台北店家0_健身)</font>
                                </td>
                                <td style="padding-top:15px">
                                    <font class="people_ot_fo2">/ @(ViewBag.台北店家0_健身max)人</font>
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
                                    <font class="people_ot_fo1">@(ViewBag.台北店家0_游泳)</font>
                                </td>
                                <td style="padding-top:15px">
                                    <font class="people_ot_fo2">/ @(ViewBag.台北店家0_游泳max)人</font>
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
                                    <font class="people_ot_fo1">@(ViewBag.新北店家0_健身)</font>
                                </td>
                                <td style="padding-top:15px">
                                    <font class="people_ot_fo2">/ @(ViewBag.新北店家0_健身max)人</font>
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
                                    <font class="people_ot_fo1">@(ViewBag.新北店家0_游泳)</font>
                                </td>
                                <td style="padding-top:15px">
                                    <font class="people_ot_fo2">/ @(ViewBag.新北店家0_游泳max)人</font>
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
                                    <font class="people_ot_fo1">@(ViewBag.北部店家1_健身)</font>
                                </td>
                                <td style="padding-top:15px">
                                    <font class="people_ot_fo2">/ @(ViewBag.北部店家1_健身max)人</font>
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
                                    <font class="people_ot_fo1">@(ViewBag.北部店家1_游泳)</font>
                                </td>
                                <td style="padding-top:15px">
                                    <font class="people_ot_fo2">/ @(ViewBag.北部店家1_游泳max)人</font>
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
            @RenderPage("../Index/Site_People.vbhtml")
        </div>
    </div>
</div>

@*@RenderPage("../Shared/_Footer.vbhtml")*@

