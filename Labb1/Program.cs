using System.Globalization;
using System.Data;
using System.Diagnostics;

static int FindIndex(string stringSearch, int numberMatch, int startIndex)
{
    int foundEndIndex;
    char matchingNumber = stringSearch[numberMatch];
    foundEndIndex = stringSearch.IndexOf(matchingNumber, startIndex);
    return foundEndIndex;
}

static string FindNumberString(string stringSearch, int startIndex, int endIndex)
{
    char[] stringCharArray = new char[stringSearch.Length];

    for (int i = startIndex; i <= endIndex; i++)
    {
        stringCharArray[i] = char.Parse(stringSearch.Substring(i, 1));
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

static (string, string) BeforeAfterNumbers(string stringSearch, int startIndex, int endIndex)
{
    string numbersBeforeString = stringSearch.Remove(startIndex);
    string numbersAfterString = stringSearch.Remove(0, endIndex + 1);
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

string stringSearch = "";
string foundString = "";
string numbersBeforeString = "";
string numbersAfterString = "";
int startIndex = 0;
int endIndex = 1;
double[] foundNumbersSum = new double[1500];
bool sane = true;
int sumIndex = 0;
int printIndex = 0;
double printSum = 0;

Console.ForegroundColor = ConsoleColor.Gray;
Console.WriteLine("Please provide a string to evaluate: ");
stringSearch = Console.ReadLine();

while (endIndex != stringSearch.Length - 1)
{
    printIndex = FindIndex(stringSearch, startIndex, endIndex);

    foundString = FindNumberString(stringSearch, startIndex, printIndex);

    sane = SanityCheck(foundString);

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
        foundNumbersSum[sumIndex] = double.Parse(foundString);
        sumIndex++;
    }

    (numbersBeforeString, numbersAfterString) = BeforeAfterNumbers(stringSearch, startIndex, printIndex);

    PrintResult(numbersBeforeString, numbersAfterString, foundString);

    startIndex++;
    endIndex++;
}
printSum = foundNumbersSum.Sum();

PrintSum(printSum);