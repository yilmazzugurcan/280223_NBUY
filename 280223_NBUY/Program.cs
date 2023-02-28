using System;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;

namespace _280223_NBUY
{
    internal class Program
    {
        static void Main(string[] args)
        {


            #region 1000kere atılan zardan tekrar edenleri yazdırma
            /*int = 0, iki = 0, uc = 0, dort = 0, bes = 0, alti = 0;
              Random rnd = new Random();
              for (int i = 0; i < 1000; i++)
              {

                  int a = rnd.Next(1, 7);
                  if (a == 1)
                  {
                      bir++;
                  }
                  else if (a == 2)
                  {
                      iki++;
                  }
                  else if (a == 3)
                  {
                      uc++;
                  }
                  else if (a == 4)
                  {
                      dort++;
                  }
                  else if (a == 5)
                  {
                      bes++;
                  }
                  else
                  {
                      alti++;
                  }


              }
              Console.WriteLine("1 için" + " " + bir);
              Console.WriteLine("2 için" + " " + iki);
              Console.WriteLine("3 için" + " " + uc);
              Console.WriteLine("4 için" + " " + dort);
              Console.WriteLine("5 için" + " " + bes);
              Console.WriteLine("6 için" + " " + alti);
              Console.WriteLine(bir * 1 + iki * 2 + uc * 3 + dort * 4 + bes * 5 + alti * 6);*/
            #endregion

            #region hersayi%10frenyapanarachesabı
            /* double hız = 100;
             Console.WriteLine("Kaç Saniye Frene Basacaksınız : ");
             int fren = Convert.ToInt32(Console.ReadLine());

             for (int i = 0; i < fren; i++)

             {
                 hız = hız - (hız * 0.1);


             }

             Console.WriteLine("Frenlenmiş Hız" + " " + hız); */
            #endregion

            #region iç içe for çarpım tablosu
            /* for (int i = 1; i < 11; i++)
              {
                  for (int j = 1; j < 10; j++)
                  {
                      Console.Write(i+"*"+j+"="+(i*j)+"\t");

                  }
                  Console.WriteLine();
              }*/
            #endregion

            #region ÇarpımTablosu Farklı Yöntem
            /* for (int a = 1; a <= 10; a++)
             {
                 for (int b = 1; b <= 5; b++)
                 {
                     Console.Write(b + "x" + a + "=" + (a * b) + "\t");
                 }
                 Console.WriteLine();
             }
             Console.Write("------------------------------------------------------------------------------------");
             Console.Write("\n");
             for (int a = 1; a <= 10; a++)
             {
                 for (int b = 6; b <= 10; b++)
                 {
                     Console.Write(b + "x" + a + "=" + (a * b) + "\t");
                 }
                 Console.WriteLine();
             }
             Console.ReadLine(); */
            #endregion

            #region Kullanıcının Girdiği Kadar Yıldızı Sıra yazdırma
            /* int a, b;
             Console.WriteLine("Kaç Yıldız Görülsün");
             a = Convert.ToInt32(Console.ReadLine());
             Console.WriteLine("Kaç Sıra Olsun");
             b = Convert.ToInt32(Console.ReadLine());


             for (int i = 0; i < b; i++)
             {
                 for (int j = 0; j < a; j++)
                 {
                     Console.Write("*");
                 }
                 Console.WriteLine("");
             } */
            #endregion

            #region Üçgen Çizimi
            /*  int b;

              Console.WriteLine("Kaç Sıra Olsun");
              b = Convert.ToInt32(Console.ReadLine());


              for (int i = 0; i < b; i++)
              {
                  for (int j = 0; j <= i; j++)
                  {
                      Console.Write("*");
                  }
                  Console.Write("\n");
              } */
            #endregion

            #region for ile baklava çizme
            /* Console.WriteLine("Satır sayısı\n");
             int row = int.Parse(Console.ReadLine());
             int space = row;

             for (int i = 0; i <= row; i++)
             {
                 for (int b = space; b >= 1; b--)
                 {
                     Console.Write(" ");
                 }
                 for (int j = 0; j <= i; j++)
                 {
                     Console.Write("* ");
                 }
                 Console.Write("\n");
                 space--;
             }

             for (int i = row - 1; i >= 0; i--)
             {
                 for (int b = space + 2; b >= 1; b--)
                 {
                     Console.Write(" ");
                 }
                 for (int j = 0; j <= i; j++)
                 {
                     Console.Write("* ");
                 }
                 Console.Write("\n");

                 space++;
             } */
            #endregion

            #region baklava çizimi farklı yazım
            /* int num_1 = 0;
             Console.Write("sayı gir:");
             Console.WriteLine();
             num_1 = int.Parse(Console.ReadLine());
             for (int i = 0; i < num_1; i++)
             {
                 for (int z = num_1; z > i + 1; z--)
                 {
                     Console.Write(" ");
                 }
                 for (int j = 0; j <= i; j++)
                 {
                     Console.Write("* ");
                 }
                 Console.WriteLine();
             }

             for (int i = 1; i < num_1; i++)
             {
                 for (int z = 1; z < i + 1; z++)
                 {
                     Console.Write(" ");
                 }
                 for (int j = num_1; j > i; j--)
                 {
                     Console.Write("* ");
                 }
                 Console.WriteLine();
             } */
            #endregion

            #region Karo Baklava
            /* Console.Write("Baklava dilimi boyut yazını: ");
             int boyut = int.Parse(Console.ReadLine());
             for (int i = 0; i < boyut; i++)
             {
                 for (int j = boyut; j > i; j--)
                 {
                     Console.Write(" ");
                 }
                 for (int k = 0; k < i; k++)
                 {
                     Console.Write("*" + " ");
                 }
                 Console.WriteLine(" ");
             }
             for (int i = 0; i < boyut; i++)
             {
                 for (int j = 0; j < i; j++)
                 {
                     Console.Write(" ");
                 }
                 for (int k = boyut; k > i; k--)
                 {
                     Console.Write("*" + " ");
                 }
                 Console.WriteLine(" ");
             }*/

            #endregion

            #region while 10 kere isim yazdırma
            /* string ad;
             int x = 0;
             Console.WriteLine("Adınızı Girin:");
             ad = Console.ReadLine();
             Console.WriteLine("\t");
             while (x < 10)
             {

                 Console.WriteLine(ad);
                 x++;

             } */
            #endregion

            #region Kullanıcı Kelimesini İstediği Adette Yazdırma
            /*int x, y = 0;
            string kelime;
            Console.WriteLine("Kelime Girin :");
            kelime = Console.ReadLine();
            Console.WriteLine("Kaç Kere Yazılsın :");
            x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            while (y < x)
            {
                Console.WriteLine(kelime);
                y++;
            } */
            #endregion

            #region 1-10 Arasını yazdırma ve toplamını yazdırma
            /* int toplam = 0, i = 1;

             while (i < 10)
             {
                 Console.WriteLine(i);
                 toplam += i;
                 i++;
             }
             Console.WriteLine("Sayıların Toplamı" + toplam); */
            #endregion

            #region 1-50 Arası Tek Sayıları Yazdırma ve Toplamını Bulma;
          /* int toplam = 0, i = 1;

            while (i < 50)

            {
                Console.WriteLine(i);
                toplam += i;
                i = i + 2;
            }


            Console.WriteLine("Sayıların Toplamı :"+" "+toplam); */
            #endregion




        }
    }
}
