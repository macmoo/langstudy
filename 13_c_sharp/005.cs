using System;

var temperature = 28.6;
var month = 7;

var text1 = $"{month}월의 평균기온은, {temperature}도 였다.";
Console.WriteLine(text1);

var text2 = string.Format("{0}월의 평균기온은, {1}도 였다.", month, temperature);
Console.WriteLine(text2);

// 7월의 평균기온은, 28.6도 였다.
// 7월의 평균기온은, 28.6도 였다.