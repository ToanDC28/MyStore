using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyStore.Domain.Payments;
public class Payout : AuditableEntity, IAggregateRoot
{
    public string UserID { get; set; }
    public Guid ImportID { get; set; }
    public double UnitOfPrice { get; set; }
    public int Amount { get; set; }
    public double TotalPrice { get; set; }
    public byte[]? PayoutImage { get; set; }
    public byte[]? ProductionImage { get; set; }
    public PaymentMethod Method { get; set; }
}
