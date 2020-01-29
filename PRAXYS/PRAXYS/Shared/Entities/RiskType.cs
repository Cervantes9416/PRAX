﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace PRAXYS.Shared.Entities
{
    public class RiskType
    {
        public int ID { get; set; }
        [Required]
        public string Description { get; set; }
    }
}
