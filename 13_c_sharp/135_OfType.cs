using System;

// ------------------------------------------
// 시퀀스에서 지정한 형의 요소만을 추출할때 사용.
var list = new object[] { 10, 30L, 4.32, "work", 45, "text" };
var query = list.OfType<int>();
foreach( var n in query)
{
    Console.WriteLine(n);
}

// 10
// 45