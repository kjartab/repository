using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks; 
using kjartab.repository.model;
using IResource = kjartab.repository.model.IResource;

namespace kjartab.repository
{
    
    public interface IRepository<T> where T: IResource
    {
        Task<IResourceResponse<T>> Get(string id);
        Task<IResourceResponse<T>> Delete(string id);
        Task<IResourceResponse<T>> Create(T resource);
        Task<IResourceResponse<T>> Update(T resource, string eTag);
        Task<IResourceResponse<T>> Upsert(T resource, string eTag);
        Task<IEnumerable<T>> List(int skip = 0, int take = 50);
        Task<IEnumerable<T>> Query(Expression<Func<T, bool>> predicate);
    }
}
