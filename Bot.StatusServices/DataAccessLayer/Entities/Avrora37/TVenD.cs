﻿using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class TVenD
    {
        public long ChId { get; set; }
        public int SrcPosId { get; set; }
        public int Ppid { get; set; }
        public decimal Qty { get; set; }
        public decimal PriceCcNt { get; set; }
        public decimal PriceCcWt { get; set; }
        public decimal Tax { get; set; }
        public decimal TaxSum { get; set; }
        public decimal SumCcNt { get; set; }
        public decimal SumCcWt { get; set; }
        public decimal NewQty { get; set; }
        public decimal NewSumCcNt { get; set; }
        public decimal NewTaxSum { get; set; }
        public decimal NewSumCcWt { get; set; }
        public int SecId { get; set; }
        public int DetProdId { get; set; }
        public string DetUm { get; set; }
    }
}
