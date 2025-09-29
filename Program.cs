Console.WriteLine("Enter the amount you want to bet");
string money=Console.ReadLine();
int bet=Convert.ToInt32(money);
int guess = -1;

while (guess < 0 || guess > 100)
{
    Console.WriteLine("Enter the number you want to bet on");
    string input = Console.ReadLine();
    guess = Convert.ToInt32(input);
    if (guess < 0 || guess > 100)
    {
        Console.WriteLine("Guess is invalid");

    }
}
//List<int> list=new List<int>();
Console.WriteLine("press enter to start");
Console.ReadLine();

while (true)
{
    Random rand = new Random();
    int randNumb = rand.Next(1, 101);

    if (randNumb == guess)
    {
        Console.WriteLine("You won " + 10 * bet);
    }
    else
    {
        Console.WriteLine("You lost");
    }
    Console.WriteLine("Do you want to play again? Press enter if yes");
    string answer= Console.ReadLine();

    if (answer == "no")
    {
        break;
    }
}




