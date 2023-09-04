using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soild.Sms
{
    public class SendSms
    {
        private ISms _sms;
        public SendSms(ISms sms)
        {
            _sms = sms;
        }
        public string Send(string Message, string Receiver)
        {
            return _sms.Send(Message, Receiver);
        }
    }
}
