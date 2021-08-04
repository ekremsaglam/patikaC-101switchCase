using System;

namespace switchCase
{
    class Program
    {
        static void Main(string[] args)
        {
            int month =DateTime.Now.Month;

            switch (month)
            {
                case 1:
                    Console.WriteLine("Ocak");
                    break;
                case 2:
                    Console.WriteLine("Şubat");
                    break;
                case 3:
                    Console.WriteLine("Mart");
                    break;
                case 8:
                    Console.WriteLine("Ağustos");
                    break;
            }

            switch (month){

                case 12:
                case 1:
                case 2:
                    Console.WriteLine("Kış ayındasınız");
                    break;
                case 6:
                case 7:
                case 8:
                    Console.WriteLine("Yaz ayındasınız");
                    break;
                    

            }
        }
    }
}
