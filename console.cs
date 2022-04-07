using System;

namespace Connorcorp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console by Connor Corporation V0.0.1
            Console.WriteLine("Connor Corporation 2022 - 2022 All Rights Reserved.");
            Console.WriteLine("Enter command: ");
            var command =
                Console.ReadLine();

            if (command == "help")
            {
                Console.WriteLine("Commands:");
                Console.WriteLine("help - Shows commands");
                Console.WriteLine("text - Shows your text");
            }

            if (command == "text") {
                Console.WriteLine("Enter You Text: ");
                var yourtext =
                    Console.ReadLine();
                Console.WriteLine(yourtext);
            }
            Console.WriteLine("Press enter to exit from console...");
            var exit =
               Console.ReadLine();
        }
    }
}
