using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace SWapi;
public class WebHelper : IWebHelper
{
    public async virtual Task<HttpResponseMessage> GetRequest(string url)
    {
        var client = new HttpClient();
        
        var message =  await client.GetAsync(url);
        return message;
    }
}
