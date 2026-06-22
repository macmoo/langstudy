using System;

// ------------------------------------------
//
// 람다식을 받는 메소드를 정의할 때, 인수의 형으로 델리게이트를 지정한다. 
//
// Action델리게이트
// Func델리게이트
// Predicate<T>델리게이트
// 가 자주 이용됨.
//

// Action델리게이트
// Action델리게이트는 반환값을 갖지 않는 메소드를 가리키는 델리게이트.
// 인수를 0~9개 갖는 메소드 전부 10개의 메소드가 정의되어 있다.
Repeat(3, n => Console.WriteLine($"{n + 1}회"));

static void Repeat(int n, Action<int> action)
{
    for (var i = 0; i < n; i++)
    {
        action(i);
    }
}
Console.WriteLine("-----------------------------");
// Func델리게이트
// Func델리게이트는 반환값을 갖는 메소드를 가리키는 델리케이트.
// 인수를 0~16개 갖는 메소드 전부 17개의 메소드가 정의되어 있다.
var seq = Generate(5, n => Math.Pow(2, n));
foreach(var x in seq)
{
    Console.WriteLine(x);
}
static IEnumerable<T> Generate<T>(int n, Func<int, T>generator)
{
    for(int i = 0; i < n; i++)
    {
        yield return generator(i);
    }
}
Console.WriteLine("-----------------------------");
// Predicate<T>델리게이트
// Predicate<T>델리게이트는 어떤 오브젝트를 받아, bool형을 반환하는 메소드를 가르킴.
var list = new TodoList();
list.Add("기술평론사와 회의일정조정", DateTime.Today.AddDays(3));
list.Add("JSON읽을때 버그 수정", DateTime.Today.AddDays(1));
list.PrintIf(x => x.Finished == false);

public class Todo
{
    public string Title { get; set; }
    public bool Finished { get; set; } = false;
    public DateTime DeadLine { get; set;}
}

public class TodoList
{
    private List<Todo> _list = new List<Todo>();
    public void Add(string title, DateTime deadline)
    {
        _list.Add(new Todo
        {
            Title = title,
            DeadLine = deadline
        });
    }
    public void PrintIf(Predicate<Todo> predicate)
    {
        foreach(var item in _list)
        {
            if (predicate(item))
            {
                Console.WriteLine($"{item.Title} {item.DeadLine} {item.Finished}");
            }
        }
    }
}
// -----------------------------
// 1회
// 2회
// 3회
// -----------------------------
// 1
// 2
// 4
// 8
// 16
// -----------------------------
// 기술평론사와 회의일정조정 2026-06-24 오전 12:00:00 False
// JSON읽을때 버그 수정 2026-06-22 오전 12:00:00 False