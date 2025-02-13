using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyStore.Domain.Payments;
public class Payment : AuditableEntity, IAggregateRoot
{
    public Guid CustomerID { get; set; }
    public string UserID { get; set; }
    public Guid OrderID { get; set; }
    public double Total { get; set; }
    public byte[]? PaymentImage { get; set; }
    public byte[]? ProductionImage { get; set; }
    public PaymentMethod Method { get; set; }
}
