// See https://aka.ms/new-console-template for more information

using Task5;

try {var Triangle = new Triangle(3, 4, 5);}

catch (NonExistentTriangleException e) { Console.WriteLine(e.Message); }

finally { Console.WriteLine("Работа закончена"); }
