
using System;
using System.Collections.Concurrent;
using System.Threading.Tasks;


// System.Collections.Concurrent 이름공간에는 스레드세이프(복수의 스레드가 병렬처리해도 문제가 발생안함)한
// 컬렉션이 준비되어 있다.
// lock구문으로 배타처리할 필요도 없고, 성능도 좋다.
//
// TryAdd(), TryUpdate(), TryRemove(), AddOrUpdate() 등 아토믹한 메소드가 있다.
//
//
ConcurrentDictionary<string, Lake> Cities = new();

var lakes = new Lake[]
{
    new Lake { Name = "사로마호", Place = "북해도", Area = 151.59 },
    new Lake { Name = "이나와시로호", Place = "후쿠시마", Area = 103.24 },
    new Lake { Name = "가스미가우라호,", Place = "이바라키", Area = 168.10 },
    new Lake { Name = "하마나호", Place = "시즈오카", Area = 64.91 },
    new Lake { Name = "비와호", Place = "사가", Area = 669.26 },
    new Lake { Name = "신지호", Place = "시마네", Area = 79.24 },
    new Lake { Name = "이케다호", Place = "카고시마", Area = 10.91 },
};

await Task.WhenAll(
    Task.Run(() => TryAddLakes(lakes, 1)),
    Task.Run(() => TryAddLakes(lakes, 2))
);

void TryAddLakes(Lake[] lakes, int id)
{
    foreach (var lake in lakes)
    {
        // 2개의 task에서 ConcurrentDictionary객체에 같은 값을 넣으려고 한다.
        if (Cities.TryAdd(lake.Name, lake))
        {
            Console.WriteLine($"TaskId={id}, 성공 {lake.Name}.");
        }
        else
        {
            Console.WriteLine($"TaskId={id}, 실패 {lake.Name}, 이미 추가함.");
        }
    }
}

class Lake
{
    public string Name { get; init; }
    public string Place { get; init; }
    public double Area { get; init; }
}

// TaskId=1, 실패 사로마호, 이미 추가함.
// TaskId=2, 성공 사로마호.
// TaskId=2, 실패 이나와시로호, 이미 추가함.
// TaskId=1, 성공 이나와시로호.
// TaskId=2, 성공 가스미가우라호,.
// TaskId=2, 성공 하마나호.
// TaskId=1, 실패 가스미가우라호,, 이미 추가함.
// TaskId=1, 실패 하마나호, 이미 추가함.
// TaskId=1, 실패 비와호, 이미 추가함.
// TaskId=2, 성공 비와호.
// TaskId=2, 실패 신지호, 이미 추가함.
// TaskId=2, 성공 이케다호.
// TaskId=1, 성공 신지호.
// TaskId=1, 실패 이케다호, 이미 추가함.
