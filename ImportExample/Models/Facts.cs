using System;
using System.Collections.Generic;

namespace ImportExample.Models
{
    public partial class Facts
    {
        public int Id { get; set; }
        public DateTime? Date { get; set; }
        public int CityId { get; set; }
        public double? Value { get; set; }

        public virtual Cities City { get; set; }
    }
}
