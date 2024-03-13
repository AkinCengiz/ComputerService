using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerService.Entities.Concrete;
public class SparePart : BaseModel
{
    public string Name { get; set; }

    public int BrandId { get; set; }
    public Brand Brand { get; set; }
    //public string Brand { get; set; }
    //public string Model { get; set; }
    public short StockAmount { get; set; }
    public decimal UnitPrice { get; set; }
}
