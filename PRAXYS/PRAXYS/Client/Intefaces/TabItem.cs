using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PRAXYS.Client.Intefaces
{
    public class TabItem
    {
        public string Label { get; set; }
        public RenderFragment Content { get; set; }
    }
}
