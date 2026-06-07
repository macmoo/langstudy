using System;

// ------------------------------------------
// 정적 클래스
// 인스턴스 생성 불가.
// 모든 멤버가 static일 필요가 있다.
var feet = 6.2;
double meter = FeetConverter.ToMeter(feet);
Console.WriteLine("{0:0.0} ft   = {1:0.0000} m ", feet, meter);

double feet2 = FeetConverter.FromMeter(meter);
Console.WriteLine("{0:0.0000} m = {1:0.0} ft", meter, feet2);

public static class FeetConverter
{
    // const는 static한 멤버
    private const double ratio = 0.3048;
    public static double FromMeter(double meter)
    {
        return meter / ratio;
    }
    public static double ToMeter(double feet)
    {
        return feet * ratio;
    }
}
// 6.2 ft = 1.8898 m
// 1.8898 m = 6.2 ft
