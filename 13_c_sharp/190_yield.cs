using System;

// ------------------------------------------
// yield키워드를 쓰면 IEnumerable<T>의 반환값으로 갖는 메소드를 간단하게 정의할수 있다.
// 
// yield는 C#에서 데이터를 한 번에 모두 반환하지 않고,
// 하나씩 순차적으로 생성해서 반환하는 기능입니다.
// 쉽게 말하면, "필요할 때마다 하나씩 만들어서 돌려주는 기능(Lazy Evaluation)"
//
// 언제 사용하는가?
// yield는 다음과 같은 경우에 특히 유용합니다.
// - 큰 데이터 집합을 순회할 때
// - 파일, 데이터베이스 등의 데이터를 순차적으로 처리할 때
// - 무한 시퀀스를 생성할 때
// - 트리나 그래프를 순회할 때
// - LINQ와 함께 지연 실행(Lazy Evaluation)을 구현할 때
//
// yield는 IEnumerable<T>를 쉽게 구현하여 데이터를 한 번에 모두 만들지 않고,
// 필요할 때마다 하나씩 생성해서 반환하는 문법입니다. 이를 통해 메모리를 절약하고,
// 첫 번째 결과를 더 빠르게 사용할 수 있으며,
// 복잡한 반복자(Iterator)를 직접 구현하지 않아도 됩니다.

var fibos = Fibonacci()
            .Select((Value, Index) => new { Index, Value })
            .TakeWhile(x => x.Index <= 10);
foreach (var f in fibos)
{
    Console.WriteLine($"f({f.Index}) = {f.Value}");
}

static IEnumerable<long> Fibonacci()
{
    yield return 0;
    yield return 1;

    long[] array = new long[] { 0, 1 };
    while (true)
    {
        var fibo = array[0] + array[1];
        if (fibo < array[1])
            yield break;
        array[0] = array[1];
        array[1] = fibo;
        yield return fibo;
    }
}

// f(0) = 0
// f(1) = 1
// f(2) = 1
// f(3) = 2
// f(4) = 3
// f(5) = 5
// f(6) = 8
// f(7) = 13
// f(8) = 21
// f(9) = 34
// f(10) = 55
