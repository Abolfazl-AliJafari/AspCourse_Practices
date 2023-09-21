using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class RequestBuilderWithForm :  IRequestBuilderWithForm
    {
        readonly Request _request;
        public RequestBuilderWithForm(Request request1)
        {
            _request = request1;
        }

        public new IRequestBuilderWithForm Request(string url)
        {
            IRequestBuilderWithForm requestBuilderWithForm = new RequestBuilderWithForm(_request);
            return requestBuilderWithForm;
        }
        public new IRequestBuilderWithForm WithHeader(string key, string value)
        {
            _request.QueryString[key] = value;
            return this;
        }
        public new IRequestBuilderWithForm WithForm(object form)
        {
            _request.Form = form;
            return this;
        }
        public new Request Build()
        {
            return _request;
        }
    }

}
