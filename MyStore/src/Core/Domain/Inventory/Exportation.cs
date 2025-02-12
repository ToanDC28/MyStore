using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyStore.Domain.Inventory;
public class Exportation : AuditableEntity, IAggregateRoot
{
    public string? UserID { get; set; }
    public Guid OrderID { get; set; }
    public Guid GoodsID { get; set; }
    public int Unit { get; set; }
    public double PriceOfUnit { get; set; }
    public double Total { get; set; }
}
