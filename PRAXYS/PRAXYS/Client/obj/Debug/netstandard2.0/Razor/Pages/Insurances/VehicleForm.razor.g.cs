#pragma checksum "C:\Users\Alejandro Chávez\Documents\BitBucket_Projects\PRAXYS\PRAXYS\Client\Pages\Insurances\VehicleForm.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f04b03be4c3beca1a954ada4971573bc68ba0d3f"
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
    public partial class VehicleForm : VehicleFormBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "row");
            __builder.AddMarkupContent(2, "\r\n    ");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "form-group col-lg-3");
            __builder.AddMarkupContent(5, "\r\n        ");
            __builder.AddMarkupContent(6, "<label>Marca</label>\r\n        ");
            __builder.OpenElement(7, "input");
            __builder.AddAttribute(8, "class", "form-control");
            __builder.AddAttribute(9, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#line 6 "C:\Users\Alejandro Chávez\Documents\BitBucket_Projects\PRAXYS\PRAXYS\Client\Pages\Insurances\VehicleForm.razor"
                            insurance.Brand

#line default
#line hidden
            ));
            __builder.AddAttribute(10, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => insurance.Brand = __value, insurance.Brand));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(11, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(12, "\r\n\r\n    ");
            __builder.OpenElement(13, "div");
            __builder.AddAttribute(14, "class", "form-group col-lg-3");
            __builder.AddMarkupContent(15, "\r\n        ");
            __builder.AddMarkupContent(16, "<label>Placas</label>\r\n        ");
            __builder.OpenElement(17, "input");
            __builder.AddAttribute(18, "class", "form-control");
            __builder.AddAttribute(19, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#line 11 "C:\Users\Alejandro Chávez\Documents\BitBucket_Projects\PRAXYS\PRAXYS\Client\Pages\Insurances\VehicleForm.razor"
                            insurance.Car_Plates

#line default
#line hidden
            ));
            __builder.AddAttribute(20, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => insurance.Car_Plates = __value, insurance.Car_Plates));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(22, "\r\n\r\n    ");
            __builder.OpenElement(23, "div");
            __builder.AddAttribute(24, "class", "form-group col-lg-3");
            __builder.AddMarkupContent(25, "\r\n        ");
            __builder.AddMarkupContent(26, "<label>Modal</label>\r\n        ");
            __builder.OpenElement(27, "input");
            __builder.AddAttribute(28, "class", "form-control");
            __builder.AddAttribute(29, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#line 16 "C:\Users\Alejandro Chávez\Documents\BitBucket_Projects\PRAXYS\PRAXYS\Client\Pages\Insurances\VehicleForm.razor"
                            insurance.Model

#line default
#line hidden
            ));
            __builder.AddAttribute(30, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => insurance.Model = __value, insurance.Model));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(31, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(32, "\r\n\r\n    ");
            __builder.OpenElement(33, "div");
            __builder.AddAttribute(34, "class", "form-group col-lg-3");
            __builder.AddMarkupContent(35, "\r\n        ");
            __builder.AddMarkupContent(36, "<label>Transmision</label>\r\n        ");
            __builder.OpenElement(37, "select");
            __builder.AddAttribute(38, "class", "form-control");
            __builder.AddAttribute(39, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#line 21 "C:\Users\Alejandro Chávez\Documents\BitBucket_Projects\PRAXYS\PRAXYS\Client\Pages\Insurances\VehicleForm.razor"
                                            insurance.Transmission

#line default
#line hidden
            ));
            __builder.AddAttribute(40, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => insurance.Transmission = __value, insurance.Transmission));
            __builder.SetUpdatesAttributeName("value");
            __builder.AddMarkupContent(41, "\r\n            ");
            __builder.OpenElement(42, "option");
            __builder.AddAttribute(43, "value", true);
            __builder.AddContent(44, "Seleccionar..");
            __builder.CloseElement();
            __builder.AddMarkupContent(45, "\r\n            ");
            __builder.OpenElement(46, "option");
            __builder.AddAttribute(47, "value", "Automatico");
            __builder.AddContent(48, "Automatico");
            __builder.CloseElement();
            __builder.AddMarkupContent(49, "\r\n            ");
            __builder.OpenElement(50, "option");
            __builder.AddAttribute(51, "value", "Estandar");
            __builder.AddContent(52, "Estandar");
            __builder.CloseElement();
            __builder.AddMarkupContent(53, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(54, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(55, "\r\n\r\n    ");
            __builder.OpenElement(56, "div");
            __builder.AddAttribute(57, "class", "form-group col-lg-3");
            __builder.AddMarkupContent(58, "\r\n        ");
            __builder.AddMarkupContent(59, "<label>Motor</label>\r\n        ");
            __builder.OpenElement(60, "input");
            __builder.AddAttribute(61, "class", "form-control");
            __builder.AddAttribute(62, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#line 30 "C:\Users\Alejandro Chávez\Documents\BitBucket_Projects\PRAXYS\PRAXYS\Client\Pages\Insurances\VehicleForm.razor"
                            insurance.Car_Motor

#line default
#line hidden
            ));
            __builder.AddAttribute(63, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => insurance.Car_Motor = __value, insurance.Car_Motor));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(64, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(65, "\r\n\r\n    ");
            __builder.OpenElement(66, "div");
            __builder.AddAttribute(67, "class", "form-group col-lg-2");
            __builder.AddMarkupContent(68, "\r\n        ");
            __builder.AddMarkupContent(69, "<label>Uso</label>\r\n        ");
            __builder.OpenElement(70, "select");
            __builder.AddAttribute(71, "class", "form-control");
            __builder.AddMarkupContent(72, "\r\n            ");
            __builder.OpenElement(73, "option");
            __builder.AddAttribute(74, "class", true);
            __builder.AddContent(75, "Selecionar..");
            __builder.CloseElement();
            __builder.AddMarkupContent(76, "\r\n            ");
            __builder.OpenElement(77, "option");
            __builder.AddAttribute(78, "class", "Particular");
            __builder.AddContent(79, "Particular");
            __builder.CloseElement();
            __builder.AddMarkupContent(80, "\r\n            ");
            __builder.OpenElement(81, "option");
            __builder.AddAttribute(82, "class", "Carga");
            __builder.AddContent(83, "Carga");
            __builder.CloseElement();
            __builder.AddMarkupContent(84, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(85, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(86, "\r\n\r\n    ");
            __builder.OpenElement(87, "div");
            __builder.AddAttribute(88, "class", "form-group col-lg-2");
            __builder.AddMarkupContent(89, "\r\n        ");
            __builder.AddMarkupContent(90, "<label>Capacidad</label>\r\n        ");
            __builder.OpenElement(91, "input");
            __builder.AddAttribute(92, "class", "form-control");
            __builder.AddAttribute(93, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#line 44 "C:\Users\Alejandro Chávez\Documents\BitBucket_Projects\PRAXYS\PRAXYS\Client\Pages\Insurances\VehicleForm.razor"
                            insurance.Capacity

#line default
#line hidden
            ));
            __builder.AddAttribute(94, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => insurance.Capacity = __value, insurance.Capacity));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(95, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(96, "\r\n\r\n    ");
            __builder.OpenElement(97, "div");
            __builder.AddAttribute(98, "class", "form-group col-12");
            __builder.AddMarkupContent(99, "\r\n        ");
            __builder.AddMarkupContent(100, "<label>Descripcion del Vehiculo</label>\r\n        ");
            __builder.OpenElement(101, "textarea");
            __builder.AddAttribute(102, "class", "form-control");
            __builder.AddAttribute(103, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#line 49 "C:\Users\Alejandro Chávez\Documents\BitBucket_Projects\PRAXYS\PRAXYS\Client\Pages\Insurances\VehicleForm.razor"
                                              insurance.Car_Description

#line default
#line hidden
            ));
            __builder.AddAttribute(104, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => insurance.Car_Description = __value, insurance.Car_Description));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(105, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(106, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591