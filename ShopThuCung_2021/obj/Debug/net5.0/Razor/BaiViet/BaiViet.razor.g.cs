#pragma checksum "D:\2021\ShopThuCung_2021\ShopThuCung_2021\BaiViet\BaiViet.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "551d58ce0bda7acbc0993ec972274b2a9efebe64"
// <auto-generated/>
#pragma warning disable 1591
namespace ShopThuCung_2021.BaiViet
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\2021\ShopThuCung_2021\ShopThuCung_2021\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\2021\ShopThuCung_2021\ShopThuCung_2021\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\2021\ShopThuCung_2021\ShopThuCung_2021\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\2021\ShopThuCung_2021\ShopThuCung_2021\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\2021\ShopThuCung_2021\ShopThuCung_2021\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\2021\ShopThuCung_2021\ShopThuCung_2021\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\2021\ShopThuCung_2021\ShopThuCung_2021\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\2021\ShopThuCung_2021\ShopThuCung_2021\_Imports.razor"
using ShopThuCung_2021;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\2021\ShopThuCung_2021\ShopThuCung_2021\_Imports.razor"
using ShopThuCung_2021.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\2021\ShopThuCung_2021\ShopThuCung_2021\_Imports.razor"
using BlazorInputFile;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "D:\2021\ShopThuCung_2021\ShopThuCung_2021\_Imports.razor"
using System.IO;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\2021\ShopThuCung_2021\ShopThuCung_2021\BaiViet\BaiViet.razor"
using ShopThuCung_2021.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\2021\ShopThuCung_2021\ShopThuCung_2021\BaiViet\BaiViet.razor"
using Web_2021_API.Entities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\2021\ShopThuCung_2021\ShopThuCung_2021\BaiViet\BaiViet.razor"
using ShopThuCung_2021.Service;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/baiviet")]
    public partial class BaiViet : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 8 "D:\2021\ShopThuCung_2021\ShopThuCung_2021\BaiViet\BaiViet.razor"
 if (check_quyen)
{
    

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(0, @"<style scoped b-xqy2nq8hlj>
        .content {
            margin: 5rem 10%;
        }

        h4 {
            text-align: center;
        }

        .input {
            width: 100%;
            height: 3rem;
        }

        .row {
            margin: 1rem 0;
        }

        label {
            width: 100%;
        }

        .rz-multiselect, .rz-dropdown {
            height: 3rem;
        }
        .img_tieude{
            height:10rem;
        }
    </style>
    ");
            __builder.OpenElement(1, "section");
            __builder.AddAttribute(2, "class", "content");
            __builder.AddAttribute(3, "b-xqy2nq8hlj");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "container-fluid");
            __builder.AddAttribute(6, "b-xqy2nq8hlj");
            __builder.OpenElement(7, "div");
            __builder.AddAttribute(8, "class", "card card-default");
            __builder.AddAttribute(9, "b-xqy2nq8hlj");
            __builder.AddMarkupContent(10, "<div class=\"card-header\" b-xqy2nq8hlj><h4 b-xqy2nq8hlj> Đăng bài</h4></div>\r\n                ");
            __builder.OpenElement(11, "div");
            __builder.AddAttribute(12, "class", " card-body");
            __builder.AddAttribute(13, "b-xqy2nq8hlj");
            __builder.OpenElement(14, "div");
            __builder.AddAttribute(15, "class", "row");
            __builder.AddAttribute(16, "b-xqy2nq8hlj");
            __builder.AddMarkupContent(17, @"<div class=""col-md-6"" b-xqy2nq8hlj><label class=""form-control-sm"" b-xqy2nq8hlj>Tiêu đề bài viết <span style=""color:red"" b-xqy2nq8hlj>*</span></label>
                            <br b-xqy2nq8hlj>
                            <input class=""form-control form-control-sm input"" type=""text"" b-xqy2nq8hlj></div>

                        ");
            __builder.OpenElement(18, "div");
            __builder.AddAttribute(19, "class", "col-md-6");
            __builder.AddAttribute(20, "b-xqy2nq8hlj");
            __builder.AddMarkupContent(21, "<label class=\"form-control-sm\" b-xqy2nq8hlj>Loại sản phẩm <span style=\"color:red\" b-xqy2nq8hlj>*</span></label>\r\n                            ");
            __builder.OpenComponent<Radzen.Blazor.RadzenDropDown<string>>(22);
            __builder.AddAttribute(23, "Placeholder", "Chọn...");
            __builder.AddAttribute(24, "Style", "width:100%");
            __builder.AddAttribute(25, "AllowClear", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 56 "D:\2021\ShopThuCung_2021\ShopThuCung_2021\BaiViet\BaiViet.razor"
                                                                                                               true

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(26, "Data", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.IEnumerable>(
#nullable restore
#line 57 "D:\2021\ShopThuCung_2021\ShopThuCung_2021\BaiViet\BaiViet.razor"
                                                                data_LoaiSPs

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(27, "TextProperty", "ten");
            __builder.AddAttribute(28, "ValueProperty", "Value");
            __builder.AddAttribute(29, "Change", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Object>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Object>(this, 
#nullable restore
#line 58 "D:\2021\ShopThuCung_2021\ShopThuCung_2021\BaiViet\BaiViet.razor"
                                                                                                            args => OnChange_LoaiSP(args, "DropDown")

#line default
#line hidden
#nullable disable
            )));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(30, "\r\n                    ");
            __builder.OpenElement(31, "div");
            __builder.AddAttribute(32, "class", "row");
            __builder.AddAttribute(33, "b-xqy2nq8hlj");
            __builder.AddMarkupContent(34, @"<div class=""col-md-6"" b-xqy2nq8hlj><label class=""form-control-sm"" b-xqy2nq8hlj>Tên thú cưng <span style=""color:red"" b-xqy2nq8hlj>*</span></label>
                            <input class=""form-control form-control-sm input"" type=""text"" b-xqy2nq8hlj></div>

                        ");
            __builder.OpenElement(35, "div");
            __builder.AddAttribute(36, "class", "col-md-6");
            __builder.AddAttribute(37, "b-xqy2nq8hlj");
            __builder.AddMarkupContent(38, "<label class=\"form-control-sm\" b-xqy2nq8hlj>Giới tính <span style=\"color:red\" b-xqy2nq8hlj>*</span></label>\r\n                            ");
            __builder.OpenComponent<Radzen.Blazor.RadzenDropDown<string>>(39);
            __builder.AddAttribute(40, "Placeholder", "Chọn...");
            __builder.AddAttribute(41, "Style", "width:100%");
            __builder.AddAttribute(42, "AllowClear", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 71 "D:\2021\ShopThuCung_2021\ShopThuCung_2021\BaiViet\BaiViet.razor"
                                                                                                               true

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(43, "Data", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.IEnumerable>(
#nullable restore
#line 72 "D:\2021\ShopThuCung_2021\ShopThuCung_2021\BaiViet\BaiViet.razor"
                                                                data_Giongs

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(44, "TextProperty", "ten");
            __builder.AddAttribute(45, "ValueProperty", "Value");
            __builder.AddAttribute(46, "Change", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Object>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Object>(this, 
#nullable restore
#line 73 "D:\2021\ShopThuCung_2021\ShopThuCung_2021\BaiViet\BaiViet.razor"
                                                                                                            args => OnChange_Giong(args, "DropDown")

#line default
#line hidden
#nullable disable
            )));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(47, "\r\n                    ");
            __builder.AddMarkupContent(48, @"<div class=""row"" b-xqy2nq8hlj><div class=""col-md-6"" b-xqy2nq8hlj><label class=""form-control-sm"" b-xqy2nq8hlj>Màu sắc <span style=""color:red"" b-xqy2nq8hlj>*</span></label>
                            <input class=""form-control form-control-sm input"" type=""text"" b-xqy2nq8hlj></div>

                        <div class=""col-md-6"" b-xqy2nq8hlj><label class=""form-control-sm"" b-xqy2nq8hlj>Giống <span style=""color:red"" b-xqy2nq8hlj>*</span></label>
                            <input class=""form-control form-control-sm input"" type=""text"" b-xqy2nq8hlj></div></div>

                    ");
            __builder.AddMarkupContent(49, @"<div class=""row"" b-xqy2nq8hlj><div class=""col-md-6"" b-xqy2nq8hlj><label class=""form-control-sm"" b-xqy2nq8hlj>Tuổi <span style=""color:red"" b-xqy2nq8hlj>*</span></label>
                            <input class=""form-control form-control-sm input"" type=""text"" b-xqy2nq8hlj></div>

                        <div class=""col-md-6"" b-xqy2nq8hlj><label class=""form-control-sm"" b-xqy2nq8hlj>Giá <span style=""color:red"" b-xqy2nq8hlj>*</span></label>
                            <input class=""form-control form-control-sm input"" type=""text"" b-xqy2nq8hlj></div></div>


                    ");
            __builder.AddMarkupContent(50, @"<div class=""row"" b-xqy2nq8hlj><div class=""col-md-6"" b-xqy2nq8hlj><label class=""form-control-sm"" b-xqy2nq8hlj>Địa chỉ liên hệ  <span style=""color:red"" b-xqy2nq8hlj>*</span></label>
                            <input class=""form-control form-control-sm input"" type=""text"" b-xqy2nq8hlj></div>

                        <div class=""col-md-6"" b-xqy2nq8hlj><label class=""form-control-sm"" b-xqy2nq8hlj>Số điện thoại liên hệ <span style=""color:red"" b-xqy2nq8hlj>*</span></label>
                            <input class=""form-control form-control-sm input"" type=""text"" b-xqy2nq8hlj></div></div>
                    ");
            __builder.OpenElement(51, "div");
            __builder.AddAttribute(52, "class", "row");
            __builder.AddAttribute(53, "b-xqy2nq8hlj");
            __builder.OpenElement(54, "div");
            __builder.AddAttribute(55, "class", "col-md-6");
            __builder.AddAttribute(56, "b-xqy2nq8hlj");
            __builder.AddMarkupContent(57, "<label class=\"form-control-sm\" b-xqy2nq8hlj>Thêm ảnh cho tiêu đề(1 ảnh) <span style=\"color:red\" b-xqy2nq8hlj>*</span></label>\r\n                            ");
            __builder.OpenComponent<BlazorInputFile.InputFile>(58);
            __builder.AddAttribute(59, "OnChange", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<BlazorInputFile.IFileListEntry[]>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<BlazorInputFile.IFileListEntry[]>(this, 
#nullable restore
#line 132 "D:\2021\ShopThuCung_2021\ShopThuCung_2021\BaiViet\BaiViet.razor"
                                                 SelectFile_tieude

#line default
#line hidden
#nullable disable
            )));
            __builder.CloseComponent();
            __builder.AddMarkupContent(60, "\r\n                            <hr b-xqy2nq8hlj>");
#nullable restore
#line 134 "D:\2021\ShopThuCung_2021\ShopThuCung_2021\BaiViet\BaiViet.razor"
                             if (file != null)
                            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(61, "img");
            __builder.AddAttribute(62, "src", 
#nullable restore
#line 136 "D:\2021\ShopThuCung_2021\ShopThuCung_2021\BaiViet\BaiViet.razor"
                                           path_tieude

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(63, "alt", "...");
            __builder.AddAttribute(64, "b-xqy2nq8hlj");
            __builder.CloseElement();
            __builder.AddMarkupContent(65, "\r\n                                <br b-xqy2nq8hlj>");
#nullable restore
#line 138 "D:\2021\ShopThuCung_2021\ShopThuCung_2021\BaiViet\BaiViet.razor"

                            }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(66, "\r\n\r\n                        ");
            __builder.OpenElement(67, "div");
            __builder.AddAttribute(68, "class", "col-md-6");
            __builder.AddAttribute(69, "b-xqy2nq8hlj");
            __builder.AddMarkupContent(70, "<label class=\"form-control-sm\" b-xqy2nq8hlj>Thêm ảnh mô tả chi tiết(có thể nhiểu ảnh) <span style=\"color:red\" b-xqy2nq8hlj>*</span></label>\r\n                            ");
            __builder.OpenComponent<BlazorInputFile.InputFile>(71);
            __builder.AddAttribute(72, "Multiple", "true");
            __builder.AddAttribute(73, "OnChange", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<BlazorInputFile.IFileListEntry[]>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<BlazorInputFile.IFileListEntry[]>(this, 
#nullable restore
#line 145 "D:\2021\ShopThuCung_2021\ShopThuCung_2021\BaiViet\BaiViet.razor"
                                                                 SelectFile

#line default
#line hidden
#nullable disable
            )));
            __builder.CloseComponent();
            __builder.AddMarkupContent(74, "\r\n                            <hr b-xqy2nq8hlj>");
#nullable restore
#line 147 "D:\2021\ShopThuCung_2021\ShopThuCung_2021\BaiViet\BaiViet.razor"
                             foreach (var item in path_img_mota)
                            {
                                var imgg = "/Upload/" + item;
                                

#line default
#line hidden
#nullable disable
#nullable restore
#line 150 "D:\2021\ShopThuCung_2021\ShopThuCung_2021\BaiViet\BaiViet.razor"
                                 if (file != null)
                                {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(75, "img");
            __builder.AddAttribute(76, "class", "img_tieude");
            __builder.AddAttribute(77, "src", 
#nullable restore
#line 152 "D:\2021\ShopThuCung_2021\ShopThuCung_2021\BaiViet\BaiViet.razor"
                                                                  imgg

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(78, "alt", "...");
            __builder.AddAttribute(79, "b-xqy2nq8hlj");
            __builder.CloseElement();
#nullable restore
#line 153 "D:\2021\ShopThuCung_2021\ShopThuCung_2021\BaiViet\BaiViet.razor"

                                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 154 "D:\2021\ShopThuCung_2021\ShopThuCung_2021\BaiViet\BaiViet.razor"
                                 
                            }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(80, "\r\n                    ");
            __builder.AddMarkupContent(81, @"<div class=""row"" b-xqy2nq8hlj><label class=""form-control-sm"" b-xqy2nq8hlj>Mô tả thêm <span style=""color:red"" b-xqy2nq8hlj>*</span></label>
                        <textarea class=""form-control form-control-sm input"" type=""text"" b-xqy2nq8hlj></textarea></div>
                    ");
            __builder.AddMarkupContent(82, "<div style=\"float:right\" class=\"row\" b-xqy2nq8hlj><button type=\"button\" class=\"btn btn-primary\" b-xqy2nq8hlj>Lưu</button></div>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 172 "D:\2021\ShopThuCung_2021\ShopThuCung_2021\BaiViet\BaiViet.razor"








}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 182 "D:\2021\ShopThuCung_2021\ShopThuCung_2021\BaiViet\BaiViet.razor"
       

    bool check_quyen = false;
    string quyen = "";
    int progress;
    string info;

    IEnumerable<BaiViet> BaiViets { get; set; }
    public class Data_Giong
    {
        public string ten { get; set; }
        public string Value { get; set; }
    }
    //

    //
    List<Data_Giong> data_Giongs = new List<Data_Giong>()
{
        new Data_Giong{ten = "Đực",Value = "D"},
        new Data_Giong{ten = "Cái",Value ="C"}

    };
    void OnChange_Giong(object Value, string name)
    {


    }
    //loại sp
    public class Data_LoaiSP
    {
        public string ten { get; set; }
        public string Value { get; set; }
    }

    List<Data_LoaiSP> data_LoaiSPs = new List<Data_LoaiSP>()
{
        new Data_LoaiSP{ten = "Chó cảnh",Value = "C"},
        new Data_LoaiSP{ten = "Mèo cảnh",Value ="M"},
           new Data_LoaiSP{ten = "Loại khác",Value ="LK"}

    };
    void OnChange_LoaiSP(object Value, string name)
    {


    }
    protected override async Task OnAfterRenderAsync(bool firstRender)
    {

        if (firstRender)
        {


            quyen = await session.Get_Quyen();
            if (quyen != "Admin")
            {
                nv.NavigateTo("/");
            }
            else
            {
                check_quyen = true;
            }

        }
        StateHasChanged();
    }
    /// <summary>
    IFileListEntry file;
    string path_noianh = "+_+";// nối path khi chọn muti ảnh
    string path_mota = ""; // lấy cái này lưu db
    string[] path_img_mota = new string[] { };
    public async Task SelectFile(IFileListEntry[] files)
    {
        for (int i = 0; i < files.Length; i++)
        {
            file = files[i];
            if (file != null)
            {
                await fileUpload.UpLoadAsync(file);
                path_mota +=  file.Name + path_noianh;
            }
            path_img_mota = path_mota.Split("+_+");
        }
        path_img_mota = path_img_mota.Take(path_img_mota.Count() - 1).ToArray();

    }
    /// </summary>

    ///
    string path_tieude = "";
    public async Task SelectFile_tieude(IFileListEntry[] files)
    {
        file = files.FirstOrDefault();
        if (file != null)
        {
            await fileUpload.UpLoadAsync(file);
            path_tieude = "/Upload/" + file.Name;
        }
    }


    void OnPaste()
    {

    }

    void OnChange(string html)
    {


        void OnExecute()
        {

        }


    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IFileUpload fileUpload { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager nv { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ShopThuCung_2021.Data.Session session { get; set; }
    }
}
#pragma warning restore 1591
