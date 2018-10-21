using System;
using System.Data.SqlTypes;

namespace Furiza.Base.Core.SeedWork
{
    public abstract class Entity
    {
        public Guid Id { get; protected set; }
        public DateTime CreationDate { get; protected set; } = SqlDateTime.MinValue.Value;
        public string CreationUser { get; set; }

        public bool IsTransient() => Id == default(Guid);

        public override bool Equals(object obj)
        {
            if (obj == null || !(obj is Entity))
                return false;

            if (ReferenceEquals(this, obj))
                return true;

            if (GetType() != obj.GetType())
                return false;

            var item = (Entity)obj;
            if (item.IsTransient() || IsTransient())
                return false;
            else
                return item.Id == Id;
        }

        public override int GetHashCode()
        {
            if (!IsTransient())
                return Id.GetHashCode() ^ 31;
            else
                return base.GetHashCode();
        }
    }
}