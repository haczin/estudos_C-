int a , b;
int x;
//Console.Write("Calculadora. \n");
//Console.Write("\n Digite o valor de a = ");
//a = int.Parse(Console.ReadLine());
//Console.Write("\n Digite o valor de b = ");
//b = int.Parse(Console.ReadLine());
//x = 10.5;
//a = (int) x;

//Console.Write(a);
//a += b;
//Console.WriteLine(" Valor da soma =  " + a);
//Console.WriteLine("Valor da subtração é " + (a - b));
//Console.WriteLine("Valor da multiplicação " +(a*b));
//Console.WriteLine("Valor da divisão " + (double) a/b);


Console.Write("Calculadora. \n");
Console.Write("\n Digite o valor de a = ");
a = int.Parse(Console.ReadLine());
Console.Write("\n Digite o valor de b = ");
b = int.Parse(Console.ReadLine());
x = a + b;
Console.WriteLine("\nx = "+x);


double pi=3.14159;
double Raio;
double calc;
//double A;
Console.Write("Digite o valor do raio desse circulo :");
Raio = int.Parse(Console.ReadLine());
calc = pi * Raio * Raio;
string A = calc.ToString("F4");

Console.WriteLine("A = " + A);
