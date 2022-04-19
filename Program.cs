using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _85._5DersListsOrnek //Bu ornekte Insan classi olusturup, bu classtan ornekler (i1,i2,i3) olusturup (instance)
{                              // bu ornekleri List ozeligiyle listeye ekledik. Boylece nesneye yonelik guzel bir uygulama oldu...
    class Program
    {
        class Insan
        {
            public string Name { get; set; }
        }
        static void Main(string[] args)
        {
            Insan i1 = new Insan();
            Insan i2 = new Insan();
            Insan i3 = new Insan();
            List <Insan> insanlar = new List<Insan>();

            insanlar.Add(i1);
            insanlar.Add(i2);
            insanlar.Add(i3);

            i1.Name = "Muhammet";
            i2.Name = "Murat";
            i3.Name = "Pala";

            foreach (var item in insanlar)
            {
                Console.WriteLine(item.Name);
            }

        }
    }
}
