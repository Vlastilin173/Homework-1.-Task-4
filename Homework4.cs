Console.Clear();

Console.Write("Введите 1-ое число: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите 2-ое число: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите 3-ое число: ");
int o = Convert.ToInt32(Console.ReadLine());
if (n > m ) 
    if (n > o)
    Console.WriteLine (n);
    else  
    Console.WriteLine(o); 
else if (m > o)   
    Console.WriteLine (m);
else 
    Console.WriteLine (o);

