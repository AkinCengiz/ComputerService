using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerService.Entities.Concrete;
public class Invoice : BaseModel
{
    public int ServiceId { get; set; }
    public DateTime PaymentDate { get; set; }
    public decimal Total { get; set; }
    public ServiceRecord ServiceRecord { get; set; }
}
