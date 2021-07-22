using Chicago.Dal.Enums;
using Daytona.Models;

namespace Chicago.Dal.Models
{
    public class Item : AuditableEntity
    {
        public WorthType Type { get; set; }
        public string Name { get; set; }
        public double Balance { get; set; }
    }
}
