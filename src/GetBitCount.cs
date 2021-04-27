using System;
using System.Collections.Generic;
using System.Text;

namespace BitsExtensions
{
    public static partial class Bits
    {
        public static int GetBitCount(this int value) => GetBitCount((uint)value);

        public static int GetBitCount(this uint value)
        {
            value = (value & 0x55555555u) + ((value >> 1) & 0x55555555u);
            value = (value & 0x33333333u) + ((value >> 2) & 0x33333333u);
            value = (value & 0x0F0F0F0Fu) + ((value >> 4) & 0x0F0F0F0Fu);
            value = (value & 0x00FF00FFu) + ((value >> 8) & 0x00FF00FFu);
            value = (value & 0x0000FFFFu) + ((value >> 16) & 0x0000FFFFu);
            return (int)value;
        }

        public static int GetBitCount(this long value) => GetBitCount((ulong)value);
        public static int GetBitCount(this ulong value)
        {
            value = (value & 0x5555555555555555u) + ((value >> 1) & 0x5555555555555555u);
            value = (value & 0x3333333333333333u) + ((value >> 2) & 0x3333333333333333u);
            value = (value & 0x0F0F0F0F0F0F0F0Fu) + ((value >> 4) & 0x0F0F0F0F0F0F0F0Fu);
            value = (value & 0x00FF00FF00FF00FFu) + ((value >> 8) & 0x00FF00FF00FF00FFu);
            value = (value & 0x0000FFFF0000FFFFu) + ((value >> 16) & 0x0000FFFF0000FFFFu);
            value = (value & 0x00000000FFFFFFFFu) + ((value >> 32) & 0x00000000FFFFFFFFu);
            return (int)value;
        }
    }
}
