#pragma checksum "C:\Users\StanleyYan\source\repos\BlazerCrudOnAzure\BlazorCRUD1\Pages\AddStock - Copy.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8f521702a534396fd1249121cb4d6b557ac64912"
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/addStock")]
    public partial class AddStock___Copy : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 30 "C:\Users\StanleyYan\source\repos\BlazerCrudOnAzure\BlazorCRUD1\Pages\AddStock - Copy.razor"
       
    [CascadingParameter] BlazoredModalInstance BlazoredModal { get; set; }
    [Parameter] public Product product { get; set; }
    Stock stock = new Stock();

    void ConfirmedUpdate()
    {
        stock.ProductID = product.ID;
        BlazoredModal.Close(ModalResult.Ok(stock));
    }

    void Cancel()
    {
        BlazoredModal.Cancel();
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IStringLocalizer<AddStock> localizer { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Microsoft.AspNetCore.Components.NavigationManager navigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IProductManager productManager { get; set; }
    }
}
#pragma warning restore 1591