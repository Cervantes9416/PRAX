using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PRAXYS.Client.Pages.Endorsement
{
    public class EndorsementChangeRFCBase : ModificationEndorsementBase
    {
        protected async override Task OnInitializedAsync()
        {
            await base.OnInitializedAsync();
            Endorsement.ValidFrom = Insurance.ValidFrom;
            Endorsement.ValidThrought = Insurance.ValidThrought;
            Endorsement.Description = "Cambio de RFC";
            Endorsement.Notes = "Favor de expedir endoso 'Modificacion' por cambio de RFC";
        }

        protected override Task CreateEndorsement()
        {
            return base.CreateEndorsement();
        }
    }
}
