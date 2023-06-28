// See https://aka.ms/new-console-template for more information

int i = 123;
byte a = 0b_1111_1111;
long k = 0xAFD12;
decimal d = 5.3m;
float f = 10.4f;
double g = 20;
bool bandera = true;
char c = 'a';
var s = 13;

Console.WriteLine("El valor de i es: {0}", i);
Console.WriteLine("El valor de a es: {0}", a);
Console.WriteLine("El valor de k es: {0:X}", k);



Console.WriteLine(bandera);
Console.WriteLine(c);
Console.WriteLine("El valor de s es {0} de tipo {1}: ", s, s.GetType());

Console.WriteLine("Valores con punto flotante:");

Console.WriteLine("El valor de d es: {0}", d);
Console.WriteLine("El valor de f es: {0}", f);
Console.WriteLine("El valor de g es: {0}", g);

Console.ReadKey();


