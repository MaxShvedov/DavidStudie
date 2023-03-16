namespace program;
class Program
{
    /// <summary>
    /// Выбирает из массива типа string строки указанной длины и возвращает их как единую строку с разделителями
    /// </summary>
    static string SearchWordsInArray(string[] text, int length)
    {
        string words = "";

        foreach (string i in text)
        {
            if (i.Length <= length)
                words += i + "\n";
        }
        return words;
    }

    static void Main(string[] args)
    {
        int wordLenght;
        string text;
        string[] words;

        Console.WriteLine("Введите текст:");
        text = Console.ReadLine();
        Console.Write("Введите максимальную длину искомых слов: ");
        wordLenght = int.Parse(Console.ReadLine());
        words = text.Split(new char[] { ' ', ',', '.' }, StringSplitOptions.RemoveEmptyEntries); //Второй параметр удаляет все пустые подстроки
        text = SearchWordsInArray(words, wordLenght);
        Console.Write("Найдены следующие слова:\n{0}", text);
    }
}