#pragma checksum "C:\Users\Alejandro Chávez\Documents\PRAXIS\PRAX\PRAXYS\PRAXYS\Client\Pages\SubAgents\SubAgentForm.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "df4fec60633f28ee2af3a07ac264f9aa8d4fc3b6"
// <auto-generated/>
#pragma warning disable 1591
namespace PRAXYS.Client.Pages.SubAgents
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
    public partial class SubAgentForm : SubAgentFormBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(0);
            __builder.AddAttribute(1, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#line 3 "C:\Users\Alejandro Chávez\Documents\PRAXIS\PRAX\PRAXYS\PRAXYS\Client\Pages\SubAgents\SubAgentForm.razor"
                 SubAgent

#line default
#line hidden
            ));
            __builder.AddAttribute(2, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#line 3 "C:\Users\Alejandro Chávez\Documents\PRAXIS\PRAX\PRAXYS\PRAXYS\Client\Pages\SubAgents\SubAgentForm.razor"
                                          OnValidSubmit

#line default
#line hidden
            )));
            __builder.AddAttribute(3, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(4, "\r\n    ");
                __builder2.OpenElement(5, "div");
                __builder2.AddAttribute(6, "class", "text-center");
                __builder2.AddMarkupContent(7, "\r\n        ");
                __builder2.AddMarkupContent(8, "<strong class=\"text-info\">Fecha de captura: </strong> ");
                __builder2.AddContent(9, 
#line 5 "C:\Users\Alejandro Chávez\Documents\PRAXIS\PRAX\PRAXYS\PRAXYS\Client\Pages\SubAgents\SubAgentForm.razor"
                                                               SubAgent.IssueDate.Value.ToString("dd/MM/yyyy")

#line default
#line hidden
                );
                __builder2.AddMarkupContent(10, "\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(11, "\r\n\r\n    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(12);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(13, "\r\n\r\n    ");
                __builder2.OpenElement(14, "div");
                __builder2.AddAttribute(15, "class", "form-row");
                __builder2.AddMarkupContent(16, "\r\n        ");
                __builder2.OpenElement(17, "div");
                __builder2.AddAttribute(18, "class", "form-group col-md-2");
                __builder2.AddMarkupContent(19, "\r\n            ");
                __builder2.OpenComponent<MatBlazor.MatSelect>(20);
                __builder2.AddAttribute(21, "Label", "Entidad");
                __builder2.AddAttribute(22, "Enhanced", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#line 12 "C:\Users\Alejandro Chávez\Documents\PRAXIS\PRAX\PRAXYS\PRAXYS\Client\Pages\SubAgents\SubAgentForm.razor"
                                                  true

#line default
#line hidden
                ));
                __builder2.AddAttribute(23, "Style", "width:100%;");
                __builder2.AddAttribute(24, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#line 12 "C:\Users\Alejandro Chávez\Documents\PRAXIS\PRAX\PRAXYS\PRAXYS\Client\Pages\SubAgents\SubAgentForm.razor"
                                                                     SubAgent.PersonType

#line default
#line hidden
                ));
                __builder2.AddAttribute(25, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => SubAgent.PersonType = __value, SubAgent.PersonType))));
                __builder2.AddAttribute(26, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(27, "\r\n                ");
                    __builder3.OpenComponent<MatBlazor.MatOption>(28);
                    __builder3.AddAttribute(29, "Value", "");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(30, "\r\n                ");
                    __builder3.OpenComponent<MatBlazor.MatOption>(31);
                    __builder3.AddAttribute(32, "Value", "Fisica");
                    __builder3.AddAttribute(33, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddContent(34, "Fisica");
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(35, "\r\n                ");
                    __builder3.OpenComponent<MatBlazor.MatOption>(36);
                    __builder3.AddAttribute(37, "Value", "Moral");
                    __builder3.AddAttribute(38, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddContent(39, "Moral");
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(40, "\r\n            ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(41, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(42, "\r\n\r\n        ");
                __builder2.AddMarkupContent(43, "<div class=\"form-group col-md-2\">\r\n\r\n        </div>\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(44, "\r\n\r\n    <hr style=\"border: .5px solid #c1d1d7\">\r\n\r\n");
#line 26 "C:\Users\Alejandro Chávez\Documents\PRAXIS\PRAX\PRAXYS\PRAXYS\Client\Pages\SubAgents\SubAgentForm.razor"
     if (SubAgent.PersonType == "Fisica")
    {

#line default
#line hidden
                __builder2.AddContent(45, "        ");
                __builder2.OpenElement(46, "div");
                __builder2.AddAttribute(47, "class", "form-row");
                __builder2.AddMarkupContent(48, "\r\n            ");
                __builder2.OpenElement(49, "div");
                __builder2.AddAttribute(50, "class", "form-group col-md-4");
                __builder2.AddMarkupContent(51, "\r\n                ");
                __builder2.OpenComponent<MatBlazor.MatTextField>(52);
                __builder2.AddAttribute(53, "Disabled", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#line 30 "C:\Users\Alejandro Chávez\Documents\PRAXIS\PRAX\PRAXYS\PRAXYS\Client\Pages\SubAgents\SubAgentForm.razor"
                                        ReadOnly

#line default
#line hidden
                ));
                __builder2.AddAttribute(54, "ReadOnly", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#line 30 "C:\Users\Alejandro Chávez\Documents\PRAXIS\PRAX\PRAXYS\PRAXYS\Client\Pages\SubAgents\SubAgentForm.razor"
                                                            ReadOnly

#line default
#line hidden
                ));
                __builder2.AddAttribute(55, "Label", "Apellido Paterno");
                __builder2.AddAttribute(56, "Style", "width:100%;");
                __builder2.AddAttribute(57, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#line 30 "C:\Users\Alejandro Chávez\Documents\PRAXIS\PRAX\PRAXYS\PRAXYS\Client\Pages\SubAgents\SubAgentForm.razor"
                                                                                                            SubAgent.LastName

#line default
#line hidden
                ));
                __builder2.AddAttribute(58, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => SubAgent.LastName = __value, SubAgent.LastName))));
                __builder2.AddAttribute(59, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => SubAgent.LastName));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(60, "\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(61, "\r\n            ");
                __builder2.OpenElement(62, "div");
                __builder2.AddAttribute(63, "class", "form-group col-md-4");
                __builder2.AddMarkupContent(64, "\r\n                ");
                __builder2.OpenComponent<MatBlazor.MatTextField>(65);
                __builder2.AddAttribute(66, "ReadOnly", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#line 33 "C:\Users\Alejandro Chávez\Documents\PRAXIS\PRAX\PRAXYS\PRAXYS\Client\Pages\SubAgents\SubAgentForm.razor"
                                        ReadOnly

#line default
#line hidden
                ));
                __builder2.AddAttribute(67, "Label", "Apellido Materno");
                __builder2.AddAttribute(68, "Style", "width:100%;");
                __builder2.AddAttribute(69, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#line 33 "C:\Users\Alejandro Chávez\Documents\PRAXIS\PRAX\PRAXYS\PRAXYS\Client\Pages\SubAgents\SubAgentForm.razor"
                                                                                        SubAgent.SecondLastName

#line default
#line hidden
                ));
                __builder2.AddAttribute(70, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => SubAgent.SecondLastName = __value, SubAgent.SecondLastName))));
                __builder2.AddAttribute(71, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => SubAgent.SecondLastName));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(72, "\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(73, "\r\n            ");
                __builder2.OpenElement(74, "div");
                __builder2.AddAttribute(75, "class", "form-group col-md-4");
                __builder2.AddMarkupContent(76, "\r\n                ");
                __builder2.OpenComponent<MatBlazor.MatTextField>(77);
                __builder2.AddAttribute(78, "ReadOnly", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#line 36 "C:\Users\Alejandro Chávez\Documents\PRAXIS\PRAX\PRAXYS\PRAXYS\Client\Pages\SubAgents\SubAgentForm.razor"
                                        ReadOnly

#line default
#line hidden
                ));
                __builder2.AddAttribute(79, "Label", "Nombre(s)");
                __builder2.AddAttribute(80, "Style", "width:100%;");
                __builder2.AddAttribute(81, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#line 36 "C:\Users\Alejandro Chávez\Documents\PRAXIS\PRAX\PRAXYS\PRAXYS\Client\Pages\SubAgents\SubAgentForm.razor"
                                                                                 SubAgent.Name

#line default
#line hidden
                ));
                __builder2.AddAttribute(82, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => SubAgent.Name = __value, SubAgent.Name))));
                __builder2.AddAttribute(83, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => SubAgent.Name));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(84, "\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(85, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(86, "\r\n");
#line 39 "C:\Users\Alejandro Chávez\Documents\PRAXIS\PRAX\PRAXYS\PRAXYS\Client\Pages\SubAgents\SubAgentForm.razor"
    }
    else
    {

#line default
#line hidden
                __builder2.AddContent(87, "        ");
                __builder2.OpenElement(88, "div");
                __builder2.AddAttribute(89, "class", "form-row");
                __builder2.AddMarkupContent(90, "\r\n            ");
                __builder2.OpenElement(91, "div");
                __builder2.AddAttribute(92, "class", "form-group col-md-12");
                __builder2.AddMarkupContent(93, "\r\n                ");
                __builder2.OpenComponent<MatBlazor.MatTextField>(94);
                __builder2.AddAttribute(95, "ReadOnly", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#line 44 "C:\Users\Alejandro Chávez\Documents\PRAXIS\PRAX\PRAXYS\PRAXYS\Client\Pages\SubAgents\SubAgentForm.razor"
                                        ReadOnly

#line default
#line hidden
                ));
                __builder2.AddAttribute(96, "Label", "Razon social");
                __builder2.AddAttribute(97, "Style", "width:100%;");
                __builder2.AddAttribute(98, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#line 44 "C:\Users\Alejandro Chávez\Documents\PRAXIS\PRAX\PRAXYS\PRAXYS\Client\Pages\SubAgents\SubAgentForm.razor"
                                                                                    SubAgent.CompanyName

#line default
#line hidden
                ));
                __builder2.AddAttribute(99, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => SubAgent.CompanyName = __value, SubAgent.CompanyName))));
                __builder2.AddAttribute(100, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => SubAgent.CompanyName));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(101, "\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(102, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(103, "\r\n");
#line 47 "C:\Users\Alejandro Chávez\Documents\PRAXIS\PRAX\PRAXYS\PRAXYS\Client\Pages\SubAgents\SubAgentForm.razor"
    }

