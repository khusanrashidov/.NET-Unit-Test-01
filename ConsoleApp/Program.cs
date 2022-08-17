using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
	public class Program
	{
		public bool ReturnTrue(double[] array)
		{
			if (array[8] == 8)
				return true;
			else
				return false;
		}
		static void Main(string[] args)
		{
			double[] array = new double[8] { 1.1, 2.2, 3.3, 4.4, 5.5, 6.6, 7.7, 8.8 };
			Console.WriteLine($"Array length: {array.Length}");
			Console.WriteLine(array);
			Array.Resize(ref array, 9);
			Console.WriteLine($"Array length: {array.Length}");
			Console.Read();
		}
	}
}
