using System;
using System.Collections.Generic;

#nullable disable

namespace Economy.Domain.Entities
{
    public partial class Serie
    {
        public int Id { get; set; }
        public int ProjectId { get; set; }
        public int Initial { get; set; }
        public int End { get; set; }
        public decimal? DownPayment { get; set; }
        public decimal? FinalPayment { get; set; }
        public decimal Quantity { get; set; }
        public decimal? Present { get; set; }
        public decimal? Future { get; set; }
        public string Type { get; set; }
        public string FlowType { get; set; }
        public decimal Rate { get; set; }
        public bool Incremental { get; set; }

        public virtual Project Project { get; set; }
    }
}
