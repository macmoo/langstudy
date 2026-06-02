using System;
using System.Collections;
using System.ComponentModel.DataAnnotations;
using System.Runtime.ExceptionServices;

// ------------------------------------------
var fruits = new List<string>();
fruits.Add("apple");
fruits.Add("banana");
fruits.Add("blueberry");
fruits.Add("lemon");

Console.WriteLine(fruits);
Console.WriteLine(fruits.Count);
Console.WriteLine();
// ------------------------------------------
fruits.Insert(3, "cherry");
fruits.Add("orange");
fruits.Remove("banana");

var item = fruits[1];
Console.WriteLine(item);
// ------------------------------------------
var fruits_2 = new List<string>
{
    "apple", "banana", "blueberry", "cherry", "grape"
};
var nums = new List<int> { 1, 2, 3, 4, 5 };
Console.WriteLine(string.Join(", ", fruits_2));
Console.WriteLine(string.Join(", ", nums));
// ------------------------------------------
// public void AddRange(IEnumerable<Task> collection);
fruits_2.AddRange(new[] { "kiwi", "orange", "peach" });
Console.WriteLine(string.Join(", ", fruits_2));
Console.WriteLine();
// ------------------------------------------
// public int RemoveAll(Predicate<T> match);
var fruits_3 = new List<string>
{
    "apple", "apricot", "banana", "blueberry", "cherry", "grape",
    "kiwi", "lemon", "mango", "melon", "peach", "pear", "strawberry"
};
Console.WriteLine(string.Join(", ", fruits_3));
// 문자길이가 5이하의 요소 삭제
var count = fruits_3.RemoveAll(x => x.Length <= 5);
Console.WriteLine(String.Join(", ", fruits_3));
Console.WriteLine($"삭제한 요소수:{count}");
Console.WriteLine();
// ------------------------------------------
// 리스트 요소 역전(리스트 자체를 역전)
var nums2 = new List<int> { 1, 3, 5, 7, 6, 4, 2, 0 };
Console.WriteLine(string.Join(", ", nums2));
nums2.Reverse();
Console.WriteLine(string.Join(", ", nums2));
Console.WriteLine();
// ------------------------------------------
// public void Sort()
// 대상요소의 형이 IComparable<T>인터페이스의 구현할 필요가 있다.
var fruits_4 = new List<string> { "apple", "orange", "banana", "grape", "blueberry", "cherry" };
Console.WriteLine(string.Join(", ", fruits_4));
fruits_4.Sort();
Console.WriteLine(string.Join(", ", fruits_4));
Console.WriteLine();
// ------------------------------------------
// public void Sort(Comparison<T> comparison);
// Comparison<T>델리게이트는 같은 형의 2개의 오브젝트를 비교하는 함수를 나타냄
var fruits_5 = new List<string> { "apple", "banana", "blueberry", "cherry", "grape" };
Console.WriteLine(string.Join(", ", fruits_5));
// 0 보다 작음 : x 는 y 보다 작음
// 0 과   같음 : x 는 y 과 같음
// 0 보다 큼   : x 가 y 보다 큼

fruits_5.Sort((a, b) => a.Length.CompareTo(b.Length));
Console.WriteLine(string.Join(", ", fruits_5));
Console.WriteLine();
// ------------------------------------------
// 리스트내 고속검색
// 리스트와 오름차순으로 정렬할 필요가 있다.
// public int BinarySearch(T item);
var fruits_6 = new List<string>
{
    "apple", "apricot", "banana", "blueberry", "cherry", "grape",
    "kiwi", "lemon", "mango", "melon", "peach", "pear", "strawberry"
};
fruits_6.Sort();
var index = fruits_6.BinarySearch("lemon");
Console.WriteLine(index < 0 ? "not found" : fruits_6[index]);
Console.WriteLine();
// ------------------------------------------
// public void ForEach(Action<T> action);
// 리스트내의 각 요소에 대해 지정한 처리를 순서대로 실행하는 것이 가능하다.
var fruits_7 = new List<string> { "apple", "orange", "banana", "grape", "blueberry", "cherry" };
fruits_7.ForEach(x => Console.WriteLine(x.ToUpper()));
Console.WriteLine();
// 배열에 대해서도 가능.
var fruits_8 = new[] { "apple", "orange", "banana", "grape", "blueberry", "cherry" };
Array.ForEach(fruits_8, x => Console.WriteLine(x.ToUpper()));
Console.WriteLine();
// ------------------------------------------
// 읽기전용 리스트
var fruits_9 = new List<string> { "apple", "orange", "banana", "blueberry", "cherry" };
var readOnlyList = fruits_9.AsReadOnly();
fruits_9.Add("grape"); // ok
// readOnlyList.Add("grape"); // error
Console.WriteLine();
// ------------------------------------------
// Dictionary<TKey, TValue>
var flowerDict = new Dictionary<string, int>()
{
    ["sunflower"] = 400,
    ["pansy"] = 300,
    ["tulip"] = 350,
    ["rose"] = 500,
    ["dahlia"] = 450,
};
flowerDict["violet"] = 600;
flowerDict.TryAdd("violet", 700);

