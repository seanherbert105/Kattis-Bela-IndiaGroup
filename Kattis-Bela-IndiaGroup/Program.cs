// See https://aka.ms/new-console-template for more information
// Team India
// Katis Bela
// Team Lead: Sean Herbert
// Assistant Team Lead: Vanny Chas
// Team Members: Minh Vo, Dorleta Cobian, Jianing Ding, Fahim Farhan Khan


// random number object
Random random = new Random();


// list values of dominant and non dominant
int[] dominant = { 11, 4, 3, 20, 10, 14, 0, 0 };
int[] nonDominant = { 11, 4, 3, 2, 10, 0, 0, 0 };

// list different types of suit available
string[] suit = { "S", "H", "D", "C" };

// choose a random suit from the suit list
int dominantSuit = random.Next(suit.Length);

Console.WriteLine("The Dominant Suit is:  " + suit[dominantSuit]);
