using System;

namespace ConsoleApp15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            byte chosen = 0;
            int sayac = 1;
            for (int i = 0; i < sayac; i++)
            {

            Console.WriteLine("(1) Roma Rakamlarıyla yazılmış sayıyı Latin sayısına döndürmek için 1 yazın ve onaylayın");
            Console.WriteLine("(2) Latin Rakamlarıyla yazılmış sayıyı Roma sayısına döndürmek için 2 yazın ve onaylayın");
            try
            {
                chosen = byte.Parse(Console.ReadLine());
            }
            catch 
            {
                Console.WriteLine("\nGeçerli bir seçim yapın\n");
                sayac++;
                    continue;
            }
            switch (chosen)
            {
                case 1:
                    Console.WriteLine("Lütfen dönüştürmek istediğiniz Roma Sayısını girin");
                    string romanNumeral = Console.ReadLine();
                    int result = RomansToLatins.RomansToLatinsMeth(romanNumeral);
                        if (result == -1)
                        {
                            Console.WriteLine("\nRoma rakamlarıyla yazılan sayıda 4 tane aynı roma rakamı peşpeşe gelemez!\n");
                            sayac++;
                            continue;
                        }
                    Console.WriteLine(result);

                    break;
                case 2:
                    Console.WriteLine("Lütfen dönüştürmek istediğiniz Roma Sayısını girin");
                    int latinNumeral = int.Parse(Console.ReadLine());
                    if (latinNumeral >= 4000)
                    {
                        Console.WriteLine("Girdiğiniz sayı 1-3999 aralığında olmalıdır");
                        break;
                    }
                    string resultt = LatinToRomans.LatinToRomansMeth(latinNumeral);
                    Console.WriteLine(resultt);
                    break;
                default:
                    Console.WriteLine("Lütfen 1 veya 2 yi seçin");
                    sayac++;
                    break;
            }
            Console.WriteLine("Hesaplamadan çıkmak için quit yazıp onaylayın");
            string quit = Console.ReadLine();
            if (quit!="quit")
            {
                sayac++;
            }
            
            }
        }
    }
}
