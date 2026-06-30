```cs
- yield
  C#에서 yield 키워드는 컬렉션의 데이터를 한 번에 모두 메모리에 올리지 않고, 필요할 때마다 하나씩(요청 시점) 반환(Lazy Evaluation) 하는 데 사용.
  yield에는 주로 사용되는 yield return과 흐름을 끊는 yield break 두 가지가 있습니다.
  1. yield return (값 반환)메서드의 실행을 일시 중단하고 호출자에게 값을 반환합니다.
     이후 다시 호출되면, 이전에 멈췄던 지점부터 실행을 재개하여 다음 값을 생성.
  2. yield break (반복 종료)반복(iteration) 작업을 조건에 따라 강제로 종료할 때 사용.

  - 대용량 데이터 처리: 수백만 개의 데이터 중 앞의 5개만 필요하거나 조건에 맞는 일부만 필요할 때,
    전체 데이터를 메모리에 올리지 않고 즉시 결과를 추출할 수 있어 메모리 절약에 큰 도움이 됩니다.
  - 무한 루프/스트림 데이터: 끝이 없는 데이터 스트림을 순회해야 할 때 유용합니다.
  - 가독성 및 구현 편의성: yield를 사용하면 복잡한 상태 유지 클래스(Enumerator 인터페이스)를
    직접 구현하지 않아도 컴파일러가 알아서 상태 유지 코드를 생성해 줍니다.
```

---

```cs
class Program
{
    static void Main()
    {
        // GetNumbers()는 한 번에 3개의 값을 다 만들지 않고,
        // foreach가 돌 때마다 하나씩 yield로 받아옵니다.
        foreach (int number in GetNumbers())
        {
            Console.WriteLine(number);
        }
    }
    public static IEnumerable<int> GetNumbers()
    {
        Console.WriteLine("첫 번째 값 생성...");
        yield return 10; // 10 반환 후 일시 정지

        Console.WriteLine("두 번째 값 생성...");
        yield return 20; // 20 반환 후 일시 정지

        Console.WriteLine("세 번째 값 생성...");
        yield return 30; // 30 반환 후 일시 정지
    }
}

// 첫 번째 값 생성...
// 10
// 두 번째 값 생성...
// 20
// 세 번째 값 생성...
// 30
```

---

```cs
public static IEnumerable<int> GetNumbersUntil(int max)
{
    for (int i = 0; i < 10; i++)
    {
        if (i > max)
        {
            yield break; // max 값을 넘어가면 반복기(Iterator) 종료
        }
        yield return i;
    }
}
```

---

// 자주 이용되는 이미 정의된 델리게이트
| 이름 | 반환값 | 의미|
| --- | --- | --- |
| Action | void | 인수없이 어떤 동작을함.|
| Action<T> | void | 1개의 인수로 어떤 동작을함.|
| Action<T1, T2> | void | 2개의 인수로 어떤 동작을함.|
| Action<T1, T2, T3> | void | 3개의 인수로 어떤 동작을함.|
| Action<T1, T2, T3, T4> | void | 4개의 인수로 어떤 동작을함.|
| Func< TResult> | TResult | 인수없이 TResult을 반환함.|
| Func<T, TResult> | TResult | 1개의 인수로 TResult을 반환함.|
| Func<T1, T2, TResult> | TResult | 2개의 인수로 TResult을 반환함.|
| Func<T1, T2, T3, TResult> | TResult | 3개의 인수로 TResult을 반환함.|
| Predicate<TResult> | bool | T형의 인수로 bool을 반환함.|

---

```cs
- Top Level Statement
  정형구의 대부분을 생략하고 using문, 처리문만을 사용할 수 있다.
- using static 완전수식형명;
  그 형의 정적멤버에 형명르 지정하지 않고 액세스가 가능하다.
  using static System.Console;
- nameof(식별명)
  변수, 형, 멤버의 이름이 문자열로 생성됨.`
  Console.WriteLine(nameof(System.DateTime)); // DateTime
- default
  오브젝트의 디폴트 값을 지정.
  형명 변수 = default;
  DateTime dt = default;
```

---

```cs
- new식
  인스턴스생성시의 형을 생략가능.
  작성할 오브젝트의 형을 이미 알고 있을 때만 사용가능.
  1. private List<Todo> _list = new ();
  2.
    public MyRetryOption Create()
    {
        // MyRetryOptionインスタンスが生成されるれる
        return new()
        {
            Count = 3,
            Interval = 100,
        };
    }
```

---

```cs
- out변수
  파라메터를 메소드에 넘길때, 변수의 선언과 동시에 할 수 있다.
// TryParse()를 호출하기 전에 변수를 선언할 필요가 없다.
if (Double.TryParse("3.14", out var value))
{
    Console.WriteLine(value);
}
```

---

```cs
- 이름있는 인수
  정의된 순서에 상관없이 인수를 넘길수 있다.

// 名前付き引数を利用しメソッドを呼び出す例
ExampleMethod(5, optionalInt: 20);
ExampleMethod(optionalStr: "hello", required: 10);

// メソッドの定義例
static void ExampleMethod(
        int     required,
        string  optionalStr = "default string",
        int     optionalInt = 10)
{
    Console.Write($"required={required}, ");
    Console.Write($"optionalStr={optionalStr}, ");
    Console.WriteLine($"optionalInt={optionalInt}");
}
// required=5, optionalStr=default string, optionalInt=20
// required=10, optionalStr=hello, optionalInt=10
```

---

```cs
- switch식
  switch식 그 자체가 값을 갖게 된다.
식 switch
{
    값1 => 식1,
    값2 => 식2,
    ...
    _   => 식x,
}

```

---

```cs

```

---

```cs

```

---

```cs

```

---

```cs

```

---

```cs

```

---

```cs

```

---

```cs

```
