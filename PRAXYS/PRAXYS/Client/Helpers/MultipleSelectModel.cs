using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PRAXYS.Client.Helpers
{
    public struct MultipleSelectModel
    {
        public string Key { get; set; }
        public string Value { get; set; }

        public MultipleSelectModel(string Key, string Value)
        {
            this.Key = Key;
            this.Value = Value;
        }
    }
}
