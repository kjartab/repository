using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace kjartab.repository.model
{

    public class Response : IResponse
    {
        public string Message { get; set; }
        public HttpStatusCode StatusCode { get; set; }
        public string ETag { get; set; }
         
    }

    public class DataResponse<T> : Response, IDataResponse<T>
    {
        public T Data { get; set; }
    }
    public class ResourceResponse<T> : Response, IResourceResponse<T> where T: IResource
    {
        public ResourceResponse(HttpStatusCode statusCode, T resource)
        {
            Resource = resource;
            StatusCode = statusCode;
        }

        public ResourceResponse(HttpStatusCode statusCode, T resource, string message)
        {
            Resource = resource;
            StatusCode = statusCode;
            Message = message;
        }

        public ResourceResponse(HttpStatusCode statusCode, string message)
        {
            StatusCode = statusCode;
            Message = message;
        }

        public ResourceResponse(HttpStatusCode statusCode)
        { 
            StatusCode = statusCode;
        }

        public T Resource { get; set; }
         
    }
}
