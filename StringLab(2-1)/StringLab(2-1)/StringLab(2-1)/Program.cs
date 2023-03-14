namespace program
{
    //TODO: Удалить комментарии
    class Programm
    {
        static void Main(string[] args)
        {
            string outputCode;

            Console.Write("Введите символ для получения кода: ");
            char symbol = char.Parse(Console.ReadLine());
            outputCode = string.Format("{0:X}", (int)symbol); // Символ преобразуется в шеснадцатиричный код
            while (outputCode.Length < 4) { outputCode = outputCode.Insert(0, "0"); } // Добавляем недостающие нули
            Console.WriteLine("Unicode код символа: U + {0}",outputCode);
        }
    }
}