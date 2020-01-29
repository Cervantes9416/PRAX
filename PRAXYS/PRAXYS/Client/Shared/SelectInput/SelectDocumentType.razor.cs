using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PRAXYS.Client.Shared.SelectInput
{
    public class SelectDocumentTypeBase : ComponentBase
    {
        [Parameter] public string DocumentType { get; set; }

    }
}
