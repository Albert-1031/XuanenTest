@Code
    Layout = Nothing
End Code

@RenderPage("../Shared/_Header.vbhtml")

<style>
    .people_ot {   /*中心人流*/
        position: relative;
        z-index: 1;
        display: inline-block;
        width: 220px;
        height: 220px;
        background-image: url(../images/_index/index_lyaout_V3_Final_Cut-27.png);
        background-size: 220px 220px;
        top: 50px;
        font-weight:bold;
        margin:auto 1%;
    }
    .people_ot td{
        vertical-align:middle;
    }
    .people_ot_tr1, .people_ot_tr2 {
        background-size: 200px 55px;
        background-repeat:no-repeat;
        background-position-x:center;
        background-position-y:center;
    }
    .people_ot_tr1 {
        background-image: url(../images/_index/index_lyaout_V3_Final_Cut-32.png);

    }
    .people_ot_tr2 {
        background-image: url(../images/_index/index_lyaout_V3_Final_Cut-33.png);
    }
    .people_ot_tr1 img, .people_ot_tr2 img {
       width:45px;
    }
    .people_ot h4 {
        font-size: 24px;
        color: #663022;
        text-shadow: 0 0 1px #663022, 0 0 1px #663022, 0 0 1px #663022;
        letter-spacing:17px;
        padding-top:15px;
        padding-left:15px;
    }
    .people_ot p {
        font-size: 18px;
        color: #bc664b;
    }
    .people_ot_fo1 {
        font-size:30px;
        color: #327c7f;
    }
    .people_ot_fo2 {
        font-size:20px;
        color: #327c7f;
        padding-right:20px;
    }

    .site_people { /*各場人流*/
        position: relative;
        z-index: 1;
        width: 800px;
        height: 220px;
        background-image: url(../images/_index/index_lyaout_V3_Final_Cut-36.png);
        background-size: 800px 220px;
        margin-top: 5%;
        margin-left: auto;
        margin-right: auto;
        top: 50px;
    }
    .site_people h3 {
        font-weight: bold;
        font-size: 28px;
        color: #fff;
    }
    .site_people h4 {
        font-weight: bold;
        font-size: 20px;
        color: #305966;
        padding-top:7px;
    }
    .site_people_tb {
        display:inline-block;
        position: relative;
        z-index: 1;
        width: 160px;
        height: 160px;
        background-image: url(../images/_index/index_lyaout_V3_Final_Cut-38.png);
        background-size: 160px 160px;
        top:-100px;
        margin-left:10px;
        margin-right:10px;
    }

    .site_people_fitness {
        font-weight: bold;
        color: #e5cb5e;
    }
    .site_people_swim {
        font-weight: bold;
        color: #3f6299;
    }
    .site_people_ice {
        font-weight: bold;
        color: #559970;
    }
</style>

<div id="banner">
    <a href="../Product/Product12"><img src="../images/_index/index_lyaout_V2_Final_Cut-11.png"></a>
