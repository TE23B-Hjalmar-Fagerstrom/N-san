näsan1();
näsan2();
näsan3();

static void näsan1()
{
    //Skapa en if-sats som skriver ut "Hello, World!" ifall 6 är större än eller lika med 3
    if (6 > 3)
    {
        Console.WriteLine("Hello, World!");
    }

    //Skapa en kod som först hämtar in ett användarnamn från användaren via Console.ReadLine. Gör sedan en if-sats som skriver ut "Welcome!" Ifall användarnamnet är lika med "noname". Komplettera föregående kod så att både användarnamn och lösenord efterfrågas. "Welcome" ska skrivas ut enbart om användarnamnet är lika med "noname" och lösenordet är "nopass". Om någon av dem inte stämmer så ska koden skriva ut "Wrong username or password".

    Console.WriteLine("write your username");
    string name = Console.ReadLine();
    Console.WriteLine("Password");
    string passWord = Console.ReadLine();
    if (name == "noname" && passWord == "nopass")
    {
        Console.WriteLine("Welcome!");
    }
    else
    {
        Console.WriteLine("Wrong username or password");
    }


    //Skriv en loop som skriver ut "Hello, World" 32 gånger. Välj själv om det ska vara en for-loop eller en while-loop.
    for (int i = 0; i < 32; i++)
    {
        Console.WriteLine("Hello, World");
    }

    //Skriv en loop som fortsätter så länge användaren inte har skrivit in rätt lösenord. Du måste alltså lägga in din Console.ReadLine inuti en while-loop.
    string passWordAgain = Console.ReadLine();
    Console.WriteLine("password");
    while (passWordAgain != "nopass")
    {
        Console.WriteLine("wrong password, try again");
        passWordAgain = Console.ReadLine();
    }

    //Skriv en loop som körs 5 gånger. Varje gång loopen körs ska användaren skriva in ett tal. Om talet är högre än 5, skriv ut “högre än 5!”. Observera att du måste konvertera talet från en string till en int för att kunna göra jämförelsen.
    int number = 0;

    for (int i = 0; i < 5; i++)
    {
        Console.WriteLine("skriv ett tal");
        string writenNumber = Console.ReadLine();
        int.TryParse(writenNumber, out number);
        if (number >= 5)
        {
            Console.WriteLine("Högre än 5!");
        }
    }

    //Skriv en loop som körs så länge användaren skriver in en string som inte kan konverteras till en int (använd All(char.isDigit)-testet eller TryCatch / TryParse).
    int hello = 0;
    bool successes = false;

    while (successes != true)
    {
        string world = Console.ReadLine();
        successes = int.TryParse(world, out hello);
    }


    //SLUTÖVNING: Skapa ett “gissa siffran”-spel:
    Console.WriteLine("Gissa nummret [1-100]");
    int randomNumber = Random.Shared.Next(1, 101);
    int guessedNumber = 12345678;

    while (randomNumber != guessedNumber)
    {
        string guess = Console.ReadLine();

        int.TryParse(guess, out guessedNumber);
        if (guessedNumber < randomNumber)
        {
            Console.WriteLine("numret är störe");
        }
        else if (guessedNumber > randomNumber)
        {
            Console.WriteLine("numret är mindre");
        }
        else
        {
            Console.WriteLine("Du hitta numret!");
        }
    }

}

static void näsan2()
{

}

static void näsan3()
{

}

Console.ReadLine();