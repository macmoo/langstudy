using System;
using System.Collections.Generic;

// IComparer
// IComparer를 구현하면 통상의 정렬과는 다른 정렬이 가능.


var list = new List<DateTime> {
    new DateTime(2020, 5, 1, 12, 30, 4),
    new DateTime(2020, 5, 2, 5, 10, 12),
    new DateTime(2020, 5, 3, 19, 3, 20),
    new DateTime(2020, 5, 4, 1, 45, 59),
};
list.Sort(new HourComparer());
foreach (var date in list)
{
    Console.WriteLine(date);
}

// IComparer<T>インターフェイスを実装
public class HourComparer : IComparer<DateTime> // *
{
    // 時(Hour)だけを比較する
    public int Compare(DateTime x, DateTime y)
    {
        return x.Hour.CompareTo(y.Hour);
    }
}

// 2020-05-04 오전 1:45:59
// 2020-05-02 오전 5:10:12
// 2020-05-01 오후 12:30:04
// 2020-05-03 오후 7:03:20