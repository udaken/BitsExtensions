using System;
using System.Runtime.CompilerServices;

namespace BitsExtensions
{
    public static partial class Bits
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static byte GetHiPart(this short value) =>  GetHiPart((ushort)value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static byte GetHiPart(this ushort value) => (byte)(value >> (sizeof(byte) * 8));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static byte GetLoPart(this ushort value) => GetLoPart((short)value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static byte GetLoPart(this short value) => (byte)(value & byte.MaxValue);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ushort GetHiPart(this int value) =>  GetHiPart((uint)value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ushort GetHiPart(this uint value) => (ushort)(value >> (sizeof(ushort) * 8));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ushort GetLoPart(this uint value) => GetLoPart((int)value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ushort GetLoPart(this int value) => (ushort)(value & ushort.MaxValue);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint GetHiPart(this long value) =>  GetHiPart((ulong)value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint GetHiPart(this ulong value) => (uint)(value >> (sizeof(uint) * 8));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint GetLoPart(this ulong value) => GetLoPart((long)value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint GetLoPart(this long value) => (uint)(value & uint.MaxValue);

    }
}


