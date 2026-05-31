using System;
using System.Globalization;


// ------------------------------------------
var str1 = "1.414";
var r = double.Parse(str1);
Console.WriteLine(r);

// ------------------------------------------
// TryParse는 예외를 발생하지 않음
var str2 = "3.14";
if (double.TryParse(str2, out var pi))
{
    Console.WriteLine(pi);
}
Console.WriteLine(pi);

// ------------------------------------------
var num1 = int.Parse("-123,000", NumberStyles.AllowThousands | NumberStyles.AllowLeadingSign);
Console.WriteLine(num1);

var num2 = int.Parse("-123,000", NumberStyles.Number);
Console.WriteLine(num2);

// NumberStyles.AllowDecimalPoint
// NumberStyles.AllowExponent
// NumberStyles.AllowLeadingSign
// NumberStyles.AllowLeadingWhite
// NumberStyles.AllowTrailingSign
// NumberStyles.AllowTrailingWhite
// NumberStyles.AllowThousands
// NumberStyles.Number

// 1.414
// 3.14
// 3.14
// - 123000
// - 123000
