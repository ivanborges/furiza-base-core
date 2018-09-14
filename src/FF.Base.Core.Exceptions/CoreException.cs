using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace FF.Base.Core.Exceptions
{
    public abstract class CoreException : Exception
    {
        public abstract string Key { get; }
        public abstract override string Message { get; }
    }

    public abstract class CoreException<T> : CoreException where T : CoreExceptionItem
    {
        public override string Message => $"One or more core exceptions occurred while processing the request. Please check '{nameof(Items)}' for details.";

        public IReadOnlyCollection<T> Items => new ReadOnlyCollection<T>(_items.ToList());
        private IEnumerable<T> _items;

        public CoreException(IEnumerable<T> coreExceptionItems) => _items = coreExceptionItems;
    }
}