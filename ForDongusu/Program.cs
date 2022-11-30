using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForDongusu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Faktöriyelini Hesaplamak İstediğiniz Sayıyı giriniz :");
            string kullaniciDeger = Console.ReadLine();

            int sayi1 = Convert.ToInt32(kullaniciDeger);
            int faktoriyel = 1;

            for (int i = sayi1; i >= 1; i--)
            {
                faktoriyel *= i;
            }
            Console.WriteLine(kullaniciDeger + " Değerinin Faktöriyelin sonucu : "+ faktoriyel  );

            Console.ReadLine();
        }
    }
}
