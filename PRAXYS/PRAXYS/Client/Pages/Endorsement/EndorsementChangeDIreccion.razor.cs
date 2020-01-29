using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PRAXYS.Client.Pages.Endorsement
{
    public class EndorsementChangeDireccionBase : ModificationEndorsementBase
    {
        protected async override Task OnInitializedAsync()
        {
            await base.OnInitializedAsync();
            Endorsement.ValidFrom = Insurance.ValidFrom;
            Endorsement.ValidThrought = Insurance.ValidThrought;
            Endorsement.Description = "Cambio de direccion";
            Endorsement.Notes = "Favor de expedir endoso 'Modificacion' por cambio de direccion";
        }
    }
}
