using Daytona.Models;

namespace Chicago.Dal.Models
{
    public class NetworthItems : AuditableEntity
    {
        public int ItemId { get; set; }
        public int NetworthId { get; set; }
        public virtual Item Item { get; set; }
        public virtual Networth Networth { get; set; }
    }
}
