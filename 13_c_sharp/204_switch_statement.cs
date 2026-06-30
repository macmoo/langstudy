using System;
using System.IO;

var driveType = DriveType.Network;
var drivetext = driveType switch
{
    DriveType.Fixed => "고정디스크",
    DriveType.Network => "네트워크디스크",
    DriveType.Removable => "리버블디스크",
    DriveType.CDRom => "광드라이브",
    _ => "그밖의 드라이브"
};
Console.WriteLine(drivetext);
// ------------------
// これは発展で示したコード
var num = 10;
var str = num switch
{
    < 0 => "마이너스",
    0 => "제로",
    > 0 => "플러스"
};
Console.WriteLine(str);
// ------------------
// 네트워크디스크
// 플러스
