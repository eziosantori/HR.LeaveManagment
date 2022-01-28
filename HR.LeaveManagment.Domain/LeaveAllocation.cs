﻿using HR.LeaveManagment.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR.LeaveManagment.Domain
{
  public class LeaveAllocation: BaseDomainEntity
  {
    public int NumberOfDays { get; set; }
    // [ForeignKey("EmployeeId")]
    // public Employee Employee { get; set; }
    // public string EmployeeId { get; set; }
    // [ForeignKey("LeaveTypeId")]
    public LeaveType LeaveType { get; set; }
    public int LeaveTypeId { get; set; }
    public int Period { get; set; }
  }
}
