// 안전한 병렬처리
// 
// Thread/Task/PLINQ등으로 병렬처리시에 각 task가 같은 리소스에 액세스하려는 경우가 있는데,
// 이 경우에 lock()으로 배타록을 걸어야한다.
//
// lock (록오브젝트){ }


using System;
using System.Linq;

var list = new[]
{
    new Player { Name = "다케다", Attempts = 20, Success = 10 },
    new Player { Name = "마치다", Attempts = 17, Success = 11 },
    new Player { Name = "후미아키", Attempts = 22, Success = 18 },
    new Player { Name = "다카야마", Attempts = 21, Success = 12 },
};

var task = new MyTask();
list.AsParallel()
    .ForAll(o => task.Execute(o));

foreach (var p in list)
{
    Console.WriteLine($"{p.SuccessRate:#.00}");
}
Console.WriteLine($"Max = {task.MaxRate:#.00}");

class Player
{
    public string Name { get; set; }
    public int Attempts { get; set; }
    public int Success { get; set; }
    public double SuccessRate { get; set; }
}

class MyTask
{
    private static object _lockobj = new Object();
    public double MaxRate { get; set; } = -1;

    // Execute는 동시에 병렬로 실행되기 때문에,
    // MaxRate를 갱신할 때에는, lock구문으로 배타처리를 한다.
    public void Execute(Player player)
    {
        player.SuccessRate = (player.Success * 100.0) / player.Attempts;

        lock (_lockobj)
        {
            if (MaxRate < player.SuccessRate)
                MaxRate = player.SuccessRate;
        }
    }
}

// 50.00
// 64.71
// 81.82
// 57.14
// Max = 81.82