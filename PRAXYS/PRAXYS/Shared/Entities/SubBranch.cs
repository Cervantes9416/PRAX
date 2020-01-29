using System;
using System.Collections.Generic;
using System.Text;

namespace PRAXYS.Shared.Entities
{
    public class SubBranch
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Alias { get; set; }
        public string MenuLetter { get; set; }
        public string InputForm { get; set; }

        public int RamoID { get; set; }
        public Branch Ramo { get; set; }
        public List<Insurance> Insurances { get; set; }
    }
}
