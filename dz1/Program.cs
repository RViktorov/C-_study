// Task 1
Console.WriteLine("--Task 1--");
Console.WriteLine("Enter 1 number");
int a= Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter 2 number");
int b= Convert.ToInt32(Console.ReadLine());
if (a>b) {Console.WriteLine("1 number- MAX, 2 number-MIN");}
if (a<b){Console.WriteLine("1 number- MIN, 2 number-MAX");}
if (a==b){Console.WriteLine("the numbers are equal");}
Console.WriteLine();

// Task 2
Console.WriteLine("--Task 2--");
Console.WriteLine("Enter 1 number");
int c= Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter 2 number");
int d= Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter 3 number");
int e= Convert.ToInt32(Console.ReadLine());
int max =c;
if (c>max) {max=c;}
if (d>max) {max=d;}
if (e>max) {max=e;}
Console.WriteLine("max number "+ max);
Console.WriteLine();

// Task 3
Console.WriteLine("--Task 3--");
Console.WriteLine("Enter  number");
int g= Convert.ToInt32(Console.ReadLine());
if (g%2==0) {Console.WriteLine(g+ " -is even number");}
else Console.WriteLine(g+ " -is not even number");
Console.WriteLine();

// Task 4
Console.WriteLine("--Task 4--");
Console.WriteLine("Enter  number");
int number= Convert.ToInt32(Console.ReadLine());
for (int i=1;i<number;i++ ) {
    if (i%2==0){
    Console.Write(i+ " ");
}}