@Code
    Layout = Nothing
End Code

@RenderPage("../Shared/_Header.vbhtml")

<style>
    #article {
        background-image: url(../images/bg/24-7_layout_Final_Cut-15.png);
    }

    #article2 {
        background-image: url(../images/bg/24-7_layout_Final_Cut-17.png);
    }
    td{
        min-width:180px;
    }
</style>

<div id="banner">
    <img src="../images/_product/32/24-7_layout_Final_Cut-11.png">
    <img src="../images/_product/32/24-7_layout_Final_Cut-12.png" style="display:flex; width:30%; margin-top:-25%; margin-left:48%">
    <img src="../images/_product/32/24-7_layout_Final_Cut-13.png" style="display:flex; width:45%; margin-top:2%; margin-left:28%">
</div>
<div id="article">
    <div class="section01" style="margin-top:15%">
        <h2>網路平台預約</h2>
        <p style="font-weight: normal">透過網路，24小時服務不中斷，提升與不同族群客戶互動性，全面資訊。</p>
        <img src="../images/_product/32/24-7_layout_Final_Cut-14.png" style="width:40%; margin-top:5%; margin-left:-50%"><br>
        <div class="section01_txt" style="display:inline-block; width:40%; text-align:left; margin-top:-40%; margin-left:60%">
            <p>課程預約報名</p>
            <p>場地預約服務</p>
            <p>課程查詢</p>
            <p>單堂報名</p>
            <p>權益查詢</p>
            <p>停車場、場地季租服務</p>
            <p>信託查詢</p>
        </div>
    </div>
</div>
<div id="article2">
    <div class="section02" style="margin-top:5%">
        <h2>專屬品牌App</h2>
        <p style="font-weight: normal">專屬數位體驗運動任你行App，全方位功能，囊括線上購票、課程報名、場地預約、互動遊戲及數位行銷，獲得更多客戶關注與增加黏著度。</p>
        <img src="../images/_product/32/24-7_layout_Final_Cut-18.png" style="width:40%; margin-top:5%; margin-left:-50%"><br>
        <table class="section01_txt" style="display:inline-block; width:50%; margin-top: -20%; margin-left: 50%">
            <tr>
                <td>
                    <p>課程預約報名</p>
                </td>
                <td>
                    <p>場地預約服務</p>
                </td>
            </tr>
            <tr>
                <td>
                    <p>會員權益查詢</p>
                </td>
                <td>
                    <p>最新消息</p>
                </td>
            </tr>
            <tr>
                <td>
                    <p>身體測量</p>
                </td>
                <td>
                    <p>運動軌跡</p>
                </td>
            </tr>
            <tr>
                <td>
                    <p>獎章收集</p>
                </td>
                <td>
                    <p>問券調查</p>
                </td>
            </tr>
            <tr>
                <td>
                    <p>運動紀錄</p>
                </td>
            </tr>
        </table>
    </div>
</div>

@RenderPage("../Shared/_Footer.vbhtml")
