using System;
using System.Collections.Generic;

// IEqualityComparer
// 대상이 되는 클래스가 아니라, 클래스의 외부에서 오브젝트의
// 등가비교를 정의해, Dictionary<TKey, TValue>, HashSet<T>를 쓸수 있게한다.

// 利用例
var set = new HashSet<Square>(new SquareEqualityComparer()); // *
set.Add(new Square { Height = 10, Width = 20 });
// 次のAddは、同一要素があるので追加されない
set.Add(new Square { Height = 10, Width = 20 });
set.Add(new Square { Height = 15, Width = 20 });
foreach (var item in set)
{
    Console.WriteLine($"{item.Height}, {item.Width}");
}

// Squareそのものは値の等価比較機能を持たない
public class Square
{
    public int Width { get; set; }
    public int Height { get; set; }
}

// IEqualityComparer<T>を実装し、Squareの等値比較を可能にする
public class SquareEqualityComparer : IEqualityComparer<Square> // *
{
    public bool Equals(Square s1, Square s2)
    {
        if (s1 == null && s2 == null)
            return true;
        if (s1 == null || s2 == null)
            return false;
        return s1.Height == s2.Height && s1.Width == s2.Width;
    }

    public int GetHashCode(Square bx)
    {
        int hCode = bx.Height ^ bx.Width;
        return hCode.GetHashCode();
    }
}

// 10, 20
// 15, 20