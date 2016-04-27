using System;

namespace YayMachine
{
	class Program
	{

		static void Main()
		{

			//Prompt user to enter number of yays
			Console.Write("Enter the number of times to print \"Yay!\": ");

			var entry = Console.ReadLine();

			var yays = int.Parse(entry);
			//yays is the number we need to extract to turn into yays

			for (int i = 0; i != yays ; i++)
			{
				Console.WriteLine("Yay!");
			}

		}
	}
}
