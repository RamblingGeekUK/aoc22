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

foreach (var item in allLinesText)
{
    Console.WriteLine(item);
}
