#pragma checksum "C:\Users\cscxx\Desktop\PRAX\PRAX\PRAXYS\PRAXYS\Client\Shared\SelectInput\SelectEndorsement.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b79f555403856947cff309e2b150de31d2899bee"
// <auto-generated/>
#pragma warning disable 1591
namespace PRAXYS.Client.Shared.SelectInput
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
    public partial class SelectEndorsement : SelectEndorsementBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#line 4 "C:\Users\cscxx\Desktop\PRAX\PRAX\PRAXYS\PRAXYS\Client\Shared\SelectInput\SelectEndorsement.razor"
 if (Endorsements == null)
{

#line default
#line hidden
            __builder.AddContent(0, "    ");
            __builder.AddMarkupContent(1, "<div class=\"d-flex justify-content-center\">\r\n        <div class=\"spinner-border text-info m-2\" role=\"status\"></div>\r\n    </div>\r\n");
#line 9 "C:\Users\cscxx\Desktop\PRAX\PRAX\PRAXYS\PRAXYS\Client\Shared\SelectInput\SelectEndorsement.razor"
}
else
{

#line default
#line hidden
            __builder.AddContent(2, "    ");
            __builder.OpenElement(3, "select");
            __builder.AddAttribute(4, "class", "form-control");
            __builder.AddAttribute(5, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#line 12 "C:\Users\cscxx\Desktop\PRAX\PRAX\PRAXYS\PRAXYS\Client\Shared\SelectInput\SelectEndorsement.razor"
                   SelectEndorsementType.EndorsementTypeID

#line default
#line hidden
            ));
            __builder.AddAttribute(6, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => SelectEndorsementType.EndorsementTypeID = __value, SelectEndorsementType.EndorsementTypeID));
            __builder.SetUpdatesAttributeName("value");
            __builder.AddMarkupContent(7, "\r\n        ");
            __builder.OpenElement(8, "option");
            __builder.AddAttribute(9, "selected", true);
            __builder.AddAttribute(10, "value", "0");
            __builder.AddContent(11, "Seleccionar..");
            __builder.CloseElement();
            __builder.AddMarkupContent(12, "\r\n");
#line 14 "C:\Users\cscxx\Desktop\PRAX\PRAX\PRAXYS\PRAXYS\Client\Shared\SelectInput\SelectEndorsement.razor"
         foreach (var item in Endorsements)
        {

#line default
#line hidden
            __builder.AddContent(13, "            ");
            __builder.OpenElement(14, "option");
            __builder.AddAttribute(15, "value", 
#line 16 "C:\Users\cscxx\Desktop\PRAX\PRAX\PRAXYS\PRAXYS\Client\Shared\SelectInput\SelectEndorsement.razor"
                            item.ID

#line default
#line hidden
            );
            __builder.AddContent(16, 
#line 16 "C:\Users\cscxx\Desktop\PRAX\PRAX\PRAXYS\PRAXYS\Client\Shared\SelectInput\SelectEndorsement.razor"
                                      item.Descripcion

#line default
#line hidden
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(17, "\r\n");
#line 17 "C:\Users\cscxx\Desktop\PRAX\PRAX\PRAXYS\PRAXYS\Client\Shared\SelectInput\SelectEndorsement.razor"
        }

#line default
#line hidden
            __builder.AddContent(18, "    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\r\n");
#line 19 "C:\Users\cscxx\Desktop\PRAX\PRAX\PRAXYS\PRAXYS\Client\Shared\SelectInput\SelectEndorsement.razor"
}

#line default
#line hidden
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