</div>
<div id="article" style="background-image:url(../images/bg/product_02-05.png)">
    <!--運動中心即時人流-->
    <div class="section01">
        <img src="../images/_index/index_lyaout_V3_Final_Cut-43.png" style="width:33%; margin-top:10%"><br>

        <table class="people_ot" border="0">
            <tr>
                <td colspan="3" style="width:220px; height:80px; line-height:18px">
                    <h4>台北市</h4>
                    <p>中山運動中心</p>
                </td>
            </tr>
            <tr class="people_ot_tr1">
                <td style="padding-top:2px; width:60px; height:60px; padding-left:10px;"><img src="../images/_index/index_lyaout_V3_Final_Cut-30.png"></td>
                <td style="padding-top:12px; width:60px; padding-top:10px"><font class="people_ot_fo1">18 /</font></td>
                <td style="padding-top:15px"><font class="people_ot_fo2">75人</font>
            </tr>
            <tr class="people_ot_tr2">
                <td style="padding-top:2px; height:60px; padding-left: 10px"><img src="../images/_index/index_lyaout_V3_Final_Cut-31.png"></td>
                <td style="padding-top:12px"><font class="people_ot_fo1">18 /</font></td>
                <td style="padding-top:15px"><font class="people_ot_fo2">120人</font></td>
            </tr>
        </table>
        
        <table class="people_ot" border="0">
            <tr>
                <td colspan="3" style="width:220px; height:80px; line-height:18px">
                    <h4>新北市</h4>
                    <p>蘆洲運動中心</p>
                </td>
            </tr>
            <tr class="people_ot_tr1">
                <td style="padding-top:2px; width:60px; height:60px; padding-left:10px;"><img src="../images/_index/index_lyaout_V3_Final_Cut-30.png"></td>
                <td style="padding-top:12px; width:60px; padding-top:10px"><font class="people_ot_fo1">18 /</font></td>
                <td style="padding-top:15px"><font class="people_ot_fo2">75人</font>
            </tr>
            <tr class="people_ot_tr2">
                <td style="padding-top:2px; height:60px; padding-left: 10px"><img src="../images/_index/index_lyaout_V3_Final_Cut-31.png"></td>
                <td style="padding-top:12px"><font class="people_ot_fo1">18 /</font></td>
                <td style="padding-top:15px"><font class="people_ot_fo2">120人</font></td>
            </tr>
        </table>
        
        <table class="people_ot" border="0">
            <tr>
                <td colspan="3" style="width:220px; height:80px; line-height:18px">
                    <h4>桃園市</h4>
                    <p>桃園運動中心</p>
                </td>
            </tr>
            <tr class="people_ot_tr1">
                <td style="padding-top:2px; width:60px; height:60px; padding-left:10px;"><img src="../images/_index/index_lyaout_V3_Final_Cut-30.png"></td>
                <td style="padding-top:12px; width:60px; padding-top:10px"><font class="people_ot_fo1">18 /</font></td>
                <td style="padding-top:15px"><font class="people_ot_fo2">75人</font>
            </tr>
            <tr class="people_ot_tr2">
                <td style="padding-top:2px; height:60px; padding-left: 10px"><img src="../images/_index/index_lyaout_V3_Final_Cut-31.png"></td>
                <td style="padding-top:12px"><font class="people_ot_fo1">18 /</font></td>
                <td style="padding-top:15px"><font class="people_ot_fo2">120人</font></td>
            </tr>
        </table>

    </div>

    <!--服務場館-->
    <div class="section01">
        <img src="../images/_index/index_lyaout_V2_Final_Cut-26.png" style="width:75%; margin-top:10%"><br>
        <img src="../images/_index/index_lyaout_V2_Final_Cut-12.png" style="width:45%; margin-top:7%; margin-left:5%; float:left">
        <img src="../images/_index/index_lyaout_V2_Final_Cut-13.png" style="width:45%; margin-top:15%"><br>
        <img src="../images/_index/index_lyaout_V2_Final_Cut-14.png" style="width:45%; margin-top:10%; float:right">
        <img src="../images/_index/index_lyaout_V2_Final_Cut-15.png" style="width:45%; margin-top:12%"><br>
        <img src="../images/_index/index_lyaout_V2_Final_Cut-16.png" style="width:45%; margin-top:11%">
        <img src="../images/_index/index_lyaout_V2_Final_Cut-17.png" style="width:45%; margin-top:-25%; float:right"><br>
    </div>
</div>

<div id="article" style="background-image:url(../images/bg/product_01-04.png); background-position-y:0%">
    <!--了解更多-->
    <div class="section02" style="height:400px">
        <a href="../Product/Product11"><img src="../images/_index/index_lyaout_V2_Final_Cut-18.png" style="width:25%; margin-top:10%;"></a><br>
        <img src="../images/_index/index_lyaout_V2_Final_Cut-19.png" style="width:20%; margin-top:5%">
        <img src="../images/_index/index_lyaout_V2_Final_Cut-21.png" style="width:20%; margin-left:20%"><br>
        <img src="../images/_index/index_lyaout_V2_Final_Cut-20.png" style="width:20%; margin-top:5%; margin-bottom:5%">
        <a href="../ContactUs/ContactUs61"><img src="../images/_index/index_lyaout_V2_Final_Cut-22.png" style="width:20%; margin-bottom:7%; margin-left:20%"></a><br>
