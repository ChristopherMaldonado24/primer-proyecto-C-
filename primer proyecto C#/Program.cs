

int EdadMeses, Edad;
string Nombre;
Console.WriteLine("Bienvenidos a nuestro primer sistema creado en C#");
Console.WriteLine("Ingresa tu nombre para continuar");
Nombre = Console.ReadLine();//Para recibir valores de caracter
Console.WriteLine("ingrese su edad");
Edad = Convert.ToInt32(Console.ReadLine);
EdadMeses = Edad * 12;