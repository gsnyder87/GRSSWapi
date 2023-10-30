using SWapi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace SWapi;
public class Repository<T> : IRepository<T> where T : BaseEntity
{
    private const string Api = "https://swapi.dev/api/";
    private const int DefaultPage = 1;
    private const int DefaultSize = 10;
    private string urlEndCharacter = "/";
    private string urlData;
    private IDataService _dataService;
    private T _entity;

    public Repository() :this(new DefaultDataService(new WebHelper()), Api)
    { }

    public Repository(IDataService dataService) : this(dataService, Api)
    {
        
    }

    public Repository(IDataService dataService, String url)
    {
        _entity = HelperInitializer<T>.Instance();
        _dataService = dataService;
        if (!url.EndsWith(urlEndCharacter)) 
        {
            url += urlEndCharacter;
        }

        urlData = url ;
    }

    public string Path { get { return urlData; } }

    public async Task<T> GetById(int id)
    {
        string url = $"{urlData}{_entity.GetPath()}{id}";
        string jsonResponse  = await _dataService.GetDataResult(url) ;
        if (jsonResponse == null)
        {
            return null;
        }

        return JsonSerializer.Deserialize<T>(jsonResponse) ;
    }

    public async Task<ICollection<T>> GetEntities(int page = DefaultPage, int size = DefaultSize)
    {
        string url = urlData + _entity.GetPath() + "?page=" +  page;
        IEnumerable<T> results = new List<T>();

        var helper = new Helper<T>()
        {
            Next = url,
            Previous = null,
        };

        string jsonResponse = string.Empty;

        while (helper.Next != null)
        {
            jsonResponse = await _dataService.GetDataResult(helper.Next);
            if (jsonResponse == null)
            {
                return null;
            }

            helper = JsonSerializer.Deserialize<Helper<T>>(jsonResponse);
            if (helper == null)
            {
                return null;
            }

            results = results.Union(helper.Results) ;

            if (results.Count() >= size)
            {
                return results.Take(size).ToList();
            }
        }

        return results.ToList();
    }

}
