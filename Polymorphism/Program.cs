using System;

namespace Polymorphism
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*  interfacelerin veya base class ların implemente ya da inherit edildikleri sınıfların 
                referansını tutma özelliğinden dolayı 
                biz o interface üzerinden farklı implementasyonlara geçebiliyoruz.
            */

            CizimManager manager = new CizimManager(new Triangle());
            manager.Ciz();






        }

        interface IDraw
        {
            void Draw();
        }

        class Rectengular : IDraw
        {
            public void Draw()
            {
                Console.WriteLine("Dikdörtgen Çizildi");
            }
        }

        class Triangle : IDraw
        {
            public void Draw()
            {
                Console.WriteLine("üçgen Çizildi");
            }
        }


        class CizimManager
        {
            private IDraw _sekil;
            public CizimManager(IDraw sekil)
            {
                _sekil = sekil;
            }

            public void Ciz()
            {
                _sekil.Draw();
            }
        }
    }
}
