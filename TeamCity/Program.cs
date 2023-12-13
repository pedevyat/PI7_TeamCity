namespace TeamCity
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            string shouldRunTestsValue = Environment.GetEnvironmentVariable("ShouldRunTests");
            bool shouldRunTests = false; // string.IsNullOrEmpty(shouldRunTestsValue) || bool.Parse(shouldRunTestsValue);
            if (shouldRunTests)
            {
                Console.WriteLine(shouldRunTests);
            }
            else
            {
                Console.WriteLine("Tests are skipped as Shouldfalse.");
            }
        }
    }
}