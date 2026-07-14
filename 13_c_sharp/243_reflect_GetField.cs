using System;
using System.ComponentModel.DataAnnotations;
using System.Reflection;

var value = Importance.High;
var fi = value.GetType().GetField(value.ToString());
var attr = fi.GetCustomAttribute<DisplayAttribute>();
Console.WriteLine($"{attr.Name}");

enum Importance
{
    [Display(Name = "低")]
    Low,
    [Display(Name = "中")]
    Medium,
    [Display(Name = "高")]
    High
}
