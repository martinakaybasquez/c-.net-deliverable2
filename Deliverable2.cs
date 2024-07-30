using System.Diagnostics;

Console.WriteLine("COME ONE! COME ALL! DARE TO JOIN THE GRAND CIRCUS COIN FLIP CHALLENGE???!!!??!??!");
Console.Write("YOU! THERE! YES, YOU! What is your name? ");
string name = Console.ReadLine(); 
Console.WriteLine(); 

Console.WriteLine($"Magnificent! Welcome, {name}. Would you like gamble? (y/n)");
string answer = Console.ReadLine(); 
int counter = 0;

if (answer == "y")
{
    const int heads = 0;
    const int tails = 1;
    
    Console.WriteLine("SUPERB! MAY THE GODS BLESS YOU ON THIS MOST GLORIOUS OF DAYS!");
    Console.WriteLine();
    // for (int i = 1; i <= 5; i++) // THIS IS TO GET IT TO LOOP 5 TIMES // KEEPING THIS AS A REMINDER OF HOW SIMPLE LIFE COULD HAVE BEEN, EXCEPT I CHOSE STRUGGLE
    Console.Write("Flipping coin...................heads or tails? ");
    string flipONE = Console.ReadLine(); 
    Random rnd1 = new Random();
    int num1 = rnd1.Next(2); 
   //Console.WriteLine(num1);
    if (flipONE == "heads") 
    {
        if (num1 == 0)
        {
            Console.WriteLine($"Winner winner chicken dinner! Good guess on the first try, {name}!");
            counter += 1;
        }
        else if (num1 != 0)
        {
            Console.WriteLine("***WRONG***");
            Console.WriteLine($"But that's okay, {name}. You have 4 more tries.");
        }
    }
    else 
    {
        if (num1 == 1)
        {
            Console.WriteLine($"Winner winner chicken dinner! Good guess on the first try, {name}!");
            counter += 1;
        }
        else if (num1 != 1)
        {
            Console.WriteLine("***WRONG***");
            Console.WriteLine($"But that's okay, {name}. You have 4 more tries.");
        }
    }
    Console.WriteLine();
    
    Console.Write("Flipping coin...................heads or tails? ");
    string flipTWO = Console.ReadLine(); 
    Random rnd2 = new Random();
    int num2 = rnd2.Next(2); 
    //Console.WriteLine(num2);
    if (flipTWO == "heads") 
    {
        if (num2 == 0)
        {
            Console.WriteLine($"Bingo! Good guess, {name}!");
            counter += 1;
        }
        else if (num2 != 0)
        {
            Console.WriteLine("***WRONG***");
        }
    }
    else 
    {
        if (num2 == 1)
        {
            Console.WriteLine($"Bingo! Good guess, {name}!");
            counter += 1;
        }
        else if (num2 != 1)
        {
            Console.WriteLine("***WRONG***");
        }
    }
    Console.WriteLine();
    
    Console.Write("Flipping coin...................heads or tails? ");
    string flipTHREE = Console.ReadLine(); 
    Random rnd3 = new Random();
    int num3 = rnd3.Next(2); 
    //Console.WriteLine(num3);
    if (flipTHREE == "heads") 
    {
        if (num3 == 0)
        {
            Console.WriteLine($"Correct! Tell me your secrets, {name}!");
            counter += 1;
        }
        else if (num3 != 0)
        {
            Console.WriteLine("***WRONG***");
        }
    }
    else 
    {
        if (num3 == 1)
        {
            Console.WriteLine($"Correct! Tell me your secrets, {name}!");
            counter += 1;
        }
        else if (num3 != 1)
        {
            Console.WriteLine("***WRONG***");
        }
    }
    Console.WriteLine();
    
    Console.Write("Flipping coin...................heads or tails? ");
    string flipFOUR = Console.ReadLine(); //THIS IS USER INPUT HEADS OR TAILS
    Random rnd4 = new Random();
    int num4 = rnd4.Next(2); //THIS IS CHOOSING RANDOM NUMBER 0 OR 1
    //Console.WriteLine(num4);
    if (flipFOUR == "heads") //THIS IS TO CHANGE "HEADS" TO "0"
    {
        if (num4 == 0)
        {
            Console.WriteLine($"Bingo! Watchout Megamind! We got a new big brain in town and their name is {name}!");
            counter += 1;
        }
        else if (num4 != 0)
        {
            Console.WriteLine("***WRONG***");
        }
    }
    else 
    {
        if (num4 == 1)
        {
            Console.WriteLine($"Bingo! Watchout Megamind! We got a new big brain in town and their name is {name}!");
            counter += 1;
        }
        else if (num4 != 1)
        {
            Console.WriteLine("***WRONG***");
        }
    }
    Console.WriteLine();
    
    Console.Write("Flipping coin...................heads or tails? ");
    string flipFIVE = Console.ReadLine(); 
    Random rnd5 = new Random();
    int num5 = rnd5.Next(2); 
    //Console.WriteLine(num5);
    if (flipFIVE == "heads") 
    {
        if (num5 == 0)
        {
            Console.WriteLine($"Is your real name, {name}? Or is it smarty pants?! CUZ YA GOT IT RIGHT!");
            counter += 1;
        }
        else if (num5 != 0)
        {
            Console.WriteLine("***WRONG***");
        }
    }
    else 
    {
        if (num5 == 1)
        {
            Console.WriteLine($"Is your real name, {name}? Or is it smarty pants?! CUZ YA GOT IT RIGHT!");
            counter += 1;
        }
        else if (num5 != 1)
        {
            Console.WriteLine("***WRONG***");
        }
    }
}

else
{
Console.WriteLine("BOOOOOO!!!!! EVERYBODY LOOK AT THIS CLOWN!!!");
}

Console.WriteLine();
Console.WriteLine($"Greatest of thank yous to you, {name}, for playing. You got {counter} points.");
