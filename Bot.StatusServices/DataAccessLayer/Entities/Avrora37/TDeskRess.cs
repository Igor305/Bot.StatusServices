﻿using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class TDeskRess
    {
        public long ChId { get; set; }
        public int OurId { get; set; }
        public long DocId { get; set; }
        public string IntDocId { get; set; }
        public DateTime DocDate { get; set; }
        public int StockId { get; set; }
        public int CompId { get; set; }
        public int EmpId { get; set; }
        public string EmpName { get; set; }
        public int DeskCode { get; set; }
        public DateTime ResTime { get; set; }
        public string PersonName { get; set; }
        public int Visitors { get; set; }
        public decimal SumPrePay { get; set; }
        public decimal TsumCc { get; set; }
        public decimal? TsumMc { get; set; }
        public short CodeId1 { get; set; }
        public short CodeId2 { get; set; }
        public short CodeId3 { get; set; }
        public short CodeId4 { get; set; }
        public short CodeId5 { get; set; }
    }
}
