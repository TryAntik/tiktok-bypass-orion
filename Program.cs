using System;

class Program : Tools
{
    private static char[] _lettersRu = new char[] { 'а', 'о', 'у', 'с', 'х', 'е', 'А', 'О', 'Е', 'Т', 'Х', 'С', 'Р' };
    private static char[] _lettersEn = new char[] { 'a', 'o', 'y', 'c', 'x', 'e', 'A', 'O', 'E', 'T', 'X', 'C', 'P' };

    private static readonly Random _timeRate = new Random();
    public bool Check(string ru, string en) => (ru == en);

    private void Queue()
    {
        while (true)
        {
            Console.WriteLine("1. exit");
            Console.WriteLine("2. write your message ");

            string temp = Console.ReadLine();
            string msgBefop, msgAftop;
            bool isUsed;
            msgBefop = temp == "exit" ? string.Empty :
                              (temp != null && temp != string.Empty) ? temp : string.Empty;
            
            if (temp == "exit" && msgBefop == string.Empty)
                Menu();

            if (msgBefop != string.Empty)
            {
                msgAftop = string.Empty;

                foreach (char ch in msgBefop)
                {
                    Clear();
                    Cout($"{0} \'{ch}\' ... ", ConsoleColor.Blue);
                    Wait(_timeRate.Next(0, 2));
                    isUsed = false;
                    for (int _ = 0; _ <= _lettersRu.Length - 1; _++)
                    {
                        Thread.Sleep(_timeRate.Next(2, 12));
                        Console.WriteLine($"if it == '{_lettersRu[_]}' <index={_}>");
                        if (ch == _lettersRu[_])
                        {
                            Cout("replacing", ConsoleColor.Blue);
                            msgAftop += _lettersEn[_];
                            isUsed = true;
                            break;
                        }
                        else if (_ == _lettersRu.Length - 1 && !isUsed)
                        {
                            msgAftop += ch;
                        }
                    }
                }
                Wait(300);
                Cout($"succesfull: ` {msgAftop} `", ConsoleColor.Magenta);
            }
              
        }
    }
    private void Menu()
    {
        Clear();
        while (true)
        {
            Cout("`bp_alpha` \n`exit`",ConsoleColor.Blue);
            string choose = Console.ReadLine();   
            switch (choose)
            {
                case "bp_alpha":
                    Console.Beep();
                    Queue();
                    break;
                case "exit":
                    Console.Beep();
                    Environment.Exit(0);
                    break;
            }
        }
    }
    public void Init() => Menu();
}
