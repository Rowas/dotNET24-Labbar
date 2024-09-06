/*
//Labb Exercise1
string wordCheck1 = "Hello World!";
foreach (char c in wordCheck1)
{ 
    if (c ==  ' ')
    {
        break;
    }
    else
    {
        Console.Write(c);
    }
}
*/

/*
//Labb Exercise2
string wordCheck2 = "This is just some other text";
foreach (char c in wordCheck2)
{
    if (c == ' ')
    {
        Console.WriteLine("");
    }
    else
    {
        Console.Write(c);
    }
}
*/

/*
//Labb Exercise3
string wordCheck3 = "Detta är uppgift 3";
int i = 1;
foreach (char c in wordCheck3)
{
    if (i % 2 == 0)
    {
        Console.Write("*");
    }
    else
    {
        Console.Write(c);
    }
    i++;
}
*/

/*
//Labb Exercise4
string wordCheck4 = "Hello World";
foreach (char c in wordCheck4)
{
    if (c == 'l')
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.Write(c);
    }
    else if (c == 'o')
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Write(c);
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.Gray;
        Console.Write(c);
    }
        
}
/*

/*
//Labb Exercise5
string wordCheck = "Hello World";
for (int i = 0; i < wordCheck.Length - 1; i++)
{

    if (wordCheck[i] == wordCheck[i + 1])
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Write(wordCheck[i]);
        Console.Write(wordCheck[i + 1]);
        i++;
    }
    else
    {
        Console.ForegroundColor= ConsoleColor.Gray;
        Console.Write(wordCheck[i]);
    }
    if (i == wordCheck.Length - 2)
    {
        Console.WriteLine(wordCheck[i + 1]);
    }
}
*/

/*
//Labb Exercise6
string longString = "How much wood would a woodchuck chuck if a woodchuck could chuck wood?";
string shortString = "oo";

for  (int i = 0; i < longString.Length - 1; i++)
{ 
    if (longString.Substring(i, shortString.Length) == shortString)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Write(longString.Substring(i, 2));
        i++;
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.Gray;
        Console.Write(longString[i]);
    }
}
*/

/*
//Labb Exercise7
string longString = "How much wood would a woodchuck chuck if a woodchuck could chuck wood?";
string shortString = "chuck";

for (int i = 0; i < longString.Length - 4; i++)
{
    if (longString.Substring(i, 5) == shortString)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Write(longString.Substring(i, 5));
        i += 4;
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.Gray;
        Console.Write(longString[i]);
    }
    if (i == longString.Length - 5)
    {
        Console.Write(longString.Substring(i+1, 4));
    }
}
*/

/*
//Labb Exercise8
string longString = "How much wood would a woodchuck chuck if a woodchuck could chuck wood?";
Console.WriteLine(longString);
Console.WriteLine("Enter string to search from in above text: ");
string shortString = Console.ReadLine();

for (int i = 0; i <= longString.Length - shortString.Length - 1; i++)
{
    int j = 0;
    if (longString.Substring(i, shortString.Length) == shortString)
    {
        while (j < shortString.Length - 1)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(longString.Substring(i, 1));
            i++;
            j++;
        }
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Write(longString.Substring(i, 1));
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.Gray;
        Console.Write(longString[i]);
    }
    if (i == longString.Length - shortString.Length - 1)
    {
        i++;
        while (i <= longString.Length - 1)
        {
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.Write(longString.Substring(i, 1));
            i++;
        }
    }
    Console.ForegroundColor= ConsoleColor.Gray;
}
*/

/*
//Labb Exercise9
string printString = "Hello world!";
for  (int i = 0; i < printString.Length; i++)
{
    for (int j = 0; j <= i; j++)
    Console.Write(printString.Substring(i, 1));
    Console.WriteLine();
}
*/

/*
//Labb Exercise13
string stringValue = "abcdefghijklmnopqrstuvwxyz";

for (int i = 0; i < stringValue.Length-4; i++)
{
    Console.Write(stringValue.Substring(0, i));
    while (true)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.Write(stringValue.Substring(i, 5));
        break;
    }
    Console.ForegroundColor = ConsoleColor.Gray;
    Console.Write(stringValue.Substring(i + 5, stringValue.Length - 5 - i));
    Console.WriteLine();
}
*/

/*
//Labb Exercise14
Console.ForegroundColor = ConsoleColor.Gray;
Console.WriteLine("Enter a string: ");
string userString = Console.ReadLine();
string firstLetter = userString.Substring(0,1);
Console.ForegroundColor = ConsoleColor.Red;
for (int i = 0; i <= userString.Length - 2; i++)
{
    Console.Write(userString.Substring(i, 1));
    if (userString.Substring(i+1,1) == firstLetter)
    {
        Console.Write(userString.Substring(i+1, 1));
        Console.ForegroundColor = ConsoleColor.Gray;
        i++;
    }
    if (i == userString.Length-2)
    {
        Console.Write(userString.Substring(i+1,1));
    }
}
Console.ForegroundColor= ConsoleColor.Gray;
*/

/*
//Labb Exercise15
Console.ForegroundColor = ConsoleColor.Gray;
Console.WriteLine("Enter a string: ");
string userString = Console.ReadLine();
int x = 0;
Console.WriteLine();
string firstRun = userString.Substring(0, x + 1);
int nRun = 0;
Console.ForegroundColor = ConsoleColor.Red;
for (int i = 0; i < userString.Length - 4; i++)
{
    Console.Write(userString.Substring(0, i));
    while (true)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.Write(userString.Substring(i, 5));
        break;
    }
    Console.ForegroundColor = ConsoleColor.Gray;
    Console.Write(userString.Substring(i + 5, userString.Length - 5 - i));
    Console.WriteLine();
}
*/