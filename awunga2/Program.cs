using System.Runtime.InteropServices;

namespace awunga2;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        Console.WriteLine("gosh didily garn, Im coding in c#!");
        //This is my coment!
        /*This is my long comment
        see?*/

        //declare a const and tells the user the value
        const int imtergerz1 = 2;
        Console.Write("the fist number is:");
        Console.WriteLine(imtergerz1);

        //declare a second const and tells the user the value
        const int imtergerz2 = 4;
        Console.Write("the second number is:");
        Console.WriteLine(imtergerz2);

        //declare a variable that is currrently the sum of the first two numbers
        int sumOfImterz = imtergerz1 + imtergerz2;
        //display the variable
        Console.Write("their sum is:");
        Console.WriteLine(sumOfImterz);

        //make a new const, and then add it to the current sum
        const int imtergerz3 = 3;
        Console.Write("if we add a third number that is:");
        Console.WriteLine(imtergerz3);
        sumOfImterz = sumOfImterz + imtergerz3;
        Console.Write("the sum becomes:");
        Console.WriteLine(sumOfImterz);
    }
}
