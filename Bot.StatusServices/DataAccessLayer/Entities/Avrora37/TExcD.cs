﻿using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class TExcD
    {
        public long ChId { get; set; }
        public int SrcPosId { get; set; }
        public int ProdId { get; set; }
        public int Ppid { get; set; }
        public string Um { get; set; }
        public decimal Qty { get; set; }
        public decimal PriceCcNt { get; set; }
        public decimal SumCcNt { get; set; }
        public decimal Tax { get; set; }
        public decimal TaxSum { get; set; }
        public decimal PriceCcWt { get; set; }
        public decimal SumCcWt { get; set; }
        public string BarCode { get; set; }
        public int SecId { get; set; }
        public int NewSecId { get; set; }
        public decimal CorrectionQty { get; set; }
        public bool Editing { get; set; }
        public string ReasonMarriage { get; set; }
        public string Sscccode { get; set; }
        public int? PcatKmid { get; set; }
    }
}