</div>
</div>

<div id="article2">
    <div id="article" style="background-image:url(../images/bg/product_02-05.png); background-position-y:58%">
        <!--各場即時人流-->
        <div class="section01">
            <img src="../images/_index/index_lyaout_V3_Final_Cut-34.png" style="width:33%; margin-top:25%"><br>
            <div class="site_people">
                <h3>台北市</h3>
                <img src="../images/_index/index_lyaout_V3_Final_Cut-37.png" style="display: inline-block; position: relative; z-index: 2; width: 15px; top:-150px">

                <table class="site_people_tb" border="0" style="margin-top:110px">
                    <tr>
                        <td colspan="3" style="width:160px; height:45px">
                            <h4>中山運動中心</h4>
                        </td>
                    </tr>
                    <tr>
                        <td style="height:100px; vertical-align:middle"> 
                            <img src="../images/_index/index_lyaout_V3_Final_Cut-40.png" style="width:30px"><br>
                            <img src="../images/_index/index_lyaout_V3_Final_Cut-41.png" style="width:30px">
                        </td>
                        <td style="height:100px; vertical-align:middle; line-height:36px; font-size:28px">
                            <font class="site_people_fitness">18</font><br>
                            <font class="site_people_swim">18</font>
                        </td>
                        <td style="height:100px; vertical-align:middle; line-height:36px; padding-top:10px">
                            <font class="site_people_fitness">/ 75人</font><br>
                            <font class="site_people_swim">/ 120人</font>
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
                            <img src="../images/_index/index_lyaout_V3_Final_Cut-40.png" style="width:30px"><br>
                            <img src="../images/_index/index_lyaout_V3_Final_Cut-41.png" style="width:30px"><br>
                            <img src="../images/_index/index_lyaout_V3_Final_Cut-42.png" style="width:30px">
                        </td>
                        <td style="height:100px; vertical-align:middle; line-height:36px; font-size:28px">
                            <font class="site_people_fitness">18</font><br>
                            <font class="site_people_swim">18</font><br>
                            <font class="site_people_ice">18</font>
                        </td>
                        <td style="height:100px; vertical-align:middle; line-height:36px; padding-top:10px">
                            <font class="site_people_fitness">/ 75人</font><br>
                            <font class="site_people_swim">/ 120人</font><br>
                            <font class="site_people_ice">/ 90人</font>
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
                            <font class="site_people_fitness">18</font><br>
                            <font class="site_people_swim">18</font>
                        </td>
                        <td style="height:100px; vertical-align:middle; line-height:36px; padding-top:10px">
                            <font class="site_people_fitness">/ 75人</font><br>
                            <font class="site_people_swim">/ 120人</font>
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
                            <font class="site_people_fitness">18</font>
                        </td>
                        <td style="height:100px; vertical-align:middle; line-height:36px; padding-top:10px">
                            <font class="site_people_fitness">/ 75人</font>
                        </td>
                    </tr>
                </table>

                <img src="../images/_index/index_lyaout_V3_Final_Cut-37_2.png" style="display: inline-block; position: relative; z-index: 2; width: 15px; top:-150px">

            </div>
            <div class="site_people">
                <h3>新北市</h3>
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
                            <font class="site_people_fitness">18</font><br>
                            <font class="site_people_swim">18</font>
                        </td>
                        <td style="height:100px; vertical-align:middle; line-height:36px; padding-top:10px">
                            <font class="site_people_fitness">/ 75人</font><br>
                            <font class="site_people_swim">/ 120人</font>
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
                            <font class="site_people_fitness">18</font><br>
                            <font class="site_people_swim">18</font><br>
                            <font class="site_people_ice">18</font>
                        </td>
                        <td style="height:100px; vertical-align:middle; line-height:36px; padding-top:10px">
                            <font class="site_people_fitness">/ 75人</font><br>
                            <font class="site_people_swim">/ 120人</font><br>
                            <font class="site_people_ice">/ 90人</font>
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
                            <font class="site_people_fitness">18</font><br>
                            <font class="site_people_swim">18</font>
                        </td>
                        <td style="height:100px; vertical-align:middle; line-height:36px; padding-top:10px">
                            <font class="site_people_fitness">/ 75人</font><br>
                            <font class="site_people_swim">/ 120人</font>
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
                            <font class="site_people_fitness">18</font>
                        </td>
                        <td style="height:100px; vertical-align:middle; line-height:36px; padding-top:10px">
                            <font class="site_people_fitness">/ 75人</font>
                        </td>
                    </tr>
                </table>

                <img src="../images/_index/index_lyaout_V3_Final_Cut-37_2.png" style="display: inline-block; position: relative; z-index: 2; width: 15px; top:-150px">

            </div>
            <div class="site_people">
                <h3>北部地區</h3>
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
                            <font class="site_people_fitness">18</font><br>
                            <font class="site_people_swim">18</font>
                        </td>
                        <td style="height:100px; vertical-align:middle; line-height:36px; padding-top:10px">
                            <font class="site_people_fitness">/ 75人</font><br>
                            <font class="site_people_swim">/ 120人</font>
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
                            <font class="site_people_fitness">18</font><br>
                            <font class="site_people_swim">18</font><br>
                            <font class="site_people_ice">18</font>
                        </td>
                        <td style="height:100px; vertical-align:middle; line-height:36px; padding-top:10px">
                            <font class="site_people_fitness">/ 75人</font><br>
                            <font class="site_people_swim">/ 120人</font><br>
                            <font class="site_people_ice">/ 90人</font>
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
                            <font class="site_people_fitness">18</font><br>
                            <font class="site_people_swim">18</font>
                        </td>
                        <td style="height:100px; vertical-align:middle; line-height:36px; padding-top:10px">
                            <font class="site_people_fitness">/ 75人</font><br>
                            <font class="site_people_swim">/ 120人</font>
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
                            <font class="site_people_fitness">18</font>
                        </td>
                        <td style="height:100px; vertical-align:middle; line-height:36px; padding-top:10px">
                            <font class="site_people_fitness">/ 75人</font>
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
                            <font class="site_people_fitness">18</font><br>
                            <font class="site_people_swim">18</font>
                        </td>
                        <td style="height:100px; vertical-align:middle; line-height:36px; padding-top:10px">
                            <font class="site_people_fitness">/ 75人</font><br>
                            <font class="site_people_swim">/ 120人</font>
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
                            <font class="site_people_fitness">18</font><br>
                            <font class="site_people_swim">18</font><br>
                            <font class="site_people_ice">18</font>
                        </td>
                        <td style="height:100px; vertical-align:middle; line-height:36px; padding-top:10px">
                            <font class="site_people_fitness">/ 75人</font><br>
                            <font class="site_people_swim">/ 120人</font><br>
                            <font class="site_people_ice">/ 90人</font>
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
                            <font class="site_people_fitness">18</font><br>
                            <font class="site_people_swim">18</font>
                        </td>
                        <td style="height:100px; vertical-align:middle; line-height:36px; padding-top:10px">
                            <font class="site_people_fitness">/ 75人</font><br>
                            <font class="site_people_swim">/ 120人</font>
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
                            <font class="site_people_fitness">18</font>
                        </td>
                        <td style="height:100px; vertical-align:middle; line-height:36px; padding-top:10px">
                            <font class="site_people_fitness">/ 75人</font>
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
                            <font class="site_people_fitness">18</font><br>
                            <font class="site_people_swim">18</font>
                        </td>
                        <td style="height:100px; vertical-align:middle; line-height:36px; padding-top:10px">
                            <font class="site_people_fitness">/ 75人</font><br>
                            <font class="site_people_swim">/ 120人</font>
                        </td>
                    </tr>
                </table>

            </div>
        </div>
    </div>
</div>

@RenderPage("../Shared/_Footer.vbhtml")

