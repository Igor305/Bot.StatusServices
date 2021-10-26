using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class ItLogEmpBarcode
    {
        public long Chid { get; set; }
        public long Tablecode { get; set; }
        public long Userid { get; set; }
        public long Tablekey { get; set; }
        public DateTime DateTime { get; set; }
        public string OldValue { get; set; }
        public string NewValue { get; set; }
    }
}
