using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class RequestBuilderWithBody : RequestBuilder, IRequestBuilderWithBody
    {
        readonly Request _request;
        public RequestBuilderWithBody(Request request)
        {
            _request = request;
        }
        public new IRequestBuilderWithBody Request(string url)
        {
            IRequestBuilderWithBody requestBuilderWithBody = new RequestBuilderWithBody(_request);
            return requestBuilderWithBody;
        }
        public new IRequestBuilderWithBody WithHeader(string key, string value)
        {
            _request.QueryString[key] = value;
            return this;
        }
        public IRequestBuilderWithBody WithForm(object form)
        {
            _request.Form = form;
            return this;
        }
        public IRequestBuilderWithBody WithBody(object body)
        {
            _request.Body = body;
            return this;
        }
        public new Request Build()
        {
            return _request;
        }
    }

}
