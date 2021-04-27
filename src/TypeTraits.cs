using System;

namespace BitsExtensions
{
    public static class TypeTraits
    {
        public static bool IsInteger(this Type type)
        {
            return IsSignedInteger(type) || IsUnsignedInteger(type);
        }

        public static bool IsSignedInteger(this Type type)
        {
            return type == typeof(int) || type == typeof(long) || type == typeof(short) || type == typeof(sbyte);
        }

        public static bool IsUnsignedInteger(this Type type)
        {
            return type == typeof(uint) || type == typeof(ulong) || type == typeof(ushort) || type == typeof(byte);
        }
    }
}
