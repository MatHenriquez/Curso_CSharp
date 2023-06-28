string cadena = "Hola, mundo";

string vacio = String.Empty;

string cadena2 = cadena;

cadena = "Hola programadores";

int programadores = 10;

decimal sueldo = 10500.5m;

string comunidad = $"Existen {programadores} programadores en la comunidad que ganan {sueldo:C}.";

string ruta = "C:\\Users"; //Doble diagonal para que aparezca una sola o uso @.

int longitud = ruta.Length;

string nombre = "  El loco Mati  ";

Console.WriteLine(cadena);  
Console.WriteLine(cadena2);
Console.WriteLine(comunidad);
Console.WriteLine("La cantidad de caracteres de la cadena ruta es: {0}", longitud);
Console.WriteLine(nombre);
Console.Write(nombre.Trim()); //Write solo no genera salto de línea al final.
Console.WriteLine(nombre.Substring(0, 10));
Console.WriteLine(nombre.StartsWith(   "M"));
Console.WriteLine(nombre.Replace('a', 'A'));
Console.WriteLine(nombre.Trim().ToLower());

Console.ReadKey();