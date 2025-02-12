using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace MyStore.Domain.Inventory;
public class Supplier : AuditableEntity, IAggregateRoot
{
    public string SupplierName { get; set; }
    public string? Address { get; set; }
    public string Phone { get; set; }

    [JsonIgnore]
    public ICollection<Goods>? HistorySupply { get; set; }
}
