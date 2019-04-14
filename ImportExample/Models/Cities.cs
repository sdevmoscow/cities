using System;
using System.Collections.Generic;

namespace ImportExample.Models
{
    public partial class Cities
    {
        public Cities()
        {
            Facts = new HashSet<Facts>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Facts> Facts { get; set; }
    }
}
