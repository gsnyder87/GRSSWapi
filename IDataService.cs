using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWapi;
public interface IDataService
{
    Task<string> GetDataResult(string url);
}
