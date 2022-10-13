// Condensing Code
// Remember Computers start counting from 0!
// If you have an array with 12 numbers inside it, Position 1 is 0
// Position 12 is 11, etc.
//

String spcr = "    ";
int[] rainfallamt = new int[12];

Console.WriteLine(spcr + "Rainfall Records and Average Calculator: ");

for(int i = 0; i < rainfallamt.Length; i++)
{
    Console.Write(spcr + "Enter Rainfall for Month " + (i+1) + ": ");
    rainfallamt[i] = Convert.ToInt32(Console.ReadLine());
}

Console.WriteLine(spcr + "Rainfall average for the year: " + rainfallamt.Average());
Console.ReadKey();