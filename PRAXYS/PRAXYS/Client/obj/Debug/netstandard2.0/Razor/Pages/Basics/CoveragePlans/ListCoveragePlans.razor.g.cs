#pragma checksum "C:\Users\Alejandro Chávez\Documents\BitBucket_Projects\PRAXYS\PRAXYS\Client\Pages\Basics\CoveragePlans\ListCoveragePlans.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4d7bb163d2f4d8d523a1e3c712d4a581e95507d2"
// <auto-generated/>
#pragma warning disable 1591
namespace PRAXYS.Client.Pages.Basics.CoveragePlans
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/coverageplans/list")]
    public partial class ListCoveragePlans : ListCoveragePlansBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<BlazorStrap.BSModal>(0);
            __builder.AddAttribute(1, "Size", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<BlazorStrap.Size>(
#line 4 "C:\Users\Alejandro Chávez\Documents\BitBucket_Projects\PRAXYS\PRAXYS\Client\Pages\Basics\CoveragePlans\ListCoveragePlans.razor"
                               Size.Large

#line default
#line hidden
            ));
            __builder.AddAttribute(2, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(3, "\r\n    ");
                __builder2.OpenComponent<BlazorStrap.BSModalHeader>(4);
                __builder2.AddAttribute(5, "OnClick", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#line 5 "C:\Users\Alejandro Chávez\Documents\BitBucket_Projects\PRAXYS\PRAXYS\Client\Pages\Basics\CoveragePlans\ListCoveragePlans.razor"
                              () => LiveDemo.Hide()

#line default
#line hidden
                )));
                __builder2.AddAttribute(6, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(7, "Agregar Cobertura");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(8, "\r\n    ");
                __builder2.OpenComponent<BlazorStrap.BSModalBody>(9);
                __builder2.AddAttribute(10, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(11, "\r\n        ");
                    __Blazor.PRAXYS.Client.Pages.Basics.CoveragePlans.ListCoveragePlans.TypeInference.CreateCascadingValue_0(__builder3, 12, 13, 
#line 7 "C:\Users\Alejandro Chávez\Documents\BitBucket_Projects\PRAXYS\PRAXYS\Client\Pages\Basics\CoveragePlans\ListCoveragePlans.razor"
                               this

#line default
#line hidden
                    , 14, (__builder4) => {
                        __builder4.AddMarkupContent(15, "\r\n            ");
                        __builder4.OpenComponent<PRAXYS.Client.Pages.Basics.CoveragePlans.AddCoveragePlan>(16);
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(17, "\r\n        ");
                    }
                    );
                    __builder3.AddMarkupContent(18, "\r\n    ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(19, "\r\n");
            }
            ));
            __builder.AddComponentReferenceCapture(20, (__value) => {
#line 4 "C:\Users\Alejandro Chávez\Documents\BitBucket_Projects\PRAXYS\PRAXYS\Client\Pages\Basics\CoveragePlans\ListCoveragePlans.razor"
               LiveDemo = (BlazorStrap.BSModal)__value;

#line default
#line hidden
            }
            );
            __builder.CloseComponent();
            __builder.AddMarkupContent(21, "\r\n\r\n");
            __builder.OpenElement(22, "div");
            __builder.AddAttribute(23, "class", "row ");
            __builder.AddMarkupContent(24, "\r\n    ");
            __builder.OpenElement(25, "div");
            __builder.AddAttribute(26, "class", "col-12 d-flex justify-content-between align-items-center");
            __builder.AddMarkupContent(27, "\r\n        ");
            __builder.AddMarkupContent(28, "<h4 class=\"mat-h4\">Planes de Cobertura</h4>\r\n        ");
            __builder.OpenElement(29, "button");
            __builder.AddAttribute(30, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#line 16 "C:\Users\Alejandro Chávez\Documents\BitBucket_Projects\PRAXYS\PRAXYS\Client\Pages\Basics\CoveragePlans\ListCoveragePlans.razor"
                            () => LiveDemo.Show()

#line default
#line hidden
            ));
            __builder.AddAttribute(31, "class", "btn btn-blue waves-effect waves-light");
            __builder.AddMarkupContent(32, "\r\n            ");
            __builder.AddMarkupContent(33, "<span class=\"btn-label\">\r\n                <i class=\"fas fa-plus\"></i>\r\n            </span>\r\n            Agregar Plan\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(34, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(35, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(36, "\r\n\r\n");
            __builder.OpenElement(37, "div");
            __builder.AddAttribute(38, "class", "card card mat-elevation-z4 border-blue border-top");
            __builder.AddMarkupContent(39, "\r\n    ");
            __builder.OpenElement(40, "div");
            __builder.AddAttribute(41, "class", "card-body");
            __builder.AddMarkupContent(42, "\r\n");
#line 27 "C:\Users\Alejandro Chávez\Documents\BitBucket_Projects\PRAXYS\PRAXYS\Client\Pages\Basics\CoveragePlans\ListCoveragePlans.razor"
         if (CoveragePlans == null)
        {

#line default
#line hidden
            __builder.AddContent(43, "            ");
            __builder.AddMarkupContent(44, "<div class=\"d-flex justify-content-center\">\r\n                <div class=\"spinner-grow avatar-lg text-secondary m-2 text-center\" role=\"status\"></div>\r\n            </div>\r\n");
#line 32 "C:\Users\Alejandro Chávez\Documents\BitBucket_Projects\PRAXYS\PRAXYS\Client\Pages\Basics\CoveragePlans\ListCoveragePlans.razor"
        }
        else if (CoveragePlans.Count == 0)
        {

#line default
#line hidden
            __builder.AddContent(45, "            ");
            __builder.AddMarkupContent(46, "<p>No existen registros que mostrar</p>\r\n");
#line 36 "C:\Users\Alejandro Chávez\Documents\BitBucket_Projects\PRAXYS\PRAXYS\Client\Pages\Basics\CoveragePlans\ListCoveragePlans.razor"
        }
        else
        {

#line default
#line hidden
            __builder.AddContent(47, "            ");
            __builder.OpenElement(48, "table");
            __builder.AddAttribute(49, "class", "table table-responsive-lg table-hover table-striped");
            __builder.AddMarkupContent(50, "\r\n                ");
            __builder.AddMarkupContent(51, "<thead class=\"bg-blue text-white\">\r\n                    <tr>\r\n                        <td>ID</td>\r\n                        <td>Nombre</td>\r\n                    </tr>\r\n                </thead>\r\n                ");
            __builder.OpenElement(52, "tbody");
            __builder.AddMarkupContent(53, "\r\n");
#line 47 "C:\Users\Alejandro Chávez\Documents\BitBucket_Projects\PRAXYS\PRAXYS\Client\Pages\Basics\CoveragePlans\ListCoveragePlans.razor"
                     foreach (var item in CoveragePlans)
                    {

#line default
#line hidden
            __builder.AddContent(54, "                        ");
            __builder.OpenElement(55, "tr");
            __builder.AddAttribute(56, "ondblclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#line 49 "C:\Users\Alejandro Chávez\Documents\BitBucket_Projects\PRAXYS\PRAXYS\Client\Pages\Basics\CoveragePlans\ListCoveragePlans.razor"
                                           () => OnDblClick.InvokeAsync(item.ID)

#line default
#line hidden
            ));
            __builder.AddMarkupContent(57, "\r\n                            ");
            __builder.OpenElement(58, "td");
            __builder.AddContent(59, 
#line 50 "C:\Users\Alejandro Chávez\Documents\BitBucket_Projects\PRAXYS\PRAXYS\Client\Pages\Basics\CoveragePlans\ListCoveragePlans.razor"
                                 item.ID

#line default
#line hidden
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(60, "\r\n                            ");
            __builder.OpenElement(61, "td");
            __builder.AddContent(62, 
#line 51 "C:\Users\Alejandro Chávez\Documents\BitBucket_Projects\PRAXYS\PRAXYS\Client\Pages\Basics\CoveragePlans\ListCoveragePlans.razor"
                                 item.Name

#line default
#line hidden
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(63, "\r\n                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(64, "\r\n");
#line 53 "C:\Users\Alejandro Chávez\Documents\BitBucket_Projects\PRAXYS\PRAXYS\Client\Pages\Basics\CoveragePlans\ListCoveragePlans.razor"
                    }

#line default
#line hidden
            __builder.AddContent(65, "                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(66, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(67, "\r\n");
#line 56 "C:\Users\Alejandro Chávez\Documents\BitBucket_Projects\PRAXYS\PRAXYS\Client\Pages\Basics\CoveragePlans\ListCoveragePlans.razor"
        }

#line default
#line hidden
            __builder.AddContent(68, "    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(69, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#line 60 "C:\Users\Alejandro Chávez\Documents\BitBucket_Projects\PRAXYS\PRAXYS\Client\Pages\Basics\CoveragePlans\ListCoveragePlans.razor"
       
    public BSModal LiveDemo;

#line default
#line hidden
    }
}
namespace __Blazor.PRAXYS.Client.Pages.Basics.CoveragePlans.ListCoveragePlans
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateCascadingValue_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, TValue __arg0, int __seq1, global::Microsoft.AspNetCore.Components.RenderFragment __arg1)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.CascadingValue<TValue>>(seq);
        __builder.AddAttribute(__seq0, "Value", __arg0);
        __builder.AddAttribute(__seq1, "ChildContent", __arg1);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591