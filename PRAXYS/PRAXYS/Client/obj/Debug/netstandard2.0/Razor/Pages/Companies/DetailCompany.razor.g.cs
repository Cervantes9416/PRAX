#pragma checksum "C:\Users\Alejandro Chávez\Documents\PRAXIS\PRAX\PRAXYS\PRAXYS\Client\Pages\Companies\DetailCompany.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3dd0f4d9897977c095ec206e851f9b6e520929d7"
// <auto-generated/>
#pragma warning disable 1591
namespace PRAXYS.Client.Pages.Companies
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/companies/detail/{CompanyID:int}")]
    public partial class DetailCompany : DetailCompanyBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h4 class=\"mat-h4 mb-1\">Informacion de Compañia</h4>\r\n\r\n");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "card mat-elevation-z4");
            __builder.AddMarkupContent(3, "\r\n    ");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "card-body");
            __builder.AddMarkupContent(6, "\r\n");
#line 8 "C:\Users\Alejandro Chávez\Documents\PRAXIS\PRAX\PRAXYS\PRAXYS\Client\Pages\Companies\DetailCompany.razor"
         if (Company != null)
        {

#line default
#line hidden
            __builder.AddContent(7, "            ");
            __builder.OpenComponent<MatBlazor.MatTabGroup>(8);
            __builder.AddAttribute(9, "Style", "min-height:90vh;");
            __builder.AddAttribute(10, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(11, "\r\n                ");
                __builder2.OpenComponent<MatBlazor.MatTab>(12);
                __builder2.AddAttribute(13, "Label", "Datos Generales");
                __builder2.AddAttribute(14, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(15, "\r\n                    ");
                    __builder3.OpenComponent<PRAXYS.Client.Pages.Companies.CompanyForm>(16);
                    __builder3.AddAttribute(17, "Company", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<PRAXYS.Commons.Entities.Company.CompanyModel>(
#line 12 "C:\Users\Alejandro Chávez\Documents\PRAXIS\PRAX\PRAXYS\PRAXYS\Client\Pages\Companies\DetailCompany.razor"
                                          Company

#line default
#line hidden
                    ));
                    __builder3.AddAttribute(18, "ReadOnly", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#line 12 "C:\Users\Alejandro Chávez\Documents\PRAXIS\PRAX\PRAXYS\PRAXYS\Client\Pages\Companies\DetailCompany.razor"
                                                             true

#line default
#line hidden
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(19, "\r\n                ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(20, "\r\n                ");
                __builder2.OpenComponent<MatBlazor.MatTab>(21);
                __builder2.AddAttribute(22, "Label", "Polizas");
                __builder2.AddAttribute(23, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(24, "\r\n");
#line 15 "C:\Users\Alejandro Chávez\Documents\PRAXIS\PRAX\PRAXYS\PRAXYS\Client\Pages\Companies\DetailCompany.razor"
                     if (Companies != null)
                    {

#line default
#line hidden
                    __builder3.AddContent(25, "                        ");
                    __builder3.OpenElement(26, "div");
                    __builder3.AddAttribute(27, "class", "mt-2 animated fadeInLeft");
                    __builder3.AddMarkupContent(28, "\r\n                            ");
                    __builder3.OpenComponent<PRAXYS.Client.Pages.Insurances.ListInsurance>(29);
                    __builder3.AddAttribute(30, "Insurances", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.List<PRAXYS.Commons.Entities.Insurance.InsuranceListModel>>(
#line 18 "C:\Users\Alejandro Chávez\Documents\PRAXIS\PRAX\PRAXYS\PRAXYS\Client\Pages\Companies\DetailCompany.razor"
                                                       Companies

#line default
#line hidden
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(31, "\r\n                        ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(32, "\r\n");
#line 20 "C:\Users\Alejandro Chávez\Documents\PRAXIS\PRAX\PRAXYS\PRAXYS\Client\Pages\Companies\DetailCompany.razor"
                    }

#line default
#line hidden
                    __builder3.AddContent(33, "                ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(34, "\r\n                ");
                __builder2.OpenComponent<MatBlazor.MatTab>(35);
                __builder2.AddAttribute(36, "Label", "Fianzas");
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(37, "\r\n            ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(38, "\r\n");
#line 31 "C:\Users\Alejandro Chávez\Documents\PRAXIS\PRAX\PRAXYS\PRAXYS\Client\Pages\Companies\DetailCompany.razor"
        }

#line default
#line hidden
            __builder.AddContent(39, "    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(40, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
