Console.WriteLine("Enter the amount you want to bet");
string money=Console.ReadLine();
int bet=Convert.ToInt32(money);

Console.WriteLine("Enter the number you want to bet on");
string input=Console.ReadLine();
int guess= Convert.ToInt32(input);


//List<int> list=new List<int>();
Random rand = new Random();
int randNumb =rand.Next(1,4);

if (randNumb ==guess)
{
    Console.WriteLine("You won " + 2*bet);
} else
{
    Console.WriteLine("You lost");
}

