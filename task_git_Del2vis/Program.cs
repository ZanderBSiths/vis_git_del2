


Menu();






static void Menu()
{
   
    Console.WriteLine("=========MENY=========");
    Console.WriteLine("1. Logga in som gäst");
    Console.WriteLine("2. Registrera");
    while (true)
    {
        try
        {
            int choice = int.Parse(Console.ReadLine());
            if (choice == 1)
            {
                Console.WriteLine("=========GÄST=========");
                Console.WriteLine("Du är inloggad som gäst...");
                break;
            }
            else if (choice == 2)
            {
                EnterUser();
                break;
            }
            else
            {
                Console.WriteLine("not a valid number");
            }
        }

        catch (Exception)
        {
            Console.WriteLine("Error: not a valid choice");

        }
        
        
    }
    
   
}



static void EnterUser()
{
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
}
