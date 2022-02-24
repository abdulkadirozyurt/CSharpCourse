using System;
using System.Collections.Generic;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> sehirler = new List<string>();
            sehirler.Add("Ankara");

            Console.WriteLine(sehirler.Count);



            MyList<string> sehirler2 = new MyList<string>();
            sehirler2.Add("Ankara");
            sehirler2.Add("Trabzon");
            sehirler2.Add("Ankara");
            sehirler2.Add("Trabzon"); 
            sehirler2.Add("Ankara");
            sehirler2.Add("Trabzon");

            Console.WriteLine(sehirler2.Count);

        }






    }

    class MyList<T>    // Generic class ---> bunun çalışma tipi T
    {
        T[] _array;
        T[] _temparray;

        public MyList()
        {
            _array = new T[0]; /*sıfır elemanlı bir array yapmış oldum. List'i newlediğim anda sıfır elemanlı bir array oluşur.
                               Biz de MyList'i newleyince sıfır elemanlı oluşsun diye yazdık. */

        }


        public void Add(T item) // sıfır elemanlı bir array olduğu için her eklemede eleman sayısını 1 artırmalıyız
        {
            _temparray = _array;
            _array = new T[_array.Length + 1]; // eleman sayısını artırırsak tümü gider. yeni eleman eklemesi yaparken newlemek gerekiyor ancak newleyince eskisi gidiyor.

            // emanet verdiğimizi geri alacağız şimdi.

            for (int i = 0; i < _temparray.Length; i++)
            {
                _array[i] = _temparray[i];
            }

            _array[_array.Length - 1] = item;   // bizim gönderdiğimiz item son elemanı verdik.
        }



        public int Count
        {
            get
            {
                return _array.Length;
            }

        }



    }


}
