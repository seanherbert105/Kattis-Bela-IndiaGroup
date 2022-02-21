// See https://aka.ms/new-console-template for more information
// Team India
// Katis Bela
// Team Lead: Sean Herbert
// Assistant Team Lead: Vanny Chas
// Team Members: Minh Vo, Dorleta Cobian, Jianing Ding, Fahim Farhan Khan


// random number object
Random random = new Random();

// error message for invalid number range for the input
string numberOfHandsError = "User must choose between 0 to 100";


// number of hands input
string numberOfHandsInput = Console.ReadLine();
int numberOfHands = int.Parse(numberOfHandsInput);

if (numberOfHands == 0)
{
    Console.WriteLine(numberOfHandsError);
}
else if (numberOfHands > 100)
{
    Console.WriteLine(numberOfHandsError);
}
else
{
    Console.WriteLine(numberOfHands);
}


// error message for invalid suit for the input
string suitError = "User must choose between the following suits - S, H, D, C";


// list different types of card suits available
string[] suit = { "S", "H", "D", "C" };
string userSuitInput = Console.ReadLine();
string dominantSuit = userSuitInput;

if (userSuitInput == "S" || userSuitInput == "s")
{
    Console.WriteLine(userSuitInput);
}
else if (userSuitInput == "H" || userSuitInput == "h")
{
    Console.WriteLine(userSuitInput);
}
else if (userSuitInput == "D" || userSuitInput == "d")
{
    Console.WriteLine(userSuitInput);
}
else if (userSuitInput == "C" || userSuitInput == "c")
{
    Console.WriteLine(userSuitInput);
}
else
{
    Console.WriteLine(suitError);
}


int total = 0;

// loop through the card suits
for (int i = 0; i < numberOfHands * 2; i++)
{
    // the dominant values
    int[] dominant = { 11, 4, 3, 20, 10, 14, 0, 0 };
    // choose a random non dominant value
    int dominantRandomValue = random.Next(0, dominant.Length);

    //the non dominant values
    int[] nonDominant = { 11, 4, 3, 2, 10, 0, 0, 0 };
    // choose a random non dominant value
    int nonDominantRandomValue = random.Next(0, nonDominant.Length);

    int randomSuit = random.Next(0, suit.Length);
    string newRandomSuit = randomSuit.ToString();

    if (dominantSuit == newRandomSuit)
    {
        Console.WriteLine(dominantRandomValue + suit[randomSuit]);
        total += dominantRandomValue;
    }
    else
    {
        Console.WriteLine(nonDominantRandomValue + suit[randomSuit]);
        total += nonDominantRandomValue;
    }
}

Console.WriteLine(total);