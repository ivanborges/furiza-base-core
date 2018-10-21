using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Runtime.Serialization;

namespace Furiza.Base.Core.Exceptions
{
    [Serializable]
    public abstract class CoreException<T> : CoreException where T : CoreExceptionItem
    {
        public override string Message => $"One or more core exceptions occurred while processing the request. Please check '{nameof(Items)}' for details.";

        public IReadOnlyCollection<T> Items => new ReadOnlyCollection<T>(_items.ToList());
        private readonly IEnumerable<T> _items;

        protected CoreException(IEnumerable<T> coreExceptionItems) : base() => 
            _items = coreExceptionItems;

        protected CoreException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}