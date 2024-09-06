﻿using System.Data;
using System.Diagnostics;

static int IndexSearch(string searchString, int charSearch, int beginIndex)
{
    int foundIndex;
    char searchChar = searchString[charSearch];
    foundIndex = searchString.IndexOf(searchChar, beginIndex);
    return foundIndex;
}

static string FindNumbers(string searchString, int startIndex, int endIndex)
{
    char[] stringChars = new char[searchString.Length];

    for (int i = startIndex; i <= endIndex; i++)
    {
        stringChars[i] = Char.Parse(searchString.Substring(i, 1));
    }
    string foundNumString = new string(stringChars);

    return foundNumString;
}

static bool StringSanityCheck(string sanityCheck)
{
    bool sane = true;
    foreach (char c in sanityCheck)
    {
        if (char.IsLetter(c) == true)
        {
            sane = false;
            break;
        }
    }
    return sane;
}

static (string, string) BeforeAfterNumbers(string userProvidedString, int index1, int index2)
{
    string remainingNumbersBefore = userProvidedString.Remove(index1);
    string remainingNumbersAfter = userProvidedString.Remove(0, index2+1);
    return (remainingNumbersAfter, remainingNumbersBefore);
}

string userProvidedString = "";
int index1 = 0;
int index2 = 1;

Console.WriteLine("Please provide a string to evaluate: ");
userProvidedString = Console.ReadLine();

int newIndex2 = IndexSearch(userProvidedString, index1, index2);

Console.WriteLine($"{index1},{newIndex2}");

string stringToColour = "";

stringToColour = FindNumbers(userProvidedString, index1, newIndex2);

Console.WriteLine(stringToColour);

bool sane = StringSanityCheck(stringToColour);

if (sane == true)
{
    Console.WriteLine("String is safe to use.");
}
else
{
    Console.WriteLine("String is not safe, trash and move on.");
    return;
}

(string numbersAfter, string numbersBefore) = BeforeAfterNumbers(userProvidedString, index1, newIndex2);

Console.WriteLine();
Console.ForegroundColor = ConsoleColor.Gray;
Console.Write(numbersBefore);
Console.ForegroundColor = ConsoleColor.Red;
Console.Write(stringToColour);
Console.ForegroundColor = ConsoleColor.Gray;
Console.WriteLine(numbersAfter);

double[] addFoundNumbers = new double[1500];
addFoundNumbers[index1] = Int32.Parse(stringToColour);
addFoundNumbers[1] = 1000000;
addFoundNumbers[2] = 1000000;
double sumFoundNumbers = addFoundNumbers.Sum();
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine(sumFoundNumbers);