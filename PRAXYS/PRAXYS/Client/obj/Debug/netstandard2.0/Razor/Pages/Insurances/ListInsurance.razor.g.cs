#pragma checksum "C:\Users\Alejandro Chávez\Documents\PRAXIS\PRAX\PRAXYS\PRAXYS\Client\Pages\Insurances\ListInsurance.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "64a2f830439a9c058ed693732e03c021adbfbcb2"
// <auto-generated/>
#pragma warning disable 1591
namespace PRAXYS.Client.Pages.Insurances
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#line 1 "C:\Users\Alejandro Chávez\Documents\PRAXIS\PRAX\PRAXYS\PRAXYS\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#line 2 "C:\Users\Alejandro Chávez\Documents\PRAXIS\PRAX\PRAXYS\PRAXYS\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#line 3 "C:\Users\Alejandro Chávez\Documents\PRAXIS\PRAX\PRAXYS\PRAXYS\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#line 4 "C:\Users\Alejandro Chávez\Documents\PRAXIS\PRAX\PRAXYS\PRAXYS\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#line 5 "C:\Users\Alejandro Chávez\Documents\PRAXIS\PRAX\PRAXYS\PRAXYS\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#line 6 "C:\Users\Alejandro Chávez\Documents\PRAXIS\PRAX\PRAXYS\PRAXYS\Client\_Imports.razor"
using PRAXYS.Client;

#line default
#line hidden
#line 7 "C:\Users\Alejandro Chávez\Documents\PRAXIS\PRAX\PRAXYS\PRAXYS\Client\_Imports.razor"
using PRAXYS.Client.Shared;

#line default
#line hidden
#line 8 "C:\Users\Alejandro Chávez\Documents\PRAXIS\PRAX\PRAXYS\PRAXYS\Client\_Imports.razor"
using PRAXYS.Client.Shared.MainViewLayout;

#line default
#line hidden
#line 9 "C:\Users\Alejandro Chávez\Documents\PRAXIS\PRAX\PRAXYS\PRAXYS\Client\_Imports.razor"
using PRAXYS.Shared.Entities;

#line default
#line hidden
#line 10 "C:\Users\Alejandro Chávez\Documents\PRAXIS\PRAX\PRAXYS\PRAXYS\Client\_Imports.razor"
using PRAXYS.Client.Intefaces;

#line default
#line hidden
#line 11 "C:\Users\Alejandro Chávez\Documents\PRAXIS\PRAX\PRAXYS\PRAXYS\Client\_Imports.razor"
using PRAXYS.Client.Shared.Tabs;

#line default
#line hidden
#line 12 "C:\Users\Alejandro Chávez\Documents\PRAXIS\PRAX\PRAXYS\PRAXYS\Client\_Imports.razor"
using PRAXYS.Client.Pages.Client;

#line default
#line hidden
#line 13 "C:\Users\Alejandro Chávez\Documents\PRAXIS\PRAX\PRAXYS\PRAXYS\Client\_Imports.razor"
using PRAXYS.Client.Pages.Companies;

#line default
#line hidden
#line 14 "C:\Users\Alejandro Chávez\Documents\PRAXIS\PRAX\PRAXYS\PRAXYS\Client\_Imports.razor"
using PRAXYS.Client.Pages.Basics;

#line default
#line hidden
#line 15 "C:\Users\Alejandro Chávez\Documents\PRAXIS\PRAX\PRAXYS\PRAXYS\Client\_Imports.razor"
using PRAXYS.Client.Shared.Forms;

#line default
#line hidden
#line 16 "C:\Users\Alejandro Chávez\Documents\PRAXIS\PRAX\PRAXYS\PRAXYS\Client\_Imports.razor"
using PRAXYS.Client.Pages.Agents;

#line default
#line hidden
#line 17 "C:\Users\Alejandro Chávez\Documents\PRAXIS\PRAX\PRAXYS\PRAXYS\Client\_Imports.razor"
using PRAXYS.Client.Pages.Insurances;

#line default
#line hidden
#line 18 "C:\Users\Alejandro Chávez\Documents\PRAXIS\PRAX\PRAXYS\PRAXYS\Client\_Imports.razor"
using PRAXYS.Client.Pages.Basics.CoveragePlans;

#line default
#line hidden
#line 19 "C:\Users\Alejandro Chávez\Documents\PRAXIS\PRAX\PRAXYS\PRAXYS\Client\_Imports.razor"
using PRAXYS.Client.Pages.Dashboard;

#line default
#line hidden
#line 20 "C:\Users\Alejandro Chávez\Documents\PRAXIS\PRAX\PRAXYS\PRAXYS\Client\_Imports.razor"
using PRAXYS.Client.Pages.Auth;

#line default
#line hidden
#line 21 "C:\Users\Alejandro Chávez\Documents\PRAXIS\PRAX\PRAXYS\PRAXYS\Client\_Imports.razor"
using PRAXYS.Client.Shared.SelectInput;

#line default
#line hidden
#line 22 "C:\Users\Alejandro Chávez\Documents\PRAXIS\PRAX\PRAXYS\PRAXYS\Client\_Imports.razor"
using PRAXYS.Client.Pages.Payments;

