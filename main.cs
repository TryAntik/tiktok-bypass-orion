using System;

class Program {

    private static char[] _lettersRu = new char[] { 'а', 'о', 'у', 'с', 'х', 'е', 'А', 'О', 'Е', 'Т', 'Х', 'С', 'Р' };
    private static char[] _lettersEn = new char[] { 'a', 'o', 'y', 'c', 'x', 'e', 'A', 'O', 'E', 'T', 'X', 'C', 'P' };
    private static readonly Random _timeRate = new Random();
    private static void Main(string[] args) {
        Project testInput = new Project();

        Console.ForegroundColor = ConsoleColor.Green;
        string temp = string.Empty;

        while (true) {
            Console.WriteLine("write your message ");
            temp = Console.ReadLine();
            string newMessage = string.Empty;
            
            foreach (char c in temp) {
                bool isUsed = false;
                Console.WriteLine($"разбив строку , проводим операции с элементом \'{c}\' ... ");
                Thread.Sleep(_timeRate.Next(2, 34));
                for (int _ = 0; _ <= _lettersRu.Length -1; _++) {
                    Thread.Sleep(_timeRate.Next(2, 34));
                    Console.WriteLine($"проверяем является ли элемент == '{_lettersRu[_]}' с индексом {_}");
                    if (c == _lettersRu[_]) {
                        Console.WriteLine("Да является, заменяем");
                        newMessage += _lettersEn[_];
                        isUsed = true;
                    } else if (_ == _lettersRu.Length -1 && !isUsed) {
                        newMessage += c;
                    }
                }
            }
            Thread.Sleep(300);
            Console.WriteLine($"Готово: {newMessage}");
            var result = testInput.Check(temp, newMessage) ? "Всё чотко!" : "кто то тут пиздит.";
            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}
