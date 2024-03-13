using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace ComputerService.Entities.Concrete;

public class Brand : BaseModel
{
    public string Name { get; set; }
    public string Model { get; set; }
    public string SerialNumber { get; set; }
    public string Description { get; set; }
    public ICollection<SparePart> SpareParts { get; set; }
    public ICollection<ServiceRecord> ServiceRecords { get; set; }

}
