Console.WriteLine("Enter the amount you want to bet");
string input=Console.ReadLine();
int amount= Convert.ToInt32(input);

Random rand = new Random();
for (int i = 0; i < amount; i++)