namespace Exercise_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter maximum number: ");
            int number = Int32.Parse(Console.ReadLine());

            for (int i = 0; i < number; i++) 
            {
                if (i % 2 == 0)
                { 
                Console.WriteLine(i);
                }
            }
            //Console.WriteLine(number);

            // asterisk

            Console.WriteLine("Enter number of asterisk");
            int asterisk = Int32.Parse(Console.ReadLine());

            for (asterisk = asterisk; asterisk > 0; asterisk--)
            {
                                
            Console.Write("*");
                
            }
        }
    }
}