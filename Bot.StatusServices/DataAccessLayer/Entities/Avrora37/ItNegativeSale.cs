using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class ItNegativeSale
    {
        public long ChId { get; set; }
        public int DocCode { get; set; }
        public long DocChId { get; set; }
        public int OurId { get; set; }
        public int StockId { get; set; }
        public short CrId { get; set; }
        public int ProdId { get; set; }
        public decimal Qty { get; set; }
        public decimal? RemQty { get; set; }
        public int EmpId { get; set; }
        public DateTime CreateTime { get; set; }
    }
}
