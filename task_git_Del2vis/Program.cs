
string[] userNames = new string[] { "Alex", "David", "Bernt" };


while (true)
{
    Console.WriteLine("enter username");
    string input = Console.ReadLine();


    if (userNames.Contains(input))
    {
        Console.WriteLine($"Error: {input} is already taken");
    }
    else
    {
        Console.WriteLine($"your username is {input}");
        break;
    }
}

