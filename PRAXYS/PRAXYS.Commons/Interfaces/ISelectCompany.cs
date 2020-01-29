using PRAXYS.Commons.Entities.Company;
using System;
using System.Collections.Generic;
using System.Text;

namespace PRAXYS.Commons.Interfaces
{
    public interface ISelectCompany
    {
        int CompanyID { get; set; }
        CompanyModel Company { get; set; }
    }
}
