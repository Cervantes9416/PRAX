#pragma checksum "C:\Users\cscxx\Desktop\PRAX\PRAX\PRAXYS\PRAXYS\Client\Pages\Bond\BondList.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fd874f42d1e7d6468ddc226ad5e020070c81cfd2"
// <auto-generated/>
#pragma warning disable 1591
namespace PRAXYS.Client.Pages.Bond
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#line 1 "C:\Users\cscxx\Desktop\PRAX\PRAX\PRAXYS\PRAXYS\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#line 2 "C:\Users\cscxx\Desktop\PRAX\PRAX\PRAXYS\PRAXYS\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#line 3 "C:\Users\cscxx\Desktop\PRAX\PRAX\PRAXYS\PRAXYS\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#line 4 "C:\Users\cscxx\Desktop\PRAX\PRAX\PRAXYS\PRAXYS\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#line 5 "C:\Users\cscxx\Desktop\PRAX\PRAX\PRAXYS\PRAXYS\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#line 6 "C:\Users\cscxx\Desktop\PRAX\PRAX\PRAXYS\PRAXYS\Client\_Imports.razor"
using PRAXYS.Client;

#line default
#line hidden
#line 7 "C:\Users\cscxx\Desktop\PRAX\PRAX\PRAXYS\PRAXYS\Client\_Imports.razor"
using PRAXYS.Client.Shared;

#line default
#line hidden
#line 8 "C:\Users\cscxx\Desktop\PRAX\PRAX\PRAXYS\PRAXYS\Client\_Imports.razor"
using PRAXYS.Client.Shared.MainViewLayout;

#line default
#line hidden
#line 9 "C:\Users\cscxx\Desktop\PRAX\PRAX\PRAXYS\PRAXYS\Client\_Imports.razor"
using PRAXYS.Shared.Entities;

#line default
#line hidden
#line 10 "C:\Users\cscxx\Desktop\PRAX\PRAX\PRAXYS\PRAXYS\Client\_Imports.razor"
using PRAXYS.Client.Intefaces;

#line default
#line hidden
#line 11 "C:\Users\cscxx\Desktop\PRAX\PRAX\PRAXYS\PRAXYS\Client\_Imports.razor"
using PRAXYS.Client.Shared.Tabs;

#line default
#line hidden
#line 12 "C:\Users\cscxx\Desktop\PRAX\PRAX\PRAXYS\PRAXYS\Client\_Imports.razor"
using PRAXYS.Client.Pages.Client;

#line default
#line hidden
#line 13 "C:\Users\cscxx\Desktop\PRAX\PRAX\PRAXYS\PRAXYS\Client\_Imports.razor"
using PRAXYS.Client.Pages.Companies;

#line default
#line hidden
#line 14 "C:\Users\cscxx\Desktop\PRAX\PRAX\PRAXYS\PRAXYS\Client\_Imports.razor"
using PRAXYS.Client.Pages.Basics;

#line default
#line hidden
#line 15 "C:\Users\cscxx\Desktop\PRAX\PRAX\PRAXYS\PRAXYS\Client\_Imports.razor"
using PRAXYS.Client.Shared.Forms;

#line default
#line hidden
#line 16 "C:\Users\cscxx\Desktop\PRAX\PRAX\PRAXYS\PRAXYS\Client\_Imports.razor"
using PRAXYS.Client.Pages.Agents;

#line default
#line hidden
#line 17 "C:\Users\cscxx\Desktop\PRAX\PRAX\PRAXYS\PRAXYS\Client\_Imports.razor"
using PRAXYS.Client.Pages.Insurances;

#line default
#line hidden
#line 18 "C:\Users\cscxx\Desktop\PRAX\PRAX\PRAXYS\PRAXYS\Client\_Imports.razor"
using PRAXYS.Client.Pages.Basics.CoveragePlans;

#line default
#line hidden
#line 19 "C:\Users\cscxx\Desktop\PRAX\PRAX\PRAXYS\PRAXYS\Client\_Imports.razor"
using PRAXYS.Client.Pages.Dashboard;

#line default
#line hidden
#line 20 "C:\Users\cscxx\Desktop\PRAX\PRAX\PRAXYS\PRAXYS\Client\_Imports.razor"
using PRAXYS.Client.Pages.Auth;

#line default
#line hidden
#line 21 "C:\Users\cscxx\Desktop\PRAX\PRAX\PRAXYS\PRAXYS\Client\_Imports.razor"
using PRAXYS.Client.Shared.SelectInput;

#line default
#line hidden
#line 22 "C:\Users\cscxx\Desktop\PRAX\PRAX\PRAXYS\PRAXYS\Client\_Imports.razor"
using PRAXYS.Client.Pages.Payments;

#line default
#line hidden
#line 23 "C:\Users\cscxx\Desktop\PRAX\PRAX\PRAXYS\PRAXYS\Client\_Imports.razor"
using PRAXYS.Client.Shared.MultipleSelect;

#line default
#line hidden
#line 24 "C:\Users\cscxx\Desktop\PRAX\PRAX\PRAXYS\PRAXYS\Client\_Imports.razor"
using BlazorStrap;

