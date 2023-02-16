// Напишите программу, которая на вход принимает число и выдаёт, 
//является ли число чётным (делится ли оно на два без остатка)
Console.Clear();
Console.WriteLine("enter number: ");
int num = Convert.ToInt32(Console.ReadLine());
if (num % 2 == 1){
    Console.WriteLine("the " + num + " is odd");
}
else{
    Console.WriteLine("the " + num + " is even");
}
