@Code
    Layout = Nothing
End Code

@RenderPage("../Shared/_Header.vbhtml")

<style>
    #article {
        background-image: url(../images/bg/product_3-05.png);
    }
</style>

<div id="banner">
    <img src="../images/_product/13/product_3-01.png">
    <img src="../images/_product/13/product_3-02.png" style="display:flex; width:45%; margin-top:-25%; margin-left:35%">
</div>
<div id="article">
    <div class="section01" style="margin-top:15%">
        <h2>團課</h2>
        <p style="font-weight: normal">無論線上或線下，一個會員都不讓你跑掉，從預約時間、滿班人數及黑名單紀錄，系統通通包辦。專業化課程管理，課程公告、介紹、報名應有盡有，搭配系統自動點名功能，節省人工點名作業的繁瑣，提高教學質量。</p>
        <img class="mobile_product13_img" src="../images/_product/13/product_3-03.png" style="width:350px; margin-top:15%; margin-left:-45%"><br>
        <div class="section01_txt , mobile_product13_txt" style="display: inline-block; width: 250px; text-align: left; margin-top: -32%; margin-left: 55%">
            <p>優惠推廣</p>
            <p>活動公告</p>
            <p>系統自動點名</p>
            <p>預購行銷方案</p>
            <p>課程體驗價</p>
            <p>課程分享、預約、候補</p>
            <p>黑名單紀錄</p>
        </div>
    </div>
</div>

@RenderPage("../Shared/_Footer.vbhtml")
