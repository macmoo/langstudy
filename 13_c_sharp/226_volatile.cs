
// 
// volatile선언
//
// lock문은 병렬처리를 안전하게 실행하는 확실한 방법이지만,
// 코스트가 높은 경우가 있다.
// 특히, lock건 시간이 길어지면, lock걸린 리소스에 액세스하려는 다른 
// 스레드가 대기상태가되어, 하드웨어의 성능을 끌어올리수 없게 된다.
// C#의 volatile을 사용하면 이런 문제의 일부를 해결할 수 있다.
//
// volatile선언된 필드는 최적화를 하지 않음.
// 이로인해, volatile선언된 필드에의 쓰기는 소스코드의 보이는 순서대로 확실이 실행되게 된다.
// 즉, 병렬처리에서도 그대로 배타제어를 의식하지않고 처리하는 것이 가능해진다.
// 
// 다만, 이하의 형들만 volatile선언할 수있다. double, long, decimal등은 volatile지정 불가.
//
// 참조형  :참조형 그 자체. 참조형의 멤버는 대상외.
// 포인터형:포인터형 그 자체. 포인터가 가리키는 오브젝트는 대상외.
// 단순형  :byte,sbyte,short,ushort,int,uint,char,float,bool
// enum형 : 기본형이 byte,sbyte,short,ushort,int,uint경우만 가능.
// 참조형임을 판명된 제너릭형파라메터
// IntPtr 및 UIntPtr
//
using System;
using System.Threading;
using System.Threading.Tasks;

var worker = new Worker();
var task = Task.Run(() => worker.DoWork());
Console.WriteLine("메인 스레드: Task시작");

while (task.Status != TaskStatus.Running)
    ;

Thread.Sleep(500);
worker.RequestStop();

task.Wait();
Console.WriteLine("메인 스레드: Task종료");

public class Worker
{
    private volatile bool _shouldStop;

    public void DoWork()
    {
        bool work = false;
        while (!_shouldStop)
        {
            work = !work;
        }
        Console.WriteLine("DoWork 정상종료합니다.");
    }

    public void RequestStop() => _shouldStop = true;
}

// 메인 스레드: Task시작
// DoWork 정상종료합니다.
// 메인 스레드: Task종료