//Задача 2. Напишите программу, которая на вход принимает 2 числа и выдает, какое число большее, а какое меньшее.
Console.Clear();
Console.WriteLine("enter first number: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("enter second number: ");
int b = Convert.ToInt32(Console.ReadLine());
if (a > b){
    Console.WriteLine("first number more second number");
}
else {
    Console.WriteLine("second number more first number");
}


