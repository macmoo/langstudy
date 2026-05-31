using System;

static string ToBinary(int n)
{
    return Convert.ToString(n, 2).PadLeft(16, '0');
}

ushort num = 0b_0000_0000_0001_1000;
Console.WriteLine($"num\t\t{ToBinary(num)}");

// -------------------------------------------------------
var n = 6;
var biton = num | 1 << n;
Console.WriteLine($"{n}비트on\t\t{ToBinary(biton)}");

// -------------------------------------------------------
var bitoff = num & 1 << 4;
Console.WriteLine($"{n}비트off-0\t{ToBinary(1)}");
Console.WriteLine($"{n}비트off-1\t{ToBinary(1 << 4)}");
Console.WriteLine($"{n}비트off-2\t{ToBinary(bitoff)}");
Console.WriteLine($"{n}비트off-3\t{ToBinary(~(1 << 4))}");

// -------------------------------------------------------
var bitoff2 = num & ~(1 << 4); // *
Console.WriteLine($"{n}비트off-4\t{ToBinary(bitoff2)}");

// -------------------------------------------------------
var bit1 = ~(1 << 4); // 11111111111111111111111111101111
var bit2 = 1 << 4; // 0000000000010000
var bit3 = bit1 & bit2;
var bit4 = bit1 | bit2;
var bit5 = bit1 ^ bit2;

Console.WriteLine($"{n}비트off-5\t{ToBinary(bit1)}");
Console.WriteLine($"{n}비트off-6\t{ToBinary(bit2)}");
Console.WriteLine($"{n}비트off-7\t{ToBinary(bit3)}");
Console.WriteLine($"{n}비트off-8\t{ToBinary(bit4)}");
Console.WriteLine($"{n}비트off-9\t{ToBinary(bit5)}");

// -------------------------------------------------------
// num            0000000000011000
// 6비트on         0000000001011000
// 6비트off-0      0000000000000001
// 6비트off-1      0000000000010000
// 6비트off-2      0000000000010000
// 6비트off-3      11111111111111111111111111101111
// 6비트off-4      0000000000001000
// 6비트off-5      11111111111111111111111111101111
// 6비트off-6      0000000000010000
// 6비트off-7      0000000000000000
// 6비트off-8      11111111111111111111111111111111
// 6비트off-9      11111111111111111111111111111111
