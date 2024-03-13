using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerService.Entities.Concrete;
public class Staff : BaseModel
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Position { get; set; }
    public string Phone { get; set; }
    public string Email { get; set; }
    public ICollection<ServiceRecord> ServiceRecords { get; set; }

}
