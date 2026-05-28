using System;
using System.Security.Cryptography;

var rnd = new Random(); // seed 없음
// var rnd = new Random(5); // seed 있음 -> 같은 난수가 나옴

// int
for (int i = 0; i < 5; i++)
{
    var n = rnd.Next(0, 10); // 0 .. 9 의 난수
    Console.Write($"{n}, ");
}
Console.WriteLine();

// double 
for (int i = 0; i < 5; i++)
{
    var n = rnd.NextDouble(); // 0.0 .. 0.9 의 난수
    Console.Write($"{n}, ");
}
Console.WriteLine();

// 보다 정도가 높은 난수
for (int i = 0; i < 5; i++)
{
    var n = RandomNumberGenerator.GetInt32(0, 32);
    Console.Write($"{n}, ");
}
Console.WriteLine();
