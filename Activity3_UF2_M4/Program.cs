namespace Activity3_UF2_M4
{
    internal class Program
    {
        static void Main(string[] args)
        {

            ConsoleKeyInfo Tecla;
            do
            {
                Console.Clear();
                ShowOptions();
                Tecla = Console.ReadKey();
                Console.Clear();
                switch (Tecla.Key)
                {
                    case ConsoleKey.D1: DoLeap(); break;
                    case ConsoleKey.D2: DoOddOrEven(); break;
                    case ConsoleKey.D3: DoTry2ReadValidTimeStamp(); break;
                    case ConsoleKey.D4: DoReadAValidTimeStamp(); break;
                    case ConsoleKey.D5: DoEnterValidDate(); break;
                    case ConsoleKey.D6: DoTry2EnterValidDate(); break;
                    case ConsoleKey.D7: DoMCD(); break;
                    case ConsoleKey.D8: DoGenerateHulukuluBulukulu(); break;
                    case ConsoleKey.D9: DoSumOfDigits(); break;
                
                    default:
                        MsgNextScreen("Error.Prem una tecla per tornar al menu..."); break;
                }

            }
            while (Tecla.Key != ConsoleKey.D0);
        }
        private static void ShowOptions()
        {
            Console.WriteLine("1. DoLeap");
            Console.WriteLine("2. DoOddOrEven");
            Console.WriteLine("3. DoTry2ReadValidTimeStamp");
            Console.WriteLine("4. DoReadAValidTimeStamp");
            Console.WriteLine("5. DoEnterValidDate");
            Console.WriteLine("6. DoTry2EnterValidDate");
            Console.WriteLine("7. DoMCD");
            Console.WriteLine("8. DoGenerateHulukuluBulukulu");
            Console.WriteLine("9. DoSumOfDigits");
            Console.WriteLine("A. AverageOfDataFile");
            Console.WriteLine("0. Exit");
        }

    }
}
