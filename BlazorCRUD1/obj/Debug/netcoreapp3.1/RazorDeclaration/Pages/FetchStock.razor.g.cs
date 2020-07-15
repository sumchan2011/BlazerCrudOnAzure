#pragma checksum "C:\Users\StanleyYan\source\repos\BlazerCrudOnAzure\BlazorCRUD1\Pages\FetchStock.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6dd11ca7f662abfee58a2f2e08db0d2abf7442f8"
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/stocklist")]
    public partial class FetchStock : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 115 "C:\Users\StanleyYan\source\repos\BlazerCrudOnAzure\BlazorCRUD1\Pages\FetchStock.razor"
       
    private string searchTerm;
    private string SearchTerm
    {
        get { return searchTerm; }
        set { searchTerm = value; FilterRecords(); }
    }

    List<Customer> customerModel;
    Customer customerEntity = new Customer();


    #region Pagination

    int totalPages;
    int totalRecords;
    int curPage;
    int pagerSize;
    int pageSize;
    int startPage;
    int endPage;
    string sortColumnName = "ID";
    string sortDir = "DESC";

    #endregion

    protected override async Task OnInitializedAsync()
    {
        //display total page buttons
        pagerSize = 3;
        pageSize = 5;
        curPage = 1;
        customerModel = await CustomerManager.ListAll(searchTerm );
        totalRecords = await CustomerManager.Count(searchTerm);
        totalPages = (int)Math.Ceiling(totalRecords / (decimal)pageSize);
        SetPagerSize("forward");
    }


    protected async Task DeleteArticle(int id)
    {
        await CustomerManager.Delete(id);
        customerModel = await CustomerManager.ListAll(searchTerm);
    }

    private bool isSortedAscending;
    private string activeSortColumn;

    private async Task<List<Customer>> SortRecords(string columnName, string dir)
    {
        return await CustomerManager.ListAll(searchTerm );
    }

    private async Task SortTable(string columnName)
    {
        if (columnName != activeSortColumn)
        {
            customerModel = await SortRecords(columnName, "ASC");
            isSortedAscending = true;
            activeSortColumn = columnName;
        }
        else
        {
            if (isSortedAscending)
            {
                customerModel = await SortRecords(columnName, "DESC");
            }
            else
            {
                customerModel = await SortRecords(columnName, "ASC");
            }

            isSortedAscending = !isSortedAscending;
        }
        sortColumnName = columnName;
        sortDir = isSortedAscending ? "ASC" : "DESC";
    }

    private string SetSortIcon(string columnName)
    {
        if (activeSortColumn != columnName)
        {
            return string.Empty;
        }
        if (isSortedAscending)
        {
            return "fa-sort-up";
        }
        else
        {
            return "fa-sort-down";
        }
    }

    public async Task refreshRecords(int currentPage)
    {
        customerModel = await CustomerManager.ListAll(searchTerm);
        curPage = currentPage;
        this.StateHasChanged();
    }

    public void SetPagerSize(string direction)
    {
        if (direction == "forward" && endPage < totalPages)
        {
            startPage = endPage + 1;
            if (endPage + pagerSize < totalPages)
            {
                endPage = startPage + pagerSize - 1;
            }
            else
            {
                endPage = totalPages;
            }
            this.StateHasChanged();
        }
        else if (direction == "back" && startPage > 1)
        {
            endPage = startPage - 1;
            startPage = startPage - pagerSize;
        }
        else
        {
            startPage = 1;
            endPage = totalPages;
        }
    }

    public async Task NavigateToPage(string direction)
    {
        if (direction == "next")
        {
            if (curPage < totalPages)
            {
                if (curPage == endPage)
                {
                    SetPagerSize("forward");
                }
                curPage += 1;
            }
        }
        else if (direction == "previous")
        {
            if (curPage > 1)
            {
                if (curPage == startPage)
                {
                    SetPagerSize("back");
                }
                curPage -= 1;
            }
        }
        await refreshRecords(curPage);
    }

    public void FilterRecords()
    {
        endPage = 0;
        this.OnInitializedAsync().Wait();
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ICustomerManager CustomerManager { get; set; }
    }
}
#pragma warning restore 1591
