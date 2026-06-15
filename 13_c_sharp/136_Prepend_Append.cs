using System;

// ------------------------------------------
//
// Prepend() : 시퀀스의 선두에 요소추가
// Append()  : 시퀀스의 후미에 요소추가
//
var sports = new[] { "tennis", "basketball", "baseball", "skating", };
var newseq1 = sports.Prepend("skiing");
Console.WriteLine(string.Join(", ", newseq1));

var newseq2 = sports.Append("skiing");
Console.WriteLine(string.Join(", ", newseq2));
Console.WriteLine();
// ------------------------------------------
// 
// Count()   : 시퀀스에 속한 요소수를 카운트
// - Func<TSource, bool>델리게이트를 취하는 메소드도 있다.
//
var count1 = sports.Count();
Console.WriteLine($"count1:{count1}");

var count2 = sports.Count(x => x.Length > 7);
Console.WriteLine($"count2:{count2}");
Console.WriteLine();
// ------------------------------------------
// 
// Sum()     : 시퀀스의 합계를 구함.
// Max()     : 시퀀스의 최대값을 구함.
// Min()     : 시퀀스의 최소값을 구함.
// Average() : 시퀀스의 평균값을 구함.
//
var list = new[]
{
    new {Name="이케부쿠로", Attempts=20 ,Success=10},
    new {Name="마치다"    , Attempts=17 ,Success=11},
    new {Name="토요스"    , Attempts=22 ,Success=18},
    new {Name="치요다"    , Attempts=21 ,Success=12},
};
var sum = list.Sum(x => x.Success);
var max = list.Max(x => x.Success);
var min = list.Min(x => x.Success);

var max_p = list.Max(x => (double)x.Success / x.Attempts);
var min_p = list.Min(x => (double)x.Success / x.Attempts);

var avg = list.Average(x => x.Success);

Console.WriteLine($"sum   :{sum}");
Console.WriteLine($"max   :{max}");
Console.WriteLine($"min   :{min}");
Console.WriteLine();

Console.WriteLine($"max % :{max_p}");
Console.WriteLine($"min % :{min_p}");
Console.WriteLine();

Console.WriteLine($"avg   :{avg}");
Console.WriteLine();

// ------------------------------------------
// 
// All()     : 시퀀스내의 모든 요소가 조건을 만족하는지 조사.
// Any()     : 시퀀스내에 조건을 만족하는 요소가 있는지 조사.
// 
// public static bool All<TSource>(
//     this IEnumerbal<TSource> source, Func<TSource, bool> predicate);
//
// public static bool Any<TSource>(
//     this IEnumerbal<TSource> source, Func<TSource, bool> predicate);
//
if (list.All(x => x.Attempts >= 10))
    Console.WriteLine("모든 멤버의 attempts가 10이상이다.");
Console.WriteLine();

if (list.Any(x => x.Attempts >= 20))
    Console.WriteLine("Attempts가 20이상인 멤버가 있다.");

// 시퀀스내에 요소가 존재하는지 조사.
// Count()보다 Any()가 효율이 좋다.
if (list.Any())
    Console.WriteLine("리스트에 요소가 존재");
Console.WriteLine();
// ------------------------------------------
// skiing, tennis, basketball, baseball, skating
// tennis, basketball, baseball, skating, skiing
// 
// count1:4
// count2:2
// 
// sum: 51
// max: 18
// min: 10
// 
// max % :0.8181818181818182
// min % :0.5
// 
// avg: 12.75
// 
// 모든 멤버의 attempts가 10이상이다.
// 
// Attempts가 20이상인 멤버가 있다.
// 리스트에 요소가 존재
