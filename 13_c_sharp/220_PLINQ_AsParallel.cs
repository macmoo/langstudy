// PLINQ (Parallel LINQ)
// PLINQ를 사용해서 컬렉션처리를 병렬화하기 위해서는 AsParallel()를 이용한다.


// public static ParallelQuery<TSource> AsParallel<TSource>(this IEnumerable<TSource> souce);

using System;
using System.Linq;

var list = new[] {
    new { Name = "다케다", Attempts = 20, Success = 10 },
    new { Name = "마치다", Attempts = 17, Success = 11 },
    new { Name = "후미아키", Attempts = 22, Success = 18 },
    new { Name = "다카야마", Attempts = 21, Success = 12 },
};

var query = list.AsParallel()
                .WithDegreeOfParallelism(4)
                .Select(x => new
                {
                    x.Name,
                    SuccessRate = (x.Success * 100.0) / x.Attempts
                });

foreach(var item in query)
{
    Console.WriteLine($"{item.Name}: {item.SuccessRate:0.0}%");
}

// 다카야마: 57.1 %
// 다케다: 50.0 %
// 마치다: 64.7 %
// 후미아키: 81.8 %