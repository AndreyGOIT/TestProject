// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
#region Code project 1
string? readResult;
string valueEntered = "";
int numValue = 0;
bool validNumber = false;

Console.WriteLine("Enter an integer value between 5 and 10");

do
{
    readResult = Console.ReadLine();
    if (readResult != null) 
    {
        valueEntered = readResult;
    }

    validNumber = int.TryParse(valueEntered, out numValue);

    if (validNumber == true)
    {
        if (numValue <= 5 || numValue >= 10)
        {
            validNumber = false;
            Console.WriteLine($"You entered {numValue}. Please enter a number between 5 and 10.");
        }
    }
    else 
    {
        Console.WriteLine("Sorry, you entered an invalid number, please try again");
    }
} while (validNumber == false);

Console.WriteLine($"Your input value ({numValue}) has been accepted.");

readResult = Console.ReadLine();
#endregion

#region Code project 2 - write code that validates string input
// string? readResult;
// bool validEntry = false;
// Console.WriteLine("Enter one of three role names: Administrator, Manager, or User:");
// do
// {
//     readResult = Console.ReadLine();
//     if (readResult != null)
//     {
//         if (readResult == "Administrator" || readResult == "Manager" || readResult == "User")
//         {
//             validEntry = true;
//         }
//         else
//         {
//             Console.WriteLine("Your input is invalid, please try again.");
//         }
//     }
//     else
//     {
//         Console.WriteLine("Invalid input. Please enter one of three role names: Administrator, Manager, or User.");
//     }
// } while (validEntry == false);
// Console.WriteLine($"Your input value ({readResult}) has been accepted.");
#endregion

#region Code project 3 - write code that validates string input
// string[] myStrings = new string[2] { "I like pizza. I like roast chicken. I like salad", "I like all three of the menu choices" };
// int stringsCount = myStrings.Length;
// string myString = "";
// int periodLocation = 0;
// for (int i = 0; i < stringsCount; i++)
// {
//     myString = myStrings[i];
//     periodLocation = myString.IndexOf(".");
//     string mySentence = "";
//     // extract sentences
//     if (periodLocation == -1)
//     {
//         mySentence = myString;
//     }
//     else
//     {
//         mySentence = myString.Substring(0, periodLocation);
//     }
//     // print sentences
//     Console.WriteLine("first sentence: " + mySentence);
//     //     mySentence + " " + mySentence + " " + mySentence
//     // );
//     // get the index of the next sentence
//     myString = myString.Substring(periodLocation + 1);
//     periodLocation = myString.IndexOf(".");
//     if (periodLocation == -1)
//     {
//         mySentence = myString;
//     }
//     else
//     {
//         mySentence = myString.Substring(0, periodLocation);
//     }
//     Console.WriteLine("Last sentence: " + mySentence);
// }
#endregion
