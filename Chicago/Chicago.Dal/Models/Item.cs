using Chicago.Dal.Enums;
using Daytona.Models;
using System.Collections.Generic;

namespace Chicago.Dal.Models
{
    public class Item : AuditableEntity
    {
        public WorthType Type { get; set; }
        public string Name { get; set; }
        public double Balance { get; set; }
        public virtual ICollection<NetworthItems> Items { get; set; }
    }
}
