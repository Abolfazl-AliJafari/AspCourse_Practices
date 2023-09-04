using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soild
{
    public interface IDbAction
    {
        OperationResult Insert();
        OperationResult Update();
        OperationResult Delete();
    }
}
