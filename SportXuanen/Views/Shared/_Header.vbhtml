<!DOCTYPE html>

<html>
<head>
    <meta meta http-equiv=content-type content=text/html charset=utf-8 />
    <meta http-equiv="X-UA-Compatible" content="IE=edge,chrome=1" />
    <meta name="description" content="會籍, 健身, 游泳池, 運動, 信託, 健身開店, 電子發票, 票券, 健身館, 訂閱制, 運動中心, 會員管理, pos系統, 收單, 教練課, 自由教練, 瑜珈">
    <meta name="viewport" content="width=device-width, initial-scale=1, user-scalable=no">
    <link rel="stylesheet" href="../css/reset.css">
    <link rel="stylesheet" href="../css/indexstyle.css">
    <script src="../js/jquery.min.js"></script>
    <title>璿恩資訊有限公司</title>

</head>

<body>
    <div id="main">
        <div class="header">
            <a href="../">
                <img class="nav_logo" src="../images/_index/index_lyaout_V2_Final_Cut-02.png" alt="璿恩資訊">
            </a>


            
            @*<div id="listBtn" onclick="listBtn()">秀出來</div>*@
            <div id="textlistn" style="display:none;">
                Hello IT邦
            </div>
            <div class="nav_menu">
                <ul>
                    <li>
                        <img src="../images/_index/index_lyaout_V2_Final_Cut-03.png" alt="璿恩斜線">
                    </li>

                    <li>
                        <a href="../">首頁</a>
                    </li>

                    <li>
                        <script>
                            function menu_pro() {
                                var menu_pro = document.getElementById('menu_pro');
                                var menu_pro_open = document.getElementById('menu_pro_open');
                                if (menu_pro_open.style.display === 'none') {
                                    menu_pro_open.style.display = 'block';
                                    menu_pro.style.background = 'url(../Images/_index/menu_down.png) no-repeat right/20px';
                                    menu_ab_open.style.display = 'none';
                                    menu_ab.style.background = 'url(../Images/_index/menu_up.png) no-repeat right/20px';
                                } else {
                                    menu_pro_open.style.display = 'none';
                                    menu_pro.style.background = 'url(../Images/_index/menu_up.png) no-repeat right/20px';
                                    menu_pro_open1_open.style.display = 'none';
                                    menu_pro_open2_open.style.display = 'none';
                                    menu_pro_open3_open.style.display = 'none';
                                    
                                }
                            }
                            function menu_pro_open1() {
                                var menu_pro_open1 = document.getElementById('menu_pro_open1');
                                var menu_pro_open1_open = document.getElementById('menu_pro_open1_open');
                                if (menu_pro_open1_open.style.display === 'none') {
                                    menu_pro_open1_open.style.display = 'block';
                                    menu_pro_open2_open.style.display = 'none';
                                    menu_pro_open3_open.style.display = 'none';
                                } else {
                                    menu_pro_open1_open.style.display = 'none';
                                }
                            }
                            function menu_pro_open2() {
                                var menu_pro_open2 = document.getElementById('menu_pro_open2');
                                var menu_pro_open2_open = document.getElementById('menu_pro_open2_open');
                                if (menu_pro_open2_open.style.display === 'none') {
                                    menu_pro_open1_open.style.display = 'none';
                                    menu_pro_open2_open.style.display = 'block';
                                    menu_pro_open3_open.style.display = 'none';
                                } else {
                                    menu_pro_open2_open.style.display = 'none';
                                }
                            }
                            function menu_pro_open3() {
                                var menu_pro_open3 = document.getElementById('menu_pro_open3');
                                var menu_pro_open3_open = document.getElementById('menu_pro_open3_open');
                                if (menu_pro_open3_open.style.display === 'none') {
                                    menu_pro_open1_open.style.display = 'none';
                                    menu_pro_open2_open.style.display = 'none';
                                    menu_pro_open3_open.style.display = 'block';
                                } else {
                                    menu_pro_open3_open.style.display = 'none';
                                }
                            }

                            function menu_ab() {
                                var menu_ab = document.getElementById('menu_ab');
                                var menu_ab_open = document.getElementById('menu_ab_open');
                                if (menu_ab_open.style.display === 'none') {
                                    menu_ab_open.style.display = 'block';
                                    menu_ab.style.background = 'url(../Images/_index/menu_down.png) no-repeat right/20px';
                                    menu_pro_open.style.display = 'none';
                                    menu_pro.style.background = 'url(../Images/_index/menu_up.png) no-repeat right/20px';
                                    menu_pro_open1_open.style.display = 'none';
                                    menu_pro_open2_open.style.display = 'none';
                                    menu_pro_open3_open.style.display = 'none';
                                } else {
                                    menu_ab_open.style.display = 'none';
                                    menu_ab.style.background = 'url(../Images/_index/menu_up.png) no-repeat right/20px';
                                }
                            }


                        </script>
                        <div id="menu_pro" class="menu_up" onclick="menu_pro()">
                            <a>產品介紹</a>
                        </div>
                        <ul id="menu_pro_open" class="nav_menu2" style="display:none">
                            <li id="menu_pro_open1" onclick="menu_pro_open1()">
                                面面俱到管理工具
                                <ul id="menu_pro_open1_open" class="nav_menu3" style="display:none">
                                    <li><a href="../Product/Product01">面面俱到管理工具</a></li>
                                    <li><a href="../Product/Product02">嶄新的資訊技術</a></li>
                                </ul>
                            </li>
                            <li id="menu_pro_open2" onclick="menu_pro_open2()">
                                健身房/工作室/游泳池
                                <ul id="menu_pro_open2_open" class="nav_menu3" style="display:none">
                                    <li><a href="../Product/Product11">來動創造活力 高階專屬服務</a></li>
                                    <li><a href="../Product/Product12">挑戰自我訓練及共享教學機制</a></li>
                                    <li><a href="../Product/Product13">新世代的課程管理</a></li>
                                </ul>
                            </li>
                            <li id="menu_pro_open3" onclick="menu_pro_open3()">
                                運動中心
                                <ul id="menu_pro_open3_open" class="nav_menu3" style="display:none">
                                    <li><a href="../Product/Product21">科技創造力 創造無限可能</a></li>
                                    <li><a href="../Product/Product22">24/7 連結客戶 提升黏著度</a></li>
                                    <li><a href="../Product/Product23">互相串聯 Make it easy</a></li>
                                </ul>
                            </li>
                            <li>
                                <a href="../Product/Product31">信託履約</a>
                            </li>
                        </ul>
                    </li>

                    <li>
                        <div id="menu_ab" class="menu_up" onclick="menu_ab()">
                            <a>關於我們</a>
                        </div>
                        <ul id="menu_ab_open" class="nav_menu2" style="display:none">
                            <li><a href="../AboutUs/AboutUs01">關於我們</a></li>
                            <li><a href="../AboutUs/AboutUs02">全方位領頭羊</a></li>
                        </ul>
                    </li>

                    <li>
                        <a href="../ContactUs/ContactUs01">聯絡我們</a>
                    </li>

                    <li>
                        <img src="../images/_index/index_lyaout_V2_Final_Cut-03.png" alt="璿恩斜線">
                    </li>
                </ul>
            </div>
        </div>

        @RenderBody()

        <div id="footer">
            <img src="~/images/_index/index_lyaout_V2_Final_Cut-23.png">
        </div>
            </div>
        </body>
</html>

