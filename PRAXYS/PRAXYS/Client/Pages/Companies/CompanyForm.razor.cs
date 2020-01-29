using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using PRAXYS.Client.Helpers;
using PRAXYS.Client.Intefaces;
using PRAXYS.Commons.Entities.Address;
using PRAXYS.Commons.Entities.Company;
using PRAXYS.Shared.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace PRAXYS.Client.Pages.Companies
{
    public class CompanyFormBase : ComponentBase, IAddressList
    {
        [Inject] IJSRuntime js { get; set; } 
        [Parameter] public CompanyModel Company { get; set; }
        [Parameter] public EventCallback OnValidSubmit { get; set; }
        [Parameter] public List<PaymentType> PaymentTypeSelect { get; set; } = new List<PaymentType>();
        [Parameter] public List<PaymentType> PaymentTypeNotSelect { get; set; } = new List<PaymentType>();
        [Parameter] public bool ReadOnly { get; set; }

        protected List<MultipleSelectModel> NotSelectItems { get; set; } = new List<MultipleSelectModel>();
        protected List<MultipleSelectModel> SelectItems { get; set; } = new List<MultipleSelectModel>();
        public List<AddressModel> AddressList { get; set; }

        protected override void OnInitialized()
        {
            Company.IssueDate = DateTime.Now;
            SelectItems = PaymentTypeSelect.Select(x => new MultipleSelectModel(x.ID.ToString(), x.Description)).ToList();
            NotSelectItems = PaymentTypeNotSelect.Select(x => new MultipleSelectModel(x.ID.ToString(), x.Description)).ToList();

            AddressList = Company.CompanyAddress.Select(x => x.Address).ToList();
        }

        public void OnValidSubmitCreate()
        {
            Company.CompanyAddress = AddressList
                .Select(x => new CompanyAddressModel { Address = x })
                .ToList();

            OnValidSubmit.InvokeAsync(null);
        }

        protected async override Task OnAfterRenderAsync(bool firstRender)
        {
            if (ReadOnly)
            {
                await js.AddAttribute("readonly");
            }
        }
    }
}
