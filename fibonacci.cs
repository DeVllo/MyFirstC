using System;
					
public class Program
{
	public static void Main()
	{
		Console.WriteLine("Hola, ¿Como te llamas?");
		string nombre = Console.ReadLine();
		Console.WriteLine("¡Un gusto {0}! ¿Cuantos años tenes?", nombre);
		int edad = Convert.ToInt32(Console.ReadLine());
		Console.WriteLine("Así que tienes {0} años...", edad);
		Console.WriteLine("Bien... ahora selecciona un numero {0}", nombre);
		int numero = Convert.ToInt32(Console.ReadLine());
		int num1 = 0;
		int num2 = 1;
		int num3;
		for(int i = 0; i <= numero; i++)
		{
			num3 = num1 + num2;
			num1 = num2;
			num2 = num3;
			
			Console.WriteLine("Fibonacci ahora mismo: ({0})", num3);
		}
	}
}
