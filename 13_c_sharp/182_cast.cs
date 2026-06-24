using System;

// 독자형의 형변환
// explicit 와 operator 키워드를 써서 형변환용 메소드를 정의.
// 
// Source -> Target으로 형변환
// public static explicit operator Target(Source obj) { ... }
// 


var time = new Time(13, 14, 5);
// TimeオブジェクトからTimeSpanオブジェクトへ型変換
var timeSpan = (TimeSpan)time;
Console.WriteLine($"{timeSpan.GetType().Name} {timeSpan}");
// TimeSpanオブジェクトからTimeオブジェクトへ型変換
var time2 = (Time)timeSpan;
Console.WriteLine($"{time2.GetType().Name} {time2.Hour}:{time2.Minute}:{time2.Second}");

// キャスト式による型変換を可能にする例
public readonly struct Time
{
    public int Hour { get; }
    public int Minute { get; }
    public int Second { get; }

    public Time(int hour, int minute = 0, int second = 0)
    {
        Hour = hour;
        Minute = minute;
        Second = second;
    }

    // (TimeSpan)による型変換を可能にする
    public static explicit operator TimeSpan(Time time)
        => new TimeSpan(time.Hour, time.Minute, time.Second);

    // (Time)による型変換を可能にする
    public static explicit operator Time(TimeSpan time)
        => new Time(time.Hours, time.Minutes, time.Seconds);
}

// TimeSpan 13:14:05
// Time 13:14:5

// ----------------------------------------------
//
// explicit대신에 implicit을 쓰면, 암묵적 형변환이 가능.
// 암묵적형변환은 코드가독성이 떨어지니 사용시 주의 필요.
// 
// var time = new Time(13, 14, 5);
// // TimeオブジェクトからTimeSpanオブジェクトへ型変換
// TimeSpan timeSpan = time;
// Console.WriteLine($"{timeSpan.GetType().Name} {timeSpan}");
// // TimeSpanオブジェクトからTimeオブジェクトへ型変換
// Time time2 = timeSpan; // 암묵적 형변환
// Console.WriteLine($"{time2.GetType().Name} {time2.Hour}:{time2.Minute}:{time2.Second}");


// // キャスト式による型変換を可能にする例
// public readonly struct Time
// {
//     public int Hour { get; }
//     public int Minute { get; }
//     public int Second { get; }

//     public Time(int hour, int minute = 0, int second = 0)
//     {
//         Hour = hour;
//         Minute = minute;
//         Second = second;
//     }

//     // (TimeSpan)による型変換を可能にする
//     public static implicit operator TimeSpan(Time time)
//         => new TimeSpan(time.Hour, time.Minute, time.Second);

//     // (Time)による型変換を可能にする
//     public static implicit operator Time(TimeSpan time)
//         => new Time(time.Hours, time.Minutes, time.Seconds);
// }