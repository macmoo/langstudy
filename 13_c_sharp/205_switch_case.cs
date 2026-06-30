using System;

// case라벨에 when구를 추가해, 조건을 추가하는 것이 가능.
object obj = 10;
switch (obj)
{
    case int i when i >= 1:
    case short s when s >= 1:
        Console.WriteLine("1이상의 정수");
        break;
    case double d when d >= 1.0:
    case float f when f >= 1.0:
        Console.WriteLine("1이상의 부동소수점");
        break;
    default:
        Console.WriteLine("그 외의 값");
        break;
}
// 1이상의 정수