#line default
#line hidden
#line 25 "C:\Users\cscxx\Desktop\PRAX\PRAX\PRAXYS\PRAXYS\Client\_Imports.razor"
using MatBlazor;

#line default
#line hidden
#line 26 "C:\Users\cscxx\Desktop\PRAX\PRAX\PRAXYS\PRAXYS\Client\_Imports.razor"
using PRAXYS.Client.Helpers;

#line default
#line hidden
#line 27 "C:\Users\cscxx\Desktop\PRAX\PRAX\PRAXYS\PRAXYS\Client\_Imports.razor"
using PRAXYS.Commons.Entities.Client;

#line default
#line hidden
#line 28 "C:\Users\cscxx\Desktop\PRAX\PRAX\PRAXYS\PRAXYS\Client\_Imports.razor"
using PRAXYS.Commons.Interfaces;

#line default
#line hidden
#line 29 "C:\Users\cscxx\Desktop\PRAX\PRAX\PRAXYS\PRAXYS\Client\_Imports.razor"
using BlazorContextMenu;

#line default
#line hidden
#line 30 "C:\Users\cscxx\Desktop\PRAX\PRAX\PRAXYS\PRAXYS\Client\_Imports.razor"
using W8lessLabs.Blazor.LocalFiles;

#line default
#line hidden
#line 31 "C:\Users\cscxx\Desktop\PRAX\PRAX\PRAXYS\PRAXYS\Client\_Imports.razor"
using PRAXYS.Client.Services;

#line default
#line hidden
#line 32 "C:\Users\cscxx\Desktop\PRAX\PRAX\PRAXYS\PRAXYS\Client\_Imports.razor"
using Radzen;

#line default
#line hidden
#line 33 "C:\Users\cscxx\Desktop\PRAX\PRAX\PRAXYS\PRAXYS\Client\_Imports.razor"
using Radzen.Blazor;

#line default
#line hidden
#line 34 "C:\Users\cscxx\Desktop\PRAX\PRAX\PRAXYS\PRAXYS\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#line 35 "C:\Users\cscxx\Desktop\PRAX\PRAX\PRAXYS\PRAXYS\Client\_Imports.razor"
using PRAXYS.Client.Auth;

#line default
#line hidden
#line 36 "C:\Users\cscxx\Desktop\PRAX\PRAX\PRAXYS\PRAXYS\Client\_Imports.razor"
using BlazorDateRangePicker;

#line default
#line hidden
#line 37 "C:\Users\cscxx\Desktop\PRAX\PRAX\PRAXYS\PRAXYS\Client\_Imports.razor"
using PRAXYS.Client.Pages.BondPayment;

#line default
#line hidden
#line 38 "C:\Users\cscxx\Desktop\PRAX\PRAX\PRAXYS\PRAXYS\Client\_Imports.razor"
using PRAXYS.Client.Pages.ComissionPayment;

#line default
#line hidden
#line 39 "C:\Users\cscxx\Desktop\PRAX\PRAX\PRAXYS\PRAXYS\Client\_Imports.razor"
using PRAXYS.Client.Pages.Basics.Branch;

#line default
#line hidden
#line 40 "C:\Users\cscxx\Desktop\PRAX\PRAX\PRAXYS\PRAXYS\Client\_Imports.razor"
using PRAXYS.Client.Pages.Basics.PaymentType;

#line default
#line hidden
    [Microsoft.AspNetCore.Components.RouteAttribute("/bonds/list")]
    public partial class BondList : BondListBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, @"<div class=""row"">
    <div class=""col-12 d-flex justify-content-between align-items-center"">
        <h4 class=""mat-h4"">Listo de Fianzas</h4>
        <a class=""btn btn-blue waves-effect waves-light"" href=""bonds/create"">
            <span class=""btn-label"">
                <i class=""fas fa-plus""></i>
            </span>
            Agregar Fianza
        </a>
    </div>
</div>

");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "card mat-elevation-z4");
            __builder.AddMarkupContent(3, "\r\n    ");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "card-body");
            __builder.AddMarkupContent(6, "\r\n");
