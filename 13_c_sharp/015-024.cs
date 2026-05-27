using System.Globalization;

int.MaxValue;
int.MinValue;

double.MaxValue;
double.MinValue;

var num = 10;

Math.Abs(num);

Math.Pow(num, 4);
Console.WriteLine($"{pow:#,0}");

Math.Floor(num);
Math.Ceiling(num);
Math.Floor(num * Math.Pow(10, 2), 2);

Math.Round(10, 1, MidpointRounding.AwayFromZero); // 2.25 -> 2.3
Math.Round(10, 1, MidpointRounding.ToEven); // 가까운 짝수로. 2.25 -> 2.2
