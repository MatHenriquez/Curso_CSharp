byte b = 200;
long l = 2000;
string cadena = "2000";
string cadena2 = "2000f";
long bl = b;
byte lb = (byte)l;
decimal d = Convert.ToDecimal(cadena);
decimal e = 0m;
int i = Convert.ToInt32("2");
DateTime fecha = Convert.ToDateTime("2023-06-26");

if (Decimal.TryParse(cadena2, out e))
    Console.WriteLine("el valor del decimal e es : {0}", e);
else
    Console.WriteLine("La conversión no se pudo realizar");

Console.WriteLine("el valor del long bl es : {0}", bl);
Console.WriteLine("el valor del byte lb es : {0}", lb);
Console.WriteLine("el valor del decimal d es : {0}", d);
Console.WriteLine("el valor del decimal e es : {0}", e);
Console.WriteLine(fecha.ToShortDateString());
Console.WriteLine("El valor entero i es: {0}", i);