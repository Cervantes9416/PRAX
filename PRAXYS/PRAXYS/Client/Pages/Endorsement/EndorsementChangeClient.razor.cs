using Microsoft.AspNetCore.Components;
using PRAXYS.Client.Helpers;
using PRAXYS.Commons.Entities.Address;
using PRAXYS.Commons.Entities.Client;
using PRAXYS.Commons.Entities.Endorsement;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace PRAXYS.Client.Pages.Endorsement
{
    public class EndorsementChangeClientBase : ModificationEndorsementBase
    {
        protected List<AddressModel> Addresses {get;set;}

        protected async override Task OnInitializedAsync()
        {
            await base.OnInitializedAsync();
            Endorsement.ValidFrom = Insurance.ValidFrom;
            Endorsement.ValidThrought = Insurance.ValidThrought;
            Endorsement.Description = "Cambio de contratante";
            Endorsement.Notes = "Favor de expedir endoso 'Modificacion' por cambio de contratante";

        }

        protected async override Task CreateEndorsement()
        {
            await base.CreateEndorsement();
        }

        protected async void GetListAddress(int id)
        {
            var Client = await Http.GetJsonAsync<ClientModel>($"api/Clients/GetByDetails/{id}");
            Addresses = Client.ClientAddresses.Select(x => x.Address).ToList();

            StateHasChanged();
        }
    }

    
}
