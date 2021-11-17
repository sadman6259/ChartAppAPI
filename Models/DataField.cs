using System;
using System.Collections.Generic;

namespace BuildingAppSample.Models
{
    public partial class DataField
    {
        public DataField()
        {
            Reading = new HashSet<Reading>();
        }

        public byte Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Reading> Reading { get; set; }
    }
}
