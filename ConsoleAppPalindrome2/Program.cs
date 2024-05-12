//another logic for palindrome check
using System.ComponentModel.DataAnnotations;

Console.WriteLine("Enter a string");
string str = Console.ReadLine();
int len = str.Length;
bool isPlaindrome = true;
for(int i = 0; i < len/2; i++)
{
    if (str[i] != str[len-1-i])
    { isPlaindrome = false; break; }
}
Console.WriteLine(isPlaindrome ? "The given string is Palindrome" : "The given string is not Palindrone");
Console.ReadLine();

//test
