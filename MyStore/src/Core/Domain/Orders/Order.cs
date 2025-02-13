using MyStore.Domain.Inventory;
using MyStore.Domain.Payments;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace MyStore.Domain.Orders;
public class Order : AuditableEntity, IAggregateRoot
{
    public Guid CustomerID { get; set; }
    [DataType(DataType.Date)]
    [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
    public DateTime? OrderDate { get; set; }
    public string? Notes { get; set; }
    public byte[] Images { get; set; }

    public OrderStatus Status { get; set; }
    [JsonIgnore]
    public ICollection<Exportation>? Exportations { get; set; }
    [JsonIgnore]
    public Payment? Payment { get; set; }
}
