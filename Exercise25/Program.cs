// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.Clear();
Console.Write("Please enter the first number: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Please enter the second number: ");
int b = Convert.ToInt32(Console.ReadLine());

int f(int n1, int n2) 
{
    int result = 1;
    for (int i=1; i<=n2; i++)
    {
        result = result * n1;
        //Console.WriteLine(result);
    }
    return result;
}
Console.Write("Here is the result: " + f(a,b));