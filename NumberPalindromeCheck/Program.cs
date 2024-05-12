int reverseNum = 0, number, tempNum, remainder;
Console.WriteLine("Enter a Number");
number = int.Parse(Console.ReadLine());
tempNum = number;
//while (number > 0)
//{
//    remainder=number% 10;//Process to get the remainder of the number
//    reverseNum = (reverseNum * 10) + remainder;
//    number = number/10;
//}

while(number > 0)
{
    remainder = number % 10;
    reverseNum = (reverseNum * 10) + remainder;
    number= number / 10;
}
if(tempNum==reverseNum)
{
    Console.WriteLine("Given number {0} is a Palindrome", tempNum);
}
else
{
    Console.WriteLine("Given number {0} is not a Palindrome", tempNum);
}

