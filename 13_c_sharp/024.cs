using System;

try
{
    var num = int.MaxValue - 5;

    // 방법 1 
    checked // <- overflow검출
    {
        num += 6;
    }

    // 방법 2
    num = checked(num + 6);
    Console.WriteLine(num);
}
catch(OverflowException e)
{
    Console.WriteLine(e.Message);
}
// Arithmetic operation resulted in an overflow.