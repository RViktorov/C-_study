// ------------------ Task 41-----------------------
Console.WriteLine(" Enter how many numbers to enter ");
int n = Convert.ToInt32(Console.ReadLine());
int count = 0;
for (int i = 0; i < n; i++)
{
    Console.WriteLine(" Enter number " + (i + 1));
    int number = Convert.ToInt32(Console.ReadLine());
    if (number > 0) { count++; }
}
Console.WriteLine("numbers greater than zero: " + count);

// ------------------ Task 43-----------------------
Console.WriteLine(" Enter b1 ");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine(" Enter k1 ");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine(" Enter b2 ");
double b2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine(" Enter k2 ");
double k2 = Convert.ToDouble(Console.ReadLine());
double x;
double y;
if (k1 > k2)
{
    x = (b1 - b2) / (k1 - k2);
    y = (b2 * k1 - b1 * k2) / k1 - k2;
    Console.WriteLine("x: " + x + " y: " + y);
}
if (k1 < k2)
{
    x = (b2 - b1) / (k1 - k2);
    y = (b2 * k1 - b1 * k2) / (k1 - k2);
    Console.WriteLine("x: " + x + " y: " + y);
}


// ------------------ Task 44-----------------------
Console.WriteLine(" Enter N (N>=2!) ");
int n1 = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n1];
for (int i = 0; i < n1; i++)
{
    if (i < 2)
    {
        array[i] = i;
        Console.Write(i + " ");
    }
    else
    {
        int numberFibonachi = array[i - 1] + array[i - 2];
        array[i] = numberFibonachi;
        Console.Write(numberFibonachi + " ");
    }
}

// ------------------ Task 45-----------------------
int[] arrayInit = { 1, 2, 3, 4, 5, 6 };
int[] arrayEnd = new int[arrayInit.Length];
for (int i = 0; i < arrayInit.Length; i++)
{
    arrayEnd[i] = arrayInit[i];
}
Console.WriteLine('[' + String.Join(", ", arrayEnd) + ']');


// ------------------ Task +-----------------------
int multiplicationNumbers(int initNumber)
{
    int result = 1;
    if (initNumber == 1) { return result; }
    result = initNumber * multiplicationNumbers(initNumber - 1);
    return result;
}

Console.WriteLine(" Enter N (N>0)) ");
int enterNumber = Convert.ToInt32(Console.ReadLine());
if (enterNumber > 0) { Console.Write("result: " + multiplicationNumbers(enterNumber)); }
else { Console.WriteLine(" Enter N (N>0)) "); }


