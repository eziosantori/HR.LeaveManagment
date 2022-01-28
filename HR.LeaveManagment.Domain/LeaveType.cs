using HR.LeaveManagment.Domain.Common;
using System;
using System.ComponentModel.DataAnnotations;

namespace HR.LeaveManagment.Domain
{
  public class LeaveType: BaseDomainEntity
  {

    public string Name { get; set; }
    public int DefaultDays { get; set; }
  }
}
