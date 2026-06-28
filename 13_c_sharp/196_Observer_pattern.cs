using System;
using System.Collections.Generic;

// IObservable<T>와 IObserver<T>를 구현한 클래스를 정의하면,
// 통일된 오브젝트간 통지메커니즘을 구현할 수 있다.
//
// IObservable<T>를 구현한 클래스 -> 통지용 프로바이더
// IObserver<T>를 구현한 클래스   -> 수신용 옵저버
//
// 통지용 프로바이더내에서 일어반 변화를 수신용 옵저버(복수가능)에 통지 할 수 있다.

// 利用例
var pg = new PrimeGenerator();
var pp = new PrimePrinter();
pg.Subscribe(pp);
pg.Generate(10);

// ------------------------------------------
// 通知を受け取る側のクラス
// PrimeGeneratorクラスのことは知らない
class PrimePrinter : IObserver<int> // *
{
    public void OnCompleted() => Console.WriteLine("終了");

    public void OnError(Exception error) => Console.WriteLine(error.ToString());

    public void OnNext(int value) => Console.WriteLine(value);
}

// ------------------------------------------
// 通知する側のクラス
// PrimePrinterクラスのことは知らない
class PrimeGenerator : IObservable<int> // *
{
    public void Generate(int maxCount)
    {
        var count = 0;
        for (int i = 2; i < int.MaxValue; i++)
        {
            if (IsPrime(i))
            {
                Publish(i);
                if (++count >= maxCount)
                    break;
            }
        }
        Complete();
    }

    private List<IObserver<int>> _observers = new List<IObserver<int>>();

    // 終了を通知する
    private void Complete() => _observers.ForEach(o => o.OnCompleted());

    // 状況変化を知らせるために購読者(受信者)に通知する
    private void Publish(int prime) => _observers.ForEach(o => o.OnNext(prime));

    // 購読(受信)する
    public IDisposable Subscribe(IObserver<int> observer)
    {
        _observers.Add(observer);
        return observer as IDisposable;
    }

    // 素数かどうかを判断する
    private static bool IsPrime(int num)
    {
        if (num == 1 || num == 2)
            return true;
        var boundary = Math.Floor(Math.Sqrt(num));
        for (var i = 2; i <= boundary; ++i)
        {
            if (num % i == 0)
                return false;
        }
        return true;
    }
}

// 2
// 3
// 5
// 7
// 11
// 13
// 17
// 19
// 23
// 29
// 終了