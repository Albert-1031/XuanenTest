@Code
    Layout = "../Shared/_Header.vbhtml"
End Code

@*@RenderPage("../Shared/_Header.vbhtml")*@

<style>
    #article {
        background-image: url();
    }

        #article form {
            display: inline-block;
            width: 450px;
            height: 35px;
            text-align: left;
            background-image: url(../images/_qa/qanda_lyaout_Final_Cut-10.png);
            background-size: 450px 35px;
            background-repeat: no-repeat;
        }

            #article form input {
                height: 35px;
                background-color: transparent;
                border-style: none;
                font-size: 18px;
            }
</style>

<div id="banner">
    <img src="../images/_qa/qanda_lyaout_Final_Cut-09.png">
</div>
<div id="article">
    <div class="section01" style="margin-top:5%">
        <form action="/" method="post">
            <input type="text" id="search" name="search" value="">
            <input type="submit" id="search_send" name="search_send" value="">
        </form>
        <div class="qa_dv">
            <a href="#"><div class="qa1_btn"></div></a>
            <a href="#" style="margin-left:5%"><div class="qa2_btn"></div></a>
            <a href="#" style="margin-left:5%"><div class="qa3_btn"></div></a>
        </div><br>
        <div class="qa1_text">
            <select>
                <option value="value">問題一</option>
                <option value="value">問題二</option>
                <option value="value">問題三</option>
            </select><br>
            <textarea></textarea><br>
        </div>
    </div>
</div>


@*@RenderPage("../Shared/_Footer.vbhtml")*@
