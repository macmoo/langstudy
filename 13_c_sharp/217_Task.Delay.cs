

// 지정시간 처리를 대기시킴.
// 
// Threading.Thread.Sleep()와는 달리 해당 스레드를 블록하지는 않는다.
// 
// public static Task Delay(int millisecondsDelay);


// 1초간 대기시킴.
// await키워드를 쓰기때문에, async키워드로 수식된 메소드가 이용가능.

Console.WriteLine(DateTime.Now);
await Task.Delay(1000);
Console.WriteLine(DateTime.Now);

// 以下　補足で示したコード
await Task.Delay(TimeSpan.FromSeconds(1));
Console.WriteLine(DateTime.Now);
