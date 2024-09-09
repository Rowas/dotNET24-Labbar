using System.Globalization;
using System.Data;
using System.Diagnostics;

static int FindIndex(string searchString, int numberMatch, int startIndex)
{
    int foundEndIndex;
    char matchingNumber = searchString[numberMatch];
    foundEndIndex = searchString.IndexOf(matchingNumber, startIndex);
    return foundEndIndex;
}

static string FindNumberString(string searchString, int startIndex, int endIndex)
{
    char[] stringCharArray = new char[searchString.Length];

    for (int i = startIndex; i <= endIndex; i++)
    {
        stringCharArray[i] = char.Parse(searchString.Substring(i, 1));
    }
    string foundNumberString = new string(stringCharArray);

    if (endIndex - startIndex + 1 > 0)
    {
        foundNumberString = foundNumberString.Remove(0, startIndex);
        foundNumberString = foundNumberString.Remove(endIndex - startIndex + 1);
    }

    return foundNumberString;
}

static bool SanityCheck(string sanityString)
{
    bool sane = true;
    foreach (char c in sanityString)
    {
        if (char.IsLetter(c) == true)
        {
            sane = false;
            break;
        }
        else if (char.IsDigit(c) == false)
        {
            sane = false;
            break;
        }
    }
    return sane;
}

static (string, string) BeforeAfterNumbers(string searchString, int startIndex, int endIndex)
{
    string numbersBeforeString = searchString.Remove(startIndex);
    string numbersAfterString = searchString.Remove(0, endIndex + 1);
    return (numbersBeforeString, numbersAfterString);
}

static void PrintResult(string numbersBeforeString, string numbersAfterString, string foundString)
{
    Console.WriteLine();
    Console.ForegroundColor = ConsoleColor.Gray;
    Console.Write(numbersBeforeString);
    Console.ForegroundColor = ConsoleColor.Green;
    Console.Write(foundString);
    Console.ForegroundColor = ConsoleColor.Gray;
    Console.Write(numbersAfterString);
}

static void PrintSum(double printSum)
{
    Console.WriteLine();
    Console.WriteLine();
    Console.ForegroundColor = ConsoleColor.Gray;
    Console.WriteLine($"Sum of all found string values is: ");
    Console.ForegroundColor = ConsoleColor.Green;
    Console.Write(printSum);
    Console.ForegroundColor = ConsoleColor.Gray;
}

string searchString = "";
int startIndex = 0;
int endIndex = 1;
double[] foundNumbersSumArray = new double[1500];
int sumIndex = 0;

Console.ForegroundColor = ConsoleColor.Gray;
Console.WriteLine("Please provide a string to evaluate: ");

while (true)
{
    searchString = Console.ReadLine();
    if (searchString == "")
    {
        Console.WriteLine("Invalid input, try again.");
    }
    else
    {
        break;
    }
}

while (endIndex != searchString.Length - 1)
{
    int printIndex = FindIndex(searchString, startIndex, endIndex);

    string foundString = FindNumberString(searchString, startIndex, printIndex);

    bool sane = SanityCheck(foundString);

    if (printIndex < 0)
    {
        startIndex++;
        endIndex++;
        continue;
    }
    else if (sane == false)
    {
        startIndex++;
        endIndex++;
        continue;
    }
    else
    {
        foundNumbersSumArray[sumIndex] = double.Parse(foundString);
        sumIndex++;
    }

    (string numbersBeforeString, string numbersAfterString) = BeforeAfterNumbers(searchString, startIndex, printIndex);

    PrintResult(numbersBeforeString, numbersAfterString, foundString);

    startIndex++;
    endIndex++;
}
double printSum = foundNumbersSumArray.Sum();

PrintSum(printSum);