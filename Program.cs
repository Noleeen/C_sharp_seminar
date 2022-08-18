//задача 1  Текст задачи
/*
Console.Write("input number");

int number = Convert.ToInt32(Console.ReadLine());
int kvadrat = number*number;

//Console.WriteLine("the quad of " +number+" is "+kvadrat);

Console.WriteLine($"the quad of {number} is {kvadrat}")
*/

//задача 2

/*Console.WriteLine("enter 1 number");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("enter 2 number");
int number2 = Convert.ToInt32(Console.ReadLine());

int sq = number1*number1;

if( number2 ==sq)
    Console.WriteLine("является");
else
    Console.WriteLine("не является");
    */

    // задача 3

    Console.WriteLine("enter number");
int number = Convert.ToInt32(Console.ReadLine());

int current = number* (-1);

while(current<=number) 
{
    Console.Write(current+"  ");
    current++;
}