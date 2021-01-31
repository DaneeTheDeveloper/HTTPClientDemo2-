// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace HTTPClientDemo2.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "/Users/elahnharris/Projects/HTTPClientDemo2/HTTPClientDemo2/_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/elahnharris/Projects/HTTPClientDemo2/HTTPClientDemo2/_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/elahnharris/Projects/HTTPClientDemo2/HTTPClientDemo2/_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/Users/elahnharris/Projects/HTTPClientDemo2/HTTPClientDemo2/_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/Users/elahnharris/Projects/HTTPClientDemo2/HTTPClientDemo2/_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/Users/elahnharris/Projects/HTTPClientDemo2/HTTPClientDemo2/_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "/Users/elahnharris/Projects/HTTPClientDemo2/HTTPClientDemo2/_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "/Users/elahnharris/Projects/HTTPClientDemo2/HTTPClientDemo2/_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "/Users/elahnharris/Projects/HTTPClientDemo2/HTTPClientDemo2/_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "/Users/elahnharris/Projects/HTTPClientDemo2/HTTPClientDemo2/_Imports.razor"
using HTTPClientDemo2;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "/Users/elahnharris/Projects/HTTPClientDemo2/HTTPClientDemo2/_Imports.razor"
using HTTPClientDemo2.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "/Users/elahnharris/Projects/HTTPClientDemo2/HTTPClientDemo2/_Imports.razor"
using HTTPClientDemo2.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "/Users/elahnharris/Projects/HTTPClientDemo2/HTTPClientDemo2/_Imports.razor"
using HTTPClientDemo2.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/weather")]
    public partial class WeatherData : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 40 "/Users/elahnharris/Projects/HTTPClientDemo2/HTTPClientDemo2/Pages/WeatherData.razor"
       
    WeatherForecastModel forecast;
    string errorString;

    protected override async Task OnInitializedAsync()
    {
        var request = new HttpRequestMessage(HttpMethod.Get,
            "https://www.metaweather.com/api/location/2471217");
        var client = _clientFactory.CreateClient();

        HttpResponseMessage response = await client.SendAsync(request);

        if (response.IsSuccessStatusCode)
        {
            forecast = await response.Content.ReadFromJsonAsync<WeatherForecastModel>();
            errorString = null;
        }
        else
        {
            errorString = $"There was an error getting our forecast: { response.ReasonPhrase }";
        }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IHttpClientFactory _clientFactory { get; set; }
    }
}
#pragma warning restore 1591