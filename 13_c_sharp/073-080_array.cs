using System;
using System.Diagnostics;

// ------------------------------------------
// 배열 선언
// var 변수명 = new 형명[요소수];
var fruits_1 = new string[5];
fruits_1[0] = "apple";

var fruits_2 = new string[] { "apple", "orange", "banana", "cherry", "blueberry" };
var fruits_3 = new[] { "apple", "orange", "banana", "cherry", "blueberry" };
// ------------------------------------------
// foreach (var 요소 in 컬렉션) { }
// ------------------------------------------
// public static void Fill<T>(T[] array, T value);
var array_1 = new int[10];
Array.Fill(array_1, -1);
foreach (var n in array_1)
{
    Console.Write($"{n} ");
}
Console.WriteLine();
// ------------------------------------------
// public static void Reverse(Array array);
var nums = new int[] { 1, 2, 3, 4, 5, 6 };
Array.Reverse(nums);
foreach (var num in nums)
{
    Console.Write($"{num} ");
}
Console.WriteLine();
// ------------------------------------------
// public static void Sort(Array array);
// 요소의 형이 IComparable<T>인터페이스를 구현할 필요가 있음.
var fruits_4 = new string[] { "apple", "orange", "banana", "cherry", "blueberry" };
Array.Sort(fruits_4);
foreach (var f in fruits_4)
{
    Console.Write($"{f} ");
}
Console.WriteLine();
// ------------------------------------------
// public static void Sort<T>(T[] array, Comparison<T> comparison);
// "Comparison<T>"델리게이트를 인수로 갖는 Array.Sort메소드를 사용하면,
// 표준과 다른 순서로 배열을 소팅하는 것이 가능.
var fruits_5 = new string[] { "apple", "orange", "banana", "cherry", "blueberry" };
// 문자열 길이가 짧은 순으로 정렬
// 방법1
Array.Sort(fruits_5, (a, b) => a.Length.CompareTo(b.Length));
// 방법2
Comparison<string> comparison = (x, y) => x.Length.CompareTo(y.Length);
Array.Sort(fruits_5, comparison);

foreach (string elm in fruits_5)
{
    Console.Write($"{elm} ");
}
Console.WriteLine();

// ------------------------------------------
// 이차원 배열
var array2d_1 = new int[,]
{
    { 10, 11, 12, 13 },
    { 20, 21, 22, 23 },
    { 30, 31, 32, 33 },
};
array2d_1[0, 0] = 0;
array2d_1[2, 1] = 1;
for (var i = 0; i < array2d_1.GetLength(0); i++)
{
    for (var j = 0; j < array2d_1.GetLength(1); j++)
    {
        var num = array2d_1[i, j];
        Console.Write($"{num} ");
    }
    Console.WriteLine();
}
Console.WriteLine();
// ------------------------------------------
// var 변수명 = new 형명[요소수][];
// jagged array
// 각 요소로 배열을 갖고 있는 배열.
// 배열의 초기화가 필요.
var jaggedArray = new int[3][];
jaggedArray[0] = new int[3] { 1, 2, 3 };
jaggedArray[1] = new int[4] { 4, 5, 6, 7 };
jaggedArray[2] = new int[2] { 8, 9 };

var jaggedArray_2 = new int[][]
{
    new []{ 1, 2, 3    },
    new []{ 4, 5, 6, 7 },
    new []{ 8, 9       },
};
// ------------------------------------------
