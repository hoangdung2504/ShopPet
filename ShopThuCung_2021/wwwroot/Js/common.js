const { NU } = require("../plugins/pdfmake/pdfmake");

var gobjid = '';
var focusControlID = null;
var type_modal = '';



function openDialog(objid, url, type_modal) {
    gobjid = objid;
    initPopup(url, type_modal);
    $("#exampleModal").modal();

}
//
function Save_Data_DB() {
    alert("Xử lý thành công")
}

function Err_login(Obj)
{
    var code = Obj;
    if (code === "001") {
        alert("tài khoản không tồn tại")
    }
   else if (code === "002") {
        alert("không đúng mật khẩu")
    }
   else if (code === "003") {
        alert("Đăng nhập quá số lần qui định")
    } 
    else if (code === "004") {
        alert("Tài khoản bị đóng")
    } 
    else if (code === "005") {
        alert("Lỗi kết nối")
    } 
}


 function Err_change_profile(pass, tendangnhap, fullname, email, sdt,quyen) {
        
     if (pass == "" || pass == null || pass.length < 6) {
         alert("Mật khẩu tối thiểu 6 kí tự")
     }
     else if (tendangnhap === "" || tendangnhap == null) {
         alert("Tên đăng nhập không được để trống")
     }
     else if (fullname === "" || fullname == null) {
         alert("Họ tên không được để trống")
     }
     else if (email === "" || email == null) {
         alert("Email không được để trống")
     }
     else if (sdt === "" || sdt == null) {
         alert("Sdt không được để trống")

     }
     else if (quyen === "" || quyen == null) {
         alert("Chọn quyền ?")
     }
}

function Err_Dangki(Obj) {
    var code = Obj;
    if (code === "001") {
        alert("tài khoản đã tồn tại")
    }
    else if (code === "002") {
        alert("Mật khẩu tối thiểu 6 kí tự")
    }
    else if (code === "003") {
        alert("Email đã tồn tại")
    }
}

function myFunction() {
    document.getElementById("myDropdown").classList.toggle("show");
}

// Close the dropdown if the user clicks outside of it
window.onclick = function (event) {
    if (!event.target.matches('.dropbtn')) {
        var dropdowns = document.getElementsByClassName("dropdown-content");
        var i;
        for (i = 0; i < dropdowns.length; i++) {
            var openDropdown = dropdowns[i];
            if (openDropdown.classList.contains('show')) {
                openDropdown.classList.remove('show');
            }
        }
    }
}

function identifyBrowser() {
    var sBrowser, sUsrAg = navigator.userAgent;

    if (sUsrAg.indexOf("Firefox") > -1) {   // "Mozilla/5.0 (X11; Ubuntu; Linux x86_64; rv:61.0) Gecko/20100101 Firefox/61.0"
        sBrowser = "Mozilla Firefox";
    } else if (sUsrAg.indexOf("SamsungBrowser") > -1) {     // "Mozilla/5.0 (Linux; Android 9; SAMSUNG SM-G955F Build/PPR1.180610.011) AppleWebKit/537.36 (KHTML, like Gecko) SamsungBrowser/9.4 Chrome/67.0.3396.87 Mobile Safari/537.36
        sBrowser = "Samsung Internet";
    } else if (sUsrAg.indexOf("Opera") > -1 || sUsrAg.indexOf("OPR") > -1) {         // "Mozilla/5.0 (Macintosh; Intel Mac OS X 10_14_0) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/70.0.3538.102 Safari/537.36 OPR/57.0.3098.106"
        sBrowser = "Opera";
    } else if (sUsrAg.indexOf("Trident") > -1) {            // "Mozilla/5.0 (Windows NT 10.0; WOW64; Trident/7.0; .NET4.0C; .NET4.0E; Zoom 3.6.0; wbx 1.0.0; rv:11.0) like Gecko"
        sBrowser = "Microsoft Internet Explorer";
    } else if (sUsrAg.indexOf("Edge") > -1) {               // "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/58.0.3029.110 Safari/537.36 Edge/16.16299"
        sBrowser = "Microsoft Edge";
    } else if (sUsrAg.indexOf("Chrome") > -1) {             // "Mozilla/5.0 (X11; Linux x86_64) AppleWebKit/537.36 (KHTML, like Gecko) Ubuntu Chromium/66.0.3359.181 Chrome/66.0.3359.181 Safari/537.36"
        sBrowser = "Google Chrome or Chromium";
    } else if (sUsrAg.indexOf("Safari") > -1) {             // "Mozilla/5.0 (iPhone; CPU iPhone OS 11_4 like Mac OS X) AppleWebKit/605.1.15 (KHTML, like Gecko) Version/11.0 Mobile/15E148 Safari/604.1 980x1306"
        sBrowser = "Apple Safari";
    } else {
        sBrowser = "unknown";
    }

    return sBrowser;
}

