// --------- metod print array for all tasks ----------
void printArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

// ------------------ Task 54 -----------------------
int[,] matrix = {{1,2,3,4},
                 {5,6,7,8},
                 {9,10,11,12},
                 {13,14,15,16}};

printArray(matrix);

for (int i = 0; i < matrix.GetLength(0); i++)
{
    bool nextIteration = true;
    while (nextIteration)
    {
        nextIteration = false;

        for (int j = 1; j < matrix.GetLength(1); j++)
        {
            if (matrix[i, j - 1] < matrix[i, j])
            {
                int temp = matrix[i, j];
                matrix[i, j] = matrix[i, j - 1];
                matrix[i, j - 1] = temp;
                nextIteration = true;
            }
        }
    }
}

printArray(matrix);

// ------------------ Task 56 -----------------------
int[,] array1 = {{1,2,3},
                 {4,5,6},
                 {1,2,1},
                 {0,1,1}};

int sumMin = 0;
int sumNextRow = 0;
int indexRow = 0;

for (int i = 0; i < array1.GetLength(0); i++)
{
    if (sumMin > sumNextRow)
    {
        sumMin = sumNextRow;
        indexRow = i;
    }
    sumNextRow = 0;
    for (int j = 0; j < array1.GetLength(1); j++)
    {
        sumNextRow += array1[i, j];
        if (i == 0)
        {
            sumMin = sumNextRow;
        }
    }
}
Console.WriteLine("MiN summa rouw: " + sumMin + " index row: " + indexRow);

// ------------------ Task 58 -----------------------
int[,] matrix1 = {{2,4,},
                 {3,2}};
int[,] matrix2 = {{3,4,},
                  {3,3}};

int[,] newMatrix = new int[matrix1.GetLength(0), matrix1.GetLength(1)];

for (int i = 0; i < matrix1.GetLength(0); i++)
{
    for (int j = 0; j < matrix2.GetLength(1); j++)
    {
        for (int k = 0; k < matrix2.GetLength(0); k++)
        {
            newMatrix[i, j] += matrix1[i, k] * matrix2[k, j];
        }
    }
}

printArray(newMatrix);

// ------------------ Task 6 -----------------------

int arraySize = 2;
int[,,] array3 = new int[arraySize, arraySize, arraySize];

for (int i = 0; i < array3.GetLength(0); i++)
{
    for (int j = 0; j < array3.GetLength(1); j++)
    {
        for (int k = 0; k < array3.GetLength(2); k++)
        {
            array3[i, j, k] = new Random().Next(10, 99);
            Console.Write(array3[i, j, k] + " (" + i + "," + j + "," + k + ") ");
        }
        Console.WriteLine();
    }
}

// ------------------ Task 62 -----------------------
int sizeArray = 4;
int numbersInArray = sizeArray * sizeArray;
int count = 1;
int indexA = 0;
int indexB = sizeArray - 1;

int[,] arraySpiral = new int[sizeArray, sizeArray];

while (count <= numbersInArray)
{
    for (int j = 0; j < sizeArray; j++)
    {
        if (arraySpiral[indexA, j] == 0)
        {
            arraySpiral[indexA, j] = count++;
        }
    }
    for (int i = 0; i < sizeArray; i++)
    {
        if (arraySpiral[i, indexB] == 0)
        {
            arraySpiral[i, indexB] = count++;
        }
    }
    for (int j = sizeArray - 1; j >= 0; j--)
    {

        if (arraySpiral[indexB, j] == 0)
        {
            arraySpiral[indexB, j] = count++;
        }
    }
    for (int i = sizeArray - 1; i >= 0; i--)
    {

        if (arraySpiral[i, indexA] == 0)
        {
            arraySpiral[i, indexA] = count++;
        }
    }
    indexA++;
    indexB--;
}

printArray(arraySpiral);