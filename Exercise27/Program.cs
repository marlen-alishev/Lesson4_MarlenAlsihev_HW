// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.Clear();
Console.Write("Please enter the number: ");
int n = Convert.ToInt32(Console.ReadLine());

int f(int x) {
    int result = 0; 
    int lastNumber = 0; 
    for(int i = 0; x > 0; i++){
        lastNumber = x%10;
        //Console.WriteLine("Last number is: " + lastNumber);
        result = result + lastNumber;
        //Console.WriteLine("Result is: " + result);
        x = x/10;
    }
    return result; 
}

Console.WriteLine("The final result is " + f(n));
