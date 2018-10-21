using System;
using System.Runtime.Serialization;

namespace Furiza.Base.Core.Exceptions
{
    [Serializable]
    public abstract class CoreException : Exception
    {
        public abstract string Key { get; }
        public abstract override string Message { get; }

        public CoreException()
        {
        }

        protected CoreException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }    
}