using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace SWapi;
public class DefaultDataService : IDataService
{
    private IWebHelper _webHelper;
    public DefaultDataService(IWebHelper webHelper)
    {
        _webHelper = webHelper;
    }

    public async Task<string> GetDataResult(string url)
    {


        try
        {
            var response = await _webHelper.GetRequest(url);
            string json = string.Empty;
            var test =   await response.Content.ReadAsStringAsync();
            return test;
        }
        catch ( HttpRequestException ex) { return null; };


    }
}
