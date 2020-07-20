#pragma checksum "C:\Users\StanleyYan\source\repos\BlazerCrudOnAzure\BlazorCRUD1\Pages\FetchProduct.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9e1775838f73ddb2f9d759d7de8ad54b06a9f8fc"
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/productlist")]
    public partial class FetchProduct : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 194 "C:\Users\StanleyYan\source\repos\BlazerCrudOnAzure\BlazorCRUD1\Pages\FetchProduct.razor"
       
    List<Product> productModel;
    List<Stock> stockModel;
    Store storeInfo;

    #region Pagination
    int totalPages;
    int totalRecords;
    int curPage;
    int pagerSize;
    int pageSize;
    int startPage;
    int endPage;


    string sortColumnName = "P.ID";
    string sortDir = "DESC";
    int selectedindex;
    bool collapseNavMenu = true;
    string NavMenuCssClass => collapseNavMenu ? "collapse" : null;

    //On data to seach.
    string searchProuctName, searchProductOrigin, searchLowerAmt, searchUpperAmt;

    //On bind variable
    string productName
    {
        get { return searchProuctName; }
        set
        {
            searchProuctName = value;
            FilterProduct(searchProuctName, searchProductOrigin, searchLowerAmt, searchUpperAmt).Wait();
        }
    }

    string productOrigin
    {
        get { return searchProductOrigin; }
        set
        {
            searchProductOrigin = value;
            FilterProduct(searchProuctName, searchProductOrigin, searchLowerAmt, searchUpperAmt).Wait();
        }
    }

    string lowerAmt
    {
        get { return searchLowerAmt; }
        set
        {
            searchLowerAmt = value;
            FilterProduct(searchProuctName, searchProductOrigin, searchLowerAmt, searchUpperAmt).Wait();
        }
    }

    string upperAmt
    {
        get { return searchUpperAmt; }
        set
        {
            searchUpperAmt = value;
            FilterProduct(searchProuctName, searchProductOrigin, searchLowerAmt, searchUpperAmt).Wait();
        }
    }

    #endregion

    public async void ToggleTableTr(int prod_id)
    {
        selectedindex = prod_id;
        collapseNavMenu = !collapseNavMenu;
        stockModel = await stockManager.SimpleListAll(prod_id);
    }

    protected override async Task OnInitializedAsync()
    {
        //display total page buttons
        pagerSize = 3;
        pageSize = 5;
        curPage = 1;
        storeInfo = await storeManager.GetById(1);
        productModel = await productManager.ListAll((curPage - 1) * pageSize, pageSize, sortColumnName, sortDir);
        totalRecords = await productManager.Count(productName);
        totalPages = (int)Math.Ceiling(totalRecords / (decimal)pageSize);
        SetPagerSize("forward");
    }

    public async void DeleteProductDialog(Product product)
    {

        var parameters = new ModalParameters();
        parameters.Add(nameof(product), product);

        var formModal = Modal.Show<DeleteProduct>(localizer["deleteProduct"], parameters);
        var result = await formModal.Result;

        if (result.Cancelled)
        {
        }
        else
        {
            DeleteProduct((Product)result.Data).Wait();
        }
    }

    public async void EditProductDialog(Product product)
    {

        var parameters = new ModalParameters();
        parameters.Add(nameof(product), product);

        var formModal = Modal.Show<EditProduct>(localizer["editProduct"], parameters);
        var result = await formModal.Result;

        if (result.Cancelled)
        {
            //Console.WriteLine("Modal was cancelled");
        }
        else
        {
            UpdateProduct((Product)result.Data).Wait();
        }
    }

    public async void AddProductDialog()
    {
        var formModal = Modal.Show<AddProduct>(localizer["addNewProduct"]);
        var result = await formModal.Result;

        if (result.Cancelled)
        {
            //Console.WriteLine("Modal was cancelled");
        }
        else
        {
            Product temp = (Product)result.Data;
            temp.UpdatedBy = "Stanley";
            temp.UpdatedDateTime = DateTime.Now;
            productManager.Create(temp).Wait();
            productModel = await productManager.ListAll((curPage - 1) * pageSize, pageSize, sortColumnName, sortDir);
            StateHasChanged();
        }
    }

    protected async Task DeleteProduct(Product product)
    {
        await productManager.Delete(product);
        FilterProduct(searchProuctName, searchProductOrigin, searchLowerAmt, searchUpperAmt).Wait();
        StateHasChanged();
    }

    protected async Task UpdateProduct(Product product)
    {
        await productManager.Update(product, false);
        StateHasChanged();
    }

    protected async Task FilterProduct(String name, String origin, String lowerAmt, String upperAmt)
    {
        if (String.IsNullOrEmpty(lowerAmt))
            lowerAmt = "0";

        if (String.IsNullOrEmpty(upperAmt))
            upperAmt = "10000000000000000000000";

        if (String.IsNullOrEmpty(name))
            name = "";

        if (String.IsNullOrEmpty(origin))
            origin = "";

        productModel = await productManager.ListFilterAll((curPage - 1) * pageSize, pageSize, sortColumnName, sortDir, name, origin, Double.Parse(lowerAmt), Double.Parse(upperAmt));
    }

    protected void FilterClear()
    {
        this.productName = null;
        this.productOrigin = null;
        this.lowerAmt = null;
        this.upperAmt = null;
    }

    public async Task GetTotalStockByProductID(int productID)
    {
        await stockManager.GetTotalStockByProductID(productID);
    }

    public async void AddStock(Product product)
    {

        var parameters = new ModalParameters();
        parameters.Add(nameof(product), product);

        var formModal = Modal.Show<AddStock>(localizer["addStock"], parameters);
        var result = await formModal.Result;

        if (result.Cancelled)
        {
            //Console.WriteLine("Modal was cancelled");
        }
        else
        {
            Stock temp = (Stock)result.Data;
            temp.UpdatedBy = "Stanley";
            temp.UpdatedDateTime = DateTime.Now;
            stockManager.Create(temp).Wait();
            stockModel = await stockManager.SimpleListAll(product.ID);
            productModel = await productManager.ListAll((curPage - 1) * pageSize, pageSize, sortColumnName, sortDir);
            StateHasChanged();
        }
    }

    public string displayStockValue(double stock, int unitType)
    {
        Dictionary<string,double> temp = BlazorCRUD1.Resources.Utils.Utils.convertStockUnit(stock, unitType);
        switch (unitType)
        {
            case 0:
                return temp["stock"] + localizer["kg"];
            case 1:
                return temp["stock"] + localizer["gun"];
            default:
                return temp["stock"].ToString();
        }
    }

    private bool isSortedAscending;
    private string activeSortColumn;

    private async Task<List<Product>> SortRecords(string columnName, string dir)
    {
        return await productManager.ListAll((curPage - 1) * pageSize, pageSize, columnName, dir, productName);
    }

    private async Task SortTable(string columnName)
    {
        if (columnName != activeSortColumn)
        {
            productModel = await SortRecords(columnName, "ASC");
            isSortedAscending = true;
            activeSortColumn = columnName;
        }
        else
        {
            if (isSortedAscending)
            {
                productModel = await SortRecords(columnName, "DESC");
            }
            else
            {
                productModel = await SortRecords(columnName, "ASC");
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
        productModel = await productManager.ListAll((currentPage - 1) * pageSize, pageSize, sortColumnName, sortDir);
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

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IStoreManager storeManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IModalService Modal { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IStringLocalizer<FetchProduct> localizer { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IStockManager stockManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IProductManager productManager { get; set; }
    }
}
#pragma warning restore 1591
