using System;

// tuple을 반환.
// 복수의 값을 반환하고 싶을 때 사용.

// ------------------------------------
// タプルを受け取る
var tuple = GetItem();
Console.WriteLine($"{tuple.name} {tuple.color}");
// ------------------------------------
// タプルを分解して受け取る
var (name, color) = GetItem();
Console.WriteLine($"{name} {color}");
// ------------------------------------
// tuple을 반환하는 메소드
static (string name, string color) GetItem()
{
    var named = ("Banana", "Yellow");
    return named;
    // もちろん return ("Banana", "Yellow"); でもOKOK
}
// ------------------------------------

// Banana Yellow
// Banana Yellow