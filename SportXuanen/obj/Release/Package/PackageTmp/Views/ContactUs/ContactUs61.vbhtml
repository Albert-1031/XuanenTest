@Code
    Layout = Nothing
End Code

@RenderPage("../Shared/_Header.vbhtml")

<style>
    #article2 {
        background-image: url(../images/bg/contact_lyaout_Final_Cut-32.png);
    }

    .contact_fm {
        margin-top:5%;
        font-weight: bold;
        font-size:18px;
        color: #598089;
        line-height: 45px;
    }

    .contact_fm input {
        font-size: 18px;
        background-color: transparent;
        text-align:left;
        width:190px;
    }

    .contact_fm select {
        font-weight: bold;
        font-size: 18px;
        width: 80px;
        color: #598089;
        background-color: transparent;
    }

    .contact_fm textarea {
        background-color: transparent;
    }
</style>

<div id="banner">
    <img src="../images/_contact_us/contact_lyaout_Final_Cut-10.png">
</div>

<div id="article2">
    <div class="section01" style="margin-top:5%">
        <p>
            若有任何疑問，您可以直接在此處留下問題，亦可於上班時間與我們聯絡！
        </p>
        <img src="../images/_contact_us/contact_lyaout_Final_Cut-11.png" style="width:40%; margin-top:5%">
        <div style="width:45%; text-align:left; margin-top:5%; float:right">
            <img src="../images/_contact_us/contact_lyaout_Final_Cut-17.png" style="width:25%; margin-left:8%"><br>
            <a href="https://www.facebook.com/xuanensports"><img src="../images/_contact_us/contact_lyaout_Final_Cut-12.png" style="width:28%; margin-top:3%; margin-left:10%"></a>
            <a href="https://linecorp.com/zh-hant/"><img src="../images/_contact_us/contact_lyaout_Final_Cut-14.png" style="width:20%; margin-bottom:2%; margin-left:15%"></a>
            <img src="../images/_contact_us/contact_lyaout_Final_Cut-15.png" style="width:20%; margin-bottom:2%"><br>
            <img src="../images/_contact_us/contact_lyaout_Final_Cut-13.png" style="width:42%">
            <img src="../images/_contact_us/contact_lyaout_Final_Cut-16.png" style="width:33%; margin-left:15%">
        </div>
    </div>
    <div class="section02" style="width:70%">
        <img src="../images/_contact_us/contact_lyaout_Final_Cut-18.png" style="width:200px; margin-top:5%"><br>
        <form class="contact_fm" action="/" method="post">
            <div class="mobile_contactus61_in" style="width:300px; text-align:right; margin-left:auto; margin-right:55%">
                您的姓名：<input type="text" name="UserName" required><br>
                您的電話：<input type="text" name="UserPhone" required><br>
                您的場館名稱：<input type="text" name="Place_txt" style="width:155px" required><br>
                請問您場館的業態屬性：
                <select required>
                    <option value="value">請選擇</option>
                </select>
            </div>

            <div class="mobile_contactus61_text">
                <div style="margin-top:-180px; margin-left:350px; margin-right:auto">
                    其他洽詢內容：<br>
                    <textarea name="contact_txt" rows="8" cols="35"></textarea>
                </div>
            </div>
            <input type="submit" 
                   value=""
                   style="width:200px;
                    height:45px;
                    margin-top:20px;
                    border-style:none;
                    background-image: url(../images/_contact_us/contact_lyaout_Final_Cut-30.png);
                    background-size:200px 45px;
            ">
        </form>
    </div>
</div>

@RenderPage("../Shared/_Footer.vbhtml")
