
// Task클래스를 써서 시작한 task를 지정시간 대기시킴.
// public bool Wait(int miliseconds Timeout)

// 2초 걸리는 task기동.
var task = Task.Run(() =>
{
    System.Threading.Thread.Sleep(2000);
    Console.WriteLine("Task End");
});

// 최대 1초 대기.
task.Wait(1000);

// task는 끝나지 않았기 때문에, completed는 false가 된다.
bool completed = task.IsCompleted;
Console.WriteLine($"IsCompleted : {completed}, Status : {task.Status}");

if (!completed)
    // 타임아웃이 발생하지만 task가 취소되는 것은 아니다.
    Console.WriteLine("Timeout");

Console.ReadLine();


// IsCompleted: False, Status: Running
// Timeout
// Task End

