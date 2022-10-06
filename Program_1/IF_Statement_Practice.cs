// Hello World

// Grade Calculator H1000!
// Program calculates average of 6x 15 credit modules
// Expected inputs are numbers from zero (0), to fifteen (15).
// 1st >=70%, 2:1 < 70% & >=60%, 2:2 <60% & >=50%, 3rd <50% & >=40%, Pass = 40%, Fail <40%
// Extension: Tell user which module they should improve to raise their average grade

// Define some initial variables
string spcr = "    ";
// grade variables
int g1;
int g2;
int g3;
int g4;
int g5;
int g6;

// Program Start
Console.WriteLine(spcr + "                        Welcome to the Grade Calculater H10000!");
Console.WriteLine(spcr + "Due to technical limitations, please enter information only in the requested format(s).");
Console.WriteLine(spcr + "                    Accepted formats: Numbers, ranging from 0 to 15");
Console.WriteLine(spcr + "             Please enter your six (6) results for your 15 credit modules:");
Console.Write(spcr + "                             Credits earned in 1st module: ");
g1 = Convert.ToInt32(Console.ReadLine());


// Debug Line
Console.WriteLine(spcr + g1 + spcr);

// Console Hold Line
Console.ReadKey();