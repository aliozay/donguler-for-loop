﻿
// //Ekrandan girilen sayıya kadar olan tek sayıları yazdır.
// System.Console.Write("Lütfen bir sayı giriniz.");
// int sayac = int.Parse(Console.ReadLine());

// for (int i = 1; i <= sayac; i++)

// {
// if(i%2 == 1)
//     System.Console.WriteLine(i);

// }
// //1-1000 arasındaki tek ve çift sayıların toplamını ekrana yazdır.
// int tekToplam = 0;
// int ciftToplam = 0;
// for (int i = 1; i <= 1000; i++)
// {
//     if(i%2 == 1)
//        tekToplam += i; // tekToplam = tekToplam + i;
//     else   
//        ciftToplam += i; // ciftToplam = ciftToplam +i;
// }

// System.Console.WriteLine("Tek Toplam:" + tekToplam);
// System.Console.WriteLine("Çift Toplam" + ciftToplam);

//break, continue

// // for (int i = 1; i < 10; i++)
// {
//     if(i==4)
//         break;
//     Console.WriteLine(i);


// }

for (int i = 1; i < 10; i++)
{
    if(i==4)
        continue;
    Console.WriteLine(i);


}