using System;

using BitsExtensions;
using BitsExtensions.Exprimental;
using static BitsExtensions.Bits;

// make 0x0000DEADBEEF0000
ulong deadbeef = MakeUInt64(MakeUInt32(0x00, 0, 0xEF, 0xBE), MakeUInt32(0xAD, 0xDE, 0, 0));
int i = 0x7FFFFFFE;
i = FillLower(unchecked((int)0xDEADBEEFU));
Console.WriteLine("{0:X}", i.ToUnsigned().GetBits(1..30));


static int FillLower(int num)
{
    num |= num >> 1;
    num |= num >> 2;
    num |= num >> 4;
    num |= num >> 8;
    num |= num >> 16;
    return num;
}