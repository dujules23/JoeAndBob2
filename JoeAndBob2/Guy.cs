namespace JoeAndBob;

class Guy
{
    public string Name;
    public int Cash;

    // Writes the name and the amount of the cash the Guy has to the console.
    public void WriteMyInfo()
    {
        Console.WriteLine(Name + " has " + Cash + " bucks.");
    }

    // Gives cash to other Guy, removes from wallet (prints message to console if there are not enough funds.
    public int GiveCash(int amount)
    {
        if(amount <= 0)
        {
            Console.WriteLine(Name + " says: " + amount + " isn't a valid amount");
        }
        if (amount > Cash)
        {
            Console.WriteLine(Name + " says: " + "I don't have enough cash to give you " + amount);
            return 0;
        }
        Cash -= amount;
        return amount;
    }

    // Receives cash, adding to wallet (prints message if the amount is invalid)
    public void ReceiveCash(int amount)
    {
        if (amount <= 0)
        {
            Console.WriteLine(Name + " says: " + amount + " isn't and amount I'll take");
        }
        else
        {
            Cash += amount;
        }
    }
}

