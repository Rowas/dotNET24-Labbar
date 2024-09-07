using System.Data;
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

    if (endIndex - startIndex + 1 > 0)
    {
        foundNumString = foundNumString.Remove(0, startIndex);
        foundNumString = foundNumString.Remove(endIndex - startIndex + 1);
    }

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

/*
//Function obsolete, solution it provided moved to 'FindNumbers' function. 
//Leaving for prosperity. 
static double StringTrashRemover(string stringWithTrash)
{
    double trashFreeDouble = 0;
    char[] charWithoutTrash = new char[stringWithTrash.Length];
    char c = ' ';
    int y = 0;
    for (int i = 0; i <= stringWithTrash.Length - 1; i++)
    {
        c = char.Parse(stringWithTrash.Substring(i, 1));

        if (char.IsDigit(c) == true)
        {
            charWithoutTrash[y] = c;
            y++;
        }
    }

    string stringWithoutTrash = new string(charWithoutTrash);

    trashFreeDouble = double.Parse(stringWithoutTrash);

    return trashFreeDouble;
}
*/

static (string, string) BeforeAfterNumbers(string userProvidedString, int index1, int index2)
{
    string remainingNumbersBefore = userProvidedString.Remove(index1);
    string remainingNumbersAfter = userProvidedString.Remove(0, index2+1);
    return (remainingNumbersAfter, remainingNumbersBefore);
}

string userProvidedString = "";
int index1 = 0;
int index2 = 1;
double[] addFoundNumbers = new double[1500];
string stringToColour = "";
bool sane = true;
int newIndex2 = 0;
int addIndex = 0;

Console.ForegroundColor = ConsoleColor.Gray;
Console.WriteLine("Please provide a string to evaluate: ");
userProvidedString = Console.ReadLine();

while (true)
{
    if (index2 == userProvidedString.Length - 1)
    {
        break;
    }
    newIndex2 = IndexSearch(userProvidedString, index1, index2);

    // Console.WriteLine($"{index1},{newIndex2}"); --Sanity check of IndexSearch, leaving for future troubleshooting. 

    stringToColour = FindNumbers(userProvidedString, index1, newIndex2);

    //Console.WriteLine(stringToColour); --Sanity check of result from FindNumbers(), leaving for future troubleshooting.

    sane = StringSanityCheck(stringToColour);



    if (newIndex2 < 0)
    {
        //Console.WriteLine("String is not safe, trash and move on."); --Confirmation of result from StringSanityCheck, leaving for future troubleshooting.
        index1++;
        index2++;
        continue;
    }
    else if (sane == false)
    {
        //Console.WriteLine("String is not safe, trash and move on."); --Confirmation of result from StringSanityCheck, leaving for future troubleshooting.
        index1++;
        index2++;
        continue;
    }
    else
    {
        //Console.WriteLine("String is safe to use."); --Confirmation of result from StringSanityCheck, leaving for future troubleshooting.
        //addFoundNumbers[addIndex] = StringTrashRemover(stringToColour);
        addFoundNumbers[addIndex] = double.Parse(stringToColour);
        addIndex++;
    }

    (string numbersAfter, string numbersBefore) = BeforeAfterNumbers(userProvidedString, index1, newIndex2);

    Console.WriteLine();
    Console.ForegroundColor = ConsoleColor.Gray;
    Console.Write(numbersBefore);
    Console.ForegroundColor = ConsoleColor.Red;
    Console.Write(stringToColour);
    Console.ForegroundColor = ConsoleColor.Gray;
    Console.Write(numbersAfter);
    index1++;
    index2++;
}
Console.WriteLine();
Console.WriteLine();
double sumFoundNumbers = addFoundNumbers.Sum();
Console.WriteLine("The sum of all the found numbers is: ");
Console.ForegroundColor = ConsoleColor.Green;
Console.Write(sumFoundNumbers);
Console.ForegroundColor = ConsoleColor.Gray;