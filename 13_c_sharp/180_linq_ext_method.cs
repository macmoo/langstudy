using System;
using System.Collections.Generic;
using System.Linq;

// 길이가 8이상인 요소가 포함되어 있는가
var drinks = new[] {"wine", "sake", "beer", "whisky", "liqueur", "cocktail", "champagne"};
var contains = drinks.Contains(x => x.Length >= 8);
Console.WriteLine(contains);

// 3으로 나누어 떨어지는 요소가 있는가
var nums = new[] { 1, 3, 5, 7, 9, 11 };
var contains2 = nums.Contains(x => x % 3 == 0);
Console.WriteLine(contains2);

// LINQ to Object를 확장하는 메소드
// IEnumerable<T>인터페이스에 대해 확장메소드를 정의
public static class EnumerableExtensions
{
    public static bool Contains<T>(this IEnumerable<T> source, Predicate<T> predicate)
    {
        foreach (var element in source)
            if (predicate(element) == true)
                return true;
        return false;
    }
}

// True
// True