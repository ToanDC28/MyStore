using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace MyStore.Domain.Identity;
public class HistoryOfSalary : AuditableEntity, IAggregateRoot
{
    public string UserID { get; set; }
    public Guid SalaryID { get; set; }
    public double SubAmount { get; set; }
    public double Total { get; set; }
    [DataType(DataType.Date)]
    [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
    public DateTime PayDay { get; set; }
    [StringLength(256, ErrorMessage = "Note cannot be longer than 256 characters.")]
    public string? Note { get; set; }
    public SalaryStatus Status { get; set; }
    [JsonIgnore]
    public Salary Salary { get; set; }
}
