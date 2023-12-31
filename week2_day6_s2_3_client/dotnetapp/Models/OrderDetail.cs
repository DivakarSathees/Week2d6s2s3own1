using System;
using System.Collections.Generic;

namespace dotnetapp.Models{
public class OrderDetail
{
    public int OrderDetailID { get; set; }
    public int OrderID { get; set; }
    public int ProductID { get; set; }
    public decimal UnitPrice { get; set; }
    public short Quantity { get; set; }
    public float Discount { get; set; }

    public virtual Order Order { get; set; }
    public virtual Product Product { get; set; }
}
}
