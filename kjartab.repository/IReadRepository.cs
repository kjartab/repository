using kjartab.repository.model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace kjartab.repository
{
    public interface IReadRepository<T> where T : IResource
    {
        Task<IResourceResponse<T>> Get(string id);
        Task<IEnumerable<T>> List(int skip = 0, int take = 50);
    }
}
