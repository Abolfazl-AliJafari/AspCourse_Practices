using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soild.Order.OrderDbAction
{
    public class OrderDbAction_Ef : IOrderDbAction
    {
        public OperationResult Delete()
        {
            return new OperationResult();
        }

        public OperationResult Insert()
        {
            return new OperationResult();
        }

        public OperationResult Update()
        {
            return new OperationResult();
        }

        public OperationResult OrderChangeStatus(string OrderCode, string NewStatus)
        {
            return new OperationResult();
        }
    }
}
