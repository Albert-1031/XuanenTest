@Code
    Layout = Nothing
End Code

@RenderPage("../Shared/_Header.vbhtml")

<style>
    #article {
        background-image: url(../images/bg/Service_lyaout_Final_Cut-15.png);
        background-position-y: 30%;
    }

    #article2 {
        background-image: url(../images/bg/Service_lyaout_Final_Cut-17.png);
        background-position-y: 70%;
    }

    .section01_txt td {
        width: 30%;
        text-align: left;
    }
</style>

<div id="banner">
    <img src="../images/_product/31/Service_lyaout_Final_Cut-10.png">
    <img src="../images/_product/31/Service_lyaout_Final_Cut-11.png" style="display:flex; width:30%; margin-top:-25%; margin-left:48%">
    <img src="../images/_product/31/Service_lyaout_Final_Cut-12.png" style="display:flex; width:45%; margin-top:2%; margin-left:28%">
</div>
<div id="article">
    <div class="section01" style="margin-top:15%">
        <h2>完整POS</h2>
        <p style="font-weight: normal">開啟電腦網頁，開始結帳吧!完整功能及多元支付工具，一個頁面滿足所有客戶需求，專注提供客戶服務。</p>
        <img src="../images/_product/31/Service_lyaout_Final_Cut-13.png" style="width:90%; margin-top:10%;"><br>

        <table class="section01_txt , mobile_product31_td" style="margin-top:10%; margin-left:15%">
            <tr>
                <td>
                    <p>結帳銷售</p>
                </td>
                <td>
                    <p>課程報名<p>
                </td>
                <td>
                    <p>場地預約/季租<p>
                </td>
            </tr>
            <tr>
                <td>
                    <p>電子發票</p>
                </td>
                <td>
                    <p>票卡販售</p>
                </td>
                <td>
                    <p>停車場季租抽籤<p>
                </td>
            </tr>
            <tr>
                <td>
                    <p>多元金流</p>
                </td>
                <td>
                    <p>商品銷售</p>
                </td>
                <td>
                    <p>報表交帳<p>
                </td>
            </tr>
        </table>
    </div>
</div>
<div id="article2">
    <div class="section02" style="margin-top:5%">
        <h2>靈活課務</h2>
        <p style="font-weight: normal">滿足需求的課務系統，搭配頂尖行銷方案，創造高收益與效益，靈活運用系統，客人源源不絕。</p>
        <img class="mobile_product31_img" src="../images/_product/31/Service_lyaout_Final_Cut-16.png" style="width:40%; margin-top:5%; margin-left:-50%"><br>
        <div class="section01_txt , mobile_product31_txt" style="display: inline-block; width: 300px; text-align: left; margin-top: -38%; margin-left: 60%">
            <p>設定各式課程類別</p>
            <p>多管道課程報名統整</p>
            <p>插班、轉班、續報課程</p>
            <p>行銷方案設定</p>
            <p>學員上課自動點名</p>
            <p>課程續效分析</p>
        </div>

    </div>
</div>

@RenderPage("../Shared/_Footer.vbhtml")

