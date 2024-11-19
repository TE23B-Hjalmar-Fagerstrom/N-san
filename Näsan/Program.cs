näsan1();
näsan2();
näsan3();

static void näsan1()
{
    //Skapa en if-sats som skriver ut "Hello, World!" ifall 6 är större än eller lika med 3
    if (6 >= 3)
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
    //Skapa en string-array med namnen på fem olika leksaker.
    string[] toys = { "woody", "buzz ligthyear", "nurf gun", "action figure", "rocking horse" };


    //Skriv en for-loop (eller foreach-loop) som skriver ut namnet på varje leksak på en egen rad.
    for (int i = 0; i < 5; i++)
    {
        Console.WriteLine(toys[i]);
    }

    //Skapa en string-array med namnen på fem av dina klasskamrater.
    string[] names = { "Jack", "Alexander", "Alexander", "Mattias", "Lukas" };

    //Skapa en integer-array med fem värden mellan 0 och 10.
    int[] points = { 1, 3, 5, 7, 9 };

    //Komplettera for-loopen så att den på varje rad skriver ut något liknande "Pelle ger Barbie betyget 5". Använd dina klasskamraters namn, leksakernas namn och värdena från int-arrayen.
    for (int i = 0; i < 5; i++)
    {
        Console.WriteLine($"{names[i]} ger {toys[i]} betyget {points[i]}");
    }

    //Skapa en tom string-lista som heter "cities".
    List<string> cities = [""];

    //Skapa en loop där du varje gång loopen körs hämtar en string från användaren med Console.ReadLine. Lägg till den string du får från användaren till cities-listan. Avbryt loopen om användaren skriver "exit".
    Console.WriteLine("skriv städer du kan, för att lämna skriv 'exit'");
    bool exit = false;
    while (exit == false)
    {
        string addCities = Console.ReadLine().ToLower();
        if (addCities == "exit")
        {
            exit = true;
        }
        if (addCities != "exit")
        {
            cities.Add(addCities);
        }

    }

    //Skapa en loop som ligger efter den ovanstående. Den här loopen ska skriva ut alla strings som finns sparade i cities-listan.
    for (int i = 0; i < cities.Count; i++)
    {
        Console.WriteLine(cities[i]);
    }

}

static void näsan3()
{
    //Skapa en metod som, när den anropas, skriver ut "Hello, World" 32 gånger. Använd en loop (while eller for) för att sköta upprepningen. Döp metoden till "Hello32".
    Hello32();

    static void Hello32()
    {
        for (int i = 0; i < 32; i++)
        {
            Console.WriteLine("Hello");
        }
    }

    //Skapa en metod som anropas med en integer som parameter. Skriv ut Kvadraten av denna integer.
    Kvadraten();

    static void Kvadraten()
    {
        Console.WriteLine("skriv ett tall så får du kavdraten av det talet");
        int theNumber = 0;
        string number = Console.ReadLine();
        int.TryParse(number, out theNumber);
        Console.WriteLine($"{theNumber *= theNumber}");
    }

    //Skapa en metod som anropas med två doubles eller floats som parametrar. Metoden ska returnera resultatet av den ena parametern multiplicerad med den andra. Döp metoden till "Multi".
    Multi();

    static void Multi()
    {
        Console.WriteLine("skriv två tall");
        float theNumber = 0;
        float secondNuber = 0;
        string number = Console.ReadLine();
        float.TryParse(number, out theNumber);
        number = Console.ReadLine();
        float.TryParse(number, out secondNuber);
        Console.WriteLine($"{theNumber *= secondNuber}");
    }

    //Skapa en metod för att räkna ut arean på en rätvinklig triangel. Den ska ta emot två doubles eller floats och returnera samma datatyp. Döp metoden till "RightTriangleArea".
    RightTriangleArea();

    static void RightTriangleArea()
    {
        Console.WriteLine("skriv två tall och få reda på vad arean en triangel med dem två tallen skulle ha");
        float firstNumber = 0;
        float secondNumber = 0;
        string number = Console.ReadLine();
        float.TryParse(number, out firstNumber);
        number = Console.ReadLine();
        float.TryParse(number, out secondNumber);
        firstNumber *= secondNumber;
        Console.WriteLine($"{firstNumber /= 2}");
    }

    //Skapa en metod som, på motsvarande sätt, räknar ut arean för en cirkel.
    cirkelArea();

    static void cirkelArea()
    {
        Console.WriteLine("skriv ett tall för radien av en cirkel för att få arean");
        float firstNumber = 0;
        string number = Console.ReadLine();
        float.TryParse(number, out firstNumber);
        firstNumber *= firstNumber;
        Console.WriteLine($"{firstNumber *= 3.14159265359F}");
    }


    //Skapa en metod som hämtar in tal från användaren via konsollen (ReadLine). Skapa en loop inuti metoden som inte avslutas förrän användaren skrivit in något som är ett tal. Metoden ska returnera en int som är det tal användaren skrivit in. Metoden ska inte ta emot några parametrar. Döp metoden till GetNumberInput.
    GetNumberInput();

    static void GetNumberInput()
    {
        int theNumber = 0;
        bool successes = false;
        Console.WriteLine("skriv ett nummer");

        while (successes == false)
        {
            string number = Console.ReadLine();
            successes = int.TryParse(number, out theNumber);
        }
        Console.WriteLine($"{theNumber}");
    }

    //Skapa en metod som du döper till GetChoice och som tar emot tre strings som parametrar. Skriv ut de tre stringvärdena så att användaren ser dem. Metoden ska sedan låta användaren välja mellan de tre, t.ex. genom att skriva 1, 2 eller 3. Metoden ska inte avslutas innan användaren skrivit in ett giltigt svar. Metoden ska returnera en int som motsvarar användarens val.
    GetChoice("apa", "ko", "häst");

    static void GetChoice(string text, string you, string read)
    {
        Console.WriteLine($"{text}   {you}   {read}");
        Console.WriteLine("välg en av de ovanstående orden genom att skriva 1,2 eller 3");

        bool successes = false;
        int theChoice = 0;

        while (successes == false || theChoice > 3 || theChoice < 1)
        {
            string choice = Console.ReadLine();
            successes = int.TryParse(choice, out theChoice);
        }
        Console.WriteLine("du valde");


        if (theChoice == 1)
        {
            Console.WriteLine($"{text}");
        }
        else if (theChoice == 2)
        {
            Console.WriteLine($"{you}");
        }
        else
        {
            Console.WriteLine($"{read}");
        }
    }

}

Console.ReadLine();