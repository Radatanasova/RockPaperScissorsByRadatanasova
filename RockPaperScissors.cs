// See https://aka.ms/new-console-template for more information
const string Rock = "Rock";
const string Paper = "Paper";
const string Scissors = "Scissors";


Console.WriteLine("Choose [r]ock, [p]aper or [s]cissors: ");
string playedMove = Console.ReadLine();

if (playedMove == "r" || playedMove == "rock")
{
    playedMove = Rock;
}
else if (playedMove == "p" || playedMove == "paper")
{
    playedMove = Paper;
}
else if (playedMove == "s" || playedMove == "scissors")
{
    playedMove = Scissors;
}
else
{
    Console.WriteLine("Invalid Input. Try Again...");
    return;
}

Random random = new Random();
int computerRandomNumber = random.Next(1,4);

string computerMove = "";

switch (computerRandomNumber)
{
    case 1:
        computerMove = "Rock";
        break;
    case 2:computerMove = "Paper";
        break;
    case 3:computerMove = "Scissors";
        break;
    default:
        break;
}

Console.WriteLine($"The computer chose {computerMove}.");

if ((playedMove == Rock && computerMove == Scissors) ||
    (playedMove == Paper && computerMove == Rock) ||
    (playedMove == Scissors && computerMove == Paper))

{
    Console.WriteLine("You win.");
}
else if ((playedMove == Rock && computerMove == Paper) ||
    (playedMove == Paper && computerMove == Scissors) ||
    (playedMove == Scissors && computerMove == Rock))

{
    Console.WriteLine("You lose.");
}
else 
{
    Console.WriteLine("This game was a draw.");
}