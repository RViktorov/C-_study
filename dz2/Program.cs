// Task 10
Console.WriteLine("--Task 10--");
Console.WriteLine("Enter number (100-999)" );
int a= Convert.ToInt32(Console.ReadLine());
Console.WriteLine((a/10)%10);

// Task 13
Console.WriteLine("--Task 13--");
Console.WriteLine("Enter number " );
String  b= Console.ReadLine();
if (b.Length<3) {Console.WriteLine("no third digit");}
else {Console.WriteLine(b.Substring(2,1));}


// Task 15
Console.WriteLine("--Task 15--");
Console.WriteLine("Enter number day of the week (1-7) " );
int d= Convert.ToInt32(Console.ReadLine());
if (d==6||d==7) {Console.WriteLine("it's weekend");}
else {Console.WriteLine("it's a working day ");}