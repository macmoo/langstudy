using System;

var count = 0;
var text = "";

while(count < 4)
{
    var s = Console.ReadLine();
    if(string.IsNullOrEmpty(s))
    {
        continue; // break;
    }
    text += s;
    count++;
}

Console.WriteLine(text);

// aa
// bb
// cc
// 
// ee
// aabbccee
