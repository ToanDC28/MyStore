using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyStore.Domain.Identity;
public class Salary : AuditableEntity, IAggregateRoot
{
    public string UserID { get; set; }
    [DataType(DataType.Date)]
    [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
    public DateTime StartDate { get; set; }
    public double SalaryOfMonth { get; set; }
}
