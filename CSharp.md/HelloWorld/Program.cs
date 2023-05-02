// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
// Console.WriteLine("What is your name?");

// string name = Console.ReadLine();

// Console.WriteLine("Hello " + name + "!");

Console.WriteLine("Welcome to Hangman, you have 6 lives to guess the correct word!");
Console.WriteLine("Take a lucky guess at the word");

string word = "apron";
Console.WriteLine("The word has " + word.Length + " letters");
string userGuess = Console.ReadLine();

// char[] wordArray = userGuess.ToCharArray();

foreach (char c in word)
{
    if (c == userGuess[0]){
    Console.WriteLine(c);
    

    }
    else {
        Console.WriteLine("_");
    }    
}
