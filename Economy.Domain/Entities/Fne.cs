using System;
using System.Collections.Generic;

#nullable disable

namespace Economy.Domain.Entities
{
    public partial class Fne
    {
        public int Id { get; set; }
        public int? ProjectId { get; set; }
        public short? Years { get; set; }
        public double? Tmar { get; set; }

        public virtual Project Project { get; set; }
    }
}
