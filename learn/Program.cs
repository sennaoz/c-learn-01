using System;
namespace ifelse
{

 class Program
    {
        static void Main(string[] args)

        {
            Console.WriteLine("ogrenci not gir:");
            string not = Console.ReadLine();
            int notint = Convert.ToInt32(not);
            if (notint>50)
            {
                Console.WriteLine("ögrenci dersten geçti");
            }
            else
            {
                Console.WriteLine("ögrenci dersten kaldı");
            }

            Console.WriteLine();

            Console.ReadLine();

            


        }
    }
}
