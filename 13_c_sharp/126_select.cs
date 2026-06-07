using System;

// ------------------------------------------
// 쿼리 결과를 새로운 형으로 변환
//
// Select메소드를 사용하면 시퀀스의 각 요소에 대해 변환처리를 할 수 있다.
// 이것을 射影라고 한다.
// 

// public static IEnumerable<TResult> Select<TSource, TResult>(
//     this IEnumerable<TSource source>,
//     Func<TSource, TResult> selector);

var nums = new int[] { 1, 3, 5, 7, 9, 11 };

var twices = nums.Select(x => x * 2);
Console.WriteLine(string.Join(", ", twices));
Console.WriteLine();

// ------------------------------------------
var list = new[]
{
    new {Name="타케다"  , Attempts= 20, Success=10},
    new {Name="마치다"  , Attempts= 17, Success=11},
    new {Name="다카야마", Attempts= 21, Success=12},
};
var query = list.Select(x => new
{
    x.Name,
    SuccessRate = (x.Success * 100.0)/x.Attempts
});

foreach (var item in query)
{
    Console.WriteLine($"{item.Name}: {item.SuccessRate:0.0}%");
    // Console.WriteLine($"{item.Attempts}"); // error , 미정의
}
Console.WriteLine();

// ------------------------------------------
var nums2 = new[] { "A", "B", "C", "D" };
var seq2 = nums.Select((s, index) => $"{index}:{s}");
Console.WriteLine(string.Join(", ", seq2));

// ------------------------------------------
// 2, 6, 10, 14, 18, 22
//
// 타케다: 50.0 %
// 마치다: 64.7 %
// 다카야마: 57.1 %
//
// 0:1, 1:3, 2:5, 3:7, 4:9, 5:11
