#pragma warning disable IDE0046
using System;
using System.Runtime.CompilerServices;

namespace BitsExtensions
{
    public static partial class Bits
    {
        #region int/uint
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void SetBit(ref this uint value, Index index, bool flag)
        {
            var offset = index.IsFromEnd ? (sizeof(int) * 8) - index.Value : index.Value;
            uint mask = (uint)(1U << (offset - 1));
            if (flag)
            {
                value |= mask;
            }
            else
            {
                value &= (uint)~mask;
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool GetBitAsBool(this uint value, Index index)
        {
            var offset = index.IsFromEnd ? (sizeof(int) * 8) - index.Value : index.Value;
            const uint One = (uint)1U;
            return (value & (One << (offset - 1))) != 0;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool GetBitAsBool(this int value, Index index) => GetBitAsBool((uint)value, index);

        public static bool GetBitAsBoolChecked(this uint value, Index index)
        {
            if (index.Value >= (sizeof(uint) * 8))
                throw new ArgumentOutOfRangeException(nameof(index));
            return GetBitAsBoolChecked(value, index);
        }

        public static bool GetBitAsBoolChecked(this int value, Index index) => GetBitAsBoolChecked((uint)value, index);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint GetBits(this uint value, Range range)
        {
            var start = range.Start.IsFromEnd ? (sizeof(int) * 8) - range.Start.Value : range.Start.Value;
            var end = range.End.IsFromEnd ? (sizeof(int) * 8) - range.End.Value : range.End.Value;
            var count = end - start - 1;
            const uint One = (uint)1U;
            return (uint)((value >> start) & ((One << count) - 1));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint GetBits(this int value, Range range) => GetBits((uint)value, range);

        public static uint GetBitsChecked(this uint value, Range range)
        {
            if (range.Start.Value >= (sizeof(uint) * 8) || range.End.Value >= (sizeof(uint) * 8))
                throw new ArgumentOutOfRangeException(nameof(range));
            return GetBits(value, range);
        }

        public static uint GetBitsChecked(this int value, Range range) => GetBitsChecked((uint)value, range);

        #endregion

        #region short/ushort
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void SetBit(ref this ushort value, Index index, bool flag)
        {
            var offset = index.IsFromEnd ? (sizeof(short) * 8) - index.Value : index.Value;
            ushort mask = (ushort)(1U << (offset - 1));
            if (flag)
            {
                value |= mask;
            }
            else
            {
                value &= (ushort)~mask;
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool GetBitAsBool(this ushort value, Index index)
        {
            var offset = index.IsFromEnd ? (sizeof(short) * 8) - index.Value : index.Value;
            const ushort One = (ushort)1U;
            return (value & (One << (offset - 1))) != 0;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool GetBitAsBool(this short value, Index index) => GetBitAsBool((ushort)value, index);

        public static bool GetBitAsBoolChecked(this ushort value, Index index)
        {
            if (index.Value >= (sizeof(ushort) * 8))
                throw new ArgumentOutOfRangeException(nameof(index));
            return GetBitAsBoolChecked(value, index);
        }

        public static bool GetBitAsBoolChecked(this short value, Index index) => GetBitAsBoolChecked((ushort)value, index);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ushort GetBits(this ushort value, Range range)
        {
            var start = range.Start.IsFromEnd ? (sizeof(short) * 8) - range.Start.Value : range.Start.Value;
            var end = range.End.IsFromEnd ? (sizeof(short) * 8) - range.End.Value : range.End.Value;
            var count = end - start - 1;
            const ushort One = (ushort)1U;
            return (ushort)((value >> start) & ((One << count) - 1));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ushort GetBits(this short value, Range range) => GetBits((ushort)value, range);

        public static ushort GetBitsChecked(this ushort value, Range range)
        {
            if (range.Start.Value >= (sizeof(ushort) * 8) || range.End.Value >= (sizeof(ushort) * 8))
                throw new ArgumentOutOfRangeException(nameof(range));
            return GetBits(value, range);
        }

        public static ushort GetBitsChecked(this short value, Range range) => GetBitsChecked((ushort)value, range);

        #endregion

        #region long/ulong
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void SetBit(ref this ulong value, Index index, bool flag)
        {
            var offset = index.IsFromEnd ? (sizeof(long) * 8) - index.Value : index.Value;
            ulong mask = (ulong)(1U << (offset - 1));
            if (flag)
            {
                value |= mask;
            }
            else
            {
                value &= (ulong)~mask;
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool GetBitAsBool(this ulong value, Index index)
        {
            var offset = index.IsFromEnd ? (sizeof(long) * 8) - index.Value : index.Value;
            const ulong One = (ulong)1U;
            return (value & (One << (offset - 1))) != 0;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool GetBitAsBool(this long value, Index index) => GetBitAsBool((ulong)value, index);

        public static bool GetBitAsBoolChecked(this ulong value, Index index)
        {
            if (index.Value >= (sizeof(ulong) * 8))
                throw new ArgumentOutOfRangeException(nameof(index));
            return GetBitAsBoolChecked(value, index);
        }

        public static bool GetBitAsBoolChecked(this long value, Index index) => GetBitAsBoolChecked((ulong)value, index);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ulong GetBits(this ulong value, Range range)
        {
            var start = range.Start.IsFromEnd ? (sizeof(long) * 8) - range.Start.Value : range.Start.Value;
            var end = range.End.IsFromEnd ? (sizeof(long) * 8) - range.End.Value : range.End.Value;
            var count = end - start - 1;
            const ulong One = (ulong)1U;
            return (ulong)((value >> start) & ((One << count) - 1));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ulong GetBits(this long value, Range range) => GetBits((ulong)value, range);

        public static ulong GetBitsChecked(this ulong value, Range range)
        {
            if (range.Start.Value >= (sizeof(ulong) * 8) || range.End.Value >= (sizeof(ulong) * 8))
                throw new ArgumentOutOfRangeException(nameof(range));
            return GetBits(value, range);
        }

        public static ulong GetBitsChecked(this long value, Range range) => GetBitsChecked((ulong)value, range);

        #endregion

        #region sbyte/byte
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void SetBit(ref this byte value, Index index, bool flag)
        {
            var offset = index.IsFromEnd ? (sizeof(sbyte) * 8) - index.Value : index.Value;
            byte mask = (byte)(1U << (offset - 1));
            if (flag)
            {
                value |= mask;
            }
            else
            {
                value &= (byte)~mask;
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool GetBitAsBool(this byte value, Index index)
        {
            var offset = index.IsFromEnd ? (sizeof(sbyte) * 8) - index.Value : index.Value;
            const byte One = (byte)1U;
            return (value & (One << (offset - 1))) != 0;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool GetBitAsBool(this sbyte value, Index index) => GetBitAsBool((byte)value, index);

        public static bool GetBitAsBoolChecked(this byte value, Index index)
        {
            if (index.Value >= (sizeof(byte) * 8))
                throw new ArgumentOutOfRangeException(nameof(index));
            return GetBitAsBoolChecked(value, index);
        }

        public static bool GetBitAsBoolChecked(this sbyte value, Index index) => GetBitAsBoolChecked((byte)value, index);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static byte GetBits(this byte value, Range range)
        {
            var start = range.Start.IsFromEnd ? (sizeof(sbyte) * 8) - range.Start.Value : range.Start.Value;
            var end = range.End.IsFromEnd ? (sizeof(sbyte) * 8) - range.End.Value : range.End.Value;
            var count = end - start - 1;
            const byte One = (byte)1U;
            return (byte)((value >> start) & ((One << count) - 1));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static byte GetBits(this sbyte value, Range range) => GetBits((byte)value, range);

        public static byte GetBitsChecked(this byte value, Range range)
        {
            if (range.Start.Value >= (sizeof(byte) * 8) || range.End.Value >= (sizeof(byte) * 8))
                throw new ArgumentOutOfRangeException(nameof(range));
            return GetBits(value, range);
        }

        public static byte GetBitsChecked(this sbyte value, Range range) => GetBitsChecked((byte)value, range);

        #endregion

    }
}


