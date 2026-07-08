
using System;
using System.Threading;
using System.Threading.Tasks;

// IProgress<T> 를 인터페이스로 하지 않으면 사용할수 없다.
// T는 통지를 받을때 받아들일수 있는 오브젝트의 형.
IProgress<int> p = new Progress<int>(progress =>
{
    // 통지를 받아 진척상황을 표시.
    Console.WriteLine("Step: {0}", progress);
});
var worker = new MyWorker(p);
await worker.ExecuteAsync(10);

// MyWorker는 진척상황을 통지한다.
class MyWorker
{
    private IProgress<int> _progress; // 인터페이스
    public MyWorker(IProgress<int> progress)
    {
        _progress = progress;
    }

    public async Task ExecuteAsync(int count)
    {
        await Task.Run(async () =>
        {
            for (int i = 0; i < count; i++)
            {
                await Task.Delay(100);
                // 진척상황을 통지
                _progress.Report(i);
            }
        });
    }
}

// Step: 0
// Step: 1
// Step: 2
// Step: 3
// Step: 4
// Step: 5
// Step: 6
// Step: 7
// Step: 8
// Step: 9