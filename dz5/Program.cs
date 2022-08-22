// ------------------ Task 34-----------------------
int[] number = new int[20];
int count = 0;
for (int i = 0; i < number.Length; i++)
{
    number[i] = new Random().Next(100, 119);
    if (number[i] % 2 == 0) { count++; }
}
Console.WriteLine('[' + String.Join(", ", number) + ']');
Console.WriteLine("number of even numbers: " + count);


// ------------------ Task 35-----------------------
int[] number1 = new int[123];
int count1 = 0;
for (int i = 0; i < number1.Length; i++)
{
    number1[i] = new Random().Next(1, 123);
    if (number1[i] >= 10 && number1[i] <= 99) { count1++; }
}
Console.WriteLine('[' + String.Join(", ", number1) + ']');
Console.WriteLine("numbers 10-99: " + count1);


// ------------------ Task 36-----------------------
int[] number2 = new int[5];
int count2 = 0;
for (int i = 0; i < number2.Length; i++)
{
    number2[i] = new Random().Next(0, 20);
    if (i % 2 != 0) { count2 += number2[i]; }
}
Console.WriteLine('[' + String.Join(", ", number2) + ']');
Console.WriteLine("sum: " + count2);


// ------------------ Task 38-----------------------
double[] number3 = { 2.1, 4.7, 5.6, 8.1, 1.2, 1.1 };
double max = number3[0];
double min = number3[0];
for (int i = 0; i < number3.Length; i++)
{
    if (number3[i] > max) { max = number3[i]; }
    if (number3[i] < min) { min = number3[i]; }
}
Console.WriteLine("max number: " + max + " min number: " + min + " difference between the maximum and minimum number: " + (max - min));