// See https://aka.ms/new-console-template for more information
Console.WriteLine("Enter a String!");
string str = Console.ReadLine();
if (str != null)
{
    char[] strArray = str.ToCharArray();
    Array.Reverse(strArray);
    string revString=new string(strArray);
    Console.WriteLine(revString == str ? string.Format("The string {str} is Palindrome") : string.Format( "The string {str} is not Palindrome"));
    Console.ReadKey();
}

