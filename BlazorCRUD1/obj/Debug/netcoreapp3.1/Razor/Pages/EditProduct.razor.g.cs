#pragma checksum "/Users/chansum/Documents/GitHub/BlazerCrudOnAzure/BlazorCRUD1/Pages/EditProduct.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a209cfd8510b0a4c4c66c72562a6e74f2bc59cb7"
// <auto-generated/>
#pragma warning disable 1591
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/editProduct/{ID}")]
    public partial class EditProduct : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "row");
            __builder.AddMarkupContent(2, "\n    ");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "col-md-4");
            __builder.AddMarkupContent(5, "\n        ");
            __builder.OpenElement(6, "form");
            __builder.AddMarkupContent(7, "\n            ");
            __builder.OpenElement(8, "div");
            __builder.AddAttribute(9, "class", "form-group");
            __builder.AddMarkupContent(10, "\n                ");
            __builder.OpenElement(11, "label");
            __builder.AddAttribute(12, "for", "Name");
            __builder.AddAttribute(13, "class", "control-label");
            __builder.AddContent(14, 
#nullable restore
#line 9 "/Users/chansum/Documents/GitHub/BlazerCrudOnAzure/BlazorCRUD1/Pages/EditProduct.razor"
                                                         localizer["productName"]

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(15, "\n                ");
            __builder.OpenElement(16, "input");
            __builder.AddAttribute(17, "for", "Name");
            __builder.AddAttribute(18, "class", "form-control");
            __builder.AddAttribute(19, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 10 "/Users/chansum/Documents/GitHub/BlazerCrudOnAzure/BlazorCRUD1/Pages/EditProduct.razor"
                                                                     product.ProductName

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(20, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => product.ProductName = __value, product.ProductName));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "\n\n                ");
            __builder.OpenElement(22, "label");
            __builder.AddAttribute(23, "for", "Name");
            __builder.AddAttribute(24, "class", "control-label");
            __builder.AddContent(25, 
#nullable restore
#line 12 "/Users/chansum/Documents/GitHub/BlazerCrudOnAzure/BlazorCRUD1/Pages/EditProduct.razor"
                                                         localizer["productPrice"]

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(26, "\n                ");
            __builder.OpenElement(27, "input");
            __builder.AddAttribute(28, "for", "Name");
            __builder.AddAttribute(29, "type", "number");
            __builder.AddAttribute(30, "class", "form-control");
            __builder.AddAttribute(31, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 13 "/Users/chansum/Documents/GitHub/BlazerCrudOnAzure/BlazorCRUD1/Pages/EditProduct.razor"
                                                                                   product.ProductPrice

#line default
#line hidden
#nullable disable
            , culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.AddAttribute(32, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => product.ProductPrice = __value, product.ProductPrice, culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(33, "\n\n                ");
            __builder.OpenElement(34, "label");
            __builder.AddAttribute(35, "for", "Name");
            __builder.AddAttribute(36, "class", "control-label");
            __builder.AddContent(37, 
#nullable restore
#line 15 "/Users/chansum/Documents/GitHub/BlazerCrudOnAzure/BlazorCRUD1/Pages/EditProduct.razor"
                                                         localizer["productOrigin"]

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(38, "\n                ");
            __builder.OpenElement(39, "input");
            __builder.AddAttribute(40, "for", "Name");
            __builder.AddAttribute(41, "class", "form-control");
            __builder.AddAttribute(42, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 16 "/Users/chansum/Documents/GitHub/BlazerCrudOnAzure/BlazorCRUD1/Pages/EditProduct.razor"
                                                                     product.ProductOrigin

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(43, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => product.ProductOrigin = __value, product.ProductOrigin));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(44, "\n\n                ");
            __builder.OpenElement(45, "label");
            __builder.AddAttribute(46, "for", "Name");
            __builder.AddAttribute(47, "class", "control-label");
            __builder.AddContent(48, 
#nullable restore
#line 18 "/Users/chansum/Documents/GitHub/BlazerCrudOnAzure/BlazorCRUD1/Pages/EditProduct.razor"
                                                         localizer["productDetails"]

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(49, "\n                ");
            __builder.OpenElement(50, "input");
            __builder.AddAttribute(51, "for", "Name");
            __builder.AddAttribute(52, "class", "form-control");
            __builder.AddAttribute(53, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 19 "/Users/chansum/Documents/GitHub/BlazerCrudOnAzure/BlazorCRUD1/Pages/EditProduct.razor"
                                                                     product.ProductDetails

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(54, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => product.ProductDetails = __value, product.ProductDetails));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(55, "\n\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(56, "\n            ");
            __builder.OpenElement(57, "div");
            __builder.AddAttribute(58, "class", "form-group");
            __builder.AddMarkupContent(59, "\n                ");
            __builder.OpenElement(60, "button");
            __builder.AddAttribute(61, "type", "button");
            __builder.AddAttribute(62, "class", "btn btn-primary");
            __builder.AddAttribute(63, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 23 "/Users/chansum/Documents/GitHub/BlazerCrudOnAzure/BlazorCRUD1/Pages/EditProduct.razor"
                                                                        () => ConfirmedUpdate()

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(64, 
#nullable restore
#line 23 "/Users/chansum/Documents/GitHub/BlazerCrudOnAzure/BlazorCRUD1/Pages/EditProduct.razor"
                                                                                                  localizer["confirm"]

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(65, "\n                ");
            __builder.OpenElement(66, "button");
            __builder.AddAttribute(67, "type", "button");
            __builder.AddAttribute(68, "class", "btn btn-danger");
            __builder.AddAttribute(69, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 24 "/Users/chansum/Documents/GitHub/BlazerCrudOnAzure/BlazorCRUD1/Pages/EditProduct.razor"
                                                                       () => Cancel()

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(70, 
#nullable restore
#line 24 "/Users/chansum/Documents/GitHub/BlazerCrudOnAzure/BlazorCRUD1/Pages/EditProduct.razor"
                                                                                        localizer["cancel"]

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(71, "\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(72, "\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(73, "\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(74, "\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 30 "/Users/chansum/Documents/GitHub/BlazerCrudOnAzure/BlazorCRUD1/Pages/EditProduct.razor"
        

    [CascadingParameter] BlazoredModalInstance BlazoredModal { get; set; }
    [Parameter] public Product product { get; set; }

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
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IStringLocalizer<EditProduct> localizer { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Microsoft.AspNetCore.Components.NavigationManager navigationManager { get; set; }
    }
}
#pragma warning restore 1591
