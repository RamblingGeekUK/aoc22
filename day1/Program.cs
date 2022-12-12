using System.Collections.Generic;
using System.Linq;

Console.WriteLine("Day 1");

// path to data file
string filename = @"C:\Users\wtt\source\repos\aoc2022\day1\data.txt";

// read data into a list.
List<string> allLinesText = File.ReadAllLines(filename).ToList();
List<int> elf = new List<int>();

int total = 0;

foreach (var item in allLinesText)
{
    // look for gap
    if (item != "")
    {   
        // total as we go
        total += Int32.Parse(item);
    }
    else
    {
        // if gap found, that's an elf, save the elf and total
        elf.Add(total);
        total = 0;
    }
}

// order in descending order and grab the top3
var result = elf.OrderByDescending(e => e).Take(3);

// find the elf with the highest and output to console
Console.WriteLine("The greedy elf has: " + elf.Max(m => m));
Console.WriteLine("Top 3 elfs total: " + result.Sum()); //sum top 3
Console.ReadLine();