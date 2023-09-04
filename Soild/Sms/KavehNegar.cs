using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soild.Sms
{
    public class KavehNegar : ISms
    {
        public string Send(string Message, string Receiver)
        {
            return "Sended";
        }
    }
}
