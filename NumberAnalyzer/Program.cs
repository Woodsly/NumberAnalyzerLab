/* name: Connor Wood
 * Date: 6/22/2022
 * Project: Number Analyzer
 */

//intro and collecting data
string rerun = "Y";
Console.WriteLine("Hello and welcome to the Number Analyzer!");
Console.WriteLine("What is your name, stranger?");
string name = Console.ReadLine();
Console.WriteLine("Nice to meet you " + name + ".");

//do while loop to ask
do 
{ 
Console.WriteLine("Please enter a whole number between 1 and 100");
int number = int.Parse(Console.ReadLine());
    if (number < 0 || number > 100)
    {
        Console.WriteLine("Please enter another number that is between 1 and 100");
        number = int.Parse(Console.ReadLine());
    }
Console.WriteLine("Thank you!");

//calculations 0 = even while 1 = odd
int oddeven = number % 2;

//if statements
    if (oddeven == 1 && number < 60)
    {
        Console.WriteLine(name + ", your number: " + number + " is odd and less than 60!");
    }
    else if (number >= 2 && number <= 24 && oddeven == 0)
    {
        Console.WriteLine(name + ", your number is even and less than 25!");
    }
    else if (oddeven == 0 && number >= 26 && number <= 60)
    {
        Console.WriteLine(name + ", your number is even and between 26 and 60 inclusively!");
    }
    else if (oddeven == 0 && number > 60)
    {
        Console.WriteLine(name + ", your number: " + number + " is even and greater than 60!");
    }
    else if (oddeven == 1 && number > 60)
    {
        Console.WriteLine(name + ", your number: " + number + " is odd and greater than 60!");
    }

    Console.WriteLine(name + ", do you want to run the program again? Y/N");
    rerun = Console.ReadLine().ToUpper();

}while (rerun == "Y" || rerun == "YES");

//closing
Console.WriteLine("Thank you for using the Number Analyzer.  Have a good day " + name + "!");