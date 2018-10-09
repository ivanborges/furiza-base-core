using System;
using System.Linq;

namespace Furiza.Base.Core.Exceptions.Serialization
{
    public class InternalServerError
    {
        public Guid LogId { get; set; }
        public string Message { get; set; }

        public InternalServerError()
        {
        }

        public InternalServerError(Exception exception)
        {
            LogId = Guid.NewGuid();

            if (exception is AggregateException)
            {
                var agEx = exception as AggregateException;
                Message = string.Join(" | ", agEx.InnerExceptions.Select(e => e.Message));
            }
            else
                Message = exception.Message;
        }
    }
}