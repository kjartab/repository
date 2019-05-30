//using System;
//using System.Collections.Generic;
//using System.Linq.Expressions;
//using System.Threading.Tasks;
//using kjartab.repository.model;

//namespace kjartab.repository.cosmosdb
//{
//    public class Repository<TResource> : IRepository<TResource> where TResource: IResource
//    {
//        public Task<IResponse<TResource>> Get(string id)
//        {
//            throw new NotImplementedException();
//        }

//        public Task<IResponse<TResource>> Delete(string id)
//        {
//            throw new NotImplementedException();
//        }

//        public Task<IResponse<TResource>> Create(TResource resource)
//        {
//            throw new NotImplementedException();
//        }

//        public Task<IResponse<TResource>> Update(TResource resource)
//        {
//            throw new NotImplementedException();
//        }

//        public Task<IResponse<TResource>> Upsert(TResource resource)
//        {
//            throw new NotImplementedException();
//        }

//        public Task<IEnumerable<TResource>> List(int skip = 0, int take = 50)
//        {
//            throw new NotImplementedException();
//        }

//        public Task<IEnumerable<TResource>> Query(Expression<Func<TResource, bool>> predicate)
//        {
//            throw new NotImplementedException();
//        }
//    }
//}
