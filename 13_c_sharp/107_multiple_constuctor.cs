using System;

// ------------------------------------------
public readonly struct Time
{
    public int Hour { get; }
    public int Minute{ get; }
    public int Second { get; }

    public Time(int hour = 0, int minute = 0, int second =0)
    {
        Hour = hour;
        Minute = minute;
        Second = second;
    }
    public Time(DateTime time) : this(time.Hour, time.Minute, time.Second) { }


}