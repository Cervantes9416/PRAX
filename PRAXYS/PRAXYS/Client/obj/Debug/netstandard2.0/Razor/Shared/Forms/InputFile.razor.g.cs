#pragma checksum "C:\Users\Alejandro Chávez\Documents\BitBucket_Projects\PRAXYS\PRAXYS\Client\Shared\Forms\InputFile.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "064f771325c9faf1efd9f604266cc51f0d79b77f"
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
#line 1 "C:\Users\Alejandro Chávez\Documents\BitBucket_Projects\PRAXYS\PRAXYS\Client\Shared\Forms\InputFile.razor"
using PRAXYS.Commons.Interfaces;

#line default
#line hidden
    public partial class InputFile : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "border");
            __builder.AddAttribute(2, "style", "min-height:70vh");
            __builder.AddMarkupContent(3, "\r\n");
#line 4 "C:\Users\Alejandro Chávez\Documents\BitBucket_Projects\PRAXYS\PRAXYS\Client\Shared\Forms\InputFile.razor"
         if (DocumentationList == null)
        {

#line default
#line hidden
            __builder.AddContent(4, "            ");
            __builder.AddMarkupContent(5, "<div class=\"d-flex justify-content-center align-items-center h-75 \">\r\n                <div class=\"spinner-grow avatar-lg text-secondary m-2 text-center\" role=\"status\"></div>\r\n            </div>\r\n");
#line 9 "C:\Users\Alejandro Chávez\Documents\BitBucket_Projects\PRAXYS\PRAXYS\Client\Shared\Forms\InputFile.razor"
        }
        else if (DocumentationList.Count == 0)
        {

#line default
#line hidden
            __builder.AddContent(6, "            ");
            __builder.OpenElement(7, "div");
            __builder.AddAttribute(8, "class", "btn-group ");
            __builder.AddMarkupContent(9, "\r\n                ");
            __builder.OpenElement(10, "button");
            __builder.AddAttribute(11, "class", "btn btn-light");
            __builder.AddAttribute(12, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#line 13 "C:\Users\Alejandro Chávez\Documents\BitBucket_Projects\PRAXYS\PRAXYS\Client\Shared\Forms\InputFile.razor"
                                                          () => Modal.Show()

#line default
#line hidden
            ));
            __builder.AddMarkupContent(13, "<i class=\"fas fa-plus\"></i>");
            __builder.CloseElement();
            __builder.AddMarkupContent(14, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(15, "\r\n            ");
            __builder.OpenElement(16, "div");
            __builder.AddAttribute(17, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#line 15 "C:\Users\Alejandro Chávez\Documents\BitBucket_Projects\PRAXYS\PRAXYS\Client\Shared\Forms\InputFile.razor"
                             () => Modal.Show()

#line default
#line hidden
            ));
            __builder.AddAttribute(18, "style", "cursor:pointer; min-height:70vh");
            __builder.AddAttribute(19, "class", "d-flex flex-column justify-content-center align-items-center h-75 text-center p-2");
            __builder.AddMarkupContent(20, "\r\n                <i class=\"far fa-folder-open fa-4x\"></i>\r\n                ");
            __builder.AddMarkupContent(21, "<h4>No se ha encontrado ningun archivo</h4>\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(22, "\r\n");
#line 19 "C:\Users\Alejandro Chávez\Documents\BitBucket_Projects\PRAXYS\PRAXYS\Client\Shared\Forms\InputFile.razor"
        }
        else
        {

#line default
#line hidden
            __builder.AddContent(23, "            ");
            __builder.OpenElement(24, "div");
            __builder.AddAttribute(25, "class", "btn-group justify-content-center");
            __builder.AddMarkupContent(26, "\r\n                ");
            __builder.OpenElement(27, "button");
            __builder.AddAttribute(28, "class", "btn btn-light");
            __builder.AddAttribute(29, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#line 23 "C:\Users\Alejandro Chávez\Documents\BitBucket_Projects\PRAXYS\PRAXYS\Client\Shared\Forms\InputFile.razor"
                                                          () => Modal.Show()

#line default
#line hidden
            ));
            __builder.AddMarkupContent(30, "<i class=\"fas fa-plus\"></i>");
            __builder.CloseElement();
            __builder.AddMarkupContent(31, "\r\n                ");
            __builder.AddMarkupContent(32, "<button class=\"btn btn-light\"><i class=\"far fa-trash-alt\"></i></button>\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(33, "\r\n            ");
            __builder.OpenComponent<MatBlazor.MatNavMenu>(34);
            __builder.AddAttribute(35, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(36, "\r\n                ");
                __builder2.OpenComponent<MatBlazor.MatNavSubMenu>(37);
                __builder2.AddAttribute(38, "Expanded", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#line 27 "C:\Users\Alejandro Chávez\Documents\BitBucket_Projects\PRAXYS\PRAXYS\Client\Shared\Forms\InputFile.razor"
                                         true

#line default
#line hidden
                ));
                __builder2.AddAttribute(39, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(40, "\r\n                    ");
                    __builder3.OpenComponent<MatBlazor.MatNavSubMenuHeader>(41);
                    __builder3.AddAttribute(42, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddMarkupContent(43, "\r\n                        ");
                        __builder4.OpenComponent<MatBlazor.MatNavItem>(44);
                        __builder4.AddAttribute(45, "AllowSelection", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#line 29 "C:\Users\Alejandro Chávez\Documents\BitBucket_Projects\PRAXYS\PRAXYS\Client\Shared\Forms\InputFile.razor"
                                                    true

#line default
#line hidden
                        ));
                        __builder4.AddAttribute(46, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.AddMarkupContent(47, "\r\n                            ");
                            __builder5.OpenComponent<MatBlazor.MatIcon>(48);
                            __builder5.AddAttribute(49, "Icon", "folder");
                            __builder5.CloseComponent();
                            __builder5.AddMarkupContent(50, "...\r\n                        ");
                        }
                        ));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(51, "\r\n                    ");
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(52, "\r\n                    ");
                    __builder3.OpenComponent<MatBlazor.MatNavSubMenuList>(53);
                    __builder3.AddAttribute(54, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddMarkupContent(55, "\r\n");
#line 34 "C:\Users\Alejandro Chávez\Documents\BitBucket_Projects\PRAXYS\PRAXYS\Client\Shared\Forms\InputFile.razor"
                         foreach (var item in DocumentationList)
                        {

#line default
#line hidden
                        __builder4.AddContent(56, "                            ");
                        __builder4.OpenComponent<BlazorContextMenu.ContextMenuTrigger>(57);
                        __builder4.AddAttribute(58, "MenuId", "itemMenu");
                        __builder4.AddAttribute(59, "Data", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#line 36 "C:\Users\Alejandro Chávez\Documents\BitBucket_Projects\PRAXYS\PRAXYS\Client\Shared\Forms\InputFile.razor"
                                                                        item

#line default
#line hidden
                        ));
                        __builder4.AddAttribute(60, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.AddMarkupContent(61, "\r\n                                ");
                            __builder5.OpenComponent<MatBlazor.MatNavItem>(62);
                            __builder5.AddAttribute(63, "AllowSelection", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#line 37 "C:\Users\Alejandro Chávez\Documents\BitBucket_Projects\PRAXYS\PRAXYS\Client\Shared\Forms\InputFile.razor"
                                                            false

#line default
#line hidden
                            ));
                            __builder5.AddAttribute(64, "Href", "");
                            __builder5.AddAttribute(65, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder6) => {
                                __builder6.AddMarkupContent(66, "\r\n                                    <i class=\"far fa-file\"></i>&nbsp;\r\n                                    ");
                                __builder6.AddContent(67, 
#line 39 "C:\Users\Alejandro Chávez\Documents\BitBucket_Projects\PRAXYS\PRAXYS\Client\Shared\Forms\InputFile.razor"
                                     item.ID

#line default
#line hidden
                                );
                                __builder6.AddContent(68, " - ");
                                __builder6.AddContent(69, 
#line 39 "C:\Users\Alejandro Chávez\Documents\BitBucket_Projects\PRAXYS\PRAXYS\Client\Shared\Forms\InputFile.razor"
                                                item.FileName

#line default
#line hidden
                                );
                                __builder6.AddMarkupContent(70, "\r\n                                ");
                            }
                            ));
                            __builder5.CloseComponent();
                            __builder5.AddMarkupContent(71, "\r\n                            ");
                        }
                        ));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(72, "\r\n");
