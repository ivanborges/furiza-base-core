using System;

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
            Message = exception.Message;
        }
    }
}