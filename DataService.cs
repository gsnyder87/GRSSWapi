using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWapi;
public class DataService : IDataService
{
    private readonly IWebHelper _WebHelper;

    public DataService(IWebHelper webHelper)
    {
        _WebHelper = webHelper;
    }

    public async Task<string> GetDataResult(string url)
    {
        try
        {
            var response = await _WebHelper.GetRequest(url);
            var json = await response.Content.ReadAsStringAsync();
            return json;
        }
        catch (Exception)
        {
            throw;
        }
    }
}
