using Microsoft.AspNetCore.Components;
using PRAXYS.Commons.Entities.Address;
using PRAXYS.Commons.Entities.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PRAXYS.Client.Pages.Endorsement
{
    public class EndorsementChangeDireccionBase : ModificationEndorsementBase
    {
        protected List<AddressModel> Addresses { get; set; }
        protected ClientModel Client { get; set; }

        protected async override Task OnInitializedAsync()
        {
            await base.OnInitializedAsync(); 
            Endorsement.PaymentTypeID = 17;
            Endorsement.EndorsementTypeID = 3;
            Endorsement.ValidFrom = Insurance.ValidFrom;
            Endorsement.ValidThrought = Insurance.ValidThrought;
            Endorsement.Description = "Cambio de direccion";
            Endorsement.Notes = "Favor de expedir endoso 'Modificacion' por cambio de direccion";

           
        }

        protected async void GetAddress()
        {
            var Client = await Http.GetJsonAsync<ClientModel>($"api/Clients/GetByDetails/{InsuranceID}");
            Addresses = Client.ClientAddresses.Select(x => x.Address).ToList();

            StateHasChanged();
        }

    }
}
