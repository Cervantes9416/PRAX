using BlazorStrap;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using PRAXYS.Client.Intefaces;
using PRAXYS.Commons.Entities.Address;
using PRAXYS.Shared.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PRAXYS.Client.Shared.Forms
{
    public class AddAddressBase : ComponentBase
    {
        [Parameter] public List<AddressModel> items { get; set; }
        [Parameter] public EventCallback OnValidSubmit { get; set; }
        protected AddressModel Address = new AddressModel();
        public BSModal Centered;

        public void onToggle(MouseEventArgs e)
        {
            Centered.Toggle();
        }

        public void OnValidCreate()
        {
            items.Add(Address);
            Address = new AddressModel();
            StateHasChanged();

            Centered.Toggle();
        }

    }
}
