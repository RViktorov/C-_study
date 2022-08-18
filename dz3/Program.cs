// Task 19
Console.WriteLine("Enter number (10000-99999)" );
int a= Convert.ToInt32(Console.ReadLine());
if (a>=10000&&a<=99999) {Console.WriteLine(a%10000/1000*10+a/10000==a%100?" POLINDROM NUMBER":"NOT POLINDROM NUMBER");}
else {Console.WriteLine("Enter number (10000-99999)");}
Console.WriteLine();

// Task 21
string [] simbols={"x","y","z","x1","x2","x3"};
double [] сoordinates=new double[6];
for (int i=0;i<сoordinates.Length;i++) {
Console.WriteLine("Enter "+ simbols[i] );
сoordinates[i]=Convert.ToDouble(Console.ReadLine());}
double result=Math.Sqrt(Math.Pow(сoordinates[0]-сoordinates[3],2)+Math.Pow(сoordinates[1]-сoordinates[4],2)+Math.Pow(сoordinates[2]-сoordinates[5],2));
Console.WriteLine("Result "+ result);
Console.WriteLine();

// Task 23
Console.WriteLine("Enter N (n>0)" );
int n= Convert.ToInt32(Console.ReadLine());
if (n>0) {for (int i=1; i<=n;i++){Console.Write(Math.Pow(i,3)+ " ");}}
else {Console.WriteLine("Enter N (n>0)");}