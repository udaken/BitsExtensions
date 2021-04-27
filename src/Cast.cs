using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace BitsExtensions
{
    public static class Casts
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint ToUnsigned(this int value) => (uint)value;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ulong ToUnsigned(this long value) => (ulong)value;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ushort ToUnsigned(this short value) => (ushort)value;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static byte ToUnsigned(this sbyte value) => (byte)value;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UIntPtr ToUnsigned(this IntPtr value) => IntPtr.Size == 8 ? (UIntPtr)value.ToInt64() : (UIntPtr)value.ToInt32();

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int ToSigned(this uint value) => (int)value;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static long ToSigned(this ulong value) => (long)value;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static short ToSigned(this ushort value) => (short)value;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static sbyte ToSigned(this byte value) => (sbyte)value;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static IntPtr ToSigned(this UIntPtr value) => UIntPtr.Size == 8 ? (IntPtr)value.ToUInt64() : (IntPtr)value.ToUInt32();

    }
}