#line default
#line hidden
#line 23 "C:\Users\Alejandro Chávez\Documents\PRAXIS\PRAX\PRAXYS\PRAXYS\Client\_Imports.razor"
using PRAXYS.Client.Shared.MultipleSelect;

#line default
#line hidden
#line 24 "C:\Users\Alejandro Chávez\Documents\PRAXIS\PRAX\PRAXYS\PRAXYS\Client\_Imports.razor"
using BlazorStrap;

#line default
#line hidden
#line 25 "C:\Users\Alejandro Chávez\Documents\PRAXIS\PRAX\PRAXYS\PRAXYS\Client\_Imports.razor"
using MatBlazor;

#line default
#line hidden
#line 26 "C:\Users\Alejandro Chávez\Documents\PRAXIS\PRAX\PRAXYS\PRAXYS\Client\_Imports.razor"
using PRAXYS.Client.Helpers;

#line default
#line hidden
#line 27 "C:\Users\Alejandro Chávez\Documents\PRAXIS\PRAX\PRAXYS\PRAXYS\Client\_Imports.razor"
using PRAXYS.Commons.Entities.Client;

#line default
#line hidden
#line 28 "C:\Users\Alejandro Chávez\Documents\PRAXIS\PRAX\PRAXYS\PRAXYS\Client\_Imports.razor"
using PRAXYS.Commons.Interfaces;

#line default
#line hidden
#line 29 "C:\Users\Alejandro Chávez\Documents\PRAXIS\PRAX\PRAXYS\PRAXYS\Client\_Imports.razor"
using BlazorContextMenu;

#line default
#line hidden
#line 30 "C:\Users\Alejandro Chávez\Documents\PRAXIS\PRAX\PRAXYS\PRAXYS\Client\_Imports.razor"
using W8lessLabs.Blazor.LocalFiles;

#line default
#line hidden
#line 31 "C:\Users\Alejandro Chávez\Documents\PRAXIS\PRAX\PRAXYS\PRAXYS\Client\_Imports.razor"
using PRAXYS.Client.Services;

#line default
#line hidden
#line 32 "C:\Users\Alejandro Chávez\Documents\PRAXIS\PRAX\PRAXYS\PRAXYS\Client\_Imports.razor"
using Radzen;

#line default
#line hidden
#line 33 "C:\Users\Alejandro Chávez\Documents\PRAXIS\PRAX\PRAXYS\PRAXYS\Client\_Imports.razor"
using Radzen.Blazor;

#line default
#line hidden
#line 34 "C:\Users\Alejandro Chávez\Documents\PRAXIS\PRAX\PRAXYS\PRAXYS\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#line 35 "C:\Users\Alejandro Chávez\Documents\PRAXIS\PRAX\PRAXYS\PRAXYS\Client\_Imports.razor"
using PRAXYS.Client.Auth;

#line default
#line hidden
#line 36 "C:\Users\Alejandro Chávez\Documents\PRAXIS\PRAX\PRAXYS\PRAXYS\Client\_Imports.razor"
using BlazorDateRangePicker;

#line default
#line hidden
#line 37 "C:\Users\Alejandro Chávez\Documents\PRAXIS\PRAX\PRAXYS\PRAXYS\Client\_Imports.razor"
using PRAXYS.Client.Pages.BondPayment;

#line default
#line hidden
#line 38 "C:\Users\Alejandro Chávez\Documents\PRAXIS\PRAX\PRAXYS\PRAXYS\Client\_Imports.razor"
using PRAXYS.Client.Pages.ComissionPayment;

#line default
#line hidden
#line 39 "C:\Users\Alejandro Chávez\Documents\PRAXIS\PRAX\PRAXYS\PRAXYS\Client\_Imports.razor"
using PRAXYS.Client.Pages.Basics.Branch;

#line default
#line hidden
#line 40 "C:\Users\Alejandro Chávez\Documents\PRAXIS\PRAX\PRAXYS\PRAXYS\Client\_Imports.razor"
using PRAXYS.Client.Pages.Basics.PaymentType;

