@Code
    Layout = "../Shared/_Header.vbhtml"
End Code

@*@RenderPage("../Shared/_Header.vbhtml")*@

<style>
    table p {
        background-image: url(../images/_product/02/product_4-05_w12Xh13.png);
        background-repeat: no-repeat;
        background-size: 3% auto;
        background-position-y: 50%;
        padding-left: 10%;
    }

    table td {
        width: 50%
    }

    #article {
        background-image: url(../images/bg/product_0-15_w1920Xh938.png);
        background-position-y: 50%;
    }
</style>

<div id="banner">
    <img src="../images/_product/02/product_4-01_w1920Xh600.png">
    <img src="../images/_product/02/product_4-02_w860Xh310.png" style="display:flex; width:45%; margin-top:-25%; margin-left:38%">
</div>
<div id="article">
    <div class="section01" style="margin-top:15%">
        <h2>系統架構</h2>
        <p class="section_des">&ensp;&ensp;&ensp;&ensp;專注於運動產業鏈，以Web-base 網路架構，整合物聯網的軟體及硬體服務。</p>
        <img src="../images/_product/02/product_4_new-01.png" style="width:100%; margin-top:10%;"><br>

        <table class="mobile_product02_td" style="width:80%; min-width:220px; text-align:left; line-height:250%; margin-top:10%; margin-bottom:5%; margin-left:15%;">
            <tr>
                <td>
                    <p>閘門通關機</p>
                </td>
                <td>
                    <p>實體信用卡刷卡機</p>
                </td>
            </tr>
            <tr>
                <td>
                    <p>自動售票機</p>
                </td>
                <td>
                    <p>悠遊卡小額扣款</p>
                </td>
            </tr>
            <tr>
                <td>
                    <p>電子發票機</p>
                </td>
                <td>
                    <p>印卡機</p>
                </td>
            </tr>
            <tr>
                <td>
                    <p>QR Code 掃描機</p>
                </td>
                <td>
                    <p>Keyboard 讀卡機</p>
                </td>
            </tr>
        </table>
    </div>
</div>
@*@RenderPage("../Shared/_Footer.vbhtml")*@
