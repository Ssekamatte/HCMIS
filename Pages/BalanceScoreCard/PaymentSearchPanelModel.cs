﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReApp.Data
{
    public class PaymentSearchPanelModel
    {
        // [Required]
        public string Id { get; set; } = null!;
        public DateTime? startDate { get; set; }
        public DateTime? endDate { get; set; }
    }
}
