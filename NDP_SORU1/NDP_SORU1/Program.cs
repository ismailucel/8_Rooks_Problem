/****************************************************************************
**					SAKARYA ÜNİVERSİTESİ
**				BİLGİSAYAR VE BİLİŞİM BİLİMLERİ FAKÜLTESİ
**				    BİLGİSAYAR MÜHENDİSLİĞİ BÖLÜMÜ
**				   NESNEYE DAYALI PROGRAMLAMA DERSİ
**					2020-2021 BAHAR DÖNEMİ
**	
**				ÖDEV NUMARASI..........: 1     
**				ÖĞRENCİ ADI............: İsmail Üçel    
**				ÖĞRENCİ NUMARASI.......: G201210352
**              DERSİN ALINDIĞI GRUP...: 2.Öğretim A Grubu
****************************************************************************/






using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NDP_SORU1
   {
        class Program
        {
            static void Main(string[] args)
            {
                int[,] matrix = new int[8, 8]; // satranç tahtası için iki boyutlu 8*8 bir matrix oluşturuyoruz.
                matrix = matrixdeğerata(matrix); // matrixe başlangıç değeri olarak 0 atııyoruz.
                for (int i = 0; i < 8; i++)
                {
                    matrix = kalekoyma(matrix);  // matrixe random olarak 1 değerlerini atıyoruz
                }

                matrixyazdır(matrix); // matrixi yazdırıyoruz
            }
            static void matrixyazdır(int[,] matrix) // matrix yazdırma fonksiyonu
            {
                for (int i = 0; i < 8; i++)
                {
                    for (int j = 0; j < 8; j++)
                    {
                        Console.Write(matrix[i, j] + " "); // satranç tahtasındaki değerleri yazdırıyoruz
                    }

                

                Console.WriteLine(); // arada boşluk bırakmak için
                }

        }
            static int[,] matrixdeğerata(int[,] matrix) // matrixin tüm elemanlarına başlangıç değeri olarak 0 atama fonksiyonu
            {
                for (int i = 0; i < 8; i++)
                {
                    for (int j = 0; j < 8; j++)
                    {

                        matrix[i, j] = 0; // matrixin tüm elemanlarına 0 değerini atıyoruz


                }
                }
                return matrix;
            }
            static int[,] kalekoyma(int[,] matrix) //matrixin random elemanlarına 1 koymak için oluşturulan fonksiyon
            {
            bas:
                bool kontr = false;
                Random rast = new Random();
                int randomSatır = rast.Next(0, 8); //rastgele satır değeri oluşturuluyor
                int randomSutun = rast.Next(0, 8); //rastgele sütun değeri oluşturuluyor
                kontr = kontrol(matrix, randomSatır, randomSutun); //satır veya sütunda 1 değeri olup olmadığını kontrol ediyoruz
                if (kontr == true)
                {
                    goto bas; //satır veya sütunda 1 değeri varsa başa dönüp tekrar kontrol yapıyoruz
                }
            matrixyazdır(matrix); // her degeri atamadan önce matrixi tekrar yazdırıyoruz
            Console.WriteLine(); // bir satır boşluk bırakıyoruz
            System.Threading.Thread.Sleep(1000); //matris aralarına delay koyuyoruz
            matrix[randomSatır, randomSutun] = 1; // random matrix satır ve sütuna kontrollerden sonra 1 değerini atıyoruz
            
            return matrix;
            }
            static bool kontrol(int[,] matrix, int x, int y) //matrix satır veya sütununda 1 olup olmadığını kontrol edecek fonksiyon
            {
                bool kontr = false;
                for (int i = 0; i < 8; i++) //saturda ya da sütunda 1 varsa kontrol değişkeni true değerini döndürür 
                {
                    if (matrix[i, y] == 1)
                    {
                        kontr = true;
                    }
                    if (matrix[x, i] == 1) 
                    {
                        kontr = true;
                    }
                }
                return kontr;
            }
        }
    }