#line 19 "C:\Users\cscxx\Desktop\PRAX\PRAX\PRAXYS\PRAXYS\Client\Pages\Bond\BondList.razor"
         if (Bonds == null)
        {

#line default
#line hidden
            __builder.AddContent(7, "            ");
            __builder.AddMarkupContent(8, "<div class=\"d-flex justify-content-center\">\r\n                <div class=\"spinner-grow avatar-lg text-secondary m-2 text-center\" role=\"status\"></div>\r\n            </div>\r\n");
#line 24 "C:\Users\cscxx\Desktop\PRAX\PRAX\PRAXYS\PRAXYS\Client\Pages\Bond\BondList.razor"
        }
        else
        {

#line default
#line hidden
            __builder.AddContent(9, "            ");
            __builder.AddMarkupContent(10, "<div class=\"d-flex justify-content-end align-items-center\">\r\n\r\n            </div>\r\n");
            __builder.AddContent(11, "            ");
            __builder.OpenElement(12, "table");
            __builder.AddAttribute(13, "class", "table table-responsive-lg table-responsive-md table-striped border");
            __builder.AddAttribute(14, "id", "datable-init");
            __builder.AddMarkupContent(15, "\r\n                ");
            __builder.AddMarkupContent(16, @"<thead class=""bg-blue text-white"">
                    <tr>
                        <td>ID</td>
                        <td>Documento</td>
                        <td>Cliente</td>
                        <td>Compañia</td>
                        <td>Agente</td>
                        <td>Fecha de Expiracion</td>
                        <td>Prima Total</td>
                        <td>Acciones</td>
                    </tr>
                </thead>
                ");
            __builder.OpenElement(17, "tbody");
            __builder.AddMarkupContent(18, "\r\n");
#line 45 "C:\Users\cscxx\Desktop\PRAX\PRAX\PRAXYS\PRAXYS\Client\Pages\Bond\BondList.razor"
                     foreach (var item in Bonds)
                    {

#line default
#line hidden
            __builder.AddContent(19, "                        ");
            __builder.OpenElement(20, "tr");
            __builder.AddMarkupContent(21, "\r\n                            ");
            __builder.OpenElement(22, "td");
            __builder.AddContent(23, 
#line 48 "C:\Users\cscxx\Desktop\PRAX\PRAX\PRAXYS\PRAXYS\Client\Pages\Bond\BondList.razor"
                                 item.ID

#line default
#line hidden
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(24, "\r\n                            ");
            __builder.OpenElement(25, "td");
            __builder.AddContent(26, 
#line 49 "C:\Users\cscxx\Desktop\PRAX\PRAX\PRAXYS\PRAXYS\Client\Pages\Bond\BondList.razor"
                                 item.BondNumber

#line default
#line hidden
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(27, "\r\n                            ");
            __builder.OpenElement(28, "td");
            __builder.AddContent(29, 
#line 50 "C:\Users\cscxx\Desktop\PRAX\PRAX\PRAXYS\PRAXYS\Client\Pages\Bond\BondList.razor"
                                 item.Client

#line default
#line hidden
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(30, "\r\n                            ");
            __builder.OpenElement(31, "td");
            __builder.AddContent(32, 
#line 51 "C:\Users\cscxx\Desktop\PRAX\PRAX\PRAXYS\PRAXYS\Client\Pages\Bond\BondList.razor"
                                 item.Company

#line default
#line hidden
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(33, "\r\n                            ");
            __builder.OpenElement(34, "td");
            __builder.AddContent(35, 
#line 52 "C:\Users\cscxx\Desktop\PRAX\PRAX\PRAXYS\PRAXYS\Client\Pages\Bond\BondList.razor"
                                 item.Agent

#line default
#line hidden
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(36, "\r\n                            ");
            __builder.OpenElement(37, "td");
            __builder.AddContent(38, 
#line 53 "C:\Users\cscxx\Desktop\PRAX\PRAX\PRAXYS\PRAXYS\Client\Pages\Bond\BondList.razor"
                                 item.End.ToString("dd-MM-yyyy")

#line default
#line hidden
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(39, "\r\n                            <td></td>\r\n                            ");
            __builder.OpenElement(40, "td");
            __builder.AddMarkupContent(41, "\r\n                                ");
            __builder.OpenElement(42, "div");
            __builder.AddAttribute(43, "class", "btn-group");
            __builder.AddMarkupContent(44, "\r\n                                    ");
            __builder.AddMarkupContent(45, "<button type=\"button\" class=\"btn btn-blue dropdown-toggle\" data-toggle=\"dropdown\" aria-haspopup=\"true\" aria-expanded=\"false\">Opciones <i class=\"mdi mdi-chevron-down\"></i></button>\r\n                                    ");
            __builder.OpenElement(46, "div");
            __builder.AddAttribute(47, "class", "dropdown-menu");
            __builder.AddMarkupContent(48, "\r\n                                        ");
            __builder.OpenElement(49, "a");
            __builder.AddAttribute(50, "class", "dropdown-item");
            __builder.AddAttribute(51, "href", "bonds/details/" + (
#line 59 "C:\Users\cscxx\Desktop\PRAX\PRAX\PRAXYS\PRAXYS\Client\Pages\Bond\BondList.razor"
                                                                                      item.ID

#line default
#line hidden
            ));
            __builder.AddContent(52, "Ver Fianza");
            __builder.CloseElement();
            __builder.AddMarkupContent(53, "\r\n                                        ");
            __builder.AddMarkupContent(54, "<a class=\"dropdown-item\">Eliminar</a>\r\n                                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(55, "\r\n                                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(56, "\r\n                            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(57, "\r\n                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(58, "\r\n");
#line 65 "C:\Users\cscxx\Desktop\PRAX\PRAX\PRAXYS\PRAXYS\Client\Pages\Bond\BondList.razor"
                    }

#line default
#line hidden
            __builder.AddContent(59, "                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(60, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(61, "\r\n");
#line 68 "C:\Users\cscxx\Desktop\PRAX\PRAX\PRAXYS\PRAXYS\Client\Pages\Bond\BondList.razor"
        }

#line default
#line hidden
            __builder.AddContent(62, "    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(63, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
