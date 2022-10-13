// Condensing Code
// Remember Computers start counting from 0!
// If you have an array with 12 numbers inside it, Position 1 is 0
// Position 12 is 11, etc.
//

String spcr = "    ";
int[] rainfallamt = new int[12];

rainfallamt[0] = 84;
rainfallamt[1] = 129;
rainfallamt[2] = 52;
rainfallamt[3] = 50;
rainfallamt[4] = 145;
rainfallamt[5] = 116;
rainfallamt[6] = 97;
rainfallamt[7] = 118;
rainfallamt[8] = 113;
rainfallamt[9] = 97;
rainfallamt[10] = 83;
rainfallamt[11] = 140;

Console.WriteLine(spcr + "Rainfall Records and Average Calculator: ");

for(int i = 0; i < 12; i++)
{
    Console.WriteLine(spcr + "Rainfall in month " + (i + 1) + " : " + rainfallamt[i]);
}

Console.WriteLine(spcr + "Rainfall average for the year: " + rainfallamt.Average());
Console.ReadKey();
