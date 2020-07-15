#pragma checksum "C:\Users\StanleyYan\source\repos\BlazerCrudOnAzure\BlazorCRUD1\Pages\TxnRecord.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6e1ff06d0d7ed8d14cb5a6ab92af9171691f67f8"
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/txnRecord")]
    public partial class TxnRecord : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 192 "C:\Users\StanleyYan\source\repos\BlazerCrudOnAzure\BlazorCRUD1\Pages\TxnRecord.razor"
       
    List<Product> productModel;
    Product productEntity = new Product();

    List<SaleTxn> saleTxnModel;
    List<Customer> customerModel;
    Customer customer = new Customer();

    Order orderEntity = new Order();
    List<Order> orderModel;

    bool collapseNavMenu = true;
    string NavMenuCssClass => collapseNavMenu ? "collapse" : null;
    int selectedindex;

    private string searchTerm;
    private string CustomerID
    {
        get { return searchTerm; }
        set
        {
            searchTerm = value;
            FilterCustomer(searchTerm);
        }
    }


    private bool IsShow { get; set; } = false;
    private void Show()
    {
        IsShow = !IsShow;
    }

    private bool IsShow2 { get; set; } = false;
    private void Show2()
    {
        IsShow2 = !IsShow2;
    }


    protected void FilterClear()
    {
        this.IsShow = false;
        this.IsShow2 = false;
    }


    protected async Task FilterCustomer(String customerId)
    {
        IsShow = true;

        customerModel = await customerManager.ListAll(customerId);
    }

    protected async Task SelectCustomer(Customer cust)
    {
        IsShow2 = false;
        customer = cust;
        if (orderModel == null)
            orderModel = new List<Order>();

        orderModel = await orderManager.SimplyListAll(customer.ID);
    }

    public async void ConfirmTransaction(Order order)
    {

        var parameters = new ModalParameters();
        parameters.Add(nameof(order), order);

        var formModal = Modal.Show<ConfirmTxn>("Confirm Txn", parameters);
        var result = await formModal.Result;

        if (result.Cancelled)
        {
            //Console.WriteLine("Modal was cancelled");
        }
        else
        {
            Order Temp = (Order)result.Data;

            orderEntity.UpdatedBy = "SAM";
            orderEntity.UpdatedDateTime = DateTime.Now;

            if (orderEntity.OrderCustomer == null)
                orderEntity.OrderCustomer = new Customer();

            int order_id = await orderManager.Create(orderEntity);

            foreach (SaleTxn item in saleTxnModel)
            {
                item.SaleTxnOrderID = order_id;
                item.UpdatedBy = "SAM";
                item.UpdatedDateTime = DateTime.Now;
                await saleManager.Create(item);
            }
        }
    }

    public async void ToggleTableTr(int orderID)
    {
        selectedindex = orderID;
        collapseNavMenu = !collapseNavMenu;
        saleTxnModel = await saleManager.SimplyListAll(orderID);
        IsShow2 = !IsShow2;
        foreach(SaleTxn item in saleTxnModel)
        {
            item.SaleProduct = await productManager.GetById(item.SaleTxnProductID);
        }


    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IModalService Modal { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IOrderManager orderManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ICustomerManager customerManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ISaleTxnManager saleManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IProductManager productManager { get; set; }
    }
}
#pragma warning restore 1591
