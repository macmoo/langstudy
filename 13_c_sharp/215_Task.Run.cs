
//
// Task.Run()
// 동기 메소드를 비동기 메소드로 변경
//
// public static Task<TResult> Run<TResult>(Func<TResult> function);

var sum1 = TriangularNumber(100);
Console.WriteLine(sum1);

var sum2 = await TriangularNumberAsync(100);
Console.WriteLine(sum2);

// 동기메소드
static int TriangularNumber(int n)
{
    var sum = 0;
    for (var i = 1; i <= n; i++)
        sum += i;
    return sum;
}

// 비동기메소드 
static Task<int> TriangularNumberAsync(int n)
{
    // 제너릭메소드의 형추론이 일어나기 때문에,
    // Run()호출시 형파라메터를 지정할 필요가 없다.
    return Task.Run(() =>
    {
        var sum = 0;
        for (var i = 1; i <= n; i++)
            sum += i;
        return sum;
    });
}

// 5050
// 5050
