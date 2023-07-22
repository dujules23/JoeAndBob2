using System;
namespace JoeAndBob
{
	public class Program
	{
		static void Main(string[] args)
		{
			// new Guy Object for Joe
			Guy joe = new Guy() { Cash = 50, Name = "Joe" };
			// new Guy Object for Bob
			Guy bob = new Guy() { Cash = 100, Name = "Bob" };

			while (true)
			{
				// calls WriteMyInfo methods for each Guy Object
				joe.WriteMyInfo();
				bob.WriteMyInfo();
				Console.Write("Enter an amount: ");
				string howMuch = Console.ReadLine();
				if (howMuch == "") return;
				if (int.TryParse(howMuch, out int amount))
				{
					Console.Write("Who should give the cash: ");
					string whichGuy = Console.ReadLine();
					if (whichGuy == "Joe")
					{
						// calls joe object's GiveCash method, calls bob object's ReceiveCash method, saved results
						int cashGiven = joe.GiveCash(amount);
						bob.ReceiveCash(cashGiven);
					}
					else if (whichGuy == "Bob")
					{
                        // calls bob object's GiveCash method, calls joe object's ReceiveCash method, saved results
                        int cashGiven = bob.GiveCash(amount);
						joe.ReceiveCash(cashGiven);
					}
					else
					{
						Console.WriteLine("Please enter 'Joe' or 'Bob'");
					}
				}
				else
				{
					Console.WriteLine("Please enter an amount (or a blank line to exit).");
				}
			}
		}
	}
}

