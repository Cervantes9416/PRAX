#pragma checksum "C:\Users\Alejandro Chávez\Documents\BitBucket_Projects\PRAXYS\PRAXYS\Client\Pages\Client\ListClient.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ea5348e085c7441240ed9cdc2652eba7dc3198a0"
// <auto-generated/>
#pragma warning disable 1591
namespace PRAXYS.Client.Pages.Client
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#line 1 "C:\Users\Alejandro Chávez\Documents\BitBucket_Projects\PRAXYS\PRAXYS\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#line 2 "C:\Users\Alejandro Chávez\Documents\BitBucket_Projects\PRAXYS\PRAXYS\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#line 3 "C:\Users\Alejandro Chávez\Documents\BitBucket_Projects\PRAXYS\PRAXYS\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#line 4 "C:\Users\Alejandro Chávez\Documents\BitBucket_Projects\PRAXYS\PRAXYS\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#line 5 "C:\Users\Alejandro Chávez\Documents\BitBucket_Projects\PRAXYS\PRAXYS\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#line 6 "C:\Users\Alejandro Chávez\Documents\BitBucket_Projects\PRAXYS\PRAXYS\Client\_Imports.razor"
using PRAXYS.Client;

#line default
#line hidden
#line 7 "C:\Users\Alejandro Chávez\Documents\BitBucket_Projects\PRAXYS\PRAXYS\Client\_Imports.razor"
using PRAXYS.Client.Shared;

#line default
#line hidden
#line 8 "C:\Users\Alejandro Chávez\Documents\BitBucket_Projects\PRAXYS\PRAXYS\Client\_Imports.razor"
using PRAXYS.Client.Shared.MainViewLayout;

#line default
#line hidden
#line 9 "C:\Users\Alejandro Chávez\Documents\BitBucket_Projects\PRAXYS\PRAXYS\Client\_Imports.razor"
using PRAXYS.Shared.Entities;

#line default
#line hidden
#line 10 "C:\Users\Alejandro Chávez\Documents\BitBucket_Projects\PRAXYS\PRAXYS\Client\_Imports.razor"
using PRAXYS.Client.Intefaces;

#line default
#line hidden
#line 11 "C:\Users\Alejandro Chávez\Documents\BitBucket_Projects\PRAXYS\PRAXYS\Client\_Imports.razor"
using PRAXYS.Client.Shared.Tabs;

#line default
#line hidden
#line 12 "C:\Users\Alejandro Chávez\Documents\BitBucket_Projects\PRAXYS\PRAXYS\Client\_Imports.razor"
using PRAXYS.Client.Pages.Client;

#line default
#line hidden
#line 13 "C:\Users\Alejandro Chávez\Documents\BitBucket_Projects\PRAXYS\PRAXYS\Client\_Imports.razor"
using PRAXYS.Client.Pages.Companies;

#line default
#line hidden
#line 14 "C:\Users\Alejandro Chávez\Documents\BitBucket_Projects\PRAXYS\PRAXYS\Client\_Imports.razor"
using PRAXYS.Client.Pages.Basics;

#line default
#line hidden
#line 15 "C:\Users\Alejandro Chávez\Documents\BitBucket_Projects\PRAXYS\PRAXYS\Client\_Imports.razor"
using PRAXYS.Client.Shared.Forms;

#line default
#line hidden
#line 16 "C:\Users\Alejandro Chávez\Documents\BitBucket_Projects\PRAXYS\PRAXYS\Client\_Imports.razor"
using PRAXYS.Client.Pages.Agents;

#line default
#line hidden
#line 17 "C:\Users\Alejandro Chávez\Documents\BitBucket_Projects\PRAXYS\PRAXYS\Client\_Imports.razor"
using PRAXYS.Client.Pages.Insurances;

#line default
#line hidden
#line 18 "C:\Users\Alejandro Chávez\Documents\BitBucket_Projects\PRAXYS\PRAXYS\Client\_Imports.razor"
using PRAXYS.Client.Pages.Basics.CoveragePlans;

#line default
#line hidden
#line 19 "C:\Users\Alejandro Chávez\Documents\BitBucket_Projects\PRAXYS\PRAXYS\Client\_Imports.razor"
using PRAXYS.Client.Pages.Dashboard;

#line default
#line hidden
#line 20 "C:\Users\Alejandro Chávez\Documents\BitBucket_Projects\PRAXYS\PRAXYS\Client\_Imports.razor"
using PRAXYS.Client.Pages.Auth;

#line default
#line hidden
#line 21 "C:\Users\Alejandro Chávez\Documents\BitBucket_Projects\PRAXYS\PRAXYS\Client\_Imports.razor"
using PRAXYS.Client.Shared.SelectInput;

