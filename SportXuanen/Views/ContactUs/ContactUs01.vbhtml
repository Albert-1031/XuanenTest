@Code
    Layout = "../Shared/_Header.vbhtml"
End Code

@*@RenderPage("../Shared/_Header.vbhtml")*@

<style>
    #article2 {
        background-image: url(../images/bg/contact_lyaout_Final_Cut-32.png);
    }

    .contact_fm {
        margin-top: 5%;
        font-weight: bold;
        font-size: 18px;
        color: #598089;
        line-height: 45px;
    }

        .contact_fm input {
            font-size: 18px;
            background-color: transparent;
            text-align: left;
            width: 190px;
        }

        .contact_fm select {
            font-weight: bold;
            font-size: 18px;
            width: 82px;
            color: #598089;
            background-color: transparent;
        }

        .contact_fm textarea {
            background-color: transparent;
            resize: none;
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
        <img src="../images/_contact_us/contact_lyaout_Final_Cut-11.png" style="width:36%; margin-top:5%">
        <div style="width:46%; text-align:left; margin-top:5%; float:right">
            <img src="../images/_contact_us/contact_lyaout_Final_Cut-17.png" style="width:25%"><br>
            <a href="https://www.facebook.com/xuanensports"><img src="../images/_contact_us/contact_lyaout_Final_Cut-12.png" style="width:28%; margin-top:3%"></a>
            <a href="https://line.me/ti/p/CC-hpxsVv8"><img src="../images/_contact_us/contact_lyaout_Final_Cut-14.png" style="width:20%; margin-bottom:2%; margin-left:20%"></a>
            <img src="../images/_contact_us/contact_lyaout_Final_Cut-15.png" style="width:20%; margin-bottom:2%"><br>
            <img src="../images/_contact_us/contact_lyaout_Final_Cut-13.png" style="width:45%; margin-left:-10%">
            <img src="../images/_contact_us/contact_lyaout_Final_Cut-16.png" style="width:55%; margin-left:5%" ">
        </div>
    </div>
    <div class="section02" style="width:70%">
        <img src="../images/_contact_us/contact_lyaout_Final_Cut-18.png" style="width:200px; margin-top:5%"><br>
        <form class="contact_fm" id="subform_MainBlock" action="@(Html.Raw(ViewBag.聯絡我們))" method="post">
            <script type="text/javascript">
                function DoSubmit() {
                    var CheckFlag = true;
                    var formObj = $('#subform_MainBlock');
                    var formURL = formObj.attr("action");
                    var formData = new FormData();

                    formData.append("UserName", $('#UserName').val());
                    formData.append("UserPhone", $('#UserPhone').val());
                    formData.append("Place_txt", $('#Place_txt').val());
                    formData.append("contact_txt", $('#contact_txt').val());
                    formData.append("Venue_Att", $('#Venue_Att').val());

                    $.ajax({
                        url: formURL,
                        type: 'POST',
                        data: formData,
                        async: false,
                        cache: false,
                        contentType: false,
                        processData: false,
                        success: function (data) {
                            var m1 = data.split(",");
                            if (m1[0] == 1) {

                            }
                            if (m1[0] == 0) {

                            }
                        }
                    });
                    return false;
                }
            </script>

            <div class="mobile_contactus01_in" style="width:300px; text-align:left; margin-left:auto; margin-right:55%">
                您的姓名：<input type="text" name="UserName" id="UserName" required><br>
                您的電話：<input type="text" name="UserPhone" id="UserPhone" required><br>
                您的場館名稱：<input type="text" name="Place_txt" id="Place_txt" style="width:155px" required><br>
                請問您場館的業態屬性：
                <select id="Venue_Att">
                    <option value="0">請選擇</option>
                    <option value="1">俱樂部</option>
                    <option value="2">健身房</option>
                    <option value="3">游泳池</option>
                    <option value="4">高爾夫</option>
                    <option value="5">網球場</option>
                    <option value="6">羽球場</option>
                    <option value="7">團體課程</option>
                    <option value="8">舞蹈教室</option>
                    <option value="9">兒童體能</option>
                </select>
            </div>

            <div class="mobile_contactus01_text" style="text-align: left; margin-top:-180px; margin-left: 55%; margin-right: auto">
                其他洽詢內容：<br>
                <textarea name="contact_txt" id="contact_txt" rows="8" cols="35"></textarea>
            </div>

            <input type="submit" value="" style="width:200px;height:45px;margin-top:20px;border-style:none;background-image: url(../images/_contact_us/contact_lyaout_Final_Cut-30.png);background-size:200px 45px;" onclick="DoSubmit();">
        </form>
    </div>
</div>

@*@RenderPage("../Shared/_Footer.vbhtml")*@
