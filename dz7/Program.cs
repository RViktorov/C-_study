// ------------------ Task 47-----------------------
double[,] matrix = new double[3, 4];
for (int i = 0; i < 3; i++)
{
    for (int j = 0; j < 4; j++)
    {
        matrix[i, j] = Convert.ToDouble(new Random().Next(-100, 100) / 10.0);
        Console.Write(matrix[i, j] + " ");
    }
    Console.WriteLine();
}
Console.WriteLine();

// ------------------ Task 50 -----------------------
int[,] matrix1 = {{1,2,3,4},
                 {5,6,7,8},
                 {9,10,11,12},
                 {13,14,15,16}};
for (int i = 0; i < 4; i++)
{
    for (int j = 0; j < 4; j++)
    {
        Console.Write(matrix1[i, j] + " ");
    }
    Console.WriteLine();
}
Console.WriteLine();
Console.WriteLine("Enter position element matrix[i, j] ");
Console.WriteLine("Enter i ");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter j ");
int y = Convert.ToInt32(Console.ReadLine());
if (x <= 4 && y <= 4) { Console.WriteLine("result:" + matrix1[x - 1, y - 1]); }
else { Console.WriteLine("there is no element with this position"); }
Console.WriteLine();

// ------------------ Task 52 -----------------------
int[,] matrix2 = {{1,2,3,4},
                 {5,6,7,8},
                 {9,10,11,12},
                 {13,14,15,16}};
// print array
for (int i = 0; i < 4; i++)
{
    for (int j = 0; j < 4; j++)
    {
        Console.Write(matrix2[i, j] + " ");
    }
    Console.WriteLine();
}
Console.WriteLine();
//count avarage
for (int i = 0; i < 4; i++)
{
    double countAvg = 0;
    for (int j = 0; j < 4; j++)
    {
        countAvg += matrix2[j, i];
    }
    Console.WriteLine("arithmetic mean " + (i + 1) + " column: " + countAvg / 4);
}