using System;

namespace Loops3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bir sayı limiti giriniz: ");

            int userInput = Convert.ToInt32(Console.ReadLine());

            int sayac_ = 0;

            do
            {
                Console.WriteLine("Ben Patika'lıyım");
                sayac_++;
            } while (sayac_ <= userInput);

            //while (sayac_ <= userInput)
            //{
            //    Console.WriteLine("Ben Patika'lıyım");
            //    sayac_++;
            //}

            //do-While döngüsünde sayaçtan daha küçük bir değer girdiğimde bile sadece 1 kez "ben patika'lıyım" yazdırdı ama while döngüsünde koşul yanlış olduğu için hiç kodu başlatmadı. Bu da bize koşul yanlış olsa bile do-While döngüsünün bir kez çalıştığını gösteriyor
        }
    }
}