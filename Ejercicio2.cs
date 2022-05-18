El area de un triangulo

double Area;
double Base;
double Altura;

Console.WriteLine("iNTRODUSCA LA ALTURA:");
Altura = double.parse(Console.ReadLine());
Base = double.parse(Console.ReadLine());
Area = (Base * Altura) / 2;
Console.WriteLine("El Area denun triangulo es de: "+ Area);
Console.ReadKey();