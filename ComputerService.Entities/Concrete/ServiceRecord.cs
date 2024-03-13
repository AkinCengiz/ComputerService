using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerService.Entities.Concrete;
public class ServiceRecord : BaseModel
{
    public int CustomerId { get; set; }
    public string DeviceType { get; set; }
    public string Brand { get; set; }
    public string Model { get; set; }
    public string SerialNumber { get; set; }
    public string Description { get; set; }
    public DateTime EstimatedCompletionDate { get; set; }
    public int StatusId { get; set; }
    [ForeignKey("CustomerId")]
    public Customer Customer { get; set; }
    [ForeignKey("StatusId")]
    public ServiceStatu ServiceStatu { get; set; }
}
