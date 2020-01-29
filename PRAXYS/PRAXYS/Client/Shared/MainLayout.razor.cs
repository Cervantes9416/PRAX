using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PRAXYS.Client.Helpers;

namespace PRAXYS.Client.Shared
{
    public class MainLayoutBase : ComponentBase
    {
        [Inject] IJSRuntime js { get; set; }


        
    }
}