#line default
#line hidden
                __builder2.AddMarkupContent(104, "\r\n    <hr style=\"border: .5px solid #c1d1d7\">\r\n\r\n    ");
                __builder2.OpenElement(105, "div");
                __builder2.AddAttribute(106, "class", "form-row");
                __builder2.AddMarkupContent(107, "\r\n        ");
                __builder2.OpenElement(108, "div");
                __builder2.AddAttribute(109, "class", "form-group col-4");
                __builder2.AddMarkupContent(110, "\r\n            ");
                __builder2.OpenComponent<MatBlazor.MatDatePicker>(111);
                __builder2.AddAttribute(112, "Disabled", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#line 53 "C:\Users\Alejandro Chávez\Documents\PRAXIS\PRAX\PRAXYS\PRAXYS\Client\Pages\SubAgents\SubAgentForm.razor"
                                     ReadOnly

#line default
#line hidden
                ));
                __builder2.AddAttribute(113, "Label", "Fecha de Expiracion");
                __builder2.AddAttribute(114, "EnableTime", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#line 53 "C:\Users\Alejandro Chávez\Documents\PRAXIS\PRAX\PRAXYS\PRAXYS\Client\Pages\SubAgents\SubAgentForm.razor"
                                                                                                                             false

#line default
#line hidden
                ));
                __builder2.AddAttribute(115, "DateFormat", "d-m-Y");
                __builder2.AddAttribute(116, "Style", "width:100%;");
                __builder2.AddAttribute(117, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.DateTime?>(
#line 53 "C:\Users\Alejandro Chávez\Documents\PRAXIS\PRAX\PRAXYS\PRAXYS\Client\Pages\SubAgents\SubAgentForm.razor"
                                                                                        SubAgent.ExpirationDate

#line default
#line hidden
                ));
                __builder2.AddAttribute(118, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.DateTime?>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.DateTime?>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => SubAgent.ExpirationDate = __value, SubAgent.ExpirationDate))));
                __builder2.AddAttribute(119, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.DateTime?>>>(() => SubAgent.ExpirationDate));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(120, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(121, "\r\n        ");
                __builder2.OpenElement(122, "div");
                __builder2.AddAttribute(123, "class", "form-group col-4");
                __builder2.AddMarkupContent(124, "\r\n            ");
                __builder2.OpenComponent<MatBlazor.MatTextField>(125);
                __builder2.AddAttribute(126, "Disabled", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#line 56 "C:\Users\Alejandro Chávez\Documents\PRAXIS\PRAX\PRAXYS\PRAXYS\Client\Pages\SubAgents\SubAgentForm.razor"
                                    ReadOnly

#line default
#line hidden
                ));
                __builder2.AddAttribute(127, "Label", "Numero de Telefono");
                __builder2.AddAttribute(128, "Style", "width:100%;");
                __builder2.AddAttribute(129, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#line 56 "C:\Users\Alejandro Chávez\Documents\PRAXIS\PRAX\PRAXYS\PRAXYS\Client\Pages\SubAgents\SubAgentForm.razor"
                                                                                      SubAgent.PhoneNumber

#line default
#line hidden
                ));
                __builder2.AddAttribute(130, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => SubAgent.PhoneNumber = __value, SubAgent.PhoneNumber))));
                __builder2.AddAttribute(131, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => SubAgent.PhoneNumber));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(132, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(133, "\r\n        ");
                __builder2.OpenElement(134, "div");
                __builder2.AddAttribute(135, "class", "form-group col-4");
                __builder2.AddMarkupContent(136, "\r\n            ");
                __builder2.OpenComponent<MatBlazor.MatTextField>(137);
                __builder2.AddAttribute(138, "Disabled", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#line 59 "C:\Users\Alejandro Chávez\Documents\PRAXIS\PRAX\PRAXYS\PRAXYS\Client\Pages\SubAgents\SubAgentForm.razor"
                                    ReadOnly

#line default
#line hidden
                ));
                __builder2.AddAttribute(139, "Label", "Correo Electronico");
                __builder2.AddAttribute(140, "Style", "width:100%;");
                __builder2.AddAttribute(141, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#line 59 "C:\Users\Alejandro Chávez\Documents\PRAXIS\PRAX\PRAXYS\PRAXYS\Client\Pages\SubAgents\SubAgentForm.razor"
                                                                                      SubAgent.PersonalEmail

#line default
#line hidden
                ));
                __builder2.AddAttribute(142, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => SubAgent.PersonalEmail = __value, SubAgent.PersonalEmail))));
                __builder2.AddAttribute(143, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => SubAgent.PersonalEmail));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(144, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(145, "\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(146, "\r\n\r\n    <hr style=\"border: .5px solid #c1d1d7\">\r\n\r\n    ");
                __builder2.OpenElement(147, "div");
                __builder2.AddAttribute(148, "class", "form-row");
                __builder2.AddMarkupContent(149, "\r\n        ");
                __builder2.OpenElement(150, "div");
                __builder2.AddAttribute(151, "class", "form-group col-4");
                __builder2.AddMarkupContent(152, "\r\n            ");
                __builder2.OpenComponent<MatBlazor.MatTextField>(153);
                __builder2.AddAttribute(154, "ReadOnly", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#line 67 "C:\Users\Alejandro Chávez\Documents\PRAXIS\PRAX\PRAXYS\PRAXYS\Client\Pages\SubAgents\SubAgentForm.razor"
                                    ReadOnly

#line default
#line hidden
                ));
                __builder2.AddAttribute(155, "Label", "RFC");
                __builder2.AddAttribute(156, "Style", "width:100%;");
                __builder2.AddAttribute(157, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#line 67 "C:\Users\Alejandro Chávez\Documents\PRAXIS\PRAX\PRAXYS\PRAXYS\Client\Pages\SubAgents\SubAgentForm.razor"
                                                                       SubAgent.RFC

#line default
#line hidden
                ));
                __builder2.AddAttribute(158, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => SubAgent.RFC = __value, SubAgent.RFC))));
                __builder2.AddAttribute(159, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => SubAgent.RFC));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(160, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(161, "\r\n        ");
                __builder2.OpenElement(162, "div");
                __builder2.AddAttribute(163, "class", "form-group col-4");
                __builder2.AddMarkupContent(164, "\r\n            ");
                __builder2.OpenComponent<MatBlazor.MatTextField>(165);
                __builder2.AddAttribute(166, "ReadOnly", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#line 70 "C:\Users\Alejandro Chávez\Documents\PRAXIS\PRAX\PRAXYS\PRAXYS\Client\Pages\SubAgents\SubAgentForm.razor"
                                    ReadOnly

#line default
#line hidden
                ));
                __builder2.AddAttribute(167, "Label", "Numero de Identificacion");
                __builder2.AddAttribute(168, "Style", "width:100%;");
                __builder2.AddAttribute(169, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#line 70 "C:\Users\Alejandro Chávez\Documents\PRAXIS\PRAX\PRAXYS\PRAXYS\Client\Pages\SubAgents\SubAgentForm.razor"
                                                                                            SubAgent.IdentificationNumber

#line default
#line hidden
                ));
                __builder2.AddAttribute(170, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => SubAgent.IdentificationNumber = __value, SubAgent.IdentificationNumber))));
                __builder2.AddAttribute(171, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => SubAgent.IdentificationNumber));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(172, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(173, "\r\n        ");
                __builder2.OpenElement(174, "div");
                __builder2.AddAttribute(175, "class", "form-group col-4");
                __builder2.AddMarkupContent(176, "\r\n            ");
                __builder2.OpenComponent<MatBlazor.MatTextField>(177);
                __builder2.AddAttribute(178, "ReadOnly", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#line 73 "C:\Users\Alejandro Chávez\Documents\PRAXIS\PRAX\PRAXYS\PRAXYS\Client\Pages\SubAgents\SubAgentForm.razor"
                                    ReadOnly

#line default
#line hidden
                ));
                __builder2.AddAttribute(179, "Label", "Numero de Identificacion");
                __builder2.AddAttribute(180, "Style", "width:100%;");
                __builder2.AddAttribute(181, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#line 73 "C:\Users\Alejandro Chávez\Documents\PRAXIS\PRAX\PRAXYS\PRAXYS\Client\Pages\SubAgents\SubAgentForm.razor"
                                                                                            SubAgent.Bank

#line default
#line hidden
                ));
                __builder2.AddAttribute(182, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => SubAgent.Bank = __value, SubAgent.Bank))));
                __builder2.AddAttribute(183, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => SubAgent.Bank));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(184, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(185, "\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(186, "\r\n\r\n");
#line 77 "C:\Users\Alejandro Chávez\Documents\PRAXIS\PRAX\PRAXYS\PRAXYS\Client\Pages\SubAgents\SubAgentForm.razor"
     if (!ReadOnly)
    {

#line default
#line hidden
                __builder2.AddContent(187, "        ");
                __builder2.AddMarkupContent(188, @"<div class=""form-row"">
            <div class=""col-12 d-flex justify-content-end"">
                <button type=""submit"" class=""btn btn-blue waves-effect waves-light"">
                    <span class=""btn-label""><i class=""far fa-save""></i></span>Guardar Datos
                </button>
            </div>
        </div>
");
#line 86 "C:\Users\Alejandro Chávez\Documents\PRAXIS\PRAX\PRAXYS\PRAXYS\Client\Pages\SubAgents\SubAgentForm.razor"
    }

#line default
#line hidden
                __builder2.AddMarkupContent(189, "\r\n");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
