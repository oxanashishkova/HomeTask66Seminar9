/*№ 66: Задайте значения M и N. Напишите программу, которая найдёт сумму
натуральных элементов в промежутке от M до N. Выполнить с помощью рекурсии.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/

Console.WriteLine("Enter 1rst number: ");
int numberM = int.Parse(Console.ReadLine());

Console.WriteLine("Enter 2nd number bigger than 1rst: ");
int numberN = int.Parse(Console.ReadLine());

void SumNumbers(int numberM, int numberN, int sum)
{
       if (numberM > numberN) 
    {
        Console.WriteLine($"Sum in the gap between two numbers is: {sum}"); 
        return;
    }
    sum = sum + (numberM++);
    SumNumbers(numberM, numberN, sum);
}

SumNumbers(numberM, numberN, 0);