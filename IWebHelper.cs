using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace SWapi;
public interface IWebHelper
{
    Task<HttpResponseMessage> GetRequest(string url);

}
