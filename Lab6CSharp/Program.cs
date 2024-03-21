using Lab6CSharp.Second;
using Lab6CSharp.First;
using Lab5CSharp.First;

void first()
{
    List<Product> products = new List<Product>();
    Console.WriteLine("Enter the number of products:");
    int count = int.Parse(Console.ReadLine());

    for (int i = 0; i < count; i++)
    {
        Console.WriteLine($"Enter information about product {i + 1}:");
        Console.Write("Name: ");
        string name = Console.ReadLine();
        Console.Write("Price: ");
        double price = double.Parse(Console.ReadLine());

        Console.WriteLine("Select the type of product (1 - toy, 2 - food product, 3 - dairy product):");
        int type = int.Parse(Console.ReadLine());

        Product product;
        switch (type)
        {
            case 1:
                Console.Write("Category: ");
                string category = Console.ReadLine();
                product = new Toy(name, price, category);
                break;
            case 2:
                Console.Write("Shelf Life: ");
                int endDate = int.Parse(Console.ReadLine());
                product = new FoodProduct(name, price, endDate);
                break;
            case 3:
                Console.Write("Origin: ");
                string origin = Console.ReadLine();
                Console.Write("Shelf Life: ");
                int endDate2 = int.Parse(Console.ReadLine());
                product = new DairyProduct(name, price, origin);
                break;
            default:
                Console.WriteLine("Incorrect type of product selected.");
                return;
        }

        products.Add(product);
    }
    Console.WriteLine();

    foreach (Product prod in products)
    {
        prod.Show();
        Console.WriteLine();
    }
}

 void second()
    {
        // Створення бази клієнтів
        Client[] clients = new Client[]
        {
            new Depositor("Glib"),
            new Creditor("SomeCreditor"),
            new Organization("Monobank.")
        };

        // Встановлення інформації про клієнтів
        foreach (var client in clients)
        {
            if (client is IDepositor)
            {
                ((IDepositor)client).SetDeposit(new DateTime(2004,10,25), 1000, 0.05);
            }
            else if (client is ICreditor)
            {
                ((ICreditor)client).SetLoan(DateTime.Now, 50000, 0.08, 40000);
            }
            else if (client is IOrganization)
            {
                ((IOrganization)client).SetAccount(DateTime.Now, "123456789", 10000);
            }
        }

        // Виведення інформації про клієнтів
        foreach (var client in clients)
        {
            client.DisplayInfo();
            Console.WriteLine();
        }

        // Пошук клієнтів, що почали співробітничати з банком у задану дату
        DateTime searchDate = new DateTime(2004,10,25);
        Console.WriteLine($"Clients who started cooperation with the bank on {searchDate.Date}:");
        foreach (var client in clients)
        {
            if (client.MatchDate(searchDate))
            {
                client.DisplayInfo();
            }
        }
    }

void main()
{
    Console.Write("Enter choise: ");
    int choise = int.Parse(Console.ReadLine());
    switch(choise)
    {
        case 1:
            first();
            break;
        case 2: second();
            break;
    }
}

main();