
// PLINQ로 병렬처리된 결과에 대해, 추가로 반복처리를 하고 싶은 경우, ForAll()를 사용.
// 그로인해 그 반복처리도 병렬처리되어, foreach문보다 고속으로 처리할 가능성이 있다.
//
// public static void ForAll<TSource>(this ParallelQuery<TSource> souce, Action<TSource> action);

using System;
using System.Linq;

var list = new[] {
    new { Name = "다케다", Attempts = 20, Success = 10 },
    new { Name = "마치다", Attempts = 17, Success = 11 },
    new { Name = "후미아키", Attempts = 22, Success = 18 },
    new { Name = "다카야마", Attempts = 21, Success = 12 },
};

list.AsParallel()
    .WithDegreeOfParallelism(4)
    .Select(x => new
    {
        x.Name,
        SuccessRate = (x.Success * 100.0) / x.Attempts
    })
    .ForAll(item =>
    {
        Console.WriteLine($"{item.Name}: {item.SuccessRate:0.0}%");
    });

// 다케다: 50.0 %
// 마치다: 64.7 %
// 다카야마: 57.1 %
// 후미아키: 81.8 %
