#pragma checksum "C:\Users\cscxx\Desktop\PRAX\PRAX\PRAXYS\PRAXYS\Client\Shared\Forms\MultipleSelect.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e87126253883dfaab50587be9be369377aeeacf1"
// <auto-generated/>
#pragma warning disable 1591
namespace PRAXYS.Client.Shared.Forms
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
    public partial class MultipleSelect : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "row d-flex justify-content-center");
            __builder.AddMarkupContent(2, "\r\n    ");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "col-5 border");
            __builder.AddMarkupContent(5, "\r\n        ");
            __builder.AddMarkupContent(6, "<h4 class=\"border-bottom border-blue\">No Seleccionados</h4>\r\n");
#line 5 "C:\Users\cscxx\Desktop\PRAX\PRAX\PRAXYS\PRAXYS\Client\Shared\Forms\MultipleSelect.razor"
         foreach (var item in NoSelectItems)
        {

#line default
#line hidden
            __builder.AddContent(7, "            ");
            __builder.OpenComponent<MatBlazor.MatListItem>(8);
            __builder.AddAttribute(9, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#line 7 "C:\Users\cscxx\Desktop\PRAX\PRAX\PRAXYS\PRAXYS\Client\Shared\Forms\MultipleSelect.razor"
                                     () => Select(item)

#line default
#line hidden
            ));
            __builder.AddAttribute(10, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(11, "<i class=\"fas fa-minus text-info mr-2\"></i>  ");
                __builder2.AddContent(12, 
#line 7 "C:\Users\cscxx\Desktop\PRAX\PRAX\PRAXYS\PRAXYS\Client\Shared\Forms\MultipleSelect.razor"
                                                                                                        item.Value

#line default
#line hidden
                );
                __builder2.AddContent(13, " ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(14, "\r\n");
#line 8 "C:\Users\cscxx\Desktop\PRAX\PRAX\PRAXYS\PRAXYS\Client\Shared\Forms\MultipleSelect.razor"
        }

#line default
#line hidden
            __builder.AddContent(15, "    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(16, "\r\n    ");
            __builder.OpenElement(17, "div");
            __builder.AddAttribute(18, "class", "col-1 d-flex flex-column justify-content-center align-items-center");
            __builder.AddMarkupContent(19, "\r\n        ");
            __builder.OpenElement(20, "button");
            __builder.AddAttribute(21, "class", "btn btn-light");
            __builder.AddAttribute(22, "type", "button");
            __builder.AddAttribute(23, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#line 11 "C:\Users\cscxx\Desktop\PRAX\PRAX\PRAXYS\PRAXYS\Client\Shared\Forms\MultipleSelect.razor"
                                                              SelectAll

#line default
#line hidden
            ));
            __builder.AddContent(24, ">>");
            __builder.CloseElement();
            __builder.AddMarkupContent(25, "\r\n        ");
            __builder.OpenElement(26, "button");
            __builder.AddAttribute(27, "class", "btn btn-light");
            __builder.AddAttribute(28, "type", "button");
            __builder.AddAttribute(29, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#line 12 "C:\Users\cscxx\Desktop\PRAX\PRAX\PRAXYS\PRAXYS\Client\Shared\Forms\MultipleSelect.razor"
                                                              UnSelectAll

#line default
#line hidden
            ));
            __builder.AddContent(30, 
#line 12 "C:\Users\cscxx\Desktop\PRAX\PRAX\PRAXYS\PRAXYS\Client\Shared\Forms\MultipleSelect.razor"
                                                                            UnSelectText

#line default
#line hidden
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(31, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(32, "\r\n    ");
            __builder.OpenElement(33, "div");
            __builder.AddAttribute(34, "class", "col-5 border");
            __builder.AddMarkupContent(35, "\r\n        ");
            __builder.AddMarkupContent(36, "<h4 class=\"border-bottom border-blue\">Seleccionados</h4>\r\n");
#line 16 "C:\Users\cscxx\Desktop\PRAX\PRAX\PRAXYS\PRAXYS\Client\Shared\Forms\MultipleSelect.razor"
         foreach (var item in SelectItems)
        {

#line default
#line hidden
            __builder.AddContent(37, "            ");
            __builder.OpenComponent<MatBlazor.MatListItem>(38);
            __builder.AddAttribute(39, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#line 18 "C:\Users\cscxx\Desktop\PRAX\PRAX\PRAXYS\PRAXYS\Client\Shared\Forms\MultipleSelect.razor"
                                     () => UnSelect(item)

#line default
#line hidden
            ));
            __builder.AddAttribute(40, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(41, "<i class=\"fas fa-check text-success mr-2\"></i>  ");
                __builder2.AddContent(42, 
#line 18 "C:\Users\cscxx\Desktop\PRAX\PRAX\PRAXYS\PRAXYS\Client\Shared\Forms\MultipleSelect.razor"
                                                                                                             item.Value

#line default
#line hidden
                );
                __builder2.AddContent(43, " ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(44, "\r\n");
#line 19 "C:\Users\cscxx\Desktop\PRAX\PRAX\PRAXYS\PRAXYS\Client\Shared\Forms\MultipleSelect.razor"
        }

#line default
#line hidden
            __builder.AddContent(45, "    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(46, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#line 25 "C:\Users\cscxx\Desktop\PRAX\PRAX\PRAXYS\PRAXYS\Client\Shared\Forms\MultipleSelect.razor"
       
    [Parameter] public List<MultipleSelectModel> NoSelectItems { get; set; }
    [Parameter] public List<MultipleSelectModel> SelectItems { get; set; }
    private string UnSelectText = "<<";

    private void Select(MultipleSelectModel item)
    {
        NoSelectItems.Remove(item);
        SelectItems.Add(item);
    }

    private void UnSelect(MultipleSelectModel item)
    {
        SelectItems.Remove(item);
        NoSelectItems.Add(item);
    }

    private void UnSelectAll()
    {
        NoSelectItems.AddRange(SelectItems);
        SelectItems.Clear();
    }

    private void SelectAll()
    {
        SelectItems.AddRange(NoSelectItems);
        NoSelectItems.Clear();
    }

#line default
#line hidden
    }
}
#pragma warning restore 1591
