// See https://aka.ms/new-console-template for more information
// Team India
// Katis Bela
// Team Lead: Sean Herbert
// Assistant Team Lead: Vanny Chas
// Team Members: Minh Vo, Dorleta Cobian, Jianing Ding, Fahim Farhan Khan


// random number object
Random random = new Random();


// list different types of card suits available
string[] suit = { "S", "H", "D", "C" };

// choose a random card suit
int randomSuit = random.Next(suit.Length);
string dominantSuit = suit[randomSuit];
Console.WriteLine("The Dominant Suit is:  " + dominantSuit);


// loop through the card suits
for (int i = 0; i < 100; i++)
{
    if (dominantSuit == dominantSuit)
    {
        // the dominant values
        int[] dominant = { 11, 4, 3, 20, 10, 14, 0, 0 };

        // choose a random non dominant value
        int randomDominant = random.Next(dominant.Length);
        Console.WriteLine(randomDominant + suit[randomSuit]);
        i++;
    }
    else
    {
        //the non dominant values
        int[] nonDominant = { 11, 4, 3, 2, 10, 0, 0, 0 };

        // choose a random non dominant value
        int randomNonDominant = random.Next(nonDominant.Length);
        Console.WriteLine(randomNonDominant + suit[randomSuit]);
        i++;
    }
}


