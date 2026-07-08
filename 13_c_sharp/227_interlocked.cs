
// Interlocked클래스에는 가산,감산,비트연산(and, or), 치환등이
// 아토믹한 메소드로 제공된다.
// 아토믹이라함은 다른 task로부터 끼어들기가 불가능하다.
// 그때문에 lock구문보다 낮은 코스트로 병렬처리를 할 수 있다.
// Interlocked클래스가 만능은 아니지만, 하나의 필드 갱신같은 경우에는 이용가치가 높다.
// 
// 
// 

using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

var workers = new[] { new Worker(), new Worker(), new Worker() };
// 3개의 task를 병렬처리
var tasks = workers.Select(x => Task.Run(() => x.DoWork()))
                   .ToArray();

Task.WaitAll(tasks);
Console.WriteLine(Worker.Result);

public class Worker
{
    private const int _maxloop = 100;
    public static int Result = 0;

    public void DoWork()
    {
        for (int i = 0; i < _maxloop; i++)
        {
            UseResource();
            Thread.Sleep(5);
        }
    }

    // 여기서 복수의 task가 하나의 필드에 액세스.
    private void UseResource()
    {
        // Result += 10를 배타적으로 실행.
        Interlocked.Add(ref Result, 10);
    }
}

// 3000