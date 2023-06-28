using _06_libPedidos;

//clsClientes cliente = new clsClientes();

//cliente.idCliente = 0;
//cliente.Nombre = "Matías";
//cliente.Apellido = "Henríquez";
//cliente.dni = 38885811;

//Console.WriteLine(cliente.ToString());

clsProductos Producto = new clsProductos();
Producto.idProducto = 1;
Producto.Description = "Gaseosa naranja 500mL";
Producto.BarCode = "0001";

clsProductos Producto2 = new clsProductos();
Producto2 = Producto;

recProductos rProducto = new recProductos(1, "Gaseosa naranja 500mL", "0001");
recProductos rProducto2 = rProducto;

Console.WriteLine("Producto: " + Producto);
Console.WriteLine("Producto2: " + Producto2);
Console.WriteLine("rProducto: " + Producto);
Console.WriteLine("rProducto2: " + Producto2);

if (Producto == Producto2)
    Console.WriteLine("Los productos son iguales");
else 
    Console.WriteLine("Los productos NO son iguales");

if (rProducto == rProducto2)
    Console.WriteLine("Los rProductos son iguales");
else
    Console.WriteLine("Los rProductos NO son iguales");