﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ComputerService.Entities.Abstract;

namespace ComputerService.Entities.Concrete;
public class Customer : BaseModel
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Phone { get; set; }
    public string Email { get; set; }
    public string Address { get; set; }
    public ICollection<ServiceRecord> ServiceRecords { get; set; }
}
