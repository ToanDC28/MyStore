using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace MyStore.Domain.Inventory;
public class Goods : AuditableEntity, IAggregateRoot
{
    public string UserID { get; set; }
    public byte[] Image { get; set; }
    public string GoodsName { get; set; }
    public Guid SupplierID { get; set; }
    public int Amount { get; set; }

    [JsonIgnore]
    public ICollection<Exportation>? Exportations { get; set; }
    [JsonIgnore]
    public ICollection<Importation>? Importations { get; set; }
}
