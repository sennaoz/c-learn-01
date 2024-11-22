using System;
namespace operatorler
{

 class Program
    {
        static void Main(string[] args)

        {
            // ve operatörü && verilen tüm şartlar doğruysa true biri bile yanlışsa false
            int sayi1 = 10;
            int sayi2 = 20;
            bool kontrol = sayi1<sayi2 && sayi1>4; // kontrol et True   değilse False döndürür
           
                     
            Console.WriteLine(kontrol);
            
            
            Console.ReadLine();


        }
    }
}