function BlazorDownloadFile(filename, contentType, content) {
    // Blazor marshall byte[] to a base64 string, so we first need to convert the string (content) to a Uint8Array to create the File
    const data = base64DecToArr(content);

    // Create the URL
    const file = new File([data], filename, { type: contentType });
    const exportUrl = URL.createObjectURL(file);

    // Create the <a> element and click on it
    const a = document.createElement("a");
    document.body.appendChild(a);
    a.href = exportUrl;
    a.download = filename;
    a.target = "_self";
    a.click();

    // We don't need to keep the url, let's release the memory
    // On Safari it seems you need to comment this line... (please let me know if you know why)
    URL.revokeObjectURL(exportUrl);
}

// Convert a base64 string to a Uint8Array. This is needed to create a blob object from the base64 string.
// The code comes from: https://developer.mozilla.org/fr/docs/Web/API/WindowBase64/D%C3%A9coder_encoder_en_base64
function b64ToUint6(nChr) {
    return nChr > 64 && nChr < 91 ? nChr - 65 : nChr > 96 && nChr < 123 ? nChr - 71 : nChr > 47 && nChr < 58 ? nChr + 4 : nChr === 43 ? 62 : nChr === 47 ? 63 : 0;
}

function base64DecToArr(sBase64, nBlocksSize) {
    var
        sB64Enc = sBase64.replace(/[^A-Za-z0-9\+\/]/g, ""),
        nInLen = sB64Enc.length,
        nOutLen = nBlocksSize ? Math.ceil((nInLen * 3 + 1 >> 2) / nBlocksSize) * nBlocksSize : nInLen * 3 + 1 >> 2,
        taBytes = new Uint8Array(nOutLen);

    for (var nMod3, nMod4, nUint24 = 0, nOutIdx = 0, nInIdx = 0; nInIdx < nInLen; nInIdx++) {
        nMod4 = nInIdx & 3;
        nUint24 |= b64ToUint6(sB64Enc.charCodeAt(nInIdx)) << 18 - 6 * nMod4;
        if (nMod4 === 3 || nInLen - nInIdx === 1) {
            for (nMod3 = 0; nMod3 < 3 && nOutIdx < nOutLen; nMod3++, nOutIdx++) {
                taBytes[nOutIdx] = nUint24 >>> (16 >>> nMod3 & 24) & 255;
            }
            nUint24 = 0;
        }
    }
    return taBytes;
}
function BlazorDownloadFileFast(name, contentType, content) {
    // Convert the parameters to actual JS types
    const nameStr = BINDING.conv_string(name);
    const contentTypeStr = BINDING.conv_string(contentType);
    const contentArray = Blazor.platform.toUint8Array(content);

    // Create the URL
    const file = new File([contentArray], nameStr, { type: contentTypeStr });
    const exportUrl = URL.createObjectURL(file);

    // Create the <a> element and click on it
    const a = document.createElement("a");
    document.body.appendChild(a);
    a.href = exportUrl;
    a.download = nameStr;
    a.target = "_self";
    a.click();

    // We don't need to keep the url, let's release the memory
    // On Safari it seems you need to comment this line... (please let me know if you know why)
    URL.revokeObjectURL(exportUrl);
}

// Mở modal 
function Open_modal(obj) {
    var id_modal = obj.id_modal;
    $('#' + id_modal + '').modal();
}
// Đóng modal
function Close_modal(obj) {
    var id_modal = obj.id_modal;
    $('#' + id_modal + '').modal('hide');
}
// Kết quả insert
function Result_insert(obj) {
    if (typeof obj.value === "undefined") {
        var res = obj.result.value; // Bat dong bo
    }
    else {
        var res = obj.value; // Dong bo
    }
    var result = res.result;
    var content = res.alert;
    var id_modal = res.id_modal;
    if (result) {
        $('#' + id_modal + '').modal('hide');
        alert(content);
    }
    else {
        alert(content);
    }
}
// Kết quả  update
function Result_update(obj) {
    if (typeof obj.value === "undefined") {

        var res = obj.result.value;
    }
    else {
        var res = obj.value;
    }
    var result = res.result;
    var content = res.alert;
    var id_modal = res.id_modal;
    if (result) {
        $('#' + id_modal + '').modal('hide');
        alert(content);
    }
    else {
        alert(content);
    }
}
// Kết quả xóa 
function Result_delete(obj) {
    if (typeof obj.value === "undefined") {
        var res = obj.result.value;
    }
    else {
        var res = obj.value;
    }
    var result = res.result;
    var content = res.alert;
    var id_modal = res.id_modal;
    if (result) {
        $('#' + id_modal + '').modal('hide');
        alert(content);
    }
    else {
        $('#' + id_modal + '').modal('hide');
        alert(content);
    }
}
// Hiển thị modal loading
function Open_modal_loading() {
    $("#modal_loading").modal();
}
function Close_modal_loading() {
    $("#modal_loading").modal('hide');
}

// Hiển thị alert
function AlertMessage(res) {
    if (res.result) {
        alert(res.alert);
    }
    else {
        alert(res.alert);
    }
}

// Hiển thị alert
function ReloadPage() {
    location.reload();
}