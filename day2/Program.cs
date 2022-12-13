using System;

Console.WriteLine("Day 2");
// path to data file
string filename = @"C:\Users\wtt\source\repos\aoc2022\day2\data.txt";

// read data into a list.
List<string> allLinesText = File.ReadAllLines(filename).ToList();

// 1 for Rock, 2 for Paper, and 3 for Scissors

// elf
// A for Rock, B for Paper, and C for Scissors

// me
// X for Rock, Y for Paper, and Z for Scissors

// paper beats rock   
// scissors beats paper 
// rock beats scissors 
// same type of each is a draw

// rock = 1
// paper = 2
// scissors = 3
// winner = 6
// lost = 0
// draw = 3


string elf;
string me;

int player1_score = 0;  //elf
int player2_score = 0; // me

elf = "A";
me = "Y";

string player1_move = "rock";
string player2_move = "paper";

List<(string, int)> Moves = new List<(string, int)>();

Moves.Add(("rock", 1));
Moves.Add(("paper", 2));
Moves.Add(("scissors", 3));
Moves.Add(("draw", 3));

foreach (var item in Moves)
{
    if(item.Item1 == player1_move)
    {
        player1_score += item.Item2;
    }
    if (item.Item1 == player2_move)
    {
        player2_score += item.Item2;
    }

}

if (player1_score != player2_score)
{
    if (player1_score > player2_score)
    {
        player1_score += 6;
        Console.WriteLine($"Player 1 Wins!! with {player1_score} and Player 2 lost with a score {player2_score}");
    }
    else
    {
        player2_score += 6;
        Console.WriteLine($"Player 2 Wins!! with {player2_score} and Player 1 lost with a score {player1_score}");
    }
}
else
{
    player1_score = 3;
    player2_score = 3;

    Console.WriteLine($"Draw!! Player 1 scored : {player1_score}. Player 2 scored : {player2_score}");
}




//Console.WriteLine(player1_score);
//Console.WriteLine(player2_score);

//Console.WriteLine(Playrps(player1, player2));

static string PlayRockPaperScissors(string player1, string player2)
{
    string result;

    if (player1 == "paper" & player2 == "rock")
    {
        result = "Player1";
    }
    else if (player1 == "scissors" & player2 == "paper")
    {
        result = "Player1";
    }
    else if (player1 == "rock" & player2 == "scissors")
    {
        result = "Player1";
    }
    else if (player1 == player2)
    {
        result = "draw";
    }
    else
    {
        result = "Player2";
    }

    return result;
}

public class rps
{
    public string? move { get; set; }
    public int value { get; set; }
}





//switch (elf)
//{
//	case "A":
//		Console.WriteLine("ROCK");
//        Console.WriteLine("1");
//        elf_score += 1;
//        break;
//	case "B":
//		Console.WriteLine("PAPER");
//        Console.WriteLine("2");
//        elf_score += 2;
//        break;
//	case "C":
//		Console.WriteLine("Scissors");
//        Console.WriteLine("3");
//        elf_score += 3;
//        break;
//}

//switch (me)
//{
//    case "X":
//        Console.WriteLine("ROCK");
//        Console.WriteLine("1");
//        me_score += 1;
//        break;
//    case "Y":
//        Console.WriteLine("PAPER");
//        Console.WriteLine("2");
//        me_score += 2;
//        break;
//    case "Z":
//        Console.WriteLine("Scissors");
//        Console.WriteLine("3");
//        me_score += 3;
//        break;
//}
