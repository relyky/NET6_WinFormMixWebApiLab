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
  //## State
  List<DeliveryBag> deliverySet = new();

  //## Property
  public int BagCount => deliverySet.Count;

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

#pragma warning disable CS8618 // 退出建構函式時，不可為 Null 的欄位必須包含非 Null 值。請考慮宣告為可為 Null。
  public object Content { get; set; }
#pragma warning restore CS8618 // 退出建構函式時，不可為 Null 的欄位必須包含非 Null 值。請考慮宣告為可為 Null。
}