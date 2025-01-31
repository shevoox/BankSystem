namespace duplicates
{
    internal class Program
    {
        static void CheckDublicates(string[] numbers)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                for (int j = i + 1; j < numbers.Length; j++)//1 2 3 4
                {
                    if (numbers[i] == numbers[j])
                    {
                        throw new Exception($"Duplicate number found: {numbers[i]}");

                    }
                }

            }
        }
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Enter numbers separated by spaces: ");
                string[] StringArr = Console.ReadLine().Split(' ');
                CheckDublicates(StringArr);
                Console.WriteLine("No duplicates found!");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }
    }
}
