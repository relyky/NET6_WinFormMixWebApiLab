using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormLab.Models;

/// <summary>
/// 快遞中心
/// </summary>
public class DeliveryQueue
{
  List<DeliveryBag> deliverySet = new();

  public void Enqueue(DeliveryBag bag)
  {
    deliverySet.Add(bag);
  }

  public DeliveryBag? Dequeue(string receiver) 
  { 
    var qryBag = from c in deliverySet
                 where c.Receiver == receiver
                 orderby c.TimeStamp ascending
                 select c;

    var targetBag = qryBag.FirstOrDefault();
    
    if (targetBag != null)
      deliverySet.Remove(targetBag);

    return targetBag;
  }

  public DeliveryBag? Dequeue(string receiver, string subject)
  {
    var qryBag = from c in deliverySet
                 where c.Receiver == receiver && c.Subject == subject
                 orderby c.TimeStamp ascending
                 select c;

    var targetBag = qryBag.FirstOrDefault();

    if (targetBag != null)
      deliverySet.Remove(targetBag);

    return targetBag;
  }

}

public class DeliveryBag
{
  public string Sender { get; set; } = string.Empty;
  public string Receiver { get; set; } = string.Empty;
  public string Subject { get; set; } = string.Empty;
  public DateTime TimeStamp { get; private set; } = DateTime.Now;
  public object Content { get; set; }
}