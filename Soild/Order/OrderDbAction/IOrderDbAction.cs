using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soild.Order.OrderDbAction
{
    public interface IOrderDbAction : IDbAction
    {
        public OperationResult OrderChangeStatus(string OrderCode, string NewStatus);
    }
}
