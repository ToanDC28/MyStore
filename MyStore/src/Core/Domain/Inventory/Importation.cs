using MyStore.Domain.Payments;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace MyStore.Domain.Inventory;
public class Importation : AuditableEntity, IAggregateRoot
{
    public Guid GoodsID { get; set; }
    public Guid SupplierID { get; set; }
    [DataType(DataType.Date)]
    [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
    public DateTime ReceiveDate { get; set; }
    [StringLength(256, ErrorMessage = "Note cannot be longer than 256 characters.")]
    public int Amount { get; set; }
    public double CostOfUnit { get; set; }
    public double Total { get; set; }
    public string? Notes { get; set; }
    public InventoryStatus Status { get; set; }

    [JsonIgnore]
    public Payout? Payout { get; set; }
}
