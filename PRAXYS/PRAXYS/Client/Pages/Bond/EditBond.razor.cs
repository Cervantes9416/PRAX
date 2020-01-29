using Microsoft.AspNetCore.Components;
using PRAXYS.Commons.Entities.Bond;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PRAXYS.Client.Pages.Bond
{
    public class EditBondBase : ComponentBase
    {
        [Parameter] public int BondID { get; set; }
        protected BondModel Bond { get; set; }
        
    }
}
