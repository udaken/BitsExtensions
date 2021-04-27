using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace BitsExtensions
{
    public static partial class Bits
    {
        [StructLayout(LayoutKind.Explicit)]
        private struct SingleUnion
        {
            [FieldOffset(0)]
            public float Value;
            [FieldOffset(0)]
            public uint Integer;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint SingleToInt32Bits(float value) => new SingleUnion { Value = value }.Integer;

#if NET5_0
        
        [StructLayout(LayoutKind.Explicit)]
        private struct HalfUnion
        {
            [FieldOffset(0)]
            public Half Value;
            [FieldOffset(0)]
            public ushort Integer;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint HalfToInt16Bits(Half value) => new HalfUnion { Value = value }.Integer;
#endif

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ushort MakeUInt16(byte lo, byte hi) => (ushort)((hi << 8) | lo);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static short MakeInt16(byte lo, byte hi) => (short)MakeUInt16(lo, hi);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint MakeUInt32(ushort lo, ushort hi) => (uint)((hi << 16) | lo);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint MakeUInt32(byte lolo, byte lohi, byte hilo, byte hihi) => MakeUInt32(MakeUInt16(lolo, lohi), MakeUInt16(hilo, hihi));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int MakeInt32(short lo, short hi) => (int)MakeUInt32((ushort)lo, (ushort)hi);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int MakeInt32(byte lolo, byte lohi, byte hilo, byte hihi) => MakeInt32(MakeInt16(lolo, lohi), MakeInt16(hilo, hihi));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ulong MakeUInt64(uint lo, uint hi) => ((ulong)hi << 32) | lo;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static long MakeInt64(int lo, int hi) => (long)MakeUInt64((uint)lo, (uint)hi);

    }
}
