using System;
using System.Collections.Generic;
using System.Text;

namespace SKHPay.Domain
{

  /*
В приложении нужно учитывать ИИН человека, улицу, дом и квартиру, номер телефона и идентификатор услуги (вода/свет и так далее).
Всю информацию сохраняйте в БД
     */
  public class Payment : Entity
  {
    public int Month { get; set; }
    public string ForWater { get; set; }
    public string ForLight { get; set; }
    public Client Client { get; set; }
    public string MustInTotal { get; set; }
  }
}
