using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
namespace ArrayListUyg
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList liste = new ArrayList();

            do
            {
                Console.WriteLine("Menü: \n\n1-Değer Ekle \n2-Değer Listele \n3-Değer Ara \n4-Değer Düzenle \n5-Değer Sil \n6-Uygulama Çıkış");
                int kul = Convert.ToInt32(Console.ReadLine());

                switch (kul)
                {
                    case 1:
                        Console.Clear();
                        Console.WriteLine("Lütfen Eklemek İstediğiniz Değeri Giriniz:");
                        liste.Add(Console.ReadLine());
                        

                        break;

                    case 2:
                        Console.Clear();
                        Console.WriteLine("Değerler Listeleniyor.");
                        foreach (var item in liste)
                        {
                            Console.WriteLine(item);
                        }
                        break;

                    case 3:
                        Console.Clear();
                        Console.WriteLine("Aramak istediğiniz değeri giriniz:");
                        object arama = Console.ReadLine();
                        if (liste.Contains(arama))
                        {
                            int indexDegeri = liste.IndexOf(arama);
                            Console.WriteLine("Aradığınız değerin indeksi: " + indexDegeri);

                        }

                        else
                        {
                            Console.WriteLine("Böyle bir değeryoktur.");
                            Console.WriteLine("Bu değeri listeye ekleyelim mi? E/H");
                            string ekstra = Console.ReadLine();
                            ekstra.ToLower();
                            if (ekstra == "e")
                            {
                                liste.Add(arama);
                            }
                        }
                        break;

                    case 4:
                        Console.Clear();
                        for (int i = 0; i < liste.Count; i++)
                        {
                            Console.WriteLine(i+1 +"." + liste[i]);
                        }
                        Console.WriteLine("Düzenlemek istediğiniz değerin indexini giriniz:");
                        int index = Convert.ToInt32(Console.ReadLine());
                        liste.RemoveAt(index - 1);
                        Console.WriteLine("Yeni Değeri Giriniz:");
                        int yeniDeger = Convert.ToInt32(Console.ReadLine());
                        liste[index - 1]=(yeniDeger);


                        break;

                    case 5:
                        Console.Clear();
                        for (int i = 0; i < liste.Count; i++)
                        {
                            Console.WriteLine(i + 1 + "." + liste[i]);
                        }
                        Console.WriteLine("Silmek istediğiniz değerinin indexini yazınız:");
                        int degerSilme = Convert.ToInt32(Console.ReadLine());
                        liste.RemoveAt(degerSilme);
                        break;

                    case 6:
                        Console.Clear();
                        Console.WriteLine("Uygulamadan çıkıyorsunuz...");
                        System.Threading.Thread.Sleep(1000);
                        Environment.Exit(0);
                        break;

                    default:
                        break;
                }

            } while (true);
            

               
        }
    }
}
