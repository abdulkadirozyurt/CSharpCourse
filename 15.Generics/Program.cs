using System;
using System.Collections.Generic;
using System.Linq;

namespace _15.Generics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> sehirler1 = new List<string>();

            MyList<string> sehirler2 = new MyList<string>();
            sehirler2.Add("ankara");
            sehirler2.Add("istanbul");
            sehirler2.Add("izmir");
            Console.WriteLine(sehirler2.Count);



        }
    }

    class MyList<T>
    {
        T[] _array;
        T[] _tempArray;

        public MyList()
        {
            _array = new T[0];
        }

        public void Add(T item)
        {
            _tempArray = _array;                    // yedeklendi
            _array = new T[_tempArray.Length + 1];  // dizinin eleman sayısı eskisine göre 1 artırıldı.

            for(int i=0;i< _tempArray.Length; i++)
            {
                // yedekteki elemanlar tek tek ana diziye aktarıldı
                _array[i]=_tempArray[i];
            }

            // dizinin eleman sayısının bir eksiği olan indeksteki yani boş olan yere, yeni eklenen öğe koyuldu
            // yani son elemana item eklendi
            _array[_array.Length-1] = item;


        }

        public int Count { get => _array.Length; }
    }
}