#line default
#line hidden
#line 22 "C:\Users\Alejandro Chávez\Documents\BitBucket_Projects\PRAXYS\PRAXYS\Client\_Imports.razor"
using PRAXYS.Client.Pages.Payments;

#line default
#line hidden
#line 23 "C:\Users\Alejandro Chávez\Documents\BitBucket_Projects\PRAXYS\PRAXYS\Client\_Imports.razor"
using PRAXYS.Client.Shared.MultipleSelect;

#line default
#line hidden
#line 24 "C:\Users\Alejandro Chávez\Documents\BitBucket_Projects\PRAXYS\PRAXYS\Client\_Imports.razor"
using BlazorStrap;

#line default
#line hidden
#line 25 "C:\Users\Alejandro Chávez\Documents\BitBucket_Projects\PRAXYS\PRAXYS\Client\_Imports.razor"
using MatBlazor;

#line default
#line hidden
#line 26 "C:\Users\Alejandro Chávez\Documents\BitBucket_Projects\PRAXYS\PRAXYS\Client\_Imports.razor"
using PRAXYS.Client.Helpers;

#line default
#line hidden
#line 27 "C:\Users\Alejandro Chávez\Documents\BitBucket_Projects\PRAXYS\PRAXYS\Client\_Imports.razor"
using PRAXYS.Commons.Entities.Client;

#line default
#line hidden
#line 28 "C:\Users\Alejandro Chávez\Documents\BitBucket_Projects\PRAXYS\PRAXYS\Client\_Imports.razor"
using PRAXYS.Commons.Interfaces;

#line default
#line hidden
#line 29 "C:\Users\Alejandro Chávez\Documents\BitBucket_Projects\PRAXYS\PRAXYS\Client\_Imports.razor"
using BlazorContextMenu;

#line default
#line hidden
#line 30 "C:\Users\Alejandro Chávez\Documents\BitBucket_Projects\PRAXYS\PRAXYS\Client\_Imports.razor"
using W8lessLabs.Blazor.LocalFiles;

#line default
#line hidden
#line 31 "C:\Users\Alejandro Chávez\Documents\BitBucket_Projects\PRAXYS\PRAXYS\Client\_Imports.razor"
using PRAXYS.Client.Services;

#line default
#line hidden
#line 32 "C:\Users\Alejandro Chávez\Documents\BitBucket_Projects\PRAXYS\PRAXYS\Client\_Imports.razor"
using Radzen;

#line default
#line hidden
#line 33 "C:\Users\Alejandro Chávez\Documents\BitBucket_Projects\PRAXYS\PRAXYS\Client\_Imports.razor"
using Radzen.Blazor;

#line default
#line hidden
#line 34 "C:\Users\Alejandro Chávez\Documents\BitBucket_Projects\PRAXYS\PRAXYS\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#line 35 "C:\Users\Alejandro Chávez\Documents\BitBucket_Projects\PRAXYS\PRAXYS\Client\_Imports.razor"
using PRAXYS.Client.Auth;

#line default
#line hidden
#line 36 "C:\Users\Alejandro Chávez\Documents\BitBucket_Projects\PRAXYS\PRAXYS\Client\_Imports.razor"
using BlazorDateRangePicker;

#line default
#line hidden
#line 37 "C:\Users\Alejandro Chávez\Documents\BitBucket_Projects\PRAXYS\PRAXYS\Client\_Imports.razor"
using PRAXYS.Client.Pages.BondPayment;

#line default
#line hidden
#line 38 "C:\Users\Alejandro Chávez\Documents\BitBucket_Projects\PRAXYS\PRAXYS\Client\_Imports.razor"
using PRAXYS.Client.Pages.ComissionPayment;

#line default
#line hidden
#line 39 "C:\Users\Alejandro Chávez\Documents\BitBucket_Projects\PRAXYS\PRAXYS\Client\_Imports.razor"
using PRAXYS.Client.Pages.Basics.Branch;

#line default
#line hidden
#line 40 "C:\Users\Alejandro Chávez\Documents\BitBucket_Projects\PRAXYS\PRAXYS\Client\_Imports.razor"
using PRAXYS.Client.Pages.Basics.PaymentType;

#line default
#line hidden
    [Microsoft.AspNetCore.Components.RouteAttribute("/clients/list")]
    public partial class ListClient : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, @"<div class=""row"">
    <div class=""col-12 d-flex justify-content-between align-items-center"">
        <h4 class=""mat-h4"">Lista de Clientes</h4>
        <a class=""btn btn-blue waves-effect waves-light"" href=""clients/create"">
            <span class=""btn-label"">
                <i class=""fas fa-plus""></i>
            </span>
            Agregar Cliente
        </a>
    </div>
