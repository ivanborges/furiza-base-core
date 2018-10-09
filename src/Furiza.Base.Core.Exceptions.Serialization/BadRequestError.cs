using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Furiza.Base.Core.Exceptions.Serialization
{
    public class BadRequestError
    {
        public string Key { get; set; }
        public string Message { get; set; }
        public ICollection<BadRequestErrorItem> Items { get; set; }

        public BadRequestError()
        {
        }

        public BadRequestError(CoreException coreException)
        {
            Key = coreException.Key;
            Message = coreException.Message;

            if (coreException.GetType().BaseType.IsGenericType)
            {
                Items = new List<BadRequestErrorItem>();
                var items = coreException.GetType().GetProperties().Single(p => p.Name == nameof(CoreException<CoreExceptionItem>.Items));
                foreach (var item in (IEnumerable)items.GetValue(coreException))
                    Items.Add(new BadRequestErrorItem()
                    {
                        Key = (item as CoreExceptionItem)?.Key,
                        Message = (item as CoreExceptionItem)?.Message
                    });
            }
        }
    }
}