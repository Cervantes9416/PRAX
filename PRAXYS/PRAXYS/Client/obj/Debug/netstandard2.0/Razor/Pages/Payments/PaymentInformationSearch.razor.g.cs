#pragma checksum "C:\Users\cscxx\Desktop\PRAX\PRAX\PRAXYS\PRAXYS\Client\Pages\Payments\PaymentInformationSearch.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fde1d03c6b361c216c06cc58fc3d448a0a5916f8"
// <auto-generated/>
#pragma warning disable 1591
namespace PRAXYS.Client.Pages.Payments
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/payments/search")]
    public partial class PaymentInformationSearch : PaymentInformationSearchBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "card mat-elevation-z4");
            __builder.AddMarkupContent(2, "\r\n    ");
            __builder.AddMarkupContent(3, "<div class=\"card-header\">\r\n        Documento\r\n    </div>\r\n    ");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "card-body");
            __builder.AddMarkupContent(6, "\r\n        ");
            __builder.OpenElement(7, "div");
            __builder.AddAttribute(8, "class", "col-12");
            __builder.AddMarkupContent(9, "\r\n            ");
            __builder.OpenElement(10, "div");
            __builder.AddAttribute(11, "class", "row");
            __builder.AddMarkupContent(12, "\r\n                ");
            __builder.OpenElement(13, "div");
            __builder.AddAttribute(14, "class", "col-lg-5");
            __builder.AddMarkupContent(15, "\r\n                    ");
            __builder.OpenElement(16, "input");
            __builder.AddAttribute(17, "type", "text");
            __builder.AddAttribute(18, "class", "form-control");
            __builder.AddAttribute(19, "placeholder", "Buscar documento");
            __builder.AddAttribute(20, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#line 12 "C:\Users\cscxx\Desktop\PRAX\PRAX\PRAXYS\PRAXYS\Client\Pages\Payments\PaymentInformationSearch.razor"
                                                    InsuranceNumber

#line default
#line hidden
            ));
            __builder.AddAttribute(21, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => InsuranceNumber = __value, InsuranceNumber));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(22, "\r\n                    ");
            __builder.AddMarkupContent(23, "<button class=\"btn btn-light\">Buscar</button>\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(24, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(25, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(26, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(27, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(28, "\r\n\r\n");
            __builder.OpenElement(29, "div");
            __builder.AddAttribute(30, "class", "card-box mat-elevation-z4");
            __builder.AddMarkupContent(31, "\r\n");
#line 21 "C:\Users\cscxx\Desktop\PRAX\PRAX\PRAXYS\PRAXYS\Client\Pages\Payments\PaymentInformationSearch.razor"
     if (Payments == null)
    {

    }
    else if (Payments.Count == 0)
    {

#line default
#line hidden
            __builder.AddContent(32, "        ");
            __builder.AddMarkupContent(33, "<div class=\"alert alert-info\" role=\"alert\">\r\n            No se ha encontrado ningun registro\r\n        </div>\r\n");
#line 30 "C:\Users\cscxx\Desktop\PRAX\PRAX\PRAXYS\PRAXYS\Client\Pages\Payments\PaymentInformationSearch.razor"
    }
    else
    {

#line default
#line hidden
            __builder.AddContent(34, "        ");
            __builder.OpenElement(35, "table");
            __builder.AddAttribute(36, "class", "table table-striped  table-responsive-lg");
            __builder.AddMarkupContent(37, "\r\n            ");
            __builder.AddMarkupContent(38, @"<thead class=""bg-blue text-white"">
                <tr>
                    <th>ID</th>
                    <th>Numero de Poliza</th>
                    <th>Serie</th>
                    <th>Prima Total</th>
                    <th>Limite de Pago</th>
                    <th class=""text-center"">Estatus</th>
                    <th class=""text-center"">Acciones</th>
                </tr>
            </thead>
            ");
            __builder.OpenElement(39, "tbody");
            __builder.AddMarkupContent(40, "\r\n");
#line 46 "C:\Users\cscxx\Desktop\PRAX\PRAX\PRAXYS\PRAXYS\Client\Pages\Payments\PaymentInformationSearch.razor"
                 foreach (var item in Payments)
                {

#line default
#line hidden
            __builder.AddContent(41, "                    ");
            __builder.OpenElement(42, "tr");
            __builder.AddMarkupContent(43, "\r\n                        ");
            __builder.OpenElement(44, "td");
            __builder.AddContent(45, 
#line 49 "C:\Users\cscxx\Desktop\PRAX\PRAX\PRAXYS\PRAXYS\Client\Pages\Payments\PaymentInformationSearch.razor"
                             item.ID

#line default
#line hidden
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(46, "\r\n                        ");
            __builder.OpenElement(47, "td");
            __builder.AddContent(48, 
#line 50 "C:\Users\cscxx\Desktop\PRAX\PRAX\PRAXYS\PRAXYS\Client\Pages\Payments\PaymentInformationSearch.razor"
                              $"{item.InsuranceNumber} - {item.Insurance.EndorsementNumber}"

#line default
#line hidden
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(49, "\r\n                        ");
            __builder.OpenElement(50, "td");
            __builder.AddAttribute(51, "class", "text-info");
            __builder.AddContent(52, 
#line 51 "C:\Users\cscxx\Desktop\PRAX\PRAX\PRAXYS\PRAXYS\Client\Pages\Payments\PaymentInformationSearch.razor"
                                               item.PaymentNumber

#line default
#line hidden
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(53, "\r\n                        ");
            __builder.OpenElement(54, "td");
            __builder.AddContent(55, 
#line 52 "C:\Users\cscxx\Desktop\PRAX\PRAX\PRAXYS\PRAXYS\Client\Pages\Payments\PaymentInformationSearch.razor"
                             item.Premium

#line default
#line hidden
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(56, "\r\n                        ");
            __builder.OpenElement(57, "td");
            __builder.AddContent(58, 
#line 53 "C:\Users\cscxx\Desktop\PRAX\PRAX\PRAXYS\PRAXYS\Client\Pages\Payments\PaymentInformationSearch.razor"
                             item.PaymentExpirationDate.ToString("dd-MM-yyyy")

#line default
#line hidden
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(59, "\r\n                        ");
            __builder.OpenElement(60, "td");
            __builder.AddAttribute(61, "class", "text-center" + " " + (
#line 54 "C:\Users\cscxx\Desktop\PRAX\PRAX\PRAXYS\PRAXYS\Client\Pages\Payments\PaymentInformationSearch.razor"
                                                 item.Payed ? "text-success" : "text-warning"

#line default
#line hidden
            ));
            __builder.OpenElement(62, "strong");
            __builder.AddContent(63, 
#line 54 "C:\Users\cscxx\Desktop\PRAX\PRAX\PRAXYS\PRAXYS\Client\Pages\Payments\PaymentInformationSearch.razor"
                                                                                                          item.Payed ? "Pagada" : "Pendiente"

#line default
#line hidden
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(64, "\r\n                        ");
            __builder.OpenElement(65, "td");
            __builder.AddAttribute(66, "class", "text-center");
            __builder.AddMarkupContent(67, "\r\n                            ");
            __builder.OpenElement(68, "div");
            __builder.AddAttribute(69, "class", "btn-group");
            __builder.AddMarkupContent(70, "\r\n                                ");
            __builder.OpenElement(71, "a");
            __builder.AddAttribute(72, "href", "/payments/receipt/" + (
#line 57 "C:\Users\cscxx\Desktop\PRAX\PRAX\PRAXYS\PRAXYS\Client\Pages\Payments\PaymentInformationSearch.razor"
                                                            item.ID

#line default
#line hidden
            ));
            __builder.AddAttribute(73, "class", "btn btn-blue waves-effect waves-light");
            __builder.AddMarkupContent(74, "\r\n                                    <i class=\"far fa-save\"></i>\r\n                                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(75, "\r\n                            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(76, "\r\n                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(77, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(78, "\r\n");
#line 63 "C:\Users\cscxx\Desktop\PRAX\PRAX\PRAXYS\PRAXYS\Client\Pages\Payments\PaymentInformationSearch.razor"
                }

#line default
#line hidden
            __builder.AddContent(79, "            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(80, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(81, "\r\n");
#line 66 "C:\Users\cscxx\Desktop\PRAX\PRAX\PRAXYS\PRAXYS\Client\Pages\Payments\PaymentInformationSearch.razor"
    }

#line default
#line hidden
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
