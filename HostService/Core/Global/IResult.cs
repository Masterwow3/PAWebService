using System;

namespace WebService.Global
{
    public class IResult<T>
    {
        /// <summary>
        /// Result is Success
        /// </summary>
        public IResult()
        {
            Result = ResultState.Success;
        }

        public IResult(T data, ResultState result = ResultState.Success, string message = null, Exception exception = null)
        {
            this.Data = data;
            this.Result = result;
            this.Message = message;
            this.Exception = exception;
        }

        public T Data { get; set; }
        public Exception Exception { get; set; }
        public string Message { get; set; }
        public ResultState Result { get; set; }
    }
}