using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PRAXYS.Client.Pages.Endorsement
{
    public class EndorsementChangeBeneficiaryBase : ModificationEndorsementBase
    {
        protected async override Task OnInitializedAsync()
        {
            await base.OnInitializedAsync();
            Endorsement.ValidFrom = Insurance.ValidFrom;
            Endorsement.ValidThrought = Insurance.ValidThrought;
            Endorsement.Description = "Endoso de beneficiario";
            Endorsement.Notes = "En caso de siniestro parcial o total que amerite indemnizacion del bien amparado bajo " +
                "la poliza y/o inciso arriba citada(o). El beneficiario preferente irrevicable hasta por el interes que " +
                "le corresponda sera:";
        }

        protected async override Task CreateEndorsement()
        {
            await base.CreateEndorsement();
        }
    }
}
