using System;

// ------------------------------------------
// 제너릭 메소드
//

// 형파라메터 지정
PrintMax<int>(new[] { 1, 4, 8, 3, 10, 2, 7 });
PrintMax<DateTime>(new[] { new DateTime(2021, 3, 5), new DateTime(2021, 11, 22) });

// 형파라메터 미지정
PrintMax(new[] { 1, 4, 8, 3, 10, 2, 7 });
PrintMax(new[] { new DateTime(2021, 3, 5), new DateTime(2021, 11, 22) });

// where T : IComparable<T>
// -> 형파라메터로 IComparable<T>을 구현한 형으로 한정.
static void PrintMax<T>(IEnumerable<T> seq) where T : IComparable<T>
{
    T max = seq.First();
    foreach (var item in seq.Skip(1))
    {
        if (item.CompareTo(max) > 0)
        {
            max = item;
        }
    }
    Console.WriteLine(max);
}

// 10
// 2021 - 11 - 22 오전 12:00:00
// 10
// 2021 - 11 - 22 오전 12:00:00