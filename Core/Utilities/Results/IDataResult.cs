using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utiliries.Results
{
    public interface IDataResult<T>:IResult, IEnumerable
    {
        T Data { get; }  
    }
}
