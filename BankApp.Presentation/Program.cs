string? userName, password;

Console.WriteLine("***********Bank APP***********");
Console.WriteLine("***********Welcome***********");
Console.WriteLine(":::Login:::");

do
{
    Console.Write("Enter user name :");
    userName = Console.ReadLine();
}while(string.IsNullOrEmpty(userName));


do
{
    Console.Write("Enter password :");
    password = Console.ReadLine();
} while (string.IsNullOrEmpty(password));


if(userName == "system" && password =="manager")
{
    int choice = -1;

    do
    {
        Console.WriteLine("ToDo ::: Menue");
        Console.WriteLine("1. Customers");
        Console.WriteLine("2. Accounts");
        Console.WriteLine("3. Funds Transfer");
        Console.WriteLine("4. Funds Transfer Statement");
        Console.WriteLine("5. Account Statement");
        Console.WriteLine("0. Exit");
        Console.Write("Enter choice :");


        int.TryParse(Console.ReadLine(), out choice);

        switch(choice)
        {
            case 1: CustomersMenue(); break;
            case 2: AccountsMenue(); break;
            case 3: break;
            case 4: break;
            case 5: break;
            default : break;
        }

    } while(choice != 0);
        
}
else
{
    Console.WriteLine("Invalid Login");
}

Console.WriteLine("Thank you! Visit again");
Console.ReadKey();




static void CustomersMenue()
{
    int customersMenue = -1;

    do
    {
        Console.WriteLine("::: Customers Menue :::");
        Console.WriteLine("1.Add Customer");
        Console.WriteLine("2.update Customer");
        Console.WriteLine("3.delete Customer");
        Console.WriteLine("4.View Customers");
        Console.WriteLine("0.Back to Main Menue");


        int.TryParse(Console.ReadLine() ,out customersMenue);

    } while (customersMenue != 0);
}


static void AccountsMenue()
{
    int AccountsMenue = -1;

    do
    {
        Console.WriteLine("::: Accounts Menue :::");
        Console.WriteLine("1.Add Account");
        Console.WriteLine("2.update Account");
        Console.WriteLine("3.delete Account");
        Console.WriteLine("4.View Account");
        Console.WriteLine("0.Back to Main Menue");


        int.TryParse(Console.ReadLine(), out AccountsMenue);

    } while (AccountsMenue != 0);
}