// Задача 8: Напишите программу, которая на вход принимает число (N), 
//а на выходе показывает все чётные числа от 1 до N.
Console.Clear();
Console.WriteLine("enter number: ");
int num = Convert.ToInt32(Console.ReadLine());
int a1 = 2;
while(a1 <= num){
    Console.WriteLine($"{a1}");
    a1 = a1+2;
}
