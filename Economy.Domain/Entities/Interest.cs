﻿using System;
using System.Collections.Generic;

#nullable disable

namespace Economy.Domain.Entities
{
    public partial class Interest
    {
        public int Id { get; set; }
        public int ProjectId { get; set; }
        public int Initial { get; set; }
        public int End { get; set; }
        public decimal? Present { get; set; }
        public decimal? Future { get; set; }
        public string FlowType { get; set; }
        public decimal Rate { get; set; }
        public decimal Payment { get; set; }
        public int TotalPeriod { get; set; }

        public virtual Project Project { get; set; }
    }
}
