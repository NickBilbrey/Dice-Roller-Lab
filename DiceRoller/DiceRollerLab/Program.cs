using DiceRollerLab;

bool Luck = false;



do
{
    Console.WriteLine("Feeling Lucky? Type x to roll the dice");    //do while to loop based on user input
    string UserLuck = Console.ReadLine();
    if (UserLuck == "x")
    {
        int die1 = Magic.GetRandomNumber(1, 7);
        int die2 = Magic.GetRandomNumber(1, 7); // gets two "random" numbers and stores them

        Console.WriteLine($"{die1} & {die2}\nTotal {die1+die2}"); // prints rolls and total

        Console.WriteLine(Magic.Result(die1,die2)); // prints result of method 1

        Console.WriteLine(Magic.Craps(die1,die2)); // prints result of method 2

    }

    else
    {
        Console.WriteLine("Unlucky, Bye Bye"); // will break code if invalid entry key
        break;
    }




    Console.WriteLine("Would you like to roll again? Type y to continue or press any other key to exit");
    string userInput = Console.ReadLine();
    string userAnswer = userInput.ToLower();
    if (userAnswer == "y")
    {
        Luck = false;                           // asks user if they would like to restart
    }
    else
    {
        Console.WriteLine("Thanks, See you around");
        Luck = true;
    }


} while (Luck == false);