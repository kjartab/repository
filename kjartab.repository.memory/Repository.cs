//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Linq.Expressions;
//using System.Net;
//using System.Threading.Tasks;
//using kjartab.repository.model;

//namespace kjartab.repository.memory
//{
//    public class MemoryRepository<T> : IRepository<T> where T: IResource
//    {

//        private readonly Dictionary<string, T> _resourceDict = new Dictionary<string, T>();

//        public async Task<IResponse<T>> Get(string id)
//        {
//            if (_resourceDict.ContainsKey(id))
//            {
//                return new Response<T>(HttpStatusCode.OK, _resourceDict[id]);
//            }
//            return new Response<T>(HttpStatusCode.NotFound);
//        }

//        public async Task<IResponse<T>> Delete(string id)
//        {
//            if (_resourceDict.ContainsKey(id))
//            {
//                _resourceDict.Remove(id);
//                return new Response<T>(HttpStatusCode.NoContent);
//            }
//            return new Response<T>(HttpStatusCode.NotFound);
//        }

//        public async Task<IResponse<T>> Create(T resource)
//        {
//            if (resource.Id != null)
//            { 
//                if (_resourceDict.ContainsKey(resource.Id))
//                {
//                    return new Response<T>(HttpStatusCode.Conflict, $"Resource with id ${resource.Id} already exists");
//                } 
//            }
//            else
//            {
//                resource.Id = Guid.NewGuid().ToString();
//            }
//            _resourceDict[resource.Id] = resource;

//            return new Response<T>(HttpStatusCode.Created, resource); 
//        }

//        public async Task<IResponse<T>> Update(T resource)
//        {
//            if (resource.Id == null)
//            {
//                return new Response<T>(HttpStatusCode.BadRequest, "Id missing for resource");
//            }

//            if (!_resourceDict.ContainsKey(resource.Id))
//            {
//                return new Response<T>(HttpStatusCode.NotFound, resource);
//            }

//            _resourceDict[resource.Id] = resource;
//            return new Response<T>(HttpStatusCode.OK, resource);
//        }

//        public async Task<IResponse<T>> Upsert(T resource)
//        {
//            if (resource.Id == null)
//            {
//                return new Response<T>(HttpStatusCode.BadRequest, "Id missing for resource");
//            }

//            if (!_resourceDict.ContainsKey(resource.Id))
//            {
//                _resourceDict[resource.Id] = resource;
//                return new Response<T>(HttpStatusCode.Created, resource);
//            }

//            _resourceDict[resource.Id] = resource;
//            return new Response<T>(HttpStatusCode.OK, resource);
//        }

//        public async Task<IEnumerable<T>> List(int skip = 0, int take = 50)
//        {
//            throw new NotImplementedException();
//        }

//        public async Task<IEnumerable<T>> Query(Expression<Func<T, bool>> predicate)
//        {
//            return _resourceDict.Values.ToList().AsQueryable().Where(predicate);  
//        }
//    }
//}
