#pragma checksum "/Users/chansum/Documents/GitHub/BlazerCrudOnAzure/BlazorCRUD1/Shared/MainLayout.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2e7044258811cb9cbc87f366ff55c5bc13a9b711"
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
#line 1 "/Users/chansum/Documents/GitHub/BlazerCrudOnAzure/BlazorCRUD1/_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/chansum/Documents/GitHub/BlazerCrudOnAzure/BlazorCRUD1/_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/chansum/Documents/GitHub/BlazerCrudOnAzure/BlazorCRUD1/_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/Users/chansum/Documents/GitHub/BlazerCrudOnAzure/BlazorCRUD1/_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/Users/chansum/Documents/GitHub/BlazerCrudOnAzure/BlazorCRUD1/_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/Users/chansum/Documents/GitHub/BlazerCrudOnAzure/BlazorCRUD1/_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "/Users/chansum/Documents/GitHub/BlazerCrudOnAzure/BlazorCRUD1/_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "/Users/chansum/Documents/GitHub/BlazerCrudOnAzure/BlazorCRUD1/_Imports.razor"
using BlazorCRUD1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "/Users/chansum/Documents/GitHub/BlazerCrudOnAzure/BlazorCRUD1/_Imports.razor"
using BlazorCRUD1.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "/Users/chansum/Documents/GitHub/BlazerCrudOnAzure/BlazorCRUD1/_Imports.razor"
using BlazorCRUD1.Concrete;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "/Users/chansum/Documents/GitHub/BlazerCrudOnAzure/BlazorCRUD1/_Imports.razor"
using BlazorCRUD1.Contracts;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "/Users/chansum/Documents/GitHub/BlazerCrudOnAzure/BlazorCRUD1/_Imports.razor"
using BlazorCRUD1.Entities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "/Users/chansum/Documents/GitHub/BlazerCrudOnAzure/BlazorCRUD1/_Imports.razor"
using BlazorCRUD1.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "/Users/chansum/Documents/GitHub/BlazerCrudOnAzure/BlazorCRUD1/_Imports.razor"
using BlazorCRUD1.DataAccess;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "/Users/chansum/Documents/GitHub/BlazerCrudOnAzure/BlazorCRUD1/_Imports.razor"
using Blazored;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "/Users/chansum/Documents/GitHub/BlazerCrudOnAzure/BlazorCRUD1/_Imports.razor"
using Blazored.Modal;

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "/Users/chansum/Documents/GitHub/BlazerCrudOnAzure/BlazorCRUD1/_Imports.razor"
using Blazored.Modal.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "/Users/chansum/Documents/GitHub/BlazerCrudOnAzure/BlazorCRUD1/_Imports.razor"
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
            __builder.AddMarkupContent(2, "\n    ");
            __builder.OpenComponent<BlazorCRUD1.Shared.NavMenu>(3);
            __builder.CloseComponent();
            __builder.AddMarkupContent(4, "\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(5, "\n\n");
            __builder.OpenElement(6, "div");
            __builder.AddAttribute(7, "class", "main");
            __builder.AddMarkupContent(8, "\n    ");
            __builder.AddMarkupContent(9, @"<div class=""top-row px-4"">
        
        <a href=""https://docs.microsoft.com/en-us/aspnet/"" target=""_blank"">Register</a>
        <a href=""https://docs.microsoft.com/en-us/aspnet/"" target=""_blank"">Login</a>
        <a href=""https://docs.microsoft.com/en-us/aspnet/"" target=""_blank"">About</a>
    </div>

    ");
            __builder.OpenElement(10, "div");
            __builder.AddAttribute(11, "class", "content px-4");
            __builder.AddMarkupContent(12, "\n        ");
            __builder.AddContent(13, 
#nullable restore
#line 16 "/Users/chansum/Documents/GitHub/BlazerCrudOnAzure/BlazorCRUD1/Shared/MainLayout.razor"
         Body

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(14, "\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(15, "\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(16, "\n");
            __builder.OpenComponent<Blazored.Modal.BlazoredModal>(17);
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
