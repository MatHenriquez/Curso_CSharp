//Comparación de strings
string nombre = "Matías Henríquez";

Console.WriteLine(nombre == "Matías Henríquez");
Console.WriteLine(nombre.Equals("matías henríquez", StringComparison.OrdinalIgnoreCase));

if (nombre == "Matías Henríquez")
    Console.WriteLine("El nombre es: " + nombre + ".");
else
    Console.WriteLine("El nombre es distinto al esperado.");

if(nombre.Equals("matías henríquez", StringComparison.OrdinalIgnoreCase))
    Console.WriteLine("El nombre es igual o similar al esperado.");
else
    Console.WriteLine("El nombre es distinto al esperado.");

//Fecha

DateTime fecha = DateTime.Now;
Console.WriteLine("La fecha actual es: " + fecha.ToShortDateString());
Console.WriteLine("La fecha actual es: " + fecha.ToLongDateString());
Console.WriteLine("La fecha actual es: " + fecha.ToString("yyyy-MM-dd HH:mm:ss"));