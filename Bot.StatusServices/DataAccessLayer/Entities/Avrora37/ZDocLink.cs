﻿using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class ZDocLink
    {
        public int LinkId { get; set; }
        public DateTime LinkDocDate { get; set; }
        public int ParentDocCode { get; set; }
        public long ParentChId { get; set; }
        public DateTime ParentDocDate { get; set; }
        public long? ParentDocId { get; set; }
        public int ChildDocCode { get; set; }
        public long ChildChId { get; set; }
        public DateTime ChildDocDate { get; set; }
        public string ChildDocId { get; set; }
        public decimal LinkSumCc { get; set; }
        public int DocLinkTypeId { get; set; }
        public DateTime LinkDocDate2 { get; set; }
        public int? Crc2 { get; set; }
    }
}
