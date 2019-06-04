using kjartab.repository.model;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace kjartab.repository
{
    public interface IQueryableRepository<T> : IRepository<T> where T : IResource
    { 
        Task<IEnumerable<T>> Query(Expression<Func<T, bool>> predicate);
    }
}
