
// 기동한 task를 취소함.
// 
// public void Cancel(bool throwOnFirstException);
// public void ThrowIfCnacellationRequested();
// 
// task를 취소하기 위해서는 호출한 쪽과 호출되는 쪽, 양쪽의 대응이 필요.
// - 호출하는 쪽에서는 CancellationTokenSource.Cancel()로 취소할 것임을 task에 전달.
// - 호출되는 쪽에서는 CancellationToken.IsCancellationRequested프로퍼티를 참조해서,
//   취소요구가 있었는지 조사함.
//   true이면 CancellationToken.ThrowIfCancellationRequested()가 호출됨.
//   ThrowIfCancellationRequested()가 호출되면, OperationCanceledException예외가 발생한다.
// - 호출하는 쪽에서 예외를 위의 예외를 캐치해서, 취소되었는지 확인.
//


using (var tokenSource = new CancellationTokenSource())
{
    var task = DoWork(tokenSource.Token);
    while (!task.IsCompleted)
    {
        if (Console.KeyAvailable)
        {
            tokenSource.Cancel(true);
            break;
        }
        Thread.Sleep(100);
    }
    try
    {
        await task;
    }
    catch (OperationCanceledException e)
    {
        Console.WriteLine("취소됨");
    }

}

// task를 기동.
static Task DoWork(CancellationToken cancelToken)
{
    return Task.Run(() =>
    {
        // 100회 반복 아니면 취소될때까지 루프
        for (int i = 0; i < 30; i++)
        {
            if (cancelToken.IsCancellationRequested)
                cancelToken.ThrowIfCancellationRequested();
            Console.Write(".");
            System.Threading.Thread.Sleep(200);

        }
    }, cancelToken);
}
// ......취소됨