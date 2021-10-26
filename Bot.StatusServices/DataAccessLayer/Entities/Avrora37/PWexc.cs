﻿using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class PWexc
    {
        public long ChId { get; set; }
        public long DocId { get; set; }
        public DateTime DocDate { get; set; }
        public decimal KursMc { get; set; }
        public int OurId { get; set; }
        public short CodeId1 { get; set; }
        public short CodeId2 { get; set; }
        public short CodeId3 { get; set; }
        public short CodeId4 { get; set; }
        public short CodeId5 { get; set; }
        public DateTime ExcBdate { get; set; }
        public DateTime ExcEdate { get; set; }
        public int EmpId { get; set; }
        public short SubId { get; set; }
        public int PostId { get; set; }
        public byte EmpClass { get; set; }
        public int WorderId { get; set; }
        public short DepId { get; set; }
        public string IntDocId { get; set; }
        public int StateCode { get; set; }
    }
}
