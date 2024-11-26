// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
#region Code project 1
// int readResult;
// bool validEntry = false;
// Console.WriteLine("Enter an integer value between 5 and 10:");
// do
// {
//     string? input = Console.ReadLine();
//     if (int.TryParse(input, out readResult))
//     {
//         if (readResult >= 5 && readResult <= 10)
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
//         Console.WriteLine("Invalid input. Please enter an integer.");
//     }
// } while (validEntry == false);
// Console.WriteLine($"Your input value ({readResult}) has been accepted.");
#endregion
#region Code project 2 - write code that validates string input
string? readResult;
bool validEntry = false;
Console.WriteLine("Enter one of three role names: Administrator, Manager, or User:");
do
{
    readResult = Console.ReadLine();
    if (readResult != null)
    {
        if (readResult == "Administrator" || readResult == "Manager" || readResult == "User")
        {
            validEntry = true;
        }
        else
        {
            Console.WriteLine("Your input is invalid, please try again.");
        }
    }
    else
    {
        Console.WriteLine("Invalid input. Please enter one of three role names: Administrator, Manager, or User.");
    }
} while (validEntry == false);
Console.WriteLine($"Your input value ({readResult}) has been accepted.");
#endregion
