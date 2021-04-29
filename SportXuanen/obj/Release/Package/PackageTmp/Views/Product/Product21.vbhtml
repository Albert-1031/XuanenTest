@Code
    Layout = Nothing
End Code

@RenderPage("../Shared/_Header.vbhtml")

<style>
    #article {
        background-image: url(../images/bg/product_01-04.png);
    }

    #article2 {
        background-image: url(../images/bg/product_02-07.png);
    }
</style>

<div id="banner">
    <img src="../images/_product/21/product_01-01.png">
    <img src="../images/_product/21/product_01-02.png" style="display:flex; width:45%; margin-top:-25%; margin-left:30%">
</div>
<div id="article">
    <div class="section01" style="margin-top:15%">
        <h2>入場門票</h2>
        <p style="font-weight: normal">多元進場選擇，滿足市場9成以上場館進場模式，從運動小白到健身老手，全自動人流設備將幫助你省去大量的人工辨識，及人為造成遺漏的問題。</p>
        <img src="../images/_product/21/product_01-03.png" style="width:40%; margin-top:5%; margin-left:-40%"><br>
        <div class="section01_txt" style="display:inline-block; width:40%; font-weight: bold; text-align:left; margin-top:-28%; margin-left:60%">
            <p>儲值會員</p>
            <p>以分鐘計算</p>
            <p>以點數計算</p>
            <p>整合悠遊卡扣款</p>
            <p>App 線上購買</p>
            <p>顯示使用狀態資訊</p>
        </div>
        <img src="../images/_product/21/product_01-05.png" style="width:15%; margin:4%;">
        <img src="../images/_product/21/product_01-06.png" style="width:15%; margin:4%;">
        <img src="../images/_product/21/product_01-07.png" style="width:15%; margin:4%;">
        <img src="../images/_product/21/product_01-08.png" style="width:15%; margin:4%;">
    </div>
</div>
<div id="article2">
    <div class="section02" style="margin-top:5%">
        <h2>會籍功能</h2>
        <p style="font-weight: normal">擔心收取年費造成會員擔憂嗎? 輕鬆綁定信用卡，時間到自動扣款，追蹤會員狀態，扣款失敗提醒，不用擔心找不到會員。業界最愛會籍功能用數據，有效管理場館及調整走向。</p>
        <img src="../images/_product/21/product_01-09.png" style="width:40%; margin-top:5%; margin-left:-40%"><br>
        <div class="section01_txt" style="display: inline-block; width: 40%; text-align: left; margin-top: -20%; margin-left: 60%">
            <p>儲值會員</p>
            <p>以分鐘計算</p>
            <p>以點數計算</p>
            <p>整合悠遊卡扣款</p>
            <p>App 線上購買</p>
            <p>顯示使用狀態資訊</p>
        </div>

    </div>
</div>

@RenderPage("../Shared/_Footer.vbhtml")

