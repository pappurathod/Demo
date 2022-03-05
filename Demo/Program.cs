// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

//int Coin_Head = 1; //constant
//Random random = new Random();
//int coinCheck = random.Next(0, 2);
//if (coinCheck == Coin_Head)
//{
//    Console.WriteLine("Coin is Head");
//}
//else 
//{
//    Console.WriteLine("Coin is Tail");
//}

Console.WriteLine("enter year :");
int year = int.Parse(Console.ReadLine());

//if (((year % 4 == 0) && (year % 100 != 0)) || (year % 400 == 0))
if (DateTime.IsLeapYear(year))
{
    Console.WriteLine("{0} is Leap year", year);
}
else
{
    Console.WriteLine("{0} is not Leap year", year);
    Console.ReadLine();
}