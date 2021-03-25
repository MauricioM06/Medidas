using System;

namespace Medidas
{

    public class Program 
    {
        public static void Main(string [] args)
        {
			double Metros;
			double Km;
			double Cm;
			
			Console.ForegroundColor = ConsoleColor.Yellow;
			Console.WriteLine("Equivalência de Medidas");
			Console.ResetColor();
			
			Console.Write("Insira o valor em metros: ");
			Metros = Convert.ToDouble(Console.ReadLine());
			
			Km = Metros / 1000;
			Cm = Metros * 100;
			
			Console.WriteLine();
			Console.WriteLine("---Equivalência---");
			Console.WriteLine(Cm + " cm");
			Console.WriteLine(Metros + " m");
			Console.WriteLine(Km + " Km");
        }
    }
}