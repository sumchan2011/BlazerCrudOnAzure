#pragma checksum "/Users/chansum/Documents/GitHub/BlazerCrudOnAzure/BlazorCRUD1/Pages/AddProduct.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c45c37af6af6432488b1805bf976bdeead661b39"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace BlazorCRUD1.Pages
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/addProduct")]
    public partial class AddProduct : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 31 "/Users/chansum/Documents/GitHub/BlazerCrudOnAzure/BlazorCRUD1/Pages/AddProduct.razor"
       
    [CascadingParameter] BlazoredModalInstance BlazoredModal { get; set; }
    Product product = new Product();

    void ConfirmedUpdate()
    {
        BlazoredModal.Close(ModalResult.Ok(product));
    }

    void Cancel()
    {
        BlazoredModal.Cancel();
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IStringLocalizer<AddProduct> localizer { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Microsoft.AspNetCore.Components.NavigationManager navigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IProductManager productManager { get; set; }
    }
}
#pragma warning restore 1591
