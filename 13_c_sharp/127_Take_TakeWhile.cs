using System;

// ------------------------------------------
// public static IEnumerable<TSource> Take<TSource>(
//     this IEnumerable<TSource> source, int count);
//
// public static IEnumerable<TSource> TakeWhile<TSource>(
//     this IEnumerable<TSource> source,
//     Func<TSource, bool> predicate);

// ------------------------------------------
// Take메소드를 사용하면, 시퀀스의 선두부터 지정한 수만큼의 요소를 추출하는 것이 가능.
// TakeWhile메소드는 지정한 조건으 만족하는 요소를 추출.
// ------------------------------------------
var fruits = new List<string>
{
    "apple", "avocado", "banana", "blueberry", "cherry", "grape"
};
var head = fruits.Take(4);
Console.WriteLine(string.Join(", ", head));
Console.WriteLine();
// ------------------------------------------
var head2 = fruits.TakeWhile(x => x.StartsWith("a"));
Console.WriteLine(string.Join(", ", head2));
Console.WriteLine();
// ------------------------------------------
// apple, avocado, banana, blueberry
//
// apple, avocado
// ------------------------------------------
// ------------------------------------------
