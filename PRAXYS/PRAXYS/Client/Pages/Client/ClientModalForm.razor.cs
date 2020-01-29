using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using PRAXYS.Commons.Entities.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PRAXYS.Client.Pages.Client
{
    public class ClientModalFormBase : ComponentBase
    {
        [Inject] IJSRuntime js { get; set; }
        [Parameter] public ClientModel Client { get; set; }
        [Parameter] public EventCallback OnValidSubmit { get; set; }
        
    }
}
