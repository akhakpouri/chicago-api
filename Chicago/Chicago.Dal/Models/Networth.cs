using Daytona.Models;
using System;
using System.Collections.Generic;

namespace Chicago.Dal.Models
{
    public class Networth : AuditableEntity
    {
        public DateTime CapturedDate { get; set; }
        public virtual ICollection<NetworthItems> Items { get; set; }
    }
}
