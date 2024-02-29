namespace FirstRepoOnGithHub
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Give in your name: ");
            var name = Console.ReadLine();
            Console.WriteLine(name);
            Console.WriteLine("Give in your age: ");
            var number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(number);
        }
    }
}
