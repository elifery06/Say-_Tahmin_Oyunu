using System;

namespace sayitahminoyunu
{
    class Program
    {
        static void Main(string[] args)
        {
            int tahmin = 0;
            int hafiza;
            int sayac = 0;
            Random rastgele = new Random();
            //1 dahil 100 dahil değil
            hafiza = rastgele.Next(1, 10);
            while (tahmin != hafiza)
            {
                sayac++;
                Console.WriteLine("Sayı girin:");
                tahmin = Convert.ToInt16(Console.ReadLine());
                if (tahmin>hafiza)
                {
                    Console.WriteLine("daha küçük sayı girin");

                }
                else if (tahmin<hafiza)
                {
                    Console.WriteLine("daha büyük bir sayı girin");
                }
            }
            Console.WriteLine("tebrikleeeerrrrr!!!!!");
                Console.WriteLine("{0}.deneme de buldunuz!",sayac);
            Console.ReadLine();
        }
    }
}
