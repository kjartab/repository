using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace kjartab.repository.model
{
    public interface IResponse
    { 
        string Message { get; set; }
        HttpStatusCode StatusCode { get; set; } 
        string ETag { get; set; }
    }

    public interface IDataResponse<T> : IResponse
    {
        T Data { get; set; }
    }

    public interface IResourceResponse<T> : IResponse where T : IResource
    {
        T Resource { get; set; } 
    }

}
