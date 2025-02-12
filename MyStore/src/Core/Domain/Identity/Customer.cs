using MyStore.Domain.Orders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace MyStore.Domain.Identity;
public class Customer : AuditableEntity, IAggregateRoot
{
    public string Name { get; set; }
    public string Phone { get; set; }
    public string? Address { get; set; }
    public string? IdentifyCode { get; set; }
    public byte[]? IdentifyImage { get; set; }

    [JsonIgnore]
    public ICollection<Order>? Orders { get; set; }
}
