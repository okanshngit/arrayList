using System;
using System.Collections;
using System.Collections.Generic;

namespace arrayList
{
    class Program
    {
        static void Main(string[] args)
        {
            //Sytem.Collctions

                ArrayList liste = new ArrayList();
                liste.Add(8);
                liste.Add("Okan");
                liste.Add(true);
                liste.Add('A');


                Console.WriteLine(liste[1]);


                //AddRange birden fazla elemanı toplu halde ekleme.

                string[] renkler = {"Kırmızı","Sarı"};
                liste.AddRange(renkler);

                List<int> sayilar = new List<int>(){1,5,6,78};

                liste.AddRange(sayilar);

                //Sorting
                    sayilar.Sort();

                //Reverse
                    liste.Reverse();

                // Clear
                    liste.Clear();

                



                






        }
    }
}
