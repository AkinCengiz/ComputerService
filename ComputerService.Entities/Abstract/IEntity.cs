using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerService.Entities.Abstract;
public interface IEntity
{
    int Id { get; set; }
    DateTime CreatedDate { get; set; }
    bool IsDeleted { get; set; }
}
