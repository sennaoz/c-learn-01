using System;
namespace TurDonusumleri
{

 class Program
    {
        static void Main(string[] args)

        {
            Console.WriteLine("yas giriniz:");
            string kullaniciyas = Console.ReadLine();//kullanıcıdan alınan değer string olur

            int kullaniciyasInt = int.Parse(kullaniciyas);
            int kullaniciyasInt2 = Convert.ToInt32(kullaniciyas);


            Console.WriteLine(kullaniciyasInt);

            Console.WriteLine(kullaniciyasInt2);

            Console.ReadLine();

            


        }
    }
}
