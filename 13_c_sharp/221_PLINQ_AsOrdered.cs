

// PLINQ쿼리 결과의 순서를 소스시퀀스의 순서와 같은 순서로 할 수 있다.
//
// public static ParallelQuery<TSource> AsOrdered<TSource>(this ParallelQuery<TSource> souce);

using System;
using System.Linq;

var list = new[] {
    new { Name = "다케다", Attempts = 20, Success = 10 },
    new { Name = "마치다", Attempts = 17, Success = 11 },
    new { Name = "후미아키", Attempts = 22, Success = 18 },
    new { Name = "다카야마", Attempts = 21, Success = 12 },
};

var query = list.AsParallel()
            .AsOrdered()
            .WithDegreeOfParallelism(4)
            .Select(x => new
            {
                x.Name,
                SuccessRate = (x.Success * 100.0) / x.Attempts
            });
foreach (var item in query)
{
    Console.WriteLine($"{item.Name}: {item.SuccessRate:0.0}%");
}

// 다케다: 50.0 %
// 마치다: 64.7 %
// 후미아키: 81.8 %
// 다카야마: 57.1 %
