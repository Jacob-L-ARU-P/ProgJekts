// Hello World

// Grade Calculator H1000!
// Version 1.0, inflexible, minimum error checks, no loops
// Program calculates average of 6x 15 credit modules
// Expected inputs are numbers from zero (0), to fifteen (15).
// 1st >=70%, 2:1 < 70% & >=60%, 2:2 <60% & >=50%, 3rd <50% & >=40%, Pass = 40%, Fail <40%
// Extension: Tell user which module they should improve to raise their average grade

// Define some initial variables
string spcr = "    ";
char choice;
double fcuk = 15.00;    // IF YOU ARE USING DECIMALS REMEMBER TO USE SIG FIGS
// grade variables
int g1, g2, g3, g4, g5, g6;
double perfectGrade = 6.00, totalGrade, actualGrade;

// Program Start and fluff
Console.WriteLine(spcr + "Welcome to the Grade Calculater H-10,000!");
Console.WriteLine(spcr + "Due to technical limitations, please enter information only in the requested format(s).");
Console.WriteLine(spcr + "Accepted formats: Whole Numbers, ranging from 0 to 15");
Console.WriteLine(spcr + "Not Accepted: Numbers written as words, i.e 'zero' for 0, of 'five' for 5.");
Console.WriteLine(spcr + "Please enter your six (6) results for your 15 credit modules:");

// While Loop Time
do{
    // Try & Catch for Errors
    try{
        // Get Grades
        Console.Write(spcr + "Credits earned in 1st module: ");
        g1 = Convert.ToInt32(Console.ReadLine());
        Console.Write(spcr + "Credits earned in 2nd module: ");
        g2 = Convert.ToInt32(Console.ReadLine());
        Console.Write(spcr + "Credits earned in 3rd module: ");
        g3 = Convert.ToInt32(Console.ReadLine());
        Console.Write(spcr + "Credits earned in 4th module: ");
        g4 = Convert.ToInt32(Console.ReadLine());
        Console.Write(spcr + "Credits earned in 5th module: ");
        g5 = Convert.ToInt32(Console.ReadLine());
        Console.Write(spcr + "Credits earned in 6th module: ");
        g6 = Convert.ToInt32(Console.ReadLine());

        // Generate module percentages, total grade as percentage and actual grade as percentage
        double gp1 = g1 / fcuk, gp2 = g2 / fcuk, gp3 = g3 / fcuk, gp4 = g4 / fcuk, gp5 = g5 / fcuk, gp6 = g6 / fcuk;
        totalGrade = gp1 + gp2 + gp3 + gp4 + gp5 + gp6;
        actualGrade = totalGrade / perfectGrade;

        // Switch statement for grades
        switch(actualGrade)
        {
            default:
                Console.WriteLine("An Error has occured.");
                break;
            case( >= 0.7):
                Console.WriteLine("Congrats! You've got a First!");               
                break;
            case( >= 0.6):
                Console.WriteLine("Congrats! You've got a 2:1!");               
                break;
            case( >= 0.5):
                Console.WriteLine("Good Work! You got a 2:2.");              
                break;
            case( > 0.4):
                Console.WriteLine("Good work, you got a 3rd.");               
                break;
            case(0.4):
                Console.WriteLine("You have passed your degree, well done.");
                break;
            case( < 0.4):
                break;
        }
    }
    catch{
        Console.WriteLine("Invalid Input.");
    }

    // Loop Confirm
    Console.Write("Do you want to try again? ");
    choice = Convert.ToChar(Console.ReadLine());
} while(choice != 'n');

// Console Hold Line
Console.ReadKey();