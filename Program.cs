using System;

namespace varioustests
{
    class Program
    {
        static void Main(string[] args)
        {
            bool showMenu = true;
            while (showMenu)
            {
                showMenu = MainMenu();
            }
        }
        private static bool MainMenu()
        {
            Console.Clear();
            Console.WriteLine("");
            Console.WriteLine("1) 【税抜　→　税込】");
            Console.WriteLine("2) 【税込　→　税抜】");
            Console.WriteLine("3) 終了");

            switch (Console.ReadLine())
            {
                case "1":
                    Taxtotal();
                    return true;
                case "2":
                    Taxremoval();
                    return true;
                case "3":
                    return false;
                default:
                    return true;
            }
        }

        static void Taxtotal()
        {
            double tax1;
            double tax2;
            double sagaku1;
            double sagaku2;

            Console.Write("（税抜）金額: ");
            double money = double.Parse(Console.ReadLine());
            Console.WriteLine(""); //Just an empty line
            tax1 = 1.08 * money;
            Console.WriteLine("8% 税込金額: {0:C}", tax1);
            sagaku1 = tax1 - money;
            Console.WriteLine("差額: {0:C}", sagaku1);
            Console.WriteLine(""); //Just an empty line
            tax2 = 1.10 * money;
            Console.WriteLine("10% 税込金額: {0:C}", tax2);
            sagaku2 = tax2 - money;
            Console.WriteLine("差額: {0:C}", sagaku2);
            Console.WriteLine(""); //Just an empty line
            Console.WriteLine("戻るにはエンターを押してください");
            Console.ReadLine();
        }

        static void Taxremoval()
        {
            double tax1;
            double tax2;
            double sagaku1;
            double sagaku2;

            Console.Write("（税込）金額: ");
            double money = double.Parse(Console.ReadLine());
            Console.WriteLine(""); //Just an empty line
            tax1 = money / 1.08;
            Console.WriteLine("8% 税抜金額: {0:C}", tax1);
            sagaku1 = money - tax1;
            Console.WriteLine("差額: {0:C}", sagaku1);
            Console.WriteLine(""); //Just an empty line
            tax2 = money / 1.10;
            Console.WriteLine("10% 税抜金額: {0:C}", tax2);
            sagaku2 = money - tax2;
            Console.WriteLine("差額: {0:C}", sagaku2);
            Console.WriteLine(""); //Just an empty line
            Console.WriteLine("戻るにはエンターを押してください");
            Console.ReadLine();
        }

    }
}
