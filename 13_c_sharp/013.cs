using System;

var nums = new int[] { 1, 3, 5, 7, 9 };
var sum = 0;

// foreach( var 요소 in 컬렉션 )
foreach( var n in nums )
{
    sum += n;
}

Console.WriteLine(sum);

// 25