#pragma checksum "C:\Users\Alejandro Chávez\Documents\BitBucket_Projects\PRAXYS\PRAXYS\Client\Pages\Dashboard\Dashboard.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b3d90219c827adf9008fc5ec6a13d47910e77f7e"
// <auto-generated/>
#pragma warning disable 1591
namespace PRAXYS.Client.Pages.Dashboard
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
    public partial class Dashboard : DashboardBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "card mat-elevation-z4");
            __builder.AddMarkupContent(2, "\r\n    ");
            __builder.AddMarkupContent(3, "<div class=\"card-header bg-blue text-white\">\r\n        Filtrar proximos acontecimientos\r\n    </div>\r\n    ");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "card-body");
            __builder.AddMarkupContent(6, "\r\n        ");
            __builder.OpenElement(7, "div");
            __builder.AddAttribute(8, "class", "row");
            __builder.AddMarkupContent(9, "\r\n            ");
            __builder.OpenElement(10, "div");
            __builder.AddAttribute(11, "class", "col-12");
            __builder.AddMarkupContent(12, "\r\n                ");
            __builder.OpenElement(13, "div");
            __builder.AddAttribute(14, "class", "form-row d-flex justify-content-center align-items-center");
            __builder.AddMarkupContent(15, "\r\n");
#line 12 "C:\Users\Alejandro Chávez\Documents\BitBucket_Projects\PRAXYS\PRAXYS\Client\Pages\Dashboard\Dashboard.razor"
                     if (DatePicker != null)
                    {

#line default
#line hidden
            __builder.AddContent(16, "                        ");
            __builder.OpenElement(17, "div");
            __builder.AddAttribute(18, "class", "form-group col-lg-3");
            __builder.AddMarkupContent(19, "\r\n                            ");
            __builder.OpenComponent<MatBlazor.MatSelect>(20);
            __builder.AddAttribute(21, "Label", "Rango de Fechas");
            __builder.AddAttribute(22, "Style", "width:100%");
            __builder.AddAttribute(23, "Enhanced", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#line 15 "C:\Users\Alejandro Chávez\Documents\BitBucket_Projects\PRAXYS\PRAXYS\Client\Pages\Dashboard\Dashboard.razor"
                                                                                                                    true

#line default
#line hidden
            ));
            __builder.AddAttribute(24, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#line 15 "C:\Users\Alejandro Chávez\Documents\BitBucket_Projects\PRAXYS\PRAXYS\Client\Pages\Dashboard\Dashboard.razor"
                                                                            DateRange

#line default
#line hidden
            ));
            __builder.AddAttribute(25, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => DateRange = __value, DateRange))));
            __builder.AddAttribute(26, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(27, "\r\n                                ");
                __builder2.OpenComponent<MatBlazor.MatOption>(28);
                __builder2.AddAttribute(29, "Value", "MES");
                __builder2.AddAttribute(30, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(31, "Mes siguiente");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(32, "\r\n                                ");
                __builder2.OpenComponent<MatBlazor.MatOption>(33);
                __builder2.AddAttribute(34, "Value", "TRIMESTRE");
                __builder2.AddAttribute(35, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(36, "Proximos 3 meses");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(37, "\r\n                                ");
                __builder2.OpenComponent<MatBlazor.MatOption>(38);
                __builder2.AddAttribute(39, "Value", "SEMESTRE");
                __builder2.AddAttribute(40, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(41, "Proximos 6 meses");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(42, "\r\n                                ");
                __builder2.OpenComponent<MatBlazor.MatOption>(43);
                __builder2.AddAttribute(44, "Value", "ANUAL");
                __builder2.AddAttribute(45, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(46, "Proximo Año");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(47, "\r\n                            ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(48, "\r\n                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(49, "\r\n                        ");
            __builder.OpenElement(50, "div");
            __builder.AddAttribute(51, "class", "form-group col-lg-3");
            __builder.AddMarkupContent(52, "\r\n                            ");
            __builder.OpenComponent<MatBlazor.MatDatePicker>(53);
            __builder.AddAttribute(54, "Style", "width:100%;");
            __builder.AddAttribute(55, "Label", "Fecha de Inicial");
            __builder.AddAttribute(56, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.DateTime?>(
#line 25 "C:\Users\Alejandro Chávez\Documents\BitBucket_Projects\PRAXYS\PRAXYS\Client\Pages\Dashboard\Dashboard.razor"
                                                         DatePicker.InitalDate

#line default
#line hidden
            ));
            __builder.AddAttribute(57, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.DateTime?>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.DateTime?>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => DatePicker.InitalDate = __value, DatePicker.InitalDate))));
            __builder.AddAttribute(58, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.DateTime?>>>(() => DatePicker.InitalDate));
            __builder.CloseComponent();
            __builder.AddMarkupContent(59, "\r\n                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(60, "\r\n                        ");
            __builder.OpenElement(61, "div");
            __builder.AddAttribute(62, "class", "form-group col-lg-3");
            __builder.AddMarkupContent(63, "\r\n                            ");
            __builder.OpenComponent<MatBlazor.MatDatePicker>(64);
            __builder.AddAttribute(65, "Style", "width:100%;");
            __builder.AddAttribute(66, "Label", "Fecha Final");
            __builder.AddAttribute(67, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.DateTime?>(
#line 31 "C:\Users\Alejandro Chávez\Documents\BitBucket_Projects\PRAXYS\PRAXYS\Client\Pages\Dashboard\Dashboard.razor"
                                                         DatePicker.FinalDate

#line default
#line hidden
            ));
            __builder.AddAttribute(68, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.DateTime?>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.DateTime?>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => DatePicker.FinalDate = __value, DatePicker.FinalDate))));
            __builder.AddAttribute(69, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.DateTime?>>>(() => DatePicker.FinalDate));
            __builder.CloseComponent();
            __builder.AddMarkupContent(70, "\r\n                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(71, "\r\n");
#line 34 "C:\Users\Alejandro Chávez\Documents\BitBucket_Projects\PRAXYS\PRAXYS\Client\Pages\Dashboard\Dashboard.razor"
                    }

#line default
#line hidden
            __builder.AddContent(72, "                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(73, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(74, "\r\n            ");
            __builder.OpenElement(75, "div");
            __builder.AddAttribute(76, "class", "col-lg-4");
            __builder.AddMarkupContent(77, "\r\n");
#line 38 "C:\Users\Alejandro Chávez\Documents\BitBucket_Projects\PRAXYS\PRAXYS\Client\Pages\Dashboard\Dashboard.razor"
                 if (DatePicker != null)
                {

#line default
#line hidden
            __builder.AddContent(78, "                    ");
            __builder.OpenComponent<PRAXYS.Client.Pages.Insurances.InsuranceNextToExpire>(79);
            __builder.AddAttribute(80, "DatePicker", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<PRAXYS.Commons.Entities.DatePickerModel>(
#line 40 "C:\Users\Alejandro Chávez\Documents\BitBucket_Projects\PRAXYS\PRAXYS\Client\Pages\Dashboard\Dashboard.razor"
                                                       DatePicker

#line default
#line hidden
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(81, "\r\n");
#line 41 "C:\Users\Alejandro Chávez\Documents\BitBucket_Projects\PRAXYS\PRAXYS\Client\Pages\Dashboard\Dashboard.razor"
                }

#line default
#line hidden
            __builder.AddContent(82, "            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(83, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(84, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(85, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591