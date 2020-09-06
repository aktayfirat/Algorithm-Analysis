using System;
using System.Diagnostics;

namespace ConsoleApp1
{
    class Program
    {
        static int[] InsertSort(int[] dizi)
        {                                                   // O     | Ω
            Boolean eklendi;                               
            int deger, uzunluk = dizi.Length; ;            
            for (int i = 0; i < uzunluk; i++)               // n     | n
            {
                deger = dizi[i];                            
                eklendi = false;                            
                for (int j = i-1; j >= 0 && !eklendi;)      // n * n | n
                {
                    if (deger < dizi[j])
                    {
                        dizi[j + 1] = dizi[j];
                        j--;
                        dizi[j + 1] = deger;
                    }
                    else
                        eklendi = true;
                }
            }
            return dizi;
        }

        static int[] BoubleSort(int[] dizi)
        {                                                   // O     | Ω
            int deger, uzunluk = dizi.Length;              
            for (int i = 0; i < uzunluk; i++)               // n     | n
            {
                for (int j = uzunluk - 1; j >= 1; j--)      // n * n | n
                {
                    if (dizi[j - 1] > dizi[j]) 
                    {
                        deger = dizi[j];
                        dizi[j] = dizi[j - 1];
                        dizi[j - 1] = deger;
                    }
                    
                }
            }
            return dizi;
        }
        static int Factoryel(int N)
        {                                                    // O     | Ω
            if (N <= 1)                                      // n     | 1
            {
                return 1;                                      
            }
            else
                return N * Factoryel(N - 1);                 // n-1    | 0
        }
        static int BinarySearch(int[] sayilar, int arananSayi)
        {                                                    // O     | Ω
            int baslangic = 0, bitis = sayilar.Length - 1, orta;
            while (baslangic <= bitis)                      // n logn | 1
            {
                orta = (baslangic + bitis) / 2;
                if (sayilar[orta] > arananSayi)
                {
                    bitis = orta - 1;
                }
                else if (sayilar[orta] < arananSayi)
                {
                    baslangic = orta + 1;
                }
                else
                {
                    return orta;
                }
            }
            return -1;
        }
        static int fibonacci_dinamik_programlama(int kacinci)
        {                                                     // O     | Ω
            int[] fibonacci_sayilari = new int[kacinci];
            for (int i = 0; i <= kacinci-1; ++i)                // n     | n
            {
                if (i == 0 || i == 1)
                {
                    fibonacci_sayilari[0] = 1; fibonacci_sayilari[1] = 1;
                }
                else
                {
                    fibonacci_sayilari[i] = fibonacci_sayilari[i - 1] + fibonacci_sayilari[i - 2];
                }

            }
            return fibonacci_sayilari[kacinci-1];
        }
        static int[] CountingSort(int[] dizi)
        {                                                 // O     | Ω
            int uzunluk = dizi.Length, deger;
            int[] say = new int[uzunluk];
            for (int i = 0; i < uzunluk; i++)             // n     | n
            {
                deger = dizi[i];
                say[deger]++;
            }

            for (int i = 1; i < uzunluk; i++)            // n     | n
            {
                say[i] = say[i] + say[i - 1];
            }

            int[] sirali = new int[uzunluk];

            for (int i = uzunluk - 1; i >= 0; i--)       // n     | n
            {
                deger = dizi[i];
                int position = say[deger] - 1;
                sirali[position] = deger;
                say[deger]--;
            }
            return sirali;
        }
        static int[] BozoSort(int[] dizi)
        {                                                     // O     | Ω
            int slot1 = 0;
            int slot2 = 0;
            int ara;
            Random rand = new Random();
            while (!Siralimi(dizi))                           // ∞     | 1
            {
                slot1 = rand.Next(0, dizi.Length);
                slot2 = rand.Next(0, dizi.Length);

                ara = dizi[slot1];
                dizi[slot1] = dizi[slot2];
                dizi[slot2] = ara;
            }
            return dizi;
        }
        static bool Siralimi(int[] dizi)
        {
            for (int i = 0; i < dizi.Length - 1; i++)
            {
                if (dizi[i] > dizi[i + 1])
                {
                    return false;
                }
            }
            return true;
        }
        static void HeapSort(int[] dizi)
        {                                                     // O      | Ω
            int uzunluk = dizi.Length;
            for (int i = uzunluk / 2 - 1; i >= 0; i--)        // n      | n
                heapify(dizi, uzunluk, i);                    // n logn | n logn
            for (int i = uzunluk - 1; i >= 0; i--)            // n      | n
            {
                int temp = dizi[0];
                dizi[0] = dizi[i];
                dizi[i] = temp;
                heapify(dizi, i, 0);                          // n logn | n logn
            }
        }
        static void heapify(int[] dizi, int n, int i)
        {
            int enbuyuk = i;
            int sol = 2 * i + 1;
            int sag = 2 * i + 2;
            if (sol < n && dizi[sol] > dizi[enbuyuk])
                enbuyuk = sol;
            if (sag < n && dizi[sag] > dizi[enbuyuk])
                enbuyuk = sag;
            if (enbuyuk != i)
            {
                int gecici = dizi[i];
                dizi[i] = dizi[enbuyuk];
                dizi[enbuyuk] = gecici;
                heapify(dizi, n, enbuyuk);
            }
        }
        static int[] SelectionSort(int[] dizi)
        {                                                   // θ     | Ω
            int uzunluk = dizi.Length;
            for (int i = 0; i < uzunluk - 1; i++)           // n     | n
            {
                for (int j = i + 1; j < uzunluk; j++)       // n * n | n * n
                {
                    if (dizi[(j)] < dizi[(i)])
                    {
                        int degistir = dizi[(j)];
                        dizi[(j)] = dizi[(i)];
                        dizi[(i)] = degistir;
                    }

                }
            }
            return dizi;
        }
        static int[] ShellSort(int[] dizi)
        {                                                   // O     | Ω
            int n = dizi.Length;                           
            for (int gap = n / 2; gap > 0; gap /= 2)        // n     | 1
            {
                for (int i = gap; i < n; i += 1)            // n     | n
                {
                    int temp = dizi[i];                    
                    int j;                                 
                    for (j = i; j >= gap && dizi[j - gap] > temp; j -= gap)
                        dizi[j] = dizi[j - gap];

                    dizi[j] = temp;
                }
            }
            return dizi;
        }
        static int LineerSearch(int[] sayilar, int arananSayi)
        {                                                   // O     | Ω
            for (int i = 0; i < sayilar.Length; i++)
            {
                if (sayilar[i] == arananSayi) 
                {
                    return i;
                }
            }
            return -1;
        }
        static void DiziYaz(int[] dizi)
        {

            for (int i = 0; i < dizi.Length; i++)
            {
                Console.WriteLine(dizi[i]);
            }
        }
        public static long GetMiliseconds()
        {
            double timestamp = Stopwatch.GetTimestamp();
            double miliseconds = 1_000_000_000 * timestamp / Stopwatch.Frequency;

            return (long)miliseconds;
        }
        static int[] DiziUret(int eleman, Boolean rastgele)
        {   // Verilen eleman sayısına göre büyükten kücüğe sıralı dizi üretimi
            int[] dizi = new int[eleman];

            for (int i = eleman - 1; i >= 0; i--)
            {
                dizi[i] = rastgele ? new Random().Next(eleman) : i;
            }
            return dizi;
        }
        static int[] DiziTersCevir(int[] dizi)
        {   // Verilen dizinin elamanlarını tersten sıralama
            int uzunluk = dizi.Length;
            int[] temp = new int[uzunluk];
            for (int i = 0; i < uzunluk; i++)
            {
                temp[i] = dizi[uzunluk - i - 1];
            }
            return temp;
        }
        static void Main(string[] args) {

            long onceki_zaman;
            // 100 sıralı,sırasız, ve ters sıralı diziler oluşturuldu
            int[] sirali_dizi = DiziUret(1000, false);
            int[] ters_sirali = DiziTersCevir(sirali_dizi);
            int[] rastgele_sirali = DiziUret(1000, false);
            onceki_zaman = GetMiliseconds();
           // Bu satırda ölçülmek istenen algoritma kullanılacak..
            Console.WriteLine("En iyi durum için harcanan süre: "
                + (GetMiliseconds() - onceki_zaman) + " ms");

            onceki_zaman = GetMiliseconds();
            // Bu satırda ölçülmek istenen algoritma kullanılacak..
            Console.WriteLine("Ortalama durum için harcanan süre: "
                + (GetMiliseconds() - onceki_zaman) + " ms");

            onceki_zaman = GetMiliseconds();
            // Bu satırda ölçülmek istenen algoritma kullanılacak..
            Console.WriteLine("En kötü durum için harcanan süre: "
                + (GetMiliseconds() - onceki_zaman) + " ms");
            // Algoritma analizi için ön görülen hesaplama yapılıp konsola yazılacak.
            Console.ReadKey();
        }
    }
}
