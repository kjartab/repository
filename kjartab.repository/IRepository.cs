using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks; 
using kjartab.repository.model;
using IResource = kjartab.repository.model.IResource;

namespace kjartab.repository
{
    
    public interface IRepository<T> : IReadRepository<T>, IWriteRepository<T> where T: IResource
    {
    }
}
