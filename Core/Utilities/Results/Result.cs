using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    public class Result : IResult
    {
        public Result(bool success, string message):this(success)
        {
            Message = message;
        }

        public Result(bool success)
        {
            Sucess = success;
        }

        public bool Sucess { get; } 
        ///getter read only o yüzden constructorda set edilebilir

        public string Message { get; }
    }
}
