using Microsoft.AspNetCore.Components;
using PRAXYS.Commons.Entities.Endorsement;
using PRAXYS.Commons.Entities.Insurance;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PRAXYS.Client.Pages.Insurances
{
    public class DocumentDetailsBase : ComponentBase
    {
        [Parameter] public InsuranceModel Insurance { get; set; }
        protected EndorsementModel Endorsement { get; set; }

        protected override void OnInitialized()
        {
            Endorsement = Insurance.Endorsements.FirstOrDefault();
        }
    }
}
