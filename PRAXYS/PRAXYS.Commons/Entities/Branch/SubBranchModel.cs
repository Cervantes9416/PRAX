using PRAXYS.Commons.Entities.Insurance;
using System;
using System.Collections.Generic;
using System.Text;

namespace PRAXYS.Commons.Entities.Branch
{
    public class SubBranchModel
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Alias { get; set; }
        public string MenuLetter { get; set; }
        public string InputForm { get; set; }

        public int RamoID { get; set; }
        public BranchModel Ramo { get; set; }
        public List<InsuranceModel> Insurances { get; set; }
    }
}
