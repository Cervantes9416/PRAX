using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace PRAXYS.Client.Pages.Basics.Coverages
{
    public class EditCoverageBase : ComponentBase
    {
        [Inject] HttpClient Http { get; set; }


    }
}
