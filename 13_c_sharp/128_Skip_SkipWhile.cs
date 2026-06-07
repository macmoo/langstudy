using System;

// ------------------------------------------
// 특정 위치까지 요소를 스킵
// ------------------------------------------
// public static IEnumerable<TSource> Skip<TSource>(
//     this IEnumerable<TSource> source, int count);
//
// public static IEnumerable<TSource> SkipWhile<TSource>(
//     this IEnumerbale<TSource> source,
//     Func<TSource, bool> predicate);
// ------------------------------------------
// Skip메소르는 시퀀스를 지정한 요소수 만큼 스킵하고 남은 요소를 추출.
// SkipWhile은 지정한 조건 만족하는 요소를 스킵.
// ------------------------------------------
var fruits = new List<string>
{
    "apple", "avocado", "banana", "blueberry", "cherry", "grape"
};
var tail1 = fruits.Skip(4);
var tail2 = fruits.SkipWhile(x => x.StartsWith("a"));
var tail3 = fruits.SkipLast(1);
Console.WriteLine(string.Join(", ", tail1));
Console.WriteLine(string.Join(", ", tail2));
Console.WriteLine(string.Join(", ", tail3));

// ------------------------------------------
// cherry, grape
// banana, blueberry, cherry, grape
// apple, avocado, banana, blueberry, cherry
// ------------------------------------------
