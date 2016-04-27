using System;

namespace YayMachine
{
	class Program
	{

		static void Main()
		{

			while (true)
			{
				//Prompt user to enter number of yays
				Console.Write("Enter the number of times to print \"Yay!\", or enter \"quit\": ");

				var entry = Console.ReadLine();

				if (entry.ToLower() == "quit")
				{
					Console.WriteLine("Later, bruh.");
					break;
				}

				try
				{
					var yays = int.Parse(entry);
					//yays is the number we need to extract to turn into yays

					if (yays <= 0)
					{
						Console.WriteLine("You must enter a positive number.");
					}

					else
					{
						for (int i = 0; i != yays; i++)
						{
							Console.WriteLine("Yay!");
						}
					}
				}
				catch (FormatException)
				{
					Console.WriteLine("You must enter a whole number.");
				} 
			}

		}
	}
}
