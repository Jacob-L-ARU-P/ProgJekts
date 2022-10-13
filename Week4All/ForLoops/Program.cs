// Multi-Dimensional Arrays, and more For Loops
//
// Address Book 'program'

string spcr = "    ";
string[,] addressBook = new string[10,2];
char userChoiceA;
int userChoiceB;
char userChoiceC;

Console.WriteLine(spcr + "Welcome to Address Book Manager V0-000-001-A!");

for(int i = 0; i < 10; i++)
{
    Console.WriteLine("Enter Name: ");
    addressBook[ i, 0 ] = Console.ReadLine();
    Console.WriteLine("Enter Address: ");
    addressBook[ i, 1 ] = Console.ReadLine();
}

Console.WriteLine();
Console.WriteLine(spcr + "...Processing...");
Console.WriteLine();
Console.WriteLine("Processing Complete!");



Console.ReadKey();

