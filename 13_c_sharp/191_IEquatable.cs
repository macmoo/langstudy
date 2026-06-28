using System;
using System.Collections.Generic;

// IEquatable<T>
// IEquatable<T>인터페이스는 오브젝트의 등가비교기능을 
// 클래스에 추가하기 위한 인터페이스
//
// 이하를 오버라이드 해야함.
//
// IEquatable<T>.Equals()
// Object.Equals()
// Object.GetHashCode()
//
var set = new HashSet<Square>();
Console.WriteLine("-1--------------------");
set.Add(new Square { Height = 10, Width = 20 });
// 次のAddは同一要素があるので追加されない。
Console.WriteLine("-2--------------------");
set.Add(new Square { Height = 10, Width = 20 });
Console.WriteLine("-3--------------------");
set.Add(new Square { Height = 15, Width = 20 });
Console.WriteLine("-4--------------------");
foreach (var item in set)
{
    Console.WriteLine($"{item.Height}, {item.Width}");
}

// IEquatable<T>を実装したクラス
public class Square : IEquatable<Square>
{
    public int Width { get; set; }
    public int Height { get; set; }

    // IEquatable<T>.Equalsを実装 
    public bool Equals(Square other)
    {
        Console.WriteLine("- IEquatable<T>.Equals()");
        if (other == null)
            return false;
        return Height == other.Height && Width == other.Width;
    }

    // Object.Equalsをオーバーライド
    public override bool Equals(object obj)
    {
        Console.WriteLine("- Object.Equals()");
        if (obj is Square square)
            return Equals(square);
        return false;
    }

    // Object.GetHashCodeをオーバーライド
    public override int GetHashCode()
    {
        Console.WriteLine("- Object.GetHashCode()");
        int hCode = Height ^ Width;
        return hCode.GetHashCode();
    }
}
// -1--------------------
// - Object.GetHashCode()
// - 2--------------------
// - Object.GetHashCode()
// - IEquatable<T>.Equals()
// - 3--------------------
// - Object.GetHashCode()
// - 4--------------------
// 10, 20
// 15, 20