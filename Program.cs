namespace MyConcoleVSC;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Как вас зовут?");
        string name = Console.ReadLine();
        DateTime currentDate = DateTime.Now;
        Console.WriteLine($"\n Привет {name}, сейчас {currentDate:d} at {currentDate:t}!");
        Console.Write($"\n Нажмите любую клавишу для завершения...");
        Console.ReadKey(true);
    }
}
