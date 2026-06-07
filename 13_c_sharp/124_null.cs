using System;

// ------------------------------------------
var member = new Member("gihyo", "gihyo@example.com");
Console.WriteLine($"username:[{member.UserName}]");
Console.WriteLine($"{member.EmailAddress.Length} {member.EmailAddress}");
Console.WriteLine(); 
// ------------
member.UserName = null;     // 경고 O
member.EmailAddress = null; // 경고 O
member.PhoneNumber = null;  // 경고 X
Console.WriteLine($"username:[{member.UserName}]");
// Console.WriteLine($"{member.EmailAddress.Length} {member.EmailAddress}")';
// -> ERROR 
// Console.WriteLine($"PhoneNumber Len:[{member.PhoneNumber!.Length}], PhoneNumber:[{member.PhoneNumber}]");
// -> ERROR 
Console.WriteLine($"PhoneNumber Len:[{member.PhoneNumber?.Length}], PhoneNumber:[{member.PhoneNumber}]");

public class Member
{
    public Member(string userName, string emailAddress)
    {
        UserName = userName;
        EmailAddress = emailAddress;
    }

    public string UserName { get; set; }         // null 비허용
    public string EmailAddress { get; set; }     // null 비허용
    public string? PhoneNumber { get; set; }     // null 허용
    public DateTime AdmissionDate { get; set; }
}