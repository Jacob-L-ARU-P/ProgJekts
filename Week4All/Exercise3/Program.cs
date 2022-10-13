// Program Initialisation
int[] arr = {800, 11, 50, 771, 649, 770, 240, 9};
int temp = 0;
Console.WriteLine("Bubble Sorter");
Console.Write("Unsorted Array: ");
// Initial Array
for (int x = 0; x < arr.Length; x++)
{
    Console.Write("{0} ", arr[x]);
}
// Bubble Sort
    for (int write = 0; write < arr.Length; write++)
    {
        for (int sort = 0; sort < arr.Length - 1; sort++)
        {
            if (arr[sort] > arr[sort + 1])
            {
                temp = arr[sort + 1];
                arr[sort + 1] = arr[sort];
                arr[sort] = temp;
            }
        }     
    }
// Sorted Array
Console.WriteLine();
Console.WriteLine("One Bubble Sort Later...");
Console.Write("Sorted Array:   ");
for (int x = 0; x < arr.Length; x++)
{
    Console.Write("{0} ", arr[x]);
}
// New Line & Window Hold
Console.WriteLine();
Console.ReadKey();