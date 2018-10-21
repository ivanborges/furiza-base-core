using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace Furiza.Base.Core.Exceptions
{
    public abstract class CoreExceptionItem
    {
        public string Key { get; }
        public string Message { get; }

        protected CoreExceptionItem(string key, string message)
        {
            Key = key;
            Message = message;
        }

        public override string ToString() => $"[{Key}] {Message}";

        public override bool Equals(object obj)
        {
            var otherKey = obj as CoreExceptionItem;
            if (otherKey == null)
                return false;

            var typeMatches = GetType().Equals(obj.GetType());
            var keyMatches = Key.Equals(otherKey.Key);

            return typeMatches && keyMatches;
        }

        public override int GetHashCode() => Key.GetHashCode();

        public static IEnumerable<T> GetAll<T>() where T : CoreExceptionItem
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

        public static T FromKey<T>(string key) where T : CoreExceptionItem => Parse<T, string>(key, item => item.Key.Trim().ToUpper() == key.Trim().ToUpper());

        public static T FromMessage<T>(string message) where T : CoreExceptionItem => Parse<T, string>(message, item => item.Message.Trim().ToUpper() == message.Trim().ToUpper());

        public static bool operator ==(CoreExceptionItem left, CoreExceptionItem right)
        {
            if (Equals(left, null))
                return (Equals(right, null));
            else
                return left.Equals(right);
        }

        public static bool operator !=(CoreExceptionItem left, CoreExceptionItem right) => !(left == right);

        #region [+] Pvts

        private static T Parse<T, K>(K key, Func<T, bool> predicate) where T : CoreExceptionItem
        {
            var matchingItem = GetAll<T>().FirstOrDefault(predicate)
                ?? throw new ArgumentException(nameof(key));

            return matchingItem;
        }

        #endregion
    }
}