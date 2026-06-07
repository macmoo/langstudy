using System;

// ------------------------------------------
// OrderBy():오름차순
// OrderByDescending():내림차순
var list = new[]
{
    new {Name="후루자와", Age=28},
    new {Name="마치다", Age=20},
    new {Name="타케다", Age=31 },
    new {Name="나나", Age=19 },
    new {Name="다카야마", Age=19},
    new {Name="후미카이", Age=22},
};

var ordered1 = list.OrderBy(x => x.Age);
var ordered2 = list.OrderByDescending(x => x.Age);
var ordered3 = list.OrderBy(x => x.Age).ThenByDescending(x => x.Name);
// ------------------------------
foreach ( var x in ordered1)
{
    Console.WriteLine($"{x.Name} {x.Age}");
}
Console.WriteLine();
// ------------------------------
foreach (var x in ordered2)
{
    Console.WriteLine($"{x.Name} {x.Age}");
}
Console.WriteLine();
// ------------------------------
foreach (var x in ordered3)
{
    Console.WriteLine($"{x.Name} {x.Age}");
}
Console.WriteLine();
// ------------------------------
// 나나 19
// 다카야마 19
// 마치다 20
// 후미카이 22
// 후루자와 28
// 타케다 31
//
// 타케다 31
// 후루자와 28
// 후미카이 22
// 마치다 20
// 나나 19
// 다카야마 19
//
// 다카야마 19
// 나나 19
// 마치다 20
// 후미카이 22
// 후루자와 28
// 타케다 31