#pragma checksum "/Users/chansum/Documents/GitHub/BlazerCrudOnAzure/BlazorCRUD1/Pages/EditArticle.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bf59f2be8406980be466f1d1a73c159cf695f03a"
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/editArticle/{ID}")]
    public partial class EditArticle : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "row");
            __builder.AddMarkupContent(2, "\n        ");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "col-md-4");
            __builder.AddMarkupContent(5, "\n            ");
            __builder.OpenElement(6, "form");
            __builder.AddMarkupContent(7, "\n                ");
            __builder.OpenElement(8, "div");
            __builder.AddAttribute(9, "class", "form-group");
            __builder.AddMarkupContent(10, "\n                    ");
            __builder.AddMarkupContent(11, "<label for=\"Name\" class=\"control-label\">Name</label>\n                    ");
            __builder.OpenElement(12, "input");
            __builder.AddAttribute(13, "for", "Name");
            __builder.AddAttribute(14, "class", "form-control");
            __builder.AddAttribute(15, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 10 "/Users/chansum/Documents/GitHub/BlazerCrudOnAzure/BlazorCRUD1/Pages/EditArticle.razor"
                                                                         articleEntity.Title

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(16, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => articleEntity.Title = __value, articleEntity.Title));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(17, "\n                    ");
            __builder.OpenElement(18, "input");
            __builder.AddAttribute(19, "type", "hidden");
            __builder.AddAttribute(20, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 11 "/Users/chansum/Documents/GitHub/BlazerCrudOnAzure/BlazorCRUD1/Pages/EditArticle.razor"
                                                        articleEntity.ID

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(21, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => articleEntity.ID = __value, articleEntity.ID));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(22, "\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(23, "\n                ");
            __builder.OpenElement(24, "div");
            __builder.AddAttribute(25, "class", "form-group");
            __builder.AddMarkupContent(26, "\n                    ");
            __builder.OpenElement(27, "button");
            __builder.AddAttribute(28, "type", "button");
            __builder.AddAttribute(29, "class", "btn btn-primary");
            __builder.AddAttribute(30, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 14 "/Users/chansum/Documents/GitHub/BlazerCrudOnAzure/BlazorCRUD1/Pages/EditArticle.razor"
                                                                            () => UpdateArticle()

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(31, "Save");
            __builder.CloseElement();
            __builder.AddMarkupContent(32, "\n                    ");
            __builder.OpenElement(33, "button");
            __builder.AddAttribute(34, "type", "button");
            __builder.AddAttribute(35, "class", "btn btn-danger");
            __builder.AddAttribute(36, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 15 "/Users/chansum/Documents/GitHub/BlazerCrudOnAzure/BlazorCRUD1/Pages/EditArticle.razor"
                                                                           () => cancel()

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(37, "Cancel");
            __builder.CloseElement();
            __builder.AddMarkupContent(38, "\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(39, "\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(40, "\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(41, "\n    ");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 21 "/Users/chansum/Documents/GitHub/BlazerCrudOnAzure/BlazorCRUD1/Pages/EditArticle.razor"
        

    [Parameter]
    public string ID { get; set; }

    Article articleEntity = new Article();

    protected override async Task OnInitializedAsync()
    {
       articleEntity = await articleManager.GetById(Convert.ToInt32(ID));
    }

    protected async Task UpdateArticle()
    {
        await articleManager.Update(articleEntity);
        navigationManager.NavigateTo("/articlelist");
    }

    void cancel()
    {
        navigationManager.NavigateTo("/articlelist");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Microsoft.AspNetCore.Components.NavigationManager navigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IArticleManager articleManager { get; set; }
    }
}
#pragma warning restore 1591
