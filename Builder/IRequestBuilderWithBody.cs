using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{

    public interface IRequestBuilderWithBody
    {
        IRequestBuilderWithBody Request(string url);
        IRequestBuilderWithBody WithHeader(string key, string value);
        IRequestBuilderWithBody WithBody(object body);
        Request Build();
    }

}
