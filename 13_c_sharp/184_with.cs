using System;
using System.Xml.Linq;


// with식을 쓰면 오브젝트를 복사할 때 
// 지정한 프로퍼티만 다른 값으로 변경가능하다.
//
var p1 = new NamedPoint("A", 100, 200);
var p2 = p1 with { Name = "B", X = 50 };
Console.WriteLine($"{nameof(p1)}: {p1}");
Console.WriteLine($"{nameof(p2)}: {p2}");

public record NamedPoint(string Name, int X, int Y);

// p1: NamedPoint { Name = A, X = 100, Y = 200 }
// p2: NamedPoint { Name = B, X = 50,  Y = 200 }
