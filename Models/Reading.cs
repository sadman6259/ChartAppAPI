using System;
using System.Collections.Generic;

namespace BuildingAppSample.Models
{
    public partial class Reading
    {
        public short BuildingId { get; set; }
        public byte ObjectId { get; set; }
        public byte DataFieldId { get; set; }
        public decimal Value { get; set; }
        public DateTime TimeStamp { get; set; }

        public virtual Building Building { get; set; }
        public virtual DataField DataField { get; set; }
        public virtual Object Object { get; set; }
    }
}
