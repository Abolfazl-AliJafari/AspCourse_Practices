using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{

    public class RequestBuilder
    {
        readonly Request _request = new Request("");

        public RequestBuilder()
        {

        }

        protected RequestBuilder(string url)
        {
            _request.Url = url;
        }

        public static RequestBuilder Request(string url)
        {
            return new RequestBuilder(url);
        }
        public RequestBuilder Reset()
            => new RequestBuilder(_request.Url);

        public RequestBuilder WithHeader(string key, string value)
        {
             if (_request.QueryString is null)
                _request.QueryString = new();
            _request.QueryString[key] = value;
            return this;
        }
        public IRequestBuilderWithBody AddBody()
        {
            IRequestBuilderWithBody requestBuilderWithBody = new RequestBuilderWithBody(_request);
            return requestBuilderWithBody;
        }

        public IRequestBuilderWithForm AddForm()
        {
            IRequestBuilderWithForm requestBuilderWithForm = new RequestBuilderWithForm(_request);
            return requestBuilderWithForm;
        }
        public  Request Build()
        {
            return _request;
        }
    }
}