</div>

");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "card mat-elevation-z4 border-top border-blue ");
            __builder.AddMarkupContent(3, "\r\n    ");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "card-body");
            __builder.AddMarkupContent(6, "\r\n");
#line 21 "C:\Users\Alejandro Chávez\Documents\BitBucket_Projects\PRAXYS\PRAXYS\Client\Pages\Client\ListClient.razor"
         if (Clients == null)
        {

#line default
#line hidden
            __builder.AddContent(7, "            ");
            __builder.AddMarkupContent(8, "<div class=\"d-flex justify-content-center\">\r\n                <div class=\"spinner-grow avatar-lg text-secondary m-2 text-center\" role=\"status\"></div>\r\n            </div>\r\n");
#line 26 "C:\Users\Alejandro Chávez\Documents\BitBucket_Projects\PRAXYS\PRAXYS\Client\Pages\Client\ListClient.razor"
        }
        else if (Clients.Count == 0)
        {

#line default
#line hidden
            __builder.AddContent(9, "            ");
            __builder.AddMarkupContent(10, "<p>No existen registros que mostrar</p>\r\n");
#line 30 "C:\Users\Alejandro Chávez\Documents\BitBucket_Projects\PRAXYS\PRAXYS\Client\Pages\Client\ListClient.razor"
        }
        else
        {

#line default
#line hidden
            __builder.AddContent(11, "            ");
            __builder.OpenElement(12, "table");
            __builder.AddAttribute(13, "class", "table table-hover border-blue border table-responsive-lg");
            __builder.AddAttribute(14, "id", "datable-init");
            __builder.AddMarkupContent(15, "\r\n                ");
            __builder.AddMarkupContent(16, @"<thead class=""bg-blue text-white"">
                    <tr>
                        <th scope=""col"">Nombre o Razon Social</th>
                        <th scope=""col"">Telefono</th>
                        <th scope=""col"">Correo</th>
                        <th scope=""col"">Acciones</th>
                    </tr>
                </thead>
                ");
            __builder.OpenElement(17, "tbody");
            __builder.AddMarkupContent(18, "\r\n");
#line 43 "C:\Users\Alejandro Chávez\Documents\BitBucket_Projects\PRAXYS\PRAXYS\Client\Pages\Client\ListClient.razor"
                     foreach (var item in Clients)
                    {

#line default
#line hidden
            __builder.AddContent(19, "                        ");
            __builder.OpenElement(20, "tr");
            __builder.AddMarkupContent(21, "\r\n");
#line 46 "C:\Users\Alejandro Chávez\Documents\BitBucket_Projects\PRAXYS\PRAXYS\Client\Pages\Client\ListClient.razor"
                             if (item.PersonType == "Fisica")
                            {

#line default
#line hidden
            __builder.AddContent(22, "                                ");
            __builder.OpenElement(23, "td");
            __builder.AddContent(24, 
#line 48 "C:\Users\Alejandro Chávez\Documents\BitBucket_Projects\PRAXYS\PRAXYS\Client\Pages\Client\ListClient.razor"
                                      item.Name + " " + item.LastName + " " + item.SecondLastName

#line default
#line hidden
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(25, "\r\n");
#line 49 "C:\Users\Alejandro Chávez\Documents\BitBucket_Projects\PRAXYS\PRAXYS\Client\Pages\Client\ListClient.razor"
                            }
                            else if (item.PersonType == "Moral")
                            {

#line default
#line hidden
            __builder.AddContent(26, "                                ");
            __builder.OpenElement(27, "td");
            __builder.OpenElement(28, "span");
            __builder.AddContent(29, 
#line 52 "C:\Users\Alejandro Chávez\Documents\BitBucket_Projects\PRAXYS\PRAXYS\Client\Pages\Client\ListClient.razor"
                                           item.CompanyName

#line default
#line hidden
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(30, "\r\n");
#line 53 "C:\Users\Alejandro Chávez\Documents\BitBucket_Projects\PRAXYS\PRAXYS\Client\Pages\Client\ListClient.razor"
                            }

#line default
#line hidden
            __builder.AddContent(31, "                            ");
            __builder.OpenElement(32, "td");
            __builder.AddContent(33, 
#line 54 "C:\Users\Alejandro Chávez\Documents\BitBucket_Projects\PRAXYS\PRAXYS\Client\Pages\Client\ListClient.razor"
                                 item.PhoneNumber

#line default
#line hidden
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(34, "\r\n                            ");
            __builder.OpenElement(35, "td");
            __builder.AddContent(36, 
#line 55 "C:\Users\Alejandro Chávez\Documents\BitBucket_Projects\PRAXYS\PRAXYS\Client\Pages\Client\ListClient.razor"
                                 item.Email

#line default
#line hidden
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(37, "\r\n                            ");
            __builder.OpenElement(38, "td");
            __builder.AddMarkupContent(39, "\r\n                                ");
            __builder.OpenElement(40, "a");
            __builder.AddAttribute(41, "href", "clients/edit/" + (
#line 57 "C:\Users\Alejandro Chávez\Documents\BitBucket_Projects\PRAXYS\PRAXYS\Client\Pages\Client\ListClient.razor"
                                                       item.ID

#line default
#line hidden
            ));
            __builder.AddAttribute(42, "class", "btn btn-blue waves-effect waves-light");
            __builder.AddMarkupContent(43, "<i class=\"far fa-edit\"></i>");
            __builder.CloseElement();
            __builder.AddMarkupContent(44, "\r\n                                ");
            __builder.OpenElement(45, "div");
            __builder.AddAttribute(46, "class", "btn-group");
            __builder.AddMarkupContent(47, "\r\n                                    ");
            __builder.AddMarkupContent(48, "<button type=\"button\" class=\"btn btn-blue dropdown-toggle\" data-toggle=\"dropdown\" aria-haspopup=\"true\" aria-expanded=\"false\">Opciones <i class=\"mdi mdi-chevron-down\"></i></button>\r\n                                    ");
            __builder.OpenElement(49, "div");
            __builder.AddAttribute(50, "class", "dropdown-menu");
            __builder.AddMarkupContent(51, "\r\n                                        ");
            __builder.OpenElement(52, "a");
            __builder.AddAttribute(53, "class", "dropdown-item");
            __builder.AddAttribute(54, "href", "clients/details/" + (
#line 61 "C:\Users\Alejandro Chávez\Documents\BitBucket_Projects\PRAXYS\PRAXYS\Client\Pages\Client\ListClient.razor"
                                                                                        item.ID

#line default
#line hidden
            ));
            __builder.AddContent(55, "Ver Cliente");
            __builder.CloseElement();
            __builder.AddMarkupContent(56, "\r\n                                        ");
            __builder.OpenElement(57, "a");
            __builder.AddAttribute(58, "class", "dropdown-item");
            __builder.AddAttribute(59, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#line 62 "C:\Users\Alejandro Chávez\Documents\BitBucket_Projects\PRAXYS\PRAXYS\Client\Pages\Client\ListClient.razor"
                                                                             () => Delete(item.ID)

#line default
#line hidden
            ));
            __builder.AddContent(60, "Eliminar");
            __builder.CloseElement();
            __builder.AddMarkupContent(61, "\r\n                                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(62, "\r\n                                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(63, "\r\n                            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(64, "\r\n                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(65, "\r\n");
#line 67 "C:\Users\Alejandro Chávez\Documents\BitBucket_Projects\PRAXYS\PRAXYS\Client\Pages\Client\ListClient.razor"
                    }

#line default
#line hidden
            __builder.AddContent(66, "                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(67, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(68, "\r\n");
#line 70 "C:\Users\Alejandro Chávez\Documents\BitBucket_Projects\PRAXYS\PRAXYS\Client\Pages\Client\ListClient.razor"
        }

#line default
#line hidden
            __builder.AddContent(69, "    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(70, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#line 74 "C:\Users\Alejandro Chávez\Documents\BitBucket_Projects\PRAXYS\PRAXYS\Client\Pages\Client\ListClient.razor"
       
    [Parameter] public EventCallback<int> OnDblClick { get; set; }

    private List<ClientModel> Clients;
    private bool Opened;

    protected override async Task OnInitializedAsync()
    {
        Clients = await Http.GetJsonAsync<List<ClientModel>>("api/clients");
    }

    private async void Delete(int id)
    {
        var result = await js.ConfirmMessage("Antes de continuar", "Esta seguro de querer eliminar el registro");
        if (result)
        {
            await Http.DeleteAsync($"api/clients/{id}");
            //Clients = await Http.GetJsonAsync<List<ClientModel>>("api/clients");
            await js.Message("Exito", "Se ha Eliminado el registro", "success");
            await js.Reload();
        }

        StateHasChanged();
    }

    protected override async Task OnAfterRenderAsync(bool firstRender)
    {
        if (firstRender)
        {
            await js.DataTableInit();
        }
    }

#line default
#line hidden
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime js { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navigarionManager { get; set; }
    }
}
#pragma warning restore 1591
