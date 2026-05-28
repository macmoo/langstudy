using System;
using System.Numerics;

// 부동소수점은 소수를 2진수의 분수로 표현하기 때문에
// 10진수의 소수를 정확히 표현하지 못하는 경우가 있다.

var d = 0.0;

for (int i = 0; i < 100; i++)
{
    d += 0.01;
}

static bool DoubleEquals(double a, double b)
{
    var difference = a * 1.0E-14;
    return Math.Abs(a - b) <= difference;
}


Console.WriteLine(d == 1.0 ? "same": "not same");

Console.WriteLine(Double.Equals(d, 1.0)? "same" : "not same");

Console.WriteLine(DoubleEquals(d, 1.0)? "same" : "not same");


// not same
// not same
// same