#pragma checksum "C:\Users\StanleyYan\source\repos\BlazerCrudOnAzure\BlazorCRUD1\Shared\MainLayout.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a4fbefc18d0ea8aea1d8585a0c93a7906adbd170"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorCRUD1.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\StanleyYan\source\repos\BlazerCrudOnAzure\BlazorCRUD1\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\StanleyYan\source\repos\BlazerCrudOnAzure\BlazorCRUD1\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\StanleyYan\source\repos\BlazerCrudOnAzure\BlazorCRUD1\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\StanleyYan\source\repos\BlazerCrudOnAzure\BlazorCRUD1\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\StanleyYan\source\repos\BlazerCrudOnAzure\BlazorCRUD1\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\StanleyYan\source\repos\BlazerCrudOnAzure\BlazorCRUD1\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\StanleyYan\source\repos\BlazerCrudOnAzure\BlazorCRUD1\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\StanleyYan\source\repos\BlazerCrudOnAzure\BlazorCRUD1\_Imports.razor"
using BlazorCRUD1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\StanleyYan\source\repos\BlazerCrudOnAzure\BlazorCRUD1\_Imports.razor"
using BlazorCRUD1.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\StanleyYan\source\repos\BlazerCrudOnAzure\BlazorCRUD1\_Imports.razor"
using BlazorCRUD1.Concrete;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\StanleyYan\source\repos\BlazerCrudOnAzure\BlazorCRUD1\_Imports.razor"
using BlazorCRUD1.Contracts;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\StanleyYan\source\repos\BlazerCrudOnAzure\BlazorCRUD1\_Imports.razor"
using BlazorCRUD1.Entities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\StanleyYan\source\repos\BlazerCrudOnAzure\BlazorCRUD1\_Imports.razor"
using BlazorCRUD1.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\StanleyYan\source\repos\BlazerCrudOnAzure\BlazorCRUD1\_Imports.razor"
using BlazorCRUD1.DataAccess;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\StanleyYan\source\repos\BlazerCrudOnAzure\BlazorCRUD1\_Imports.razor"
using Blazored;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\Users\StanleyYan\source\repos\BlazerCrudOnAzure\BlazorCRUD1\_Imports.razor"
using Blazored.Modal;

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "C:\Users\StanleyYan\source\repos\BlazerCrudOnAzure\BlazorCRUD1\_Imports.razor"
using Blazored.Modal.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "C:\Users\StanleyYan\source\repos\BlazerCrudOnAzure\BlazorCRUD1\_Imports.razor"
using Microsoft.Extensions.Localization;

#line default
#line hidden
#nullable disable
    public partial class MainLayout : LayoutComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "sidebar");
            __builder.AddMarkupContent(2, "\r\n    ");
            __builder.OpenComponent<BlazorCRUD1.Shared.NavMenu>(3);
            __builder.CloseComponent();
            __builder.AddMarkupContent(4, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(5, "\r\n\r\n");
            __builder.OpenElement(6, "div");
            __builder.AddAttribute(7, "class", "main");
            __builder.AddMarkupContent(8, "\r\n    ");
            __builder.AddMarkupContent(9, "<div class=\"top-row px-4\">\r\n        \r\n        <a href=\"https://docs.microsoft.com/en-us/aspnet/\" target=\"_blank\">About</a>\r\n    </div>\r\n\r\n    ");
            __builder.OpenElement(10, "div");
            __builder.AddAttribute(11, "class", "content px-4");
            __builder.AddMarkupContent(12, "\r\n        ");
            __builder.AddContent(13, 
#nullable restore
#line 14 "C:\Users\StanleyYan\source\repos\BlazerCrudOnAzure\BlazorCRUD1\Shared\MainLayout.razor"
         Body

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(14, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(15, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(16, "\r\n");
            __builder.OpenComponent<Blazored.Modal.BlazoredModal>(17);
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
