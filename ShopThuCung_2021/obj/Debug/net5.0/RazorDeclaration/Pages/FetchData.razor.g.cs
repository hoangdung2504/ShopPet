// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace ShopThuCung_2021.Pages
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
#line 3 "D:\2021\ShopThuCung_2021\ShopThuCung_2021\Pages\FetchData.razor"
using ShopThuCung_2021.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/fetchdata")]
    public partial class FetchData : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 39 "D:\2021\ShopThuCung_2021\ShopThuCung_2021\Pages\FetchData.razor"
       
    private WeatherForecast[] forecasts;

    protected override async Task OnInitializedAsync()
    {
        forecasts = await ForecastService.GetForecastAsync(DateTime.Now);
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private WeatherForecastService ForecastService { get; set; }
    }
}
#pragma warning restore 1591
