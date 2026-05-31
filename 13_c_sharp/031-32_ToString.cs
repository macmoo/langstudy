using System;

// ------------------------------------------
var n = 10;
string s1 = n.ToString();
Console.WriteLine(s1);

var f = 10.45;
string s2 = f.ToString();
Console.WriteLine(s2);
Console.WriteLine();
// ------------------------------------------
var num1 = 1234567;
var str1 = num1.ToString("E");
var str2 = num1.ToString("D10");
var str3 = num1.ToString("#,0");
var str4 = num1.ToString("0000000000");

Console.WriteLine(str1);
Console.WriteLine(str2);
Console.WriteLine(str3);
Console.WriteLine(str4);
Console.WriteLine();
// ------------------------------------------
var num2 = 123.45;
var str5 = num2.ToString("F");
var str6 = num2.ToString("#,0.0");
var str7 = num2.ToString("0000.000");

Console.WriteLine(str5);
Console.WriteLine(str6);
Console.WriteLine(str7);
Console.WriteLine();

// ------------------------------------------
var str8 = string.Format("{0:F4}", num2);
var str9 = string.Format("{0:00000.000}", num2);
Console.WriteLine(str8);
Console.WriteLine(str9);
Console.WriteLine();
// ------------------------------------------
var num3 = 123456;
var num4 = 9876.5;

var str10 = string.Format("{0, 10:#,0}", num3);
var str11 = string.Format("{0, 10:#,0.00}", num4);

Console.WriteLine(str10);
Console.WriteLine(str11);
Console.WriteLine();
// ------------------------------------------
// 10
// 10.45

// 1.234567E+006
// 0001234567
// 1,234,567
// 0001234567

// 123.45
// 123.5
// 0123.450

// 123.4500
// 00123.450

//    123,456
//   9,876.50
