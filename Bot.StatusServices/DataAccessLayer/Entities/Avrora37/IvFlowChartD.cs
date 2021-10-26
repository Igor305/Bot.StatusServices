﻿using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class IvFlowChartD
    {
        public long ChId { get; set; }
        public int SrcPosId { get; set; }
        public int ProdId { get; set; }
        public string Um { get; set; }
        public decimal GrossQty { get; set; }
        public decimal WastePrc { get; set; }
        public decimal NetQty { get; set; }
        public string BaseUm { get; set; }
        public decimal? Qty { get; set; }
        public decimal? PriceCc { get; set; }
        public decimal? SumCc { get; set; }
    }
}
