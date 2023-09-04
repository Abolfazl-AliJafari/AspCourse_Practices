using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soild.Sms
{
    public interface ISms
    {
        string Send(string Message,string Receiver);
    }
}
