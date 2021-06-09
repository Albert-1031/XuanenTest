@Code
    Layout = "../Shared/_Header.vbhtml"
End Code

@*@RenderPage("../Shared/_Header.vbhtml")*@

<style>
    #article2 {
        background-image: url(../images/bg/contact_lyaout_Final_Cut-32.png);
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
        <div style="width:100%; margin-top:5%">
            <div style="display: inline-block; width:42%; text-align: left; margin-left:5%; vertical-align:top">
                <img src="../images/_contact_us/contact_lyaout_Final_Cut-11_1.png" style="width:40%; vertical-align:top"><br>
                <img src="../images/_contact_us/contact_lyaout_Final_Cut-11_2.png" style="width:95%; margin-top:5%">
            </div>
            <div style="display: inline-block; width:42%; text-align: left; margin-left:5%">
                <img src="../images/_contact_us/contact_lyaout_Final_Cut-17.png" style="width:40%; vertical-align:top"><br>
                <a href="https://www.facebook.com/xuanensports"><img src="../images/_contact_us/contact_lyaout_Final_Cut-12.png" style="width:28%; margin-top:7%"></a>
                <a href="https://line.me/ti/p/CC-hpxsVv8"><img src="../images/_contact_us/contact_lyaout_Final_Cut-14.png" style="width:20%; margin-bottom:2%; margin-left:20%"></a>
                <img src="../images/_contact_us/contact_lyaout_Final_Cut-15.png" style="width:20%; margin-bottom:2%"><br>
                <img src="../images/_contact_us/contact_lyaout_Final_Cut-13.png" style="width:45%; margin-left:-10%">
                <img src="../images/_contact_us/contact_lyaout_Final_Cut-16.png" style="width:55%; margin-left:5%">
            </div>
        </div>  
    </div>
    <div class="section02" style="width:70%">
        <img src="../images/_contact_us/contact_lyaout_Final_Cut-18.png" style="width:200px; margin-top:5%"><br>
        <form class="contact_fm" id="subform_MainBlock" action="../ContactUs/ContactUs01" onclick="return false">
            <div class="mobile_contactus01_in" style="width:300px; text-align:left; margin-left:auto; margin-right:55%">
                *您的姓名：<input type="text" name="txtName" id="txtName" required><br>
                *您的電話：<input type="text" name="txtPhone" id="txtPhone" required><br>
                *您的場館名稱：<input type="text" name="txtPlace" id="txtPlace" style="width:155px" required><br>
                *請問您場館的業態屬性：
                <select id="Venue_Att" required>
                    <option value="">請選擇</option>
                    <option value="0">俱樂部</option>
                    <option value="1">健身房</option>
                    <option value="2">游泳池</option>
                    <option value="3">高爾夫</option>
                    <option value="4">網球場</option>
                    <option value="5">羽球場</option>
                    <option value="6">團體課程</option>
                    <option value="7">舞蹈教室</option>
                    <option value="8">兒童體能</option>
                </select>
            </div>

            <div class="mobile_contactus01_text" style="text-align: left; margin-top:-180px; margin-left: 55%; margin-right: auto">
                其他洽詢內容：<br>
                <textarea name="contact_txt" id="txtContact" rows="8" cols="35"></textarea>
            </div>

            <input id="submit_LM" type="button" value="送出" onclick="DoSubmit();"><br>

            <!--<hr id="submit_thxhr" style="width:200vw; margin-left:-50%; margin-right:auto; display:none; border-top:2px solid rgb(151,242,244)">-->
            <img id="submit_thx" src="../images/_contact_us/contact_lyaout_Final_Cut-29.png" alt="璿恩感謝你的來信" style="display:none">
        </form>
        <script type="text/javascript">
            var uo = document.getElementById('subform_MainBlock');
            function DoSubmit() {

                var submit = document.getElementById('submit_LM');
                var submit_thx = document.getElementById('submit_thx');
                /*var submit_thxhr = document.getElementById('submit_thxhr');*/


                /*var CheckFlag = true;*/
                var formObj = $('#subform_MainBlock');
                var formURL = formObj.attr("action");
                var formData = new FormData();
                formData.append("tFlag", '0');
                formData.append("txtName", $('#txtName').val());
                formData.append("txtPhone", $('#txtPhone').val());
                formData.append("txtPlace", $('#txtPlace').val());
                formData.append("txtContact", $('#txtContact').val());
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
                            alert(m1[1]);
                        }
                        if (m1[0] == 0) {
                            if (submit_thx.style.display === 'none') {
                                submit_thx.style.display = 'block';
                                /*submit_thxhr.style.display = 'block';*/
                                submit.style.display = 'none';
                                setTimeout("late_go()", 5000);
                            } else {
                                submit_thx.style.display = 'none';
                                submit.style.display = 'block';
                            }
                        }
                    }
                });
                return false;
            }
            function late_go() {
                uo.submit();
            }


        </script>
    </div>
</div>

@*@RenderPage("../Shared/_Footer.vbhtml")*@
