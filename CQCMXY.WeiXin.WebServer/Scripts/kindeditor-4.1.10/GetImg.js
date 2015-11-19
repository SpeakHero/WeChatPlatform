//<table>
//        <tr>
//            <td class="lyTxtRight">
//                详细内容：</td>
//            <td class="nobordertd edit">
//                <!--editor begin-->
//                <asp:TextBox ID="editHtml" runat="server"></asp:TextBox>
//                <input type="hidden" id="editAllPic" name="editAllPic" value="" />
//                <input type="hidden" id="ImgSrc" name="ImgSrc" value="" />
//                <!--editor end-->
//            </td>
//        </tr>
//        <tr>
//            <td class="lyTxtRight">
//                首页展示图片：</td>
//            <td>
//                <div id="picList">
//                    暂无图片(从上传图片中选择首页要展示的图片)</div>
//            </td>
//        </tr>
//    </table>
//说明：

//　　1、kindeditor_4.0.5_min.js是编辑器配置js

//　　2、lang_zh.js是编辑器语言js

//　　3、edit_set.js是在上传图片中选一张为焦点图片，我自己写的

//　　4、ID="editAllPic"的input保存所有的图片地址，用|分割

//　　5、ID="ImgSrc"的input保存一张选中的焦点图片地址

window.onerror = function () {
    return true;
}
function getID(objId) {
    return document.getElementById(objId);
}
function selectShowPic(obj) {
    getID("ImgSrc").value = obj.value;
    //alert(getID("ImgSrc").value);
}
//editor onchange
function createPicList(editValue) {
    var reg = new RegExp("img[^>]*src=\"([^\"].*?)\"", "ig");
    if (reg.test(editValue)) {
        reg = new RegExp("img[^>]*src=\"([^\"].*?)\"", "ig");
        html = "<table style='background-color: #F7FAFF;border:1px solid #D3E7F6;'>";
        var i = 0;
        var allPic = "";
        while (reg.exec(editValue) != null) {
            b = RegExp.$1;
            if (i % 7 == 0) {
                html += "<tr>";
            }

            html += "<td><input value='" + b + "' type=radio name='mrtp' onclick='selectShowPic(this);' ><img src=" + b + " style='width:50px;height:50px;'></td>";

            if (i % 7 == 6) {
                html += "</tr>";
            }
            i++;
            if (i == 1) {
                allPic = b;
            } else {
                allPic = allPic + "|" + b;
            }
        }
        if (i % 7 != 6)
        { html += "</tr>"; }
        html += "</table>";
        if (getID("editAllPic")) {
            if (getID("editAllPic").value != allPic) {
                getID("editAllPic").value = allPic;
                if (getID("picList")) {
                    getID("picList").innerHTML = html;
                }
            }
        }
        if (getID("ImgSrc")) {
            var obj = document.getElementsByName("mrtp");
            var showpic = getID("ImgSrc").value;
            var ischecked = false;
            if (showpic != "") {
                for (var i = 0; i < obj.length; i++) {
                    if (obj[i].value == showpic) {
                        obj[i].checked = true;
                        getID("ImgSrc").value = obj[i].value;
                        ischecked = true;
                        break;
                    }
                }
            }
            if (obj.length > 0 && !ischecked) {
                obj[0].checked = true;
                getID("ImgSrc").value = obj[0].value;
            }
        }
    } else {
        if (getID("editAllPic")) {
            getID("editAllPic").value = "";
        }

        if (getID("ImgSrc")) {
            getID("ImgSrc").value = "";
        }

        getID("picList").innerHTML = "暂无图片";
    }

}