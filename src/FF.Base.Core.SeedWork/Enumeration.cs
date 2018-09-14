using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace FF.Base.Core.SeedWork
{
    public abstract class Enumeration : IComparable
    {
        public int Value { get; set; }
        public string DisplayAs { get; set; }

        protected Enumeration(int value, string displayAs)
        {
            Value = value;
            DisplayAs = displayAs;
        }

        public override string ToString() => $"[{Value}] {DisplayAs}";

        public override bool Equals(object obj)
        {
            var otherValue = obj as Enumeration;
            if (otherValue == null)
                return false;

            var typeMatches = GetType().Equals(obj.GetType());
            var valueMatches = Value.Equals(otherValue.Value);

            return typeMatches && valueMatches;
        }

        public override int GetHashCode() => Value.GetHashCode();

        public static IEnumerable<T> GetAll<T>() where T : Enumeration
        {
            var type = typeof(T);
            var fields = type.GetFields(BindingFlags.Public | BindingFlags.Static | BindingFlags.DeclaredOnly);

            foreach (var info in fields)
            {
                var instance = (T)Activator.CreateInstance(typeof(T), true);
                if (info.GetValue(instance) is T locatedValue)
                    yield return locatedValue;
            }
        }

        public static T FromValue<T>(int value) where T : Enumeration => Parse<T, int>(value, item => item.Value == value);

        public static T FromDisplayAs<T>(string displayAs) where T : Enumeration => Parse<T, string>(displayAs, item => item.DisplayAs.Trim().ToUpper() == displayAs.Trim().ToUpper());

        public static bool operator ==(Enumeration left, Enumeration right)
        {
            if (Equals(left, null))
                return (Equals(right, null)) ? true : false;
            else
                return left.Equals(right);
        }

        public static bool operator !=(Enumeration left, Enumeration right) => !(left == right);

        public int CompareTo(object other) => Value.CompareTo(((Enumeration)other).Value);

        #region [+] Pvts

        private static T Parse<T, K>(K value, Func<T, bool> predicate) where T : Enumeration
        {
            var matchingItem = GetAll<T>().FirstOrDefault(predicate) 
                ?? throw new ArgumentException(nameof(value));

            return matchingItem;
        }

        #endregion
    }
}