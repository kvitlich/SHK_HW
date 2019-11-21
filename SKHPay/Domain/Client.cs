using System;
using System.Collections.Generic;
using System.Text;

namespace SKHPay.Domain
{
  public class Client : Entity
  {
    public string IIN { get; set; }
    public string StreetName { get; set; }
    public string HouseNumber { get; set; }
    public string FlatsNumber { get; set; }
    public string PhoneNumber { get; set; }
    public virtual ICollection<Payment> Payments { get; set; }
  }
}
