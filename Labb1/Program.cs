using System.Data;

static int IndexSearch(string searchString, int charSearch, int beginIndex)
{
    char searchChar = searchString[charSearch];
    int foundIndex = searchString.IndexOf(searchChar,beginIndex);

    return foundIndex;
}
/*
static double FindNumbers(int startIndex, int endIndex)
{
    return numbersToAdd;
    return foundNumString;
}

static string BeforeAfterNumbers(string numbersFound)
{

}

static string ColourNumbers(string numbersToColour)
{


    return numbersColoured;
}

static double[] foundNumbersAddition(double[] addFoundNumbers)
{

}

*/

string userPorivdedString = "";
int index1 = 0;
int index2 = 1;

Console.WriteLine("Please provide a string to evaluate: ");
userPorivdedString = Console.ReadLine();

index2 = IndexSearch(userPorivdedString, index1, index2);

Console.Write($"{index1},{index2}");