namespace OOP12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Workers worker = new Workers("Oleg");

            Console.Write("Vvedite vozrast ==> ");
            worker.Age = int.Parse(Console.ReadLine());

            Console.Write("Vvvedite staj ==> ");
            worker.Experience = int.Parse(Console.ReadLine());

            Console.WriteLine($"Rabotnek  {worker.Name} imeet {worker.Age} let i staj {worker.Experience} let.");
        }
    }
}