#line default
#line hidden
    public partial class ListInsurance : ListInsuranceBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "table");
            __builder.AddAttribute(1, "class", "table table-hover table-striped border border-blue table-responsive-lg");
            __builder.AddAttribute(2, "id", true);
            __builder.AddMarkupContent(3, "\r\n    ");
            __builder.AddMarkupContent(4, @"<thead class=""bg-blue text-white"">
        <tr>
            <td>Numero de Poliza</td>
            <td class=""text-center"">Estado</td>
            <td>Cliente</td>
            <td>Tipo de Poliza</td>
            <td>Fecha de Vencimiento</td>
            <td>Aseguradora</td>
            <td>Acciones</td>
        </tr>
    </thead>
    ");
            __builder.OpenElement(5, "tbody");
            __builder.AddMarkupContent(6, "\r\n");
#line 17 "C:\Users\Alejandro Chávez\Documents\PRAXIS\PRAX\PRAXYS\PRAXYS\Client\Pages\Insurances\ListInsurance.razor"
         foreach (var item in Insurances)
        {

#line default
#line hidden
            __builder.AddContent(7, "            ");
            __builder.OpenElement(8, "tr");
            __builder.AddMarkupContent(9, "\r\n                ");
            __builder.OpenElement(10, "td");
            __builder.AddContent(11, 
#line 20 "C:\Users\Alejandro Chávez\Documents\PRAXIS\PRAX\PRAXYS\PRAXYS\Client\Pages\Insurances\ListInsurance.razor"
                     item.InsuranceNumber

#line default
#line hidden
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(12, "\r\n                ");
            __builder.OpenElement(13, "td");
            __builder.AddAttribute(14, "class", "text-center");
            __builder.AddMarkupContent(15, "\r\n                    ");
            __builder.OpenElement(16, "i");
            __builder.AddAttribute(17, "class", 
#line 22 "C:\Users\Alejandro Chávez\Documents\PRAXIS\PRAX\PRAXYS\PRAXYS\Client\Pages\Insurances\ListInsurance.razor"
                               item.getStatus()

#line default
#line hidden
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\r\n                ");
            __builder.OpenElement(20, "td");
            __builder.AddMarkupContent(21, "\r\n                    ");
            __builder.OpenElement(22, "a");
            __builder.AddAttribute(23, "href", "clients/details/" + (
#line 25 "C:\Users\Alejandro Chávez\Documents\PRAXIS\PRAX\PRAXYS\PRAXYS\Client\Pages\Insurances\ListInsurance.razor"
                                              item.Client.ID

#line default
#line hidden
            ));
            __builder.AddMarkupContent(24, "\r\n                        ");
            __builder.AddContent(25, 
#line 26 "C:\Users\Alejandro Chávez\Documents\PRAXIS\PRAX\PRAXYS\PRAXYS\Client\Pages\Insurances\ListInsurance.razor"
                         item.Client.GetName()

#line default
#line hidden
            );
            __builder.AddMarkupContent(26, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(27, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(28, "\r\n                ");
            __builder.OpenElement(29, "td");
            __builder.AddContent(30, 
#line 29 "C:\Users\Alejandro Chávez\Documents\PRAXIS\PRAX\PRAXYS\PRAXYS\Client\Pages\Insurances\ListInsurance.razor"
                     item.InsuranceType

#line default
#line hidden
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(31, "\r\n                ");
            __builder.OpenElement(32, "td");
            __builder.AddContent(33, 
#line 30 "C:\Users\Alejandro Chávez\Documents\PRAXIS\PRAX\PRAXYS\PRAXYS\Client\Pages\Insurances\ListInsurance.razor"
                     item.ValidThrought

#line default
#line hidden
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(34, "\r\n                ");
            __builder.OpenElement(35, "td");
            __builder.AddContent(36, 
#line 31 "C:\Users\Alejandro Chávez\Documents\PRAXIS\PRAX\PRAXYS\PRAXYS\Client\Pages\Insurances\ListInsurance.razor"
                     item.Company.CompanyName

#line default
#line hidden
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(37, "\r\n                ");
            __builder.OpenElement(38, "td");
            __builder.AddMarkupContent(39, "\r\n                    ");
            __builder.AddMarkupContent(40, "<a href class=\"btn btn-blue waves-effect waves-light\"><i class=\"far fa-edit\"></i></a>\r\n                    ");
            __builder.OpenElement(41, "div");
            __builder.AddAttribute(42, "class", "btn-group");
            __builder.AddMarkupContent(43, "\r\n                        ");
            __builder.AddMarkupContent(44, "<button type=\"button\" class=\"btn btn-blue dropdown-toggle\" data-toggle=\"dropdown\" aria-haspopup=\"true\" aria-expanded=\"false\">Opciones <i class=\"mdi mdi-chevron-down\"></i></button>\r\n                        ");
            __builder.OpenElement(45, "div");
            __builder.AddAttribute(46, "class", "dropdown-menu");
            __builder.AddMarkupContent(47, "\r\n                            ");
            __builder.OpenElement(48, "a");
            __builder.AddAttribute(49, "class", "dropdown-item");
            __builder.AddAttribute(50, "href", "Overview/" + (
#line 38 "C:\Users\Alejandro Chávez\Documents\PRAXIS\PRAX\PRAXYS\PRAXYS\Client\Pages\Insurances\ListInsurance.razor"
                                                                     item.ID

#line default
#line hidden
            ));
            __builder.AddContent(51, "Ver Poliza");
            __builder.CloseElement();
            __builder.AddMarkupContent(52, "\r\n                            ");
            __builder.AddMarkupContent(53, "<a class=\"dropdown-item\">Eliminar</a>\r\n                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(54, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(55, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(56, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(57, "\r\n");
#line 44 "C:\Users\Alejandro Chávez\Documents\PRAXIS\PRAX\PRAXYS\PRAXYS\Client\Pages\Insurances\ListInsurance.razor"
        }

#line default
#line hidden
            __builder.AddContent(58, "    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(59, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
