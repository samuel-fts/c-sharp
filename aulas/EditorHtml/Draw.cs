using System;
using Pricipal;

namespace Principal
{
    public static class Draw
    {
        public static void DrawnScreen()
        {
            Line();
            Space();
            Line();
            Options();
            var option = short.Parse(Console.ReadLine());
            HandleMenuOption(option);
        }

        private static void Line()
        {
            Console.Write("+");
            for (int line = 0; line < 30; line++)
            {
                Console.Write("-");
            }
            Console.Write("+");
            Console.Write("\n");
        }

        private static void Space()
        {
            for (int bar = 0; bar < 10; bar++)
            {
                Console.Write("|");
                for (int space = 0; space < 30; space++)
                {
                    Console.Write(" ");

                }
                Console.Write("|");
                Console.Write("\n");
            }
        }

        public static void HandleMenuOption(short options)
        {
            switch (options)
            {
                case 1: Editor.Show(); break;
                case 2: Editor.Show(); break;
                case 0:
                    {
                        Console.Clear();
                        System.Environment.Exit(0);
                        break;
                    }
                default: Menu.Show(); break;
            }
        }

        public static void NovoArquivo()
        {

        }
        public static void Abrir()
        {

        }

        public static void Options()
        {
            Console.SetCursorPosition(3, 3);
            Console.WriteLine("Editor HTML");
            Console.SetCursorPosition(3, 4);
            Console.WriteLine("===========");
            Console.SetCursorPosition(3, 5);
            Console.WriteLine("Selecione uma opcao abaixo");
            Console.SetCursorPosition(3, 6);
            Console.WriteLine("");
            Console.SetCursorPosition(3, 7);
            Console.WriteLine("1 - Novo Arquivo");
            Console.SetCursorPosition(3, 8);
            Console.WriteLine("2 - Abrir");
            Console.SetCursorPosition(3, 9);
            Console.WriteLine("0 - Sair");
            Console.SetCursorPosition(3, 10);
            Console.Write("Opcao:");
        }
    }
}