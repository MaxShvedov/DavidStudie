namespace programm
{
    //TODO: Удалить комментарии кроме summary
    class Program
    {
        /// <summary>
        /// Возвращает значение True, если строка является палиндромом
        /// </summary>
        static bool IsInputSymmetric(string input)
        {
            int stringLength = input.Length; //Засунул в отдельную переменную на всякий случай

            for (int i = 0; i < stringLength; i++) //Перебор строки
            {
                if (input[i] != input[stringLength - 1 - i]) //Сравнивает противоположные по позиции символы
                {
                    return false; //Если он не находит совпадения, метод сразу возвращает False, цикл прерывается
                }
            }

            return true;
        }

        static void Main(string[] args)
        {
            int exitValue = 1;

            while (exitValue != 0)
            {
                if (exitValue == 1) {
                    Console.Write("Введите строку для проверки: ");

                    string inputString = Console.ReadLine().ToLower();
                    exitValue = -1;

                    Console.WriteLine("Результат: {0}", IsInputSymmetric(inputString));
                }
                Console.WriteLine("Для продолжения введите 1.\nДля выхода из программы введите 0.");
                exitValue = int.Parse(Console.ReadLine());
            }
        }
    }
}