#line 42 "C:\Users\Alejandro Chávez\Documents\BitBucket_Projects\PRAXYS\PRAXYS\Client\Shared\Forms\InputFile.razor"
                        }

#line default
#line hidden
                        __builder4.AddContent(73, "                    ");
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(74, "\r\n                ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(75, "\r\n            ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(76, "\r\n");
#line 46 "C:\Users\Alejandro Chávez\Documents\BitBucket_Projects\PRAXYS\PRAXYS\Client\Shared\Forms\InputFile.razor"
        }

#line default
#line hidden
            __builder.AddContent(77, "    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(78, "\r\n\r\n\r\n\r\n");
            __builder.OpenComponent<BlazorContextMenu.ContextMenu>(79);
            __builder.AddAttribute(80, "Id", "itemMenu");
            __builder.AddAttribute(81, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(82, "\r\n    ");
                __builder2.OpenComponent<BlazorContextMenu.Item>(83);
                __builder2.AddAttribute(84, "OnClick", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<BlazorContextMenu.ItemClickEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<BlazorContextMenu.ItemClickEventArgs>(this, 
#line 53 "C:\Users\Alejandro Chávez\Documents\BitBucket_Projects\PRAXYS\PRAXYS\Client\Shared\Forms\InputFile.razor"
                     () => Modal.Show()

#line default
#line hidden
                )));
                __builder2.AddAttribute(85, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(86, "<i class=\"fas fa-file-upload\"></i>&nbsp;Subir nuevo Archivo");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(87, "\r\n    ");
                __builder2.OpenComponent<BlazorContextMenu.Item>(88);
                __builder2.AddAttribute(89, "OnClick", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<BlazorContextMenu.ItemClickEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<BlazorContextMenu.ItemClickEventArgs>(this, 
#line 54 "C:\Users\Alejandro Chávez\Documents\BitBucket_Projects\PRAXYS\PRAXYS\Client\Shared\Forms\InputFile.razor"
                   DeleteClick

#line default
#line hidden
                )));
                __builder2.AddAttribute(90, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(91, "<i class=\"far fa-trash-alt\"></i>&nbsp;Eliminar Archivo");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(92, "\r\n    ");
                __builder2.OpenComponent<MatBlazor.MatDivider>(93);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(94, "\r\n    ");
                __builder2.OpenComponent<BlazorContextMenu.Item>(95);
                __builder2.AddAttribute(96, "OnClick", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<BlazorContextMenu.ItemClickEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<BlazorContextMenu.ItemClickEventArgs>(this, 
#line 56 "C:\Users\Alejandro Chávez\Documents\BitBucket_Projects\PRAXYS\PRAXYS\Client\Shared\Forms\InputFile.razor"
                   ViewClick

#line default
#line hidden
                )));
                __builder2.AddAttribute(97, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(98, "<i class=\"fas fa-search\"></i>&nbsp;Revisar Archivo");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(99, "\r\n    ");
                __builder2.OpenComponent<BlazorContextMenu.Item>(100);
                __builder2.AddAttribute(101, "OnClick", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<BlazorContextMenu.ItemClickEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<BlazorContextMenu.ItemClickEventArgs>(this, 
#line 57 "C:\Users\Alejandro Chávez\Documents\BitBucket_Projects\PRAXYS\PRAXYS\Client\Shared\Forms\InputFile.razor"
                   DownloadClick

#line default
#line hidden
                )));
                __builder2.AddAttribute(102, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(103, "<i class=\"fas fa-cloud-download-alt\"></i>&nbsp;Descargar");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(104, "\r\n");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(105, "\r\n\r\n");
            __builder.OpenComponent<BlazorStrap.BSModal>(106);
            __builder.AddAttribute(107, "IsCentered", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#line 60 "C:\Users\Alejandro Chávez\Documents\BitBucket_Projects\PRAXYS\PRAXYS\Client\Shared\Forms\InputFile.razor"
                                  true

#line default
#line hidden
            ));
            __builder.AddAttribute(108, "Size", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<BlazorStrap.Size>(
#line 60 "C:\Users\Alejandro Chávez\Documents\BitBucket_Projects\PRAXYS\PRAXYS\Client\Shared\Forms\InputFile.razor"
                                              Size.Medium

#line default
#line hidden
            ));
            __builder.AddAttribute(109, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(110, "\r\n    ");
                __builder2.OpenComponent<BlazorStrap.BSModalHeader>(111);
                __builder2.AddAttribute(112, "OnClick", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#line 61 "C:\Users\Alejandro Chávez\Documents\BitBucket_Projects\PRAXYS\PRAXYS\Client\Shared\Forms\InputFile.razor"
                              () => Modal.Hide()

#line default
#line hidden
                )));
                __builder2.AddAttribute(113, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(114, "<h2>Subir Archivo</h2>");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(115, "\r\n    ");
                __builder2.OpenComponent<BlazorStrap.BSModalBody>(116);
                __builder2.AddAttribute(117, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(118, "\r\n        ");
                    __builder3.OpenElement(119, "div");
                    __builder3.AddAttribute(120, "class", "col-12");
                    __builder3.AddMarkupContent(121, "\r\n            ");
                    __builder3.OpenElement(122, "div");
                    __builder3.AddAttribute(123, "class", "form-group");
                    __builder3.AddMarkupContent(124, "\r\n                ");
                    __builder3.AddMarkupContent(125, "<label>Tipo de archivo</label>\r\n                ");
                    __builder3.OpenElement(126, "select");
                    __builder3.AddAttribute(127, "class", "form-control");
                    __builder3.AddAttribute(128, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#line 66 "C:\Users\Alejandro Chávez\Documents\BitBucket_Projects\PRAXYS\PRAXYS\Client\Shared\Forms\InputFile.razor"
                                                    documentation.containerName

#line default
#line hidden
                    ));
                    __builder3.AddAttribute(129, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => documentation.containerName = __value, documentation.containerName));
                    __builder3.SetUpdatesAttributeName("value");
                    __builder3.AddMarkupContent(130, "\r\n                    ");
                    __builder3.OpenElement(131, "option");
                    __builder3.AddAttribute(132, "value", true);
                    __builder3.AddContent(133, "Seleccionar..");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(134, "\r\n                    ");
                    __builder3.OpenElement(135, "option");
                    __builder3.AddAttribute(136, "value", "acta");
                    __builder3.AddContent(137, "ACTA CONSTITUCIONAL");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(138, "\r\n                    ");
                    __builder3.OpenElement(139, "option");
                    __builder3.AddAttribute(140, "value", "identificacion");
                    __builder3.AddContent(141, "INE/IFE/LICENCIA");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(142, "\r\n                    ");
                    __builder3.OpenElement(143, "option");
                    __builder3.AddAttribute(144, "value", "comprobante");
                    __builder3.AddContent(145, "COMPROBANTE DE DOMICILIO");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(146, "\r\n                    ");
                    __builder3.OpenElement(147, "option");
                    __builder3.AddAttribute(148, "value", "documento");
                    __builder3.AddContent(149, "DOCUMENTO");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(150, "\r\n                    ");
                    __builder3.OpenElement(151, "option");
                    __builder3.AddAttribute(152, "value", "factura-fianza");
                    __builder3.AddMarkupContent(153, "FACTURA/TARJETA DE CIRCULACIÓN/PEDIMENTO");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(154, "\r\n                    ");
                    __builder3.OpenElement(155, "option");
                    __builder3.AddAttribute(156, "value", "fianza");
                    __builder3.AddContent(157, "FIANZA");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(158, "\r\n                    ");
                    __builder3.OpenElement(159, "option");
                    __builder3.AddAttribute(160, "value", "poliza");
                    __builder3.AddContent(161, "POLIZA");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(162, "\r\n                    ");
                    __builder3.OpenElement(163, "option");
                    __builder3.AddAttribute(164, "value", "representante");
                    __builder3.AddContent(165, "INE/IFE REPRESENTANTE LEGAL");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(166, "\r\n                    ");
                    __builder3.OpenElement(167, "option");
                    __builder3.AddAttribute(168, "value", "rfc");
                    __builder3.AddContent(169, "RFC");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(170, "\r\n                ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(171, "\r\n            ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(172, "\r\n\r\n            ");
                    __builder3.OpenElement(173, "div");
                    __builder3.AddAttribute(174, "class", "form-group");
                    __builder3.AddMarkupContent(175, "\r\n                ");
                    __builder3.OpenElement(176, "button");
                    __builder3.AddAttribute(177, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#line 81 "C:\Users\Alejandro Chávez\Documents\BitBucket_Projects\PRAXYS\PRAXYS\Client\Shared\Forms\InputFile.razor"
                                  SelectFile

#line default
#line hidden
                    ));
                    __builder3.AddAttribute(178, "class", "btn btn-blue");
                    __builder3.AddContent(179, "Buscar Archivo");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(180, "\r\n            ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(181, "\r\n        ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(182, "\r\n    ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(183, "\r\n");
            }
            ));
            __builder.AddComponentReferenceCapture(184, (__value) => {
#line 60 "C:\Users\Alejandro Chávez\Documents\BitBucket_Projects\PRAXYS\PRAXYS\Client\Shared\Forms\InputFile.razor"
               Modal = (BlazorStrap.BSModal)__value;

#line default
#line hidden
            }
            );
            __builder.CloseComponent();
            __builder.AddMarkupContent(185, "\r\n\r\n");
            __builder.OpenComponent<W8lessLabs.Blazor.LocalFiles.FileSelect>(186);
            __builder.AddAttribute(187, "Accept", ".xml,.pdf,.jpg");
            __builder.AddComponentReferenceCapture(188, (__value) => {
#line 87 "C:\Users\Alejandro Chávez\Documents\BitBucket_Projects\PRAXYS\PRAXYS\Client\Shared\Forms\InputFile.razor"
                  FileSelect = (W8lessLabs.Blazor.LocalFiles.FileSelect)__value;

#line default
#line hidden
            }
            );
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#line 89 "C:\Users\Alejandro Chávez\Documents\BitBucket_Projects\PRAXYS\PRAXYS\Client\Shared\Forms\InputFile.razor"
       
    [Parameter] public EventCallback UploadFile { get; set; }
    [Parameter] public EventCallback<int> DeleteFile { get; set; }
    [Parameter] public EventCallback<int> DownloadFile { get; set; }
    [Parameter] public EventCallback<int> ViewFile { get; set; }
    [Parameter] public List<IDocumentationEntity> DocumentationList { get; set; }
    [Parameter] public IDocumentationEntity documentation { get; set; }
    private FileSelect FileSelect;
    private string fileName;
    private string fileBase64;
    private string FrameUrl = "";
    private string FrameTitle = "";
    private BSModal  Modal;

    private void SelectFile()
    {
        FileSelect.SelectFiles(FilesToUpload);
    }

    async Task FilesToUpload(SelectedFile[] files)
    {
        var selectedFile = files.FirstOrDefault();
        fileName = selectedFile.Name;
        StateHasChanged();
        documentation.FileName = selectedFile.Name;
        documentation.FileExtension = selectedFile.Name.Substring(selectedFile.Name.Length - 4);

        using (var fileReader = FileSelect.GetFileReader(selectedFile))
        {
            var imageBytes = await fileReader.GetFileBytesAsync();
            fileBase64 = Convert.ToBase64String(imageBytes);
            documentation.fileBase64 = fileBase64;
            await UploadFile.InvokeAsync(null);
            selectedFile = null;
            StateHasChanged();
        }

        Modal.Hide();
    }

    async void DeleteClick(ItemClickEventArgs e)
    {
        var current = e.Data as IDocumentationEntity;
        await DeleteFile.InvokeAsync(current.ID);
    }

    async void DownloadClick(ItemClickEventArgs e)
    {
        var current = e.Data as IDocumentationEntity;
        await DownloadFile.InvokeAsync(current.ID);
    }

    async void ViewClick(ItemClickEventArgs e)
    {
        var current = e.Data as IDocumentationEntity;
        await ViewFile.InvokeAsync(current.ID);
        StateHasChanged();
    }

#line default
#line hidden
    }
}
#pragma warning restore 1591
