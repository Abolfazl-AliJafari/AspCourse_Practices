using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soild.Order
{

    public class Order
    {
        public Order(string OrderCode,int OrderOwnerId,string OrderDateRegistered,string OrderStatus)
        {
            this.OrderCode = OrderCode;
            this.OrderOwnerId = OrderOwnerId;
            this.OrderDateRegistered = OrderDateRegistered;
            this.OrderStatus = OrderStatus;
        }
        public string OrderCode { get; set; }
        public int OrderOwnerId{ get; set; }
        public string OrderDateRegistered { get; set;}
        public string OrderStatus { get; set;}
    }
}
