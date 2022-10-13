// Hello World
// Pain

Console.WriteLine("Yearly Rainfall Average Calculator:");
Console.WriteLine("Enter only whole number values, in mm.");

int[] Rainfallmm = new int[12];
string[] Months = new string[] {"January", "Febuary", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December"};

for(int i = 0; i < Rainfallmm.Length; i++)
{
    Console.Write("Enter Rainfall for " + Months[i] + ": ");
    Rainfallmm[i] = Convert.ToInt32(Console.ReadLine());
}

Console.WriteLine();
Console.WriteLine("aaa");
Console.ReadKey();