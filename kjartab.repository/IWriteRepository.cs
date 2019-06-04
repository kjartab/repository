using kjartab.repository.model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace kjartab.repository
{
    public interface IWriteRepository<T> where T : IResource
    {
        Task<IResourceResponse<T>> Delete(string id);
        Task<IResourceResponse<T>> Create(T resource);
        Task<IResourceResponse<T>> Update(T resource, string eTag);
        Task<IResourceResponse<T>> Upsert(T resource, string eTag);
    }
}
