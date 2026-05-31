using System;

// N비트의 상태를 체크
ushort num1 = 0b_0000_0000_0001_0000;
ushort num2 = 0b_0000_0000_0010_0000;

// 5비트 째가 1인가 아닌가
var n = 5;
var isOn = (num1 & 1 << n) != 0;
Console.WriteLine($"{n}비트째는 On이냐 {isOn}");

var isOn2 = (num2 & 1 << n) != 0;
Console.WriteLine($"{n}비트째는 On이냐 {isOn2}");
