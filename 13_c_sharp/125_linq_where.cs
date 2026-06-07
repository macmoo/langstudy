using System;
using System.Xml.Linq;

// ------------------------------------------
// public static IEnumerable<TSource> Where<TSource>(
//     this IEnumerable<TSource> source,    // 조건
//     Func<TSource, bool> predicate);

var list = new[]
{
    new {Name="후루자와", Age=28},
    new {Name="마치다", Age=20},
    new {Name="타케다", Age=31 },
    new {Name="다카야마", Age=19},
    new {Name="후미카이", Age=22},
};
var query = list.Where(x => x.Age > 20);
foreach (var x in query)
{
    Console.WriteLine(x);
}
Console.WriteLine();
// ------------------------------------------
var list2 = new[] { 28, 32, 54, 21, 56, 98, 14, 43 };
foreach (var x in list2)
{
    Console.Write($"{x} ");
}
Console.WriteLine();
// ------------------------
// ix는 인덱스
var query2 = list2.Where((n, ix) => ix % 2 == 0 && n >= 30);
foreach (var x in query2)
{
    Console.Write($"{x} ");
}
Console.WriteLine();
// ------------------------
var query3 = list2.Where((n, ix) => ix == 3);
foreach (var x in query3)
{
    Console.Write($"{x} ");
}
Console.WriteLine();
// ------------------------
// { Name = 후루자와, Age = 28 }
// { Name = 타케다, Age = 31 }
// { Name = 후미카이, Age = 22 }
// 
// 28 32 54 21 56 98 14 43
// 54 56
// 21
