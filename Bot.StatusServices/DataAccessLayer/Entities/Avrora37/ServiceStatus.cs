using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class ServiceStatus
    {
        public DateTime Date { get; set; }
        public string Service { get; set; }
        public int Status { get; set; }
    }
}
