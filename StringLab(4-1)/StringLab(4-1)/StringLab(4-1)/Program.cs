namespace program
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите занчение S: ");
            string s = Console.ReadLine();
            Console.Write("Введите значение S1: ");
            string s1 = Console.ReadLine();
            Console.Write("Введите значение S2: ");
            string s2 = Console.ReadLine();

            s = s.Remove(s.LastIndexOf(s1), s1.Length).Insert(s.LastIndexOf(s1), s2);
            Console.WriteLine("Результат: {0}",s);
        }
    }
}