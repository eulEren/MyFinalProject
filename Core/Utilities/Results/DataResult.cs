using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    public class DataResult<T> : Result, IDataResult<T>
    {
        public DataResult(T data, bool succsess, string message) : base(succsess, message)
        {
            Data = data;
        }
        public DataResult(T data, bool succsess) : base(succsess)
        {
            Data = data;
        }
        public T Data { get; }
    }
    

    
}