var key = "pansy";
if (flowerDict.ContainsKey(key))
{
    var pansy_price = flowerDict[key];
    Console.WriteLine($"pansy price\t= {pansy_price}");
    Console.WriteLine();
}
foreach (var dict in flowerDict)
{
    Console.WriteLine($"{dict.Key}\t= {dict.Value}");
}

Console.WriteLine();
foreach (var k in flowerDict.Keys)
{
    Console.WriteLine($"{k}\t= {flowerDict[k]}");
}
Console.WriteLine();
// ------------------------------------------
// HashSet
// 중복을 허용하지 않는 값들의 집합.
// List<T>보다 빠름.
var hashSet = new HashSet<string>();
hashSet.Add("apple");
hashSet.Add("banana");
hashSet.Add("grape");
hashSet.Add("lemon");
hashSet.Add("lemon"); // 추가에는 실패. 예외 발생안함.
Console.WriteLine(hashSet.Count);
hashSet.Remove("grape");

var contains = hashSet.Contains("grape");
Console.WriteLine(contains);

foreach (var hs in hashSet)
{
    Console.Write($"{hs}, ");
}
Console.WriteLine();
Console.WriteLine();
// ------------------------------------------
// HastSet<T>으로 집합연산
// public void UnionWith(IEnumerable<T> other); // 합집합
// public void ExceptionWith(IEnumerable<T> other); // 차집합
// public void IntersectWith(IEnumerable<T> other); // 겨집합

var mul2 = new HashSet<int> { 2, 4, 6, 8, 10, 12 };
var mul3 = new HashSet<int> { 3, 6, 9, 12, 15, 18 };

Console.WriteLine(string.Join(", ", mul2));
Console.WriteLine(string.Join(", ", mul3));
Console.WriteLine();

// 합집합
var set = new HashSet<int>(mul2);
set.UnionWith(mul3);
Console.WriteLine(string.Join(", ", set));
Console.WriteLine();

// 차집합
var set2 = new HashSet<int>(mul2);
set2.ExceptWith(mul3);
Console.WriteLine(string.Join(", ", set2));
Console.WriteLine();

// 교집합
var set3 = new HashSet<int>(mul2);
set3.IntersectWith(mul3);
Console.WriteLine(string.Join(", ", set3));
Console.WriteLine();
Console.WriteLine();
// ------------------------------------------
// Stack<T>
var stack = new Stack<int>();
stack.Push(10);
stack.Push(20);
stack.Push(30);

// stack의 선두요소를 참조.
// stack의 내용은 변경되지 않음.
var peekValue = stack.Peek();
Console.WriteLine(peekValue);
Console.WriteLine(stack.Count);
Console.WriteLine();

while (stack.Count > 0)
{
    // stack의 선두에서 부터 요소 삭제 
    var n = stack.Pop();Console.WriteLine(n);
}
Console.WriteLine();
// ------------------------------------------
// Queue<T>
// 가변사이즈 컬렉션
var queue = new Queue<int>();
queue.Enqueue(4);
queue.Enqueue(8);
queue.Enqueue(3);
queue.Enqueue(9);

while (queue.Count > 0)
{
    var n = queue.Dequeue();
    Console.WriteLine(n);
}
Console.WriteLine($"Count:{queue.Count}");



Console.WriteLine();
// ------------------------------------------
//System.Collections.Generic.List`1[System.String]
//4

//blueberry
//apple, banana, blueberry, cherry, grape
//1, 2, 3, 4, 5
//apple, banana, blueberry, cherry, grape, kiwi, orange, peach

//apple, apricot, banana, blueberry, cherry, grape, kiwi, lemon, mango, melon, peach, pear, strawberry
//apricot, banana, blueberry, cherry, strawberry
//삭제한 요소수:8

//1, 3, 5, 7, 6, 4, 2, 0
//0, 2, 4, 6, 7, 5, 3, 1

//apple, orange, banana, grape, blueberry, cherry
//apple, banana, blueberry, cherry, grape, orange

//apple, banana, blueberry, cherry, grape
//apple, grape, banana, cherry, blueberry

//lemon

//APPLE
//ORANGE
//BANANA
//GRAPE
//BLUEBERRY
//CHERRY

//APPLE
//ORANGE
//BANANA
//GRAPE
//BLUEBERRY
//CHERRY


//pansy price     = 300

//sunflower       = 400
//pansy   = 300
//tulip   = 350
//rose    = 500
//dahlia  = 450
//violet  = 600

//sunflower       = 400
//pansy   = 300
//tulip   = 350
//rose    = 500
//dahlia  = 450
//violet  = 600

//4
//False
//apple, banana, lemon,

//2, 4, 6, 8, 10, 12
//3, 6, 9, 12, 15, 18

//2, 4, 6, 8, 10, 12, 3, 9, 15, 18

//2, 4, 8, 10

//6, 12


//30
//3

//30
//20
//10

//4
//8
//3
//9
//Count:0
// ------------------------------------------
