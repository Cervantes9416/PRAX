#pragma checksum "C:\Users\Alejandro Chávez\Documents\BitBucket_Projects\PRAXYS\PRAXYS\Client\Pages\Client\ClientModalForm.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "780968ae09fb8ec2373e5f20335b6e33bd59285c"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace PRAXYS.Client.Pages.Client
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
    public partial class ClientModalForm : ClientModalFormBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591