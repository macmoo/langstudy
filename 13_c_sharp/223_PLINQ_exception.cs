using System;
using System.Linq;

// PLINQ로 병렬처리중에 예외가 발생할수 있다.
// PLINQ쿼리 실행중에 throw되어지는 예외는 System.AggregateException예외이다.
//
// PLINQ는 LINQ와 같이 지연처리가 적용되기 때문에 Select()로는 실제의 쿼리처리가 실행되지 않는다.
// 그때문에 예외를 catch하는 것은 쿼리의 결과를 추출할 때가 된다.
//
// AggregateException에는 InnerExceptions프로퍼티(읽기전용컬렉션)가 정의되어 있다.
// 실제의 예외를 알기위해서는 이 프로퍼티를 참조해야한다.

var list = new[] {
    null,
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

try
{
    foreach (var item in query)
        Console.WriteLine($"{item.Name}: {item.SuccessRate:0.0}%");
}
catch (AggregateException e)
{
    foreach (var ex in e.InnerExceptions)
        Console.WriteLine(ex.Message);
}

// 마치다: 64.7 %
// 후미아키: 81.8 %
// 다카야마: 57.1 %
// Object reference not set to an instance of an object.
