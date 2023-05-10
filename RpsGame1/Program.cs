namespace RpsGame1;
class Program
{
    static void Main(string[] args)
    {
        int NumberOfRounds = 0;
        int compWins = 0;
        int userWins = 0;
        int ties = 0;

        while (compWins !=2 && userWins !=2){
        Console.WriteLine($"Hey there. Please enter your name.");
        string? name = Console.ReadLine();
        Console.WriteLine($"Thanks. Please enter a R, P, or S for Rock, Paper, or Scissors.");
        string? userChoice1 = Console.ReadLine();
        string userChoice = userChoice1!.ToUpper();
        // hard-code the computers choice.
        char compChoice = 'P';
        
        //compare the results with the computers hard-coded choice.
        if (userChoice == "R" && compChoice.ToString().Equals("P"))
        {// computer wins
            compWins++;
            Console.WriteLine($"Doh! {name}, bruh... The computer won");
            Console.WriteLine($"Computer won {compWins} times");

            if (compWins >= 1){
                NumberOfRounds++;
            }
        }
        else if (userChoice == "S" && compChoice.ToString().Equals("P"))
        {// user wins
            userWins++;
            Console.WriteLine($"YAAAAS!!! {name}, bruh... The user won");
            Console.WriteLine($"User won {userWins} times");

            if (userWins >= 1){
                NumberOfRounds++;
            }
        }
        else
        {// tie
            Console.WriteLine($"Close!! {name}, bruh... It was a tie.");
            ties++;
            Console.WriteLine($"There were {ties} ties");
        }
        }
            Console.WriteLine($"Total number of rounds: {NumberOfRounds}");
        /* refactor this code so that the game continues looping till one player gets 2 wins.
        print out the number of rounds and how many wins each palyer had adn how many ties total. 

        */

    }
}
