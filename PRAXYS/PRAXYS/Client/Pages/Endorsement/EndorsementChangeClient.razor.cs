using Microsoft.AspNetCore.Components;
using PRAXYS.Client.Helpers;
using PRAXYS.Commons.Entities.Endorsement;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace PRAXYS.Client.Pages.Endorsement
{
    public class EndorsementChangeClientBase : ModificationEndorsementBase
    {
        protected async override Task OnInitializedAsync()
        {
            await base.OnInitializedAsync();
            Endorsement.PaymentTypeID = 17;
            Endorsement.EndorsementTypeID = 3;
            Endorsement.ValidFrom = Insurance.ValidFrom;
            Endorsement.ValidThrought = Insurance.ValidThrought;
            Endorsement.Description = "Cambio de contratante";
            Endorsement.Notes = "Favor de expedir endoso 'Modificacion' por cambio de contratante";
        }

        protected async override Task CreateEndorsement()
        {
            await base.CreateEndorsement();
        }
    }

    
}
