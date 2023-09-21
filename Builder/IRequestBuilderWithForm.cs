using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public interface IRequestBuilderWithForm
    {
        IRequestBuilderWithForm Request(string url);
        IRequestBuilderWithForm WithHeader(string key, string value);
        IRequestBuilderWithForm WithForm(object form);
        Request Build();
    }

}
