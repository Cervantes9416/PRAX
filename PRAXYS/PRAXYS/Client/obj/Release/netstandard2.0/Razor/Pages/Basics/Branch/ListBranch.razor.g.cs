#pragma checksum "C:\Users\Alejandro Chávez\Documents\PRAXIS\PRAX\PRAXYS\PRAXYS\Client\Pages\Basics\Branch\ListBranch.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d9b6871349d5467bd557140abb6ba4138731a85a"
// <auto-generated/>
#pragma warning disable 1591
namespace PRAXYS.Client.Pages.Basics.Branch
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/basics/branchs")]
    public partial class ListBranch : ListBranchBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "row mb-2");
            __builder.AddMarkupContent(2, "\r\n    ");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "col-12 d-flex justify-content-end align-items-center");
            __builder.AddMarkupContent(5, "\r\n        ");
            __builder.OpenElement(6, "button");
            __builder.AddAttribute(7, "class", "btn bg-blue");
            __builder.AddAttribute(8, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#line 7 "C:\Users\Alejandro Chávez\Documents\PRAXIS\PRAX\PRAXYS\PRAXYS\Client\Pages\Basics\Branch\ListBranch.razor"
                                              AddBranch

#line default
#line hidden
            ));
            __builder.AddMarkupContent(9, "\r\n            Agregar Ramo\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(10, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(11, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(12, "\r\n\r\n");
            __builder.OpenElement(13, "div");
            __builder.AddAttribute(14, "class", "row");
            __builder.AddMarkupContent(15, "\r\n    ");
            __builder.OpenElement(16, "div");
            __builder.AddAttribute(17, "class", "col-12");
            __builder.AddMarkupContent(18, "\r\n        ");
            __builder.OpenElement(19, "div");
            __builder.AddAttribute(20, "class", "card-box mat-elevation-z4");
            __builder.AddMarkupContent(21, "\r\n\r\n");
#line 17 "C:\Users\Alejandro Chávez\Documents\PRAXIS\PRAX\PRAXYS\PRAXYS\Client\Pages\Basics\Branch\ListBranch.razor"
             if (Branches != null)
            {

#line default
#line hidden
            __builder.AddContent(22, "                ");
            __builder.OpenElement(23, "button");
            __builder.AddAttribute(24, "class", "btn btn-light");
            __builder.AddAttribute(25, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#line 19 "C:\Users\Alejandro Chávez\Documents\PRAXIS\PRAX\PRAXYS\PRAXYS\Client\Pages\Basics\Branch\ListBranch.razor"
                                                        UpdateList

#line default
#line hidden
            ));
            __builder.AddContent(26, "Actualizar registros");
            __builder.CloseElement();
            __builder.AddMarkupContent(27, "\r\n                ");
            __builder.OpenElement(28, "table");
            __builder.AddAttribute(29, "class", "table table-striped table-responsive-lg");
            __builder.AddMarkupContent(30, "\r\n                    ");
            __builder.AddMarkupContent(31, @"<thead class=""bg-blue text-white"">
                        <tr>
                            <td>Ramo</td>
                            <td>Alias</td>
                            <td>Acciones</td>
                        </tr>
                    </thead>
                    ");
            __builder.OpenElement(32, "tbody");
            __builder.AddMarkupContent(33, "\r\n\r\n");
#line 30 "C:\Users\Alejandro Chávez\Documents\PRAXIS\PRAX\PRAXYS\PRAXYS\Client\Pages\Basics\Branch\ListBranch.razor"
                         foreach (var item in Branches)
                        {

#line default
#line hidden
            __builder.AddContent(34, "                            ");
            __builder.OpenElement(35, "tr");
            __builder.AddMarkupContent(36, "\r\n                                ");
            __builder.OpenElement(37, "td");
            __builder.AddContent(38, 
#line 33 "C:\Users\Alejandro Chávez\Documents\PRAXIS\PRAX\PRAXYS\PRAXYS\Client\Pages\Basics\Branch\ListBranch.razor"
                                     item.Name

#line default
#line hidden
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(39, "\r\n                                ");
            __builder.OpenElement(40, "td");
            __builder.AddContent(41, 
#line 34 "C:\Users\Alejandro Chávez\Documents\PRAXIS\PRAX\PRAXYS\PRAXYS\Client\Pages\Basics\Branch\ListBranch.razor"
                                     item.Alias

#line default
#line hidden
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(42, "\r\n                                ");
            __builder.OpenElement(43, "td");
            __builder.AddMarkupContent(44, "\r\n                                    ");
            __builder.OpenElement(45, "div");
            __builder.AddAttribute(46, "class", "btn-group");
            __builder.AddMarkupContent(47, "\r\n                                        ");
            __builder.AddMarkupContent(48, "<button class=\"btn btn-light\">Editar</button>\r\n                                        ");
            __builder.OpenElement(49, "button");
            __builder.AddAttribute(50, "class", "btn btn-light");
            __builder.AddAttribute(51, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#line 38 "C:\Users\Alejandro Chávez\Documents\PRAXIS\PRAX\PRAXYS\PRAXYS\Client\Pages\Basics\Branch\ListBranch.razor"
                                                                                  () => Delete(item.ID)

#line default
#line hidden
            ));
            __builder.AddContent(52, "Eliminar");
            __builder.CloseElement();
            __builder.AddMarkupContent(53, "\r\n                                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(54, "\r\n                                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(55, "\r\n                            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(56, "\r\n");
#line 42 "C:\Users\Alejandro Chávez\Documents\PRAXIS\PRAX\PRAXYS\PRAXYS\Client\Pages\Basics\Branch\ListBranch.razor"
                        }

#line default
#line hidden
            __builder.AddContent(57, "                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(58, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(59, "\r\n");
#line 45 "C:\Users\Alejandro Chávez\Documents\PRAXIS\PRAX\PRAXYS\PRAXYS\Client\Pages\Basics\Branch\ListBranch.razor"
            }
            else
            {

#line default
#line hidden
            __builder.AddContent(60, "                ");
            __builder.AddMarkupContent(61, "<div class=\"d-flex justify-content-center\">\r\n                    <div class=\"spinner-grow avatar-lg text-secondary m-2 text-center\" role=\"status\"></div>\r\n                </div>\r\n");
#line 51 "C:\Users\Alejandro Chávez\Documents\PRAXIS\PRAX\PRAXYS\PRAXYS\Client\Pages\Basics\Branch\ListBranch.razor"
            }

#line default
#line hidden
            __builder.AddContent(62, "        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(63, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(64, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(65, "\r\n");
            __Blazor.PRAXYS.Client.Pages.Basics.Branch.ListBranch.TypeInference.CreateCascadingValue_0(__builder, 66, 67, 
#line 55 "C:\Users\Alejandro Chávez\Documents\PRAXIS\PRAX\PRAXYS\PRAXYS\Client\Pages\Basics\Branch\ListBranch.razor"
                       this

#line default
#line hidden
            , 68, (__builder2) => {
                __builder2.AddMarkupContent(69, "\r\n    ");
                __builder2.OpenComponent<BlazorStrap.BSModal>(70);
                __builder2.AddAttribute(71, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(72, "\r\n        ");
                    __builder3.OpenComponent<BlazorStrap.BSModalHeader>(73);
                    __builder3.AddAttribute(74, "OnClick", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#line 57 "C:\Users\Alejandro Chávez\Documents\PRAXIS\PRAX\PRAXYS\PRAXYS\Client\Pages\Basics\Branch\ListBranch.razor"
                                  () => Modal.Hide()

#line default
#line hidden
                    )));
                    __builder3.AddAttribute(75, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddContent(76, "Modal title");
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(77, "\r\n        ");
                    __builder3.OpenComponent<BlazorStrap.BSModalBody>(78);
                    __builder3.AddAttribute(79, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddMarkupContent(80, "\r\n            ");
                        __builder4.AddContent(81, 
#line 59 "C:\Users\Alejandro Chávez\Documents\PRAXIS\PRAX\PRAXYS\PRAXYS\Client\Pages\Basics\Branch\ListBranch.razor"
             ModalContent

#line default
#line hidden
                        );
                        __builder4.AddMarkupContent(82, "\r\n        ");
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(83, "\r\n    ");
                }
                ));
                __builder2.AddComponentReferenceCapture(84, (__value) => {
#line 56 "C:\Users\Alejandro Chávez\Documents\PRAXIS\PRAX\PRAXYS\PRAXYS\Client\Pages\Basics\Branch\ListBranch.razor"
                   Modal = (BlazorStrap.BSModal)__value;

#line default
#line hidden
                }
                );
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(85, "\r\n");
            }
            );
        }
        #pragma warning restore 1998
#line 65 "C:\Users\Alejandro Chávez\Documents\PRAXIS\PRAX\PRAXYS\PRAXYS\Client\Pages\Basics\Branch\ListBranch.razor"
      
    RenderFragment ModalContent { get; set; }

    void AddBranch()
    {
        ModalContent = 

#line default
#line hidden
        (__builder2) => {
            __builder2.OpenComponent<PRAXYS.Client.Pages.Basics.Branch.AddBranch>(86);
            __builder2.CloseComponent();
        }
#line 70 "C:\Users\Alejandro Chávez\Documents\PRAXIS\PRAX\PRAXYS\PRAXYS\Client\Pages\Basics\Branch\ListBranch.razor"
                                     ;
        Modal.Show();
    }



#line default
#line hidden
    }
}
namespace __Blazor.PRAXYS.Client.Pages.Basics.Branch.ListBranch
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
