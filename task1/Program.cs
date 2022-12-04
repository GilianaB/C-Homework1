int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
int max = a;
if (b == max) 
{
    Console.WriteLine("Числа равны"); 
}
else
{
    if (b > max) max = b;
Console.Write("max = ");
Console.WriteLine(max);
}

