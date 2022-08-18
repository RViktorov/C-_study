 // ------------------ Task 25
Console.WriteLine("Enter number a (number>0)");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter number b (number>0)");
int b = Convert.ToInt32(Console.ReadLine());
int result = a;
if (a > 0 && b > 0)
{
    for (int i = 2; i <= b; i++)
    {
        result *= a;
    }

Console.WriteLine("Result: " + result);}
else {Console.WriteLine("Enter numbers >0)");} 

// ------------------Task 27
Console.WriteLine("Enter number)");
int result=0;
String number= Console.ReadLine();
for (int i = 0; i < number.Length; i++)
{
    int a = Convert.ToInt32(number.Substring(i, 1));
    result += a;
}
Console.WriteLine(result);

// ------------------ Task 29
int [] number= new int[8];
for (int i = 0; i < number.Length; i++)
{
    number[i] =new Random().Next(1,8);       
}
Console.WriteLine ('['+String.Join (", ",number) +']');


// ------------------ Task 28
int[] array1 = { 2, 3, 4, 5 };
int[] array2 = new int[4];

for (int i = 0; i < array1.Length; i++)
{
    int count = 1;
    for (int j = 1; j <= array1[i]; j++)
    {
        count *= j;
        array2[i] = count;
    }
}
Console.WriteLine('[' + String.Join(", ", array2) + ']');

