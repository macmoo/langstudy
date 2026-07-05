
// 복수의 Task를 병렬 실행하기
//
// Task는 비동기처리만을 위한 클래스가 아니다.
// 복수의 task를 병렬로 동작시키는 것도 가능하다.
// await키워드를 붙이면, Task.Run()메소드를 복수호출해 병렬로 task를 동작시킨다.
// 기동한 복수의 task의 종료를 기다리고 싶은 경우에는 Task.WhenAll()를 이용.
// WhenAll()는 배열내의 모든 Task오브젝트가 완료되었을 경우에 task를 작성한다.
//
// public static Task WhenAll(IEnumerablt<Task> tasks);
//

using System;
using System.Threading.Tasks;

// task를 두개 기동.
var tasks = new Task[2];

tasks[0] = Task.Run(async () =>
{
    await Task.Delay(3000);
    Console.WriteLine("Task 1");
});

tasks[1] = Task.Run(async () =>
{
    await Task.Delay(2000);
    Console.WriteLine("Tstk 2");
});

//두개의 Task가 완료될때까지 대기.
await Task.WhenAll(tasks);
Console.WriteLine("End");

// Tstk 2
// Task 1
// End
