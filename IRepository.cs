using SWapi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWapi;
public interface IRepository<T> where T : BaseEntity
{
    Task<T> GetById(int id);
    Task<ICollection<T>> GetEntities(int page = 1, int size = 10);
}
