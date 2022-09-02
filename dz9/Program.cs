// ------------------ Task 64 -----------------------
Console.WriteLine("Enter N ");
int number = Convert.ToInt32(Console.ReadLine());
void naturalNubers(int n)
{  
   if (n>=1){
   Console.Write(n+ " ");
   naturalNubers(n-1);}
   }
naturalNubers(number);

// ------------------ Task 66 -----------------------
Console.WriteLine("Enter initN");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter endN");
int number2 = Convert.ToInt32(Console.ReadLine());
int summa(int number1, int number2, int result = 0)
{
    if (number1 <= number2)
    {
        result = summa(number1, number2 - 1, result + number2);
    }
    return result;
}

Console.WriteLine("Summa: "+summa(number1, number2));

// ------------------ Task 68 ----------------------- m = 2, n = 3 -> A(m,n) = 9
Console.WriteLine("Enter m");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter n");
int n = Convert.ToInt32(Console.ReadLine());

int Akkerman(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if ((m > 0) && (n == 0))
    {
        return Akkerman(m - 1, 1);
    }
    else
    {
        return Akkerman(m - 1, Akkerman(m, n - 1));
    }
}

Console.WriteLine("Result: "+Akkerman(m, n));