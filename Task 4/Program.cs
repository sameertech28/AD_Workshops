class Program
{
    static void Main()
    {
        int[] favoriteNumbers = { 17, 3, 9, 1, 5 };

        
        Array.Sort(favoriteNumbers);

        Console.WriteLine("Array after Sort (Ascending):");

        for (int i = 0; i < favoriteNumbers.Length; i++)
        {
            Console.WriteLine(favoriteNumbers[i]);
        }

        
        Array.Reverse(favoriteNumbers);

        Console.WriteLine("Array after Reverse:");

        for (int i = 0; i < favoriteNumbers.Length; i++)
        {
            Console.WriteLine(favoriteNumbers[i]);
        }
        
        int position = Array.IndexOf(favoriteNumbers, 9);

        Console.WriteLine($"Index of 9: {position}");
    }
}