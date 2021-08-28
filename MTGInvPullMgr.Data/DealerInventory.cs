﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MTGInvPullMgr.Data
{
    public class DealerInventory
    {
        [Key]
        public int SKU { get; set; }
        [Required]
        public string Name{ get; set; }
        public string ApiObjectURI { get; set; }
        public int CurrentInventory { get; set; }
        public string SetName { get; set; }
        public string Set { get; set; }
        public int CollectorNumber { get; set; }
        public bool IsFoil { get; set; }
        public bool IsVariant { get; set; }
    }
}
