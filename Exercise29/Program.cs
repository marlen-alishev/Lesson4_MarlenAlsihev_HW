// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

//Console.Clear();
// Console.Write("Please enter the 1 number: ");
// int n1 = Convert.ToInt32(Console.ReadLine()); 
// Console.Write("Please enter the 2 number: ");
// int n2 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Please enter the 3 number: ");
// int n3 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Please enter the 4 number: ");
// int n4 = Convert.ToInt32(Console.ReadLine());
//Console.Write("Please enter the 5 number: ");
// int n5 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Please enter the 6 number: ");
// int n6 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Please enter the 7 number: ");
// int n7 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Please enter the 8 number: ");
// int n8 = Convert.ToInt32(Console.ReadLine());

// int[] array1 = {n1, n2, n3, n4, n5, n6, n7, n8}; 
// Console.Write($"Here is the array: [{string.Join(", ", array1)}]");

int[] array2 = new int[new Random().Next(1,9)];
Console.WriteLine("Array length is " + array2.Length);

void f(){
    for (int i=0; i<array2.Length; i++)
    {
        array2[i] = new Random().Next(); 
    }
    Console.WriteLine($"Here is the array: [{string.Join(", ", array2)}]");
}

f();