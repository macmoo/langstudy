

// System.Threading.Tasks이름공간의 Parallel클래스를 이용하면,
// 어떤 컬렉션에 대한 반복처리를 간단히 병렬처리로 하는 것이 가능하다.
//
// public static ParallelLoopResult ForEach<TSoruce>(IEnumerable<TSource> source, Action<TSource> body);
//

var collection = new int[] { 1,2,3,4};
Parallel.ForEach(collection, item => Process(item));

static void Process(int item)
{
    Console.WriteLine($"Begin:{item}");
    System.Threading.Thread.Sleep(10);
    Console.WriteLine($"{item}");
    Console.WriteLine($"End  :{item}");
}


// Begin: 4
// Begin: 1
// Begin: 3
// Begin: 2
// 2
// End: 2
// 4
// End: 4
// 1
// End: 1
// 3
// End: 3
