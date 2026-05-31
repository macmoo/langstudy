using System;

static string ToBinary(int n)
{
    return Convert.ToString(n, 2).PadLeft(16, '0');
}

ushort num1 = 0b_0000_0000_1111_1000;
ushort num2 = 0b_0000_0000_1001_1101;

Console.WriteLine($"비트num1\t{ToBinary(num1)}");
Console.WriteLine($"비트num2\t{ToBinary(num2)}");

var bitrev = (ushort)~num1;
Console.WriteLine($"비트반전\t{ToBinary(bitrev)}");

var bitor = num1 | num2;
Console.WriteLine($"비트or\t\t{ToBinary(bitor)}");

var bitand = num1 & num2;
Console.WriteLine($"비트and\t\t{ToBinary(bitand)}");

var bitxor = num1 ^ num2;
Console.WriteLine($"비트xor\t\t{ToBinary(bitxor)}");

var bitshift1 = num1 << 1;
Console.WriteLine($"비트 L shift\t{ToBinary(bitshift1)}");

var bitshift2 = num1 >> 1;
Console.WriteLine($"비트 R shift\t{ToBinary(bitshift2)}");

// 비트num1        0000000011111000
// 비트num2        0000000010011101
// 비트반전        1111111100000111
// 비트or          0000000011111101
// 비트and         0000000010011000
// 비트xor         0000000001100101
// 비트 L shift    0000000111110000
// 비트 R shift    0000000001111100