using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class Request
    {
        public Request(string url)
        {
            Url= url;
        }
        public string Url { get; set; }
        public object? Body { get; set; }
        public object? Form { get; set; }
        public Dictionary<string, string>? QueryString { get; set; }
        // Bad Design
        // public Request(string url)
        // {
        //     Url = url;
        // }
        // public Request(string url, object body)
        // {
        //     Url = url;
        //     Body = body;
        // }

        // public Request(string url, object? body, Dictionary<string, string> queryString)
        // {
        //     Url = url;
        //     Body = body;
        //     QueryString = queryString;
        // }

        public override string ToString()
        {
            return $"{Url}?{string.Join("&", QueryString.Select(q => $"{q.Key}:{q.Value}"))}";
        }
    }
}
